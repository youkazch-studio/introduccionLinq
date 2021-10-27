
namespace introduucionLINQ
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btngetnames = new System.Windows.Forms.Button();
            this.btngetdata = new System.Windows.Forms.Button();
            this.lstProductsNames = new System.Windows.Forms.ListBox();
            this.dgAllProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btngetnames
            // 
            this.btngetnames.Location = new System.Drawing.Point(47, 102);
            this.btngetnames.Name = "btngetnames";
            this.btngetnames.Size = new System.Drawing.Size(104, 71);
            this.btngetnames.TabIndex = 0;
            this.btngetnames.Text = "Ver categorias";
            this.btngetnames.UseVisualStyleBackColor = true;
            // 
            // btngetdata
            // 
            this.btngetdata.Location = new System.Drawing.Point(47, 274);
            this.btngetdata.Name = "btngetdata";
            this.btngetdata.Size = new System.Drawing.Size(104, 69);
            this.btngetdata.TabIndex = 1;
            this.btngetdata.Text = "Mostrar productos";
            this.btngetdata.UseVisualStyleBackColor = true;
            // 
            // lstProductsNames
            // 
            this.lstProductsNames.FormattingEnabled = true;
            this.lstProductsNames.Location = new System.Drawing.Point(226, 102);
            this.lstProductsNames.Name = "lstProductsNames";
            this.lstProductsNames.Size = new System.Drawing.Size(179, 316);
            this.lstProductsNames.TabIndex = 2;
            // 
            // dgAllProducts
            // 
            this.dgAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllProducts.Location = new System.Drawing.Point(451, 102);
            this.dgAllProducts.Name = "dgAllProducts";
            this.dgAllProducts.Size = new System.Drawing.Size(322, 316);
            this.dgAllProducts.TabIndex = 3;
            this.dgAllProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgAllProducts);
            this.Controls.Add(this.lstProductsNames);
            this.Controls.Add(this.btngetdata);
            this.Controls.Add(this.btngetnames);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgAllProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btngetnames;
        private System.Windows.Forms.Button btngetdata;
        private System.Windows.Forms.ListBox lstProductsNames;
        private System.Windows.Forms.DataGridView dgAllProducts;
    }
}

