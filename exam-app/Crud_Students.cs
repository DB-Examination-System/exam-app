using exam_app.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Crud_Students : Form
    {
        ItidbContext context;
        public Crud_Students()
        {
            context = new ItidbContext();
            InitializeComponent();
        }
        #region formm add student
        private void add_btn_Click(object sender, EventArgs e)
        {
            //make validaton first on values
            if (string.IsNullOrWhiteSpace(fname_txt.Text) ||
                string.IsNullOrWhiteSpace(lname_txt.Text) ||
                string.IsNullOrWhiteSpace(age_txt.Text) ||
                string.IsNullOrWhiteSpace(username_txt.Text) ||
                string.IsNullOrWhiteSpace(city_txt.Text) ||
                string.IsNullOrWhiteSpace(phoneNumber_txt.Text) ||
                gender_combo.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            if (!int.TryParse(age_txt.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }
            if (!long.TryParse(phoneNumber_txt.Text, out long phoneNumber))
            {
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }
            string selectedGender = gender_combo.SelectedItem.ToString();
            // here i will add to db
            try
            {
                using (context)
                {
                    // Create a new instance of your entity class and populate it with the validated data
                    var newData = new Student
                    {
                        StFname = fname_txt.Text,
                        StLname = lname_txt.Text,
                        StAge = age,
                        City = city_txt.Text,
                        Street = street_txt.Text,
                        StPhone = int.Parse(phoneNumber_txt.Text),
                        StGender = gender_combo.SelectedItem.ToString(),

                    };
                    //add to student 
                    context.Students.Add(newData);
                    context.SaveChanges();

                    //add to login accounts
                    string stD_role = role_txt.Text;
                    string usernameVal = username_txt.Text;
                    string userpass = pass_txt.Text.Trim();
                    InsertIntoLoginAccounts(stD_role, usernameVal, userpass);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the database operation
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            MessageBox.Show("Student added successfully.");
            // here swithch to another form with std_id
        }
        #endregion add student
        #region add to login accounts
        private void InsertIntoLoginAccounts(string role, string username, string userpassword)
        {
            try
            {
                using (context)
                {
                    var newLoginAccount = new LoginAccount
                    {
                        Role = role,
                        Password = userpassword,
                        UserName = username

                    };

                    context.LoginAccounts.Add(newLoginAccount);
                    context.SaveChanges();

                    // MessageBox.Show("Login account added successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        #endregion


        #region Form Load
        private void Crud_Students_Load(object sender, EventArgs e)
        {
            //1- get gender and put it in combo
            gender_combo.Items.Add("Male");
            gender_combo.Items.Add("Female");
            //hide lbl and stdid
            stdid_lbl.Visible = false;
            std_id_txt.Visible = false;
            ok_btn.Visible = false;


        }
        #endregion


        private void update_btn_Click(object sender, EventArgs e)
        {
            stdid_lbl.Visible = true;
            std_id_txt.Visible = true;
            ok_btn.Visible = true;
            
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            int std_id = int.Parse(std_id_txt.Text);

            using (context) // Replace YourEntityModel with your DbContext class
            {
                var user = context.Students.FirstOrDefault(u => u.StId == std_id);
                if (user != null)
                {
                    fname_txt.Text = user.StFname;
                    lname_txt.Text = user.StLname;
                    age_txt.Text = user.StAge.ToString();
                    city_txt.Text = user.City;
                    street_txt.Text = user.Street;
                    phoneNumber_txt.Text = user.StPhone.ToString();

                    //gender
                    foreach (var item in gender_combo.Items)
                    {
                        if (item.ToString() == user.StGender)
                        {
                            gender_combo.SelectedItem = item;
                            break;
                        }
                    }
                    //
                    //get data of login accounts
                    var loginAccount = context.LoginAccounts.FirstOrDefault(l => l.UserId == user.UserId);
                    username_txt.Text = loginAccount.UserName;
                    role_txt.Text = loginAccount.Role;
                    pass_txt.Text = loginAccount.Password;

                    MessageBox.Show("Data retrieved successfully.");
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }
        }
    }
}
