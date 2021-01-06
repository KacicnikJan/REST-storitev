using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassTekmovanje
{

    public class TekmovanjeDAO
    {
        private string connString;

        public string ConnString
        {
            get { return connString; }
            set { connString = value; }
        }

        public List<TekmovanjeInfo> GetTekmovalec(string name)
        {
            List<TekmovanjeInfo> tekmovanje = null;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText= "SELECT ID, tekmovanje, name, genderRank, divRank, overallRank, bib, division, age, state, country, profession, points, swim, swimDistance, t1, bike, bikeDistance, t2, run, runDistance, overall FROM Tekmovanje WHERE name=@name";
            cmd.Parameters.Add("name", SqlDbType.VarChar).Value = name;
            conn.Open();

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    tekmovanje = new List<TekmovanjeInfo>();
                    while (rd.Read())
                    {
                        TekmovanjeInfo t = new TekmovanjeInfo();
                        t = new TekmovanjeInfo();

                        t.id = rd.GetInt32(0);
                        t.tekmovanje = rd.GetString(1);
                        t.name = rd.GetString(2);
                        t.genderRank = rd.GetString(3);
                        t.divRank = rd.GetString(4);
                        t.overallRank = rd.GetString(5);
                        t.bib = rd.GetString(6);
                        t.division = rd.GetString(7);
                        t.age = rd.GetString(8);
                        t.state = rd.GetString(9);
                        t.country = rd.GetString(10);
                        t.profession = rd.GetString(11);
                        t.points = rd.GetString(12);
                        t.swim = rd.GetString(13);
                        t.swimDistance = rd.GetString(14);
                        t.t1 = rd.GetString(15);
                        t.bike = rd.GetString(16);
                        t.bikeDistance = rd.GetString(17);
                        t.t2 = rd.GetString(18);
                        t.run = rd.GetString(19);
                        t.runDistance = rd.GetString(20);
                        t.overall = rd.GetString(21);

                        tekmovanje.Add(t);
                    }
                }

            }
            catch (Exception ex)
            {

            }

            conn.Close();

            return tekmovanje;

        }

        public List<TekmovanjeInfo>GetTekmovanje(string tekmovanje)
        {
            List<TekmovanjeInfo> tekmovanje1 = null;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID, tekmovanje, name, genderRank, divRank, overallRank, bib, division, age, state, country, profession, points, swim, swimDistance, t1, bike, bikeDistance, t2, run, runDistance, overall FROM Tekmovanje WHERE tekmovanje=@tekmovanje";
            cmd.Parameters.Add("tekmovanje", SqlDbType.VarChar).Value = tekmovanje;

            
            
            return tekmovanje1;
        }

        public List<TekmovanjeInfo>GetTekmovanja()
        {
            List<TekmovanjeInfo> tekmovanje = null;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID, tekmovanje, name, genderRank, divRank, overallRank, bib, division, age, state, country, profession, points, swim, swimDistance, t1, bike, bikeDistance, t2, run, runDistance, overall FROM Tekmovanje";

            conn.Open();

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    tekmovanje = new List<TekmovanjeInfo>();
                    while (rd.Read())
                    {
                        TekmovanjeInfo t = new TekmovanjeInfo();
                        t = new TekmovanjeInfo();

                        t.id = rd.GetInt32(0);
                        t.tekmovanje = rd.GetString(1);
                        t.name = rd.GetString(2);
                        t.genderRank = rd.GetString(3);
                        t.divRank = rd.GetString(4);
                        t.overallRank = rd.GetString(5);
                        t.bib = rd.GetString(6);
                        t.division = rd.GetString(7);
                        t.age = rd.GetString(8);
                        t.state = rd.GetString(9);
                        t.country = rd.GetString(10);
                        t.profession = rd.GetString(11);
                        t.points = rd.GetString(12);
                        t.swim = rd.GetString(13);
                        t.swimDistance = rd.GetString(14);
                        t.t1 = rd.GetString(15);
                        t.bike = rd.GetString(16);
                        t.bikeDistance = rd.GetString(17);
                        t.t2 = rd.GetString(18);
                        t.run = rd.GetString(19);
                        t.runDistance = rd.GetString(20);
                        t.overall = rd.GetString(21);

                        tekmovanje.Add(t);
                    }
                }

            }
            catch (Exception ex)
            {

            }

            conn.Close();

            return tekmovanje;
        }

        public List<string>SeznamTekmovanj()
        {
            List<string> tekmovanja = null;

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT DISTINCT tekmovanje FROM tekmovanje ORDER BY tekmovanje ASC";

            conn.Open();

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    tekmovanja = new List<string>();
                    while (rd.Read())
                    {
                        

                        string naziv = null;

                        naziv = rd.GetString(0);
                        

                        tekmovanja.Add(naziv);
                    }
                }

            }
            catch (Exception ex)
            {

            }

            conn.Close();

            return tekmovanja;
        }


        public void CreateTekmovanje(TekmovanjeInfo tekmovanje)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO tekmovanje ( tekmovanje, name, genderRank, divRank, overallRank, bib, division, age, state, country, profession, points, swim, swimDistance, t1, bike, bikeDistance, t2, run, runDistance, overall) values ( @tekmovanje, @name, @genderRank, @divRank, @overallRank, @bib, @division, @age, @state, @country, @profession, @points, @swim, @swimDistance, @t1, @bike, @bikeDistance, @t2, @run, @runDistance, @overall) ";
            cmd.Parameters.Add("tekmovanje", SqlDbType.VarChar).Value = tekmovanje.tekmovanje;
            cmd.Parameters.Add("name", SqlDbType.VarChar).Value = tekmovanje.name;
            cmd.Parameters.Add("genderRank", SqlDbType.VarChar).Value = tekmovanje.genderRank;
            cmd.Parameters.Add("divRank", SqlDbType.VarChar).Value = tekmovanje.divRank;
            cmd.Parameters.Add("overallRank", SqlDbType.VarChar).Value = tekmovanje.overallRank;
            cmd.Parameters.Add("bib", SqlDbType.VarChar).Value = tekmovanje.bib;
            cmd.Parameters.Add("division", SqlDbType.VarChar).Value = tekmovanje.division;
            cmd.Parameters.Add("age", SqlDbType.VarChar).Value = tekmovanje.age;
            cmd.Parameters.Add("state", SqlDbType.VarChar).Value = tekmovanje.state;
            cmd.Parameters.Add("country", SqlDbType.VarChar).Value = tekmovanje.country;
            cmd.Parameters.Add("profession", SqlDbType.VarChar).Value = tekmovanje.profession;
            cmd.Parameters.Add("points", SqlDbType.VarChar).Value = tekmovanje.points;
            cmd.Parameters.Add("swim", SqlDbType.VarChar).Value = tekmovanje.swim;
            cmd.Parameters.Add("swimDistance", SqlDbType.VarChar).Value = tekmovanje.swimDistance;
            cmd.Parameters.Add("t1", SqlDbType.VarChar).Value = tekmovanje.t1;
            cmd.Parameters.Add("bike", SqlDbType.VarChar).Value = tekmovanje.bike;
            cmd.Parameters.Add("bikeDistance", SqlDbType.VarChar).Value = tekmovanje.bikeDistance;
            cmd.Parameters.Add("t2", SqlDbType.VarChar).Value = tekmovanje.t2;
            cmd.Parameters.Add("run", SqlDbType.VarChar).Value = tekmovanje.run;
            cmd.Parameters.Add("runDistance", SqlDbType.VarChar).Value = tekmovanje.runDistance;
            cmd.Parameters.Add("overall", SqlDbType.VarChar).Value = tekmovanje.overall;

            conn.Open();

            try
            {
                int create = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }

            conn.Close();

        }

        public void UpdateTekmovalec(string id, TekmovanjeInfo tekmovanje)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Tekmovalec SET tekmovanje=@tekmovanje, name=@name, genderRank=@genderRank, divRank=@divRank, overallRank=@overallRank, bib=@bib, division=@division, age=@age, state=@state, country=@country, profession=@profession, points=@points, swim=@swim, swimDistance=@swimDistance, t1=@t1, bike=@bike, bikeDistance=@bikeDistance, t2=@t2, run=@run, runDistance=@runDistance, overall=@overall WHERE ID=@ID";

            cmd.Parameters.Add("ID", SqlDbType.Int).Value = int.Parse(id);

            cmd.Parameters.Add("tekmovanje", SqlDbType.VarChar).Value = tekmovanje.tekmovanje;
            cmd.Parameters.Add("name", SqlDbType.VarChar).Value = tekmovanje.name;
            cmd.Parameters.Add("genderRank", SqlDbType.VarChar).Value = tekmovanje.genderRank;
            cmd.Parameters.Add("divRank", SqlDbType.VarChar).Value = tekmovanje.divRank;
            cmd.Parameters.Add("overallRank", SqlDbType.VarChar).Value = tekmovanje.overallRank;
            cmd.Parameters.Add("bib", SqlDbType.VarChar).Value = tekmovanje.bib;
            cmd.Parameters.Add("division", SqlDbType.VarChar).Value = tekmovanje.division;
            cmd.Parameters.Add("age", SqlDbType.VarChar).Value = tekmovanje.age;
            cmd.Parameters.Add("state", SqlDbType.VarChar).Value = tekmovanje.state;
            cmd.Parameters.Add("country", SqlDbType.VarChar).Value = tekmovanje.country;
            cmd.Parameters.Add("profession", SqlDbType.VarChar).Value = tekmovanje.profession;
            cmd.Parameters.Add("points", SqlDbType.VarChar).Value = tekmovanje.points;
            cmd.Parameters.Add("swim", SqlDbType.VarChar).Value = tekmovanje.swim;
            cmd.Parameters.Add("swimDistance", SqlDbType.VarChar).Value = tekmovanje.swimDistance;
            cmd.Parameters.Add("t1", SqlDbType.VarChar).Value = tekmovanje.t1;
            cmd.Parameters.Add("bike", SqlDbType.VarChar).Value = tekmovanje.bike;
            cmd.Parameters.Add("bikeDistance", SqlDbType.VarChar).Value = tekmovanje.bikeDistance;
            cmd.Parameters.Add("t2", SqlDbType.VarChar).Value = tekmovanje.t2;
            cmd.Parameters.Add("run", SqlDbType.VarChar).Value = tekmovanje.run;
            cmd.Parameters.Add("runDistance", SqlDbType.VarChar).Value = tekmovanje.runDistance;
            cmd.Parameters.Add("overall", SqlDbType.VarChar).Value = tekmovanje.overall;

            conn.Open();

            try
            {
                int update = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }

            conn.Close();
        }
        public void DeleteTekmovalec(string id)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM tekmovanje WHERE id=@id";
            cmd.Parameters.Add("id", SqlDbType.Int).Value = int.Parse(id);

            conn.Open();

            try
            {
                int delete = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }

            conn.Close();
        }

        public List<Izdelki> GetIzdelke()
        {
            List<Izdelki> izdelki = new List<Izdelki>();

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id, naziv, opis, kategorija, cena FROM izdelki";

            conn.Open();

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    izdelki = new List<Izdelki>();
                    while (rd.Read())
                    {
                        Izdelki n = new Izdelki();
                        n = new Izdelki();

                        n.id = rd.GetInt32(0);
                        n.naziv= rd.GetString(1);
                        n.opis = rd.GetString(2);
                        n.kategorija = rd.GetString(3);
                        n.cena = rd.GetString(4);

                        izdelki.Add(n);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            conn.Close();

            return izdelki;
        }

        public void CreateIzdelek(Izdelki izdelek)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Izdelek (naziv, opis, kategorija, cena) VALUES (@naziv, @opis, @kategorija, @cena)";
            cmd.Parameters.Add("Naziv", SqlDbType.VarChar).Value = izdelek.naziv;
            cmd.Parameters.Add("Opis", SqlDbType.VarChar).Value = izdelek.opis;
            cmd.Parameters.Add("Kategorija", SqlDbType.VarChar).Value = izdelek.kategorija;
            cmd.Parameters.Add("Cena", SqlDbType.VarChar).Value = izdelek.cena;

            conn.Open();

            try
            {
                int create = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }

            conn.Close();
        }

        public void UpdateIzdelek(string id, Izdelki izdelek)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Novica SET naziv=@naziv, opis=@opis, kategorija=@kategorija, cena=@cena WHERE id=@id";

            cmd.Parameters.Add("ID", SqlDbType.Int).Value = int.Parse(id);

            cmd.Parameters.Add("Naziv", SqlDbType.VarChar).Value = izdelek.naziv;
            cmd.Parameters.Add("Opis", SqlDbType.VarChar).Value = izdelek.opis;
            cmd.Parameters.Add("Kategorija", SqlDbType.VarChar).Value = izdelek.kategorija;
            cmd.Parameters.Add("Cena", SqlDbType.VarChar).Value = izdelek.cena;

            conn.Open();

            try
            {
                int update = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }

            conn.Close();
        }

        public void DeleteIzdelek(string id)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Izdelki WHERE id=@id";
            cmd.Parameters.Add("id", SqlDbType.Int).Value = int.Parse(id);

            conn.Open();

            try
            {
                int delete = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }

            conn.Close();
        }


        public List<Admin> GetAdmin()
        {
            List<Admin> admin = new List<Admin>();

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id, Username, Password FROM Admin";

            conn.Open();

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    admin = new List<Admin>();
                    while (rd.Read())
                    {
                        Admin a = new Admin();
                        a = new Admin();

                        a.Id = rd.GetInt32(0);
                        a.username = rd.GetString(1);
                        a.password = rd.GetString(2);

                        admin.Add(a);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            conn.Close();

            //Admin b = new Admin();
            //b.ID = 3;
            //b.UpIme = "aaa";
            //b.Geslo = "aaa";

            //admini.Add(b);

            return admin;
        }


        //Uporabnik prijava **********....................*************************
        public List<Uporabnik> GetUporabnik()
        {
            List<Uporabnik> user = new List<Uporabnik>();

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id, Username, Password FROM Uporabnik";

            conn.Open();

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    user = new List<Uporabnik>();
                    while (rd.Read())
                    {
                        Uporabnik u = new Uporabnik();
                        u = new Uporabnik();

                        u.Id = rd.GetInt32(0);
                        u.username = rd.GetString(1);
                        u.password = rd.GetString(2);

                        user.Add(u);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            conn.Close();

            //Admin b = new Admin();
            //b.ID = 3;
            //b.UpIme = "aaa";
            //b.Geslo = "aaa";

            //admini.Add(b);

            return user;
        }

        //Novice ******************.........................************************
        public List<Obvetilo> GetObvestila()
        {
            List<Obvetilo> obvestilo = new List<Obvetilo>();

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id, naziv, opis, datum_objave FROM Obvestilo";

            conn.Open();

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    obvestilo = new List<Obvetilo>();
                    while (rd.Read())
                    {
                        Obvetilo o = new Obvetilo();
                        o = new Obvetilo();

                        o.id = rd.GetInt32(0);
                        o.naziv = rd.GetString(1);
                        o.opis = rd.GetString(2);
                        o.datum_objave = rd.GetString(3);


                        obvestilo.Add(o);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            conn.Close();

            return obvestilo;
        }

        public void CreateObvestilo(Obvetilo obvestilo)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Obvestilo (naziv, opis, datum_objave) VALUES (@naziv, @opis, @datum_objave)";
            cmd.Parameters.Add("Naziv", SqlDbType.VarChar).Value = obvestilo.naziv;
            cmd.Parameters.Add("Opis", SqlDbType.VarChar).Value = obvestilo.opis;
            cmd.Parameters.Add("Datum objave", SqlDbType.VarChar).Value = obvestilo.datum_objave;
            

            conn.Open();

            try
            {
                int create = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }

            conn.Close();
        }

        public void UpdateObvestilo(string id, Obvetilo obvestilo)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Obvestilo SET naziv=@naziv, opis=@opis, datum_objave=@datum_objave WHERE id=@id";

            cmd.Parameters.Add("ID", SqlDbType.Int).Value = int.Parse(id);

            cmd.Parameters.Add("Naziv", SqlDbType.VarChar).Value = obvestilo.naziv;
            cmd.Parameters.Add("Opis", SqlDbType.VarChar).Value = obvestilo.opis;
            cmd.Parameters.Add("Datum objave", SqlDbType.VarChar).Value = obvestilo.datum_objave;
            

            conn.Open();

            try
            {
                int update = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }

            conn.Close();
        }

        public void DeleteObvestilo(string id)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Obvestilo WHERE id=@id";
            cmd.Parameters.Add("id", SqlDbType.Int).Value = int.Parse(id);

            conn.Open();

            try
            {
                int delete = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }

            conn.Close();
        }
    }
}
