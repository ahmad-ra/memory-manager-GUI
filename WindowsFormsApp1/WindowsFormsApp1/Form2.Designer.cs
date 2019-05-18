namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bestFit = new System.Windows.Forms.RadioButton();
            this.firstFit = new System.Windows.Forms.RadioButton();
            this.worstFit = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxAddProc = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DoneAddProc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addSegment = new System.Windows.Forms.Button();
            this.tableLayoutPanelSegments = new System.Windows.Forms.TableLayoutPanel();
            this.procName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxRemoveProc = new System.Windows.Forms.GroupBox();
            this.chooseDeleteProc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.removeProc = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.canvas1 = new WindowsFormsApp1.canvas();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxAddProc.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBoxRemoveProc.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.canvas1);
            this.splitContainer1.Size = new System.Drawing.Size(1822, 811);
            this.splitContainer1.SplitterDistance = 851;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxAddProc);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxRemoveProc);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(851, 811);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bestFit);
            this.groupBox1.Controls.Add(this.firstFit);
            this.groupBox1.Controls.Add(this.worstFit);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 205);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Allocation strategy";
            // 
            // bestFit
            // 
            this.bestFit.AutoSize = true;
            this.bestFit.Location = new System.Drawing.Point(520, 89);
            this.bestFit.Name = "bestFit";
            this.bestFit.Size = new System.Drawing.Size(89, 24);
            this.bestFit.TabIndex = 2;
            this.bestFit.Text = "Best Fit";
            this.bestFit.UseVisualStyleBackColor = true;
            this.bestFit.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // firstFit
            // 
            this.firstFit.AutoSize = true;
            this.firstFit.Checked = true;
            this.firstFit.Location = new System.Drawing.Point(22, 89);
            this.firstFit.Name = "firstFit";
            this.firstFit.Size = new System.Drawing.Size(83, 24);
            this.firstFit.TabIndex = 0;
            this.firstFit.TabStop = true;
            this.firstFit.Text = "FirstFit";
            this.firstFit.UseVisualStyleBackColor = true;
            this.firstFit.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // worstFit
            // 
            this.worstFit.AutoSize = true;
            this.worstFit.Location = new System.Drawing.Point(284, 89);
            this.worstFit.Name = "worstFit";
            this.worstFit.Size = new System.Drawing.Size(93, 24);
            this.worstFit.TabIndex = 1;
            this.worstFit.Text = "Worst fit";
            this.worstFit.UseVisualStyleBackColor = true;
            this.worstFit.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 221);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(777, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Process                                                                      " +
    "                    <";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxAddProc
            // 
            this.groupBoxAddProc.Controls.Add(this.label1);
            this.groupBoxAddProc.Controls.Add(this.DoneAddProc);
            this.groupBoxAddProc.Controls.Add(this.groupBox2);
            this.groupBoxAddProc.Controls.Add(this.procName);
            this.groupBoxAddProc.Location = new System.Drawing.Point(3, 279);
            this.groupBoxAddProc.Name = "groupBoxAddProc";
            this.groupBoxAddProc.Size = new System.Drawing.Size(776, 691);
            this.groupBoxAddProc.TabIndex = 4;
            this.groupBoxAddProc.TabStop = false;
            this.groupBoxAddProc.Text = "Add new process";
            this.groupBoxAddProc.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Process name";
            // 
            // DoneAddProc
            // 
            this.DoneAddProc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DoneAddProc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoneAddProc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DoneAddProc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DoneAddProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneAddProc.Location = new System.Drawing.Point(0, 574);
            this.DoneAddProc.Name = "DoneAddProc";
            this.DoneAddProc.Size = new System.Drawing.Size(776, 72);
            this.DoneAddProc.TabIndex = 10;
            this.DoneAddProc.Text = "Done";
            this.DoneAddProc.UseVisualStyleBackColor = false;
            this.DoneAddProc.Click += new System.EventHandler(this.DoneAddProc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Controls.Add(this.addSegment);
            this.groupBox2.Controls.Add(this.tableLayoutPanelSegments);
            this.groupBox2.Location = new System.Drawing.Point(6, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 434);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Segments :";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(8, 123);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(747, 48);
            this.flowLayoutPanel2.TabIndex = 14;
            this.flowLayoutPanel2.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(411, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "name";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(420, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "size in MB";
            // 
            // addSegment
            // 
            this.addSegment.Location = new System.Drawing.Point(14, 25);
            this.addSegment.Name = "addSegment";
            this.addSegment.Size = new System.Drawing.Size(330, 54);
            this.addSegment.TabIndex = 13;
            this.addSegment.Text = "+ Add Segment";
            this.addSegment.UseVisualStyleBackColor = true;
            this.addSegment.Click += new System.EventHandler(this.addSegment_Click);
            // 
            // tableLayoutPanelSegments
            // 
            this.tableLayoutPanelSegments.AutoScroll = true;
            this.tableLayoutPanelSegments.ColumnCount = 2;
            this.tableLayoutPanelSegments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.61044F));
            this.tableLayoutPanelSegments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.38956F));
            this.tableLayoutPanelSegments.Location = new System.Drawing.Point(6, 175);
            this.tableLayoutPanelSegments.Name = "tableLayoutPanelSegments";
            this.tableLayoutPanelSegments.RowCount = 2;
            this.tableLayoutPanelSegments.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelSegments.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelSegments.Size = new System.Drawing.Size(747, 258);
            this.tableLayoutPanelSegments.TabIndex = 8;
            // 
            // procName
            // 
            this.procName.Location = new System.Drawing.Point(374, 58);
            this.procName.Name = "procName";
            this.procName.Size = new System.Drawing.Size(288, 26);
            this.procName.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 983);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(777, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "Remove Process                                                                   " +
    "                    <";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxRemoveProc
            // 
            this.groupBoxRemoveProc.Controls.Add(this.chooseDeleteProc);
            this.groupBoxRemoveProc.Controls.Add(this.label2);
            this.groupBoxRemoveProc.Controls.Add(this.removeProc);
            this.groupBoxRemoveProc.Location = new System.Drawing.Point(3, 1041);
            this.groupBoxRemoveProc.Name = "groupBoxRemoveProc";
            this.groupBoxRemoveProc.Size = new System.Drawing.Size(776, 251);
            this.groupBoxRemoveProc.TabIndex = 6;
            this.groupBoxRemoveProc.TabStop = false;
            this.groupBoxRemoveProc.Text = "remove process";
            this.groupBoxRemoveProc.Visible = false;
            // 
            // chooseDeleteProc
            // 
            this.chooseDeleteProc.FormattingEnabled = true;
            this.chooseDeleteProc.Location = new System.Drawing.Point(374, 54);
            this.chooseDeleteProc.Name = "chooseDeleteProc";
            this.chooseDeleteProc.Size = new System.Drawing.Size(288, 28);
            this.chooseDeleteProc.TabIndex = 15;
            this.chooseDeleteProc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Process";
            // 
            // removeProc
            // 
            this.removeProc.BackColor = System.Drawing.Color.Red;
            this.removeProc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeProc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.removeProc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.removeProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeProc.Location = new System.Drawing.Point(-3, 102);
            this.removeProc.Name = "removeProc";
            this.removeProc.Size = new System.Drawing.Size(776, 72);
            this.removeProc.TabIndex = 10;
            this.removeProc.Text = "Remove";
            this.removeProc.UseVisualStyleBackColor = false;
            this.removeProc.Click += new System.EventHandler(this.removeProc_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(602, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 170);
            this.button3.TabIndex = 1;
            this.button3.Text = "COMPACT \r\nMEMORY";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // canvas1
            // 
            this.canvas1.AutoScroll = true;
            this.canvas1.AutoSize = true;
            this.canvas1.Location = new System.Drawing.Point(30, 46);
            this.canvas1.Margin = new System.Windows.Forms.Padding(2);
            this.canvas1.Name = "canvas1";
            this.canvas1.Size = new System.Drawing.Size(848, 3231);
            this.canvas1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 811);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxAddProc.ResumeLayout(false);
            this.groupBoxAddProc.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBoxRemoveProc.ResumeLayout(false);
            this.groupBoxRemoveProc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton bestFit;
        private System.Windows.Forms.RadioButton worstFit;
        private System.Windows.Forms.RadioButton firstFit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxAddProc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox procName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DoneAddProc;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addSegment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSegments;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBoxRemoveProc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeProc;
        private System.Windows.Forms.ComboBox chooseDeleteProc;
        private canvas canvas1;
        private System.Windows.Forms.Button button3;
    }
}