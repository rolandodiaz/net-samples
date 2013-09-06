using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WcfService1
{
    
    public class Service1 : IService1
    {
       
        public IList<Categoria> ObtenerCategorias(){

            var lista = new List<Categoria>();
            var cnn = new SqlConnection("Data Source=.;Initial Catalog=Restaurante;Integrated Security=SSPI");

            var comando = new SqlCommand("select IdCategoria, Nombre from Categoria", cnn);

            cnn.Open();

            var reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lista.Add(new Categoria
                    {
                        IdCategoria = reader.GetInt32(reader.GetOrdinal("IdCategoria")),
                        Nombre = reader.GetString(reader.GetOrdinal("Nombre"))

                    });
                }

            }
            cnn.Dispose();
            return lista;

        }

    }
}
