using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_spaceways.Models
{
    public class ObjetoCeleste
    {
        public int IdObjeto { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Tamanho { get; set; }
        public string Distancia { get; set; }
        public string Orbita { get; set; }
        public string Rotacao { get; set; }
        public string Formacao { get; set; }
        public string Fatos { get; set; }
        public string Cultura { get; set; }
        public string Atmosfera { get; set; }
        public double Temperatura { get; set; }
        public string Observacao { get; set; }
    }
}
