namespace GPU_Temperature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.degree = new System.Windows.Forms.Label();
            this.understood = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.thermometer = new System.Windows.Forms.NotifyIcon(this.components);
            this.temperatureWarning = new System.Windows.Forms.NumericUpDown();
            this.timeWithSecond = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.read = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeWithSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "GPU Temperature: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label2.Location = new System.Drawing.Point(138, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = " °C";
            // 
            // degree
            // 
            this.degree.AutoSize = true;
            this.degree.Font = new System.Drawing.Font("Tahoma", 30F);
            this.degree.ForeColor = System.Drawing.Color.Green;
            this.degree.Location = new System.Drawing.Point(12, 65);
            this.degree.Name = "degree";
            this.degree.Size = new System.Drawing.Size(120, 48);
            this.degree.TabIndex = 2;
            this.degree.Text = "50.00";
            // 
            // understood
            // 
            this.understood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.understood.Font = new System.Drawing.Font("Tahoma", 16F);
            this.understood.ForeColor = System.Drawing.Color.Green;
            this.understood.Location = new System.Drawing.Point(277, 166);
            this.understood.Name = "understood";
            this.understood.Size = new System.Drawing.Size(75, 39);
            this.understood.TabIndex = 3;
            this.understood.Text = "OK";
            this.understood.UseVisualStyleBackColor = true;
            this.understood.Click += new System.EventHandler(this.Understood_Click);
            // 
            // close
            // 
            this.close.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Tahoma", 12F);
            this.close.Location = new System.Drawing.Point(277, 130);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 30);
            this.close.TabIndex = 4;
            this.close.TabStop = false;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // thermometer
            // 
            this.thermometer.BalloonTipText = "show";
            this.thermometer.Icon = ((System.Drawing.Icon)(resources.GetObject("thermometer.Icon")));
            this.thermometer.Text = "thermometer";
            this.thermometer.Visible = true;
            this.thermometer.Click += new System.EventHandler(this.Thermometer_Click);
            // 
            // temperatureWarning
            // 
            this.temperatureWarning.DecimalPlaces = 2;
            this.temperatureWarning.Location = new System.Drawing.Point(132, 188);
            this.temperatureWarning.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.temperatureWarning.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.temperatureWarning.Name = "temperatureWarning";
            this.temperatureWarning.Size = new System.Drawing.Size(72, 20);
            this.temperatureWarning.TabIndex = 5;
            this.temperatureWarning.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // timeWithSecond
            // 
            this.timeWithSecond.Location = new System.Drawing.Point(132, 159);
            this.timeWithSecond.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.timeWithSecond.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.timeWithSecond.Name = "timeWithSecond";
            this.timeWithSecond.Size = new System.Drawing.Size(72, 20);
            this.timeWithSecond.TabIndex = 6;
            this.timeWithSecond.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.timeWithSecond.ValueChanged += new System.EventHandler(this.TimeWithSecond_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(210, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Second";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(210, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = " °C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Reading Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(12, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Temp Warning";
            // 
            // read
            // 
            this.read.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.read.Font = new System.Drawing.Font("Tahoma", 12F);
            this.read.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.read.Location = new System.Drawing.Point(277, 94);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(75, 30);
            this.read.TabIndex = 11;
            this.read.TabStop = false;
            this.read.Text = "Read";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 217);
            this.Controls.Add(this.read);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeWithSecond);
            this.Controls.Add(this.temperatureWarning);
            this.Controls.Add(this.close);
            this.Controls.Add(this.understood);
            this.Controls.Add(this.degree);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.temperatureWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeWithSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label degree;
        private System.Windows.Forms.Button understood;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.NotifyIcon thermometer;
        private System.Windows.Forms.NumericUpDown temperatureWarning;
        private System.Windows.Forms.NumericUpDown timeWithSecond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button read;
    }
}

