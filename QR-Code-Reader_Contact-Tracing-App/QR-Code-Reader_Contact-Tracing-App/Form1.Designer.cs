
namespace QR_Code_Reader_Contact_Tracing_App
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboBxDevices = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.displayTxtBx = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxAddress = new System.Windows.Forms.TextBox();
            this.txtBxAge = new System.Windows.Forms.TextBox();
            this.txtBxGender = new System.Windows.Forms.TextBox();
            this.txtBxQuesOne = new System.Windows.Forms.TextBox();
            this.txtBxQuesTwo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBxQuesThree = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera:";
            // 
            // cboBxDevices
            // 
            this.cboBxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBxDevices.FormattingEnabled = true;
            this.cboBxDevices.Location = new System.Drawing.Point(33, 55);
            this.cboBxDevices.Name = "cboBxDevices";
            this.cboBxDevices.Size = new System.Drawing.Size(323, 21);
            this.cboBxDevices.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(33, 97);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(445, 407);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(33, 526);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(213, 44);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // displayTxtBx
            // 
            this.displayTxtBx.Location = new System.Drawing.Point(400, 25);
            this.displayTxtBx.Multiline = true;
            this.displayTxtBx.Name = "displayTxtBx";
            this.displayTxtBx.Size = new System.Drawing.Size(78, 53);
            this.displayTxtBx.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(270, 526);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 44);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "S&top";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(570, 61);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(100, 20);
            this.txtBxName.TabIndex = 6;
            // 
            // txtBxAddress
            // 
            this.txtBxAddress.Location = new System.Drawing.Point(570, 116);
            this.txtBxAddress.Name = "txtBxAddress";
            this.txtBxAddress.Size = new System.Drawing.Size(100, 20);
            this.txtBxAddress.TabIndex = 6;
            // 
            // txtBxAge
            // 
            this.txtBxAge.Location = new System.Drawing.Point(845, 55);
            this.txtBxAge.Name = "txtBxAge";
            this.txtBxAge.Size = new System.Drawing.Size(100, 20);
            this.txtBxAge.TabIndex = 6;
            // 
            // txtBxGender
            // 
            this.txtBxGender.Location = new System.Drawing.Point(845, 110);
            this.txtBxGender.Name = "txtBxGender";
            this.txtBxGender.Size = new System.Drawing.Size(100, 20);
            this.txtBxGender.TabIndex = 6;
            // 
            // txtBxQuesOne
            // 
            this.txtBxQuesOne.Location = new System.Drawing.Point(526, 238);
            this.txtBxQuesOne.Name = "txtBxQuesOne";
            this.txtBxQuesOne.Size = new System.Drawing.Size(100, 20);
            this.txtBxQuesOne.TabIndex = 6;
            // 
            // txtBxQuesTwo
            // 
            this.txtBxQuesTwo.Location = new System.Drawing.Point(526, 367);
            this.txtBxQuesTwo.Name = "txtBxQuesTwo";
            this.txtBxQuesTwo.Size = new System.Drawing.Size(100, 20);
            this.txtBxQuesTwo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(804, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(788, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(351, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Have you traveled outside the country anytime from last month until now?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(526, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(348, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Have you come into contact with anyone who has traveled outside your ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(526, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "country between the period of last month until now?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(526, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(335, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Do you currently have any of the following conditions during this time?";
            // 
            // txtBxQuesThree
            // 
            this.txtBxQuesThree.Location = new System.Drawing.Point(526, 474);
            this.txtBxQuesThree.Multiline = true;
            this.txtBxQuesThree.Name = "txtBxQuesThree";
            this.txtBxQuesThree.Size = new System.Drawing.Size(419, 96);
            this.txtBxQuesThree.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 594);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxQuesThree);
            this.Controls.Add(this.txtBxQuesTwo);
            this.Controls.Add(this.txtBxQuesOne);
            this.Controls.Add(this.txtBxGender);
            this.Controls.Add(this.txtBxAge);
            this.Controls.Add(this.txtBxAddress);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.displayTxtBx);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cboBxDevices);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing App Using QR Code";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBxDevices;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox displayTxtBx;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxAddress;
        private System.Windows.Forms.TextBox txtBxAge;
        private System.Windows.Forms.TextBox txtBxGender;
        private System.Windows.Forms.TextBox txtBxQuesOne;
        private System.Windows.Forms.TextBox txtBxQuesTwo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBxQuesThree;
    }
}

