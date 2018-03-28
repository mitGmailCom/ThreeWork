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
    public partial class FormChildSearchFiles : Form
    {
        public bool flagKeyPressEnter { get; private set; } = false;
        FolderBrowserDialog fbd;
        public string path { get; private set; } = null;
        public string maskF { get; private set; } = null;
        public string[] filesDir;
        public string[] filesChild { get; set; }
        public FormSearchFilesParent ff;

        public FormChildSearchFiles()
        {
            InitializeComponent();
        }

        public FormChildSearchFiles(FormSearchFilesParent formP)
        {
            InitializeComponent();
            ff = new FormSearchFilesParent();
            ff = formP;
        }
        
                
        private void tbFolder_MouseClick(object sender, MouseEventArgs e)
        {
            fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            path = fbd.SelectedPath;
            this.tbFolder.Text = path;
        }

        private void tbMaskaFilles_TextChanged(object sender, EventArgs e)
        {

            if (flagKeyPressEnter == true)
            {
                maskF = this.tbMaskaFilles.Text;
                filesDir = Directory.GetFiles(path, maskF);
                filesChild = filesDir;
                ff.Calculate();
            }
        }

        private void tbMaskaFilles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "\r")
            {
                flagKeyPressEnter = true;
                tbMaskaFilles_TextChanged(sender, e);
            }
        }
    }
}
