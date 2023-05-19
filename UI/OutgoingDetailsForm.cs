using Dough.Data;
using Dough.Services.BankAccountService;
using Dough.Services.OutgoingService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dough.UI
{
    public partial class OutgoingDetailsForm : Form
    {
        IOutgoingService _outgoingService;
        IBankAccountService _bankAccountService;
        Outgoing? _outgoing;

        public OutgoingDetailsForm( IOutgoingService outgoingService, IBankAccountService bankAccountService )
        {
            InitializeComponent();
            _outgoingService = outgoingService;
            _bankAccountService = bankAccountService;
            _outgoing = null;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd";
        }

        async Task PopulateForm()
        {
            comboAccount.DisplayMember = "Name";
            comboAccount.DataSource = await _bankAccountService.GetAllAsync();
        }

        public void ShowDialog( Outgoing outgoing )
        {
            if( outgoing != null )
            {
                _outgoing = outgoing;

                tbName.Text = outgoing.Name;
                tbDesc.Text = outgoing.Description;
                dateTimePicker1.Value = outgoing.PayOnDate;
                cbAllowWeekends.Checked = outgoing.AllowWeekendPayDate;
                cbReoccuring.Checked = outgoing.Reoccuring;
                var index = comboAccount.Items.IndexOf( outgoing.BankAccount );
                if( index >= 0 )
                {
                    comboAccount.SelectedIndex = index;
                }
            }

            base.ShowDialog();
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private async void OutgoingDetailsForm_Shown( object sender, EventArgs e )
        {
            await PopulateForm();
        }

        private async void btnSave_Click( object sender, EventArgs e )
        {
            var name = tbName.Text;
            var desc = tbDesc.Text;
            var amount = ( double )numAmount.Value;
            var bankAccount = comboAccount.SelectedItem as BankAccount;

            if( string.IsNullOrEmpty( name ) || string.IsNullOrEmpty(desc) )
            {
                MessageBox.Show( "Name or desc cannot be empty" );
            }
            if( amount <= 0 )
            {
                MessageBox.Show( "Amount must be greater than 0" );
            }
            if( bankAccount == null )
            {
                MessageBox.Show( "Select bank account this outgoing comes from" );
            }

            if( _outgoing == null )
            {
                var newOutgoing = new Outgoing()
                {
                    Name = name,
                    Description = desc,
                    Amount = amount,
                    BankAccount = bankAccount,
                    AllowWeekendPayDate = cbAllowWeekends.Checked,
                    Reoccuring = cbReoccuring.Checked,
                    PayOnDate = dateTimePicker1.Value
                };

                await _outgoingService.InsertAsync( newOutgoing );
            }
            else
            {
                _outgoing.Name= name;
                _outgoing.Description= desc;
                _outgoing.Amount= amount;
                _outgoing.BankAccount = bankAccount;
                _outgoing.AllowWeekendPayDate= cbAllowWeekends.Checked;
                _outgoing.Reoccuring= cbReoccuring.Checked;

                await _outgoingService.UpdateAsync( _outgoing );
            }

            bankAccount.TotalOut += amount;
            await _bankAccountService.UpdateAsync( bankAccount );

            this.Close();
        }
    }
}
