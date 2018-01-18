using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GameLibrarian
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseCommunicator dbcom = new DatabaseCommunicator();
            Game[] heh = dbcom.GetAllGames();
            foreach(Game game in heh)
            {
                Console.Write(game.visibleName);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


    }
}
