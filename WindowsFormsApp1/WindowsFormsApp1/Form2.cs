using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
         

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            memory.fit = fitType.FIRSTFIT;
            comboBoxInit();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            if (groupBoxAddProc.Visible)
            {
                groupBoxAddProc.Hide();
                button1.Text = "Add Process                                                                                          <";
                return;
            }


            groupBoxAddProc.Show();
            button1.Text = "Add Process                                                                                          >";
        }

   
        private void addSegment_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Show();
            TextBox name , size ;
                    name = new TextBox();
                    name.Location = new System.Drawing.Point(615, 153);
                    name.Name = "totalSize";
                    name.Size = new System.Drawing.Size(428, 26);
                    name.TabIndex = 3;
                    name.UseWaitCursor = true;
                    name.TextChanged += new System.EventHandler(emptyTextBoxHandler);


                    size = new TextBox();
                    size.Location = new System.Drawing.Point(615, 153);
                    size.Name = "totalSize";
                    size.Size = new System.Drawing.Size(428, 26);
                    size.TabIndex = 3;
                    size.UseWaitCursor = true;
                    size.TextChanged += new System.EventHandler(algs.textBoxValidator);
            
            tableLayoutPanelSegments.Controls.Add(name);
            tableLayoutPanelSegments.Controls.Add(size);

        }

        private void emptyTextBoxHandler(object sender, EventArgs e)
        {
            if (  (( TextBox ) sender).Text == "")
            {
                MessageBox.Show("segment name can't be empty , and will be ignored", "Error" );
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (groupBoxRemoveProc.Visible)
            {
                groupBoxRemoveProc.Hide();
                button2.Text = "Remove Process                                                                                       <";
                return;
            }


            groupBoxRemoveProc.Show();
            button2.Text = "Remove Process                                                                                       >";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DoneAddProc_Click(object sender, EventArgs e)
        {

            if (procName.Text == "")
            {
                MessageBox.Show("process name cant be empty", "process name");
                return;
            }
            processControlBlock p1 = algs.populateProc(tableLayoutPanelSegments, procName.Text);

            if (p1 ==null )
            {
                MessageBox.Show( " process must have at least 1 segment" , " msh 7nhazar b2a ");
            }

            else
            {
               if( !algs.allocProc(p1) )
                {

                    MessageBox.Show(" process can't be allocated and is waiting", "Allocation error ");
                }

                procName.Clear();

                while (tableLayoutPanelSegments.Controls.Count > 0)
                {
                    tableLayoutPanelSegments.Controls[0].Dispose();
                }

                comboBoxInit();
                this.Refresh();

            }

        }

        private void removeProc_Click(object sender, EventArgs e)
        {

            algs.removeProc( (processControlBlock) chooseDeleteProc.SelectedItem);

            comboBoxInit();
            this.Refresh();
        }


        private void comboBoxInit()
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = memory.runningProcs;
            chooseDeleteProc.DataSource = bs;
            chooseDeleteProc.DisplayMember = "name";


            chooseDeleteProc.Enabled = true;
            removeProc.Enabled = true;
            if (memory.runningProcs.Count == 0)
            {
                chooseDeleteProc.SelectedIndex = -1;

                chooseDeleteProc.Enabled = false;
                removeProc.Enabled = false;
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (firstFit.Checked)
            {
                memory.fit = fitType.FIRSTFIT;

            }

            else if (bestFit.Checked)
            {
                memory.fit = fitType.BESTFIT;
            }

            else if (worstFit.Checked)
            {
                memory.fit = fitType.WORSTFIT;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            algs.compactMem();

            this.Refresh();
        }
    }
}
