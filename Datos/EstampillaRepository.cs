using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Datos
{
    public class EstampillaRepository
    {
        private readonly SqlConnection _connection;
        private readonly List<Estampilla> _personas = new List<Estampilla>();
        public EstampillaRepository(ConnectionManager connection)
        {
             _connection = connection._conexion;
        }

        public void Guardar(Estampilla estampilla)
        {
            using (var command = _connection.CreateCommand())
            {

                command.CommandText = @"Insert Into Copago (NContrato,ObjContrato,VContrato,ApoyaCovid19,VEstampilla) 
                                        values (@NContrato,ObjContrato,@VContrato,@ApoyaCovid19,@VEstampilla)";
                command.Parameters.AddWithValue("@NContrato", estampilla.NContrato);
                command.Parameters.AddWithValue("@ObjContrato", estampilla.ObjContrato);
                command.Parameters.AddWithValue("@VContrato", estampilla.VContrato);
                command.Parameters.AddWithValue("@ApoyaCovid19", estampilla.ApoyaCovid19);
                command.Parameters.AddWithValue("@VEstampilla", estampilla.VEstampilla);
                var filas = command.ExecuteNonQuery();
            }
        }

        public List<Estampilla> ConsultarTodos()
        {
            SqlDataReader dataReader;
            List<Estampilla> estampillas = new List<Estampilla>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from estampilla ";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Estampilla estampilla = DataReaderMapToPerson(dataReader);
                        estampillas.Add(estampilla);
                    }
                }
            }
            return estampillas;
        }

        private Estampilla DataReaderMapToPerson(SqlDataReader dataReader)
        {
            if(!dataReader.HasRows) return null;
            Estampilla estampilla = new Estampilla();
            estampilla.NContrato = (string)dataReader["NContrato"];
            estampilla.ObjContrato = (string)dataReader["ObjContrato"];
            estampilla.VContrato = (decimal)dataReader["VContrato"];
            estampilla.ApoyaCovid19 = (string)dataReader["ApoyaCovid19"];
            estampilla.VEstampilla = (decimal)dataReader["VEstampilla"];
            
            return estampilla;
        }
        
    }
}