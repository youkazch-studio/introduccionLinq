using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduucionLINQ
{
    class Product
    {

        public int codProduct { get; set; }

        public string productname { get; set; }

        public string productDescription { get; set; }

        public double buyPrice { get; set; }

        public string categorias { get; set; }

        //metodo para definir una colleccion de datos

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product{codProduct=8902, productname="Palomitas de maiz", productDescription="comida ligera", buyPrice= 0.99, categorias="aperitivos"},
                new Product{codProduct=0534, productname="Pepsi", productDescription="bebida carbonatada", buyPrice=1.90,categorias="Bebidas"},
                new Product{codProduct=7892, productname="Arroz San Pedro", productDescription="arroz precosido", buyPrice=1.50,categorias="Gano basico"},
                new Product{codProduct=9345, productname="Manzanas", productDescription="Manzanas por una libra", buyPrice=1.50,categorias="Frutas"},
                new Product{codProduct=8490, productname="Carne para azar", productDescription="corte lizo por libra", buyPrice=3.90,categorias="carnes rojas"}
            };

            return products;
            //retornamos lista de producctos


        }
    }
}

