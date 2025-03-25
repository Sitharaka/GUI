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

namespace WpfApp1
{
   
    public partial class AddTaskWindow : Window
    {
        private MainWindow _mainWindow;     
        private string SelectedDay = "";
        public AddTaskWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }
        private void Day_changed(object sender, SelectionChangedEventArgs e)
        {
            if (DaySelectionList.SelectedItem is ComboBoxItem selectedComboBoxItem)
            {
                SelectedDay = selectedComboBoxItem.Content?.ToString() ?? "";
            }
        }
        private void AddDialogAdd_onClick(object sender, RoutedEventArgs e)
        {
           string TaskInput = InputTask.Text;
            _mainWindow.RecieveFromAddwindow(TaskInput, SelectedDay);
            this.Close();       
        }
        private void AddDialogClose_onClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
