namespace TempSensorForm
{
    partial class TempSensorForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboCom = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.StatusSquare = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonTempUnit = new System.Windows.Forms.Button();
            this.buttonScreen = new System.Windows.Forms.Button();
            this.buttonMode = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.lcd = new System.Windows.Forms.TextBox();
            this.ledC1 = new System.Windows.Forms.Panel();
            this.ledC3 = new System.Windows.Forms.Panel();
            this.ledC2 = new System.Windows.Forms.Panel();
            this.ledC7 = new System.Windows.Forms.Panel();
            this.ledC5 = new System.Windows.Forms.Panel();
            this.ledC4 = new System.Windows.Forms.Panel();
            this.ledC6 = new System.Windows.Forms.Panel();
            this.ledD5 = new System.Windows.Forms.Panel();
            this.ledD4 = new System.Windows.Forms.Panel();
            this.ledD6 = new System.Windows.Forms.Panel();
            this.ledD7 = new System.Windows.Forms.Panel();
            this.ledD2 = new System.Windows.Forms.Panel();
            this.ledD3 = new System.Windows.Forms.Panel();
            this.ledD1 = new System.Windows.Forms.Panel();
            this.ledU5 = new System.Windows.Forms.Panel();
            this.ledU4 = new System.Windows.Forms.Panel();
            this.ledU6 = new System.Windows.Forms.Panel();
            this.ledU7 = new System.Windows.Forms.Panel();
            this.ledU2 = new System.Windows.Forms.Panel();
            this.ledU3 = new System.Windows.Forms.Panel();
            this.ledU1 = new System.Windows.Forms.Panel();
            this.ledF5 = new System.Windows.Forms.Panel();
            this.ledF4 = new System.Windows.Forms.Panel();
            this.ledF6 = new System.Windows.Forms.Panel();
            this.ledF7 = new System.Windows.Forms.Panel();
            this.ledF2 = new System.Windows.Forms.Panel();
            this.ledF3 = new System.Windows.Forms.Panel();
            this.ledF1 = new System.Windows.Forms.Panel();
            this.ledDot = new System.Windows.Forms.Panel();
            this.displayBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.displayBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboCom
            // 
            this.comboCom.FormattingEnabled = true;
            this.comboCom.Location = new System.Drawing.Point(55, 21);
            this.comboCom.Name = "comboCom";
            this.comboCom.Size = new System.Drawing.Size(82, 21);
            this.comboCom.TabIndex = 0;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(152, 20);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // StatusSquare
            // 
            this.StatusSquare.BackColor = System.Drawing.Color.Red;
            this.StatusSquare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusSquare.Location = new System.Drawing.Point(239, 21);
            this.StatusSquare.Name = "StatusSquare";
            this.StatusSquare.Size = new System.Drawing.Size(21, 21);
            this.StatusSquare.TabIndex = 2;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(297, 20);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonTempUnit
            // 
            this.buttonTempUnit.Enabled = false;
            this.buttonTempUnit.Location = new System.Drawing.Point(18, 24);
            this.buttonTempUnit.Name = "buttonTempUnit";
            this.buttonTempUnit.Size = new System.Drawing.Size(75, 36);
            this.buttonTempUnit.TabIndex = 4;
            this.buttonTempUnit.Text = "Fahrenheit";
            this.buttonTempUnit.UseVisualStyleBackColor = true;
            this.buttonTempUnit.Click += new System.EventHandler(this.buttonTempUnit_Click);
            // 
            // buttonScreen
            // 
            this.buttonScreen.Enabled = false;
            this.buttonScreen.Location = new System.Drawing.Point(18, 73);
            this.buttonScreen.Name = "buttonScreen";
            this.buttonScreen.Size = new System.Drawing.Size(75, 36);
            this.buttonScreen.TabIndex = 5;
            this.buttonScreen.Text = "Display";
            this.buttonScreen.UseVisualStyleBackColor = true;
            this.buttonScreen.Click += new System.EventHandler(this.buttonScreen_Click);
            // 
            // buttonMode
            // 
            this.buttonMode.Enabled = false;
            this.buttonMode.Location = new System.Drawing.Point(18, 121);
            this.buttonMode.Name = "buttonMode";
            this.buttonMode.Size = new System.Drawing.Size(75, 36);
            this.buttonMode.TabIndex = 6;
            this.buttonMode.Text = "Manual";
            this.buttonMode.UseVisualStyleBackColor = true;
            this.buttonMode.Click += new System.EventHandler(this.buttonMode_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Enabled = false;
            this.buttonRead.Location = new System.Drawing.Point(18, 171);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 36);
            this.buttonRead.TabIndex = 7;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // lcd
            // 
            this.lcd.BackColor = System.Drawing.Color.LimeGreen;
            this.lcd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lcd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lcd.Cursor = System.Windows.Forms.Cursors.Default;
            this.lcd.Enabled = false;
            this.lcd.Font = new System.Drawing.Font("LilyUPC", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcd.ForeColor = System.Drawing.SystemColors.Control;
            this.lcd.Location = new System.Drawing.Point(6, 19);
            this.lcd.Multiline = true;
            this.lcd.Name = "lcd";
            this.lcd.ReadOnly = true;
            this.lcd.Size = new System.Drawing.Size(254, 64);
            this.lcd.TabIndex = 8;
            this.lcd.Text = "DATALOGGER\r\nSENAI";
            this.lcd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcd.WordWrap = false;
            // 
            // ledC1
            // 
            this.ledC1.BackColor = System.Drawing.Color.LightGray;
            this.ledC1.Location = new System.Drawing.Point(13, 31);
            this.ledC1.Name = "ledC1";
            this.ledC1.Size = new System.Drawing.Size(9, 28);
            this.ledC1.TabIndex = 9;
            // 
            // ledC3
            // 
            this.ledC3.BackColor = System.Drawing.Color.LightGray;
            this.ledC3.Location = new System.Drawing.Point(51, 31);
            this.ledC3.Name = "ledC3";
            this.ledC3.Size = new System.Drawing.Size(9, 28);
            this.ledC3.TabIndex = 10;
            // 
            // ledC2
            // 
            this.ledC2.BackColor = System.Drawing.Color.LightGray;
            this.ledC2.Location = new System.Drawing.Point(18, 20);
            this.ledC2.Name = "ledC2";
            this.ledC2.Size = new System.Drawing.Size(37, 10);
            this.ledC2.TabIndex = 10;
            // 
            // ledC7
            // 
            this.ledC7.BackColor = System.Drawing.Color.LightGray;
            this.ledC7.Location = new System.Drawing.Point(18, 60);
            this.ledC7.Name = "ledC7";
            this.ledC7.Size = new System.Drawing.Size(37, 10);
            this.ledC7.TabIndex = 11;
            // 
            // ledC5
            // 
            this.ledC5.BackColor = System.Drawing.Color.LightGray;
            this.ledC5.Location = new System.Drawing.Point(18, 100);
            this.ledC5.Name = "ledC5";
            this.ledC5.Size = new System.Drawing.Size(37, 10);
            this.ledC5.TabIndex = 14;
            // 
            // ledC4
            // 
            this.ledC4.BackColor = System.Drawing.Color.LightGray;
            this.ledC4.Location = new System.Drawing.Point(51, 71);
            this.ledC4.Name = "ledC4";
            this.ledC4.Size = new System.Drawing.Size(9, 28);
            this.ledC4.TabIndex = 13;
            // 
            // ledC6
            // 
            this.ledC6.BackColor = System.Drawing.Color.LightGray;
            this.ledC6.Location = new System.Drawing.Point(13, 71);
            this.ledC6.Name = "ledC6";
            this.ledC6.Size = new System.Drawing.Size(9, 28);
            this.ledC6.TabIndex = 12;
            // 
            // ledD5
            // 
            this.ledD5.BackColor = System.Drawing.Color.LightGray;
            this.ledD5.Location = new System.Drawing.Point(78, 100);
            this.ledD5.Name = "ledD5";
            this.ledD5.Size = new System.Drawing.Size(37, 10);
            this.ledD5.TabIndex = 21;
            // 
            // ledD4
            // 
            this.ledD4.BackColor = System.Drawing.Color.LightGray;
            this.ledD4.Location = new System.Drawing.Point(111, 71);
            this.ledD4.Name = "ledD4";
            this.ledD4.Size = new System.Drawing.Size(9, 28);
            this.ledD4.TabIndex = 20;
            // 
            // ledD6
            // 
            this.ledD6.BackColor = System.Drawing.Color.LightGray;
            this.ledD6.Location = new System.Drawing.Point(73, 71);
            this.ledD6.Name = "ledD6";
            this.ledD6.Size = new System.Drawing.Size(9, 28);
            this.ledD6.TabIndex = 19;
            // 
            // ledD7
            // 
            this.ledD7.BackColor = System.Drawing.Color.LightGray;
            this.ledD7.Location = new System.Drawing.Point(78, 60);
            this.ledD7.Name = "ledD7";
            this.ledD7.Size = new System.Drawing.Size(37, 10);
            this.ledD7.TabIndex = 18;
            // 
            // ledD2
            // 
            this.ledD2.BackColor = System.Drawing.Color.LightGray;
            this.ledD2.Location = new System.Drawing.Point(78, 20);
            this.ledD2.Name = "ledD2";
            this.ledD2.Size = new System.Drawing.Size(37, 10);
            this.ledD2.TabIndex = 16;
            // 
            // ledD3
            // 
            this.ledD3.BackColor = System.Drawing.Color.LightGray;
            this.ledD3.Location = new System.Drawing.Point(111, 31);
            this.ledD3.Name = "ledD3";
            this.ledD3.Size = new System.Drawing.Size(9, 28);
            this.ledD3.TabIndex = 17;
            // 
            // ledD1
            // 
            this.ledD1.BackColor = System.Drawing.Color.LightGray;
            this.ledD1.Location = new System.Drawing.Point(73, 31);
            this.ledD1.Name = "ledD1";
            this.ledD1.Size = new System.Drawing.Size(9, 28);
            this.ledD1.TabIndex = 15;
            // 
            // ledU5
            // 
            this.ledU5.BackColor = System.Drawing.Color.LightGray;
            this.ledU5.Location = new System.Drawing.Point(138, 100);
            this.ledU5.Name = "ledU5";
            this.ledU5.Size = new System.Drawing.Size(37, 10);
            this.ledU5.TabIndex = 28;
            // 
            // ledU4
            // 
            this.ledU4.BackColor = System.Drawing.Color.LightGray;
            this.ledU4.Location = new System.Drawing.Point(171, 71);
            this.ledU4.Name = "ledU4";
            this.ledU4.Size = new System.Drawing.Size(9, 28);
            this.ledU4.TabIndex = 27;
            // 
            // ledU6
            // 
            this.ledU6.BackColor = System.Drawing.Color.LightGray;
            this.ledU6.Location = new System.Drawing.Point(133, 71);
            this.ledU6.Name = "ledU6";
            this.ledU6.Size = new System.Drawing.Size(9, 28);
            this.ledU6.TabIndex = 26;
            // 
            // ledU7
            // 
            this.ledU7.BackColor = System.Drawing.Color.LightGray;
            this.ledU7.Location = new System.Drawing.Point(138, 60);
            this.ledU7.Name = "ledU7";
            this.ledU7.Size = new System.Drawing.Size(37, 10);
            this.ledU7.TabIndex = 25;
            // 
            // ledU2
            // 
            this.ledU2.BackColor = System.Drawing.Color.LightGray;
            this.ledU2.Location = new System.Drawing.Point(138, 20);
            this.ledU2.Name = "ledU2";
            this.ledU2.Size = new System.Drawing.Size(37, 10);
            this.ledU2.TabIndex = 23;
            // 
            // ledU3
            // 
            this.ledU3.BackColor = System.Drawing.Color.LightGray;
            this.ledU3.Location = new System.Drawing.Point(171, 31);
            this.ledU3.Name = "ledU3";
            this.ledU3.Size = new System.Drawing.Size(9, 28);
            this.ledU3.TabIndex = 24;
            // 
            // ledU1
            // 
            this.ledU1.BackColor = System.Drawing.Color.LightGray;
            this.ledU1.Location = new System.Drawing.Point(133, 31);
            this.ledU1.Name = "ledU1";
            this.ledU1.Size = new System.Drawing.Size(9, 28);
            this.ledU1.TabIndex = 22;
            // 
            // ledF5
            // 
            this.ledF5.BackColor = System.Drawing.Color.LightGray;
            this.ledF5.Location = new System.Drawing.Point(211, 100);
            this.ledF5.Name = "ledF5";
            this.ledF5.Size = new System.Drawing.Size(37, 10);
            this.ledF5.TabIndex = 35;
            // 
            // ledF4
            // 
            this.ledF4.BackColor = System.Drawing.Color.LightGray;
            this.ledF4.Location = new System.Drawing.Point(244, 71);
            this.ledF4.Name = "ledF4";
            this.ledF4.Size = new System.Drawing.Size(9, 28);
            this.ledF4.TabIndex = 34;
            // 
            // ledF6
            // 
            this.ledF6.BackColor = System.Drawing.Color.LightGray;
            this.ledF6.Location = new System.Drawing.Point(206, 71);
            this.ledF6.Name = "ledF6";
            this.ledF6.Size = new System.Drawing.Size(9, 28);
            this.ledF6.TabIndex = 33;
            // 
            // ledF7
            // 
            this.ledF7.BackColor = System.Drawing.Color.LightGray;
            this.ledF7.Location = new System.Drawing.Point(211, 60);
            this.ledF7.Name = "ledF7";
            this.ledF7.Size = new System.Drawing.Size(37, 10);
            this.ledF7.TabIndex = 32;
            // 
            // ledF2
            // 
            this.ledF2.BackColor = System.Drawing.Color.LightGray;
            this.ledF2.Location = new System.Drawing.Point(211, 20);
            this.ledF2.Name = "ledF2";
            this.ledF2.Size = new System.Drawing.Size(37, 10);
            this.ledF2.TabIndex = 30;
            // 
            // ledF3
            // 
            this.ledF3.BackColor = System.Drawing.Color.LightGray;
            this.ledF3.Location = new System.Drawing.Point(244, 31);
            this.ledF3.Name = "ledF3";
            this.ledF3.Size = new System.Drawing.Size(9, 28);
            this.ledF3.TabIndex = 31;
            // 
            // ledF1
            // 
            this.ledF1.BackColor = System.Drawing.Color.LightGray;
            this.ledF1.Location = new System.Drawing.Point(206, 31);
            this.ledF1.Name = "ledF1";
            this.ledF1.Size = new System.Drawing.Size(9, 28);
            this.ledF1.TabIndex = 29;
            // 
            // ledDot
            // 
            this.ledDot.BackColor = System.Drawing.Color.LightGray;
            this.ledDot.Location = new System.Drawing.Point(188, 100);
            this.ledDot.Name = "ledDot";
            this.ledDot.Size = new System.Drawing.Size(11, 11);
            this.ledDot.TabIndex = 36;
            // 
            // displayBox
            // 
            this.displayBox.BackColor = System.Drawing.SystemColors.Control;
            this.displayBox.Controls.Add(this.ledD4);
            this.displayBox.Controls.Add(this.ledDot);
            this.displayBox.Controls.Add(this.ledC1);
            this.displayBox.Controls.Add(this.ledF5);
            this.displayBox.Controls.Add(this.ledC3);
            this.displayBox.Controls.Add(this.ledF4);
            this.displayBox.Controls.Add(this.ledC2);
            this.displayBox.Controls.Add(this.ledF6);
            this.displayBox.Controls.Add(this.ledC7);
            this.displayBox.Controls.Add(this.ledF7);
            this.displayBox.Controls.Add(this.ledC6);
            this.displayBox.Controls.Add(this.ledF2);
            this.displayBox.Controls.Add(this.ledC4);
            this.displayBox.Controls.Add(this.ledF3);
            this.displayBox.Controls.Add(this.ledC5);
            this.displayBox.Controls.Add(this.ledF1);
            this.displayBox.Controls.Add(this.ledD1);
            this.displayBox.Controls.Add(this.ledU5);
            this.displayBox.Controls.Add(this.ledD3);
            this.displayBox.Controls.Add(this.ledU4);
            this.displayBox.Controls.Add(this.ledD2);
            this.displayBox.Controls.Add(this.ledU6);
            this.displayBox.Controls.Add(this.ledD7);
            this.displayBox.Controls.Add(this.ledU7);
            this.displayBox.Controls.Add(this.ledD6);
            this.displayBox.Controls.Add(this.ledU2);
            this.displayBox.Controls.Add(this.ledD5);
            this.displayBox.Controls.Add(this.ledU3);
            this.displayBox.Controls.Add(this.ledU1);
            this.displayBox.Location = new System.Drawing.Point(12, 182);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(266, 119);
            this.displayBox.TabIndex = 37;
            this.displayBox.TabStop = false;
            this.displayBox.Text = "Display";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lcd);
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 94);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LCD";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboCom);
            this.groupBox3.Controls.Add(this.buttonConnect);
            this.groupBox3.Controls.Add(this.StatusSquare);
            this.groupBox3.Controls.Add(this.buttonStart);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 54);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Setup";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonScreen);
            this.groupBox4.Controls.Add(this.buttonTempUnit);
            this.groupBox4.Controls.Add(this.buttonMode);
            this.groupBox4.Controls.Add(this.buttonRead);
            this.groupBox4.Location = new System.Drawing.Point(291, 76);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(111, 225);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Controls";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Portas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Status:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(57, 312);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(123, 13);
            this.StatusLabel.TabIndex = 43;
            this.StatusLabel.Text = "Waiting connection port.";
            // 
            // TempSensorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 334);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.displayBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TempSensorForm";
            this.Text = "Temperature Sensor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TempSensorForm_FormClosed);
            this.Load += new System.EventHandler(this.TempSensorForm_Load);
            this.displayBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCom;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Panel StatusSquare;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonTempUnit;
        private System.Windows.Forms.Button buttonScreen;
        private System.Windows.Forms.Button buttonMode;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.TextBox lcd;
        private System.Windows.Forms.Panel ledC1;
        private System.Windows.Forms.Panel ledC3;
        private System.Windows.Forms.Panel ledC2;
        private System.Windows.Forms.Panel ledC7;
        private System.Windows.Forms.Panel ledC5;
        private System.Windows.Forms.Panel ledC4;
        private System.Windows.Forms.Panel ledC6;
        private System.Windows.Forms.Panel ledD5;
        private System.Windows.Forms.Panel ledD4;
        private System.Windows.Forms.Panel ledD6;
        private System.Windows.Forms.Panel ledD7;
        private System.Windows.Forms.Panel ledD2;
        private System.Windows.Forms.Panel ledD3;
        private System.Windows.Forms.Panel ledD1;
        private System.Windows.Forms.Panel ledU5;
        private System.Windows.Forms.Panel ledU4;
        private System.Windows.Forms.Panel ledU6;
        private System.Windows.Forms.Panel ledU7;
        private System.Windows.Forms.Panel ledU2;
        private System.Windows.Forms.Panel ledU3;
        private System.Windows.Forms.Panel ledU1;
        private System.Windows.Forms.Panel ledF5;
        private System.Windows.Forms.Panel ledF4;
        private System.Windows.Forms.Panel ledF6;
        private System.Windows.Forms.Panel ledF7;
        private System.Windows.Forms.Panel ledF2;
        private System.Windows.Forms.Panel ledF3;
        private System.Windows.Forms.Panel ledF1;
        private System.Windows.Forms.Panel ledDot;
        private System.Windows.Forms.GroupBox displayBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StatusLabel;
    }
}

