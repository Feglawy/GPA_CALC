using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Schema;

namespace GPA_CALC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            int Total_Time = 0, temp = 0;
            double total_grade = 0;
            Dictionary<string, double> dict = new Dictionary<string, double>()
            {
                {"A+",  4  },
                {"A",  3.7 },
                {"B+", 3.3 },
                {"B",  3.0 },
                {"C+", 2.7 },
                {"C",  2.4 },
                {"D+", 2.2 },
                {"D",  2.0 },
                {"F",   0  },
            };

            double grade = 0;
            foreach (Control control in panel1.Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;

                    if (temp % 2 == 0)
                    {
                        string Grade = comboBox.Text;
                        if (Grade != "None" && Grade != null && Grade != "")
                        {
                            grade = dict[Grade];
                        }

                    }
                    else
                    {
                        string time = comboBox.Text;
                        if (time != "None" && time != null && time != "")
                        {
                            Total_Time += Convert.ToInt32(comboBox.Text);
                            total_grade += Convert.ToInt32(comboBox.Text) * grade;
                        }
                    }

                    temp++;
                }
            }
            string GPA = Calculate.Get_GPA(Total_Time, total_grade);
            MessageBox.Show(GPA, "GPA", MessageBoxButtons.OK);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TextBox newTextBox = new TextBox();
            ComboBox newComboBox = new ComboBox();
            ComboBox newComboBox2 = new ComboBox();

            newComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            newComboBox.FormattingEnabled = true;
            newComboBox.Items.AddRange(new object[] { "A+", "A", "B+", "B", "C+", "C", "D+", "D", "F", "None" });
            newComboBox.Location = new Point(352, panel1.Controls.Count * 15);
            newComboBox.Name = "comboBox2";
            newComboBox.Size = new Size(140, 29);
            newComboBox.TabIndex = 2;
            // 
            // comboBox1
            // 
            newComboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            newComboBox2.FormattingEnabled = true;
            newComboBox2.Items.AddRange(new object[] { "0", "2", "3" });
            newComboBox2.Location = new Point(186, panel1.Controls.Count * 15);
            newComboBox2.Name = "comboBox1";
            newComboBox2.Size = new Size(140, 29);
            newComboBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            newTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            newTextBox.Location = new Point(6, panel1.Controls.Count * 15);
            newTextBox.Name = "textBox1";
            newTextBox.Size = new Size(140, 29);
            newTextBox.TabIndex = 0;

            panel1.Controls.Add(newComboBox);
            panel1.Controls.Add(newComboBox2);
            panel1.Controls.Add(newTextBox);

        }
    }
}