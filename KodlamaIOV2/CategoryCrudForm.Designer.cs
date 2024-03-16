namespace KodlamaIOV2
{
    partial class CategoryCrudForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCategoryRemove = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCategoryUpdate = new System.Windows.Forms.Button();
            this.labelNameUpdate = new System.Windows.Forms.Label();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.dgwCategories = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCategoryRemove
            // 
            this.btnCategoryRemove.BackColor = System.Drawing.Color.Red;
            this.btnCategoryRemove.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryRemove.Location = new System.Drawing.Point(580, 276);
            this.btnCategoryRemove.Name = "btnCategoryRemove";
            this.btnCategoryRemove.Size = new System.Drawing.Size(218, 47);
            this.btnCategoryRemove.TabIndex = 16;
            this.btnCategoryRemove.Text = "Remove";
            this.btnCategoryRemove.UseVisualStyleBackColor = false;
            this.btnCategoryRemove.Click += new System.EventHandler(this.btnCategoryRemove_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCategoryUpdate);
            this.groupBox2.Controls.Add(this.labelNameUpdate);
            this.groupBox2.Controls.Add(this.tbxNameUpdate);
            this.groupBox2.Location = new System.Drawing.Point(725, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 138);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.BackColor = System.Drawing.Color.Gold;
            this.btnCategoryUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryUpdate.Location = new System.Drawing.Point(181, 88);
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.Size = new System.Drawing.Size(197, 23);
            this.btnCategoryUpdate.TabIndex = 10;
            this.btnCategoryUpdate.Text = "Update";
            this.btnCategoryUpdate.UseVisualStyleBackColor = false;
            this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
            // 
            // labelNameUpdate
            // 
            this.labelNameUpdate.AutoSize = true;
            this.labelNameUpdate.BackColor = System.Drawing.Color.Salmon;
            this.labelNameUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNameUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNameUpdate.Location = new System.Drawing.Point(15, 30);
            this.labelNameUpdate.Name = "labelNameUpdate";
            this.labelNameUpdate.Size = new System.Drawing.Size(58, 22);
            this.labelNameUpdate.TabIndex = 2;
            this.labelNameUpdate.Text = "Name";
            this.labelNameUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxNameUpdate.Location = new System.Drawing.Point(181, 30);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(197, 20);
            this.tbxNameUpdate.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCategoryAdd);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Location = new System.Drawing.Point(132, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 138);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCategoryAdd.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryAdd.Location = new System.Drawing.Point(181, 88);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(191, 23);
            this.btnCategoryAdd.TabIndex = 10;
            this.btnCategoryAdd.Text = "Add";
            this.btnCategoryAdd.UseVisualStyleBackColor = false;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Salmon;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(15, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 22);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxName.Location = new System.Drawing.Point(181, 30);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(191, 20);
            this.tbxName.TabIndex = 6;
            // 
            // dgwCategories
            // 
            this.dgwCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCategories.Location = new System.Drawing.Point(256, 127);
            this.dgwCategories.Name = "dgwCategories";
            this.dgwCategories.Size = new System.Drawing.Size(845, 121);
            this.dgwCategories.TabIndex = 13;
            this.dgwCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCategories_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(611, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "CategoryDB";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoryCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1244, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCategoryRemove);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwCategories);
            this.Name = "CategoryCrudForm";
            this.Text = "CategoryCrudForm";
            this.Load += new System.EventHandler(this.CategoryCrudForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCategoryRemove;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCategoryUpdate;
        private System.Windows.Forms.Label labelNameUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.DataGridView dgwCategories;
        private System.Windows.Forms.Label label1;
    }
}