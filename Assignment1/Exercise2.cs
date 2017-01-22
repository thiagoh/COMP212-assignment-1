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

        private static string COMPUTER_PROGRAMMER_ANALYST = "Computer Programmer Analyst";
        private static string COMPUTER_PROGRAMMER = "Computer Programmer";

        private BindingList<Course> computerProgrammerAnalystCourses = new BindingList<Course>();
        private BindingList<Course> computerProgrammerCourses = new BindingList<Course>();
        private BindingList<Course> selectedCourses = new BindingList<Course>();
        private BindingList<Student> students = new BindingList<Student>();

        public Exercise2() {
            InitializeComponent();

            lastChecked = computerProgrammerAnalystRB;

            resetCourseAvailableLists();
            setDataSource();
        }

        private void resetCourseAvailableLists() {

            computerProgrammerAnalystCourses.Clear();
            computerProgrammerCourses.Clear();
            selectedCourses.Clear();

            computerProgrammerAnalystCourses.Add(new Course(COMPUTER_PROGRAMMER_ANALYST, ""));
            computerProgrammerAnalystCourses.Add(new Course(COMPUTER_PROGRAMMER_ANALYST, "Word Processing"));
            computerProgrammerAnalystCourses.Add(new Course(COMPUTER_PROGRAMMER_ANALYST, "Advance Programming"));
            computerProgrammerAnalystCourses.Add(new Course(COMPUTER_PROGRAMMER_ANALYST, "Computer Fundamentals"));
            computerProgrammerAnalystCourses.Add(new Course(COMPUTER_PROGRAMMER_ANALYST, "Software Engineering"));

            computerProgrammerCourses.Add(new Course(COMPUTER_PROGRAMMER, ""));
            computerProgrammerCourses.Add(new Course(COMPUTER_PROGRAMMER, "CSharp"));
            computerProgrammerCourses.Add(new Course(COMPUTER_PROGRAMMER, "Java"));
            computerProgrammerCourses.Add(new Course(COMPUTER_PROGRAMMER, "PHP"));
            computerProgrammerCourses.Add(new Course(COMPUTER_PROGRAMMER, "HTML5"));
        }

        private void setDataSource() {

            if (computerProgrammerAnalystRB.Checked) {
                availableCoursesCB.DataSource = computerProgrammerAnalystCourses;
            } else {
                availableCoursesCB.DataSource = computerProgrammerCourses;
            }

            availableCoursesCB.DisplayMember = "Name";
            availableCoursesCB.ValueMember = "Name";

            lstCourses.DataSource = selectedCourses;
            lstCourses.DisplayMember = "Name";
            lstCourses.ValueMember = "Name";
        }

        private void Form3_Load(object sender, EventArgs e) {

        }

        private void Exercise2_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
        }

        private RadioButton lastChecked;

        private void programType_Changed(object sender, EventArgs e) {

            RadioButton radio = sender as RadioButton;

            if (radio.Checked) {
                if (selectedCourses.Count > 0) {
                    DialogResult result = MessageBox.Show(this, "Do you really want to change the Program? All your courses currently added will be removed?", "Warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes) {
                        resetCourseAvailableLists();
                        setDataSource();

                        lastChecked = radio;

                    } else {
                        radio.Checked = false;
                        lastChecked.CheckedChanged -= programType_Changed;
                        lastChecked.Checked = true;
                        lastChecked.CheckedChanged += programType_Changed;

                    }
                } else {

                    resetCourseAvailableLists();
                    setDataSource();
                    lastChecked = radio;
                }
            }
        }

        private void availableCoursesCB_SelectedIndexChanged(object sender, EventArgs e) {

            if (availableCoursesCB.SelectedIndex >= 1) {

                var item = availableCoursesCB.SelectedItem as Course;

                selectedCourses.Add(item);

                if (item.Program == COMPUTER_PROGRAMMER_ANALYST) {
                    computerProgrammerAnalystCourses.Remove(item);
                } else {
                    computerProgrammerCourses.Remove(item);
                }
            }
        }

        private void lstCourses_DoubleClick(object sender, EventArgs e) {
            if (lstCourses.SelectedIndex >= 0) {

                var item = lstCourses.SelectedItem as Course;

                selectedCourses.Remove(item);

                if (item.Program == COMPUTER_PROGRAMMER_ANALYST) {
                    computerProgrammerAnalystCourses.Add(item);
                } else {
                    computerProgrammerCourses.Add(item);
                }
            }
        }

        private void displayButton_Click(object sender, EventArgs e) {

            var student = new Student();

            student.Name = nameTextBox.Text;
            student.Address = addressTextBox.Text;
            student.City = cityTextBox.Text;
            student.PostalCode = postalCodeTextBox.Text;
            student.PhoneNumber = phoneNumberTextBox.Text;

            foreach (var item in selectedCourses) {
                student.Courses.Add(item);
            }

            students.Add(student);


            nameTextBox.Text = "";
            addressTextBox.Text = "";
            cityTextBox.Text = "";
            postalCodeTextBox.Text = "";
            phoneNumberTextBox.Text = "";

            resetCourseAvailableLists();
            refreshStudentsDisplay();
        }

        private void refreshStudentsDisplay() {

            txtDisplay.Clear();
            foreach (var item in students) {
                txtDisplay.Text += item.CustomToString() + "\r\n";
            }
        }
    }

    public class Student {

        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Province { get; set; }
        public string PhoneNumber { get; set; }
        public List<Course> Courses { get; set; }

        public Student() {
            Courses = new List<Course>();
        }

        internal string CustomToString() {

            var s = Name;
            s += " " + Address;

            foreach (var item in Courses) {
                s += " " + item.Name + ",";
            }

            return s.Substring(0, s.Length - 1);
        }
    }

    public class Course {

        public string Program { get; set; }
        public string Name { get; set; }

        public Course(string Program, string Name) {
            this.Program = Program.Trim();
            this.Name = Name.Trim();
        }
    }
}
