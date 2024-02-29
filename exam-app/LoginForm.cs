using exam_app.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_app
{
	public partial class LoginForm : Form
	{
		ItidbContext iticontext { get; set; }
		public LoginForm()
		{
			InitializeComponent();
			iticontext = new ItidbContext();
		}

		private void bttn_login_Click(object sender, EventArgs e)
		{
			if(txt_username.Text.IsNullOrEmpty() ||  txt_password.Text.IsNullOrEmpty() )
			{
				MessageBox.Show("please enter all data");
			}
			else
			{
				var user = iticontext.LoginAccounts.FirstOrDefault(u => u.UserName == txt_username.Text);
				
				if (user == null || user.Role==null)
				{
					MessageBox.Show("wrong username");
				}
				else
				{
					Debug.WriteLine(user.Role);
					if (user.Password == txt_password.Text && user.Role!=null)
					{
						MessageBox.Show(user.Role);
						if (user.Role.ToLower().Trim() == "student")
						{
							Hide();
							StudentMainForm studentMainForm = new StudentMainForm();
							studentMainForm.ShowDialog();
							this.Close();
						}
						else if (user.Role.Trim() == "instructor")
						{
							Hide();
							InstructorMainForm instructorMainForm = new InstructorMainForm();
							instructorMainForm.ShowDialog();
							this.Close();
						}else if(user.Role.Trim() == "admin")
						{
							Hide();
							AdminMainForm adminMainForm = new AdminMainForm();
							adminMainForm.ShowDialog();
							this.Close();
						}
						else
						{
							MessageBox.Show("sorry you don't have any roles");
						}
					}
					else { MessageBox.Show("wrong password"); }
				}
			}

		}
	}
}
