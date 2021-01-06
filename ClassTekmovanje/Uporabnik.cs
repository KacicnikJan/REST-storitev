using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ClassTekmovanje
{
    [DataContract/*(Namespace = "http://si.feri/ozra/tekmovanje")*/]
    public class Uporabnik
    {
        private int id;
        [DataMember(Order = 0)]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string Username;
        [DataMember(Order = 1)]
        public string username
        {
            get { return Username; }
            set { Username = value; }
        }

        private string Password;
        [DataMember(Order = 2)]
        public string password
        {
            get { return Password; }
            set { Password = value; }
        }
    }
}
