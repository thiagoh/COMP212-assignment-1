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

            var message = "Hi professor!";
            message += "\r\n\nTo check my work click in one of the three exercise buttons.";
            message += "\r\n\nThanks,";
            message += "\r\n\nThiago de Andrade Souza";
            message += "\r\nStudent n. #300886181";

            MessageBox.Show(message, "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
