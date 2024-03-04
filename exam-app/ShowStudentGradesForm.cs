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

        private void ShowStudentGradesForm_Load(object sender, EventArgs e)
        {
            // You can initialize the form or load additional data if needed.
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
                // Display student information
                // You may need to adjust the property names based on your actual model
                lbl_name.Text = $"{student.StFname} {student.StLname}";
                //lbl_id.Text = student.StId.ToString();

                // Fetch and display exam grades
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






//using exam_app.Models;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace exam_app
//{
//    public partial class ShowStudentGradesForm : Form
//    {
//        public ShowStudentGradesForm()
//        {
//            InitializeComponent();
//        }
//        ItidbContext db = new ItidbContext();
//        private void ShowStudentGradesForm_Load(object sender, EventArgs e)
//        {
//            dgv_studentGrades.DataSource = db.Students.include().ToList();
//        }

//        //private void btn_showData_Click(object sender, EventArgs e)
//        //{
//        //    insid = int.Parse(txt_id.Text);

//        //    var instructor = db.Instructors.FirstOrDefault(i => i.InsId == insid);
//        //    if (instructor != null)
//        //    {
//        //        txt_fname.Text = instructor.InsFname;
//        //        txt_lname.Text = instructor.InsLname;
//        //        dtp_birthdate.Text = instructor.InsBirthDate.ToString();
//        //        txt_phone.Text = instructor.InsPhone.ToString();
//        //        cb_insDegree.SelectedItem = instructor.InsDegree;
//        //    }
//        //    else
//        //    {
//        //        MessageBox.Show("Instructor not exists.");
//        //    }
//        //}

//        int stid;
//        private void btn_search_Click(object sender, EventArgs e)
//        {
//            if (!int.TryParse(txt_id.Text, out stid))
//            {
//                MessageBox.Show("Please enter a valid student ID.");
//                return;
//            }

//          //  Clear existing data in the DataGridView
//            dgv_studentGrades.Rows.Clear();
//            stid = int.Parse(txt_id.Text);
//            var student = db.Students.FirstOrDefault(s => s.StId == stid);
//            if (student != null)
//            {
//                Console.WriteLine("hello");

//            }
//            else
//            {
//                MessageBox.Show("Student not exists.");
//            }
//        }
//    }
//}
