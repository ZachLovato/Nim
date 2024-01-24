using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NimGame
{
    /// <summary>
    /// Interaction logic for WinWindow.xaml
    /// </summary>
    public partial class WinWindow : Window
    {
        //new changed the window to take a boolean to check game win
        public WinWindow(bool win)
        {
            InitializeComponent();
            setWinText(win);
        }

        private void Replay_Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow = new titleWindow();

            Application.Current.MainWindow.Show();
            //new
            this.Close();
        }

        private void Quit_Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        //new sets the game winner text
        private void setWinText(bool win)
        {
            if (win)
            {
                WinText.Text = "Player 2 Wins";
            }
            else
            {
                WinText.Text = "Player 1 Wins";
            }
        }
    }
}
