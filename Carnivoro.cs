using System;

namespace GiocoDellaVita
{
	public class Carnivoro : ICreatura
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Energia { get; set; } = 100;

		public Carnivoro(int x, int y) 
		{ 
			X = x; 
			Y = y; 
		}

		public void Aggiorna()
		{
			Energia -= 10;
			if (Energia <= 0) 
			{ 
				Muori();
			}
			else Muovi();
		}

		public void Muovi()
		{
            List<Erbivoro> erbivoriAdiacenti = new List<Erbivoro>();

			for (int dx = -1; dx <= 1; dx++) // Controlla celle adiacenti per trovare erbivori
            {
				for (int dy = -1; dy <= 1; dy++)
				{
					if (dx == 0 && dy == 0) continue; // Ignora caso dx == 0 && dy == 0

                    int nuovaX = ((X + Campo.matrice.rand.Next(-1, 2)) % Campo.matrice.Dimensioni + Campo.matrice.Dimensioni) % Campo.matrice.Dimensioni; // X in modo che non sia fuori dai confini della matrice
                    int nuovaY = ((Y + Campo.matrice.rand.Next(-1, 2)) % Campo.matrice.Dimensioni + Campo.matrice.Dimensioni) % Campo.matrice.Dimensioni; // Y in modo che non sia fuori dai confini della matrice

                    Cella cella = Campo.matrice.GetCella(nuovaX, nuovaY);
					if (cella.Presenza is Erbivoro erbivoro)
					{
						erbivoriAdiacenti.Add(erbivoro);
					}
				}
			}

			if (erbivoriAdiacenti.Count > 0)
			{
				// Se ci sono erbivori adiacenti ne sceglie uno e se lo mangia
				Erbivoro preda = erbivoriAdiacenti[Campo.matrice.rand.Next(erbivoriAdiacenti.Count)];
				Mangia(preda);
			}
			else
			{
				// Se non ci sono erbivori si muove in una cella vuota
				int nuovaX = ((X + Campo.matrice.rand.Next(-1, 2)) % Campo.matrice.Dimensioni + Campo.matrice.Dimensioni) % Campo.matrice.Dimensioni; // X in modo che non sia fuori dai confini della matrice
                int nuovaY = ((Y + Campo.matrice.rand.Next(-1, 2)) % Campo.matrice.Dimensioni + Campo.matrice.Dimensioni) % Campo.matrice.Dimensioni; // Y in modo che non sia fuori dai confini della matrice

                Cella nuovaCella = Campo.matrice.GetCella(nuovaX, nuovaY);
				if (nuovaCella.èVuota)
				{
					Campo.matrice.GetCella(X, Y).Presenza = null;
					X = nuovaX;
					Y = nuovaY;
					nuovaCella.Presenza = this;
				}
			}
		}

		private void Mangia(Erbivoro erbivoro) // Metodo con cui il carnivoro mangia le prede
        {
			Energia += 50;
			Campo.LabelLog.Text = $"[{Campo.GetOra()}] Un carnivoro a ({X},{Y}) ha mangiato un erbivoro a ({erbivoro.X},{erbivoro.Y}).";
			Campo.matrice.GetCella(erbivoro.X, erbivoro.Y).Presenza = null;
			Campo.matrice.Erbivori.Remove(erbivoro);
		}

		public void Muori() // Metodo con cui il carnivoro muore
        {
			Campo.LabelLog.Text = $"[{Campo.GetOra()}] Un carnivoro a ({X},{Y}) è morto.";
			Campo.matrice.GetCella(X, Y).Presenza = null;
			Campo.matrice.Carnivori.Remove(this);
		}
	}
}