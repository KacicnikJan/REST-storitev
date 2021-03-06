﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ClassTekmovanje
{
    [DataContract/*(Namespace = "http://si.feri/ozra/tekmovanje")*/]
    public class Obvetilo
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

        private string Datum_objave;

        [DataMember(Order = 3)]
        public string datum_objave
        {
            get { return Datum_objave; }
            set { Datum_objave = value; }
        }

        

        
    }
}
