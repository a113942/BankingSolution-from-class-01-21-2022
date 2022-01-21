using BankingDomain;

namespace BankingKiosk
{
    public partial class Form1 : Form
    {
        private BankAccount _account;
        public Form1()
        {
            InitializeComponent();
            // hokey composition root
            _account = new BankAccount(new TimeBasedBonusCalculator(new SystemTime()), new Compliance());
            UpdateBalance();
        }

        private void UpdateBalance()
        {
            Text = _account.GetBalance().ToString("c");
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DoTransaction(_account.Deposit);
        }

        private void DoTransaction(Action<decimal> operation)
        {
            try
            {
                var amount = decimal.Parse(txtAmount.Text);
                operation(amount);
               
            }
            catch (FormatException)
            {

                ShowErrorMessage("Enter a Number, Moron!");
            }

            catch(NoNegativeNumbersException)
            {
                var message = "Enter a non-negative number!";
                ShowErrorMessage(message);
            }
            catch (OverdraftException)
            {
                ShowErrorMessage("You do not have enough moolah!");
            }
            finally
            {
                txtAmount.SelectAll(); // select all the text in that box
                txtAmount.Focus(); // put the cursor focus there.
                UpdateBalance();
            }
        }

        // "Never type 'private' always refactor it.
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            DoTransaction(_account.Withdraw);
        }
    }
}