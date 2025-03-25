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
    /// <summary>
    /// Interaction logic for RemoveTaskWindow.xaml
    /// </summary>
    public partial class RemoveTaskWindow : Window
    {
        public RemoveTaskWindow()
        {
            InitializeComponent();
        }
        private void RemoveDialogClose_onClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
