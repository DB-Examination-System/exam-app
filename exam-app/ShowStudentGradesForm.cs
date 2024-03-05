using exam_app.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace exam_app
{
    public partial class ShowStudentGradesForm : Form
    {
        int stid;
        ItidbContext db = new ItidbContext();

        public ShowStudentGradesForm()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_id.Text, out stid))
            {
                MessageBox.Show("Please enter a valid student ID.");
                return;
            }

            var student = db.Students.FirstOrDefault(s => s.StId == stid);

            if (student != null)
            {
                lbl_name.Text = $"{student.StFname} {student.StLname}";
                lbl_id.Text = $"{student.StId.ToString()}. ";


                var examGrades = (from se in db.StudentExams
                                  join ex in db.Exams on se.ExamId equals ex.ExId
                                  join c in db.Courses on ex.CourseId equals c.CrsId
                                  where se.StudentId == stid
                                  select new
                                  {
                                      ExamId = ex.ExId,
                                      CourseName = c.CrsName,
                                      ExamDate = ex.ExDate,
                                      Grade = se.Grade,
                                  }).ToList();

                dgv_studentGrades.DataSource = examGrades;
            }
            else
            {
                MessageBox.Show("Student not exists.");
            }
        }
    }
}





