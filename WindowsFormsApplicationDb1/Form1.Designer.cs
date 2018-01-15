namespace WindowsFormsApplicationDb1
{
    partial class Form1
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
            this.buttonConect = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelSatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonCommand = new System.Windows.Forms.Button();
            this.buttonReader = new System.Windows.Forms.Button();
            this.listBoxDaten = new System.Windows.Forms.ListBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.labelBezirk = new System.Windows.Forms.Label();
            this.textBoxBezirk = new System.Windows.Forms.TextBox();
            this.buttonNeuBezirk = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConect
            // 
            this.buttonConect.Location = new System.Drawing.Point(210, 58);
            this.buttonConect.Name = "buttonConect";
            this.buttonConect.Size = new System.Drawing.Size(260, 36);
            this.buttonConect.TabIndex = 0;
            this.buttonConect.Text = "Connection";
            this.buttonConect.UseVisualStyleBackColor = true;
            this.buttonConect.Click += new System.EventHandler(this.buttonConect_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 436);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(964, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelSatus
            // 
            this.toolStripStatusLabelSatus.Name = "toolStripStatusLabelSatus";
            this.toolStripStatusLabelSatus.Size = new System.Drawing.Size(0, 17);
            // 
            // buttonCommand
            // 
            this.buttonCommand.Enabled = false;
            this.buttonCommand.Location = new System.Drawing.Point(210, 113);
            this.buttonCommand.Name = "buttonCommand";
            this.buttonCommand.Size = new System.Drawing.Size(260, 32);
            this.buttonCommand.TabIndex = 2;
            this.buttonCommand.Text = "Command";
            this.buttonCommand.UseVisualStyleBackColor = true;
            this.buttonCommand.Click += new System.EventHandler(this.buttonCommand_Click);
            // 
            // buttonReader
            // 
            this.buttonReader.Enabled = false;
            this.buttonReader.Location = new System.Drawing.Point(210, 165);
            this.buttonReader.Name = "buttonReader";
            this.buttonReader.Size = new System.Drawing.Size(260, 37);
            this.buttonReader.TabIndex = 3;
            this.buttonReader.Text = "Auslesen";
            this.buttonReader.UseVisualStyleBackColor = true;
            this.buttonReader.Click += new System.EventHandler(this.buttonReader_Click);
            // 
            // listBoxDaten
            // 
            this.listBoxDaten.FormattingEnabled = true;
            this.listBoxDaten.Location = new System.Drawing.Point(552, 83);
            this.listBoxDaten.Name = "listBoxDaten";
            this.listBoxDaten.Size = new System.Drawing.Size(375, 251);
            this.listBoxDaten.TabIndex = 4;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(210, 223);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(260, 34);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Datensatz ändern";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(210, 278);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(260, 34);
            this.buttonInsert.TabIndex = 6;
            this.buttonInsert.Text = "Datensatz hinzufügen";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // labelBezirk
            // 
            this.labelBezirk.AutoSize = true;
            this.labelBezirk.Location = new System.Drawing.Point(222, 361);
            this.labelBezirk.Name = "labelBezirk";
            this.labelBezirk.Size = new System.Drawing.Size(36, 13);
            this.labelBezirk.TabIndex = 7;
            this.labelBezirk.Text = "Bezirk";
            // 
            // textBoxBezirk
            // 
            this.textBoxBezirk.Location = new System.Drawing.Point(264, 358);
            this.textBoxBezirk.Name = "textBoxBezirk";
            this.textBoxBezirk.Size = new System.Drawing.Size(181, 20);
            this.textBoxBezirk.TabIndex = 8;
            // 
            // buttonNeuBezirk
            // 
            this.buttonNeuBezirk.Location = new System.Drawing.Point(463, 356);
            this.buttonNeuBezirk.Name = "buttonNeuBezirk";
            this.buttonNeuBezirk.Size = new System.Drawing.Size(75, 23);
            this.buttonNeuBezirk.TabIndex = 9;
            this.buttonNeuBezirk.Text = "Neu";
            this.buttonNeuBezirk.UseVisualStyleBackColor = true;
            this.buttonNeuBezirk.Click += new System.EventHandler(this.buttonNeuBezirk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 458);
            this.Controls.Add(this.buttonNeuBezirk);
            this.Controls.Add(this.textBoxBezirk);
            this.Controls.Add(this.labelBezirk);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.listBoxDaten);
            this.Controls.Add(this.buttonReader);
            this.Controls.Add(this.buttonCommand);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonConect);
            this.Name = "Form1";
            this.Text = "OleDB";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSatus;
        private System.Windows.Forms.Button buttonCommand;
        private System.Windows.Forms.Button buttonReader;
        private System.Windows.Forms.ListBox listBoxDaten;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label labelBezirk;
        private System.Windows.Forms.TextBox textBoxBezirk;
        private System.Windows.Forms.Button buttonNeuBezirk;
    }
}

