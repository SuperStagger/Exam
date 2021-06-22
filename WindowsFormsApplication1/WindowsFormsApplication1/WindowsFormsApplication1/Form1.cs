using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        public Form1()
        {
            PowerSteal[] steals = new PowerSteal[15]
            {
                new SquareSteal(rnd.Next(1, 10),rnd.NextDouble(),rnd.Next(5,10)),
                new SquareSteal(rnd.Next(1, 10),rnd.NextDouble(),rnd.Next(5,10)),
                new SquareSteal(rnd.Next(1, 10),rnd.NextDouble(),rnd.Next(5,10)),
                new SquareSteal(rnd.Next(1, 10),rnd.NextDouble(),rnd.Next(5,10)),
                new SquareSteal(rnd.Next(1, 10),rnd.NextDouble(),rnd.Next(5,10)),

                new RectangleSteal(rnd.Next(1, 10),rnd.NextDouble(),rnd.Next(5,10),rnd.Next(5,10)),
                new RectangleSteal(rnd.Next(1, 10),rnd.NextDouble(),rnd.Next(5,10),rnd.Next(5,10)),
                new RectangleSteal(rnd.Next(1, 10),rnd.NextDouble(),rnd.Next(5,10),rnd.Next(5,10)),
                new RectangleSteal(rnd.Next(1, 10),rnd.NextDouble(),rnd.Next(5,10),rnd.Next(5,10)),
                new RectangleSteal(rnd.Next(1, 10),rnd.NextDouble(),rnd.Next(5,10),rnd.Next(5,10)),
                new RectangleSteal(rnd.Next(1, 10),rnd.NextDouble(),rnd.Next(5,10),rnd.Next(5,10)),
                new RectangleSteal(rnd.Next(1, 10),rnd.NextDouble(),rnd.Next(5,10),rnd.Next(5,10)),
                
                new TriangleSteal(rnd.Next(1, 10),rnd.NextDouble(),rnd.Next(5,10),rnd.Next(5,10)),
                new TriangleSteal(rnd.Next(1, 10),rnd.NextDouble(),rnd.Next(5,10),rnd.Next(5,10)),
                new TriangleSteal(rnd.Next(1, 10),rnd.NextDouble(),rnd.Next(5,10),rnd.Next(5,10)),
            };
            InitializeComponent();
            double sumSquare = 0;
            double sumWeight = 0;

            for(int i=0;i<15;i++)
            {
                //textBox1.Text += steals[i].Information() + "\n";
                sumSquare += steals[i].Square();
                sumWeight += steals[i].Weight();
            }

            textBox1.Text += "\nПлоща: " + sumSquare + "\nВага: " + sumWeight;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
