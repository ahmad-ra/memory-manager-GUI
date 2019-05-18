using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;

namespace WindowsFormsApp1
{
    class shared
    {
        private static shared singleton = null;

        shared()
        {

        }

    public  static shared getInstance ()
        {
            if (singleton == null)
            {
                singleton = new shared();
              //  singleton.memory = new LinkedList<process> ();
               // singleton.holes = new List<process>() ;
                return singleton;
            }
            return singleton;

        }


      // public List <process> holes;
       //public LinkedList<process> memory;

      


    }
}
