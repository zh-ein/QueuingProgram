﻿using System;
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

            if (CashierClass.CashierQueue.Count > 0)
            {

                string nextNumber = CashierClass.CashierQueue.Peek();
                lblQueued.Text = nextNumber;
            }
            else
            {

                MessageBox.Show("There are no more queues in the list.");
                this.Close();
            }
        }
    }
}
