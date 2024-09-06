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
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public CashierWindowQueue()
        {
            InitializeComponent();

            timer.Interval = (1 * 1000); // 1 sec
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();
        }
        private void timer1_tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);

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
        private CustomerView customerView;
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                if (customerView == null || customerView.IsDisposed)
                {
                    customerView = new CustomerView();
                    customerView.Show();

                }
                else
                {
                    customerView.Hide();
                    customerView = null;
                    if (customerView == null)
                    {
                        CashierClass.CashierQueue.Dequeue();
                        if (CashierClass.CashierQueue.Count > 0)
                        {
                            customerView = new CustomerView();
                            customerView.Show();

                        }
                    }
                }
            }
            else if (CashierClass.CashierQueue.Count == 0)
            {
                // Handle the case when the queue is empty
                MessageBox.Show("No customers in the queue.");
            }
        }
    }
}