using System.Windows;
using System.Windows.Threading;

namespace csharp_net_forms_improved_racing_game
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer gameTimer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            MyCanvas.Focus();

            gameTimer.Tick += GameLoop;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
        }

        private void GameLoop(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
