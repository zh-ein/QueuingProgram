using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingProgram
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
            this.Controls.Add(lblQueued);

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 sec
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                
                string nextNumber = CashierClass.CashierQueue.Peek();
                lblQueued.Text = nextNumber;
            }
            else
            {
                lblQueued.Text = "";
            }
        }
    }
}
