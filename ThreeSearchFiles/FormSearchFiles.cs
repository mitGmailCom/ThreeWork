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

namespace ThreeSearchFiles
{
    public partial class FormSearchFilesParent : Form
    {
        public string[] ttt { get; set; } = null;
        FormChildSearchFiles formSearch;

        public FormSearchFilesParent()
        {
            InitializeComponent();
        }

        public void AddIt()
        {
            for (int i = 0; i < formSearch.filesChild.Length; i++)
            {
                this.listBox1.Items.Add(formSearch.filesChild[i]);
            }
        }

        public void Calculate()
        {
                if (formSearch.filesChild != null)
                {
                    foreach (var item in formSearch.filesChild)
                    {
                        this.listBox1.Items.Add(item);

                    }
                }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            formSearch = new FormChildSearchFiles(this);
            formSearch.Show();
        }
    } 
}
