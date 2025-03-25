using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class FridayTask
    {
        public FridayTask()
        {
            FridayTaskDescription = string.Empty;
        }

        public string FridayTaskDescription { get; set; }
        public bool FridayIsDone { get; set; }
    }
}
