using System.Windows;

namespace Chess_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Switches 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Human_Locally_Button_Click(object sender, RoutedEventArgs e)
        {
            ChessBoardWindow chessBoardWindow = new ChessBoardWindow();
            chessBoardWindow.Show();
            this.Close();
        }
    }
}
