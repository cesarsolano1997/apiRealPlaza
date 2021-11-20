using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace realPlazaApi.Models
{
    public class MallModel
    {
        public string key { get; set; }
        public string name { get; set; }

        public List<MallModel> GetListMall()
        {
            List<MallModel> list = new List<MallModel>();
            SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConBD"].ConnectionString);
            Con.Open();
            SqlCommand Comando = new SqlCommand("ListMall", Con);
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.CommandTimeout = 0;

            SqlDataReader Reader = Comando.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    MallModel mj = new MallModel();
                    mj.key = Reader["id_centro_comercial"].ToString();
                    mj.name = Reader["descripcion"].ToString();
                    list.Add(mj);
                }
            }
            Con.Close();
            return list;
        }

    }
}