using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1 {
    public partial class MainForm : Form {

        private Exercise1 exercise1;
        private Exercise2 exercise2;
        private Feedbackform exercise3;

        public MainForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (exercise1 == null) {
                exercise1 = new Exercise1();
            }
            exercise1.Show();
            exercise1.Focus();
        }

        private void button2_Click(object sender, EventArgs e) {
            if (exercise2 == null) {
                exercise2 = new Exercise2();
            }
            exercise2.Show();
            exercise2.Focus();
        }

        private void button3_Click(object sender, EventArgs e) {
            if (exercise3 == null) {
                exercise3 = new Feedbackform();
            }
            exercise3.Show();
            exercise3.Focus();
        }
    }
}
