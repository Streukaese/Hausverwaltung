namespace Hausverwaltung
{
    partial class HausBearbeitungsDialog
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
            this.labelAdresse = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxPlz = new System.Windows.Forms.TextBox();
            this.labelPlz = new System.Windows.Forms.Label();
            this.labelOrt = new System.Windows.Forms.Label();
            this.textBoxOrt = new System.Windows.Forms.TextBox();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(28, 40);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(110, 20);
            this.labelAdresse.TabIndex = 0;
            this.labelAdresse.Text = "Str. + HausNr.";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(31, 59);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(201, 22);
            this.textBoxAdresse.TabIndex = 1;
            // 
            // textBoxPlz
            // 
            this.textBoxPlz.Location = new System.Drawing.Point(31, 105);
            this.textBoxPlz.Name = "textBoxPlz";
            this.textBoxPlz.Size = new System.Drawing.Size(201, 22);
            this.textBoxPlz.TabIndex = 2;
            // 
            // labelPlz
            // 
            this.labelPlz.AutoSize = true;
            this.labelPlz.Location = new System.Drawing.Point(28, 86);
            this.labelPlz.Name = "labelPlz";
            this.labelPlz.Size = new System.Drawing.Size(31, 16);
            this.labelPlz.TabIndex = 3;
            this.labelPlz.Text = "PLZ";
            // 
            // labelOrt
            // 
            this.labelOrt.AutoSize = true;
            this.labelOrt.Location = new System.Drawing.Point(28, 134);
            this.labelOrt.Name = "labelOrt";
            this.labelOrt.Size = new System.Drawing.Size(24, 16);
            this.labelOrt.TabIndex = 4;
            this.labelOrt.Text = "Ort";
            // 
            // textBoxOrt
            // 
            this.textBoxOrt.Location = new System.Drawing.Point(31, 153);
            this.textBoxOrt.Name = "textBoxOrt";
            this.textBoxOrt.Size = new System.Drawing.Size(201, 22);
            this.textBoxOrt.TabIndex = 5;
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(31, 198);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(201, 36);
            this.buttonSpeichern.TabIndex = 6;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(31, 259);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(201, 31);
            this.buttonAbbrechen.TabIndex = 7;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // HausBearbeitungsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 401);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.textBoxOrt);
            this.Controls.Add(this.labelOrt);
            this.Controls.Add(this.labelPlz);
            this.Controls.Add(this.textBoxPlz);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.labelAdresse);
            this.Name = "HausBearbeitungsDialog";
            this.Text = "HausBearbeitungsDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxPlz;
        private System.Windows.Forms.Label labelPlz;
        private System.Windows.Forms.Label labelOrt;
        private System.Windows.Forms.TextBox textBoxOrt;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.Button buttonAbbrechen;
    }
}