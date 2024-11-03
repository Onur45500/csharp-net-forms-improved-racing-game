using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
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
        bool moveLeft, moveRight, gameOver, powerMode;

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

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                moveLeft = true;
            }
            if (e.Key == Key.Right)
            {
                moveRight = true;
            }
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                moveLeft = false;
            }
            if (e.Key == Key.Right)
            {
                moveRight = false;
            }

            if (e.Key == Key.Enter && gameOver == true)
            {
                StartGame();
            }
        }


        private void StartGame()
        {
            speed = 8;
            gameTimer.Start();
        }
    }
}
