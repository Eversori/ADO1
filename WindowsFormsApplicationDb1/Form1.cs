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
    public partial class Form1 : Form
    {
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;
        List<Artikel> artikelList = null;


        public Form1()
        {
            InitializeComponent();
            artikelList = new List<Artikel>();
        }

        private void buttonConect_Click(object sender, EventArgs e)
        {
            //"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Bestellung.accdb"
            con = new OleDbConnection();
            //OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();
            //builder.Provider = "Microsoft.ACE.OLEDB.12.0";
            //builder.DataSource = "Bestellung.accdb";
            con.ConnectionString = Properties.Settings.Default.DbCon;

            try
            {
                con.Open();
                toolStripStatusLabelSatus.Text = "Verbindung aufgebaut";
            }
            catch (Exception)
            {
                MessageBox.Show("Verbindung nicht möglich");             
            }

            buttonCommand.Enabled = true;
            buttonConect.Enabled = false;
        }

        private void buttonCommand_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from tArtikel;";
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception)
            {

                MessageBox.Show("Zugriff auf tArtikel nicht möglich");
            }

            buttonReader.Enabled = true;
            buttonCommand.Enabled = false;
        }

        private void buttonReader_Click(object sender, EventArgs e)
        {
            while(reader.Read())
            {
                //String bez = reader.GetString(3);
                Artikel a = mkArtikelObject(reader);
                //listBoxDaten.Items.Add(a);

                artikelList.Add(a);
            }
            listBoxDaten.DataSource = artikelList;
            reader.Close();

            buttonReader.Enabled = false;
        }

        private Artikel mkArtikelObject(OleDbDataReader reader)
        {
            Artikel a = new Artikel();
            int i = 0;

            a.ArtikelOid = reader.GetInt32(i);
            i++;

            a.ArtikelNr = Convert.ToString(checkDBNull(reader[i++]));
           
            a.ArtikelGruppe = Convert.ToInt32(checkDBNull(reader[i++]));

            a.Bezeichnung = Convert.ToString(checkDBNull(reader[i++]));

            a.Bestand = Convert.ToUInt16(checkDBNull(reader[i++]));

            a.Meldebestand = Convert.ToInt16(checkDBNull(reader[i++]));

            a.Verpackung = Convert.ToInt32(checkDBNull(reader[i++]));

            a.VkPreis = Convert.ToDecimal(checkDBNull(reader[i]));

            return a;
        }

        private Object checkDBNull(Object o)
        {
            if (o == DBNull.Value) return 0;
            else return o;

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxDaten.SelectedItem != null)
            {
                Artikel a = (Artikel) listBoxDaten.SelectedItem;
                FormUpdate frmUpdate = new FormUpdate(a);
                frmUpdate.ShowDialog(); // Modales Fenster
                if(frmUpdate.Result == DialogResult.OK)
                {
                    updateArtikel(a);
                }
                else
                {
                    toolStripStatusLabelSatus.Text = "Änderung wurde Abgebrochen";
                }
            }
        }

        private void updateArtikel(Artikel a)
        {
            // Command-Opjekt
            OleDbCommand cmd = con.CreateCommand();
            // Parameter garantieren
            cmd.Parameters.AddWithValue("ANR", a.ArtikelNr);
            cmd.Parameters.AddWithValue("BEZ", a.Bezeichnung);
            cmd.Parameters.AddWithValue("BEST", a.Bestand);
            cmd.Parameters.AddWithValue("MBEST",a.Meldebestand);
            cmd.Parameters.AddWithValue("PREIS", a.VkPreis);
            cmd.Parameters.AddWithValue("LENT", a.LetzteEntnahme);
            // Commandtext: SQL
            String sql = "Update tArtikel set ArtikelNR = ANR, Bezeichnung = BEZ, Bestand = BEST, Meldebestand = MBEST, VkPreis = PREIS, letzteEntnahme = LENT";
            sql += " Where ArtikelOID = " + a.ArtikelOid.ToString();
            cmd.CommandText = sql;
            // Command ausführen
            try
            {
                cmd.ExecuteNonQuery();
                toolStripStatusLabelSatus.Text = "Update erfolgreich";
            }
            catch (Exception)
            {

                MessageBox.Show("Fehler beim Update");
            }
        }
    }
}
