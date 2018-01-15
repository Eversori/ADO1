using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplicationDb1
{
    public partial class FormInsert : Form
    {
        Artikel newArtikel = new Artikel();
        OleDbConnection connect = null;
        OleDbDataReader reader = null;
        OleDbCommand cmd = null;
        DialogResult Result = new DialogResult();

        public FormInsert()
        {
            InitializeComponent();
        }

        public FormInsert(OleDbConnection con, Artikel artikel) : this()
        {
            newArtikel = artikel;
            connect = con;
            initializeControles();
        }

        private void initializeControles()
        {
            InitializeDropboxGrp();
            InitializeDropboxVerpackung();
        }

        private void InitializeDropboxGrp()
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "Select * from tArtGruppe;";

            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                MessageBox.Show("Kann nicht auf tArtGruppe zugreifen");
            }

            while(reader.Read())
            {
                ArtGruppe artgrp = new ArtGruppe();
                artgrp.GrpId = Convert.ToInt32(checkDBNull(reader[0]));
                artgrp.Bezeichnung = Convert.ToString(checkDBNull(reader[1]));
                this.comboBoxGrp.Items.Add(artgrp);
            }
            reader.Close();
        }

        private void InitializeDropboxVerpackung()
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "Select * from tVerpackung;";

            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                MessageBox.Show("Kann nicht auf tVerpackung zugreifen");
            }

            while (reader.Read())
            {
                Verpackung vpck = new Verpackung();
                vpck.VerpackungsId = Convert.ToInt32(checkDBNull(reader[0]));
                vpck.Bezeichnung = Convert.ToString(checkDBNull(reader[1]));
                this.comboBoxVerpackung.Items.Add(vpck);
            }
            reader.Close();
        }



        private Object checkDBNull(Object o)
        {
            if (o == DBNull.Value) return 0;
            else return o;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
         
            this.Result = DialogResult.Cancel;
            this.Close();
        
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            ArtGruppe artgrp = (ArtGruppe) this.comboBoxGrp.SelectedItem;
            Verpackung vpck = (Verpackung) this.comboBoxVerpackung.SelectedItem;

            try
            {
                newArtikel.Bezeichnung = this.textBoxBez.Text;
                newArtikel.ArtikelNr = this.textBoxNr.Text;
                newArtikel.ArtikelGruppe = artgrp.GrpId;
                newArtikel.Bestand = Convert.ToUInt16(this.textBoxBestand.Text);
                newArtikel.Meldebestand = Convert.ToInt16(this.textBoxMeldeBest.Text);
                newArtikel.Verpackung = vpck.VerpackungsId;
                newArtikel.VkPreis = Convert.ToDecimal(this.textBoxPreis.Text);
                newArtikel.LetzteEntnahme = this.dateTimePickerLetzteEnt.Value;
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler");
                newArtikel = null;
            }

            this.Result = DialogResult.OK;
            this.Close();
        }
    }
}
