namespace CustomClock
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label_time = new System.Windows.Forms.Label();
            this.label_am_pm = new System.Windows.Forms.Label();
            this.label_day = new System.Windows.Forms.Label();
            this.label_year = new System.Windows.Forms.Label();
            this.label_month = new System.Windows.Forms.Label();
            this.label_dayName = new System.Windows.Forms.Label();
            this.timer_time = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(135, 145);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.label_am_pm);
            this.splitContainer1.Panel1.Controls.Add(this.label_time);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.splitContainer1.Panel2.Controls.Add(this.label_dayName);
            this.splitContainer1.Panel2.Controls.Add(this.label_month);
            this.splitContainer1.Panel2.Controls.Add(this.label_year);
            this.splitContainer1.Panel2.Controls.Add(this.label_day);
            this.splitContainer1.Size = new System.Drawing.Size(237, 133);
            this.splitContainer1.SplitterDistance = 64;
            this.splitContainer1.TabIndex = 0;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.Location = new System.Drawing.Point(19, 10);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(174, 46);
            this.label_time.TabIndex = 0;
            this.label_time.Text = "10:14:20";
            // 
            // label_am_pm
            // 
            this.label_am_pm.AutoSize = true;
            this.label_am_pm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_am_pm.Location = new System.Drawing.Point(184, 34);
            this.label_am_pm.Name = "label_am_pm";
            this.label_am_pm.Size = new System.Drawing.Size(28, 17);
            this.label_am_pm.TabIndex = 1;
            this.label_am_pm.Text = "PM";
            // 
            // label_day
            // 
            this.label_day.AutoSize = true;
            this.label_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_day.ForeColor = System.Drawing.Color.White;
            this.label_day.Location = new System.Drawing.Point(3, 2);
            this.label_day.Name = "label_day";
            this.label_day.Size = new System.Drawing.Size(87, 63);
            this.label_day.TabIndex = 0;
            this.label_day.Text = "20";
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_year.ForeColor = System.Drawing.Color.White;
            this.label_year.Location = new System.Drawing.Point(75, 35);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(45, 20);
            this.label_year.TabIndex = 1;
            this.label_year.Text = "2014";
            // 
            // label_month
            // 
            this.label_month.AutoSize = true;
            this.label_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_month.ForeColor = System.Drawing.Color.White;
            this.label_month.Location = new System.Drawing.Point(75, 8);
            this.label_month.Name = "label_month";
            this.label_month.Size = new System.Drawing.Size(35, 20);
            this.label_month.TabIndex = 2;
            this.label_month.Text = "Jan";
            // 
            // label_dayName
            // 
            this.label_dayName.AutoSize = true;
            this.label_dayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dayName.ForeColor = System.Drawing.Color.Black;
            this.label_dayName.Location = new System.Drawing.Point(116, 20);
            this.label_dayName.Name = "label_dayName";
            this.label_dayName.Size = new System.Drawing.Size(101, 26);
            this.label_dayName.TabIndex = 3;
            this.label_dayName.Text = "Thursday";
            // 
            // timer_time
            // 
            this.timer_time.Enabled = true;
            this.timer_time.Tick += new System.EventHandler(this.timer_time_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 422);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label_am_pm;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_dayName;
        private System.Windows.Forms.Label label_month;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.Label label_day;
        private System.Windows.Forms.Timer timer_time;
    }
}

