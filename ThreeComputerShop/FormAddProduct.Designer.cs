namespace ThreeComputerShop
{
    partial class FormAddProduct
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
            this.lbListProductChild = new System.Windows.Forms.ListBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnAddProductChild = new System.Windows.Forms.Button();
            this.tbCharacteristic = new System.Windows.Forms.TextBox();
            this.tbDescribe = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnSaveEditProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbListProductChild
            // 
            this.lbListProductChild.FormattingEnabled = true;
            this.lbListProductChild.HorizontalScrollbar = true;
            this.lbListProductChild.Location = new System.Drawing.Point(134, 0);
            this.lbListProductChild.MultiColumn = true;
            this.lbListProductChild.Name = "lbListProductChild";
            this.lbListProductChild.ScrollAlwaysVisible = true;
            this.lbListProductChild.Size = new System.Drawing.Size(262, 238);
            this.lbListProductChild.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbName.Location = new System.Drawing.Point(0, 21);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(128, 40);
            this.tbName.TabIndex = 2;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAddProductChild
            // 
            this.btnAddProductChild.Location = new System.Drawing.Point(0, 244);
            this.btnAddProductChild.Name = "btnAddProductChild";
            this.btnAddProductChild.Size = new System.Drawing.Size(128, 44);
            this.btnAddProductChild.TabIndex = 5;
            this.btnAddProductChild.Text = "AddProduct";
            this.btnAddProductChild.UseVisualStyleBackColor = true;
            this.btnAddProductChild.Click += new System.EventHandler(this.btnAddProductChild_Click);
            // 
            // tbCharacteristic
            // 
            this.tbCharacteristic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCharacteristic.Location = new System.Drawing.Point(0, 80);
            this.tbCharacteristic.Multiline = true;
            this.tbCharacteristic.Name = "tbCharacteristic";
            this.tbCharacteristic.Size = new System.Drawing.Size(128, 40);
            this.tbCharacteristic.TabIndex = 6;
            this.tbCharacteristic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbDescribe
            // 
            this.tbDescribe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDescribe.Location = new System.Drawing.Point(0, 139);
            this.tbDescribe.Multiline = true;
            this.tbDescribe.Name = "tbDescribe";
            this.tbDescribe.Size = new System.Drawing.Size(128, 40);
            this.tbDescribe.TabIndex = 7;
            this.tbDescribe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPrice
            // 
            this.tbPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPrice.Location = new System.Drawing.Point(0, 198);
            this.tbPrice.Multiline = true;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(128, 40);
            this.tbPrice.TabIndex = 8;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(134, 244);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(128, 44);
            this.btnEditProduct.TabIndex = 10;
            this.btnEditProduct.Text = "EditProduct";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnSaveEditProduct
            // 
            this.btnSaveEditProduct.Location = new System.Drawing.Point(268, 244);
            this.btnSaveEditProduct.Name = "btnSaveEditProduct";
            this.btnSaveEditProduct.Size = new System.Drawing.Size(128, 44);
            this.btnSaveEditProduct.TabIndex = 11;
            this.btnSaveEditProduct.Text = "SaveEdit";
            this.btnSaveEditProduct.UseVisualStyleBackColor = true;
            this.btnSaveEditProduct.Click += new System.EventHandler(this.btnSaveEditProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Characteristics";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Describe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Price";
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 294);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveEditProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbDescribe);
            this.Controls.Add(this.tbCharacteristic);
            this.Controls.Add(this.btnAddProductChild);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbListProductChild);
            this.Name = "FormAddProduct";
            this.Text = "FormAddProduct";
            this.Load += new System.EventHandler(this.FormAddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbListProductChild;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnAddProductChild;
        private System.Windows.Forms.TextBox tbCharacteristic;
        private System.Windows.Forms.TextBox tbDescribe;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnSaveEditProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}