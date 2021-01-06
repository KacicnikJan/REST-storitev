using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingData
{
    public class Class1
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
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO Tekmovanje (Tekmovanje, name, genderRank, divRank, overallRank, bib, division, age, state, country, profession, points, swim, swimDistance, t1, bike, bikeDistance, t2, run, runDistance, overall) VALUES (@Naslov, @Name, @GenderRank, @DivRank, @OverallRank, @Bib, @Division, @Age, @State, @Country, @Profession, @Points, @SwimTime, @SwimDistance, @T1, @BikeTime, @BikeDistance, @T2, @RunTime, @RunDistance, @Overall)"))
                            {
                                cmd.CommandType = CommandType.Text;
                                cmd.Connection = conn;

                                cmd.Parameters.AddWithValue("@Naslov", imeDat);
                                cmd.Parameters.AddWithValue("@Name", polje[i].ElementAt(0));
                                cmd.Parameters.AddWithValue("@GenderRank", polje[i].ElementAt(1));
                                cmd.Parameters.AddWithValue("@DivRank", polje[i].ElementAt(2));
                                cmd.Parameters.AddWithValue("@OverallRank", polje[i].ElementAt(3));
                                cmd.Parameters.AddWithValue("@Bib", polje[i].ElementAt(4));
                                cmd.Parameters.AddWithValue("@Division", polje[i].ElementAt(5));
                                cmd.Parameters.AddWithValue("@Age", polje[i].ElementAt(6));
                                cmd.Parameters.AddWithValue("@State", polje[i].ElementAt(7));
                                cmd.Parameters.AddWithValue("@Country", polje[i].ElementAt(8));
                                cmd.Parameters.AddWithValue("@Profession", polje[i].ElementAt(9));
                                cmd.Parameters.AddWithValue("@Points", polje[i].ElementAt(10));
                                cmd.Parameters.AddWithValue("@SwimTime", polje[i].ElementAt(11));
                                cmd.Parameters.AddWithValue("@SwimDistance", polje[i].ElementAt(12));
                                cmd.Parameters.AddWithValue("@T1", polje[i].ElementAt(13));
                                cmd.Parameters.AddWithValue("@BikeTime", polje[i].ElementAt(14));
                                cmd.Parameters.AddWithValue("@BikeDistance", polje[i].ElementAt(15));
                                cmd.Parameters.AddWithValue("@T2", polje[i].ElementAt(16));
                                cmd.Parameters.AddWithValue("@RunTime", polje[i].ElementAt(17));
                                cmd.Parameters.AddWithValue("@RunDistance", polje[i].ElementAt(18));
                                cmd.Parameters.AddWithValue("@Overall", polje[i].ElementAt(19));

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
