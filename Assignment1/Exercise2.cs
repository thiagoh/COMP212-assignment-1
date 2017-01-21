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
    public partial class Exercise2 : Form {

        private BindingList<string> computerProgrammerAnalystCourses = new BindingList<string>();
        private BindingList<string> computerProgrammerCourses = new BindingList<string>();
        private BindingList<string> selectedCourses = new BindingList<string>();

        public Exercise2() {
            InitializeComponent();

            computerProgrammerAnalystCourses.Add("Word Processing");
            computerProgrammerAnalystCourses.Add("Advance Programming");
            computerProgrammerAnalystCourses.Add("Computer Fundamentals");
            computerProgrammerAnalystCourses.Add("Software Engineering");

            setDataSource();

            lstCourses.DataSource = selectedCourses;
        }

        private void setDataSource() {

            if (computerProgrammerAnalystRB.Checked) {
                availableCoursesCB.DataSource = computerProgrammerAnalystCourses;
            } else {
                availableCoursesCB.DataSource = computerProgrammerCourses;
            }
        }

        private void Form3_Load(object sender, EventArgs e) {

        }

        private void Exercise2_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
        }
    }


}
