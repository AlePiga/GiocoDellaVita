using System;

namespace GiocoDellaVita
{
	public class Erbivoro : ICreatura
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Energia { get; set; } = 100;

		public Erbivoro(int x, int y) { X = x; Y = y; }

		public void Aggiorna()
		{
			Energia -= 15;
			if (Energia <= 0)
			{
				Muori();
			}
			else Muovi();
		}

		public void Muovi()
		{
			List<Pianta> pianteAdiacenti = new List<Pianta>();
			List<Seme> semiAdiacenti = new List<Seme>();

			for (int dx = -1; dx <= 1; dx++) // Controlla celle adiacenti per trovare cibo
			{
				for (int dy = -1; dy <= 1; dy++)
				{
					if (dx == 0 && dy == 0) continue; // Ignora caso dx == 0 && dy == 0

					int nuovaX = ((X + Campo.matrice.rand.Next(-1, 2)) % Campo.matrice.Dimensioni + Campo.matrice.Dimensioni) % Campo.matrice.Dimensioni; // X in modo che non sia fuori dai confini della matrice
                    int nuovaY = ((Y + Campo.matrice.rand.Next(-1, 2)) % Campo.matrice.Dimensioni + Campo.matrice.Dimensioni) % Campo.matrice.Dimensioni; // Y in modo che non sia fuori dai confini della matrice

                    Cella cella = Campo.matrice.GetCella(nuovaX, nuovaY);
					if (cella.Presenza is Pianta pianta)
					{
						pianteAdiacenti.Add(pianta);
					}
					else if (cella.Presenza is Seme seme)
					{
						semiAdiacenti.Add(seme);
					}
				}
			}

			if (pianteAdiacenti.Count > 0)
			{
				// Se ci sono piante adiacenti sceglie una e mangia
				Pianta gnam = pianteAdiacenti[Campo.matrice.rand.Next(pianteAdiacenti.Count)];
				MangiaPianta(gnam);
			}
			else if (semiAdiacenti.Count > 0)
			{
				// Se ci sono semi adiacenti sceglie uno e mangia
				Seme gnam = semiAdiacenti[Campo.matrice.rand.Next(semiAdiacenti.Count)];
				MangiaSeme(gnam);
			}
			else
			{
				// Se non c'è cibo si muove in una cella vuota
				int nuovaX = ((X + Campo.matrice.rand.Next(-1, 2)) % Campo.matrice.Dimensioni + Campo.matrice.Dimensioni) % Campo.matrice.Dimensioni;
				int nuovaY = ((Y + Campo.matrice.rand.Next(-1, 2)) % Campo.matrice.Dimensioni + Campo.matrice.Dimensioni) % Campo.matrice.Dimensioni;
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

		private void MangiaPianta(Pianta pianta) // Metodo con cui l'erbivoro mangia le piante
		{
			Energia += 30; 
			Campo.LabelLog.Text = $"[{Campo.GetOra()}] Un erbivoro a ({X},{Y}) ha mangiato una pianta.";
			pianta.Muori(); 
		}

		private void MangiaSeme(Seme seme) // Metodo con cui l'erbivoro mangia i semi
        {
			Energia += 10; 
			Campo.LabelLog.Text = $"[{Campo.GetOra()}] Un erbivoro a ({X},{Y}) ha mangiato un seme.";
			seme.Muori(); 
		}

		public void Muori() // Metodo con cui l'erbivoro muore
        {
			Campo.LabelLog.Text = $"[{Campo.GetOra()}] Un erbivoro a ({X},{Y}) è morto.";
			Campo.matrice.GetCella(X, Y).Presenza = null;
			Campo.matrice.Erbivori.Remove(this);
		}
	}
}