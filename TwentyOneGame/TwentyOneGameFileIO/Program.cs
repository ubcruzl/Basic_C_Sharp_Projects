using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TwentyOneGameFileIO;
using Casino;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOneGameFileIO
{
    class Program
    {
        static void Main(string[] args)
        {

            //string text = "Here is some text.";
            //File.WriteAllText("C:\\Users\\Ubaldo\\Documents\\GitHub\\VisualStudio\\Basic_C_Sharp_Projects\\TwentyOneGame\\TwentyOneGameFileIO\\log.txt",text);
            //string text = File.ReadAllText("C:\\Users\\Ubaldo\\Documents\\GitHub\\VisualStudio\\Basic_C_Sharp_Projects\\TwentyOneGame\\TwentyOneGameFileIO\\log.txt");

            //DateTime dateTime = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfGraduation = new DateTime(1995, 5, 23, 8, 32, 45);
            //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;

            Player newPlayer = new Player("Jesse");

            var newDictionarity = new Dictionary<string, string>();

            const string casinoName= "Grand Hotel and casino";
            Console.WriteLine("Welcome To the {0} \n\nLet's star by telling your name. ", casinoName);
            string playerName = Console.ReadLine();
            ////////////////////////////////////////////////////////////////
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }
            ////////////////////////////////////////////////////////////////
            //Guid identifier = new Guid();
            /*
            Console.WriteLine("And how much money did you bring today? ");
            int bank = Convert.ToInt32(Console.ReadLine());
            */
            ////////////////////////////////////
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(),out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals");
            }
            ////////////////////////////////////
            Console.WriteLine("Hello, {0}. How you like to join a game of 21 right now? ",playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer=="yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName,bank);
                player.Id = Guid.NewGuid();
                /////////////////////////////////
                using (StreamWriter file = new StreamWriter(@"C:\Users\Ubaldo\Documents\GitHub\VisualStudio\Basic_C_Sharp_Projects\TwentyOneGame\TwentyOneGameFileIO\log.txt", true))
                {
                    file.WriteLine(DateTime.Now);
                    file.WriteLine(player.Id);
                }
                /////////////////////////////////
                Game game = new TwentyOneGame();
                game += player;
                player.isActivePlaying = true;

                while (player.isActivePlaying&&player.Balance>0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex) //ArgumentException
                    {
                        //Console.WriteLine("Something you entered, was incorrect.");
                        //Console.WriteLine("!Security! kick this person out.");
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("An error ocurred. Please contact your system administrator");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    
                }

                game -= player;
                Console.WriteLine("Thank you for you playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }
        public enum DaysOfTheWeek
        {
            Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
        }
        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;
                                    Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                    ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string queryString = @"INSERT INTO Exceptions (ExceptionType,ExceptionMessage, TimeStamp) VALUES
                                  (@ExceptionType,@ExceptionMessage, @TimeStamp)";
            using (SqlConnection connection= new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString,connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime
                    );

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private static List<ExceptionEntity> ReadExceptions() 
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;
                                    Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                    ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string queryString = "select Id,ExceptionType,ExceptionMessage,TimeStamp from Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection=new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);

                }
                connection.Close();
            }
            return Exceptions;
        }
    }
}
