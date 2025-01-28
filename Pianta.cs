using GiocoDellaVita;

public class Pianta : ICreatura
{
	public int X { get; set; }
	public int Y { get; set; }
	public int Energia { get; set; } = 100;
	private int TempoSeme { get; set; } = 3;

	public Pianta(int x, int y)
	{
		X = x;
		Y = y;
	}

	public void Aggiorna()
	{
		TempoSeme--;
		Energia -= 20;
		if (TempoSeme <= 0)
		{
			Random random = new Random();
			if(random.Next(0, 3) == 0) // Probabilità del 33% che spawni il seme
			{
				SpawnaSeme();
			}
			TempoSeme = 3; // Reset del tempo
		}
		if (Energia <= 0)
		{
			Muori();
		}
	}

	private void SpawnaSeme()
	{
		int semeX = ((X + Campo.matrice.rand.Next(-1, 2)) % Campo.matrice.Dimensioni + Campo.matrice.Dimensioni) % Campo.matrice.Dimensioni; // X in modo che non sia fuori dai confini della matrice
		int semeY = ((Y + Campo.matrice.rand.Next(-1, 2)) % Campo.matrice.Dimensioni + Campo.matrice.Dimensioni) % Campo.matrice.Dimensioni; // Y in modo che non sia fuori dai confini della matrice
		var cella = Campo.matrice.GetCella(semeX, semeY);

		if (cella.èVuota)
		{
			Seme nuovoSeme = new Seme(semeX, semeY);
			cella.Presenza = nuovoSeme;
			Campo.matrice.Semi.Add(nuovoSeme);
			Campo.LabelLog.Text = $"[{Campo.GetOra()}] Una pianta a ({X},{Y}) ha generato un seme a ({semeX},{semeY}).";
		}
	}

	public void Muori()
	{
		Campo.LabelLog.Text = $"[{Campo.GetOra()}] Una pianta a ({X},{Y}) è morta.";
		Cella cella = Campo.matrice.GetCella(X, Y);
		if (cella.Presenza == this)
		{
			cella.Presenza = null;
		}
		Campo.matrice.Piante.Remove(this);
	}

	public void Muovi()
	{
		// La pianta non si muove
	}
}