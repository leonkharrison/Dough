namespace Dough.UI
{
    partial class OutgoingDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbReoccuring = new System.Windows.Forms.CheckBox();
            this.cbAllowWeekends = new System.Windows.Forms.CheckBox();
            this.comboAccount = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 27);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(325, 23);
            this.tbName.TabIndex = 1;
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(12, 76);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(325, 23);
            this.tbDesc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // numAmount
            // 
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numAmount.Location = new System.Drawing.Point(12, 120);
            this.numAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(126, 23);
            this.numAmount.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount:";
            // 
            // cbReoccuring
            // 
            this.cbReoccuring.AutoSize = true;
            this.cbReoccuring.Location = new System.Drawing.Point(12, 215);
            this.cbReoccuring.Name = "cbReoccuring";
            this.cbReoccuring.Size = new System.Drawing.Size(86, 19);
            this.cbReoccuring.TabIndex = 7;
            this.cbReoccuring.Text = "Reoccuring";
            this.cbReoccuring.UseVisualStyleBackColor = true;
            // 
            // cbAllowWeekends
            // 
            this.cbAllowWeekends.AutoSize = true;
            this.cbAllowWeekends.Location = new System.Drawing.Point(172, 215);
            this.cbAllowWeekends.Name = "cbAllowWeekends";
            this.cbAllowWeekends.Size = new System.Drawing.Size(150, 19);
            this.cbAllowWeekends.TabIndex = 9;
            this.cbAllowWeekends.Text = "Allow weekend pay day";
            this.cbAllowWeekends.UseVisualStyleBackColor = true;
            // 
            // comboAccount
            // 
            this.comboAccount.FormattingEnabled = true;
            this.comboAccount.Location = new System.Drawing.Point(12, 173);
            this.comboAccount.Name = "comboAccount";
            this.comboAccount.Size = new System.Drawing.Size(325, 23);
            this.comboAccount.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Account:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(219, 246);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 35);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(12, 246);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 35);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save and Close";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 23);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pay Date:";
            // 
            // OutgoingDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 293);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboAccount);
            this.Controls.Add(this.cbAllowWeekends);
            this.Controls.Add(this.cbReoccuring);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OutgoingDetailsForm";
            this.Text = "Outgoing";
            this.Shown += new System.EventHandler(this.OutgoingDetailsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbName;
        private TextBox tbDesc;
        private Label label2;
        private NumericUpDown numAmount;
        private Label label3;
        private CheckBox cbReoccuring;
        private CheckBox cbAllowWeekends;
        private ComboBox comboAccount;
        private Label label4;
        private Button btnClose;
        private Button btnSave;
        private DateTimePicker dateTimePicker1;
        private Label label5;
    }
}