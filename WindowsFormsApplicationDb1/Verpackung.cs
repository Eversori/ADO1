using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationDb1
{
    class Verpackung
    {
        Int32 verpackungsId;
        String bezeichnung;

        public int VerpackungsId
        {
            get
            {
                return verpackungsId;
            }

            set
            {
                verpackungsId = value;
            }
        }

        public string Bezeichnung
        {
            get
            {
                return bezeichnung;
            }

            set
            {
                bezeichnung = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", VerpackungsId, Bezeichnung);
        }
    }
}
