using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public static String global_Name = "Тестовая строка";
        public static String error = "";
        public static String pathToConnectFile = "..\\..\\ConnectPath.txt";
        public static String dbFileName = "GlobalDateBase.db";

        public static String textFromFile = "";
        public static int prtToEditId = -1;

        public static List<User> users = new List<User>();
        public static List<Part> parts = new List<Part>();

    }

    public static class LoadUsers
    {
        public static void LoadUser()
        {
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
