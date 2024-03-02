﻿namespace exam_app
{
    partial class CreateExamForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            cmb_ins_courses = new ComboBox();
            label1 = new Label();
            btn_generate_exam = new Button();
            label2 = new Label();
            label3 = new Label();
            cmb_noOfTFQ = new ComboBox();
            cmb_noChooseQ = new ComboBox();
            DGV_exam_question = new DataGridView();
            DTP_examDate = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            txt_exam_name = new TextBox();
            txt_exam_duration = new TextBox();
            label6 = new Label();
            lst_createdExam = new ListView();
            btn_update_exam = new Button();
            btn_del_exam = new Button();
            btn_regenerate_Q = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGV_exam_question).BeginInit();
            SuspendLayout();
            // 
            // cmb_ins_courses
            // 
            cmb_ins_courses.Font = new Font("Tahoma", 12F);
            cmb_ins_courses.FormattingEnabled = true;
            cmb_ins_courses.Location = new Point(1128, 12);
            cmb_ins_courses.Name = "cmb_ins_courses";
            cmb_ins_courses.Size = new Size(192, 32);
            cmb_ins_courses.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F);
            label1.Location = new Point(911, 12);
            label1.Name = "label1";
            label1.Size = new Size(191, 28);
            label1.TabIndex = 1;
            label1.Text = "instructor courses";
            // 
            // btn_generate_exam
            // 
            btn_generate_exam.Font = new Font("Tahoma", 13.8F);
            btn_generate_exam.Location = new Point(393, 183);
            btn_generate_exam.Name = "btn_generate_exam";
            btn_generate_exam.Size = new Size(190, 46);
            btn_generate_exam.TabIndex = 2;
            btn_generate_exam.Text = "Generate-Exam";
            btn_generate_exam.UseVisualStyleBackColor = true;
            btn_generate_exam.Click += btn_generate_exam_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F);
            label2.Location = new Point(911, 67);
            label2.Name = "label2";
            label2.Size = new Size(211, 28);
            label2.TabIndex = 3;
            label2.Text = "true/false questions";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F);
            label3.Location = new Point(937, 113);
            label3.Name = "label3";
            label3.Size = new Size(185, 28);
            label3.TabIndex = 4;
            label3.Text = "choose questions";
            // 
            // cmb_noOfTFQ
            // 
            cmb_noOfTFQ.Font = new Font("Tahoma", 12F);
            cmb_noOfTFQ.FormattingEnabled = true;
            cmb_noOfTFQ.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmb_noOfTFQ.Location = new Point(1128, 63);
            cmb_noOfTFQ.Name = "cmb_noOfTFQ";
            cmb_noOfTFQ.Size = new Size(192, 32);
            cmb_noOfTFQ.TabIndex = 5;
            // 
            // cmb_noChooseQ
            // 
            cmb_noChooseQ.Font = new Font("Tahoma", 12F);
            cmb_noChooseQ.FormattingEnabled = true;
            cmb_noChooseQ.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmb_noChooseQ.Location = new Point(1128, 113);
            cmb_noChooseQ.Name = "cmb_noChooseQ";
            cmb_noChooseQ.Size = new Size(192, 32);
            cmb_noChooseQ.TabIndex = 6;
            // 
            // DGV_exam_question
            // 
            DGV_exam_question.AllowUserToAddRows = false;
            DGV_exam_question.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_exam_question.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGV_exam_question.DefaultCellStyle = dataGridViewCellStyle2;
            DGV_exam_question.Dock = DockStyle.Bottom;
            DGV_exam_question.Location = new Point(0, 256);
            DGV_exam_question.Name = "DGV_exam_question";
            DGV_exam_question.RowHeadersWidth = 51;
            DGV_exam_question.Size = new Size(1351, 266);
            DGV_exam_question.TabIndex = 7;
            // 
            // DTP_examDate
            // 
            DTP_examDate.CalendarFont = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTP_examDate.CustomFormat = "";
            DTP_examDate.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTP_examDate.Location = new Point(605, 113);
            DTP_examDate.Name = "DTP_examDate";
            DTP_examDate.Size = new Size(286, 32);
            DTP_examDate.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 13.8F);
            label4.Location = new Point(465, 117);
            label4.Name = "label4";
            label4.Size = new Size(118, 28);
            label4.TabIndex = 9;
            label4.Text = "exam date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13.8F);
            label5.Location = new Point(454, 16);
            label5.Name = "label5";
            label5.Size = new Size(129, 28);
            label5.TabIndex = 10;
            label5.Text = "exam name";
            // 
            // txt_exam_name
            // 
            txt_exam_name.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_exam_name.Location = new Point(605, 12);
            txt_exam_name.Name = "txt_exam_name";
            txt_exam_name.Size = new Size(286, 32);
            txt_exam_name.TabIndex = 11;
            // 
            // txt_exam_duration
            // 
            txt_exam_duration.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_exam_duration.Location = new Point(605, 67);
            txt_exam_duration.Name = "txt_exam_duration";
            txt_exam_duration.Size = new Size(286, 32);
            txt_exam_duration.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 13.8F);
            label6.Location = new Point(442, 67);
            label6.Name = "label6";
            label6.Size = new Size(157, 28);
            label6.TabIndex = 12;
            label6.Text = "exam duration";
            // 
            // lst_createdExam
            // 
            lst_createdExam.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lst_createdExam.Location = new Point(12, 57);
            lst_createdExam.Name = "lst_createdExam";
            lst_createdExam.Size = new Size(297, 193);
            lst_createdExam.TabIndex = 14;
            lst_createdExam.UseCompatibleStateImageBehavior = false;
            lst_createdExam.SelectedIndexChanged += lst_createdExam_SelectedIndexChanged;
            // 
            // btn_update_exam
            // 
            btn_update_exam.Font = new Font("Tahoma", 13.8F);
            btn_update_exam.Location = new Point(589, 183);
            btn_update_exam.Name = "btn_update_exam";
            btn_update_exam.Size = new Size(214, 46);
            btn_update_exam.TabIndex = 15;
            btn_update_exam.Text = "Update-Exam";
            btn_update_exam.UseVisualStyleBackColor = true;
            btn_update_exam.Click += btn_update_exam_Click;
            // 
            // btn_del_exam
            // 
            btn_del_exam.Font = new Font("Tahoma", 13.8F);
            btn_del_exam.Location = new Point(818, 183);
            btn_del_exam.Name = "btn_del_exam";
            btn_del_exam.Size = new Size(234, 46);
            btn_del_exam.TabIndex = 16;
            btn_del_exam.Text = "Delete-Exam";
            btn_del_exam.UseVisualStyleBackColor = true;
            btn_del_exam.Click += btn_del_exam_Click;
            // 
            // btn_regenerate_Q
            // 
            btn_regenerate_Q.Font = new Font("Tahoma", 13.8F);
            btn_regenerate_Q.Location = new Point(1068, 183);
            btn_regenerate_Q.Name = "btn_regenerate_Q";
            btn_regenerate_Q.Size = new Size(252, 46);
            btn_regenerate_Q.TabIndex = 17;
            btn_regenerate_Q.Text = "Regenerate-Questions";
            btn_regenerate_Q.UseVisualStyleBackColor = true;
            btn_regenerate_Q.Click += btn_regenerate_Q_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 13.8F);
            label7.Location = new Point(12, 16);
            label7.Name = "label7";
            label7.Size = new Size(186, 28);
            label7.TabIndex = 18;
            label7.Text = "generated exams";
            // 
            // CreateExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 522);
            Controls.Add(label7);
            Controls.Add(btn_regenerate_Q);
            Controls.Add(btn_del_exam);
            Controls.Add(btn_update_exam);
            Controls.Add(lst_createdExam);
            Controls.Add(txt_exam_duration);
            Controls.Add(label6);
            Controls.Add(txt_exam_name);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(DTP_examDate);
            Controls.Add(DGV_exam_question);
            Controls.Add(cmb_noChooseQ);
            Controls.Add(cmb_noOfTFQ);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_generate_exam);
            Controls.Add(label1);
            Controls.Add(cmb_ins_courses);
            Name = "CreateExamForm";
            Text = "CreateExamForm";
            Load += CreateExamForm_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_exam_question).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_ins_courses;
        private Label label1;
        private Button btn_generate_exam;
        private Label label2;
        private Label label3;
        private ComboBox cmb_noOfTFQ;
        private ComboBox cmb_noChooseQ;
        private DataGridView DGV_exam_question;
        private DateTimePicker DTP_examDate;
        private Label label4;
        private Label label5;
        private TextBox txt_exam_name;
        private TextBox txt_exam_duration;
        private Label label6;
        private ListView lst_createdExam;
        private Button btn_update_exam;
        private Button btn_del_exam;
        private Button btn_regenerate_Q;
        private Label label7;
    }
}