using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        static Form1 _obj;
        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void headerPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point newPoint = PointToScreen(e.Location);
                Location = new Point(newPoint.X - startPoint.X, newPoint.Y - startPoint.Y);
            }
        }

        public static Form1 Instance
        {
            get 
            {
                if(_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Panel ContentPanel
        {
            get { return contentPanel; }
            set { contentPanel = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;

            
        }
    }
}
