using Dough.Data;
using Dough.Services.BankAccountService;
using Dough.Services.OutgoingService;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Principal;

namespace Dough.UI
{
    public partial class MainForm : Form
    {
        IBankAccountService _BankAccountService;
        IOutgoingService _OutgoingService;

        public MainForm( IBankAccountService bankAccountService, IOutgoingService outgoingService )
        {
            InitializeComponent();

            _BankAccountService = bankAccountService;
            _OutgoingService = outgoingService;
        }

        async Task PopulateOutgoings()
        {
            var outgoings = await _OutgoingService.GetAllAsync();

            if( outgoings == null )
            {
                return;
            }

            gridViewOutgoings.DataSource = outgoings;
        }

        async Task PopulateBankAccounts()
        {
            var bankAccounts = ( await _BankAccountService.GetAllAsync() ).Where( e => e.IsDeleted == false ).ToList();

            if( bankAccounts == null )
            {
                return;
            }

            gridViewAccounts.DataSource = bankAccounts;
        }

        private async void btnManageBankAccounts_Click( object sender, EventArgs e )
        {
            if( gridViewAccounts.SelectedRows.Count != 1 )
            {
                return;
            }

            var selectedAccount = gridViewAccounts.SelectedRows[ 0 ].DataBoundItem as BankAccount;

            if( selectedAccount == null )
            {
                return;
            }

            using( BankAccountDetailsForm baDetailsForm = Program.ServiceProvider.GetRequiredService<BankAccountDetailsForm>() )
            {
                baDetailsForm.ShowDialog( selectedAccount );
            }

            await PopulateBankAccounts();
        }

        private async void MainForm_Shown( object sender, EventArgs e )
        {
            await PopulateBankAccounts();
            await PopulateOutgoings();
        }

        private async void btnNewBankAccount_Click( object sender, EventArgs e )
        {
            using( BankAccountDetailsForm baDetailsForm = Program.ServiceProvider.GetRequiredService<BankAccountDetailsForm>() )
            {
                baDetailsForm.ShowDialog();
            }

            await PopulateBankAccounts();
        }

        private async void btnDeleteAccount_Click( object sender, EventArgs e )
        {
            if( gridViewAccounts.SelectedRows.Count != 1 )
            {
                return;
            }

            var account = gridViewAccounts.SelectedRows[ 0 ].DataBoundItem as BankAccount;

            if( account == null )
            {
                return;
            }

            var result = MessageBox.Show( $"Are you sure you want to delete {account.Name}", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning );

            if( result == DialogResult.Yes )
            {
                await _BankAccountService.DeleteAsync( account );
                await PopulateBankAccounts();
            }
        }

        private async void btnAddOutgoing_Click( object sender, EventArgs e )
        {
            using( OutgoingDetailsForm outgoingForm = Program.ServiceProvider.GetRequiredService<OutgoingDetailsForm>() )
            {
                outgoingForm.ShowDialog();
            }

            await PopulateOutgoings();
            await PopulateBankAccounts();
        }

        private async void btnEditOutgoing_Click( object sender, EventArgs e )
        {
            if( gridViewOutgoings.SelectedRows.Count != 1 )
            {
                return;
            }

            var selectedOutgoing = gridViewOutgoings.SelectedRows[ 0 ].DataBoundItem as Outgoing;

            if( selectedOutgoing == null )
            {
                return;
            }

            using( OutgoingDetailsForm outgoingForm = Program.ServiceProvider.GetRequiredService<OutgoingDetailsForm>() )
            {
                outgoingForm.ShowDialog( selectedOutgoing );
            }

            await PopulateOutgoings();
            await PopulateBankAccounts();
        }

        private async void btnDeleteOutgoing_Click( object sender, EventArgs e )
        {
            if( gridViewOutgoings.SelectedRows.Count != 1 )
            {
                return;
            }

            var selectedOutgoing = gridViewOutgoings.SelectedRows[ 0 ].DataBoundItem as Outgoing;

            if( selectedOutgoing == null )
            {
                return;
            }

            var result = MessageBox.Show( $"Are you sure you want to delete {selectedOutgoing.Name}", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning );

            if( result == DialogResult.Yes )
            {
                var amount = selectedOutgoing.Amount;
                var bankAccount = selectedOutgoing.BankAccount;
                bankAccount.TotalOut -= amount;

                await _OutgoingService.DeleteAsync( selectedOutgoing );
                await _BankAccountService.UpdateAsync( bankAccount );

                await PopulateOutgoings();
                await PopulateBankAccounts();
            }
        }
    }
}