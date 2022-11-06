// Created by Laila Shihada 764700695                   4th November 2022
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeaveMangementForm
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)     // Load the form.
        {
            CurrentTime_tmr.Start();                // Start the timer
            SubFormTitle_lbl.Text = "Leave Management";
        }

        private void CurrentTime_tmr_Tick(object sender, EventArgs e)       // Set the current day and time.
        {
            CurrentTime_lbl.Text = DateTime.Now.ToShortTimeString();
            CurrentDate_lbl.Text = DateTime.Now.ToLongDateString();
        }

        private void LeaveMg_Menu_btn_Click(object sender, EventArgs e)     // Click the Leave management Button
        {
            Bitmap B = new Bitmap(@"C:\Users\Laila\source\repos\LeaveMangementForm\Images\LeaveManagement_Click.png");  // Change the button image when click
            LeaveMg_Menu_btn.BackgroundImage = B;
            LeaveManagement LMF = new LeaveManagement() { TopLevel = false, TopMost = true };           // Load the leave management subform into the main frame.
            SubForm_pnl.Controls.Add(LMF);
            LMF.Show();
            
        }
    }
}
