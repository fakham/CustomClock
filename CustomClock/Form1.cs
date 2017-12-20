using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomClock
{
    public partial class Form1 : Form
    {
        DateTime now;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTime();
            UpdateDate();
        }

        private void UpdateTime() 
        {
            now = DateTime.Now;
            label_time.Text = now.ToString("hh:mm:ss");
            label_am_pm.Text = now.ToString("tt");

            if (now.Hour == 0)
                UpdateDate();
        }

        private void UpdateDate()
        {
            label_day.Text = now.Day.ToString();
            label_month.Text = now.ToString("MMM");
            label_year.Text = now.Year.ToString();
            label_dayName.Text = now.ToString("dddd");
        }

        private void timer_time_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }
    }
}
