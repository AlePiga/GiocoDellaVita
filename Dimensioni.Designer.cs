namespace GiocoDellaVita
{
    partial class Impostazioni
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impostazioni));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            numericUpDownColonne = new NumericUpDown();
            buttonInizia = new Button();
            comboBoxTema = new ComboBox();
            label3 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownColonne).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.54438F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.45562F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(numericUpDownColonne, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonInizia, 2, 0);
            tableLayoutPanel1.Controls.Add(comboBoxTema, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 153);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.2352943F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.7647057F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(278, 55);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 26);
            label1.TabIndex = 6;
            label1.Text = "Altezza";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericUpDownColonne
            // 
            numericUpDownColonne.Anchor = AnchorStyles.Left;
            numericUpDownColonne.Location = new Point(58, 3);
            numericUpDownColonne.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numericUpDownColonne.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownColonne.Name = "numericUpDownColonne";
            numericUpDownColonne.Size = new Size(52, 23);
            numericUpDownColonne.TabIndex = 4;
            numericUpDownColonne.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // buttonInizia
            // 
            buttonInizia.Dock = DockStyle.Fill;
            buttonInizia.Font = new Font("Segoe UI", 12F);
            buttonInizia.Location = new Point(172, 3);
            buttonInizia.Name = "buttonInizia";
            tableLayoutPanel1.SetRowSpan(buttonInizia, 2);
            buttonInizia.Size = new Size(103, 49);
            buttonInizia.TabIndex = 9;
            buttonInizia.Text = "Inizia!";
            buttonInizia.UseVisualStyleBackColor = true;
            buttonInizia.Click += buttonInizia_Click_1;
            // 
            // comboBoxTema
            // 
            comboBoxTema.Anchor = AnchorStyles.Left;
            comboBoxTema.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTema.FormattingEnabled = true;
            comboBoxTema.Items.AddRange(new object[] { "Foresta", "Savana", "Oceano", "Deserto", "Irlanda", "Cina" });
            comboBoxTema.Location = new Point(58, 29);
            comboBoxTema.Name = "comboBoxTema";
            comboBoxTema.Size = new Size(104, 23);
            comboBoxTema.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(3, 26);
            label3.Name = "label3";
            label3.Size = new Size(49, 29);
            label3.TabIndex = 8;
            label3.Text = "Tema";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(284, 211);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Benvenuto;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 144);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Impostazioni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 211);
            Controls.Add(tableLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(300, 250);
            MinimumSize = new Size(300, 250);
            Name = "Impostazioni";
            Text = "Impostazioni";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownColonne).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox comboBoxTema;
        private Label label1;
        private Label label3;
        private NumericUpDown numericUpDownColonne;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private Button buttonInizia;
    }
}
