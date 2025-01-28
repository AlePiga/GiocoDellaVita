using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace GiocoDellaVita
{
	public partial class Campo : Form
	{
		public string Tema { get; set; }
		public int Dimensioni { get; set; }

		public static Matrice matrice;
		public static Label LabelLog = new Label();
		Log log = new Log();

		private System.Windows.Forms.Timer delay;
		private int delayUtente = 1000;

		public Campo(string tema, int dimensioni) // Costruttore pubblico
		{
			InitializeComponent();
			Tema = tema;
			Dimensioni = dimensioni;
			matrice = new Matrice(Dimensioni);
		}

		private void InizializzaTLP() // Metodo per inizializzare il TLP su cui verrà visualizzata la matrice
		{
			TLPCampo.Controls.Clear();
			TLPCampo.RowStyles.Clear();
			TLPCampo.ColumnStyles.Clear();
			TLPCampo.RowCount = matrice.Dimensioni;
			TLPCampo.ColumnCount = matrice.Dimensioni;

			float percentuale = 100f / Dimensioni;
			for (int i = 0; i < Dimensioni; i++)
			{
				TLPCampo.RowStyles.Add(new RowStyle(SizeType.Percent, percentuale));
				TLPCampo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, percentuale));
			}
		}

		private void Campo_Load(object sender, EventArgs e) // Inizializzazione elementi all'avvio del form Campo
		{
			InizializzaTLP();
			pictureBoxLogo.BackgroundImage = Image.FromFile($"Immagini/Loghi/{Tema}.png");
			panelLabel.Controls.Add(LabelLog);
			LabelLog.Text = $"[{Campo.GetOra()}] Clicca \"Inizia\" per iniziare la simulazione!";
			LabelLog.Dock = DockStyle.Fill;
			matrice.InizializzaCampo();
			StampaMatrice();
		}

		private void Inizia() // Inizializza il TableLayoutPanel e stampa gli animali disposti casualmente, fa partire il delay e stampa nella log "Simulazione iniziata!"
		{
			InizializzaTLP();
			StampaMatrice();

			LabelLog.Text = $"[{Campo.GetOra()}] Simulazione iniziata!";
			delay = new System.Windows.Forms.Timer { Interval = delayUtente };
			delay.Tick += Delay_Tick;
			delay.Start();
		}

		public void Delay_Tick(object sender, EventArgs e)
		{
			matrice.AggiornaCreature();
			StampaMatrice();
            log.richTextBoxLog.AppendText(LabelLog.Text + "\n"); // Aggiorna il testo alla LabelLog

            if (matrice.Piante.Count == 0 && matrice.Erbivori.Count == 0 && matrice.Carnivori.Count == 0 && matrice.Semi.Count == 0) // Quando il campo è completamente vuoto il delay si ferma e finisce la partita
			{
				delay.Stop();
				MessageBox.Show("Simulazione terminata!\nPremi \"Reset\" e \"Inizia\" per iniziare una nuova partita.", "Fine!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		public void StampaMatrice()
		{
			TLPCampo.Controls.Clear();

			for (int y = 0; y < matrice.Dimensioni; y++) // Scorre Y
			{
				for (int x = 0; x < matrice.Dimensioni; x++) // Scorre X
				{
					Cella cella = matrice.GetCella(x, y);
					Button creatura = new Button
					{
						Dock = DockStyle.Fill,
						BackgroundImage = cella.Presenza switch // Controlla cosa si trova nelle celle per assegnare l'immagine giusta
						{
							Pianta => Image.FromFile($"./Immagini/Temi/{Tema}/p.png"),
							Erbivoro => Image.FromFile($"./Immagini/Temi/{Tema}/e.png"),
							Carnivoro => Image.FromFile($"./Immagini/Temi/{Tema}/k.png"),
							Seme => Image.FromFile($"./Immagini/Temi/{Tema}/s.png"),
							null => null
						},
						BackColor = cella.Presenza switch // Controlla l'energia delle creature per mettere il colore giusto
						{
							Pianta p => GetColore(p.Energia),
							Erbivoro e => GetColore(e.Energia),
							Carnivoro c => GetColore(c.Energia),
							Seme s => Color.FromArgb(128, 0, 0, 255),
							null => Color.Transparent
						},
						BackgroundImageLayout = ImageLayout.Stretch,
						Enabled = false, // Il bottone non può essere premuto
						TabStop = true // Il bottone non può essere selezionato con tab
					};

					TLPCampo.Controls.Add(creatura, x, y); // Aggiunge la creatura al campo
				}
			}
		}

		public Color GetColore(int energia) // Metodo per determinare il colore in base al livello di energia
		{
			return energia switch
			{
				> 66 => Color.FromArgb(128, 0, 255, 0), // Verde
				> 33 => Color.FromArgb(128, 255, 255, 0), // Giallo
				< 32 => Color.FromArgb(128, 255, 0, 0) // Rosso
			};
		}

		public static string GetOra() => DateTime.Now.ToString("HH:mm:ss");

		private void Reset() // Resetta la matrice e inizializza il campo in base agli elementi che contiene
		{
			matrice.Reset();
			InizializzaTLP();
			StampaMatrice();
		}

		public void PlayMusic(string musica) // Metodo per ascoltare la musica
		{
			string percorso = $"Musica/{musica}.wav";
			SoundPlayer player = new SoundPlayer(percorso);
			player.PlayLooping();
		}

		private void CambiaDelay(int nuovoDelay) // Metodo per modificare il delay
		{
			delayUtente = nuovoDelay;
			if (delay != null)
			{
				delay.Interval = delayUtente;
			}

		}

		private void TSMIRiconoscimenti_Click(object sender, EventArgs e) // MessageBox con riconoscimenti
		{
			MessageBox.Show(
				"\"GIOCO DELLA VITA\"\n" +
				"Progetto scolastico sviluppato da Alessandro Pigaiani\n\n" +
				"MUSICA\n" +
                "- Traccia #1: \"Map 2: Overworld\" di Koji Kondo\n" +
                "- Traccia #2: \"Driftveil City BG\" di Hitomi Sato e Go Ichinose\n" +
				"- Traccia #3: \"Beat Konadu 1\" di Manuel Dalla Santa\n\n" +
				"DISEGNI DELLE CREATURE\n" +
				"Emoji di Microsoft Windows",
				"Riconoscimenti", MessageBoxButtons.OK, MessageBoxIcon.Information
			);
		}

		private void TSMIGitHub_Click(object sender, EventArgs e) // Reindirizza alla pagina GitHub del gioco, chiede all'utente se vuole uscire effettivamente
		{
			DialogResult result = MessageBox.Show(
				"Vuoi visitare il repository GitHub del gioco?\nCliccando su \"Sì\" verrai reindirizzato al di fuori dell'applicazione.",
				"Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question
			);

			if (result == DialogResult.Yes)
			{
				System.Diagnostics.Process.Start("cmd", "/c start https://github.com/itisrossi/classi-AlessandroPigaiani/tree/GiocoDellaVita");
			}
		}

		private void pictureBoxLogo_Click(object sender, EventArgs e)
		{
			// Misscliccato⛓️💔
		}

		private void buttonLogForm_Click(object sender, EventArgs e) // Se il form log è visibile lo mette in evidenza, altrimenti lo apre
		{
			if (log.Visible)
			{
				log.Activate();
			}
			else
			{
				log.Show();
			}
		}

		// Funzioni dei bottoni
		private void buttonInizia_Click(object sender, EventArgs e) => Inizia();
        private void buttonReset_Click(object sender, EventArgs e) => Reset();
        
		// Funzioni dei TMSI -- ToolStripMenuItem
		private void TMSIInizia_Click(object sender, EventArgs e) => Inizia();
		private void TMSIReset_Click(object sender, EventArgs e) => Reset();

		private void traccia1ToolStripMenuItem_Click(object sender, EventArgs e) => PlayMusic("1");
		private void traccia2ToolStripMenuItem_Click(object sender, EventArgs e) => PlayMusic("2");
		private void traccia3ToolStripMenuItem_Click(object sender, EventArgs e) => PlayMusic("3");
		private void nessunaToolStripMenuItem_Click(object sender, EventArgs e) => PlayMusic("Silent");

		private void TSMIDelayAlto_Click(object sender, EventArgs e) => CambiaDelay(2000);
		private void TSMIDelayMedio_Click(object sender, EventArgs e) => CambiaDelay(1000);
		private void TMSIDelayBasso_Click(object sender, EventArgs e) => CambiaDelay(500);
		private void TMSINoDelay_Click(object sender, EventArgs e) => CambiaDelay(1);
	}
}