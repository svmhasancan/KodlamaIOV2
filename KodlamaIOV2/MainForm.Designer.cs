namespace KodlamaIOV2
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCourseDb = new System.Windows.Forms.Button();
            this.btnCategoryDb = new System.Windows.Forms.Button();
            this.btnInstructorDb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(548, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kodlama.io Database";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCourseDb
            // 
            this.btnCourseDb.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnCourseDb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCourseDb.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btnCourseDb.FlatAppearance.BorderSize = 0;
            this.btnCourseDb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCourseDb.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCourseDb.Location = new System.Drawing.Point(586, 224);
            this.btnCourseDb.Name = "btnCourseDb";
            this.btnCourseDb.Size = new System.Drawing.Size(175, 38);
            this.btnCourseDb.TabIndex = 4;
            this.btnCourseDb.Text = "CourseDB";
            this.btnCourseDb.UseVisualStyleBackColor = false;
            this.btnCourseDb.Click += new System.EventHandler(this.btnCourseDb_Click);
            // 
            // btnCategoryDb
            // 
            this.btnCategoryDb.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnCategoryDb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCategoryDb.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btnCategoryDb.FlatAppearance.BorderSize = 0;
            this.btnCategoryDb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryDb.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCategoryDb.Location = new System.Drawing.Point(586, 338);
            this.btnCategoryDb.Name = "btnCategoryDb";
            this.btnCategoryDb.Size = new System.Drawing.Size(175, 38);
            this.btnCategoryDb.TabIndex = 5;
            this.btnCategoryDb.Text = "CategoryDB";
            this.btnCategoryDb.UseVisualStyleBackColor = false;
            this.btnCategoryDb.Click += new System.EventHandler(this.btnCategoryDb_Click);
            // 
            // btnInstructorDb
            // 
            this.btnInstructorDb.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnInstructorDb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInstructorDb.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btnInstructorDb.FlatAppearance.BorderSize = 0;
            this.btnInstructorDb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInstructorDb.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnInstructorDb.Location = new System.Drawing.Point(586, 458);
            this.btnInstructorDb.Name = "btnInstructorDb";
            this.btnInstructorDb.Size = new System.Drawing.Size(175, 38);
            this.btnInstructorDb.TabIndex = 6;
            this.btnInstructorDb.Text = "InstructorDB";
            this.btnInstructorDb.UseVisualStyleBackColor = false;
            this.btnInstructorDb.Click += new System.EventHandler(this.btnInstructorDb_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(1248, 497);
            this.Controls.Add(this.btnInstructorDb);
            this.Controls.Add(this.btnCategoryDb);
            this.Controls.Add(this.btnCourseDb);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kodlama.io";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCourseDb;
        private System.Windows.Forms.Button btnCategoryDb;
        private System.Windows.Forms.Button btnInstructorDb;
    }
}

