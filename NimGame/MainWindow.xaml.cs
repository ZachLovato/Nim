using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NimGame
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		//create new array of the images
		NimGames nim = new NimGames();
		Image[] Row1 = new Image[1];
		Image[] Row2 = new Image[3];
		Image[] Row3 = new Image[5];
		Image[] Row4 = new Image[7];

		//check the index of the arrays
		int index1 = 0;
		int index2 = 2;
		int index3 = 4;
		int index4 = 6;
		//end
		public MainWindow()
		{
			InitializeComponent();
			//set the images to correct rows
			//row 1
			Row1[0] = Match;
			//row 2
			Row2[0] = Match_Copy;
			Row2[1] = Match_Copy1;
			Row2[2] = Match_Copy2;
			//row 3
			Row3[0] = Match_Copy3;
			Row3[1] = Match_Copy4;
			Row3[2] = Match_Copy5;
			Row3[3] = Match_Copy6;
			Row3[4] = Match_Copy7;
			//row4
			Row4[0] = Match_Copy8;
			Row4[1] = Match_Copy9;
			Row4[2] = Match_Copy10;
			Row4[3] = Match_Copy11;
			Row4[4] = Match_Copy12;
			Row4[5] = Match_Copy13;
			Row4[6] = Match_Copy14;
			SetPlayerTurn();
			//end
		}

		//new removes the pegs from the selected row and disables all other buttons but enables end turn
		private void Button_Row1_Click(object sender, RoutedEventArgs e)
		{
			nim.removePegs(0);
			DisableButtons(0);
			if(index1 == 0)
			{
				Row1[0].Visibility = Visibility.Collapsed;
			}
		}
		private void Button_Row2_Click(object sender, RoutedEventArgs e)
		{
			nim.removePegs(1);
			DisableButtons(1);
			if(index2 >= 0)
			{
				Row2[index2].Visibility = Visibility.Collapsed;
				index2--;
			}
		}
		private void Button_Row3_Click(object sender, RoutedEventArgs e)
		{
			nim.removePegs(2);
			DisableButtons(2);
			if (index3 >= 0)
			{
				Row3[index3].Visibility = Visibility.Collapsed;
				index3--;
			}
		}

		private void Button_Row4_Click(object sender, RoutedEventArgs e)
		{
			nim.removePegs(3);
			DisableButtons(3);
			if (index4 >= 0)
			{
				Row4[index4].Visibility = Visibility.Collapsed;
				index4--;
			}
		}


		//new disables the buttons based on the row you select
		private void DisableButtons(int index)
		{
			switch (index)
			{
				case 0:
					Button_Row2.IsEnabled = false;
					Button_Row3.IsEnabled = false;
					Button_Row4.IsEnabled = false;
					Button_EndTurn.IsEnabled = true;
					break;
				case 1:
					Button_Row1.IsEnabled = false;
					Button_Row3.IsEnabled = false;
					Button_Row4.IsEnabled = false;
					Button_EndTurn.IsEnabled = true;
					break;
				case 2:
					Button_Row2.IsEnabled = false;
					Button_Row4.IsEnabled = false;
					Button_Row1.IsEnabled = false;
					Button_EndTurn.IsEnabled = true;
					break;
				case 3:
					Button_Row3.IsEnabled = false;
					Button_Row1.IsEnabled = false;
					Button_Row2.IsEnabled = false;
					Button_EndTurn.IsEnabled= true;
					break;
				default:
					Debug.Write("Buttons didn't disable");
					break;
			}
		}
		//new enables all buttons if the player hasn't picked all the matches in the row
		private void EnableButtons()
		{
			if(index1 == 0)
			{
				Button_Row1.IsEnabled=true;
			}
			else
			{
				Button_Row1.IsEnabled=false;
			}
			if(index2 >= 0)
			{
				Button_Row2.IsEnabled=true;
			}
			else
			{
				Button_Row2.IsEnabled=false;
			}
			if(index3 >= 0)
			{
				Button_Row3.IsEnabled=true;
			}
			else
			{
				Button_Row3.IsEnabled = false;
			}
			if (index4 >= 0)
			{
				Button_Row4.IsEnabled=true;
			}
			else
			{
				Button_Row4.IsEnabled = false;
			}
			Button_EndTurn.IsEnabled=false;
		}
		//mew switches player turn and checks if the game is over and closes the windo
		private void Button_EndTurn_Click(object sender, RoutedEventArgs e)
		{
			nim.switchPlayerTurn();
			SetPlayerTurn();
			EnableButtons();
			if(nim.isGameOver)
			{
				this.Close();
			}
		}

		//new sets the text to show the players turn
		public void SetPlayerTurn()
		{
			if(nim.isPlayerOneTurn)
			{
				Title_Player_Turn.Text = "Player 1";
			}
			else
			{
				Title_Player_Turn.Text = "Player 2";
			}
		}
		//end
	}
}