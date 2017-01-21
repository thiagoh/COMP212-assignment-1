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
            this.clearButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.sumButton = new System.Windows.Forms.Button();
            this.averageButton = new System.Windows.Forms.Button();
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
            this.gradesListBox.Size = new System.Drawing.Size(153, 394);
            this.gradesListBox.TabIndex = 2;
            // 
            // gradeInput
            // 
            this.gradeInput.Location = new System.Drawing.Point(191, 48);
            this.gradeInput.MaxLength = 4;
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
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(191, 143);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(164, 38);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clear_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(191, 196);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(164, 38);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(191, 254);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(164, 38);
            this.sumButton.TabIndex = 7;
            this.sumButton.Text = "sum";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // averageButton
            // 
            this.averageButton.Location = new System.Drawing.Point(191, 313);
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(164, 38);
            this.averageButton.TabIndex = 8;
            this.averageButton.Text = "average";
            this.averageButton.UseVisualStyleBackColor = true;
            this.averageButton.Click += new System.EventHandler(this.averageButton_Click);
            // 
            // Exercise1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 451);
            this.Controls.Add(this.averageButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gradeInput);
            this.Controls.Add(this.gradesListBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Exercise1";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exercise1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox gradesListBox;
        private System.Windows.Forms.TextBox gradeInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button averageButton;
    }
}