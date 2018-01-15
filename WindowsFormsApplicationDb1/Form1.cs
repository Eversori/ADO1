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
using System.Globalization;

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

            a.VkPreis = Convert.ToDecimal(checkDBNull(reader[i++]));

            //a.LetzteEntnahme = Convert.ToDateTime(checkDBNull(reader[i]));

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
                a.onUpdateError = MeldeBestand;
                FormUpdate frmUpdate = new FormUpdate(a);
                frmUpdate.ShowDialog(); // Modales Fenster
                if(frmUpdate.Result == DialogResult.OK)
                {
                    updateArtikel(a);
                    listBoxDaten.DataSource = null;
                    listBoxDaten.DataSource = artikelList;
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

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Artikel a = new Artikel();

            FormInsert frmInsert = new FormInsert(con,a);

            frmInsert.ShowDialog();
            if ( a != null)
            {
                insertNewArtikel(a);
                listBoxDaten.DataSource = null;
                listBoxDaten.DataSource = artikelList;
            }
            else
            {
                MessageBox.Show("Abgebrochen");
            }
        }

        private void insertNewArtikel(Artikel a)
        {
            OleDbCommand cmd = con.CreateCommand();

            cmd.Parameters.AddWithValue("ANR", a.ArtikelNr);
            cmd.Parameters.AddWithValue("GRP", a.ArtikelGruppe);
            cmd.Parameters.AddWithValue("BEZ", a.Bezeichnung);
            cmd.Parameters.AddWithValue("BEST", a.Bestand);
            cmd.Parameters.AddWithValue("MBEST", a.Meldebestand);
            cmd.Parameters.AddWithValue("VPCK", a.Verpackung);
            cmd.Parameters.AddWithValue("PREIS", a.VkPreis.ToString(new CultureInfo("de-DE")));
            cmd.Parameters.AddWithValue("LEZTENT", a.LetzteEntnahme);

            String cmdString = "insert into tArtikel (ArtikelNr, ArtikelGruppe, Bezeichnung, ";
            cmdString += "Bestand, Meldebestand, Verpackung, VkPreis, letzteEntnahme) ";
            cmdString += "values (ANR,GRP,BEZ,BEST,MBEST,VPCK,PREIS,LEZTENT);";

            cmd.CommandText = cmdString;

        
                cmd.ExecuteNonQuery();
                toolStripStatusLabelSatus.Text = "Neuer Artikel hinzugefügt";
            


        }

        private void buttonNeuBezirk_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "Insert into tBezirk (Bezirk) values ('" + textBoxBezirk.Text + "')";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Select @@IDENTITY From tBezirk";
            Int32 id = Convert.ToInt32(cmd.ExecuteScalar());
            MessageBox.Show("Satz mit Id " + id.ToString() + " eingefügt");
        }


        private void MeldeBestand(String message)
        {
            MessageBox.Show(message);
        }
    }
}
