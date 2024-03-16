namespace KodlamaIOV2
{
    partial class CourseCrudForm
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
            this.dgwCourse = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxInstructor = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCourseAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCourseUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPriceUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDescriptionUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxInstructorUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.btnCourseRemove = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCourse)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCourse
            // 
            this.dgwCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCourse.Location = new System.Drawing.Point(245, 147);
            this.dgwCourse.Name = "dgwCourse";
            this.dgwCourse.Size = new System.Drawing.Size(845, 184);
            this.dgwCourse.TabIndex = 1;
            this.dgwCourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCourse_CellClick);
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
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.BackColor = System.Drawing.Color.Salmon;
            this.lblInstructor.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInstructor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInstructor.Location = new System.Drawing.Point(16, 74);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(90, 22);
            this.lblInstructor.TabIndex = 3;
            this.lblInstructor.Text = "Instructor";
            this.lblInstructor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Salmon;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescription.Location = new System.Drawing.Point(16, 120);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(104, 22);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Salmon;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrice.Location = new System.Drawing.Point(16, 161);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(50, 22);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxName.Location = new System.Drawing.Point(181, 30);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(191, 20);
            this.tbxName.TabIndex = 6;
            // 
            // tbxInstructor
            // 
            this.tbxInstructor.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxInstructor.Location = new System.Drawing.Point(181, 74);
            this.tbxInstructor.Name = "tbxInstructor";
            this.tbxInstructor.Size = new System.Drawing.Size(191, 20);
            this.tbxInstructor.TabIndex = 7;
            // 
            // tbxDescription
            // 
            this.tbxDescription.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxDescription.Location = new System.Drawing.Point(181, 123);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(191, 20);
            this.tbxDescription.TabIndex = 8;
            // 
            // tbxPrice
            // 
            this.tbxPrice.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxPrice.Location = new System.Drawing.Point(181, 161);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(191, 20);
            this.tbxPrice.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCourseAdd);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.tbxPrice);
            this.groupBox1.Controls.Add(this.lblInstructor);
            this.groupBox1.Controls.Add(this.tbxDescription);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.tbxInstructor);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Location = new System.Drawing.Point(254, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 244);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnCourseAdd
            // 
            this.btnCourseAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCourseAdd.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCourseAdd.Location = new System.Drawing.Point(181, 199);
            this.btnCourseAdd.Name = "btnCourseAdd";
            this.btnCourseAdd.Size = new System.Drawing.Size(191, 23);
            this.btnCourseAdd.TabIndex = 10;
            this.btnCourseAdd.Text = "Add";
            this.btnCourseAdd.UseVisualStyleBackColor = false;
            this.btnCourseAdd.Click += new System.EventHandler(this.courseAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCourseUpdate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbxPriceUpdate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbxDescriptionUpdate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbxInstructorUpdate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbxNameUpdate);
            this.groupBox2.Location = new System.Drawing.Point(700, 434);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 244);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnCourseUpdate
            // 
            this.btnCourseUpdate.BackColor = System.Drawing.Color.Gold;
            this.btnCourseUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCourseUpdate.Location = new System.Drawing.Point(181, 199);
            this.btnCourseUpdate.Name = "btnCourseUpdate";
            this.btnCourseUpdate.Size = new System.Drawing.Size(197, 23);
            this.btnCourseUpdate.TabIndex = 10;
            this.btnCourseUpdate.Text = "Update";
            this.btnCourseUpdate.UseVisualStyleBackColor = false;
            this.btnCourseUpdate.Click += new System.EventHandler(this.btnCourseUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxPriceUpdate
            // 
            this.tbxPriceUpdate.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxPriceUpdate.Location = new System.Drawing.Point(181, 161);
            this.tbxPriceUpdate.Name = "tbxPriceUpdate";
            this.tbxPriceUpdate.Size = new System.Drawing.Size(197, 20);
            this.tbxPriceUpdate.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Instructor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxDescriptionUpdate
            // 
            this.tbxDescriptionUpdate.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxDescriptionUpdate.Location = new System.Drawing.Point(181, 123);
            this.tbxDescriptionUpdate.Name = "tbxDescriptionUpdate";
            this.tbxDescriptionUpdate.Size = new System.Drawing.Size(197, 20);
            this.tbxDescriptionUpdate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Salmon;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(16, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxInstructorUpdate
            // 
            this.tbxInstructorUpdate.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxInstructorUpdate.Location = new System.Drawing.Point(181, 74);
            this.tbxInstructorUpdate.Name = "tbxInstructorUpdate";
            this.tbxInstructorUpdate.Size = new System.Drawing.Size(197, 20);
            this.tbxInstructorUpdate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Salmon;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(16, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxNameUpdate.Location = new System.Drawing.Point(181, 30);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(197, 20);
            this.tbxNameUpdate.TabIndex = 6;
            // 
            // btnCourseRemove
            // 
            this.btnCourseRemove.BackColor = System.Drawing.Color.Red;
            this.btnCourseRemove.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCourseRemove.Location = new System.Drawing.Point(591, 351);
            this.btnCourseRemove.Name = "btnCourseRemove";
            this.btnCourseRemove.Size = new System.Drawing.Size(215, 47);
            this.btnCourseRemove.TabIndex = 12;
            this.btnCourseRemove.Text = "Remove";
            this.btnCourseRemove.UseVisualStyleBackColor = false;
            this.btnCourseRemove.Click += new System.EventHandler(this.btnCourseRemove_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(605, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "CourseDB";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1300, 749);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCourseRemove);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwCourse);
            this.Name = "CourseCrudForm";
            this.Text = "CourseCrudForm";
            this.Load += new System.EventHandler(this.CourseCrudForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCourse)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCourse;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxInstructor;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCourseAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCourseUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPriceUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDescriptionUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxInstructorUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Button btnCourseRemove;
        private System.Windows.Forms.Label label5;
    }
}