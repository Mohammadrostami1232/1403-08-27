using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public abstract class vehicle
        {
            public abstract void Pedal();
        }
        public class Car : vehicle
        {
            public override void Pedal()
            {
                MessageBox.Show("the car acceleration");
            }
        }
        public class Bike : vehicle
        {
            public override void Pedal()
            {
                MessageBox.Show("push pedal");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            Bike bike = new Bike();
            car.Pedal();
            bike.Pedal();
        }
    }
}
