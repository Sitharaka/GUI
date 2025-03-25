using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class WednesdayTask
    {
        public WednesdayTask()
        {
            WednesdayTaskDescription = string.Empty;
        }

        public string WednesdayTaskDescription { get; set; }
        public bool WednesdayIsDone { get; set; }
    }
}
