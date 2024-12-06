using System.Diagnostics;
using System.Windows;

namespace Delta_Launcher;

public partial class Startup : Window
{
    public Startup()
    {
        InitializeComponent();
        
        // Path to the executable file you want to run
        string filePath = @"C:\Users\franco.jourdan\Downloads\JetBrains.Rider-2024.3.exe"; // Change this to the path of your .exe file

        try
        {
            // Start the executable file
            Process.Start(filePath);

            // Log success message to the console
            Console.WriteLine($"Successfully launched: {filePath}");
        }
        catch (Exception ex)
        {
            // If there's an error, log the error message
            Console.WriteLine($"Error launching file: {ex.Message}");
        }
    }
}