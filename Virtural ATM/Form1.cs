using System.Reflection.Metadata;

namespace Virtural_ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            deposit_dollars.MaxLength = 7;

            transaction_dollars.MaxLength = 7;

        }

        public void BalanceText()
        {
            balance.Text = "Balance: $" + Convert.ToString(Math.Round(GlobalVariable.dollars,2));
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Random money = new Random();
            double RANDOM_AMMOUNT = money.Next(0, 9999);
            GlobalVariable.dollars = RANDOM_AMMOUNT / 7;

            BalanceText();
        }

        private void balance_Click(object sender, EventArgs e)
        {

        }

        public static class GlobalVariable
        {
            public static double dollars;

            public static double deposit_amount_dollars;
            public static double transaction_amount_dollars;
        }

        private void deposit_complete_Click(object sender, EventArgs e)
        {
            BalanceText();
            GlobalVariable.deposit_amount_dollars = Convert.ToDouble(deposit_dollars.Text);

            GlobalVariable.dollars = GlobalVariable.deposit_amount_dollars + GlobalVariable.dollars;

            deposit_complete.Enabled = false;
        }

        private void transaction_complete_Click(object sender, EventArgs e)
        {
            BalanceText();
            GlobalVariable.transaction_amount_dollars = Convert.ToDouble(transaction_dollars.Text);

            GlobalVariable.dollars = GlobalVariable.dollars - GlobalVariable.transaction_amount_dollars;

            transaction_complete.Enabled = false; 

            if (GlobalVariable.dollars < 0)
            {
                balance.Text = "FAILED TO COMPLETE";
                balance.ForeColor = Color.Red;
            }
        }
    }
}