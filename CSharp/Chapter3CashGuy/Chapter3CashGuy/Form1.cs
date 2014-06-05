﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter3CashGuy
{
    public partial class Form1 : Form
    {
            Guy joe;
            Guy bob;
            int bank = 100;
           
        public void UpdateForm()
       {
           joeCashLabel.Text = joe.Name + " has $" + joe.Cash;
           bobCashLabel.Text = bob.Name + " has $" + bob.Cash;
           bankCashLabel.Text = "The bank has $" + bank;
        }
        
        public Form1()
        {
            InitializeComponent();
            bob = new Guy();
            bob.Name = "Bob";
            bob.Cash = 100;

            joe = new Guy();
            joe.Name = "Joe";
            joe.Cash = 50;
            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }


    }
}