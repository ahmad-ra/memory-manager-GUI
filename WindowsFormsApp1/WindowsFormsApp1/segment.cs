using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    class segment
    {

        public System.Drawing.Color color;
        public string name;
        public float limit;
        public float? Base;

        public segment(string name, float limit, float? Base = null)
        {
            this.name = name;
            this.limit = limit;
            this.Base = Base;
            color = System.Drawing.Color.FromArgb(0);
        }


        public static segment operator+ (segment a ,segment b) {

            float newLimit;
            float newBase;

            if( a.Base <= b.Base) {

                newLimit = Math.Abs( b.Base.Value + b.limit - a.Base.Value );
                newBase = a.Base.Value;
                 }

            else
            {
                newLimit = a.Base.Value + a.limit - b.Base.Value;
                newBase = b.Base.Value;
            }

            return new segment(a.name, newLimit , newBase);
        }

    }
}
