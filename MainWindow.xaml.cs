using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ADO__DZ1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
  {
      public MainWindow()
      {
          InitializeComponent();
      }
      // Задание 1
      //private void LaunchProcess_Click(object sender, RoutedEventArgs e)
      //{
      //    Process process = new Process();
      //    process.StartInfo.FileName = "notepad.exe";
      //    process.StartInfo.UseShellExecute = false;
      //    process.StartInfo.RedirectStandardOutput = true;

      //    process.Start();

      //    process.WaitForExit();

      //    int exitCode = process.ExitCode;

      //    Output.Text = $"Код завершения: {exitCode}";

      //        Задание 2
      //  private void LaunchProcess_Click(object sender, RoutedEventArgs e)
      //        {
      //            // Создаем процесс
      //            Process process = new Process();
      //            process.StartInfo.FileName = "notepad.exe";
      //            process.StartInfo.UseShellExecute = false;
      //            process.StartInfo.RedirectStandardOutput = true;
      //            process.Start();
      //            if (WaitForExit.IsChecked == true)
      //            {
      //                process.WaitForExit();
        //                int exitCode = process.ExitCode;
          //                Output.Text = $"Код завершения: {exitCode}";
      //            }
      //            else
      //            {
     
      //                process.Kill();
            //                Output.Text = "Процесс принудительно завершен";
      //            }
      //        }
      //    }
      //}
      //        Задание3
      //        private void LaunchProcess_Click(object sender, RoutedEventArgs e)
      //        {
      //            //  аргументы командной строки
      //            string number1 = Number1.Text;
      //            string number2 = Number2.Text;
      //            string operation = Operation.SelectedItem.ToString();

      //            // Создание
      //            Process process = new Process();
      //            process.StartInfo.FileName = "Calculator.exe";
      //            process.StartInfo.Arguments = $"{number1} {operation} {number2} + 10";
      //            process.StartInfo.UseShellExecute = false;
      //            process.StartInfo.RedirectStandardOutput = true;

      //            // Запуск
      //            process.Start();

      //            //  завершение
      //            process.WaitForExit();

      //            // Получение результата
      //            string output = process.StandardOutput.ReadToEnd();

      //            // Отображение результата
      //            Output.Text = $"Результат: {output}";
      //        }
      //    }
      //}

      //Задание 4 
      //     private void LaunchProcess_Click(object sender, RoutedEventArgs e)
      //{

      //    string filePath = FilePath.Text;
      //    string searchTerm = SearchTerm.Text;

      //     существует ли файл
      //    if (!File.Exists(filePath))
      //    {
      //        Output.Text = "Файл не существует";
      //        return;
      //    }

      //    Process process = new Process();
      //    process.StartInfo.FileName = "Find.exe";
      //    process.StartInfo.Arguments = $"/c \"findstr /s /i /n \"{searchTerm}\" \"{filePath}\"";
      //    process.StartInfo.UseShellExecute = false;
      //    process.StartInfo.RedirectStandardOutput = true;

      //    process.Start();

      //    process.WaitForExit();

      //    string output = process.StandardOutput.ReadToEnd();

      //    Output.Text = $"Вхождений: {output.Split('\n').Length - 1}";
      }
  }
