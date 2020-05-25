using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;


namespace HightApp
{
    public class SqlConnect
    {
        
        public static SQLiteConnection m_dbConn;
        public static SQLiteCommand m_sqlCmd;
        //public static string textFromFile;
        


        //из-за того что два раза заходит сюда же и проверяет возвращает неправильное
        public static void Connect()
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
               // MessageBox.Show("----------------------\n" + textFromFile);

            }

            try
            {                
                    SQLiteConnection.CreateFile(StatClass.dbFileName);
            }
            catch (SQLiteException ex)
            {
                StatClass.error = ex.Message;
              

               // MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static bool IsDBExists()
        {
            if (File.Exists(StatClass.dbFileName)) return true;
            else return false;
        }

        public static void CreateTableForDB()
        {
            
            try
            {
                CreateTableUsers();
                CreateTableJobAssignments();
                CreateTableTechnic();
                CreateTableParts();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error при попытке создать базу: " + ex.Message);
            }


        }

        public static void CreateTableUsers()
        {
            using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
            {
                // строка запроса, который надо будет выполнить
                string commandText = "CREATE TABLE IF NOT EXISTS [dbUsers] ( [userId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, [login] VARCHAR(20), [password] VARCHAR(40), [fio] VARCHAR(30), " +
                    "[assesLvl] INTEGER)"; // создать таблицу, если её нет
                SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                Connect.Open(); // открыть соединение
                Command.ExecuteNonQuery(); // выполнить запрос
                Connect.Close(); // закрыть соединение
            }
        }

        public static void CreateTableJobAssignments()
        {
            using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
            {
                // строка запроса, который надо будет выполнить
                string commandText = "CREATE TABLE IF NOT EXISTS [dbJobAssignments] ( [jobId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, [plase] VARCHAR(40), [technicId] INTEGER, " +
                    "[dateAppointment] VARCHAR(15), [master] INTEGER, [executor] INTEGER, FOREIGN KEY (master)  REFERENCES dbUsers (userId),  FOREIGN KEY (executor)  REFERENCES dbUsers (userId), FOREIGN KEY (technicId)  REFERENCES dbTechnic (technicId))"; // создать таблицу, если её нет
                SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                Connect.Open(); // открыть соединение
                Command.ExecuteNonQuery(); // выполнить запрос
                Connect.Close(); // закрыть соединение
            }
        }

        public static void CreateTableTechnic()
        {
            using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
            {
                // строка запроса, который надо будет выполнить
                string commandText = "CREATE TABLE IF NOT EXISTS [dbTechnic] ( [technicId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, [mark] VARCHAR(20), [model] VARCHAR(20), " +
                    "[availability] VARCHAR(15), [dateLastRepair] VARCHAR(10), [defect] VARCHAR(30))"; // создать таблицу, если её нет
                SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                Connect.Open(); // открыть соединение
                Command.ExecuteNonQuery(); // выполнить запрос
                Connect.Close(); // закрыть соединение
            }
        }

        public static void CreateTableParts()
        {
            using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
            {
                // строка запроса, который надо будет выполнить
                string commandText = "CREATE TABLE IF NOT EXISTS [dbParts] ( [partsId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, [mark] VARCHAR(20), [model] VARCHAR(20), " +
                    "[description] VARCHAR(15), [remains] INTEGER, [prise] INTEGER)"; // создать таблицу, если её нет
                SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                Connect.Open(); // открыть соединение
                Command.ExecuteNonQuery(); // выполнить запрос
                Connect.Close(); // закрыть соединение
            }
        }
    }
    
}
