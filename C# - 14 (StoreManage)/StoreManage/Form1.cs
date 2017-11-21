using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using StoreManage.Models;

namespace StoreManage
{
    public partial class Form1 : Form
    {
        private StoreEntities db = new StoreEntities();
        private Order selectedOrder;
        public Form1()
        {
            InitializeComponent();
            FillDatas();
            dgvOrders.Columns[0].Visible = false;
            FillComboBoxs();
        }

        private void FillDatas()
        {
            dgvOrders.DataSource = db.Orders.Select(o => new
            {
                o.ID,
                Customer = o.Customer.Email,
                Product = o.Product.Name,
                o.Date,
                Price = o.Price + " $",
                o.Count,
                Total = (o.Price * o.Count) + " $"
            }).ToList();
        }

        private void FillComboBoxs()
        {
            List<Product> ProductList = db.Product.ToList();
            ProductList.ForEach(i => cmbProduct.Items.Add(i.Name + " - " + i.Price));

            List<Customer> CustomerList = db.Customers.ToList();
            CustomerList.ForEach(i => cmbCustomer.Items.Add(i.Email));
        }

        private void BtnBuyClick(object sender, EventArgs e)
        {
            string product = cmbProduct.Text;
            string customer = cmbCustomer.Text;
            int count = 0;

            if (product == string.Empty || customer == string.Empty)
            {
                MessageBox.Show("Fill the boxs!");
                return;
            }
            if (!int.TryParse(txtCount.Text, out count))
            {
                MessageBox.Show("Enter valid number!");
                return;
            }

            Order newOrder = new Order();
            newOrder.Count = count;
            newOrder.Date = DateTime.Now;

            int customerId = this.getCustomerIdByName(customer);
            newOrder.CustomerID = customerId;
            string[] a = product.Split('-');
            newOrder.Price = Convert.ToDecimal(a[1]);
            int productId = this.getProductIdByName(a[0]);
            newOrder.ProductID = productId;

            db.Orders.Add(newOrder);
            db.SaveChanges();

            Reset();
        }

        private int getCustomerIdByName(string email)
        {
            return db.Customers.FirstOrDefault(c => c.Email == email).ID;
        }

        private int getProductIdByName(string name)
        {
            return db.Product.FirstOrDefault(p => p.Name == name).ID;
        }


        private void DGVRowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.selectedOrder = db.Orders.Find(id);
            cmbCustomer.Text = this.selectedOrder.Customer.Email;
            cmbProduct.Text = this.selectedOrder.Product.Name + " - " + this.selectedOrder.Product.Price;
            txtCount.Text = this.selectedOrder.Count.ToString();
            btnBuy.Visible = false;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
        }


        private void BtnUpdateClick(object sender, EventArgs e)
        {
            string product = cmbProduct.Text;
            string customer = cmbCustomer.Text;
            int count = 0;

            if (product == string.Empty || customer == string.Empty)
            {
                MessageBox.Show("Fill the boxs!");
                return;
            }
            if (!int.TryParse(txtCount.Text, out count))
            {
                MessageBox.Show("Enter valid number!");
                return;
            }

            this.selectedOrder.Count = count;
            int customerId = this.getCustomerIdByName(customer);
            this.selectedOrder.CustomerID = customerId;
            string[] a = product.Split('-');
            this.selectedOrder.Price = Convert.ToDecimal(a[1]);
            int productId = this.getProductIdByName(a[0]);
            this.selectedOrder.ProductID = productId;
            db.SaveChanges();
            Reset();
        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                db.Orders.Remove(this.selectedOrder);
                db.SaveChanges();
                Reset();
            }
        }

        private void Reset()
        {
            FillDatas();
            cmbProduct.Text = "";
            cmbCustomer.Text = "";
            txtCount.Clear();
            btnBuy.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }
    }
}
