using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfKeyboardMovement
{
    public partial class MainWindow : Window
    {
        private double playerX = 0;
        private double playerY = 0;

        public MainWindow()
        {
            InitializeComponent();
            Canvas.SetLeft(player, playerX);
            Canvas.SetTop(player, playerY);

            PreviewKeyDown += MainWindow_PreviewKeyDown;
            PreviewKeyUp += MainWindow_PreviewKeyUp;
        }

        private void MainWindow_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.W: // W - do góry
                    playerY -= 5;
                    break;
                case Key.S: // S - w dół
                    playerY += 5;
                    break;
                case Key.A: // A - w lewo
                    playerX -= 5;
                    break;
                case Key.D: // D - w prawo
                    playerX += 5;
                    break;
            }

            Canvas.SetLeft(player, playerX);
            Canvas.SetTop(player, playerY);
        }

        private void MainWindow_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            // Obsługuje zwolnienie klawisza (jeśli potrzebne)
            // Tutaj możesz dodać odpowiednie działania, np. zatrzymanie ruchu gracza.
        }
    }
}
