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
    public partial class Feedbackform : Form {
        public Feedbackform() {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e) {

            foreach (var item in Controls) {

                if (item is CheckBox) {
                    (item as CheckBox).Checked = false;

                } else if (item is TextBox) {
                    (item as TextBox).Text = "";

                } else if (item is ComboBox) {
                    (item as ComboBox).SelectedIndex = 0;

                } else if (item is RadioButton) {
                    (item as RadioButton).Checked = false;
                }
            }
        }
    }
}
