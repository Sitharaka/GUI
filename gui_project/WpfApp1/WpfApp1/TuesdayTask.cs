using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class TuesdayTask
    {
        public TuesdayTask()
        {
            TuesdayTaskDescription = string.Empty;
        }

        public string TuesdayTaskDescription { get; set; }
        public bool TuesdayIsDone { get; set; }
    }
}
