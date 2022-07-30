using System;
using System.Diagnostics;
using System.Windows;

namespace BowlingApp.Views
{
    /// <summary>Interaction logic for MainWindow.xaml</summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // batファイルを実行
            // Process.Start($"{Environment.CurrentDirectory}\\practice.bat");
        }
    }
}