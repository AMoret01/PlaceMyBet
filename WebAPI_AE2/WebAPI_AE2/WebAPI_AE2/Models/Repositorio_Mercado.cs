﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace WebAPI_AE2.Models
{
    public class Repositorio_Mercado
    {
        private MySqlConnection conexion()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=placemybet;SslMode=none";
            MySqlConnection conexion = new MySqlConnection(connectionString);
            return conexion;

        }

        internal List<Mercado> retrieve()
        {
            MySqlConnection conectar = conexion();
            MySqlCommand command = conectar.CreateCommand();
            command.CommandText = "SELECT * FROM mercado";

            try
            {
                conectar.Open();
                MySqlDataReader reader = command.ExecuteReader();
                List<Mercado> mercado = new List<Mercado>();

                while (reader.Read())
                {
                    Mercado e = new Mercado(reader.GetInt32(0), reader.GetDouble(1), reader.GetDouble(2), reader.GetDouble(3), reader.GetDouble(4), reader.GetDouble(5), reader.GetInt32(6));
                    mercado.Add(e);

                }
                conectar.Close();
                return mercado;
            }
            catch (MySqlException e)
            {
                Debug.WriteLine("Error al conectar a la base de datos. ");
                return null;
            }
        }
    }
}