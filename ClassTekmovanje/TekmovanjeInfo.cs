using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ClassTekmovanje
{
    [DataContract/*(Namespace = "http://si.feri/ozra/tekmovanje")*/]
    public class TekmovanjeInfo
    {
        private int ID;

        [DataMember(Order = 0)]
        public int id
        {
            get { return ID; }
            set { ID = value; }
        }

        private string Tekmovanje;

        [DataMember(Order = 1)]
        public string tekmovanje
        {
            get { return Tekmovanje; }
            set { Tekmovanje = value; }
        }

        private string Name;

        [DataMember(Order = 2)]
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        private string GenderRank;

        [DataMember(Order = 3)]
        public string genderRank
        {
            get { return GenderRank; }
            set { GenderRank = value; }
        }

        private string DivRank;

        [DataMember(Order = 4)]
        public string divRank
        {
            get { return DivRank; }
            set { DivRank = value; }
        }

        private string OverallRank;

        [DataMember(Order = 5)]
        public string overallRank
        {
            get { return OverallRank; }
            set { OverallRank = value; }
        }

        private string Bib;

        [DataMember(Order = 6)]
        public string bib
        {
            get { return Bib; }
            set { Bib = value; }
        }

        private string Division;

        [DataMember(Order = 7)]
        public string division
        {
            get { return Division; }
            set { Division = value; }
        }

        private string Age;

        [DataMember(Order = 8)]
        public string age
        {
            get { return Age; }
            set { Age = value; }
        }

        private string State;

        [DataMember(Order = 9)]
        public string state
        {
            get { return State; }
            set { State = value; }
        }

        private string Country;

        [DataMember(Order = 10)]
        public string country
        {
            get { return Country; }
            set { Country = value; }
        }

        private string Profession;

        [DataMember(Order = 11)]
        public string profession
        {
            get { return Profession; }
            set { Profession = value; }
        }

        private string Points;

        [DataMember(Order = 12)]
        public string points
        {
            get { return Points; }
            set { Points = value; }
        }

        private string Swim;

        [DataMember(Order = 13)]
        public string swim
        {
            get { return Swim; }
            set { Swim = value; }
        }

        private string SwimDistance;

        [DataMember(Order = 14)]
        public string swimDistance
        {
            get { return SwimDistance; }
            set { SwimDistance = value; }
        }

        private string T1;

        [DataMember(Order = 15)]
        public string t1
        {
            get { return T1; }
            set { T1 = value; }
        }

        private string Bike;

        [DataMember(Order = 16)]
        public string bike
        {
            get { return Bike; }
            set { Bike = value; }
        }

        private string BikeDistance;

        [DataMember(Order = 17)]
        public string bikeDistance
        {
            get { return BikeDistance; }
            set { BikeDistance = value; }
        }

        private string T2;

        [DataMember(Order = 18)]
        public string t2
        {
            get { return T2; }
            set { T2 = value; }
        }

        private string Run;

        [DataMember(Order = 19)]
        public string run
        {
            get { return Run; }
            set { Run = value; }
        }

        private string RunDistance;

        [DataMember(Order = 20)]
        public string runDistance
        {
            get { return RunDistance; }
            set { RunDistance = value; }
        }

        private string Overall;

        [DataMember(Order = 21)]
        public string overall
        {
            get { return Overall; }
            set { Overall = value; }
        }
    }
}
