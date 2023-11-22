namespace GPA_CALC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            Calculate_Button = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 410);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(395, 19);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 5;
            label4.Text = "Grades";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(205, 19);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 4;
            label3.Text = "Course Hours";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 3;
            label2.Text = "Course Name";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.Location = new Point(12, 541);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(146, 21);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "⨁ Add new cources";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 1;
            label1.Text = "GPA Calculator";
            // 
            // Calculate_Button
            // 
            Calculate_Button.Location = new Point(198, 541);
            Calculate_Button.Name = "Calculate_Button";
            Calculate_Button.Size = new Size(150, 79);
            Calculate_Button.TabIndex = 2;
            Calculate_Button.Text = "Calculate";
            Calculate_Button.UseVisualStyleBackColor = true;
            Calculate_Button.Click += Calculate_Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 655);
            Controls.Add(linkLabel1);
            Controls.Add(Calculate_Button);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "GPA Calculator";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button Calculate_Button;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label4;
        private Label label3;
    }
}