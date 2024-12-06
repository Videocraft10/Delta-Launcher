using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Diagnostics;

namespace Delta_Launcher
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

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Add this to enable window dragging

        private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Ensure left mouse button is pressed before calling DragMove
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                try
                {
                    this.DragMove();
                }
                catch (InvalidOperationException ex)
                {
                    // Optionally handle the exception (log, notify user, etc.)
                    System.Diagnostics.Debug.WriteLine($"DragMove error: {ex.Message}");
                }
            }
        }

        private void OpenGame_Click(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            this.WindowState = WindowState.Minimized;
            
            
            // Path to the executable file you want to run
            //string filePath = @"C:\Users\franco.jourdan\Downloads\JetBrains.Rider-2024.3.exe"; // Change this to the path of your .exe file

            //try
            {
                // Start the executable file
                //Process.Start(filePath);

                // Log success message to the console
                //Console.WriteLine($"Successfully launched: {filePath}");
            }
            //catch (Exception ex)
            {
                // If there's an error, log the error message
                //Console.WriteLine($"Error launching file: {ex.Message}");
            }
        }
    }
}