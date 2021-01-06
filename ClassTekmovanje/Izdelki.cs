using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ClassTekmovanje
{
    [DataContract/*(Namespace = "http://si.feri/ozra/tekmovanje")*/]
    public class Izdelki
    {
        private int ID;

        [DataMember(Order = 0)]
        public int id
        {
            get { return ID; }
            set { ID = value; }
        }

        private string Naziv;

        [DataMember(Order = 1)]
        public string naziv
        {
            get { return Naziv; }
            set { Naziv = value; }
        }

        private string Opis;

        [DataMember(Order = 2)]
        public string opis
        {
            get { return Opis; }
            set { Opis = value; }
        }

        private string Kategorija;

        [DataMember(Order = 3)]
        public string kategorija
        {
            get { return Kategorija; }
            set { Kategorija = value; }
        }

        private string Cena;

        [DataMember(Order = 4)]
        public string cena
        {
            get { return Cena; }
            set { Cena = value; }
        }
    }
}
