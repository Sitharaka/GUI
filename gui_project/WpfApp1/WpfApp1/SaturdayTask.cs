using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class SaturdayTask
    {
        public SaturdayTask()
        {
            SaturdayTaskDescription = string.Empty;
        }

        public string SaturdayTaskDescription { get; set; }
        public bool SaturdayIsDone { get; set; }
    }
}
