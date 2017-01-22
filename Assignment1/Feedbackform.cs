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

            clearForm();
        }

        private void clear_Click(object sender, EventArgs e) {

            clearForm();
        }

        private void clearForm() {

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

        private void submit_Click(object sender, EventArgs e) {

            var message = "Name: " + nameTB.Text;
            message += "\r\nComments: " + commentsTB.Text;
            message += "\r\nE-mail Address: " + emailTB.Text;
            message += "\r\nThings you liked: ";

            if (siteDesignCB.Checked) {
                message += "\r\n\tSite design";
            }
            if (linksCB.Checked) {
                message += "\r\n\tLinks";
            }
            if (easeOfUseCB.Checked) {
                message += "\r\n\tEase of use";
            }
            if (imagesCB.Checked) {
                message += "\r\n\tImages";
            }
            if (sourceCodeCB.Checked) {
                message += "\r\n\tSource code";
            }

            message += "\r\nHow did you get to our site: ";

            if (searchEngineRB.Checked) {
                message += "\r\n\tSearch engine";
            }
            if (linksRB.Checked) {
                message += "\r\n\tLinks from another site";
            }
            if (deitelRB.Checked) {
                message += "\r\n\tDeitel.com WebSite";
            }
            if (referenceInBookRB.Checked) {
                message += "\r\n\tReference in a book";
            }
            if (otherRB.Checked) {
                message += "\r\n\tOther";
            }

            if (rateOurSiteCB.SelectedIndex >= 0) {

                message += "\r\nRate our site: ";
                message += "\r\n\t" + rateOurSiteCB.SelectedItem;
            }

            MessageBox.Show(message, "Thank you for your feedback!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
