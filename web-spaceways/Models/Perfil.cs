using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_spaceways.Models
{
    public class Perfil
    {
        public int IdPerfil { get; set; }
        public string Tipo { get; set; }
        public int Idade { get; set; }
        public string Interesse { get; set; }
        public Risco Risco { get; set; }
    }
}
