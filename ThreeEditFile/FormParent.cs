using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeEditFile
{
    public partial class FormParent : Form
    {
        FormChild formChild;
        public FormParent()
        {
            InitializeComponent();
        }

        private void FormParent_Load(object sender, EventArgs e)
        {
            formChild = null;
        }

        public void Calcul(FormChild childF)
        {
            this.tbShowFile.Text = childF.text;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Текстовый файлы | *.txt";
            open.FilterIndex = 0;
            if (open.ShowDialog() == DialogResult.OK)
            {
                this.tbShowFile.Text = File.ReadAllText(open.FileName);
            }
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (formChild != null)
                formChild.Close();
            formChild = new FormChild(this);
            formChild.text = this.tbShowFile.Text;
            formChild.Show();
        }
    }
}
