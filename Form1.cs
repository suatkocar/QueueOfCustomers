using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
  public partial class Form1 : Form
    {
        private CustomerQueue customerQueue = new CustomerQueue();
       
        public Form1()
        {
            InitializeComponent();
            UpdateStatistics();
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            try
            {
                int age = int.Parse(txtAge.Text);
                float amountOwed = float.Parse(txtAmountOwed.Text);
                string address = txtAddress.Text.Trim();

                if (age < 0 || amountOwed < 0)
                {
                    MessageBox.Show("Age and Amount Owed must be non-negative.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Address cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var customer = new Customer
                {
                    Name = txtName.Text,
                    Age = age,
                    Address = address,
                    AmountOwed = amountOwed
                };

                customerQueue.Enqueue(customer);
                UpdateCustomerList();
                UpdateStatistics();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Queue Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for Age and Amount Owed.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = customerQueue.Dequeue();
                MessageBox.Show(customer.GetInformation(), "Dequeued Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateCustomerList();
                UpdateStatistics();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = customerQueue.Peek();
                MessageBox.Show(customer.GetInformation(), "Peek Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCustomerList()
        {
            FirstCustomers.Items.Clear();
            for (int i = 0; i < customerQueue.Count; i++)
            {
                Customer customer = customerQueue.GetCustomerAt(i);
                FirstCustomers.Items.Add(customer.GetInformation());
            }
        }

        private void UpdateStatistics()
        {
            lblTotalCustomers.Text = customerQueue.Count.ToString();
            lblTotalAmountOwed.Text = "£" + customerQueue.TotalAmountOwed().ToString("F2");

            Customer maxDebtCustomer = customerQueue.MaxDebtCustomer();
            if (maxDebtCustomer != null)
            {
                lblMaxDebtCustomerInfo.Text = "Name: " + maxDebtCustomer.Name +
                                              ", Owed Amount: £" + maxDebtCustomer.AmountOwed.ToString("F2") +
                                              ", Age: " + maxDebtCustomer.Age.ToString() +
                                              ", Address: " + maxDebtCustomer.Address;
            }
            else
            {
                lblMaxDebtCustomerInfo.Text = "No customers or no debts.";
            }
        }

    }
}