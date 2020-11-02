using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_AE2.Models
{
    public class Mercado
    {
        public Mercado(int id_Mercado, double cuota_Over, double cuota_Under, double dinero_Over, double dinero_Under, double tipo_Mercado, int id_Evento)
        {
            Id_Mercado = id_Mercado;
            Cuota_Over = cuota_Over;
            Cuota_Under = cuota_Under;
            Dinero_Over = dinero_Over;
            Dinero_Under = dinero_Under;
            Tipo_Mercado = tipo_Mercado;
            Id_Evento = id_Evento;
        }

        public int Id_Mercado { get; set; }
        public double Cuota_Over { get; set; }
        public double Cuota_Under { get; set; }
        public double Dinero_Over { get; set; }
        public double Dinero_Under { get; set; }
        public double Tipo_Mercado { get; set; }
        public int Id_Evento { get; set; }
    }
}