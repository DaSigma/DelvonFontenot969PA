﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DelvonFontenot969PA
{
    public partial class AppointmentForm : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=3.227.166.251;user id=U04cRO;password=53688204070;persistsecurityinfo=True;database=U04cRO");
 
        static DateTime start;
        static DateTime end;
        static DateTime lowerLimit;
        static DateTime upperLimit;
        static DateTime apptStartTime;
        static DateTime apptEndTime;
        private int usrID;
        public int UsrID { get; set; }
        public AppointmentForm()
        {
            InitializeComponent();
            dtpEnd.Value = dTPStart.Value;
            this.btnDone.Click += (object sender, EventArgs e) =>
            {
                this.Hide();
                Scheduling schedulingScreen = new Scheduling();
                schedulingScreen.Show();
            }; // Lambda expression to create Done button click event
        }

        // Save appointment
        private void btnSaveApt_Click(object sender, EventArgs e)
        {
            // Convert times for validations
            string custName = cbCustName.Text.ToString();
            lowerLimit = Convert.ToDateTime((dTPStart.Value.ToString("yyyy-MM-dd") + (" 09:00")));
            upperLimit = Convert.ToDateTime((dTPStart.Value.ToString("yyyy-MM-dd") + (" 17:00")));
            apptStartTime = Convert.ToDateTime(dTPStart.Value.ToString("yyyy-MM-dd") + dTPStartTime.Value.ToString(" HH:mm"));
            apptEndTime = Convert.ToDateTime(dTPStart.Value.ToString("yyyy-MM-dd") + dTPEndTime.Value.ToString(" HH:mm"));

            try
            {
                //Validate times
                if ((BusinessHrsValidation()) && (FutureAppointmentValidation()) && (MeetingTimeValidation()))
                {
                    using (con)
                    {
                        int custID;
                        UsrID = usrID;

                        // Insert Appointment
                        string sp = "sp_insertAppt";
                        using (MySqlCommand cmd2 = new MySqlCommand(sp, con))
                        {
                            
                            apptStartTime = TimeZoneInfo.ConvertTimeToUtc(dTPStartTime.Value, TimeZoneInfo.Local);
                            apptEndTime = TimeZoneInfo.ConvertTimeToUtc(dTPEndTime.Value, TimeZoneInfo.Local);
                            string apptStart = dTPStart.Value.ToString("yyyy-MM-dd") + apptStartTime.ToString(" HH:mm");
                            string apptEnd = dTPStart.Value.ToString("yyyy-MM-dd") + apptEndTime.ToString(" HH:mm");
                            DateTime t1 = Convert.ToDateTime(apptStart);
                            DateTime t2 = Convert.ToDateTime(apptEnd);

                            string apptStartTimeTemp = dTPStartTime.Value.ToString(" HH:mm");
                            string apptEndTimeTemp = dTPEndTime.Value.ToString(" HH:mm");

                            con.Open();

                            // Get userID by name
                            MySqlCommand cmd4 = new MySqlCommand("sp_getUserIDbyName", con);
                            cmd4.CommandType = CommandType.StoredProcedure;
                            cmd4.Parameters.AddWithValue("@usrname", cbUsr.Text.ToString());
                            MySqlDataReader dr = cmd4.ExecuteReader();
                            if (dr.Read())
                            {
                                usrID = Convert.ToInt32(dr["userId"]);
                            }
                            dr.Close();

                            // Insert or update Appointment
                            start = Convert.ToDateTime(dTPStart.Value.ToString("yyyy-MM-dd") + dTPStartTime.Value.ToString(" HH:mm"));
                            end = Convert.ToDateTime(dTPStart.Value.ToString("yyyy-MM-dd") + dTPEndTime.Value.ToString(" HH:mm"));
                            MySqlCommand cmd3 = new MySqlCommand("sp_getUsrApptTimes", con);
                            cmd3.CommandType = CommandType.StoredProcedure;
                            cmd3.Parameters.AddWithValue("@usrID", usrID);
                            dr = cmd3.ExecuteReader();

                            while (dr.Read())
                            {
                                ChangeAID();
                                int AID = Convert.ToInt32(dr["AID"]);

                                if ((Scheduling.GetCorrectedDate(Convert.ToDateTime(dr["Start"])) <= start)
                                && (start <= Scheduling.GetCorrectedDate(Convert.ToDateTime(dr["End"]))))
                                {
                                    if (AID != Convert.ToInt32(lblApptID.Text))
                                    {
                                        string mtgStart = Scheduling.GetCorrectedDate(Convert.ToDateTime(dr["Start"])).ToString("hh:mm tt");
                                        string mtgEnd = Scheduling.GetCorrectedDate(Convert.ToDateTime(dr["End"])).ToString("hh:mm tt");
                                        string mtgDay = Scheduling.GetCorrectedDate(Convert.ToDateTime(dr["Start"])).ToString("MMMM dd, yyyy");
                                        char.ToUpper(cbUsr.Text[0]);
                                        MessageBox.Show($"Consultant {cbUsr.Text} already has a meeting from {mtgStart} to {mtgEnd} on {mtgDay}!");
                                        goto done;
                                    }
                                }
                            }
                            dr.Close();

                            //Get customerID by name
                            MySqlCommand cmd = new MySqlCommand("sp_getIDByName", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@custName", custName.ToString());
                            dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                {
                                    custID = Convert.ToInt32(dr["customerId"].ToString());
                                    cmd2.Connection = con;
                                    cmd2.CommandType = CommandType.StoredProcedure;
                                    cmd2.Parameters.AddWithValue("@apptID", lblApptID.Text.ToString());
                                    cmd2.Parameters.AddWithValue("@custID", custID);
                                    cmd2.Parameters.AddWithValue("@usrId", usrID);
                                    cmd2.Parameters.AddWithValue("@typeof", cbType.Text.ToString());

                                    cmd2.Parameters.AddWithValue("@startDate", t1.ToString("yyyy-MM-dd HH:mm"));//dTPStart.Value.ToString("yyyy-MM-dd"));

                                    cmd2.Parameters.AddWithValue("@endDate", t2.ToString("yyyy-MM-dd HH:mm"));
                                    DateTime lastUpdatedtimeUTC = DateTime.UtcNow;
                                    DateTime lastUpdatedtime;
                                    lastUpdatedtime = DateTime.SpecifyKind(lastUpdatedtimeUTC, DateTimeKind.Utc).ToLocalTime();
                                    cmd2.Parameters.AddWithValue("@lastUpdated", lastUpdatedtimeUTC.ToString("yyyy-MM-dd HH:mm"));
                                    dr.Close();
                                    cmd2.ExecuteNonQuery();
                                    MessageBox.Show("Appointment Saved!");
                                }
                            }
                            done:;
                            con.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// print error message
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            this.Hide();
            Scheduling schedulingScreen = new Scheduling();
            schedulingScreen.Show();

        }

        // Conditions for save button to be enabled
        private bool AllowSave()
        {
            if (((string.IsNullOrEmpty(cbCustName.Text)) || (string.IsNullOrEmpty(cbType.Text)) || (string.IsNullOrEmpty(cbUsr.Text))))
            {
                return false;
            }
            return true;
        }

        // Check if save button is enabled
        private void cbUsr_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnSaveApt.Enabled = AllowSave();
        }

        // Check if save button is enabled
        private void dTPStart_ValueChanged(object sender, EventArgs e)
        {
            dtpEnd.Value = dTPStart.Value;
        }

        // Check if save button is enabled
        private void cbCustName_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnSaveApt.Enabled = AllowSave();
        }

        // Validate the meeting starts befor ending
        private bool MeetingTimeValidation()
        {
            bool test = true;
            if (dTPStartTime.Value >= dTPEndTime.Value)
            {
                MessageBox.Show("Meeting start must be before meeting end!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                test = false;
            }
            return test;
            
        }

        // Validate new appointment is in the future
        private bool FutureAppointmentValidation()
        {
            DateTime apptStartTime = Convert.ToDateTime(dTPStart.Value.ToString("yyyy-MM-dd") + dTPStartTime.Value.ToString(" HH:mm"));
            bool test = true;
            if ((lblApptID.Text == "Auto Generated") && (apptStartTime <= DateTime.Now))
            {
                MessageBox.Show("New Appointments Must be Scheduled with a future Time/Date!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                test = false;
            }
            btnSaveApt.Enabled = AllowSave();
            return test;
        }

        // Validate appointment is within business hours
        private bool BusinessHrsValidation()
        {
            bool test = true;
            if ((((dTPStart.Value.DayOfWeek == DayOfWeek.Saturday) || (dtpEnd.Value.DayOfWeek == DayOfWeek.Saturday)) ||
                    ((dTPStart.Value.DayOfWeek == DayOfWeek.Sunday) || (dtpEnd.Value.DayOfWeek == DayOfWeek.Sunday))) ||
                    ((apptStartTime < lowerLimit) || (apptEndTime > upperLimit)))
            {

                MessageBox.Show("Out of Business Hrs, Please select a different time!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                test = false;
            }
            btnSaveApt.Enabled = AllowSave();
            return test;
        }

        // Handle type combobox textchange
        private void cbType_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbType.Text))
            {
                errorProvider1.SetError(cbType, "Please select Appointment Type!");
            }
            else
            {
                errorProvider1.SetError(cbType, null);
            }
            btnSaveApt.Enabled = AllowSave();
        }

        // Validate user combobox
        private void cbUsr_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbUsr.Text))
            {
                e.Cancel = true;
                cbUsr.Focus();
                errorProvider1.SetError(cbUsr, "Please select Consultant!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbUsr, null);
            }
        }

        // Change Appointment ID label text
        private void ChangeAID()
        {
            if (lblApptID.Text == "Auto Generated")
            {
                lblApptID.Text = "0";
            }
        }
    }
}
