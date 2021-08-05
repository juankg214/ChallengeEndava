
namespace ChallengeEndava
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BoxFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BoxPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.BoxFirstPoint = new System.Windows.Forms.TextBox();
            this.NodesLabel = new System.Windows.Forms.Label();
            this.EdgesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxWeight1 = new System.Windows.Forms.TextBox();
            this.Weight2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BoxSecond = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Threads2 = new System.Windows.Forms.TextBox();
            this.Weight3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Box3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.BoxV = new System.Windows.Forms.TextBox();
            this.BoxU = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BoxFile);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.BoxPath);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(28, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 655);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BoxFile
            // 
            this.BoxFile.BackColor = System.Drawing.Color.LightGray;
            this.BoxFile.Location = new System.Drawing.Point(107, 120);
            this.BoxFile.Multiline = true;
            this.BoxFile.Name = "BoxFile";
            this.BoxFile.ReadOnly = true;
            this.BoxFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BoxFile.Size = new System.Drawing.Size(449, 280);
            this.BoxFile.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "No se ha detectado ningun archivo cargado anteriormente, por favor seleccionarlo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BoxPath
            // 
            this.BoxPath.Location = new System.Drawing.Point(130, 28);
            this.BoxPath.Name = "BoxPath";
            this.BoxPath.Size = new System.Drawing.Size(307, 20);
            this.BoxPath.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Path:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.BoxU);
            this.panel2.Controls.Add(this.BoxV);
            this.panel2.Controls.Add(this.Weight3);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.Box3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.Threads2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.Weight2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.BoxSecond);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.BoxWeight1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.EdgesLabel);
            this.panel2.Controls.Add(this.NodesLabel);
            this.panel2.Controls.Add(this.BoxFirstPoint);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-7, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 698);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Calculate a good route that passes through all rooms once";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(349, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Calculate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BoxFirstPoint
            // 
            this.BoxFirstPoint.Location = new System.Drawing.Point(92, 127);
            this.BoxFirstPoint.Multiline = true;
            this.BoxFirstPoint.Name = "BoxFirstPoint";
            this.BoxFirstPoint.ReadOnly = true;
            this.BoxFirstPoint.Size = new System.Drawing.Size(582, 46);
            this.BoxFirstPoint.TabIndex = 2;
            // 
            // NodesLabel
            // 
            this.NodesLabel.AutoSize = true;
            this.NodesLabel.Location = new System.Drawing.Point(41, 20);
            this.NodesLabel.Name = "NodesLabel";
            this.NodesLabel.Size = new System.Drawing.Size(44, 13);
            this.NodesLabel.TabIndex = 3;
            this.NodesLabel.Text = "Nodes :";
            // 
            // EdgesLabel
            // 
            this.EdgesLabel.AutoSize = true;
            this.EdgesLabel.Location = new System.Drawing.Point(41, 44);
            this.EdgesLabel.Name = "EdgesLabel";
            this.EdgesLabel.Size = new System.Drawing.Size(43, 13);
            this.EdgesLabel.TabIndex = 4;
            this.EdgesLabel.Text = "Edges: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Route";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Weight";
            // 
            // BoxWeight1
            // 
            this.BoxWeight1.Location = new System.Drawing.Point(92, 193);
            this.BoxWeight1.Name = "BoxWeight1";
            this.BoxWeight1.ReadOnly = true;
            this.BoxWeight1.Size = new System.Drawing.Size(80, 20);
            this.BoxWeight1.TabIndex = 7;
            // 
            // Weight2
            // 
            this.Weight2.Location = new System.Drawing.Point(92, 383);
            this.Weight2.Name = "Weight2";
            this.Weight2.ReadOnly = true;
            this.Weight2.Size = new System.Drawing.Size(80, 20);
            this.Weight2.TabIndex = 13;
            this.Weight2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Weight";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Route";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // BoxSecond
            // 
            this.BoxSecond.Location = new System.Drawing.Point(92, 317);
            this.BoxSecond.Multiline = true;
            this.BoxSecond.Name = "BoxSecond";
            this.BoxSecond.ReadOnly = true;
            this.BoxSecond.Size = new System.Drawing.Size(582, 46);
            this.BoxSecond.TabIndex = 10;
            this.BoxSecond.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(349, 426);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Calculate";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(336, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "2. Calculate a good route that passes through all rooms once (Parallel)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Threads";
            // 
            // Threads2
            // 
            this.Threads2.Location = new System.Drawing.Point(249, 382);
            this.Threads2.Name = "Threads2";
            this.Threads2.ReadOnly = true;
            this.Threads2.Size = new System.Drawing.Size(100, 20);
            this.Threads2.TabIndex = 15;
            // 
            // Weight3
            // 
            this.Weight3.Location = new System.Drawing.Point(85, 628);
            this.Weight3.Name = "Weight3";
            this.Weight3.ReadOnly = true;
            this.Weight3.Size = new System.Drawing.Size(80, 20);
            this.Weight3.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 631);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Weight";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 581);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Route";
            // 
            // Box3
            // 
            this.Box3.Location = new System.Drawing.Point(83, 562);
            this.Box3.Multiline = true;
            this.Box3.Name = "Box3";
            this.Box3.ReadOnly = true;
            this.Box3.Size = new System.Drawing.Size(582, 46);
            this.Box3.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(349, 672);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Calculate";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 452);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(218, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "3.Calculate a good route between two rooms";
            // 
            // BoxV
            // 
            this.BoxV.Location = new System.Drawing.Point(92, 524);
            this.BoxV.Name = "BoxV";
            this.BoxV.Size = new System.Drawing.Size(100, 20);
            this.BoxV.TabIndex = 22;
            // 
            // BoxU
            // 
            this.BoxU.Location = new System.Drawing.Point(92, 488);
            this.BoxU.Name = "BoxU";
            this.BoxU.Size = new System.Drawing.Size(100, 20);
            this.BoxU.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 491);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Room 1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 527);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Room 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 711);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BoxFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox BoxPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxFirstPoint;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label EdgesLabel;
        private System.Windows.Forms.Label NodesLabel;
        private System.Windows.Forms.TextBox BoxWeight1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Weight2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BoxSecond;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Threads2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox BoxU;
        private System.Windows.Forms.TextBox BoxV;
        private System.Windows.Forms.TextBox Weight3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Box3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
    }
}

