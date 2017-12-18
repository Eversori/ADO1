using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationDb1
{
    public partial class FormUpdate : Form
    {
        Artikel selArtikel;
        DialogResult result = DialogResult.OK;

        public DialogResult Result
        {
            get
            {
                return result;
            }

            private set
            {
                result = value;
            }
        }

        public Artikel SelArtikel
        {
            get
            {
                return selArtikel;
            }

            set
            {
                selArtikel = value;
            }
        }

        public FormUpdate()
        {
            InitializeComponent();
        }

        public FormUpdate(Artikel artikel) : this()
        {
            SelArtikel = artikel;
            InitializeControls();
        }

        private void InitializeControls()
        {
            this.textBoxID.Text = SelArtikel.ArtikelOid.ToString();
            this.textBoxNr.Text = SelArtikel.ArtikelNr;
            this.textBoxGrp.Text = SelArtikel.ArtikelGruppe.ToString();
            this.textBoxBez.Text = SelArtikel.Bezeichnung;
            this.textBoxBestand.Text = SelArtikel.Bestand.ToString();
            this.textBoxMeldeBest.Text = SelArtikel.Meldebestand.ToString();
            this.textBoxVerpackung.Text = SelArtikel.Verpackung.ToString();
            this.textBoxPreis.Text = SelArtikel.VkPreis.ToString();
            this.textBoxEntname.Text = SelArtikel.LetzteEntnahme.ToShortDateString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Result = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            SelArtikel.ArtikelNr = textBoxNr.Text;
            SelArtikel.Bezeichnung = textBoxBez.Text;
            SelArtikel.Bestand = Convert.ToUInt16(textBoxBestand.Text);
            SelArtikel.Meldebestand = Convert.ToInt16(textBoxMeldeBest.Text);
            SelArtikel.VkPreis = Convert.ToDecimal(textBoxPreis.Text);
            SelArtikel.LetzteEntnahme = Convert.ToDateTime(textBoxEntname.Text);


            this.Close();
        }
    }
}
