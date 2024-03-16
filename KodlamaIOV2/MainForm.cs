using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KodlamaIOV2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCourseDb_Click(object sender, EventArgs e)
        {
            CourseCrudForm courseForm = new CourseCrudForm();
            courseForm.ShowDialog();
        }

        private void btnCategoryDb_Click(object sender, EventArgs e)
        {
            CategoryCrudForm categoryForm = new CategoryCrudForm();
            categoryForm.ShowDialog();
        }

        private void btnInstructorDb_Click(object sender, EventArgs e)
        {
            InstructorCrudForm instructorform = new InstructorCrudForm();
            instructorform.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
