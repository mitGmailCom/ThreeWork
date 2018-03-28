namespace ThreeSearchFiles
{
    partial class FormChildSearchFiles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFolder = new System.Windows.Forms.TextBox();
            this.tbMaskaFilles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbFolder
            // 
            this.tbFolder.Location = new System.Drawing.Point(97, 27);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.Size = new System.Drawing.Size(100, 20);
            this.tbFolder.TabIndex = 0;
            this.tbFolder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbFolder_MouseClick);
            // 
            // tbMaskaFilles
            // 
            this.tbMaskaFilles.Location = new System.Drawing.Point(97, 70);
            this.tbMaskaFilles.Name = "tbMaskaFilles";
            this.tbMaskaFilles.Size = new System.Drawing.Size(100, 20);
            this.tbMaskaFilles.TabIndex = 1;
            this.tbMaskaFilles.TextChanged += new System.EventHandler(this.tbMaskaFilles_TextChanged);
            this.tbMaskaFilles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaskaFilles_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Папка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Маска файлов";
            // 
            // FormChildSearchFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 113);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMaskaFilles);
            this.Controls.Add(this.tbFolder);
            this.Name = "FormChildSearchFiles";
            this.Text = "FormChildSearchFiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFolder;
        private System.Windows.Forms.TextBox tbMaskaFilles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}