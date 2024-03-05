namespace exam_app
{
    partial class ShowStudentGradesForm
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
            btn_search = new Button();
            label1 = new Label();
            txt_id = new TextBox();
            dgv_studentGrades = new DataGridView();
            lbl_name = new Label();
            lbl_id = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_studentGrades).BeginInit();
            SuspendLayout();
            // 
            // btn_search
            // 
            btn_search.BackColor = SystemColors.GradientActiveCaption;
            btn_search.ForeColor = Color.Black;
            btn_search.Location = new Point(539, 36);
            btn_search.Margin = new Padding(4);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(142, 48);
            btn_search.TabIndex = 5;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(181, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 4;
            label1.Text = "Enter Student ID";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(345, 36);
            txt_id.Margin = new Padding(4);
            txt_id.Multiline = true;
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(159, 48);
            txt_id.TabIndex = 3;
            // 
            // dgv_studentGrades
            // 
            dgv_studentGrades.BackgroundColor = SystemColors.ControlLight;
            dgv_studentGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_studentGrades.Location = new Point(121, 210);
            dgv_studentGrades.Name = "dgv_studentGrades";
            dgv_studentGrades.RowHeadersWidth = 55;
            dgv_studentGrades.Size = new Size(625, 200);
            dgv_studentGrades.TabIndex = 6;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI Semibold", 14.0625F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name.ForeColor = Color.RoyalBlue;
            lbl_name.Location = new Point(363, 131);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(0, 35);
            lbl_name.TabIndex = 7;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_id.ForeColor = Color.RoyalBlue;
            lbl_id.Location = new Point(296, 128);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(0, 38);
            lbl_id.TabIndex = 8;
            // 
            // ShowStudentGradesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 440);
            Controls.Add(lbl_id);
            Controls.Add(lbl_name);
            Controls.Add(dgv_studentGrades);
            Controls.Add(btn_search);
            Controls.Add(label1);
            Controls.Add(txt_id);
            Name = "ShowStudentGradesForm";
            Text = "ShowStudentGradesForm";
            ((System.ComponentModel.ISupportInitialize)dgv_studentGrades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_search;
        private Label label1;
        private TextBox txt_id;
        private DataGridView dgv_studentGrades;
        private Label lbl_name;
        private Label lbl_id;
    }
}