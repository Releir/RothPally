namespace RothPally
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
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hpPerc = new System.Windows.Forms.ComboBox();
            this.spPerc = new System.Windows.Forms.ComboBox();
            this.hp2Perc = new System.Windows.Forms.ComboBox();
            this.hp3Perc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hp2Enabled = new System.Windows.Forms.CheckBox();
            this.hp3Enabled = new System.Windows.Forms.CheckBox();
            this.hpKey = new System.Windows.Forms.ComboBox();
            this.spKey = new System.Windows.Forms.ComboBox();
            this.hp2Key = new System.Windows.Forms.ComboBox();
            this.hp3Key = new System.Windows.Forms.ComboBox();
            this.procLabel = new System.Windows.Forms.Label();
            this.attachBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(39, 202);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(120, 202);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "HP: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "SP: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "HP 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "HP 3: ";
            // 
            // hpPerc
            // 
            this.hpPerc.FormattingEnabled = true;
            this.hpPerc.Items.AddRange(new object[] {
            "99",
            "90",
            "80",
            "70",
            "60",
            "50",
            "40",
            "30",
            "20",
            "10",
            "5",
            "1"});
            this.hpPerc.Location = new System.Drawing.Point(58, 59);
            this.hpPerc.Name = "hpPerc";
            this.hpPerc.Size = new System.Drawing.Size(56, 23);
            this.hpPerc.TabIndex = 6;
            this.hpPerc.Text = "99";
            // 
            // spPerc
            // 
            this.spPerc.FormattingEnabled = true;
            this.spPerc.Items.AddRange(new object[] {
            "99",
            "90",
            "80",
            "70",
            "60",
            "50",
            "40",
            "30",
            "20",
            "10",
            "5",
            "1"});
            this.spPerc.Location = new System.Drawing.Point(58, 88);
            this.spPerc.Name = "spPerc";
            this.spPerc.Size = new System.Drawing.Size(56, 23);
            this.spPerc.TabIndex = 7;
            this.spPerc.Text = "30";
            // 
            // hp2Perc
            // 
            this.hp2Perc.FormattingEnabled = true;
            this.hp2Perc.Items.AddRange(new object[] {
            "99",
            "90",
            "80",
            "70",
            "60",
            "50",
            "40",
            "30",
            "20",
            "10",
            "5",
            "1"});
            this.hp2Perc.Location = new System.Drawing.Point(58, 118);
            this.hp2Perc.Name = "hp2Perc";
            this.hp2Perc.Size = new System.Drawing.Size(56, 23);
            this.hp2Perc.TabIndex = 8;
            this.hp2Perc.Text = "80";
            // 
            // hp3Perc
            // 
            this.hp3Perc.FormattingEnabled = true;
            this.hp3Perc.Items.AddRange(new object[] {
            "99",
            "90",
            "80",
            "70",
            "60",
            "50",
            "40",
            "30",
            "20",
            "10",
            "5",
            "1"});
            this.hp3Perc.Location = new System.Drawing.Point(58, 147);
            this.hp3Perc.Name = "hp3Perc";
            this.hp3Perc.Size = new System.Drawing.Size(56, 23);
            this.hp3Perc.TabIndex = 9;
            this.hp3Perc.Text = "60";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Client";
            // 
            // hp2Enabled
            // 
            this.hp2Enabled.AutoSize = true;
            this.hp2Enabled.Location = new System.Drawing.Point(224, 121);
            this.hp2Enabled.Name = "hp2Enabled";
            this.hp2Enabled.Size = new System.Drawing.Size(15, 14);
            this.hp2Enabled.TabIndex = 12;
            this.hp2Enabled.UseVisualStyleBackColor = true;
            // 
            // hp3Enabled
            // 
            this.hp3Enabled.AutoSize = true;
            this.hp3Enabled.Location = new System.Drawing.Point(224, 151);
            this.hp3Enabled.Name = "hp3Enabled";
            this.hp3Enabled.Size = new System.Drawing.Size(15, 14);
            this.hp3Enabled.TabIndex = 13;
            this.hp3Enabled.UseVisualStyleBackColor = true;
            // 
            // hpKey
            // 
            this.hpKey.FormattingEnabled = true;
            this.hpKey.Items.AddRange(new object[] {
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "D1",
            "D2",
            "D3",
            "D4",
            "D5",
            "D6",
            "D7",
            "D8",
            "D9",
            "D0",
            "Q",
            "W",
            "E",
            "R",
            "T",
            "Y",
            "U",
            "I",
            "O",
            "A",
            "S",
            "G",
            "H",
            "J",
            "K",
            "L"});
            this.hpKey.Location = new System.Drawing.Point(120, 59);
            this.hpKey.Name = "hpKey";
            this.hpKey.Size = new System.Drawing.Size(96, 23);
            this.hpKey.TabIndex = 14;
            this.hpKey.Text = "F9";
            this.hpKey.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // spKey
            // 
            this.spKey.FormattingEnabled = true;
            this.spKey.Items.AddRange(new object[] {
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "D1",
            "D2",
            "D3",
            "D4",
            "D5",
            "D6",
            "D7",
            "D8",
            "D9",
            "D0",
            "Q",
            "W",
            "E",
            "R",
            "T",
            "Y",
            "U",
            "I",
            "O",
            "A",
            "S",
            "G",
            "H",
            "J",
            "K",
            "L"});
            this.spKey.Location = new System.Drawing.Point(120, 88);
            this.spKey.Name = "spKey";
            this.spKey.Size = new System.Drawing.Size(96, 23);
            this.spKey.TabIndex = 15;
            this.spKey.Text = "F6";
            // 
            // hp2Key
            // 
            this.hp2Key.FormattingEnabled = true;
            this.hp2Key.Items.AddRange(new object[] {
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "D1",
            "D2",
            "D3",
            "D4",
            "D5",
            "D6",
            "D7",
            "D8",
            "D9",
            "D0",
            "Q",
            "W",
            "E",
            "R",
            "T",
            "Y",
            "U",
            "I",
            "O",
            "A",
            "S",
            "G",
            "H",
            "J",
            "K",
            "L"});
            this.hp2Key.Location = new System.Drawing.Point(120, 117);
            this.hp2Key.Name = "hp2Key";
            this.hp2Key.Size = new System.Drawing.Size(96, 23);
            this.hp2Key.TabIndex = 16;
            this.hp2Key.Text = "F8";
            // 
            // hp3Key
            // 
            this.hp3Key.FormattingEnabled = true;
            this.hp3Key.Items.AddRange(new object[] {
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "D1",
            "D2",
            "D3",
            "D4",
            "D5",
            "D6",
            "D7",
            "D8",
            "D9",
            "D0",
            "Q",
            "W",
            "E",
            "R",
            "T",
            "Y",
            "U",
            "I",
            "O",
            "A",
            "S",
            "G",
            "H",
            "J",
            "K",
            "L"});
            this.hp3Key.Location = new System.Drawing.Point(120, 147);
            this.hp3Key.Name = "hp3Key";
            this.hp3Key.Size = new System.Drawing.Size(96, 23);
            this.hp3Key.TabIndex = 17;
            this.hp3Key.Text = "F7";
            // 
            // procLabel
            // 
            this.procLabel.AutoSize = true;
            this.procLabel.Location = new System.Drawing.Point(64, 18);
            this.procLabel.Name = "procLabel";
            this.procLabel.Size = new System.Drawing.Size(18, 15);
            this.procLabel.TabIndex = 18;
            this.procLabel.Text = "ID";
            // 
            // attachBtn
            // 
            this.attachBtn.Location = new System.Drawing.Point(164, 14);
            this.attachBtn.Name = "attachBtn";
            this.attachBtn.Size = new System.Drawing.Size(75, 23);
            this.attachBtn.TabIndex = 19;
            this.attachBtn.Text = "Attach";
            this.attachBtn.UseVisualStyleBackColor = true;
            this.attachBtn.Click += new System.EventHandler(this.attachBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 245);
            this.Controls.Add(this.attachBtn);
            this.Controls.Add(this.procLabel);
            this.Controls.Add(this.hp3Key);
            this.Controls.Add(this.hp2Key);
            this.Controls.Add(this.spKey);
            this.Controls.Add(this.hpKey);
            this.Controls.Add(this.hp3Enabled);
            this.Controls.Add(this.hp2Enabled);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hp3Perc);
            this.Controls.Add(this.hp2Perc);
            this.Controls.Add(this.spPerc);
            this.Controls.Add(this.hpPerc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Name = "Form1";
            this.Text = "RothPally";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startBtn;
        private Button stopBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox hpPerc;
        private ComboBox spPerc;
        private ComboBox hp2Perc;
        private ComboBox hp3Perc;
        private Label label5;
        private CheckBox hp2Enabled;
        private CheckBox hp3Enabled;
        private ComboBox hpKey;
        private ComboBox spKey;
        private ComboBox hp2Key;
        private ComboBox hp3Key;
        private Label procLabel;
        private Button attachBtn;
    }
}