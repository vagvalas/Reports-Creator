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
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            richTextBox1 = new RichTextBox();
            btnOutputDir = new Button();
            btnGenerate = new Button();
            numericFirstHour = new NumericUpDown();
            numericFirstMinute = new NumericUpDown();
            numericLastHour = new NumericUpDown();
            numericLastMinute = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            btnTemplateFile = new Button();
            checkBoxInclude31User = new CheckBox();
            numeric31JoinHour = new NumericUpDown();
            numeric31JoinMinute = new NumericUpDown();
            numeric31LeaveHour = new NumericUpDown();
            numeric31LeaveMinute = new NumericUpDown();
            textBoxProfessorName = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericFirstHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericFirstMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericLastHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericLastMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric31JoinHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric31JoinMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric31LeaveHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric31LeaveMinute).BeginInit();
            SuspendLayout();
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(506, 51);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(157, 23);
            dtpStartDate.TabIndex = 0;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(506, 100);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(157, 23);
            dtpEndDate.TabIndex = 1;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(24, 45);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(398, 250);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // btnOutputDir
            // 
            btnOutputDir.Location = new Point(646, 257);
            btnOutputDir.Name = "btnOutputDir";
            btnOutputDir.Size = new Size(75, 23);
            btnOutputDir.TabIndex = 3;
            btnOutputDir.Text = "OUTPUT";
            btnOutputDir.UseVisualStyleBackColor = true;
            btnOutputDir.Click += btnOutputDir_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(646, 311);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // numericFirstHour
            // 
            numericFirstHour.Location = new Point(669, 51);
            numericFirstHour.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numericFirstHour.Name = "numericFirstHour";
            numericFirstHour.Size = new Size(47, 23);
            numericFirstHour.TabIndex = 5;
            // 
            // numericFirstMinute
            // 
            numericFirstMinute.Location = new Point(722, 51);
            numericFirstMinute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericFirstMinute.Name = "numericFirstMinute";
            numericFirstMinute.Size = new Size(55, 23);
            numericFirstMinute.TabIndex = 6;
            // 
            // numericLastHour
            // 
            numericLastHour.Location = new Point(669, 100);
            numericLastHour.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numericLastHour.Name = "numericLastHour";
            numericLastHour.Size = new Size(47, 23);
            numericLastHour.TabIndex = 7;
            // 
            // numericLastMinute
            // 
            numericLastMinute.Location = new Point(722, 100);
            numericLastMinute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericLastMinute.Name = "numericLastMinute";
            numericLastMinute.Size = new Size(55, 23);
            numericLastMinute.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(581, 33);
            label1.Name = "label1";
            label1.Size = new Size(166, 15);
            label1.TabIndex = 9;
            label1.Text = "Start Date and time in 24-hour";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(574, 82);
            label2.Name = "label2";
            label2.Size = new Size(173, 15);
            label2.TabIndex = 10;
            label2.Text = "Finish Date and time in 24-hour";
            // 
            // btnTemplateFile
            // 
            btnTemplateFile.Location = new Point(506, 184);
            btnTemplateFile.Name = "btnTemplateFile";
            btnTemplateFile.Size = new Size(75, 23);
            btnTemplateFile.TabIndex = 11;
            btnTemplateFile.Text = "TEMPLATE";
            btnTemplateFile.UseVisualStyleBackColor = true;
            btnTemplateFile.Click += button1_Click;
            // 
            // checkBoxInclude31User
            // 
            checkBoxInclude31User.AutoSize = true;
            checkBoxInclude31User.Location = new Point(44, 372);
            checkBoxInclude31User.Name = "checkBoxInclude31User";
            checkBoxInclude31User.Size = new Size(102, 19);
            checkBoxInclude31User.TabIndex = 12;
            checkBoxInclude31User.Text = "Include 31user";
            checkBoxInclude31User.UseVisualStyleBackColor = true;
            checkBoxInclude31User.CheckedChanged += checkBoxInclude31User_CheckedChanged;
            // 
            // numeric31JoinHour
            // 
            numeric31JoinHour.Location = new Point(258, 371);
            numeric31JoinHour.Name = "numeric31JoinHour";
            numeric31JoinHour.Size = new Size(120, 23);
            numeric31JoinHour.TabIndex = 13;
            // 
            // numeric31JoinMinute
            // 
            numeric31JoinMinute.Location = new Point(384, 372);
            numeric31JoinMinute.Name = "numeric31JoinMinute";
            numeric31JoinMinute.Size = new Size(120, 23);
            numeric31JoinMinute.TabIndex = 14;
            // 
            // numeric31LeaveHour
            // 
            numeric31LeaveHour.Location = new Point(258, 406);
            numeric31LeaveHour.Name = "numeric31LeaveHour";
            numeric31LeaveHour.Size = new Size(120, 23);
            numeric31LeaveHour.TabIndex = 15;
            // 
            // numeric31LeaveMinute
            // 
            numeric31LeaveMinute.Location = new Point(384, 406);
            numeric31LeaveMinute.Name = "numeric31LeaveMinute";
            numeric31LeaveMinute.Size = new Size(120, 23);
            numeric31LeaveMinute.TabIndex = 16;
            // 
            // textBoxProfessorName
            // 
            textBoxProfessorName.Location = new Point(24, 332);
            textBoxProfessorName.Name = "textBoxProfessorName";
            textBoxProfessorName.Size = new Size(398, 23);
            textBoxProfessorName.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 308);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 18;
            label3.Text = "Professor Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBoxProfessorName);
            Controls.Add(numeric31LeaveMinute);
            Controls.Add(numeric31LeaveHour);
            Controls.Add(numeric31JoinMinute);
            Controls.Add(numeric31JoinHour);
            Controls.Add(checkBoxInclude31User);
            Controls.Add(btnTemplateFile);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericLastMinute);
            Controls.Add(numericLastHour);
            Controls.Add(numericFirstMinute);
            Controls.Add(numericFirstHour);
            Controls.Add(btnGenerate);
            Controls.Add(btnOutputDir);
            Controls.Add(richTextBox1);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Reports Creator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericFirstHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericFirstMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericLastHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericLastMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric31JoinHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric31JoinMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric31LeaveHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric31LeaveMinute).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
        private Button btnTemplateFile;
        private CheckBox checkBoxInclude31User;
        private NumericUpDown numeric31JoinHour;
        private NumericUpDown numeric31JoinMinute;
        private NumericUpDown numeric31LeaveHour;
        private NumericUpDown numeric31LeaveMinute;
        private TextBox textBoxProfessorName;
        private Label label3;
    }
}