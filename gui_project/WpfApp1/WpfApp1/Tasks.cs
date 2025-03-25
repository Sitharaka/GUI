using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WpfApp1.Tasks;

namespace WpfApp1
{
    public class Tasks : INotifyPropertyChanged
    {
        public Tasks()
        {
            _mondayTasks = new ObservableCollection<MondayTask>()
            {
                new MondayTask() {MondayTaskDescription = "Throw the trash."},
                new MondayTask() {MondayTaskDescription = "Wash clothes."},
                new MondayTask() {MondayTaskDescription = "Read books."}
            };

            _tuesdayTasks = new ObservableCollection<TuesdayTask>()
            {
                new TuesdayTask() {TuesdayTaskDescription = "Clean house."},
                new TuesdayTask() {TuesdayTaskDescription = "Play cricket."},
                new TuesdayTask() {TuesdayTaskDescription = "Watch tv."}
            };

            _wednesdayTasks = new ObservableCollection<WednesdayTask>()
            {
                new WednesdayTask() {WednesdayTaskDescription = "Eat bread."},
                new WednesdayTask() {WednesdayTaskDescription = "Pay bill."},
                new WednesdayTask() {WednesdayTaskDescription = "Read comics."}
            };

            _thursdayTasks = new ObservableCollection<ThursdayTask>()
            {
                new ThursdayTask() {ThursdayTaskDescription = "Jump."},
                new ThursdayTask() {ThursdayTaskDescription = "Sleep."},
                new ThursdayTask() {ThursdayTaskDescription = "Cry."}
            };

            _fridayTasks = new ObservableCollection<FridayTask>()
            {
                new FridayTask() {FridayTaskDescription = "Fry fish."},
                new FridayTask() {FridayTaskDescription = "Walk the dog."},
                new FridayTask() {FridayTaskDescription = "Laugh."}
            };

            _saturdayTasks = new ObservableCollection<SaturdayTask>()
            {
                new SaturdayTask() {SaturdayTaskDescription = "Read letters."},
                new SaturdayTask() {SaturdayTaskDescription = "Feed the cat."},
                new SaturdayTask() {SaturdayTaskDescription = "Do exercise."}
            };

            _sundayTasks = new ObservableCollection<SundayTask>()
            {
                new SundayTask() {SundayTaskDescription = "Clean the garden."},
                new SundayTask() {SundayTaskDescription = "Do the dishes."},
                new SundayTask() {SundayTaskDescription = "Clap."},
                new SundayTask() {SundayTaskDescription = "Watch movies."}
            };


        }
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }




        private ObservableCollection<MondayTask> _mondayTasks;
        public ObservableCollection<MondayTask> MondayTasks
        {
            get { return _mondayTasks; }
            set
            {
                _mondayTasks = value;
                OnPropertyChanged(nameof(MondayTasks));
            }
        }

        private ObservableCollection<TuesdayTask> _tuesdayTasks;
        public ObservableCollection<TuesdayTask> TuesdayTasks
        {
            get { return _tuesdayTasks; }
            set
            {
                _tuesdayTasks = value;
                OnPropertyChanged(nameof(TuesdayTasks));
            }
        }

        private ObservableCollection<WednesdayTask> _wednesdayTasks;
        public ObservableCollection<WednesdayTask> WednesdayTasks
        {
            get { return _wednesdayTasks; }
            set
            {
                _wednesdayTasks = value;
                OnPropertyChanged(nameof(WednesdayTasks));
            }
        }

        private ObservableCollection<ThursdayTask> _thursdayTasks;
        public ObservableCollection<ThursdayTask> ThursdayTasks
        {
            get { return _thursdayTasks; }
            set
            {
                _thursdayTasks = value;
                OnPropertyChanged(nameof(ThursdayTasks));
            }
        }

        private ObservableCollection<FridayTask> _fridayTasks;
        public ObservableCollection<FridayTask> FridayTasks
        {
            get { return _fridayTasks; }
            set
            {
                _fridayTasks = value;
                OnPropertyChanged(nameof(FridayTasks));
            }
        }

        private ObservableCollection<SaturdayTask> _saturdayTasks;
        public ObservableCollection<SaturdayTask> SaturdayTasks
        {
            get { return _saturdayTasks; }
            set
            {
                _saturdayTasks = value;
                OnPropertyChanged(nameof(SaturdayTasks));
            }
        }

        private ObservableCollection<SundayTask> _sundayTasks;
        public ObservableCollection<SundayTask> SundayTasks
        {
            get { return _sundayTasks; }
            set
            {
                _sundayTasks = value;
                OnPropertyChanged(nameof(SundayTasks));
            }
        }
    }
}
