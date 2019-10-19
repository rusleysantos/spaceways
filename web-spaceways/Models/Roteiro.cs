using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_spaceways.Models
{
    public class Roteiro
    {
        public int IdRoteiro { get; set; }
        public Perfil perfil { get; set; }
        public string Observacao { get; set; }

    }
}
