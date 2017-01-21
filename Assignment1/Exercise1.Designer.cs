namespace Assignment1 {
    partial class Exercise1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.gradesListBox = new System.Windows.Forms.ListBox();
            this.gradeInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grades";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gradesListBox
            // 
            this.gradesListBox.FormattingEnabled = true;
            this.gradesListBox.Location = new System.Drawing.Point(12, 48);
            this.gradesListBox.Name = "gradesListBox";
            this.gradesListBox.Size = new System.Drawing.Size(153, 433);
            this.gradesListBox.TabIndex = 2;
            // 
            // gradeInput
            // 
            this.gradeInput.Location = new System.Drawing.Point(191, 48);
            this.gradeInput.Name = "gradeInput";
            this.gradeInput.Size = new System.Drawing.Size(164, 20);
            this.gradeInput.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "input";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addGradeClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(191, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 38);
            this.button3.TabIndex = 6;
            this.button3.Text = "remove";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(191, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 38);
            this.button4.TabIndex = 7;
            this.button4.Text = "sum";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(191, 313);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 38);
            this.button5.TabIndex = 8;
            this.button5.Text = "average";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Exercise1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 517);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gradeInput);
            this.Controls.Add(this.gradesListBox);
            this.Controls.Add(this.label1);
            this.Name = "Exercise1";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox gradesListBox;
        private System.Windows.Forms.TextBox gradeInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}