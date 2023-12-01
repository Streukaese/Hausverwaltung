namespace Hausverwaltung
{
    partial class WohnungBearbeiten
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
            this.labelTuer = new System.Windows.Forms.Label();
            this.textBoxTuer = new System.Windows.Forms.TextBox();
            this.textBoxWohnflaeche = new System.Windows.Forms.TextBox();
            this.labelWohnflaeche = new System.Windows.Forms.Label();
            this.labelHaus = new System.Windows.Forms.Label();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTuer
            // 
            this.labelTuer.AutoSize = true;
            this.labelTuer.Location = new System.Drawing.Point(12, 101);
            this.labelTuer.Name = "labelTuer";
            this.labelTuer.Size = new System.Drawing.Size(93, 16);
            this.labelTuer.TabIndex = 0;
            this.labelTuer.Text = "Raum / Patere";
            // 
            // textBoxTuer
            // 
            this.textBoxTuer.Location = new System.Drawing.Point(111, 95);
            this.textBoxTuer.Name = "textBoxTuer";
            this.textBoxTuer.Size = new System.Drawing.Size(177, 22);
            this.textBoxTuer.TabIndex = 1;
            // 
            // textBoxWohnflaeche
            // 
            this.textBoxWohnflaeche.Location = new System.Drawing.Point(111, 134);
            this.textBoxWohnflaeche.Name = "textBoxWohnflaeche";
            this.textBoxWohnflaeche.Size = new System.Drawing.Size(177, 22);
            this.textBoxWohnflaeche.TabIndex = 2;
            // 
            // labelWohnflaeche
            // 
            this.labelWohnflaeche.AutoSize = true;
            this.labelWohnflaeche.Location = new System.Drawing.Point(12, 140);
            this.labelWohnflaeche.Name = "labelWohnflaeche";
            this.labelWohnflaeche.Size = new System.Drawing.Size(78, 16);
            this.labelWohnflaeche.TabIndex = 3;
            this.labelWohnflaeche.Text = "Wohnfläche";
            // 
            // labelHaus
            // 
            this.labelHaus.AutoSize = true;
            this.labelHaus.Location = new System.Drawing.Point(108, 59);
            this.labelHaus.Name = "labelHaus";
            this.labelHaus.Size = new System.Drawing.Size(44, 16);
            this.labelHaus.TabIndex = 4;
            this.labelHaus.Text = "label3";
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(111, 175);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(177, 59);
            this.buttonSpeichern.TabIndex = 5;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(111, 240);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(177, 59);
            this.buttonAbbrechen.TabIndex = 6;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // WohnungBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.labelHaus);
            this.Controls.Add(this.labelWohnflaeche);
            this.Controls.Add(this.textBoxWohnflaeche);
            this.Controls.Add(this.textBoxTuer);
            this.Controls.Add(this.labelTuer);
            this.Name = "WohnungBearbeiten";
            this.Text = "Wohnung Bearbeiten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTuer;
        private System.Windows.Forms.TextBox textBoxTuer;
        private System.Windows.Forms.TextBox textBoxWohnflaeche;
        private System.Windows.Forms.Label labelWohnflaeche;
        private System.Windows.Forms.Label labelHaus;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.Button buttonAbbrechen;
    }
}