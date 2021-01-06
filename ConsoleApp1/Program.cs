using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static List<string[]> readCSV(String filename)
        {
            List<string[]> result = new List<string[]>();
            try
            {
                string[] vrstice = File.ReadAllLines(filename);
                foreach (string vrstica in vrstice)
                {
                    string[] vrednosti = vrstica.Split(',');
                    result.Add(vrednosti);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Napaka pri branju: '{0}'", e);
            }
            return result;
        }
        static void Main(string[] args)
        {
            //string pot = "im_australia_2005.csv";
            //List<string[]> polje = readCSV(pot);

            //Console.WriteLine(polje.Count);



            string path = @"C:\Users\janka\Desktop\Faks\2 LETNIK\2 semester\OZRA\Race-Results\Race-Results\IRONMAN\CSV";

            //foreach (string imeDat in Directory.GetFiles(path, "*.csv").Select(Path.GetFullPath))
            //{
            //    Console.WriteLine(imeDat);
            //}

            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
            csb.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\janka\source\repos\TekmovanjeLib\WcfTekmovanjeREST\App_Data\TekmovanjeDATA.mdf;Integrated Security=True";

            int s = 0;
            using (SqlConnection conn = new SqlConnection(csb.ConnectionString))
            {
                foreach (string imeDat in Directory.GetFiles(path, "*.csv").Select(Path.GetFileName))
                {
                    List<string[]> polje = readCSV(@"C:\Users\janka\Desktop\Faks\2 LETNIK\2 semester\OZRA\Race-Results\Race-Results\IRONMAN\CSV\" + imeDat);

                    conn.Open();
                    for (int i = 1; i < polje.Count; i++)
                    {
                        if (polje[i].Length == 20)
                        {
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO Tekmovanje (Tekmovanje, name, genderRank, divRank, overallRank, bib, division, age, state, country, profession, points, swim, swimDistance, t1, bike, bikeDistance, t2, run, runDistance, overall) VALUES (@Tekmovanje, @name, @genderRank, @divRank, @overallRank, @bib, @division, @age, @state, @country, @profession, @points, @swim, @swimDistance, @t1, @bike, @bikeDistance, @t2, @run, @runDistance, @overall)"))
                            {
                                cmd.CommandType = CommandType.Text;
                                cmd.Connection = conn;

                                cmd.Parameters.AddWithValue("@Tekmovanje", imeDat);
                                cmd.Parameters.AddWithValue("@name", polje[i].ElementAt(0));
                                cmd.Parameters.AddWithValue("@genderRank", polje[i].ElementAt(1));
                                cmd.Parameters.AddWithValue("@divRank", polje[i].ElementAt(2));
                                cmd.Parameters.AddWithValue("@overallRank", polje[i].ElementAt(3));
                                cmd.Parameters.AddWithValue("@bib", polje[i].ElementAt(4));
                                cmd.Parameters.AddWithValue("@division", polje[i].ElementAt(5));
                                cmd.Parameters.AddWithValue("@age", polje[i].ElementAt(6));
                                cmd.Parameters.AddWithValue("@state", polje[i].ElementAt(7));
                                cmd.Parameters.AddWithValue("@country", polje[i].ElementAt(8));
                                cmd.Parameters.AddWithValue("@profession", polje[i].ElementAt(9));
                                cmd.Parameters.AddWithValue("@points", polje[i].ElementAt(10));
                                cmd.Parameters.AddWithValue("@swim", polje[i].ElementAt(11));
                                cmd.Parameters.AddWithValue("@swimDistance", polje[i].ElementAt(12));
                                cmd.Parameters.AddWithValue("@t1", polje[i].ElementAt(13));
                                cmd.Parameters.AddWithValue("@bike", polje[i].ElementAt(14));
                                cmd.Parameters.AddWithValue("@bikeDistance", polje[i].ElementAt(15));
                                cmd.Parameters.AddWithValue("@t2", polje[i].ElementAt(16));
                                cmd.Parameters.AddWithValue("@run", polje[i].ElementAt(17));
                                cmd.Parameters.AddWithValue("@runDistance", polje[i].ElementAt(18));
                                cmd.Parameters.AddWithValue("@overall", polje[i].ElementAt(19));

                                cmd.ExecuteNonQuery();
                            }
                        }
                        else
                            s++;
                    }
                    conn.Close();
                }
            }



            //Console.WriteLine(polje[1].ElementAt(18));



            Console.WriteLine("Napačnih vrstic: " + s);

            Console.ReadLine();
        }
    }
}
