using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QueuingProgram
{
    public partial class CashierWindowQueue : Form
    {


        public CashierWindowQueue()
        {
            InitializeComponent();



        }


        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }            

            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                CustomerView customerView = new CustomerView();
                customerView.Show();
                CashierClass.CashierQueue.Dequeue();
                
            }
            else if (CashierClass.CashierQueue.Count == 0)
            {
                CustomerView customerView = new CustomerView();
                customerView.Show();
            }
        }
    }
}