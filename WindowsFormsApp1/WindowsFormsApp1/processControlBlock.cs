using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public enum State { WAITING, RUNNIG, BLOCKED };
    class processControlBlock
    {


       public string name { get; set; }
       public State state;
       public List<segment> segments;


       public processControlBlock (string name ,  State state ,  List< segment> segment )
        {

            this.name = name;
            this.state = state;
            this.segments = segment;
      
        }





    }
}
