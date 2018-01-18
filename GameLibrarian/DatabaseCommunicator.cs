using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace GameLibrarian
{
    class DatabaseCommunicator
    {
        private SQLiteConnection connection = null;

        public DatabaseCommunicator()
        {
            connection = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
            connection.Open();
        }

        public void CreateGamesTable()
        {
            string sql = "CREATE TABLE games (" +
                "gameId INTEGER PRIMARY KEY," +
                "name TEXT NOT NULL" +
                ");";

            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            cmd.ExecuteNonQuery();                            
        }

        public void AddGame(string gameName)
        {
            string sql = "INSERT INTO games (name) values ('" + gameName + "');";
            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            cmd.ExecuteNonQuery();
        }

        ~DatabaseCommunicator()
        {
          //  connection.Close();
        }
    }
}
