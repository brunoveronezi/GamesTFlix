using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GamesTrailerFlix.Models
{
    public class Usuarios
    {
        public Usuarios()
        {
        }
        public int Id { get; set; }
        public string NomeUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public string Email { get; set; }

        private readonly static string _conn = "";

        public bool Login()
        {
            var result = false;
            var sql = "SELECT Id, NomeUsuario, SenhaUsuario FROM Usuario WHERE Email = '" + this.Email + "' ";

            try
            {
                using (var cn = new SqlConnection(_conn))
                {
                    cn.Open();

                    using (var cmd = new SqlCommand(sql, cn))
                    {
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    if (this.SenhaUsuario == dr["SenhaUsuario"].ToString())
                                    {
                                        this.Id = Convert.ToInt32(dr["Id"]);
                                        this.NomeUsuario = dr["NomeUsuario"].ToString();
                                        result = true;
                                        return result;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch 
            {
                throw;
            }
            return result;
        }
    }
}
