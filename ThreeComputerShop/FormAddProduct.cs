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
    public partial class FormAddProduct : Form
    {
        private List<Product> listProductInAddForm = new List<Product>();
        private ComputerShop tShop = new ComputerShop();
        public string tempProduct { get; set; } = null; 
        private string NameCmBoxComputerShop { get; set; } = null; // imya cmbLisProduct v glavnoy forme
        bool flagProductAdd; // flag na dobavlenie
        int n = 0;
        Product prod;

        public FormAddProduct(ComputerShop shop, List<Product> tempListProd, string tempNameCmb)//(Product prodct, bool flg)
        {
            InitializeComponent();
            tShop = shop;
            listProductInAddForm = tempListProd;
            NameCmBoxComputerShop = tempNameCmb;
        }

        private void btnAddProductChild_Click(object sender, EventArgs e)
        {
            flagProductAdd = true;
            if (tbName.Text == "" || tbCharacteristic.Text == "" || tbDescribe.Text == "" || tbPrice.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            if (prod == null)
            {
                prod = new Product();
                prod.Name = tbName.Text;
                prod.Charact = tbCharacteristic.Text;
                prod.Descr = tbDescribe.Text;
                try
                {
                    prod.Price = Convert.ToDouble(tbPrice.Text);
                }
                catch
                {
                    MessageBox.Show("Цена указана неверно");
                    return;
                }
            }
            if (!lbListProductChild.Items.Contains($"{prod.Name}, {prod.Charact}, {prod.Descr}"))
            {
                lbListProductChild.Items.Add($"{prod.Name}, {prod.Charact}, {prod.Descr}");
                listProductInAddForm.Add(prod);
            }
            //tShop.AddToComboBox(prod);
            ((ComboBox)tShop.Controls[NameCmBoxComputerShop]).Items.Add(prod.Name);
            //listProductInAddForm.Add(prod);
            tbName.Text = tbCharacteristic.Text = tbDescribe.Text = tbPrice.Text = "";
            prod = null;
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < listProductInAddForm.Count; i++)
            {
                lbListProductChild.Items.Add($"{listProductInAddForm[i].Name}, {listProductInAddForm[i].Charact}, {listProductInAddForm[i].Descr}");
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if(lbListProductChild.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали товар");
                return;
            }
            n = lbListProductChild.SelectedIndex;
            flagProductAdd = false;
            Calc();
        }

        private void Calc()
        {
            for (int i = 0; i < listProductInAddForm.Count; i++)
            {
                if (lbListProductChild.SelectedItem.ToString() == $"{listProductInAddForm[i].Name}, {listProductInAddForm[i].Charact}, {listProductInAddForm[i].Descr}")
                {
                    this.prod = listProductInAddForm[i];
                    if (flagProductAdd == false)
                    {
                        this.Text = "Редоктирование товара";
                        this.tbName.Text = prod.Name;
                        this.tbCharacteristic.Text = prod.Charact;
                        this.tbDescribe.Text = prod.Descr;
                        this.tbPrice.Text = prod.Price.ToString();
                    }
                }
            }
        }

        private void btnSaveEditProduct_Click(object sender, EventArgs e)
        {
            if (flagProductAdd == false)
            {
                lbListProductChild.Items.RemoveAt(n);
                if(!lbListProductChild.Items.Contains(prod))
                {
                    var tname = tShop.Controls[NameCmBoxComputerShop];
                    ((ComboBox)tname).Items.RemoveAt(n);
                    listProductInAddForm.RemoveAt(n);
                    prod = null;
                    prod = new Product();
                    this.Text = "Редоктирование товара";
                    prod.Name = this.tbName.Text;
                    prod.Charact = this.tbCharacteristic.Text;
                    prod.Descr = this.tbDescribe.Text;
                    try
                    {
                        prod.Price = Convert.ToDouble(tbPrice.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Цена указана неверно");
                        return;
                    }
                    lbListProductChild.Items.Insert(n, $"{prod.Name}, {prod.Charact}, {prod.Descr}");
                    ((ComboBox)tname).Items.Insert(n, prod.Name);
                    listProductInAddForm.Insert(n, prod);
                    //tShop.AddToComboBox(prod);
                }
            }
            this.Text = "Form Add Product";
        }
    }
}
