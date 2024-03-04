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
    public partial class StudentMainForm : Form
    {
        int currStdId;
        public StudentMainForm(int id)
        {
            InitializeComponent();
            currStdId = id;
        }

        private void btn_to_avail_exams_form_Click(object sender, EventArgs e)
        {
            Hide();
            StdAvailExamsForm stdAvailExamsForm = new StdAvailExamsForm(currStdId);
            stdAvailExamsForm.ShowDialog();
            Close();
        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
