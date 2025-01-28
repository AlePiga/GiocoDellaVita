namespace GiocoDellaVita
{
	public partial class Impostazioni : Form
	{
		public int Dimensioni { get; set; }
		public string Tema { get; set; }

		public Impostazioni()
		{
			InitializeComponent();
		}

		private void buttonInizia_Click(object sender, EventArgs e)
		{
			
		}

        private void buttonInizia_Click_1(object sender, EventArgs e)
        {
            Dimensioni = (int)numericUpDownColonne.Value;
            Tema = comboBoxTema.Text;

            if (Tema == "") 
            {
                MessageBox.Show("Inserisci un tema prima di cominciare!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Dimensioni > 10)
            {
                DialogResult result = MessageBox.Show(
                    "Il valore di altezza del campo selezionato è molto alto. Questo potrebbe rallentare la simulazione. Vuoi continuare comunque?",
                    "Avviso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No) return;
            }

            Campo campo = new Campo(Tema, Dimensioni);
            campo.Show();
            this.Hide();
        }
    }
}