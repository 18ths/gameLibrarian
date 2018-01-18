using GameLibrarian.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLibrarian
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            //TODO: perhaps some singleton solution should be here present
            //we don't want to open more than one of this
            NewGameWindow window = new NewGameWindow();
            window.Show();
        }
    }
}
