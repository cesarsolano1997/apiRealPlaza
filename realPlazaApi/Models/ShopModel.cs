using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace realPlazaApi.Models
{
    public class ShopModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string bussinesHours { get; set; }
        public string urlImg { get; set; }
        public string urlLogo { get; set; }

        public List<ShopModel> GetListShop(int idMall)
        {
            List<ShopModel> list = new List<ShopModel>();
            SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConBD"].ConnectionString);
            Con.Open();
            SqlCommand Comando = new SqlCommand("ListShopxMall", Con);
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.CommandTimeout = 0;
            Comando.Parameters.Add("@idMall", System.Data.SqlDbType.Int).Value = idMall;

            SqlDataReader Reader = Comando.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    ShopModel mj = new ShopModel();
                    mj.id = Reader["id_tienda"].ToString();
                    mj.name = Reader["descripcion"].ToString();
                    mj.address = Reader["direccion"].ToString();
                    mj.bussinesHours = "Lunes a Viernes desde las " + Reader["hora_abre"].ToString() + " hasta las " + Reader["hora_cierre"].ToString();
                    mj.urlImg = Reader["urlImg"].ToString();
                    mj.urlLogo = Reader["urlLogo"].ToString();
                    list.Add(mj);
                }
            }
            Con.Close();
            return list;
        }
    }
}