namespace KU_Digital_Medi_File
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
            this.btn_stdentry = new System.Windows.Forms.Button();
            this.Student_Entry_level = new System.Windows.Forms.Label();
            this.Medi_File = new System.Windows.Forms.GroupBox();
            this.Doctors_schedule_level = new System.Windows.Forms.Label();
            this.btn_schedule = new System.Windows.Forms.Button();
            this.Medi_store_label = new System.Windows.Forms.Label();
            this.Doctors_Advice_button = new System.Windows.Forms.Button();
            this.Medi_Store_button = new System.Windows.Forms.Button();
            this.Doctors_Advice_level = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.updateStudentDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.date_lbl1 = new System.Windows.Forms.Label();
            this.time_lbl = new System.Windows.Forms.Label();
            this.day_lbl = new System.Windows.Forms.Label();
            this.Medi_File.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_stdentry
            // 
            this.btn_stdentry.BackgroundImage = global::KU_Digital_Medi_File.Properties.Resources.student;
            this.btn_stdentry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_stdentry.Location = new System.Drawing.Point(19, 49);
            this.btn_stdentry.Name = "btn_stdentry";
            this.btn_stdentry.Size = new System.Drawing.Size(125, 45);
            this.btn_stdentry.TabIndex = 0;
            this.btn_stdentry.UseVisualStyleBackColor = true;
            this.btn_stdentry.Click += new System.EventHandler(this.btn_stdentry_Click);
            // 
            // Student_Entry_level
            // 
            this.Student_Entry_level.AutoSize = true;
            this.Student_Entry_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Entry_level.Location = new System.Drawing.Point(16, 30);
            this.Student_Entry_level.Name = "Student_Entry_level";
            this.Student_Entry_level.Size = new System.Drawing.Size(82, 16);
            this.Student_Entry_level.TabIndex = 1;
            this.Student_Entry_level.Text = "Patient Entry";
            // 
            // Medi_File
            // 
            this.Medi_File.BackColor = System.Drawing.Color.Transparent;
            this.Medi_File.Controls.Add(this.Doctors_schedule_level);
            this.Medi_File.Controls.Add(this.btn_stdentry);
            this.Medi_File.Controls.Add(this.btn_schedule);
            this.Medi_File.Controls.Add(this.Student_Entry_level);
            this.Medi_File.Controls.Add(this.Medi_store_label);
            this.Medi_File.Controls.Add(this.Doctors_Advice_button);
            this.Medi_File.Controls.Add(this.Medi_Store_button);
            this.Medi_File.Controls.Add(this.Doctors_Advice_level);
            this.Medi_File.Location = new System.Drawing.Point(12, 27);
            this.Medi_File.Name = "Medi_File";
            this.Medi_File.Size = new System.Drawing.Size(192, 418);
            this.Medi_File.TabIndex = 2;
            this.Medi_File.TabStop = false;
            // 
            // Doctors_schedule_level
            // 
            this.Doctors_schedule_level.AutoSize = true;
            this.Doctors_schedule_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctors_schedule_level.Location = new System.Drawing.Point(16, 296);
            this.Doctors_schedule_level.Name = "Doctors_schedule_level";
            this.Doctors_schedule_level.Size = new System.Drawing.Size(68, 16);
            this.Doctors_schedule_level.TabIndex = 8;
            this.Doctors_schedule_level.Text = " Schedule";
            // 
            // btn_schedule
            // 
            this.btn_schedule.BackgroundImage = global::KU_Digital_Medi_File.Properties.Resources.bnmu;
            this.btn_schedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_schedule.Location = new System.Drawing.Point(19, 315);
            this.btn_schedule.Name = "btn_schedule";
            this.btn_schedule.Size = new System.Drawing.Size(123, 48);
            this.btn_schedule.TabIndex = 7;
            this.btn_schedule.UseVisualStyleBackColor = true;
            this.btn_schedule.Click += new System.EventHandler(this.btn_schedule_Click);
            // 
            // Medi_store_label
            // 
            this.Medi_store_label.AutoSize = true;
            this.Medi_store_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medi_store_label.Location = new System.Drawing.Point(16, 209);
            this.Medi_store_label.Name = "Medi_store_label";
            this.Medi_store_label.Size = new System.Drawing.Size(73, 16);
            this.Medi_store_label.TabIndex = 6;
            this.Medi_store_label.Text = "Medi Store";
            // 
            // Doctors_Advice_button
            // 
            this.Doctors_Advice_button.BackgroundImage = global::KU_Digital_Medi_File.Properties.Resources.Doctors;
            this.Doctors_Advice_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Doctors_Advice_button.Location = new System.Drawing.Point(19, 137);
            this.Doctors_Advice_button.Name = "Doctors_Advice_button";
            this.Doctors_Advice_button.Size = new System.Drawing.Size(127, 48);
            this.Doctors_Advice_button.TabIndex = 3;
            this.Doctors_Advice_button.UseVisualStyleBackColor = true;
            this.Doctors_Advice_button.Click += new System.EventHandler(this.Doctors_Advice_button_Click);
            // 
            // Medi_Store_button
            // 
            this.Medi_Store_button.BackgroundImage = global::KU_Digital_Medi_File.Properties.Resources._1d560d295d0a42ceb63346f7028f8583b502cddb_original1;
            this.Medi_Store_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Medi_Store_button.Location = new System.Drawing.Point(19, 225);
            this.Medi_Store_button.Name = "Medi_Store_button";
            this.Medi_Store_button.Size = new System.Drawing.Size(123, 47);
            this.Medi_Store_button.TabIndex = 5;
            this.Medi_Store_button.UseVisualStyleBackColor = true;
            this.Medi_Store_button.Click += new System.EventHandler(this.Medi_Store_button_Click);
            // 
            // Doctors_Advice_level
            // 
            this.Doctors_Advice_level.AutoSize = true;
            this.Doctors_Advice_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctors_Advice_level.Location = new System.Drawing.Point(16, 118);
            this.Doctors_Advice_level.Name = "Doctors_Advice_level";
            this.Doctors_Advice_level.Size = new System.Drawing.Size(100, 16);
            this.Doctors_Advice_level.TabIndex = 4;
            this.Doctors_Advice_level.Text = "Doctors Advice";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::KU_Digital_Medi_File.Properties.Resources.student;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(233, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 127);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::KU_Digital_Medi_File.Properties.Resources.Doctors;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(419, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 135);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::KU_Digital_Medi_File.Properties.Resources._1d560d295d0a42ceb63346f7028f8583b502cddb_original1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(599, 42);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 146);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::KU_Digital_Medi_File.Properties.Resources.bnmu;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(770, 61);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(133, 127);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::KU_Digital_Medi_File.Properties.Resources.footer_wave;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(210, 365);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(693, 101);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // updateStudentDatabaseToolStripMenuItem
            // 
            this.updateStudentDatabaseToolStripMenuItem.Name = "updateStudentDatabaseToolStripMenuItem";
            this.updateStudentDatabaseToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.updateStudentDatabaseToolStripMenuItem.Text = "Update Student Database";
            this.updateStudentDatabaseToolStripMenuItem.Click += new System.EventHandler(this.updateStudentDatabaseToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateStudentDatabaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(314, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "KU DIGITAL MEDI FILE";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // date_lbl1
            // 
            this.date_lbl1.AutoSize = true;
            this.date_lbl1.BackColor = System.Drawing.Color.Transparent;
            this.date_lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl1.Location = new System.Drawing.Point(791, 236);
            this.date_lbl1.Name = "date_lbl1";
            this.date_lbl1.Size = new System.Drawing.Size(35, 16);
            this.date_lbl1.TabIndex = 10;
            this.date_lbl1.Text = "date";
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.BackColor = System.Drawing.Color.Transparent;
            this.time_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_lbl.Location = new System.Drawing.Point(793, 301);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(33, 16);
            this.time_lbl.TabIndex = 11;
            this.time_lbl.Text = "time";
            // 
            // day_lbl
            // 
            this.day_lbl.AutoSize = true;
            this.day_lbl.BackColor = System.Drawing.Color.Transparent;
            this.day_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_lbl.Location = new System.Drawing.Point(791, 269);
            this.day_lbl.Name = "day_lbl";
            this.day_lbl.Size = new System.Drawing.Size(31, 16);
            this.day_lbl.TabIndex = 12;
            this.day_lbl.Text = "day";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::KU_Digital_Medi_File.Properties.Resources.Purple_blue_background_1150x1198;
            this.ClientSize = new System.Drawing.Size(915, 466);
            this.Controls.Add(this.day_lbl);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.date_lbl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Medi_File);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "KU Digital Medi File";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Medi_File.ResumeLayout(false);
            this.Medi_File.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_stdentry;
        private System.Windows.Forms.Label Student_Entry_level;
        private System.Windows.Forms.GroupBox Medi_File;
        private System.Windows.Forms.Button Doctors_Advice_button;
        private System.Windows.Forms.Label Doctors_Advice_level;
        private System.Windows.Forms.Button Medi_Store_button;
        private System.Windows.Forms.Label Medi_store_label;
        private System.Windows.Forms.Button btn_schedule;
        private System.Windows.Forms.Label Doctors_schedule_level;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ToolStripMenuItem updateStudentDatabaseToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label date_lbl1;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Label day_lbl;
    }
}

