﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
         );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width,panel3.Height, 30, 30));
            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            Title.Text = btnDashboard.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
          /* Dashboard button -----------------------------------------------------------------------*/
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            Title.Text = btnDashboard.Text;
        }
        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }
          /* Dashboard btn end here -----------------------------------------------------------------*/
        private void btnUsers_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnUsers.Height;
            PnlNav.Top = btnUsers.Top;
            PnlNav.Left = btnUsers.Left;
            btnUsers.BackColor = Color.FromArgb(46, 51, 73);
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            Title.Text = btnUsers.Text;
        }

        private void btnUsers_Leave(object sender, EventArgs e)
        {
            btnUsers.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnReports.Height;
            PnlNav.Top = btnReports.Top;
            PnlNav.Left = btnReports.Left;
            btnReports.BackColor = Color.FromArgb(46, 51, 73);
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            Title.Text = btnReports.Text;
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnCalender.Height;
            PnlNav.Top = btnCalender.Top;
            PnlNav.Left = btnCalender.Left;
            btnCalender.BackColor = Color.FromArgb(46, 51, 73);
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            Title.Text = btnCalender.Text;
        }

        private void btnReports_Leave(object sender, EventArgs e)
        {
            btnReports.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCalender_Leave(object sender, EventArgs e)
        {
            btnCalender.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnSetting.Height;
            PnlNav.Top = btnSetting.Top;
            PnlNav.Left = btnSetting.Left;
            btnSetting.BackColor = Color.FromArgb(46, 51, 73);
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            Title.Text = btnSetting.Text;
        }

        private void btnSetting_Leave(object sender, EventArgs e)
        {
            btnSetting.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //
        }

    }
}
