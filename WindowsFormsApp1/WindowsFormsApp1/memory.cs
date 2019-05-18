using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WindowsFormsApp1
{
    enum fitType { FIRSTFIT , BESTFIT , WORSTFIT }
    class memory
    {
        public static fitType fit ;
        public static float size;

        public static LinkedList<segment> sortedHolesByStartAddress = new LinkedList<segment>();

        public static LinkedList<segment> sortedHolesBySize = new LinkedList<segment>();



        public static LinkedList<processControlBlock> runningProcs = new LinkedList<processControlBlock>();
        public static LinkedList<processControlBlock> runningProcsCopy = new LinkedList<processControlBlock>();


        public static LinkedList<processControlBlock> waitingProcs = new LinkedList<processControlBlock>();


        public memory(int size, LinkedList<segment> holes)
        {
            //this.size = size;
           // this.holes = holes;
        }
    }
}
