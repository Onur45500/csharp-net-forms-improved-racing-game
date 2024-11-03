using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace csharp_net_forms_improved_racing_game
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer gameTimer = new DispatcherTimer();
        int speed = 15;

        public MainWindow()
        {
            InitializeComponent();

            MyCanvas.Focus();

            gameTimer.Tick += GameLoop;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);

            StartGame();
        }

        private void GameLoop(object? sender, EventArgs e)
        {
            foreach (var x in MyCanvas.Children.OfType<Rectangle>())
            {
                if ((string)x.Tag == "roadMark")
                {
                    Canvas.SetTop(x, Canvas.GetTop(x) + speed);

                    if (Canvas.GetTop(x) > 510)
                    {
                        Canvas.SetTop(x, -152);
                    }
                }
            }
        }

        private void OnKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {

        }

        private void OnKeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {

        }


        private void StartGame()
        {
            speed = 8;
            gameTimer.Start();
        }
    }
}
