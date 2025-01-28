using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiocoDellaVita
{
	public partial class Log : Form
	{
		public Log()
		{
			InitializeComponent();
		}

		public void richTextBoxLog_TextChanged(object sender, EventArgs e)
		{
            // Misscliccato⛓️💔
        }

        // Funzioni dei TMSI -- ToolStripMenuItem
        private void resetToolStripMenuItem_Click(object sender, EventArgs e) => richTextBoxLog.Text = "";
		private void chiudiToolStripMenuItem_Click(object sender, EventArgs e) => this.Hide();
		private void piccoloToolStripMenuItem_Click(object sender, EventArgs e) => richTextBoxLog.Font = new Font(richTextBoxLog.Font.FontFamily, 9);
        private void medioToolStripMenuItem_Click(object sender, EventArgs e) => richTextBoxLog.Font = new Font(richTextBoxLog.Font.FontFamily, 12);
		private void grandeToolStripMenuItem_Click(object sender, EventArgs e) => richTextBoxLog.Font = new Font(richTextBoxLog.Font.FontFamily, 16);
	}
}
