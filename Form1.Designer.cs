namespace Reports_Creator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnOutputDir = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.numericFirstHour = new System.Windows.Forms.NumericUpDown();
            this.numericFirstMinute = new System.Windows.Forms.NumericUpDown();
            this.numericLastHour = new System.Windows.Forms.NumericUpDown();
            this.numericLastMinute = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericFirstHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFirstMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLastHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLastMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(506, 51);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(157, 23);
            this.dtpStartDate.TabIndex = 0;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(506, 100);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(157, 23);
            this.dtpEndDate.TabIndex = 1;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(398, 250);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // btnOutputDir
            // 
            this.btnOutputDir.Location = new System.Drawing.Point(646, 257);
            this.btnOutputDir.Name = "btnOutputDir";
            this.btnOutputDir.Size = new System.Drawing.Size(75, 23);
            this.btnOutputDir.TabIndex = 3;
            this.btnOutputDir.Text = "OUTPUT";
            this.btnOutputDir.UseVisualStyleBackColor = true;
            this.btnOutputDir.Click += new System.EventHandler(this.btnOutputDir_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(646, 311);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // numericFirstHour
            // 
            this.numericFirstHour.Location = new System.Drawing.Point(669, 51);
            this.numericFirstHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericFirstHour.Name = "numericFirstHour";
            this.numericFirstHour.Size = new System.Drawing.Size(47, 23);
            this.numericFirstHour.TabIndex = 5;
            // 
            // numericFirstMinute
            // 
            this.numericFirstMinute.Location = new System.Drawing.Point(722, 51);
            this.numericFirstMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericFirstMinute.Name = "numericFirstMinute";
            this.numericFirstMinute.Size = new System.Drawing.Size(55, 23);
            this.numericFirstMinute.TabIndex = 6;
            // 
            // numericLastHour
            // 
            this.numericLastHour.Location = new System.Drawing.Point(669, 100);
            this.numericLastHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericLastHour.Name = "numericLastHour";
            this.numericLastHour.Size = new System.Drawing.Size(47, 23);
            this.numericLastHour.TabIndex = 7;
            // 
            // numericLastMinute
            // 
            this.numericLastMinute.Location = new System.Drawing.Point(722, 100);
            this.numericLastMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericLastMinute.Name = "numericLastMinute";
            this.numericLastMinute.Size = new System.Drawing.Size(55, 23);
            this.numericLastMinute.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Start Date and time in 24-hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Finish Date and time in 24-hour";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericLastMinute);
            this.Controls.Add(this.numericLastHour);
            this.Controls.Add(this.numericFirstMinute);
            this.Controls.Add(this.numericFirstHour);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnOutputDir);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Reports Creator";
            ((System.ComponentModel.ISupportInitialize)(this.numericFirstHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFirstMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLastHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLastMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private RichTextBox richTextBox1;
        private Button btnOutputDir;
        private Button btnGenerate;
        private NumericUpDown numericFirstHour;
        private NumericUpDown numericFirstMinute;
        private NumericUpDown numericLastHour;
        private NumericUpDown numericLastMinute;
        private Label label1;
        private Label label2;
    }
}