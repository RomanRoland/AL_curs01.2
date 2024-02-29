using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AF_curs01._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextReader load = new StreamReader(@"..\..\TextFile1.txt");
            string t;
            bool check = true;
            string line = load.ReadLine();
            listBox1.Items.Add(line);
            string[] numbers = line.Split(' ');
            int[] v = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                v[i] = int.Parse(numbers[i]);
            }
            t = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                t += v[i] + " ";
            }
            listBox1.Items.Add(t);
            do
            {
                check = true;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (v[i] < v[i + 1])
                    {
                        (v[i], v[i + 1]) = (v[i + 1], v[i]);
                        check = false;
                    }
                }
            }while (!check);
            t = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                t += v[i] + " ";
            }
            listBox1.Items.Add(t);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
