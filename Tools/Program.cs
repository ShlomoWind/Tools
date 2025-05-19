using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tool> ListToolBox = new List<Tool>();
            ListToolBox.Add(new Hammer(5));
            ListToolBox.Add(new Drill(1));
            ListToolBox.Add(new PipeCutter(2));
            foreach(Tool tool in ListToolBox)
            {
                tool.Describe();
            }
        }
    }
}
