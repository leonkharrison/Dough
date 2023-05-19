using Dough.Data;
using Dough.Services.BankAccountService;
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
    public partial class BankAccountDetailsForm : Form
    {
        IBankAccountService _bankAccountService;
        BankAccount _bankAccount;

        public BankAccountDetailsForm( IBankAccountService bankAccountService )
        {
            InitializeComponent();
            _bankAccountService = bankAccountService;
        }

        public void ShowDialog( BankAccount bankAccount )
        {
            _bankAccount = bankAccount; 
            
            if( _bankAccount != null )
            {
                tbName.Text = _bankAccount.Name;
                tbDesc.Text = _bankAccount.Description;
            }

            base.ShowDialog();
        }

        private async void btnSave_Click( object sender, EventArgs e )
        {
            var name = tbName.Text;
            var desc = tbDesc.Text;

            if( string.IsNullOrEmpty( name ) || string.IsNullOrEmpty( desc ) )
            {
                MessageBox.Show( "Name and descriptions must not be empty" );
            }

            if( _bankAccount != null )
            {
                _bankAccount.Name = name;
                _bankAccount.Description = desc;

                await _bankAccountService.UpdateAsync( _bankAccount );
            }
            else
            {
                _bankAccount = new BankAccount()
                {
                    Name = name,
                    Description = desc,
                };

                await _bankAccountService.InsertAsync( _bankAccount );
            }

            this.Close();
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
