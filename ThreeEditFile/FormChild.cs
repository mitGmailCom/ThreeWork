using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeEditFile
{
    public partial class FormChild : Form
    {
        public string text { get; set; } = null;
        private FormParent FormP = new FormParent();

        public FormChild()
        {
            InitializeComponent();
        }

        public FormChild(FormParent parentF)
        {
            InitializeComponent();
            FormP = parentF;
        }

        private void FormChild_Load(object sender, EventArgs e)
        {
            this.tbEditFile.Text = text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            text = this.tbEditFile.Text;
            FormP.Calcul(this);
        }
    }
}
