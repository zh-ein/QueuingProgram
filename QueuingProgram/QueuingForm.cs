using System.Drawing.Text;

namespace QueuingProgram
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier = new CashierClass();


        public QueuingForm()
        {

            InitializeComponent();
            cashier = new CashierClass();
        }   

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);            
        }
    }
}