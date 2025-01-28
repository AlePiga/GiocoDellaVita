namespace GiocoDellaVita
{
    partial class Log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            richTextBoxLog = new RichTextBox();
            menuStrip1 = new MenuStrip();
            logToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            chiudiToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            piccoloToolStripMenuItem = new ToolStripMenuItem();
            medioToolStripMenuItem = new ToolStripMenuItem();
            grandeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBoxLog
            // 
            richTextBoxLog.Location = new Point(12, 27);
            richTextBoxLog.Name = "richTextBoxLog";
            richTextBoxLog.ReadOnly = true;
            richTextBoxLog.Size = new Size(460, 622);
            richTextBoxLog.TabIndex = 0;
            richTextBoxLog.Text = "";
            richTextBoxLog.TextChanged += richTextBoxLog_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { logToolStripMenuItem, fontToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(484, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // logToolStripMenuItem
            // 
            logToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { resetToolStripMenuItem, chiudiToolStripMenuItem });
            logToolStripMenuItem.Name = "logToolStripMenuItem";
            logToolStripMenuItem.Size = new Size(57, 20);
            logToolStripMenuItem.Text = "Scheda";
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(180, 22);
            resetToolStripMenuItem.Text = "Reset";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // chiudiToolStripMenuItem
            // 
            chiudiToolStripMenuItem.Name = "chiudiToolStripMenuItem";
            chiudiToolStripMenuItem.Size = new Size(180, 22);
            chiudiToolStripMenuItem.Text = "Chiudi";
            chiudiToolStripMenuItem.Click += chiudiToolStripMenuItem_Click;
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { piccoloToolStripMenuItem, medioToolStripMenuItem, grandeToolStripMenuItem });
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(43, 20);
            fontToolStripMenuItem.Text = "Font";
            // 
            // piccoloToolStripMenuItem
            // 
            piccoloToolStripMenuItem.Name = "piccoloToolStripMenuItem";
            piccoloToolStripMenuItem.Size = new Size(180, 22);
            piccoloToolStripMenuItem.Text = "Piccolo";
            piccoloToolStripMenuItem.Click += piccoloToolStripMenuItem_Click;
            // 
            // medioToolStripMenuItem
            // 
            medioToolStripMenuItem.Name = "medioToolStripMenuItem";
            medioToolStripMenuItem.Size = new Size(180, 22);
            medioToolStripMenuItem.Text = "Medio";
            medioToolStripMenuItem.Click += medioToolStripMenuItem_Click;
            // 
            // grandeToolStripMenuItem
            // 
            grandeToolStripMenuItem.Name = "grandeToolStripMenuItem";
            grandeToolStripMenuItem.Size = new Size(180, 22);
            grandeToolStripMenuItem.Text = "Grande";
            grandeToolStripMenuItem.Click += grandeToolStripMenuItem_Click;
            // 
            // Log
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 661);
            Controls.Add(richTextBoxLog);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(500, 700);
            MinimumSize = new Size(500, 700);
            Name = "Log";
            Text = "Log";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public RichTextBox richTextBoxLog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem logToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem chiudiToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem piccoloToolStripMenuItem;
        private ToolStripMenuItem medioToolStripMenuItem;
        private ToolStripMenuItem grandeToolStripMenuItem;
    }
}