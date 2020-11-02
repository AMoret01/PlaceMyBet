﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace WebAPI_AE2.Models
{
    public class Repositorio_Evento
    {
        private MySqlConnection conexion()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=placemybet;SslMode=none";
            MySqlConnection conexion = new MySqlConnection(connectionString);
            return conexion;

        }

        internal List<Evento> retrieve()
        {
            MySqlConnection conectar = conexion();
            MySqlCommand command = conectar.CreateCommand();
            command.CommandText = "SELECT * FROM evento";

            try
            {
                conectar.Open();
                MySqlDataReader reader = command.ExecuteReader();
                List<Evento> evento = new List<Evento>();

                while (reader.Read())
                {
                    Evento e = new Evento(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetMySqlDateTime(3).ToString());
                    evento.Add(e);

                }
                conectar.Close();
                return evento;
            }
            catch (MySqlException e)
            {
                Debug.WriteLine("Error al conectar a la base de datos. ");
                return null;
            }
        }
    }
}