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
    public partial class CategoryCrudForm : Form
    {
        public CategoryCrudForm()
        {
            InitializeComponent();
        }

        CategoryManager categoryManager = new CategoryManager(new CategoryDal());

        private void CategoryCrudForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            dgwCategories.DataSource = categoryManager.GetAll();
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            categoryManager.Add(new Category
            {
                Name = tbxName.Text
            });
            LoadCategories();
        }

        private void dgwCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwCategories.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            categoryManager.Update(new Category {
                Id = Convert.ToInt32(dgwCategories.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text 
            });
            LoadCategories();
        }

        private void btnCategoryRemove_Click(object sender, EventArgs e)
        {
            categoryManager.Delete(new Category{ 
                Id = Convert.ToInt32(dgwCategories.CurrentRow.Cells[0].Value) 
            });
            LoadCategories();
        }
    }
}
