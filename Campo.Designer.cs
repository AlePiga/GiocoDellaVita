namespace GiocoDellaVita
{
    partial class Campo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Campo));
            menuStrip1 = new MenuStrip();
            TSMISimluazione = new ToolStripMenuItem();
            TMSIInizia = new ToolStripMenuItem();
            TMSIReset = new ToolStripMenuItem();
            TSMIDelay = new ToolStripMenuItem();
            TSMIDelayAlto = new ToolStripMenuItem();
            TSMIDelayMedio = new ToolStripMenuItem();
            TMSIDelayBasso = new ToolStripMenuItem();
            TMSINoDelay = new ToolStripMenuItem();
            TSMIMusica = new ToolStripMenuItem();
            traccia1ToolStripMenuItem = new ToolStripMenuItem();
            traccia2ToolStripMenuItem = new ToolStripMenuItem();
            traccia3ToolStripMenuItem = new ToolStripMenuItem();
            nessunaToolStripMenuItem = new ToolStripMenuItem();
            TSMIAiuto = new ToolStripMenuItem();
            TSMIGitHub = new ToolStripMenuItem();
            TSMIRiconoscimenti = new ToolStripMenuItem();
            TLPCampo = new TableLayoutPanel();
            TLPFormattazione = new TableLayoutPanel();
            TLPPulsanti = new TableLayoutPanel();
            buttonReset = new Button();
            buttonInizia = new Button();
            buttonLogForm = new Button();
            pictureBoxLogo = new PictureBox();
            panelLabel = new Panel();
            menuStrip1.SuspendLayout();
            TLPFormattazione.SuspendLayout();
            TLPPulsanti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { TSMISimluazione, TSMIDelay, TSMIMusica, TSMIAiuto });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(634, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // TSMISimluazione
            // 
            TSMISimluazione.DropDownItems.AddRange(new ToolStripItem[] { TMSIInizia, TMSIReset });
            TSMISimluazione.Name = "TSMISimluazione";
            TSMISimluazione.Size = new Size(83, 20);
            TSMISimluazione.Text = "Simulazione";
            // 
            // TMSIInizia
            // 
            TMSIInizia.Name = "TMSIInizia";
            TMSIInizia.Size = new Size(180, 22);
            TMSIInizia.Text = "Inizia";
            TMSIInizia.Click += TMSIInizia_Click;
            // 
            // TMSIReset
            // 
            TMSIReset.Name = "TMSIReset";
            TMSIReset.Size = new Size(180, 22);
            TMSIReset.Text = "Reset";
            TMSIReset.Click += TMSIReset_Click;
            // 
            // TSMIDelay
            // 
            TSMIDelay.DropDownItems.AddRange(new ToolStripItem[] { TSMIDelayAlto, TSMIDelayMedio, TMSIDelayBasso, TMSINoDelay });
            TSMIDelay.Name = "TSMIDelay";
            TSMIDelay.Size = new Size(48, 20);
            TSMIDelay.Text = "Delay";
            // 
            // TSMIDelayAlto
            // 
            TSMIDelayAlto.Name = "TSMIDelayAlto";
            TSMIDelayAlto.Size = new Size(174, 22);
            TSMIDelayAlto.Text = "Alto (2 secondi)";
            TSMIDelayAlto.Click += TSMIDelayAlto_Click;
            // 
            // TSMIDelayMedio
            // 
            TSMIDelayMedio.Name = "TSMIDelayMedio";
            TSMIDelayMedio.Size = new Size(174, 22);
            TSMIDelayMedio.Text = "Medio (1 secondo)";
            TSMIDelayMedio.Click += TSMIDelayMedio_Click;
            // 
            // TMSIDelayBasso
            // 
            TMSIDelayBasso.Name = "TMSIDelayBasso";
            TMSIDelayBasso.Size = new Size(174, 22);
            TMSIDelayBasso.Text = "Basso (0,5 secondi)";
            TMSIDelayBasso.Click += TMSIDelayBasso_Click;
            // 
            // TMSINoDelay
            // 
            TMSINoDelay.Name = "TMSINoDelay";
            TMSINoDelay.Size = new Size(174, 22);
            TMSINoDelay.Text = "Nessun delay";
            TMSINoDelay.Click += TMSINoDelay_Click;
            // 
            // TSMIMusica
            // 
            TSMIMusica.DropDownItems.AddRange(new ToolStripItem[] { traccia1ToolStripMenuItem, traccia2ToolStripMenuItem, traccia3ToolStripMenuItem, nessunaToolStripMenuItem });
            TSMIMusica.Name = "TSMIMusica";
            TSMIMusica.Size = new Size(57, 20);
            TSMIMusica.Text = "Musica";
            // 
            // traccia1ToolStripMenuItem
            // 
            traccia1ToolStripMenuItem.Name = "traccia1ToolStripMenuItem";
            traccia1ToolStripMenuItem.Size = new Size(157, 22);
            traccia1ToolStripMenuItem.Text = "Traccia #1 ";
            traccia1ToolStripMenuItem.Click += traccia1ToolStripMenuItem_Click;
            // 
            // traccia2ToolStripMenuItem
            // 
            traccia2ToolStripMenuItem.Name = "traccia2ToolStripMenuItem";
            traccia2ToolStripMenuItem.Size = new Size(157, 22);
            traccia2ToolStripMenuItem.Text = "Traccia #2";
            traccia2ToolStripMenuItem.Click += traccia2ToolStripMenuItem_Click;
            // 
            // traccia3ToolStripMenuItem
            // 
            traccia3ToolStripMenuItem.Name = "traccia3ToolStripMenuItem";
            traccia3ToolStripMenuItem.Size = new Size(157, 22);
            traccia3ToolStripMenuItem.Text = "Traccia #3";
            traccia3ToolStripMenuItem.Click += traccia3ToolStripMenuItem_Click;
            // 
            // nessunaToolStripMenuItem
            // 
            nessunaToolStripMenuItem.Name = "nessunaToolStripMenuItem";
            nessunaToolStripMenuItem.Size = new Size(157, 22);
            nessunaToolStripMenuItem.Text = "Nessuna traccia";
            nessunaToolStripMenuItem.Click += nessunaToolStripMenuItem_Click;
            // 
            // TSMIAiuto
            // 
            TSMIAiuto.DropDownItems.AddRange(new ToolStripItem[] { TSMIGitHub, TSMIRiconoscimenti });
            TSMIAiuto.Name = "TSMIAiuto";
            TSMIAiuto.Size = new Size(48, 20);
            TSMIAiuto.Text = "Aiuto";
            // 
            // TSMIGitHub
            // 
            TSMIGitHub.Name = "TSMIGitHub";
            TSMIGitHub.Size = new Size(156, 22);
            TSMIGitHub.Text = "Pagina GitHub";
            TSMIGitHub.Click += TSMIGitHub_Click;
            // 
            // TSMIRiconoscimenti
            // 
            TSMIRiconoscimenti.Name = "TSMIRiconoscimenti";
            TSMIRiconoscimenti.Size = new Size(156, 22);
            TSMIRiconoscimenti.Text = "Riconoscimenti";
            TSMIRiconoscimenti.Click += TSMIRiconoscimenti_Click;
            // 
            // TLPCampo
            // 
            TLPCampo.ColumnCount = 5;
            TLPCampo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TLPCampo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TLPCampo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TLPCampo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TLPCampo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TLPCampo.Dock = DockStyle.Fill;
            TLPCampo.Location = new Point(3, 126);
            TLPCampo.Name = "TLPCampo";
            TLPCampo.RowCount = 5;
            TLPCampo.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TLPCampo.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TLPCampo.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TLPCampo.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TLPCampo.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TLPCampo.Size = new Size(532, 487);
            TLPCampo.TabIndex = 1;
            // 
            // TLPFormattazione
            // 
            TLPFormattazione.ColumnCount = 2;
            TLPFormattazione.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            TLPFormattazione.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            TLPFormattazione.Controls.Add(TLPCampo, 0, 1);
            TLPFormattazione.Controls.Add(TLPPulsanti, 1, 1);
            TLPFormattazione.Controls.Add(pictureBoxLogo, 0, 0);
            TLPFormattazione.Controls.Add(panelLabel, 0, 2);
            TLPFormattazione.Dock = DockStyle.Fill;
            TLPFormattazione.Location = new Point(0, 24);
            TLPFormattazione.Name = "TLPFormattazione";
            TLPFormattazione.RowCount = 3;
            TLPFormattazione.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TLPFormattazione.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            TLPFormattazione.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TLPFormattazione.Size = new Size(634, 637);
            TLPFormattazione.TabIndex = 2;
            // 
            // TLPPulsanti
            // 
            TLPPulsanti.ColumnCount = 1;
            TLPPulsanti.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TLPPulsanti.Controls.Add(buttonReset, 0, 1);
            TLPPulsanti.Controls.Add(buttonInizia, 0, 0);
            TLPPulsanti.Controls.Add(buttonLogForm, 0, 2);
            TLPPulsanti.Dock = DockStyle.Fill;
            TLPPulsanti.Location = new Point(541, 126);
            TLPPulsanti.Name = "TLPPulsanti";
            TLPPulsanti.RowCount = 3;
            TLPPulsanti.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TLPPulsanti.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TLPPulsanti.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TLPPulsanti.Size = new Size(90, 487);
            TLPPulsanti.TabIndex = 2;
            // 
            // buttonReset
            // 
            buttonReset.Dock = DockStyle.Fill;
            buttonReset.Location = new Point(3, 165);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(84, 156);
            buttonReset.TabIndex = 1;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonInizia
            // 
            buttonInizia.Dock = DockStyle.Fill;
            buttonInizia.Location = new Point(3, 3);
            buttonInizia.Name = "buttonInizia";
            buttonInizia.Size = new Size(84, 156);
            buttonInizia.TabIndex = 0;
            buttonInizia.Text = "Inizia";
            buttonInizia.UseVisualStyleBackColor = true;
            buttonInizia.Click += buttonInizia_Click;
            // 
            // buttonLogForm
            // 
            buttonLogForm.Dock = DockStyle.Fill;
            buttonLogForm.Location = new Point(3, 327);
            buttonLogForm.Name = "buttonLogForm";
            buttonLogForm.Size = new Size(84, 157);
            buttonLogForm.TabIndex = 2;
            buttonLogForm.Text = "Log";
            buttonLogForm.UseVisualStyleBackColor = true;
            buttonLogForm.Click += buttonLogForm_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Stretch;
            TLPFormattazione.SetColumnSpan(pictureBoxLogo, 2);
            pictureBoxLogo.Dock = DockStyle.Fill;
            pictureBoxLogo.Location = new Point(3, 3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(628, 117);
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click;
            // 
            // panelLabel
            // 
            TLPFormattazione.SetColumnSpan(panelLabel, 2);
            panelLabel.Dock = DockStyle.Fill;
            panelLabel.Location = new Point(3, 619);
            panelLabel.Name = "panelLabel";
            panelLabel.Size = new Size(628, 15);
            panelLabel.TabIndex = 5;
            // 
            // Campo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 661);
            Controls.Add(TLPFormattazione);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(10000, 10000);
            MinimumSize = new Size(650, 700);
            Name = "Campo";
            Text = "Gioco della vita";
            Load += Campo_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            TLPFormattazione.ResumeLayout(false);
            TLPPulsanti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem TSMISimluazione;
        private ToolStripMenuItem TMSIInizia;
        private ToolStripMenuItem TMSIReset;
        private ToolStripMenuItem TSMIDelay;
        private ToolStripMenuItem TSMIDelayAlto;
        private ToolStripMenuItem TSMIDelayMedio;
        private ToolStripMenuItem TMSIDelayBasso;
        private ToolStripMenuItem TMSINoDelay;
        private ToolStripMenuItem TSMIAiuto;
        private ToolStripMenuItem TSMIGitHub;
        private ToolStripMenuItem TSMIRiconoscimenti;
        //private PictureBox pictureBox1;
        private TableLayoutPanel TLPCampo;
        private ToolStripMenuItem TSMIMusica;
        private TableLayoutPanel TLPFormattazione;
        private TableLayoutPanel TLPPulsanti;
        private Button buttonInizia;
        private Button buttonReset;
        private ToolStripMenuItem traccia1ToolStripMenuItem;
        private ToolStripMenuItem traccia2ToolStripMenuItem;
        private ToolStripMenuItem traccia3ToolStripMenuItem;
        private ToolStripMenuItem nessunaToolStripMenuItem;
        private PictureBox pictureBoxLogo;
        private Panel panelLabel;
        private Button buttonLogForm;
    }
}