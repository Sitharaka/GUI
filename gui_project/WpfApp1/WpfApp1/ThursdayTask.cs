using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class ThursdayTask
    {
        public ThursdayTask()
        {
            ThursdayTaskDescription = string.Empty;
        }

        public string ThursdayTaskDescription { get; set; }
        public bool ThursdayIsDone { get; set; }
    }
}
