using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class MondayTask
    {
        public MondayTask()
        {
            MondayTaskDescription = string.Empty;
        }
            
        public string MondayTaskDescription { get; set; }
        public bool MondayIsDone { get; set; }

    }
}
