using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace introduucionLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          selectProductCategory();
        }
        private void selectProductCategory()
        {
            List<string> categoryList = (
                from category in Product.GetProducts()
                select category.categorias
                ).ToList();

            foreach (var category in categoryList)
                lstProductsNames.Items.Add(category);
        }

        private void btngetdata_Click(object sender, EventArgs e)
        {
            dgAllProducts.Columns.Add("codProduct", "CODIGO DEL PRODUCTO");

            dgAllProducts.Columns.Add("name", "NOMBRE DEL PRODUCTO");

            dgAllProducts.Columns.Add("descripcion", "DESCRIPCION");

            dgAllProducts.Columns.Add("price", "PRECIO DE COMPRA");

            dgAllProducts.Columns.Add("category", "CATEGORIA DEL PRODUCTO");

            foreach (var product in selectAllProducts())
            {
                dgAllProducts.Rows.Add(product.codProduct, product.productname, product.productDescription, product.buyPrice, product.categorias);
            }
        }

        private List<Product> selectAllProducts()
        {
            List<Product> getAllProducts = (
                from product in Product.GetProducts()
                select new Product()
                {
                    codProduct = product.codProduct,
                    productname = product.productname,
                    productDescription = product.productDescription,
                    buyPrice = product.buyPrice,
                    categorias = product.categorias,

                }

                ).ToList();

            return getAllProducts;
        }
    }
}
