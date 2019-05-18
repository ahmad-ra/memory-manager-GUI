using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class canvas : UserControl
    {
        public canvas()
        {
            InitializeComponent();
        }

        int counter = System.Drawing.Color.Aqua.ToArgb();

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            float scalingFactor = (float) (memory.size / 2000.0);



            System.Drawing.Pen pen = new Pen(System.Drawing.Color.Red);


            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Aqua);

 
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 8);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();

            foreach (var proc in memory.runningProcs)
            {
                foreach (var seg in proc.segments)
                {

                    if (seg.color == System.Drawing.Color.FromArgb(0))
                    {
                        seg.color = System.Drawing.Color.FromArgb(counter);
                    }
                    myBrush.Color = seg.color;

                    e.Graphics.FillRectangle(myBrush, new Rectangle(0,Convert.ToInt32( seg.Base / scalingFactor) , 200,  Convert.ToInt32(seg.limit / scalingFactor)  ));


                    e.Graphics.DrawString(seg.Base.ToString(), drawFont, drawBrush, 210, Convert.ToInt32(seg.Base  / ( scalingFactor)), drawFormat);

                    e.Graphics.DrawString( proc.name + " . " + seg.name, drawFont, drawBrush, 240, Convert.ToInt32((2* seg.Base + seg.limit) / (2*scalingFactor ) ) ,drawFormat);


                    e.Graphics.DrawString((seg.Base+seg.limit).ToString(), drawFont, drawBrush, 210, Convert.ToInt32( (seg.Base + seg.limit) / (scalingFactor)), drawFormat);


                    counter += 1000;
              
                }
            }

   
            myBrush.Color = System.Drawing.Color.FromArgb(0) ;

            foreach (var hole in memory.sortedHolesByStartAddress)
            {


                e.Graphics.FillRectangle(myBrush, new Rectangle(0, Convert.ToInt32(hole.Base / scalingFactor), 200, Convert.ToInt32(hole.limit / scalingFactor)));


                e.Graphics.DrawString(hole.Base.ToString(), drawFont, drawBrush, 210, Convert.ToInt32(hole.Base / (scalingFactor)), drawFormat);

                e.Graphics.DrawString(hole.name, drawFont, drawBrush, 240, Convert.ToInt32((2 * hole.Base + hole.limit) / (2 * scalingFactor)), drawFormat);


                e.Graphics.DrawString((hole.Base + hole.limit).ToString(), drawFont, drawBrush, 210, Convert.ToInt32((hole.Base + hole.limit) / (scalingFactor)), drawFormat);


            }


            //  e.Graphics.FillRectangle(myBrush, new Rectangle(0, 0, 200, 1000));

            e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, 200, 2000));

            pen.Dispose();
            drawFont.Dispose();
            drawBrush.Dispose();

            myBrush.Dispose();
            e.Dispose();



        }
    }
}
