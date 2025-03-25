using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
     public class SundayTask
    {
        public SundayTask()
        {
            SundayTaskDescription = string.Empty;
        }

        public string SundayTaskDescription { get; set; }
        public bool SundayIsDone { get; set; }
    }
}
