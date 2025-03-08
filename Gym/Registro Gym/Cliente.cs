using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Gym
{
    class Cliente
    {
        public static int ContadorID = 0;
        public int id { get; set; }
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public int edad { get; set; }
        public string? movil { get; set; }


    }
}
