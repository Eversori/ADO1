using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationDb1
{
    class ArtGruppe
    {
        Int32 grpId;
        String bezeichnung;

        public int GrpId
        {
            get
            {
                return grpId;
            }

            set
            {
                grpId = value;
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
            return String.Format("{0} - {1}", GrpId, Bezeichnung);
        }
    }
}
