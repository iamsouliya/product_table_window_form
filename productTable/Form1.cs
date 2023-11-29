using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace productTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text.ToLower() == "add")
            {
                txtProduct.Enabled = true;
                txtQty.Enabled = true;
                txtPrice.Enabled = true;
                btnAdd.Text = "Save";
                btnDelete.Enabled = false;
            }
            else
            {
                txtProduct.Enabled = true;
                txtQty.Enabled = true;
                txtPrice.Enabled = true;
                btnAdd.Text = "Add";
                btnDelete.Enabled = true;
                AddItemToListView();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && MessageBox.Show("Do you want to delete this item?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listView1.SelectedItems[0].Remove();
            }
        }
        public void AddItemToListView()
        {
            if (int.TryParse(txtQty.Text, out int number) && int.TryParse(txtPrice.Text, out int number2))
            {

                int qty = int.Parse(txtQty.Text);
                int price = int.Parse(txtPrice.Text);
                int result = qty * price;

                ListViewItem lv = listView1.Items.Add(txtProduct.Text);
                lv.SubItems.Add(txtQty.Text);
                lv.SubItems.Add(txtPrice.Text);
                lv.SubItems.Add(result.ToString());

                // reset state
                txtPrice.Text = "";
                txtQty.Text = "";
                txtProduct.Text = "";
                txtProduct.Enabled = false;
                txtQty.Enabled = false;
                txtPrice.Enabled = false;
                // invoke function to sum result
                SumTotalPrice();
            }
            else
            {
                txtPrice.Text = "";
                txtQty.Text = "";
                txtProduct.Enabled = false;
                txtQty.Enabled = false;
                txtPrice.Enabled = false;
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void SumTotalPrice()
        {
            int sum = 0;

            // Choose column index that you want to sum (start at 0)
            int columnIndexToSum = 3;

            foreach (ListViewItem item in listView1.Items)
            {
                // Parse each item in the specified column and add it to the sum
                if (int.TryParse(item.SubItems[columnIndexToSum].Text, out int value))
                {
                    sum += value;
                }
                else
                {
                    MessageBox.Show("Invalid number in the column.");
                    return; // Exit the summing process
                }
            }

            totalPrice.Text = sum.ToString();

            // MessageBox.Show("Sum of column " + columnIndexToSum + ": " + sum);
        }
    }
}
