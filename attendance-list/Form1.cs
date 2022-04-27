using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(tbStudentsCount.Text, out int students_count);
                string[] student_names = new string[students_count];

                int i = 0;
                while (i < students_count)
                {
                    student_names[i] = tbStudentsName.Text;
                    listBox1.Items.Add(student_names[i]);
                    result.Text = "Total Students: " + listBox1.Items.Count;
                    i++;
                }
                MessageBox.Show($"Student count is {students_count} only.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbStudentsName.ResetText();
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            result.Text = "Total Students: " + listBox1.Items.Count;
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            result.Text = "Total Students: " + listBox1.Items.Count;
        }
    }
}