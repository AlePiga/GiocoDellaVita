using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{
	public interface ICreatura
	{
		public int X {  get; set; }
		public int Y { get; set; }

		public void Aggiorna();
		public void Muovi();
		public void Muori();
	}
}