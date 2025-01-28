using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{
	public class Cella
	{
		public int X { get; set; }
		public int Y { get; set; }
		public ICreatura Presenza { get; set; }

        public Cella(int x, int y)  // Costruttore pubblico
        {
            X = x;
            Y = y;
        }

        public bool èVuota // Metodo per verificare se la cella è vuota
		{
			get
			{
				return Presenza == null;
			}
		}
	}
}