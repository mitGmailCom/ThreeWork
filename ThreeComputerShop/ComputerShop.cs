using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeComputerShop
{
    public partial class ComputerShop : Form
    {
        FormAddProduct addProd;
        Product tempProduct;
        public List<Product> masProducts;
        bool selectedValueCBox;
        double summ = 0.0;
        string nameCmb = null; // imya combBox

        public ComputerShop()
        {
            InitializeComponent();
        }

        //public void AddToComboBox(Product tempProd)
        //{
        //    tempProduct = tempProd;
        //    if(!cmbLisProduct.Items.Contains(tempProduct))
        //        cmbLisProduct.Items.Add(tempProduct.Name);
        //}

        public void createMasProduct()
        {
            masProducts = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                Product tProd = new Product();
                tProd.Name = "Celeron 4300" + $"{i.ToString()}";
                tProd.Charact = "Intel";
                tProd.Descr = "Processor";
                tProd.Price = 970.00;
                masProducts.Add(tProd);
            }
        }

        private void ComputerShop_Load(object sender, EventArgs e)
        {
            createMasProduct();
            nameCmb = this.cmbLisProduct.Name;
            addProd = new FormAddProduct(this, masProducts, nameCmb);
            selectedValueCBox = false;
            tempProduct = new Product();
            for (int i = 0; i < masProducts.Count; i++)
            {
                cmbLisProduct.Items.Add(masProducts[i].Name);
            }
        }

        private void btnAddToSales_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < masProducts.Count; i++)
            {
                if (cmbLisProduct.Text == masProducts[i].Name)
                {
                    listbSales.Items.Add(masProducts[i].Name);
                    summ += masProducts[i].Price;
                }

            }
            lbTotal.Text = summ.ToString();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if(addProd.IsDisposed == true)
                addProd = new FormAddProduct(this, masProducts, nameCmb);
            if (addProd == null)
                addProd = new FormAddProduct(this, masProducts, nameCmb);
            addProd.Show();
        }

        private void cmbLisProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            selectedValueCBox = true;
            for (int i = 0; i < masProducts.Count; i++)
            {
                if (cmbLisProduct.Text == masProducts[i].Name)
                {
                    lbPrice.Text = masProducts[i].Price.ToString();
                }
            }
        }

        
    }
}
