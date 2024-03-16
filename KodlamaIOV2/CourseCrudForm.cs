using KodlamaIOV2.Business.Concretes;
using KodlamaIOV2.DataAccess.Concretes;
using KodlamaIOV2.Entities;
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
    public partial class CourseCrudForm : Form
    {
        public CourseCrudForm()
        {
            InitializeComponent();
        }

        CourseManager courseManager = new CourseManager(new CourseDal());

        private void CourseCrudForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void LoadCourses()
        {
            dgwCourse.DataSource = courseManager.GetAll();
        }

        private void courseAdd_Click(object sender, EventArgs e)
        {
            courseManager.Add(new Course
            {
                Name = tbxName.Text,
                Instructor = tbxInstructor.Text,
                Description = tbxDescription.Text,
                Price = Convert.ToDecimal(tbxPrice.Text)
            });
            LoadCourses();
        }

        private void dgwCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwCourse.CurrentRow.Cells[1].Value.ToString();
            tbxInstructorUpdate.Text = dgwCourse.CurrentRow.Cells[2].Value.ToString();
            tbxDescriptionUpdate.Text = dgwCourse.CurrentRow.Cells[3].Value.ToString();
            tbxPriceUpdate.Text = dgwCourse.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnCourseUpdate_Click(object sender, EventArgs e)
        {
            courseManager.Update(new Course
            {
                Id = Convert.ToInt32(dgwCourse.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                Instructor = tbxInstructorUpdate.Text,
                Description = tbxDescriptionUpdate.Text,
                Price = Convert.ToDecimal(tbxPriceUpdate.Text)
            });
            LoadCourses();
        }

        private void btnCourseRemove_Click(object sender, EventArgs e)
        {
            courseManager.Delete(new Course
            {
                Id = Convert.ToInt32(dgwCourse.CurrentRow.Cells[0].Value)
            });
            LoadCourses();
        }
    }
}
