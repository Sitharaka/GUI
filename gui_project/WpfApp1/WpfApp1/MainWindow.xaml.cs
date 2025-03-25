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

namespace WpfApp1;

public partial class MainWindow : Window
{
    private Tasks tasks;
    public MainWindow()
    {
        InitializeComponent();
        tasks = new Tasks();
        DataContext = tasks;
    }

    private void AddDialogBtn_onClick(object sender, RoutedEventArgs e)
    {
        AddTaskWindow addTaskWindow = new AddTaskWindow(this);
        addTaskWindow.ShowDialog();
    }
    private void RemoveDialogBtn_onClick(object sender, RoutedEventArgs e)
    {
        RemoveTaskWindow removeTaskWindow = new RemoveTaskWindow();
        removeTaskWindow.ShowDialog();
    }

    public void RecieveFromAddwindow(string input, string day)
    {
        if (day == "Monday")
        {
            MondayTask mondayTask = new MondayTask()
            {
                MondayTaskDescription = input
            };
            tasks.MondayTasks.Add(mondayTask);
        }

        if (day == "Tuesday")
        {
            TuesdayTask tuesdayTask = new TuesdayTask()
            {
                TuesdayTaskDescription = input
            };
            tasks.TuesdayTasks.Add(tuesdayTask);
        }

        if (day == "Wednesday")
        {
            WednesdayTask wednesdayTask = new WednesdayTask()
            {
                WednesdayTaskDescription = input
            };
            tasks.WednesdayTasks.Add(wednesdayTask);
        }

        if (day == "Thursday")
        {
            ThursdayTask thursdayTask = new ThursdayTask()
            {
                ThursdayTaskDescription = input
            };
            tasks.ThursdayTasks.Add(thursdayTask);
        }

        if (day == "Friday")
        {
            FridayTask fridayTask = new FridayTask()
            {
                FridayTaskDescription = input
            };
            tasks.FridayTasks.Add(fridayTask);
        }

        if (day == "Saturday")
        {
            SaturdayTask saturdayTask = new SaturdayTask()
            {
                SaturdayTaskDescription = input
            };
            tasks.SaturdayTasks.Add(saturdayTask);
        }

        if (day == "Sunday")
        {
            SundayTask sundayTask = new SundayTask()
            {
                SundayTaskDescription = input
            };
            tasks.SundayTasks.Add(sundayTask);
        }

    }

}