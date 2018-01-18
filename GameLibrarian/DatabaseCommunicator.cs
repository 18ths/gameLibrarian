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

        public Game[] GetAllGames()
        {
            string sql = "SELECT * FROM games";
            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            List<Game> allGames = new List<Game>();
            while (reader.Read())
            {
                Game newGame = new Game();
                newGame.id = (int)(long)reader["gameId"];
                newGame.visibleName = (string)(reader["name"]);
                allGames.Add(newGame);
            }

            return allGames.ToArray();
        }

        ~DatabaseCommunicator()
        {
          //  connection.Close();
        }
    }
}
