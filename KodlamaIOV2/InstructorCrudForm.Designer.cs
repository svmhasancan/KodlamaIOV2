namespace KodlamaIOV2
{
    partial class InstructorCrudForm
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
            this.btnInstructorRemove = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInstructorUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxEmailUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCityUpdate = new System.Windows.Forms.TextBox();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInstructorAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.dgwInstructor = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInstructor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInstructorRemove
            // 
            this.btnInstructorRemove.BackColor = System.Drawing.Color.Red;
            this.btnInstructorRemove.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInstructorRemove.Location = new System.Drawing.Point(579, 316);
            this.btnInstructorRemove.Name = "btnInstructorRemove";
            this.btnInstructorRemove.Size = new System.Drawing.Size(187, 35);
            this.btnInstructorRemove.TabIndex = 16;
            this.btnInstructorRemove.Text = "Remove";
            this.btnInstructorRemove.UseVisualStyleBackColor = false;
            this.btnInstructorRemove.Click += new System.EventHandler(this.btnInstructorRemove_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInstructorUpdate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbxEmailUpdate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbxCityUpdate);
            this.groupBox2.Controls.Add(this.tbxNameUpdate);
            this.groupBox2.Location = new System.Drawing.Point(693, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 207);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnInstructorUpdate
            // 
            this.btnInstructorUpdate.BackColor = System.Drawing.Color.Gold;
            this.btnInstructorUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInstructorUpdate.Location = new System.Drawing.Point(167, 163);
            this.btnInstructorUpdate.Name = "btnInstructorUpdate";
            this.btnInstructorUpdate.Size = new System.Drawing.Size(197, 23);
            this.btnInstructorUpdate.TabIndex = 10;
            this.btnInstructorUpdate.Text = "Update";
            this.btnInstructorUpdate.UseVisualStyleBackColor = false;
            this.btnInstructorUpdate.Click += new System.EventHandler(this.btnInstructorUpdate_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "City";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxEmailUpdate
            // 
            this.tbxEmailUpdate.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxEmailUpdate.Location = new System.Drawing.Point(167, 123);
            this.tbxEmailUpdate.Name = "tbxEmailUpdate";
            this.tbxEmailUpdate.Size = new System.Drawing.Size(197, 20);
            this.tbxEmailUpdate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Salmon;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(16, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxCityUpdate
            // 
            this.tbxCityUpdate.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxCityUpdate.Location = new System.Drawing.Point(167, 74);
            this.tbxCityUpdate.Name = "tbxCityUpdate";
            this.tbxCityUpdate.Size = new System.Drawing.Size(197, 20);
            this.tbxCityUpdate.TabIndex = 7;
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxNameUpdate.Location = new System.Drawing.Point(167, 30);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(197, 20);
            this.tbxNameUpdate.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInstructorAdd);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblInstructor);
            this.groupBox1.Controls.Add(this.tbxEmail);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.tbxCity);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Location = new System.Drawing.Point(248, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 207);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnInstructorAdd
            // 
            this.btnInstructorAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnInstructorAdd.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInstructorAdd.Location = new System.Drawing.Point(181, 163);
            this.btnInstructorAdd.Name = "btnInstructorAdd";
            this.btnInstructorAdd.Size = new System.Drawing.Size(191, 23);
            this.btnInstructorAdd.TabIndex = 10;
            this.btnInstructorAdd.Text = "Add";
            this.btnInstructorAdd.UseVisualStyleBackColor = false;
            this.btnInstructorAdd.Click += new System.EventHandler(this.btnInstructorAdd_Click);
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
            this.lblInstructor.Size = new System.Drawing.Size(42, 22);
            this.lblInstructor.TabIndex = 3;
            this.lblInstructor.Text = "City";
            this.lblInstructor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxEmail.Location = new System.Drawing.Point(181, 123);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(191, 20);
            this.tbxEmail.TabIndex = 8;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Salmon;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescription.Location = new System.Drawing.Point(16, 120);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(54, 22);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Email";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxCity
            // 
            this.tbxCity.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxCity.Location = new System.Drawing.Point(181, 74);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(191, 20);
            this.tbxCity.TabIndex = 7;
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxName.Location = new System.Drawing.Point(181, 30);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(191, 20);
            this.tbxName.TabIndex = 6;
            // 
            // dgwInstructor
            // 
            this.dgwInstructor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwInstructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInstructor.Location = new System.Drawing.Point(248, 120);
            this.dgwInstructor.Name = "dgwInstructor";
            this.dgwInstructor.Size = new System.Drawing.Size(835, 174);
            this.dgwInstructor.TabIndex = 13;
            this.dgwInstructor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwInstructor_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(592, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "InstructorDB";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstructorCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnInstructorRemove);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwInstructor);
            this.Name = "InstructorCrudForm";
            this.Text = "InstructorCrudForm";
            this.Load += new System.EventHandler(this.InstructorCrudForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInstructor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstructorRemove;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInstructorUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxEmailUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCityUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInstructorAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.DataGridView dgwInstructor;
        private System.Windows.Forms.Label label4;
    }
}