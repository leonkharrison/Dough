namespace Dough.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnManageBankAccount = new System.Windows.Forms.Button();
            this.btnNewBankAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddOutgoing = new System.Windows.Forms.Button();
            this.gridViewOutgoings = new System.Windows.Forms.DataGridView();
            this.btnEditOutgoing = new System.Windows.Forms.Button();
            this.btnDeleteOutgoing = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridViewAccounts = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOutgoings)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccounts)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManageBankAccount
            // 
            this.btnManageBankAccount.Location = new System.Drawing.Point(135, 279);
            this.btnManageBankAccount.Name = "btnManageBankAccount";
            this.btnManageBankAccount.Size = new System.Drawing.Size(139, 27);
            this.btnManageBankAccount.TabIndex = 0;
            this.btnManageBankAccount.Text = "Edit selected";
            this.btnManageBankAccount.UseVisualStyleBackColor = true;
            this.btnManageBankAccount.Click += new System.EventHandler(this.btnManageBankAccounts_Click);
            // 
            // btnNewBankAccount
            // 
            this.btnNewBankAccount.Location = new System.Drawing.Point(14, 279);
            this.btnNewBankAccount.Name = "btnNewBankAccount";
            this.btnNewBankAccount.Size = new System.Drawing.Size(115, 27);
            this.btnNewBankAccount.TabIndex = 2;
            this.btnNewBankAccount.Text = "New";
            this.btnNewBankAccount.UseVisualStyleBackColor = true;
            this.btnNewBankAccount.Click += new System.EventHandler(this.btnNewBankAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(280, 279);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(129, 27);
            this.btnDeleteAccount.TabIndex = 3;
            this.btnDeleteAccount.Text = "Delete selected";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddOutgoing
            // 
            this.btnAddOutgoing.Location = new System.Drawing.Point(8, 284);
            this.btnAddOutgoing.Name = "btnAddOutgoing";
            this.btnAddOutgoing.Size = new System.Drawing.Size(178, 27);
            this.btnAddOutgoing.TabIndex = 5;
            this.btnAddOutgoing.Text = "Add Outgoing";
            this.btnAddOutgoing.UseVisualStyleBackColor = true;
            this.btnAddOutgoing.Click += new System.EventHandler(this.btnAddOutgoing_Click);
            // 
            // gridViewOutgoings
            // 
            this.gridViewOutgoings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewOutgoings.Location = new System.Drawing.Point(8, 19);
            this.gridViewOutgoings.Name = "gridViewOutgoings";
            this.gridViewOutgoings.ReadOnly = true;
            this.gridViewOutgoings.RowTemplate.Height = 25;
            this.gridViewOutgoings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewOutgoings.Size = new System.Drawing.Size(571, 253);
            this.gridViewOutgoings.TabIndex = 6;
            // 
            // btnEditOutgoing
            // 
            this.btnEditOutgoing.Location = new System.Drawing.Point(192, 284);
            this.btnEditOutgoing.Name = "btnEditOutgoing";
            this.btnEditOutgoing.Size = new System.Drawing.Size(178, 27);
            this.btnEditOutgoing.TabIndex = 7;
            this.btnEditOutgoing.Text = "Edit Outgoing";
            this.btnEditOutgoing.UseVisualStyleBackColor = true;
            this.btnEditOutgoing.Click += new System.EventHandler(this.btnEditOutgoing_Click);
            // 
            // btnDeleteOutgoing
            // 
            this.btnDeleteOutgoing.Location = new System.Drawing.Point(376, 284);
            this.btnDeleteOutgoing.Name = "btnDeleteOutgoing";
            this.btnDeleteOutgoing.Size = new System.Drawing.Size(178, 27);
            this.btnDeleteOutgoing.TabIndex = 8;
            this.btnDeleteOutgoing.Text = "Delete Outgoing";
            this.btnDeleteOutgoing.UseVisualStyleBackColor = true;
            this.btnDeleteOutgoing.Click += new System.EventHandler(this.btnDeleteOutgoing_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteOutgoing);
            this.groupBox1.Controls.Add(this.btnEditOutgoing);
            this.groupBox1.Controls.Add(this.gridViewOutgoings);
            this.groupBox1.Controls.Add(this.btnAddOutgoing);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 319);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Outgoings";
            // 
            // gridViewAccounts
            // 
            this.gridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewAccounts.Location = new System.Drawing.Point(14, 19);
            this.gridViewAccounts.Name = "gridViewAccounts";
            this.gridViewAccounts.ReadOnly = true;
            this.gridViewAccounts.RowTemplate.Height = 25;
            this.gridViewAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewAccounts.Size = new System.Drawing.Size(395, 248);
            this.gridViewAccounts.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridViewAccounts);
            this.groupBox2.Controls.Add(this.btnDeleteAccount);
            this.groupBox2.Controls.Add(this.btnNewBankAccount);
            this.groupBox2.Controls.Add(this.btnManageBankAccount);
            this.groupBox2.Location = new System.Drawing.Point(622, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 319);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bank Accounts";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOutgoings)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccounts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnManageBankAccount;
        private Button btnNewBankAccount;
        private Button btnDeleteAccount;
        private Button btnAddOutgoing;
        private DataGridView gridViewOutgoings;
        private Button btnEditOutgoing;
        private Button btnDeleteOutgoing;
        private GroupBox groupBox1;
        private DataGridView gridViewAccounts;
        private GroupBox groupBox2;
    }
}