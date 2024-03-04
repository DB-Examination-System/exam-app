namespace exam_app
{
	partial class InstructorMainForm
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
			btn_showCrsGrades = new Button();
			SuspendLayout();
			// 
			// btn_showCrsGrades
			// 
			btn_showCrsGrades.Location = new Point(287, 61);
			btn_showCrsGrades.Name = "btn_showCrsGrades";
			btn_showCrsGrades.Size = new Size(206, 57);
			btn_showCrsGrades.TabIndex = 0;
			btn_showCrsGrades.Text = "Show Courses Grades";
			btn_showCrsGrades.UseVisualStyleBackColor = true;
			// 
			// InstructorMainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btn_showCrsGrades);
			Name = "InstructorMainForm";
			Text = "InstructorMainForm";
			ResumeLayout(false);
		}

		#endregion

		private Button btn_showCrsGrades;
	}
}