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
    /// Interaction logic for titleWindow.xaml
    /// </summary>
    public partial class titleWindow : Window
    {
        public titleWindow()
        {
            InitializeComponent();
        }

		private void Start_Game_Click(object sender, RoutedEventArgs e)
		{
            // until a game window is made keep this commented
            // replace window with the name of the game window
            Window gameWindow = new MainWindow();
            gameWindow.Show();

            this.Close();
		}

		private void Quit_Game_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
	}
}
