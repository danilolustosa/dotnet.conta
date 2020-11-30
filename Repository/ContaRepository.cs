using BancoEveris.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace BancoEveris.Repository
{
    public class ContaRepository
    {

        public string ConnectionString = "Data Source=DANILO\\SQLEXPRESS;Initial Catalog=BancoEveris;Integrated Security=True";


        public List<Conta> Lista()
        {
            string query = @"
                       SELECT id, hash FROM Conta
                        ";

            var con = new SqlConnection(ConnectionString);
            con.Open();
            return con.Query<Conta>(query).ToList();
        }

    }
}
