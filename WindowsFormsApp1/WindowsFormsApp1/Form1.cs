using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        int ID;
        private System.Windows.Forms.TextBox startingAdd , size;

        public Form1()
        {
            ID = 0;
            InitializeComponent();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            if (totalSize.Text == "" || totalSize.Text =="0")
            {
                MessageBox.Show("total size cant be empty", "memory size");
                return;
            }

            algs.populateHole(tableLayoutPanel1 , (float)Convert.ToDouble(totalSize.Text)  );
            

          
            Form2 f2 = new Form2();
            f2.Show();
            this.Dispose(false);

            //tableLayoutPanel1.Controls.Clear();
            //foreach (var a in shared.getInstance().memory)
            //{
            //    Console.WriteLine(((process)a).segment[0].Key);
            //    Console.WriteLine("  ");
            //    Console.WriteLine(((process)a).segment[0].Value);
            //}
        }



        private void totalSize_TextChanged(object sender, EventArgs e)
        {

            float x;
            if (!float.TryParse(((TextBox)sender).Text, out x))
            {

                ((TextBox)sender).Focus();
                ((TextBox)sender).Text = "";
                errorProvider1.SetError(((TextBox)sender), "please enter a valid number");
                MessageBox.Show(((TextBox)sender), "please enter a valid number");
            }
            else
            {
                errorProvider1.SetError(((TextBox)sender), "");
            }

        }

        private void addHole_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Show();
            if (totalSize.Text =="")
            {
                MessageBox.Show( "total size cant be empty" , "memory size");
                return;
            }
            Label l1 = new Label() ;
            ID++;
            l1.Text = (ID).ToString();

            this.startingAdd = new TextBox();
            this.startingAdd.Location = new System.Drawing.Point(615, 153);
            this.startingAdd.Name = "totalSize";
            this.startingAdd.Size = new System.Drawing.Size(428, 26);
            this.startingAdd.TabIndex = 3;
            this.startingAdd.UseWaitCursor = true;
            this.startingAdd.TextChanged += new System.EventHandler(this.totalSize_TextChanged);


            this.size = new TextBox();
            this.size.Location = new System.Drawing.Point(615, 153);
            this.size.Name = "totalSize";
            this.size.Size = new System.Drawing.Size(428, 26);
            this.size.TabIndex = 3;
            this.size.UseWaitCursor = true;
            this.size.TextChanged += new System.EventHandler(this.totalSize_TextChanged);


            tableLayoutPanel1.Controls.Add(l1);
            tableLayoutPanel1.Controls.Add(startingAdd);
            tableLayoutPanel1.Controls.Add(size);


        }
    }
}
