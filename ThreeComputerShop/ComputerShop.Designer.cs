namespace ThreeComputerShop
{
    partial class ComputerShop
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listbSales = new System.Windows.Forms.ListBox();
            this.cmbLisProduct = new System.Windows.Forms.ComboBox();
            this.btnAddToSales = new System.Windows.Forms.Button();
            this.lbPrice = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTotalText = new System.Windows.Forms.Label();
            this.lbPriceText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listbSales
            // 
            this.listbSales.FormattingEnabled = true;
            this.listbSales.Location = new System.Drawing.Point(0, 0);
            this.listbSales.MultiColumn = true;
            this.listbSales.Name = "listbSales";
            this.listbSales.ScrollAlwaysVisible = true;
            this.listbSales.Size = new System.Drawing.Size(259, 134);
            this.listbSales.TabIndex = 0;
            // 
            // cmbLisProduct
            // 
            this.cmbLisProduct.FormattingEnabled = true;
            this.cmbLisProduct.Location = new System.Drawing.Point(0, 140);
            this.cmbLisProduct.Name = "cmbLisProduct";
            this.cmbLisProduct.Size = new System.Drawing.Size(375, 21);
            this.cmbLisProduct.TabIndex = 1;
            this.cmbLisProduct.SelectedIndexChanged += new System.EventHandler(this.cmbLisProduct_SelectedIndexChanged);
            // 
            // btnAddToSales
            // 
            this.btnAddToSales.Location = new System.Drawing.Point(265, 84);
            this.btnAddToSales.Name = "btnAddToSales";
            this.btnAddToSales.Size = new System.Drawing.Size(110, 50);
            this.btnAddToSales.TabIndex = 2;
            this.btnAddToSales.Text = "ADD TO SALES";
            this.btnAddToSales.UseVisualStyleBackColor = true;
            this.btnAddToSales.Click += new System.EventHandler(this.btnAddToSales_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrice.Enabled = false;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPrice.Location = new System.Drawing.Point(327, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(48, 39);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddProduct.Location = new System.Drawing.Point(0, 167);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(379, 62);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "ADD PRODUCT";
            this.btnAddProduct.UseMnemonic = false;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTotal.Location = new System.Drawing.Point(328, 42);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(47, 36);
            this.lbTotal.TabIndex = 5;
            // 
            // lbTotalText
            // 
            this.lbTotalText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTotalText.Location = new System.Drawing.Point(265, 42);
            this.lbTotalText.Name = "lbTotalText";
            this.lbTotalText.Size = new System.Drawing.Size(47, 39);
            this.lbTotalText.TabIndex = 6;
            this.lbTotalText.Text = "Всего";
            this.lbTotalText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPriceText
            // 
            this.lbPriceText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPriceText.Location = new System.Drawing.Point(265, 0);
            this.lbPriceText.Name = "lbPriceText";
            this.lbPriceText.Size = new System.Drawing.Size(47, 39);
            this.lbPriceText.TabIndex = 7;
            this.lbPriceText.Text = "Цена";
            this.lbPriceText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComputerShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 229);
            this.Controls.Add(this.lbPriceText);
            this.Controls.Add(this.lbTotalText);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.btnAddToSales);
            this.Controls.Add(this.cmbLisProduct);
            this.Controls.Add(this.listbSales);
            this.Name = "ComputerShop";
            this.Text = "Магазин комплектующих";
            this.Load += new System.EventHandler(this.ComputerShop_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listbSales;
        private System.Windows.Forms.ComboBox cmbLisProduct;
        private System.Windows.Forms.Button btnAddToSales;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTotalText;
        private System.Windows.Forms.Label lbPriceText;
    }
}

