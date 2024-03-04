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
    public partial class InstructorMainForm : Form
    {
        int Ins_id;
        public InstructorMainForm(int ins_id)
        {
            InitializeComponent();
            Ins_id = ins_id;
        }

        private void InstructorMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
