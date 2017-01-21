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
    public partial class Exercise1 : Form {

        private List<Grade> grades = new List<Grade>();

        public Exercise1() {
            InitializeComponent();

            //grades.Add(new Grade { Text = "nhaaaaa0", Value = 123 });
            //grades.Add(new Grade { Text = "nhaaaaa1", Value = 123 });
            //grades.Add(new Grade { Text = "nhaaaaa2", Value = 123 });

            gradesListBox.DataSource = grades;
            gradesListBox.DisplayMember = "Text";
            gradesListBox.ValueMember = "Value";
            gradesListBox.ClearSelected();

        }

        private void addGradeClick(object sender, EventArgs e) {

            DialogResult result = MessageBox.Show(this, "nha 1", "my caption", MessageBoxButtons.YesNo);

            Console.WriteLine(result);

            string text = gradeInput.Text.Trim();

            if (text.Length > 0) {

                try {

                    var grade = new Grade {
                        Text = text,
                        Value = Convert.ToDouble(text)
                    };
                    if (grade.Value >= 0) {
                        grades.Add(grade);
                        gradesListBox.Refresh();
                        gradesListBox.Update();
                    }

                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }

            gradeInput.Text = "";
        }

    }

    public class Grade {

        public string Text { get; set; }
        public double Value { get; set; }


    }
}
