namespace Hausverwaltung
{
    partial class Hauptfenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxHaeuser = new System.Windows.Forms.ListBox();
            this.labelHaeuser = new System.Windows.Forms.Label();
            this.buttonNeu = new System.Windows.Forms.Button();
            this.listBoxWohnungen = new System.Windows.Forms.ListBox();
            this.labelWohnungen = new System.Windows.Forms.Label();
            this.buttonNeuWohnung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxHaeuser
            // 
            this.listBoxHaeuser.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.listBoxHaeuser.FormattingEnabled = true;
            this.listBoxHaeuser.ItemHeight = 16;
            this.listBoxHaeuser.Location = new System.Drawing.Point(12, 88);
            this.listBoxHaeuser.Name = "listBoxHaeuser";
            this.listBoxHaeuser.Size = new System.Drawing.Size(268, 324);
            this.listBoxHaeuser.TabIndex = 0;
            this.listBoxHaeuser.SelectedIndexChanged += new System.EventHandler(this.listBoxHaeuser_SelectedIndexChanged);
            this.listBoxHaeuser.DoubleClick += new System.EventHandler(this.listBoxHaeuser_DoubleClick);
            // 
            // labelHaeuser
            // 
            this.labelHaeuser.AutoSize = true;
            this.labelHaeuser.Location = new System.Drawing.Point(12, 62);
            this.labelHaeuser.Name = "labelHaeuser";
            this.labelHaeuser.Size = new System.Drawing.Size(39, 16);
            this.labelHaeuser.TabIndex = 1;
            this.labelHaeuser.Text = "Haus";
            // 
            // buttonNeu
            // 
            this.buttonNeu.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonNeu.Location = new System.Drawing.Point(139, 55);
            this.buttonNeu.Name = "buttonNeu";
            this.buttonNeu.Size = new System.Drawing.Size(141, 23);
            this.buttonNeu.TabIndex = 2;
            this.buttonNeu.Text = "Neues Haus";
            this.buttonNeu.UseVisualStyleBackColor = false;
            this.buttonNeu.Click += new System.EventHandler(this.buttonNeu_Click);
            // 
            // listBoxWohnungen
            // 
            this.listBoxWohnungen.FormattingEnabled = true;
            this.listBoxWohnungen.ItemHeight = 16;
            this.listBoxWohnungen.Location = new System.Drawing.Point(374, 88);
            this.listBoxWohnungen.Name = "listBoxWohnungen";
            this.listBoxWohnungen.Size = new System.Drawing.Size(240, 324);
            this.listBoxWohnungen.TabIndex = 3;
            this.listBoxWohnungen.DoubleClick += new System.EventHandler(this.listBoxWohnungen_DoubleClick);
            // 
            // labelWohnungen
            // 
            this.labelWohnungen.AutoSize = true;
            this.labelWohnungen.Location = new System.Drawing.Point(371, 62);
            this.labelWohnungen.Name = "labelWohnungen";
            this.labelWohnungen.Size = new System.Drawing.Size(79, 16);
            this.labelWohnungen.TabIndex = 4;
            this.labelWohnungen.Text = "Wohnungen";
            // 
            // buttonNeuWohnung
            // 
            this.buttonNeuWohnung.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonNeuWohnung.Location = new System.Drawing.Point(473, 59);
            this.buttonNeuWohnung.Name = "buttonNeuWohnung";
            this.buttonNeuWohnung.Size = new System.Drawing.Size(141, 23);
            this.buttonNeuWohnung.TabIndex = 5;
            this.buttonNeuWohnung.Text = "Neue Wohnung";
            this.buttonNeuWohnung.UseVisualStyleBackColor = false;
            this.buttonNeuWohnung.Click += new System.EventHandler(this.buttonNeuWohnung_Click);
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNeuWohnung);
            this.Controls.Add(this.labelWohnungen);
            this.Controls.Add(this.listBoxWohnungen);
            this.Controls.Add(this.buttonNeu);
            this.Controls.Add(this.labelHaeuser);
            this.Controls.Add(this.listBoxHaeuser);
            this.Name = "Hauptfenster";
            this.Text = "Hauptfenster";
            this.Load += new System.EventHandler(this.Hauptfenster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxHaeuser;
        private System.Windows.Forms.Label labelHaeuser;
        private System.Windows.Forms.Button buttonNeu;
        private System.Windows.Forms.ListBox listBoxWohnungen;
        private System.Windows.Forms.Label labelWohnungen;
        private System.Windows.Forms.Button buttonNeuWohnung;
    }
}

