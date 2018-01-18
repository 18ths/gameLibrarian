using GameLibrarian.UI.Common;
using System;
using System.Windows.Forms;

namespace GameLibrarian.UI
{
    public partial class NewGameWindow : Form
    {
        public NewGameWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Game g = new Game
            {
                id = 666,
                visibleName = "Game Librarian Simulator"
            };

            Utils.NotImplementedAlert();
        }
    }
}
