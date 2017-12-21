namespace WindowsFormsApplicationDb1
{
    partial class FormInsert
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxBez = new System.Windows.Forms.TextBox();
            this.textBoxNr = new System.Windows.Forms.TextBox();
            this.textBoxBestand = new System.Windows.Forms.TextBox();
            this.textBoxMeldeBest = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPreis = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.comboBoxVerpackung = new System.Windows.Forms.ComboBox();
            this.comboBoxGrp = new System.Windows.Forms.ComboBox();
            this.dateTimePickerLetzteEnt = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(483, 224);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 40;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(370, 224);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 39;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxBez
            // 
            this.textBoxBez.Location = new System.Drawing.Point(104, 68);
            this.textBoxBez.Name = "textBoxBez";
            this.textBoxBez.Size = new System.Drawing.Size(155, 20);
            this.textBoxBez.TabIndex = 37;
            // 
            // textBoxNr
            // 
            this.textBoxNr.Location = new System.Drawing.Point(104, 117);
            this.textBoxNr.Name = "textBoxNr";
            this.textBoxNr.Size = new System.Drawing.Size(155, 20);
            this.textBoxNr.TabIndex = 36;
            // 
            // textBoxBestand
            // 
            this.textBoxBestand.Location = new System.Drawing.Point(104, 206);
            this.textBoxBestand.Name = "textBoxBestand";
            this.textBoxBestand.Size = new System.Drawing.Size(155, 20);
            this.textBoxBestand.TabIndex = 34;
            // 
            // textBoxMeldeBest
            // 
            this.textBoxMeldeBest.Location = new System.Drawing.Point(369, 20);
            this.textBoxMeldeBest.Name = "textBoxMeldeBest";
            this.textBoxMeldeBest.Size = new System.Drawing.Size(155, 20);
            this.textBoxMeldeBest.TabIndex = 33;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(104, 20);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(155, 20);
            this.textBoxID.TabIndex = 32;
            // 
            // textBoxPreis
            // 
            this.textBoxPreis.Location = new System.Drawing.Point(369, 117);
            this.textBoxPreis.Name = "textBoxPreis";
            this.textBoxPreis.Size = new System.Drawing.Size(155, 20);
            this.textBoxPreis.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "letzte Entname";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Verpackung";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Preis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "MeldeBest";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Bestand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Gruppe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Bezeichnung";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(29, 23);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(50, 13);
            this.labelID.TabIndex = 21;
            this.labelID.Text = "Artikel ID";
            // 
            // comboBoxVerpackung
            // 
            this.comboBoxVerpackung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVerpackung.FormattingEnabled = true;
            this.comboBoxVerpackung.Location = new System.Drawing.Point(369, 67);
            this.comboBoxVerpackung.Name = "comboBoxVerpackung";
            this.comboBoxVerpackung.Size = new System.Drawing.Size(155, 21);
            this.comboBoxVerpackung.TabIndex = 41;
            // 
            // comboBoxGrp
            // 
            this.comboBoxGrp.FormattingEnabled = true;
            this.comboBoxGrp.Location = new System.Drawing.Point(104, 161);
            this.comboBoxGrp.Name = "comboBoxGrp";
            this.comboBoxGrp.Size = new System.Drawing.Size(155, 21);
            this.comboBoxGrp.TabIndex = 42;
            // 
            // dateTimePickerLetzteEnt
            // 
            this.dateTimePickerLetzteEnt.Location = new System.Drawing.Point(370, 162);
            this.dateTimePickerLetzteEnt.Name = "dateTimePickerLetzteEnt";
            this.dateTimePickerLetzteEnt.Size = new System.Drawing.Size(154, 20);
            this.dateTimePickerLetzteEnt.TabIndex = 43;
            // 
            // FormInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 292);
            this.Controls.Add(this.dateTimePickerLetzteEnt);
            this.Controls.Add(this.comboBoxGrp);
            this.Controls.Add(this.comboBoxVerpackung);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxBez);
            this.Controls.Add(this.textBoxNr);
            this.Controls.Add(this.textBoxBestand);
            this.Controls.Add(this.textBoxMeldeBest);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxPreis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelID);
            this.Name = "FormInsert";
            this.Text = "Insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxBez;
        private System.Windows.Forms.TextBox textBoxNr;
        private System.Windows.Forms.TextBox textBoxBestand;
        private System.Windows.Forms.TextBox textBoxMeldeBest;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPreis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ComboBox comboBoxVerpackung;
        private System.Windows.Forms.ComboBox comboBoxGrp;
        private System.Windows.Forms.DateTimePicker dateTimePickerLetzteEnt;
    }
}