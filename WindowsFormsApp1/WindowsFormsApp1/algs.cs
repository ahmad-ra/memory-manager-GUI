using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class algs
    {

        //public static void populateHole ( TableLayoutPanel holesForm , int totalSize)
        //{
           
        //    int i1;
        //    processControlBlock p1;
        //    List<segment> seg;


        //    memory.size = totalSize;
        //    for (int i = 0; i < holesForm.Controls.Count; i+=3)
        //    {
        //        if (holesForm.Controls[i].Text != "" && holesForm.Controls[i + 2].Text != "")
        //        {
        //            seg = new List<segment> ();
        //            seg.Add(new segment("HOLE", (float) Convert.ToDouble(holesForm.Controls[i + 2].Text), (float) Convert.ToDouble(holesForm.Controls[i + 1].Text)));

        //            p1 = new processControlBlock("HOLE", State.RUNNIG, seg)  ;




        //            memory.holes.AddLast(seg[0]);
                    












        //           // s1 = "A"; // holesForm.Controls[i].Text;


        //             i1 = (float) Convert.ToDouble(holesForm.Controls[i+2].Text);

        //            KeyValuePair<String, int>[] k1 = new KeyValuePair<String, int>[1];
        //            k1[0] = new KeyValuePair<String, int>(s1, i1);

        //            //process p1 = new process(true, k1);
                    
        //            //shared.getInstance().holes.Add(p1);
        //            //shared.getInstance().memory.AddLast(p1);
        //            char c1 = s1[0];
        //            c1++;
        //            s1 =  c1.ToString();

        //        }
        //    }

            
      

        //}


        public static void textBoxValidator(object sender, EventArgs e)
        {
            float x;
            if (!float.TryParse(((TextBox)sender).Text, out x))
            {

                ((TextBox)sender).Focus();
                ((TextBox)sender).Text = "";
              
                MessageBox.Show(((TextBox)sender), "please enter a valid number");
            }
     



        }




        public static void populateHole(TableLayoutPanel holesForm, float totalSize)
        {
            
         

            
            memory.size = totalSize;

            //creating holes
            segment hole;
            for (int i = 0; i < holesForm.Controls.Count; i += 3)
            {
              
                if (holesForm.Controls[i+1].Text != "" && holesForm.Controls[i + 2].Text != "" )
                {

                    float holeStart = (float) Convert.ToDouble(holesForm.Controls[i + 1].Text);
                    float holeEnd = (float) Convert.ToDouble(holesForm.Controls[i + 1].Text) + (float) Convert.ToDouble(holesForm.Controls[i + 2].Text);
                    float holeSize = (float)Convert.ToDouble(holesForm.Controls[i + 2].Text);
                    if (holeStart >= memory.size || holeEnd > memory.size || holeSize ==0)
                    {
                        continue;
                    }

                    hole = new segment("HOLE", (float) Convert.ToDouble(holesForm.Controls[i + 2].Text), (float) Convert.ToDouble(holesForm.Controls[i + 1].Text)   );

                    memory.sortedHolesByStartAddress.AddLast(hole);
                }
            }


            memory.sortedHolesByStartAddress = new LinkedList<segment>(memory.sortedHolesByStartAddress.OrderBy(h => h.Base).ToList<segment>());


            memory.sortedHolesBySize = new LinkedList<segment>(memory.sortedHolesByStartAddress.OrderBy(h => h.limit).ToList<segment>());

            ////////////////////////creating processes between holes ////////////

            float startProc = 0 , sizeProc ;
            int counter =0;
            List<segment> procSeg;

            processControlBlock p1;
            ////if no holes ////////////
            if (memory.sortedHolesByStartAddress.Count ==0)
            {

                procSeg = new List<segment>();
                procSeg.Add(new segment(("OLD" + counter), memory.size , 0));

                p1 = new processControlBlock(("OLD" + counter), State.RUNNIG, procSeg);

                memory.runningProcs.AddLast(p1);


                return;


            }

            ///////////////////////////////////////////
            ///

            if (memory.sortedHolesByStartAddress.ElementAt(0).Base !=0 )
            {
                procSeg = new List<segment>();
                procSeg.Add(new segment ( ("OLD"+counter) , memory.sortedHolesByStartAddress.ElementAt(0).Base.Value  , 0)  );

                p1 = new processControlBlock( ("OLD" + counter) , State.RUNNIG, procSeg );

                memory.runningProcs.AddLast(p1);

                counter++;
            

            }



            ///////////loop between holes///////
         
            for (int i = 0; i < memory.sortedHolesByStartAddress.Count ; i++)
            {
                hole = memory.sortedHolesByStartAddress.ElementAt(i) ;
                startProc = hole.Base.Value + hole.limit ;
           
            
                if( i == memory.sortedHolesByStartAddress.Count -1)
                {
                    sizeProc = memory.size - startProc;

                    if (sizeProc ==0 )
                    {
                        continue;
                    }
                }
                else
                {
                    sizeProc = memory.sortedHolesByStartAddress.ElementAt(i + 1).Base.Value - startProc;
                }


         
                if (sizeProc <= 0)
                {
                   
                    memory.sortedHolesByStartAddress.Find( memory.sortedHolesByStartAddress.ElementAt(i)  ).Value = memory.sortedHolesByStartAddress.ElementAt(i) + memory.sortedHolesByStartAddress.ElementAt(i + 1);

                    memory.sortedHolesByStartAddress.Remove(memory.sortedHolesByStartAddress.ElementAt(i + 1));

                    i--;

                    continue;
                }

                procSeg = new List<segment>() ;
                procSeg.Add(new segment(("OLD" + counter), sizeProc, startProc));
                p1 = new processControlBlock(("OLD" + counter), State.RUNNIG, procSeg);

                counter++;



                memory.runningProcs.AddLast(p1);


                ///update size sorted holes because starting address sorted holes were merged
                ///
                memory.sortedHolesBySize = new LinkedList<segment>(memory.sortedHolesByStartAddress.OrderBy(h => h.limit).ToList<segment>());

                ///




            }



        }


        public static processControlBlock populateProc   (TableLayoutPanel segmentsForm, string name)
        {
          

           List<segment> seg = new List<segment>();
            for (int i = 0; i<segmentsForm.Controls.Count; i += 2)
            {
                if (segmentsForm.Controls[i].Text != "" && segmentsForm.Controls[i + 1].Text != "" && segmentsForm.Controls[i + 1].Text != "0")
                {

                    seg.Add(  new segment(segmentsForm.Controls[i].Text , (float) Convert.ToDouble(segmentsForm.Controls[i + 1].Text) )  );


                
                }
             }

        processControlBlock p1 = new processControlBlock(name, State.WAITING, seg);
            return p1.segments.Count ==0 ? null : p1;

        }





        public static bool allocProcFirstFit ( processControlBlock p1)
        {
            bool noHoleAvailabe = true;

            foreach (var segment in p1.segments)
            {
                noHoleAvailabe = true;

                for (int i = 0; i < memory.sortedHolesByStartAddress.Count ; i++)
                {
                    segment hole = memory.sortedHolesByStartAddress.ElementAt(i);

                    if (hole.limit > segment.limit )
                    {
                        noHoleAvailabe = false;

                        segment.Base = hole.Base;

                        segment newHole = new segment("HOLE", hole.limit - segment.limit, segment.Base + segment.limit) ;

                        memory.sortedHolesByStartAddress.Find(hole).Value = newHole;

                        memory.sortedHolesBySize = new LinkedList<segment>(memory.sortedHolesByStartAddress.OrderBy(h => h.limit).ToList<segment>());

                        break;

                    }

                    else if (hole.limit == segment.limit)
                    {

                        noHoleAvailabe = false;

                        segment.Base = hole.Base;

                        memory.sortedHolesByStartAddress.Remove(hole);

                        memory.sortedHolesBySize.Remove(hole);

                        break;

                    }


                }


                if (noHoleAvailabe)
                {
                    //  List < segment > segs2 = new List<segment>(p1.segments) ;
                    //processControlBlock p2 = new processControlBlock(p1.name, State.WAITING, segs2);

                    removePartiallyLoadedProc(p1);

                    foreach (var seg in p1.segments)
                    {
                        seg.Base = null;
                        
                    }

                
                    memory.waitingProcs.AddLast(p1);

                   
                    return false;

                }


              
            }


            p1.state = State.RUNNIG;
            memory.runningProcs.AddFirst(p1);

            return true;

        }


        public static bool allocProcBestFit(processControlBlock p1)
        {
            bool noHoleAvailabe = true;

            foreach (var segment in p1.segments)
            {
                noHoleAvailabe = true;

                for (int i = 0; i < memory.sortedHolesBySize.Count; i++)
                {
                    segment hole = memory.sortedHolesBySize.ElementAt(i);
                    
                    if (hole.limit > segment.limit)
                    {
                        noHoleAvailabe = false;

                        segment.Base = hole.Base;

                        segment newHole = new segment("HOLE", hole.limit - segment.limit, segment.Base + segment.limit);

                        //segment hh = memory.sortedHolesByStartAddress.Find(hole).Value;

                        memory.sortedHolesByStartAddress.Find(hole).Value = newHole;

                        memory.sortedHolesBySize = new LinkedList<segment>(memory.sortedHolesByStartAddress.OrderBy(h => h.limit).ToList<segment>());

                        break;

                    }

                    else if (hole.limit == segment.limit)
                    {

                        noHoleAvailabe = false;

                        segment.Base = hole.Base;

                        memory.sortedHolesByStartAddress.Remove(hole);

                        memory.sortedHolesBySize.Remove(hole);

                        break;

                    }


                }


                if (noHoleAvailabe)
                {
                    //  List < segment > segs2 = new List<segment>(p1.segments) ;
                    //processControlBlock p2 = new processControlBlock(p1.name, State.WAITING, segs2);

                    removePartiallyLoadedProc(p1);

                    foreach (var seg in p1.segments)
                    {
                        seg.Base = null;

                    }


                    memory.waitingProcs.AddLast(p1);


                    return false;

                }



            }


            p1.state = State.RUNNIG;
            memory.runningProcs.AddFirst(p1);

            return true;

        }


        public static bool allocProcWorstFit(processControlBlock p1)
        {
            bool noHoleAvailabe = true;

            foreach (var segment in p1.segments)
            {
                noHoleAvailabe = true;

                for (int i = memory.sortedHolesBySize.Count -1; i >= 0; i--)
                {
                    segment hole = memory.sortedHolesBySize.ElementAt(i);

                    if (hole.limit > segment.limit)
                    {
                        noHoleAvailabe = false;

                        segment.Base = hole.Base;

                        segment newHole = new segment("HOLE", hole.limit - segment.limit, segment.Base + segment.limit);

                        memory.sortedHolesByStartAddress.Find(hole).Value = newHole;

                        memory.sortedHolesBySize = new LinkedList<segment>(memory.sortedHolesByStartAddress.OrderBy(h => h.limit).ToList<segment>());

                        break;

                    }

                    else if (hole.limit == segment.limit)
                    {

                        noHoleAvailabe = false;

                        segment.Base = hole.Base;

                        memory.sortedHolesByStartAddress.Remove(hole);

                        memory.sortedHolesBySize.Remove(hole);

                        break;

                    }


                }


                if (noHoleAvailabe)
                {
                    //  List < segment > segs2 = new List<segment>(p1.segments) ;
                    //processControlBlock p2 = new processControlBlock(p1.name, State.WAITING, segs2);

                    removePartiallyLoadedProc(p1);

                    foreach (var seg in p1.segments)
                    {
                        seg.Base = null;

                    }


                    memory.waitingProcs.AddLast(p1);


                    return false;

                }



            }


            p1.state = State.RUNNIG;
            memory.runningProcs.AddFirst(p1);

            return true;

        }



        public static bool allocProc ( processControlBlock p1)
        {
            switch (memory.fit)
            {
                case (fitType.BESTFIT):
                    {
                        return allocProcBestFit(p1);
                        break;
                    }
                case (fitType.FIRSTFIT):
                    {
                        return allocProcFirstFit(p1);
                        break;
                    }
                case (fitType.WORSTFIT):
                    {
                        return allocProcWorstFit(p1);
                        break;
                    }

                default:
                    return false;

            }

        }



        public static void removeProc ( processControlBlock p1)
        {

            foreach (var seg in p1.segments)
            {
                if (seg.Base != null)
                {
                   
                    seg.name = "HOLE";

                    memory.sortedHolesByStartAddress.AddFirst(seg);
                }


            }


       
            memory.sortedHolesByStartAddress = new LinkedList<segment>(memory.sortedHolesByStartAddress.OrderBy(h => h.Base).ToList<segment>());


            memory.sortedHolesBySize = new LinkedList<segment>(memory.sortedHolesByStartAddress.OrderBy(h => h.limit).ToList<segment>());

            mergeHoles();

            memory.runningProcs.Remove(p1);

            int waitingCount = memory.waitingProcs.Count;
            for (int i = 0; i < waitingCount ; i++)
            {

                processControlBlock p2 = memory.waitingProcs.First.Value;

              memory.waitingProcs.RemoveFirst();

                allocProc(p2);

                
            }
     

        }

        public static void removePartiallyLoadedProc(processControlBlock p1)
        {

            foreach (var seg in p1.segments)
            {
                if (seg.Base != null)
                {

                    seg.name = "HOLE";

                    memory.sortedHolesByStartAddress.AddFirst(seg);
                }


            }



            memory.sortedHolesByStartAddress = new LinkedList<segment>(memory.sortedHolesByStartAddress.OrderBy(h => h.Base).ToList<segment>());


            memory.sortedHolesBySize = new LinkedList<segment>(memory.sortedHolesByStartAddress.OrderBy(h => h.limit).ToList<segment>());

            mergeHoles();

            memory.runningProcs.Remove(p1);




        }

        public static void mergeHoles ()
        {

            for (int i = 0; i < memory.sortedHolesByStartAddress.Count-1; i++)
            {
                segment hole = memory.sortedHolesByStartAddress.ElementAt(i);

                segment nextHole = memory.sortedHolesByStartAddress.ElementAt(i+1);
                if ( nextHole.Base == (hole.Base +hole.limit) )
                {
                    memory.sortedHolesByStartAddress.Find(hole).Value = hole + nextHole;

                    memory.sortedHolesByStartAddress.Remove(nextHole);

                    i--;
                }
            }

            memory.sortedHolesBySize = new LinkedList<segment>(memory.sortedHolesByStartAddress.OrderBy(h => h.limit).ToList<segment>());



        }




        public static void compactMem ()
        {

            segment hole = new segment("HOLE", memory.size, 0);
            memory.sortedHolesByStartAddress.Clear();

            memory.sortedHolesByStartAddress.AddFirst(hole);


            memory.sortedHolesBySize.Clear();

            memory.sortedHolesBySize.AddFirst(hole);


            LinkedList<processControlBlock> temp = memory.runningProcs;

            int runnningCount = memory.runningProcs.Count;
            for (int i = 0; i < runnningCount ; i++)
            {
                processControlBlock proc = memory.runningProcs.Last.Value ;

                memory.runningProcs.RemoveLast() ;

                allocProc(proc);

            }

            int waitingCount = memory.waitingProcs.Count;
            for (int i = 0; i < waitingCount ; i++)
            {
                processControlBlock proc = memory.waitingProcs.First.Value;

                memory.waitingProcs.RemoveFirst();

              
                allocProc(proc);

            }



        }







    }
            }
