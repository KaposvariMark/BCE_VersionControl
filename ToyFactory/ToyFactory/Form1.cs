using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyFactory.Abstractions;
using ToyFactory.Entities;

namespace ToyFactory
{
    public partial class Form1 : Form
    {
        private List<Toy> _toys = new List<Toy>();

        private BallFactory _factory;
        public BallFactory IToyFactory
        {
            get { return _factory; }
            set { _factory = value; }
        }

        public Form1()
        {
            InitializeComponent();
            IToyFactory = new BallFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var ball = IToyFactory.CreateNew();
            _toys.Add(ball);
            ball.Left = -ball.Width;
            mainPanel.Controls.Add(ball);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var Toy in _toys)
            {
                Toy.MoveToy();
                if (Toy.Left > maxPosition)
                    maxPosition = Toy.Left;
            }

            if (maxPosition > 1000)
            {
                var oldestBall = _toys[0];
                mainPanel.Controls.Remove(oldestBall);
                _toys.Remove(oldestBall);
            }
        }
    }
}
