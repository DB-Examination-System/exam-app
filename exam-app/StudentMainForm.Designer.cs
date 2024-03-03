namespace exam_app
{
	partial class StudentMainForm
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
			btn_to_avail_exams_form = new Button();
			SuspendLayout();
			// 
			// btn_to_avail_exams_form
			// 
			btn_to_avail_exams_form.Location = new Point(283, 103);
			btn_to_avail_exams_form.Name = "btn_to_avail_exams_form";
			btn_to_avail_exams_form.Size = new Size(200, 29);
			btn_to_avail_exams_form.TabIndex = 0;
			btn_to_avail_exams_form.Text = "Show Available Exams";
			btn_to_avail_exams_form.UseVisualStyleBackColor = true;
			btn_to_avail_exams_form.Click += btn_to_avail_exams_form_Click;
			// 
			// StudentMainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btn_to_avail_exams_form);
			Name = "StudentMainForm";
			Text = "StudentMainForm";
			ResumeLayout(false);
		}

		#endregion

		private Button btn_to_avail_exams_form;
	}
}