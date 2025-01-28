using System;
using System.Collections.Generic;
using System.Threading;

namespace GiocoDellaVita
{
	public class Matrice
	{
		public int Dimensioni { get; set; }
		public Random rand = new Random(); // Variabile random utilizzata in questa classe e nelle classi delle creature
		public Cella[,] campo;

		public List<Pianta> Piante { get; set; } = new List<Pianta>(); // Lista di piante
		public List<Erbivoro> Erbivori { get; set; } = new List<Erbivoro>(); // Lista di erbivori
		public List<Carnivoro> Carnivori { get; set; } = new List<Carnivoro>(); // Lista di carnivori
		public List<Seme> Semi { get; set; } = new List<Seme>(); // Lista di semi

		public Matrice(int dimensioni)
		{
			Dimensioni = dimensioni;
			campo = new Cella[Dimensioni, Dimensioni]; 
		}

		public void Inizia()
		{
			while (Piante.Count > 0 && Erbivori.Count > 0 && Carnivori.Count > 0)
			{
				Thread.Sleep(2000);
				AggiornaCreature();
			}
		}

		public void InizializzaCampo()
		{
			for (int i = 0; i < this.Dimensioni; i++)
			{
				for (int j = 0; j < this.Dimensioni; j++)
				{
					campo[i, j] = new Cella(i, j);
				}
			}

			int celleTotali = this.Dimensioni * this.Dimensioni;

			int numPiante = (int)(celleTotali * 0.2); // 20% piante
			int numErbivori = (int)(celleTotali * 0.1); // 10% erbivori
			int numCarnivori = (int)(celleTotali * 0.05); // 5% carnivori

			PopolaCampo(numPiante, typeof(Pianta));
			PopolaCampo(numErbivori, typeof(Erbivoro));
			PopolaCampo(numCarnivori, typeof(Carnivoro));
		}

		public void PopolaCampo(int count, Type type) // Popola il campo con il numero giusto di creature per tipo
		{
			for (int i = 0; i < count; i++)
			{
				int x, y;
				do
				{
					x = rand.Next(this.Dimensioni);
					y = rand.Next(this.Dimensioni);
				} while (!campo[x, y].èVuota);

				if (type == typeof(Pianta))
				{
					Pianta pianta = new Pianta(x, y);
					campo[x, y].Presenza = pianta;
					Piante.Add(pianta);
				}
				else if (type == typeof(Erbivoro))
				{
					Erbivoro erbivoro = new Erbivoro(x, y);
					campo[x, y].Presenza = erbivoro;
					Erbivori.Add(erbivoro);
				}
				else if (type == typeof(Carnivoro))
				{
					Carnivoro carnivoro = new Carnivoro(x, y);
					campo[x, y].Presenza = carnivoro;
					Carnivori.Add(carnivoro);
				}
			}
		}

		public void AggiornaCreature() // Richiama il metodo per aggiornare per ogni creatura
		{
			foreach (Pianta pianta in new List<Pianta>(Piante)) // new List<Creatura>(Creature) per evitare problemi di enumerzione
            {
				pianta.Aggiorna();
			}
			foreach (Erbivoro erbivoro in new List<Erbivoro>(Erbivori))
			{
				erbivoro.Aggiorna();
			}
			foreach (Carnivoro carnivoro in new List<Carnivoro>(Carnivori))
			{
				carnivoro.Aggiorna();
			}
			foreach (Seme seme in new List<Seme>(Semi))
			{
				seme.Aggiorna();
			}
		}

		public Cella GetCella(int x, int y)
		{
			return campo[x, y];
		}

		public void Reset() // Resetta il gioco
		{
			foreach (Cella cella in campo)
			{
				cella.Presenza = null;
			}

			Piante.Clear();
			Erbivori.Clear();
			Carnivori.Clear();
			InizializzaCampo();
		}
	}
}