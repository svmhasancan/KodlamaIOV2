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
    public partial class InstructorCrudForm : Form
    {
        public InstructorCrudForm()
        {
            InitializeComponent();
        }

        InstructorManager instructorManager = new InstructorManager(new InstructorDal());

        private void InstructorCrudForm_Load(object sender, EventArgs e)
        {
            LoadInstructors();
        }

        private void LoadInstructors()
        {
            dgwInstructor.DataSource = instructorManager.GetAll();
        }


        private void btnInstructorAdd_Click(object sender, EventArgs e)
        {
            instructorManager.Add(new Instructor
            {
                Name = tbxName.Text.ToString(),
                City = tbxCity.Text.ToString(),
                Email = tbxEmail.Text.ToString()
            });
            LoadInstructors();
        }

        private void dgwInstructor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwInstructor.CurrentRow.Cells[1].Value.ToString();
            tbxCityUpdate.Text = dgwInstructor.CurrentRow.Cells[2].Value.ToString();
            tbxEmailUpdate.Text = dgwInstructor.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnInstructorUpdate_Click(object sender, EventArgs e)
        {
            instructorManager.Update(new Instructor
            {
                Id = Convert.ToInt32(dgwInstructor.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text.ToString(),
                City = tbxCityUpdate.Text.ToString(),
                Email = tbxEmailUpdate.Text.ToString()
            });
            LoadInstructors();
        }

        private void btnInstructorRemove_Click(object sender, EventArgs e)
        {
            instructorManager.Delete(new Instructor
            {
                Id = Convert.ToInt32(dgwInstructor.CurrentRow.Cells[0].Value)
            });
            LoadInstructors();
        }
    }
}
