using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChallengeEndava
{
    public partial class Form1 : Form
    {
        GraphChallenge graph { get; set; }
        public Form1()
        {
            InitializeComponent();

            if (FileManager.FileExists())
            {
                LoadData(FileManager.GetData());
            }
            
        }


    

        private void LoadData(string decoded)
        {
            string[] s = decoded.Split('\n');
            int V = FileManager.GetNumberOfNodes(s);
            List<Edge> Edges = FileManager.GetEdges(s, V);
            graph = new GraphChallenge(Edges, V);
            panel1.Hide();
            panel2.Show();
            NodesLabel.Text += V; 
            EdgesLabel.Text += Edges.Count; 
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Browse",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BoxPath.Text = openFileDialog1.FileName;
                FileManager.GetStringData(BoxPath.Text);
                string decoded = FileManager.GetData();
                BoxFile.Text = decoded;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData(FileManager.GetData());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a, b;
            (a,b) = graph.PrimerPunto();
            BoxFirstPoint.Text = a;
            BoxWeight1.Text = b;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a, b, c;
            (a, b, c) = graph.PrimerPuntoParalelo();
            BoxSecond.Text = a;
            Weight2.Text = b;
            Threads2.Text = c;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string a, b;
            (a, b) = graph.SegundoPunto(Int32.Parse(BoxU.Text)-1, Int32.Parse(BoxV.Text)-1);
            Box3.Text = a;
            Weight3.Text = b;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
