using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace realPlazaApi.Models
{
    public class ProductModel
    {
        public string id { get; set; }
        public string idShop { get; set; }
        public string nameShop { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string urlImg { get; set; }


        public List<ProductModel> GetListProduct(int idShop)
        {
            List<ProductModel> list = new List<ProductModel>();
            SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConBD"].ConnectionString);
            Con.Open();
            SqlCommand Comando = new SqlCommand("ListProductsxShop", Con);
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.CommandTimeout = 0;
            Comando.Parameters.Add("@idShop", System.Data.SqlDbType.Int).Value = idShop;

            SqlDataReader Reader = Comando.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    ProductModel mj = new ProductModel();
                    mj.id = Reader["id_producto"].ToString();
                    mj.idShop = Reader["id_tienda"].ToString();
                    mj.nameShop = Reader["tienda"].ToString();
                    mj.name = Reader["descripcion"].ToString();
                    mj.price = Reader["precio_unitario"].ToString();
                    mj.urlImg = Reader["urlImg"].ToString();

                    list.Add(mj);
                }
            }
            Con.Close();
            return list;
        }

    }


}