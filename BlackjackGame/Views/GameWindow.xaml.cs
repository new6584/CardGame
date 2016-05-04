using BlackjackGame.ViewModels;
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

namespace BlackjackGame.Views
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        public string PlayerName { get; set; }
        public GameBoardViewModel GameBoardVM { get; set; }
        public int Card_width = 113;
        public int Card_height = 157;
        public GameWindow()
        {
            InitializeComponent();
        }
        public GameWindow(string playerName)
        {
            PlayerName = playerName;
            GameBoardVM = new GameBoardViewModel(this);
            InitializeComponent();         
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //draw a card
        }
        public void addToPlayerField(string url)
        {
            //add images to player
        }
        public void addToDealerField(string url)
        {
            //add images to dealer
        }
    }
}
