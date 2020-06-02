using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;

using System.Data.Common;



namespace HightApp
{
    
    class Program
    {
       
        [STAThread]
        static void Main()
        {

            using (FileStream fstream = File.OpenRead($"{StatClass.pathToConnectFile}"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                StatClass.textFromFile = System.Text.Encoding.Default.GetString(array);
                StatClass.textFromFile = StatClass.textFromFile.Remove(0, 3);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogInForm());           

        }
    }
    public static class StatClass
    {
        //Данная переменная статического класса будет доступна откуда угодно в пределах проекта
        public static String global_Name = "";
        public static String error = "";
        public static String pathToConnectFile = "..\\..\\ConnectPath.txt";
        public static String dbFileName = "GlobalDateBase.db";

        public static String textFromFile = "";

        public static int prtToEditId = -1;
        public static int empleToEditId = -1;
        public static int jobToEditId = -1;
        
        public static List<User> users = new List<User>();
        public static List<Part> parts = new List<Part>();
        public static List<JobAssignment> jobAssignments = new List<JobAssignment>();
        public static List<Technic> technics = new List<Technic>();

    }

    public static class LoadUsers
    {
        public static void LoadUser()
        {
            StatClass.users.Clear();

            using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
            {

                SQLiteCommand command = new SQLiteCommand("SELECT * FROM dbUsers;", Connect);

                Connect.Open();

                SQLiteDataReader reader = command.ExecuteReader();

                foreach (DbDataRecord record in reader)
                {

                    User user = new User();
                    user.UserId = Int32.Parse(record["userId"].ToString());
                    user.Logins = record["login"].ToString();
                    user.Passwords = record["password"].ToString();
                    user.Fio = record["fio"].ToString();
                    user.AssesLvl = Int32.Parse(record["assesLvl"].ToString());

                    StatClass.users.Add(user);
                    

                }
                Connect.Close();
            }

        }
    }

    public static class LoadParts
    {
        
        public static void Load()
        {
            StatClass.parts.Clear();
            using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
            {

                SQLiteCommand command = new SQLiteCommand("SELECT * FROM dbParts;", Connect);

                Connect.Open();

                SQLiteDataReader reader = command.ExecuteReader();

                foreach (DbDataRecord record in reader)
                {
                    Part part = new Part();

                    part.PartId = Int32.Parse(record["partsId"].ToString());
                    part.Mark = record["mark"].ToString();
                    part.Model = record["model"].ToString();
                    part.Description = record["description"].ToString();
                    part.Remains = Int32.Parse(record["remains"].ToString());
                    part.Prise = float.Parse(record["prise"].ToString());


                    StatClass.parts.Add(part);

                }
                Connect.Close();
            }

        }
    }

    public static class LoadTechnic
    {

        public static void Load()
        {
            StatClass.technics.Clear();
            using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
            {

                SQLiteCommand command = new SQLiteCommand("SELECT * FROM dbTechnic;", Connect);

                Connect.Open();

                SQLiteDataReader reader = command.ExecuteReader();

                foreach (DbDataRecord record in reader)
                {
                    Technic technic = new Technic();
                    technic.TechnicId = Int32.Parse(record["technicId"].ToString());
                    technic.Mark = record["mark"].ToString();
                    technic.Model = record["model"].ToString(); ;
                    technic.Availability = record["availability"].ToString(); ;
                    technic.DateLastRepair = record["dateLastRepair"].ToString(); ;
                    technic.Defect = record["defect"].ToString(); ;

                    StatClass.technics.Add(technic);

                }
                Connect.Close();
            }

        }
    }

    public static class LoadJob
    {
        public static void Load()
        {
            StatClass.jobAssignments.Clear();
            using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
            {

                SQLiteCommand command = new SQLiteCommand("SELECT * FROM dbJobAssignments;", Connect);

                Connect.Open();

                SQLiteDataReader reader = command.ExecuteReader();

                foreach (DbDataRecord record in reader)
                {
                    JobAssignment jobAssignment = new JobAssignment();
                    jobAssignment.JobId = Int32.Parse(record["jobId"].ToString());
                    jobAssignment.Plase = record["plase"].ToString();
                    jobAssignment.TechnicId = Int32.Parse(record["technicId"].ToString());
                    jobAssignment.DateAppointment = record["dateAppointment"].ToString();
                    jobAssignment.MasterId = Int32.Parse(record["master"].ToString());
                    jobAssignment.ExecutorId = Int32.Parse(record["executor"].ToString());


                    StatClass.jobAssignments.Add(jobAssignment);

                }
                Connect.Close();
            }

        }
    }
    public static class Hash
    {
        public static string GetMD5Hash(string text)
        {
            using (var hashAlg = MD5.Create())
            {
                byte[] hash = hashAlg.ComputeHash(Encoding.UTF8.GetBytes(text));
                var builder = new StringBuilder(hash.Length * 2);
                for (int i = 0; i < hash.Length; i++)
                {
                    builder.Append(hash[i].ToString("X2"));
                }
                return builder.ToString();
            }
        }
    }
}
