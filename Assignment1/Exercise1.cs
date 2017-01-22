using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Assignment1 {
    public partial class Exercise1 : Form {

        private BindingList<Grade> grades = new BindingList<Grade>();
        private NumberFormatInfo numberFormat;

        public Exercise1() {
            InitializeComponent();

            numberFormat = new NumberFormatInfo();
            numberFormat.NumberDecimalSeparator = ".";
            numberFormat.NumberGroupSeparator = ",";
            numberFormat.NumberGroupSizes = new int[] { 3 };

            grades.Add(new Grade(9.8, numberFormat));
            grades.Add(new Grade(4.8, numberFormat));
            grades.Add(new Grade(1.4, numberFormat));

            gradesListBox.DataSource = grades;
            gradesListBox.DisplayMember = "Text";
            gradesListBox.ValueMember = "Value";
            gradesListBox.ClearSelected();

        }

        private void addGradeClick(object sender, EventArgs e) {

            string text = gradeInput.Text.Trim();

            if (text.Length > 0) {

                try {

                    var grade = new Grade {
                        Text = text,
                        Value = Convert.ToDouble(text, numberFormat)
                    };
                    if (grade.Value >= 0 && grade.Value <= 10.0) {
                        grades.Add(grade);
                    }

                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                }
            }

            gradeInput.Text = "";
        }

        private void clear_Click(object sender, EventArgs e) {
            grades.Clear();
        }

        private void Exercise1_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
        }

        private void removeButton_Click(object sender, EventArgs e) {

            if (gradesListBox.SelectedIndex >= 0) {
                grades.RemoveAt(gradesListBox.SelectedIndex);
            }
        }

        private void sumButton_Click(object sender, EventArgs e) {

            double sum = 0;
            for (int i = 0; i < grades.Count; i++) {
                sum += grades[i].Value;
            }

            DialogResult result = MessageBox.Show(this, "Sum is " + sum, "Sum of grades", MessageBoxButtons.OK);
        }

        private void averageButton_Click(object sender, EventArgs e) {
            double avg = 0;
            for (int i = 0; i < grades.Count; i++) {
                avg += grades[i].Value;
            }
            avg = avg / grades.Count;
            DialogResult result = MessageBox.Show(this, "Avg is " + avg, "Avg of grades", MessageBoxButtons.OK);
        }
    }

    public class Grade {

        public string Text { get; set; }
        public double Value { get; set; }

        public Grade() { }

        public Grade(double v, NumberFormatInfo numberFormat) {
            Text = Convert.ToString(v, numberFormat);
            Value = v;
        }
    }
}
