using exam_app.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_app
{
    public partial class CreateQuestionsForm : Form
    {
        ItidbContext context;
        int Ins_id { get; set; }
        public CreateQuestionsForm(int Ins_id)
        {
            this.Ins_id = Ins_id;
            context = new ItidbContext();
            InitializeComponent();
        }

        private void CreateQuestionsForm_Load(object sender, EventArgs e)
        {
            DefaultStart();
            getInstructorCourses();
            cb_QuestionType.SelectedIndex = 0;
            cb_TorF_ans.SelectedIndex = 0;

            //
            DGV_Crs_Questions.DataSource = context.Questions
               .Where(Question => Question.CourseId == (int) cb_Courses.SelectedValue)
               .Select(Question => new
               {
                   Question.QType,
                   Question.QContent,
                   Question.ModelAnswer,
                   Question.Course.CrsName,
               })
               .ToList();
        }

        void getInstructorCourses()
        {
            var instructorCourses = context.InsCourses.Where((ins_crs) => ins_crs.InsId == Ins_id)
                .Select(x => new { x.CrsId, x.Crs.CrsName });

            cb_Courses.DataSource = instructorCourses.ToList();
            cb_Courses.DisplayMember = "CrsName";
            cb_Courses.ValueMember = "CrsId";

        }

        void DefaultStart()
        {
            Choice1.Visible = false;
            Choice2.Visible = false;
            Choice3.Visible = false;
            Choice4.Visible = false;

            Correct_Answer.Visible = false;
            Cb_CorrectAnswer.Visible = false;

            txt_Choice1.Visible = false;
            txt_Choice2.Visible = false;
            txt_Choice3.Visible = false;
            txt_Choice4.Visible = false;
        }
   
        private void cb_Courses_SelectedIndexChanged(object sender, EventArgs e)
        {
           string selelctedCourse = cb_Courses.SelectedValue.ToString();

            DGV_Crs_Questions.DataSource = context.Questions
                .Where(Question => Question.CourseId == int.Parse(selelctedCourse))
                .Select(Question => new
                {
                    Question.QType,
                    Question.QContent,
                    Question.ModelAnswer,
                    Question.Course.CrsName,
                })
                .ToList();

            DGV_Crs_Questions.Refresh();
        }

    }
}
