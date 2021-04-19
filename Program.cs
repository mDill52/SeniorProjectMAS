using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace SeniorProjectMAS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Control Panel and Sensors, not all of them, just a few
            ControlPanel cPanel1 = new ControlPanel(1, "First Floor Maintenance", "Shouldifixit22", "Ilovelamp3");
            FireSensor fSense1 = new FireSensor(1, "First Floor Lobby");
            SmokeSensor sSense1 = new SmokeSensor(1, "First Floor Lobby");
            HeatSensor hSense1 = new HeatSensor(2, "Second Floor Offices");
            StaticElectricitySensor sESense1 = new StaticElectricitySensor(3, "Server Room");

            Console.WriteLine("\t MAS System ");
            Console.WriteLine("\t------------");
            Console.WriteLine("\n*** Enter your Login Information. ***");

            UsernameRequired();

            string choice = "";

            while (choice != "3")
            {
                ShowMainMenu();
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        while (choice != "5")
                        {
                            // display menu
                            ShowSensorMenu();
                            choice = Console.ReadLine();

                            // run code based on user's choice
                            switch (choice)
                            {
                                case "1":
                                    while (choice != "5")
                                    {
                                        // display menu
                                        ShowFireSensorMenu();
                                        choice = Console.ReadLine();

                                        switch (choice)
                                        {
                                            case "1":
                                                var sensorTime = DateTime.Now;
                                                string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Mark\Desktop\CIS477\MASDB.mdb;Persist Security Info=False;";
                                                string accQuery = "Select * FROM tbl_fireSensor";
                                                try
                                                {
                                                    using (OleDbConnection dbConn = new OleDbConnection(connectionString))
                                                    {
                                                        OleDbCommand command = new OleDbCommand(accQuery, dbConn);
                                                        dbConn.Open();
                                                        OleDbDataReader reader = command.ExecuteReader();

                                                        while (reader.Read())
                                                        {
                                                            Console.WriteLine("\nID: " + reader["fireID"]);
                                                            Console.Write("Status: "); fSense1.SensorStatus();
                                                            Console.WriteLine("Date: " + sensorTime);
                                                            Console.WriteLine("Location: " + reader["Location"]);
                                                        }
                                                        reader.Close();
                                                    }
                                                }
                                                catch (Exception)
                                                {
                                                    Console.WriteLine("Failed to connect to Database.");
                                                }
                                                break;
                                            case "2":
                                                fSense1.ActivateSensor();
                                                break;
                                            case "3":
                                                fSense1.DeactivateSensor();
                                                break;
                                            case "4":
                                                fSense1.ResetSensor();
                                                break;
                                            case "5":
                                                Console.WriteLine("\nPress Enter to return to the previous menu");
                                                break;
                                            default:
                                                Console.WriteLine("\nError. Please select from the menu.");
                                                break;
                                        }
                                        Console.ReadLine();
                                    }
                                    break;
                                case "2":
                                    while (choice != "5")
                                    {
                                        // display menu
                                        ShowHeatSensorMenu();
                                        choice = Console.ReadLine();

                                        switch (choice)
                                        {
                                            case "1":
                                                var sensorTime = DateTime.Now;
                                                string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Mark\Desktop\CIS477\MASDB.mdb;Persist Security Info=False;";
                                                string accQuery = "Select * FROM tbl_heatSensor";
                                                try
                                                {
                                                    using (OleDbConnection dbConn = new OleDbConnection(connectionString))
                                                    {
                                                        OleDbCommand command = new OleDbCommand(accQuery, dbConn);
                                                        dbConn.Open();
                                                        OleDbDataReader reader = command.ExecuteReader();

                                                        while (reader.Read())
                                                        {
                                                            Console.WriteLine("\nID: " + reader["HeatID"]);
                                                            Console.Write("Status: "); hSense1.SensorStatus();
                                                            Console.WriteLine("Date: " + sensorTime);
                                                            Console.WriteLine("Location: " + reader["Location"]);
                                                        }
                                                        reader.Close();
                                                    }
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine("Failed to connect to Database.");
                                                }
                                                break;
                                            case "2":
                                                hSense1.ActivateSensor();
                                                break;
                                            case "3":
                                                hSense1.DeactivateSensor();
                                                break;
                                            case "4":
                                                hSense1.ResetSensor();
                                                break;
                                            case "5":
                                                Console.WriteLine("\nPress Enter to return to the previous menu");
                                                break;
                                            default:
                                                Console.WriteLine("\nError. Please select from the menu.");
                                                break;
                                        }
                                        Console.ReadLine();
                                    }
                                    break;
                                case "3":
                                    while (choice != "5")
                                    {
                                        // display menu
                                        ShowSmokeSensorMenu();
                                        choice = Console.ReadLine();

                                        switch (choice)
                                        {
                                            case "1":
                                                var sensorTime = DateTime.Now;
                                                string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Mark\Desktop\CIS477\MASDB.mdb;Persist Security Info=False;";
                                                string accQuery = "Select * FROM tbl_smokeSensor";
                                                try
                                                {
                                                    using (OleDbConnection dbConn = new OleDbConnection(connectionString))
                                                    {
                                                        OleDbCommand command = new OleDbCommand(accQuery, dbConn);
                                                        dbConn.Open();
                                                        OleDbDataReader reader = command.ExecuteReader();

                                                        while (reader.Read())
                                                        {
                                                            Console.WriteLine("\nID: " + reader["smokeID"]);
                                                            Console.Write("Status: "); sSense1.SensorStatus();
                                                            Console.WriteLine("Date: " + sensorTime);
                                                            Console.WriteLine("Location: " + reader["Location"]);
                                                        }
                                                        reader.Close();

                                                    }
                                                }
                                                catch (Exception)
                                                {
                                                    Console.WriteLine("Failed to connect to Database.");
                                                }

                                                break;
                                            case "2":
                                                sSense1.ActivateSensor();
                                                break;
                                            case "3":
                                                sSense1.DeactivateSensor();
                                                break;
                                            case "4":
                                                sSense1.ResetSensor();
                                                break;
                                            case "5":
                                                Console.WriteLine("\nPress Enter to return to the previous menu");
                                                break;
                                            default:
                                                Console.WriteLine("\nError. Please select from the menu.");
                                                break;
                                        }
                                        Console.ReadLine();
                                    }
                                    break;
                                case "4":
                                    while (choice != "5")
                                    {
                                        // display menu
                                        ShowStaticElectricitySensorMenu();
                                        choice = Console.ReadLine();

                                        switch (choice)
                                        {
                                            case "1":
                                                var sensorTime = DateTime.Now;
                                                string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Mark\Desktop\CIS477\MASDB.mdb;Persist Security Info=False;";
                                                string accQuery = "Select * FROM tbl_staticSensor";
                                                try
                                                {
                                                    using (OleDbConnection dbConn = new OleDbConnection(connectionString))
                                                    {
                                                        OleDbCommand command = new OleDbCommand(accQuery, dbConn);
                                                        dbConn.Open();
                                                        OleDbDataReader reader = command.ExecuteReader();

                                                        while (reader.Read())
                                                        {
                                                            Console.WriteLine("\nID: " + reader["staticID"]);
                                                            Console.Write("Status: "); hSense1.SensorStatus();
                                                            Console.WriteLine("Date: " + sensorTime);
                                                            Console.WriteLine("Location: " + reader["Location"]);
                                                        }
                                                        reader.Close();

                                                    }
                                                }
                                                catch (Exception)
                                                {
                                                    Console.WriteLine("Failed to connect to Database.");
                                                }

                                                break;
                                            case "2":
                                                sESense1.ActivateSensor();
                                                break;
                                            case "3":
                                                sESense1.DeactivateSensor();
                                                break;
                                            case "4":
                                                sESense1.ResetSensor();
                                                break;
                                            case "5":
                                                Console.WriteLine("\nPress Enter to return to the previous menu");
                                                break;
                                            default:
                                                Console.WriteLine("\nError. Please select from the menu.");
                                                break;
                                        }
                                        Console.ReadLine();
                                    }
                                    break;
                                case "5":
                                    Console.WriteLine("\nPress Enter to return to the previous menu.");
                                    break;
                                default:
                                    Console.WriteLine("\nError. Please select from the menu.");
                                    break;
                            }
                            Console.ReadLine();
                        }
                        break;
                    case "2":
                        cPanel1.LogOut();
                        break;
                    case "3":
                        Console.WriteLine("\nGoodbye");
                        break;
                    default:
                        Console.WriteLine("\nError. Please select from the menu.");
                        break;
                }
                //Console.ReadLine();

            }

        }
        // End of Main

        // Menus
        private static void ShowMainMenu()
        {
            Console.Clear(); // clears the screen
            Console.WriteLine("\tMAS Main Menu");
            Console.WriteLine("\t-----------\n");
            Console.WriteLine("1) Sensor Options");
            Console.WriteLine("2) Log Out");
            Console.WriteLine("3) Exit");

            Console.WriteLine("Enter your choice:");
        }

        private static void ShowSensorMenu()
        {
            Console.Clear(); // clears the screen
            Console.WriteLine("\n*** Choose a Sensor ***\n");
            Console.WriteLine("1) Fire Sensor");
            Console.WriteLine("2) Heat Sensor");
            Console.WriteLine("3) Smoke Sensor");
            Console.WriteLine("4) Static Electricity Sensor");
            Console.WriteLine("5) Exit");

            Console.WriteLine("Enter your choice:");
        }

        private static void ShowFireSensorMenu()
        {
            Console.Clear(); // clears the screen
            Console.WriteLine("\n*** What do you want to do with the Fire Sensor? ***\n");
            Console.WriteLine("1) View Sensor");
            Console.WriteLine("2) Activate Sensor");
            Console.WriteLine("3) Deactivate Sensor");
            Console.WriteLine("4) Reset Sensor");
            Console.WriteLine("5) Exit");

            Console.WriteLine("Enter your choice:");
        }
        private static void ShowHeatSensorMenu()
        {
            Console.Clear(); // clears the screen
            Console.WriteLine("\n*** What do you want to do with the Heat Sensor? ***\n");
            Console.WriteLine("1) View Sensor");
            Console.WriteLine("2) Activate Sensor");
            Console.WriteLine("3) Deactivate Sensor");
            Console.WriteLine("4) Reset Sensor");
            Console.WriteLine("5) Exit");

            Console.WriteLine("Enter your choice:");
        }
        private static void ShowSmokeSensorMenu()
        {
            Console.Clear(); // clears the screen
            Console.WriteLine("\n*** What do you want to do with the Smoke Sensor? ***\n");
            Console.WriteLine("1) View Sensor");
            Console.WriteLine("2) Activate Sensor");
            Console.WriteLine("3) Deactivate Sensor");
            Console.WriteLine("4) Reset Sensor");
            Console.WriteLine("5) Exit");

            Console.WriteLine("Enter your choice:");
        }
        private static void ShowStaticElectricitySensorMenu()
        {
            Console.Clear(); // clears the screen
            Console.WriteLine("\n*** What do you want to do with the Static Electricity Sensor? ***\n");
            Console.WriteLine("1) View Sensor");
            Console.WriteLine("2) Activate Sensor");
            Console.WriteLine("3) Deactivate Sensor");
            Console.WriteLine("4) Reset Sensor");
            Console.WriteLine("5) Exit");

            Console.WriteLine("Enter your choice:");
        }
        private static void UsernameRequired()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nUsername:");
                string username = Console.ReadLine();
                if (username.Length > 4 && username.Length < 16)
                {
                    i = 5;
                    PasswordRequired();
                }
                else
                {
                    Console.WriteLine("\nUsername was not recognized.");
                }

            }
        }
        private static void PasswordRequired()
        {
            string password;
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("\nPassword:");
                password = Console.ReadLine();

                if (password.Length > 7 && password.Length < 20)
                {
                    i = 5;
                    ShowMainMenu();
                }
                else
                {
                    Console.WriteLine("\nPassword was incorrect.");
                }
            }

        }
    }

}




