
namespace RS232
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDisConn = new System.Windows.Forms.Button();
            this.btnConn = new System.Windows.Forms.Button();
            this.txtConn = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnoff1 = new System.Windows.Forms.Button();
            this.btnon1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnoff2 = new System.Windows.Forms.Button();
            this.btnon2 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "BLUETOOTH ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnDisConn);
            this.groupBox1.Controls.Add(this.btnConn);
            this.groupBox1.Controls.Add(this.txtConn);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commuication Setup";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "COM Port";
            // 
            // btnDisConn
            // 
            this.btnDisConn.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisConn.Location = new System.Drawing.Point(129, 83);
            this.btnDisConn.Name = "btnDisConn";
            this.btnDisConn.Size = new System.Drawing.Size(78, 25);
            this.btnDisConn.TabIndex = 3;
            this.btnDisConn.Text = "Disconnect";
            this.btnDisConn.UseVisualStyleBackColor = true;
            this.btnDisConn.Click += new System.EventHandler(this.btnDisConn_Click);
            // 
            // btnConn
            // 
            this.btnConn.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConn.Location = new System.Drawing.Point(41, 83);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(82, 25);
            this.btnConn.TabIndex = 2;
            this.btnConn.Text = "Connect";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // txtConn
            // 
            this.txtConn.BackColor = System.Drawing.Color.LightCoral;
            this.txtConn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConn.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConn.ForeColor = System.Drawing.Color.Black;
            this.txtConn.Location = new System.Drawing.Point(90, 52);
            this.txtConn.Name = "txtConn";
            this.txtConn.ReadOnly = true;
            this.txtConn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConn.Size = new System.Drawing.Size(86, 25);
            this.txtConn.TabIndex = 1;
            this.txtConn.Text = "Disconnected!";
            this.txtConn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 32);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOff);
            this.groupBox2.Controls.Add(this.btnOn);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(10, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 89);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control LED1";
            // 
            // btnOff
            // 
            this.btnOff.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff.Location = new System.Drawing.Point(81, 59);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(74, 24);
            this.btnOff.TabIndex = 4;
            this.btnOff.Text = "STOP-1";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnOn
            // 
            this.btnOn.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOn.Location = new System.Drawing.Point(81, 21);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(74, 29);
            this.btnOn.TabIndex = 3;
            this.btnOn.Text = "START-1";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnoff1);
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Controls.Add(this.btnon1);
            this.groupBox4.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(175, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(166, 89);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Control LED2";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnoff1
            // 
            this.btnoff1.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoff1.Location = new System.Drawing.Point(86, 54);
            this.btnoff1.Name = "btnoff1";
            this.btnoff1.Size = new System.Drawing.Size(78, 25);
            this.btnoff1.TabIndex = 6;
            this.btnoff1.Text = "STOP-2";
            this.btnoff1.UseVisualStyleBackColor = true;
            this.btnoff1.Click += new System.EventHandler(this.btnoff1_Click);
            // 
            // btnon1
            // 
            this.btnon1.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnon1.Location = new System.Drawing.Point(86, 20);
            this.btnon1.Name = "btnon1";
            this.btnon1.Size = new System.Drawing.Size(78, 25);
            this.btnon1.TabIndex = 5;
            this.btnon1.Text = "START-2";
            this.btnon1.UseVisualStyleBackColor = true;
            this.btnon1.Click += new System.EventHandler(this.btnon1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnoff2);
            this.groupBox5.Controls.Add(this.pictureBox4);
            this.groupBox5.Controls.Add(this.btnon2);
            this.groupBox5.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(346, 135);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(169, 89);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Control LED3";
            // 
            // btnoff2
            // 
            this.btnoff2.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoff2.Location = new System.Drawing.Point(88, 51);
            this.btnoff2.Name = "btnoff2";
            this.btnoff2.Size = new System.Drawing.Size(76, 29);
            this.btnoff2.TabIndex = 8;
            this.btnoff2.Text = "STOP-3";
            this.btnoff2.UseVisualStyleBackColor = true;
            this.btnoff2.Click += new System.EventHandler(this.btnoff2_Click);
            // 
            // btnon2
            // 
            this.btnon2.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnon2.Location = new System.Drawing.Point(88, 22);
            this.btnon2.Name = "btnon2";
            this.btnon2.Size = new System.Drawing.Size(76, 27);
            this.btnon2.TabIndex = 7;
            this.btnon2.Text = "START-3";
            this.btnon2.UseVisualStyleBackColor = true;
            this.btnon2.Click += new System.EventHandler(this.btnon2_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(261, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 108);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Remote Control";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(130, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "MANUAL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(6, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "AUTO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBox3);
            this.groupBox6.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBox6.Location = new System.Drawing.Point(534, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(166, 197);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Lighting Status";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RS232.Properties.Resources.dusangr;
            this.pictureBox3.Location = new System.Drawing.Point(16, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 120);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::RS232.Properties.Resources.ledoff;
            this.pictureBox4.Location = new System.Drawing.Point(10, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RS232.Properties.Resources.ledoff;
            this.pictureBox2.Location = new System.Drawing.Point(10, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RS232.Properties.Resources.ledoff;
            this.pictureBox1.Location = new System.Drawing.Point(6, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 237);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RS232(COM) Comunication lab";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Info;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtConn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDisConn;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnoff1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnon1;
        private System.Windows.Forms.Button btnoff2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnon2;
        private System.Windows.Forms.Label label6;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

