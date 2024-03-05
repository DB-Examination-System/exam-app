namespace exam_app
{
    partial class CreateQuestionsForm
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
            label1 = new Label();
            cb_Courses = new ComboBox();
            DGV_Crs_Questions = new DataGridView();
            label2 = new Label();
            cb_QuestionType = new ComboBox();
            txt_QuesContent = new TextBox();
            Question_Content = new Label();
            txt_Choice1 = new TextBox();
            txt_Choice2 = new TextBox();
            txt_Choice3 = new TextBox();
            txt_Choice4 = new TextBox();
            Choice1 = new Label();
            Choice2 = new Label();
            Choice3 = new Label();
            Choice4 = new Label();
            cb_TorF_ans = new ComboBox();
            Answer = new Label();
            Cb_CorrectAnswer = new ComboBox();
            Correct_Answer = new Label();
            btn_AddQuestion = new Button();
            DVG_Question_Choices = new DataGridView();
            btn_DeleteQuestion = new Button();
            btn_UpdateQuestion = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_Crs_Questions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DVG_Question_Choices).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(28, 34);
            label1.Name = "label1";
            label1.Size = new Size(99, 17);
            label1.TabIndex = 0;
            label1.Text = "Choose Course";
            // 
            // cb_Courses
            // 
            cb_Courses.FormattingEnabled = true;
            cb_Courses.Location = new Point(162, 33);
            cb_Courses.Name = "cb_Courses";
            cb_Courses.Size = new Size(121, 23);
            cb_Courses.TabIndex = 1;
            cb_Courses.SelectedIndexChanged += cb_Courses_SelectedIndexChanged;
            // 
            // DGV_Crs_Questions
            // 
            DGV_Crs_Questions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Crs_Questions.Location = new Point(12, 259);
            DGV_Crs_Questions.Name = "DGV_Crs_Questions";
            DGV_Crs_Questions.Size = new Size(438, 179);
            DGV_Crs_Questions.TabIndex = 2;
            DGV_Crs_Questions.RowHeaderMouseDoubleClick += DGV_Crs_Questions_RowHeaderMouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(539, 35);
            label2.Name = "label2";
            label2.Size = new Size(97, 17);
            label2.TabIndex = 3;
            label2.Text = "Quesrion Type";
            // 
            // cb_QuestionType
            // 
            cb_QuestionType.FormattingEnabled = true;
            cb_QuestionType.Items.AddRange(new object[] { "True or False", "Multiple Choices" });
            cb_QuestionType.Location = new Point(651, 34);
            cb_QuestionType.Name = "cb_QuestionType";
            cb_QuestionType.Size = new Size(121, 23);
            cb_QuestionType.TabIndex = 4;
            cb_QuestionType.SelectedIndexChanged += cb_QuestionType_SelectedIndexChanged;
            // 
            // txt_QuesContent
            // 
            txt_QuesContent.Location = new Point(162, 91);
            txt_QuesContent.Name = "txt_QuesContent";
            txt_QuesContent.Size = new Size(376, 23);
            txt_QuesContent.TabIndex = 5;
            // 
            // Question_Content
            // 
            Question_Content.AutoSize = true;
            Question_Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Question_Content.ForeColor = Color.Navy;
            Question_Content.Location = new Point(28, 97);
            Question_Content.Name = "Question_Content";
            Question_Content.Size = new Size(117, 17);
            Question_Content.TabIndex = 6;
            Question_Content.Text = "Question Content";
            // 
            // txt_Choice1
            // 
            txt_Choice1.Location = new Point(162, 130);
            txt_Choice1.Name = "txt_Choice1";
            txt_Choice1.Size = new Size(206, 23);
            txt_Choice1.TabIndex = 7;
            // 
            // txt_Choice2
            // 
            txt_Choice2.Location = new Point(162, 159);
            txt_Choice2.Name = "txt_Choice2";
            txt_Choice2.Size = new Size(206, 23);
            txt_Choice2.TabIndex = 9;
            // 
            // txt_Choice3
            // 
            txt_Choice3.Location = new Point(566, 130);
            txt_Choice3.Name = "txt_Choice3";
            txt_Choice3.Size = new Size(206, 23);
            txt_Choice3.TabIndex = 11;
            // 
            // txt_Choice4
            // 
            txt_Choice4.Location = new Point(566, 159);
            txt_Choice4.Name = "txt_Choice4";
            txt_Choice4.Size = new Size(206, 23);
            txt_Choice4.TabIndex = 12;
            // 
            // Choice1
            // 
            Choice1.AutoSize = true;
            Choice1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Choice1.ForeColor = Color.Navy;
            Choice1.Location = new Point(28, 136);
            Choice1.Name = "Choice1";
            Choice1.Size = new Size(60, 17);
            Choice1.TabIndex = 13;
            Choice1.Text = "Choice 1";
            // 
            // Choice2
            // 
            Choice2.AutoSize = true;
            Choice2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Choice2.ForeColor = Color.Navy;
            Choice2.Location = new Point(28, 167);
            Choice2.Name = "Choice2";
            Choice2.Size = new Size(60, 17);
            Choice2.TabIndex = 14;
            Choice2.Text = "Choice 2";
            // 
            // Choice3
            // 
            Choice3.AutoSize = true;
            Choice3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Choice3.ForeColor = Color.Navy;
            Choice3.Location = new Point(474, 133);
            Choice3.Name = "Choice3";
            Choice3.Size = new Size(60, 17);
            Choice3.TabIndex = 15;
            Choice3.Text = "Choice 3";
            // 
            // Choice4
            // 
            Choice4.AutoSize = true;
            Choice4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Choice4.ForeColor = Color.Navy;
            Choice4.Location = new Point(474, 167);
            Choice4.Name = "Choice4";
            Choice4.Size = new Size(60, 17);
            Choice4.TabIndex = 16;
            Choice4.Text = "Choice 4";
            // 
            // cb_TorF_ans
            // 
            cb_TorF_ans.DisplayMember = "True ";
            cb_TorF_ans.FormattingEnabled = true;
            cb_TorF_ans.Items.AddRange(new object[] { "True ", "False" });
            cb_TorF_ans.Location = new Point(651, 91);
            cb_TorF_ans.Name = "cb_TorF_ans";
            cb_TorF_ans.Size = new Size(121, 23);
            cb_TorF_ans.TabIndex = 17;
            // 
            // Answer
            // 
            Answer.AutoSize = true;
            Answer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Answer.ForeColor = Color.Navy;
            Answer.Location = new Point(562, 91);
            Answer.Name = "Answer";
            Answer.Size = new Size(57, 17);
            Answer.TabIndex = 18;
            Answer.Text = "Answer ";
            // 
            // Cb_CorrectAnswer
            // 
            Cb_CorrectAnswer.FormattingEnabled = true;
            Cb_CorrectAnswer.Items.AddRange(new object[] { "Choice 1", "Choice 2", "Choice 3", "Choice 4" });
            Cb_CorrectAnswer.Location = new Point(162, 200);
            Cb_CorrectAnswer.Name = "Cb_CorrectAnswer";
            Cb_CorrectAnswer.Size = new Size(121, 23);
            Cb_CorrectAnswer.TabIndex = 20;
            // 
            // Correct_Answer
            // 
            Correct_Answer.AutoSize = true;
            Correct_Answer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Correct_Answer.ForeColor = Color.Navy;
            Correct_Answer.Location = new Point(28, 206);
            Correct_Answer.Name = "Correct_Answer";
            Correct_Answer.Size = new Size(101, 17);
            Correct_Answer.TabIndex = 19;
            Correct_Answer.Text = "Correct Answer";
            // 
            // btn_AddQuestion
            // 
            btn_AddQuestion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddQuestion.ForeColor = Color.Navy;
            btn_AddQuestion.Location = new Point(651, 214);
            btn_AddQuestion.Name = "btn_AddQuestion";
            btn_AddQuestion.Size = new Size(122, 35);
            btn_AddQuestion.TabIndex = 21;
            btn_AddQuestion.Text = "Add Question";
            btn_AddQuestion.UseVisualStyleBackColor = true;
            btn_AddQuestion.Click += btn_AddQuestion_Click;
            // 
            // DVG_Question_Choices
            // 
            DVG_Question_Choices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVG_Question_Choices.Location = new Point(456, 259);
            DVG_Question_Choices.Name = "DVG_Question_Choices";
            DVG_Question_Choices.Size = new Size(316, 179);
            DVG_Question_Choices.TabIndex = 22;
            DVG_Question_Choices.RowHeaderMouseDoubleClick += DVG_Question_Choices_RowHeaderMouseDoubleClick;
            // 
            // btn_DeleteQuestion
            // 
            btn_DeleteQuestion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DeleteQuestion.ForeColor = Color.Navy;
            btn_DeleteQuestion.Location = new Point(340, 214);
            btn_DeleteQuestion.Name = "btn_DeleteQuestion";
            btn_DeleteQuestion.Size = new Size(125, 35);
            btn_DeleteQuestion.TabIndex = 23;
            btn_DeleteQuestion.Text = "Delete Question";
            btn_DeleteQuestion.UseVisualStyleBackColor = true;
            btn_DeleteQuestion.Click += btn_DeleteQuestion_Click;
            // 
            // btn_UpdateQuestion
            // 
            btn_UpdateQuestion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_UpdateQuestion.ForeColor = Color.Navy;
            btn_UpdateQuestion.Location = new Point(497, 214);
            btn_UpdateQuestion.Name = "btn_UpdateQuestion";
            btn_UpdateQuestion.Size = new Size(122, 35);
            btn_UpdateQuestion.TabIndex = 24;
            btn_UpdateQuestion.Text = "Update Question";
            btn_UpdateQuestion.UseVisualStyleBackColor = true;
            btn_UpdateQuestion.Click += btn_UpdateQuestion_Click;
            // 
            // CreateQuestionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_UpdateQuestion);
            Controls.Add(btn_DeleteQuestion);
            Controls.Add(DVG_Question_Choices);
            Controls.Add(btn_AddQuestion);
            Controls.Add(Cb_CorrectAnswer);
            Controls.Add(Correct_Answer);
            Controls.Add(Answer);
            Controls.Add(cb_TorF_ans);
            Controls.Add(Choice4);
            Controls.Add(Choice3);
            Controls.Add(Choice2);
            Controls.Add(Choice1);
            Controls.Add(txt_Choice4);
            Controls.Add(txt_Choice3);
            Controls.Add(txt_Choice2);
            Controls.Add(txt_Choice1);
            Controls.Add(Question_Content);
            Controls.Add(txt_QuesContent);
            Controls.Add(cb_QuestionType);
            Controls.Add(label2);
            Controls.Add(DGV_Crs_Questions);
            Controls.Add(cb_Courses);
            Controls.Add(label1);
            Name = "CreateQuestionsForm";
            Text = "CreateQuestionsForm";
            Load += CreateQuestionsForm_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Crs_Questions).EndInit();
            ((System.ComponentModel.ISupportInitialize)DVG_Question_Choices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cb_Courses;
        private DataGridView DGV_Crs_Questions;
        private Label label2;
        private ComboBox cb_QuestionType;
        private TextBox txt_QuesContent;
        private Label Question_Content;
        private TextBox txt_Choice1;
        private TextBox txt_Choice2;
        private TextBox txt_Choice3;
        private TextBox txt_Choice4;
        private Label Choice1;
        private Label Choice2;
        private Label Choice3;
        private Label Choice4;
        private ComboBox cb_TorF_ans;
        private Label Answer;
        private ComboBox Cb_CorrectAnswer;
        private Label Correct_Answer;
        private Button btn_AddQuestion;
        private DataGridView DVG_Question_Choices;
        private Button btn_DeleteQuestion;
        private Button btn_UpdateQuestion;
    }
}