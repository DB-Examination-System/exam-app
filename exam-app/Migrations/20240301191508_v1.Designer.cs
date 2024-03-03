﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using exam_app.Models;

#nullable disable

namespace exam_app.Migrations
{
    [DbContext(typeof(ItidbContext))]
    [Migration("20240301191508_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("Latin1_General_CI_AS")
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BranchesTrack", b =>
                {
                    b.Property<int>("BranchId")
                        .HasColumnType("int")
                        .HasColumnName("Branch_id");

                    b.Property<int>("TrackId")
                        .HasColumnType("int")
                        .HasColumnName("Track_id");

                    b.HasKey("BranchId", "TrackId")
                        .HasName("PK_Branch'sTracks");

                    b.HasIndex("TrackId");

                    b.ToTable("BranchesTracks", (string)null);
                });

            modelBuilder.Entity("CrsTrack", b =>
                {
                    b.Property<int>("CrsId")
                        .HasColumnType("int")
                        .HasColumnName("Crs_id");

                    b.Property<int>("TrId")
                        .HasColumnType("int")
                        .HasColumnName("Tr_id");

                    b.HasKey("CrsId", "TrId");

                    b.HasIndex("TrId");

                    b.ToTable("Crs_Track", (string)null);
                });

            modelBuilder.Entity("ExamQuestion", b =>
                {
                    b.Property<int>("ExId")
                        .HasColumnType("int")
                        .HasColumnName("Ex_id");

                    b.Property<int>("QId")
                        .HasColumnType("int")
                        .HasColumnName("Q_id");

                    b.HasKey("ExId", "QId");

                    b.HasIndex("QId");

                    b.ToTable("Exam_Question", (string)null);
                });

            modelBuilder.Entity("exam_app.Models.Branch", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Branch_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BranchId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("BranchId");

                    b.ToTable("Branch", (string)null);
                });

            modelBuilder.Entity("exam_app.Models.Course", b =>
                {
                    b.Property<int>("CrsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Crs_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CrsId"));

                    b.Property<int>("CrsDuration")
                        .HasColumnType("int")
                        .HasColumnName("Crs_duration");

                    b.Property<string>("CrsName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Crs_name");

                    b.Property<int?>("TopicId")
                        .HasColumnType("int")
                        .HasColumnName("Topic_id");

                    b.HasKey("CrsId");

                    b.HasIndex("TopicId");

                    b.ToTable("Course", (string)null);
                });

            modelBuilder.Entity("exam_app.Models.Exam", b =>
                {
                    b.Property<int>("ExId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Ex_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExId"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("Course_id");

                    b.Property<DateTime>("ExDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("Ex_date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("ExDuration")
                        .HasColumnType("int")
                        .HasColumnName("Ex_duration");

                    b.Property<string>("ExamName")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("Exam_Name");

                    b.HasKey("ExId");

                    b.HasIndex("CourseId");

                    b.ToTable("Exam", (string)null);
                });

            modelBuilder.Entity("exam_app.Models.ExamStdQuestion", b =>
                {
                    b.Property<int>("ExId")
                        .HasColumnType("int")
                        .HasColumnName("Ex_id");

                    b.Property<int>("StId")
                        .HasColumnType("int")
                        .HasColumnName("St_id");

                    b.Property<int>("QId")
                        .HasColumnType("int")
                        .HasColumnName("Q_id");

                    b.Property<string>("StdAnswer")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Std_answer");

                    b.HasKey("ExId", "StId", "QId");

                    b.HasIndex("QId");

                    b.HasIndex("StId");

                    b.ToTable("Exam_Std_Question", (string)null);
                });

            modelBuilder.Entity("exam_app.Models.InsCourse", b =>
                {
                    b.Property<int>("InsId")
                        .HasColumnType("int")
                        .HasColumnName("Ins_id");

                    b.Property<int>("CrsId")
                        .HasColumnType("int")
                        .HasColumnName("Crs_id");

                    b.Property<string>("Evaluation")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.HasKey("InsId", "CrsId");

                    b.HasIndex("CrsId");

                    b.ToTable("Ins_Courses", (string)null);
                });

            modelBuilder.Entity("exam_app.Models.Instructor", b =>
                {
                    b.Property<int>("InsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Ins_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InsId"));

                    b.Property<int?>("InsAge")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("int")
                        .HasColumnName("Ins_Age")
                        .HasComputedColumnSql("(datediff(year,[Ins_BirthDate],getdate()))", false);

                    b.Property<DateOnly?>("InsBirthDate")
                        .HasColumnType("date")
                        .HasColumnName("Ins_BirthDate");

                    b.Property<string>("InsDegree")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Ins_Degree");

                    b.Property<string>("InsFname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .HasColumnName("Ins_Fname")
                        .IsFixedLength();

                    b.Property<string>("InsLname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .HasColumnName("Ins_Lname")
                        .IsFixedLength();

                    b.Property<string>("InsPhone")
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .HasColumnName("Ins_Phone")
                        .IsFixedLength();

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("User_id");

                    b.HasKey("InsId")
                        .HasName("PK_Instructors");

                    b.HasIndex("UserId");

                    b.ToTable("Instructor", (string)null);
                });

            modelBuilder.Entity("exam_app.Models.LoginAccount", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("User_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Role")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.ToTable("Login_Accounts", (string)null);
                });

            modelBuilder.Entity("exam_app.Models.Question", b =>
                {
                    b.Property<int>("QId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Q_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QId"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("Course_id");

                    b.Property<string>("ModelAnswer")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("Model_answer");

                    b.Property<string>("QContent")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("Q_content");

                    b.Property<string>("QType")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Q_type");

                    b.HasKey("QId")
                        .HasName("PK_Table_1");

                    b.HasIndex("CourseId");

                    b.ToTable("Question", (string)null);
                });

            modelBuilder.Entity("exam_app.Models.QuestionChoice", b =>
                {
                    b.Property<int>("QId")
                        .HasColumnType("int")
                        .HasColumnName("Q_id");

                    b.Property<string>("QChoice")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Q_choice");

                    b.HasKey("QId", "QChoice")
                        .HasName("PK_Q_choices");

                    b.ToTable("Question_choices", (string)null);
                });

            modelBuilder.Entity("exam_app.Models.Student", b =>
                {
                    b.Property<int>("StId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("St_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StId"));

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("StAge")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("int")
                        .HasColumnName("St_age")
                        .HasComputedColumnSql("(datepart(year,getdate())-datepart(year,[St_birthdate]))", false);

                    b.Property<DateOnly>("StBirthdate")
                        .HasColumnType("date")
                        .HasColumnName("St_birthdate");

                    b.Property<string>("StFname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("St_fname");

                    b.Property<string>("StGender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("St_gender");

                    b.Property<string>("StLname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("St_lname");

                    b.Property<int?>("StPhone")
                        .HasColumnType("int")
                        .HasColumnName("St_phone");

                    b.Property<string>("Street")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("User_id");

                    b.HasKey("StId");

                    b.HasIndex("UserId");

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("exam_app.Models.StudentCourse", b =>
                {
                    b.Property<int>("StdId")
                        .HasColumnType("int")
                        .HasColumnName("Std_id");

                    b.Property<int>("CrsId")
                        .HasColumnType("int")
                        .HasColumnName("Crs_id");

                    b.Property<int?>("TotalGrade")
                        .HasColumnType("int")
                        .HasColumnName("Total_Grade");

                    b.HasKey("StdId", "CrsId");

                    b.HasIndex("CrsId");

                    b.ToTable("Student_Courses", (string)null);
                });

            modelBuilder.Entity("exam_app.Models.StudentExam", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("Student_id");

                    b.Property<int>("ExamId")
                        .HasColumnType("int")
                        .HasColumnName("Exam_id");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "ExamId")
                        .HasName("PK_Student_Exames");

                    b.HasIndex("ExamId");

                    b.ToTable("Student_Exams", (string)null);
                });

            modelBuilder.Entity("exam_app.Models.StudentsInTrack", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("Student_Id");

                    b.Property<int>("TrackId")
                        .HasColumnType("int")
                        .HasColumnName("Track_id");

                    b.Property<int>("Durations")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "TrackId");

                    b.HasIndex("TrackId");

                    b.ToTable("Students_InTracks", (string)null);
                });

            modelBuilder.Entity("exam_app.Models.Topic", b =>
                {
                    b.Property<int>("TopicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Topic_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TopicId"));

                    b.Property<string>("TopicName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Topic_name");

                    b.HasKey("TopicId");

                    b.ToTable("Topic", (string)null);
                });

            modelBuilder.Entity("exam_app.Models.Track", b =>
                {
                    b.Property<int>("TrId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Tr_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrId"));

                    b.Property<string>("TrName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Tr_name");

                    b.HasKey("TrId");

                    b.ToTable("Track", (string)null);
                });

            modelBuilder.Entity("BranchesTrack", b =>
                {
                    b.HasOne("exam_app.Models.Branch", null)
                        .WithMany()
                        .HasForeignKey("BranchId")
                        .IsRequired()
                        .HasConstraintName("FK_BranchesTracks_Branch");

                    b.HasOne("exam_app.Models.Track", null)
                        .WithMany()
                        .HasForeignKey("TrackId")
                        .IsRequired()
                        .HasConstraintName("FK_BranchesTracks_Track");
                });

            modelBuilder.Entity("CrsTrack", b =>
                {
                    b.HasOne("exam_app.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CrsId")
                        .IsRequired()
                        .HasConstraintName("FK_Crs_Track_Course");

                    b.HasOne("exam_app.Models.Track", null)
                        .WithMany()
                        .HasForeignKey("TrId")
                        .IsRequired()
                        .HasConstraintName("FK_Crs_Track_Track");
                });

            modelBuilder.Entity("ExamQuestion", b =>
                {
                    b.HasOne("exam_app.Models.Exam", null)
                        .WithMany()
                        .HasForeignKey("ExId")
                        .IsRequired()
                        .HasConstraintName("FK_Exam_Question_Exam");

                    b.HasOne("exam_app.Models.Question", null)
                        .WithMany()
                        .HasForeignKey("QId")
                        .IsRequired()
                        .HasConstraintName("FK_Exam_Question_Question");
                });

            modelBuilder.Entity("exam_app.Models.Course", b =>
                {
                    b.HasOne("exam_app.Models.Topic", "Topic")
                        .WithMany("Courses")
                        .HasForeignKey("TopicId")
                        .HasConstraintName("FK_Course_Topic");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("exam_app.Models.Exam", b =>
                {
                    b.HasOne("exam_app.Models.Course", "Course")
                        .WithMany("Exams")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK_Exam_Course");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("exam_app.Models.ExamStdQuestion", b =>
                {
                    b.HasOne("exam_app.Models.Exam", "Ex")
                        .WithMany("ExamStdQuestions")
                        .HasForeignKey("ExId")
                        .IsRequired()
                        .HasConstraintName("FK_Exam_Std_Question_Exam");

                    b.HasOne("exam_app.Models.Question", "QIdNavigation")
                        .WithMany("ExamStdQuestions")
                        .HasForeignKey("QId")
                        .IsRequired()
                        .HasConstraintName("FK_Exam_Std_Question_Question");

                    b.HasOne("exam_app.Models.Student", "St")
                        .WithMany("ExamStdQuestions")
                        .HasForeignKey("StId")
                        .IsRequired()
                        .HasConstraintName("FK_Exam_Std_Question_Student");

                    b.Navigation("Ex");

                    b.Navigation("QIdNavigation");

                    b.Navigation("St");
                });

            modelBuilder.Entity("exam_app.Models.InsCourse", b =>
                {
                    b.HasOne("exam_app.Models.Course", "Crs")
                        .WithMany("InsCourses")
                        .HasForeignKey("CrsId")
                        .IsRequired()
                        .HasConstraintName("FK_Ins_Courses_Course");

                    b.HasOne("exam_app.Models.Instructor", "Ins")
                        .WithMany("InsCourses")
                        .HasForeignKey("InsId")
                        .IsRequired()
                        .HasConstraintName("FK_Ins_Courses_Instructor");

                    b.Navigation("Crs");

                    b.Navigation("Ins");
                });

            modelBuilder.Entity("exam_app.Models.Instructor", b =>
                {
                    b.HasOne("exam_app.Models.LoginAccount", "User")
                        .WithMany("Instructors")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Instructor_Login_Accounts");

                    b.Navigation("User");
                });

            modelBuilder.Entity("exam_app.Models.Question", b =>
                {
                    b.HasOne("exam_app.Models.Course", "Course")
                        .WithMany("Questions")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK_Question_Course");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("exam_app.Models.QuestionChoice", b =>
                {
                    b.HasOne("exam_app.Models.Question", "QIdNavigation")
                        .WithMany("QuestionChoices")
                        .HasForeignKey("QId")
                        .IsRequired()
                        .HasConstraintName("FK_Question_choices_Question");

                    b.Navigation("QIdNavigation");
                });

            modelBuilder.Entity("exam_app.Models.Student", b =>
                {
                    b.HasOne("exam_app.Models.LoginAccount", "User")
                        .WithMany("Students")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Student_Login_Accounts");

                    b.Navigation("User");
                });

            modelBuilder.Entity("exam_app.Models.StudentCourse", b =>
                {
                    b.HasOne("exam_app.Models.Course", "Crs")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CrsId")
                        .IsRequired()
                        .HasConstraintName("FK_Student_Courses_Course");

                    b.HasOne("exam_app.Models.Student", "Std")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StdId")
                        .IsRequired()
                        .HasConstraintName("FK_Student_Courses_Student");

                    b.Navigation("Crs");

                    b.Navigation("Std");
                });

            modelBuilder.Entity("exam_app.Models.StudentExam", b =>
                {
                    b.HasOne("exam_app.Models.Exam", "Exam")
                        .WithMany("StudentExams")
                        .HasForeignKey("ExamId")
                        .IsRequired()
                        .HasConstraintName("FK_Student_Exames_Exam");

                    b.HasOne("exam_app.Models.Student", "Student")
                        .WithMany("StudentExams")
                        .HasForeignKey("StudentId")
                        .IsRequired()
                        .HasConstraintName("FK_Student_Exames_Student");

                    b.Navigation("Exam");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("exam_app.Models.StudentsInTrack", b =>
                {
                    b.HasOne("exam_app.Models.Student", "Student")
                        .WithMany("StudentsInTracks")
                        .HasForeignKey("StudentId")
                        .IsRequired()
                        .HasConstraintName("FK_Students_InTracks_Student");

                    b.HasOne("exam_app.Models.Track", "Track")
                        .WithMany("StudentsInTracks")
                        .HasForeignKey("TrackId")
                        .IsRequired()
                        .HasConstraintName("FK_Students_InTracks_Track");

                    b.Navigation("Student");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("exam_app.Models.Course", b =>
                {
                    b.Navigation("Exams");

                    b.Navigation("InsCourses");

                    b.Navigation("Questions");

                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("exam_app.Models.Exam", b =>
                {
                    b.Navigation("ExamStdQuestions");

                    b.Navigation("StudentExams");
                });

            modelBuilder.Entity("exam_app.Models.Instructor", b =>
                {
                    b.Navigation("InsCourses");
                });

            modelBuilder.Entity("exam_app.Models.LoginAccount", b =>
                {
                    b.Navigation("Instructors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("exam_app.Models.Question", b =>
                {
                    b.Navigation("ExamStdQuestions");

                    b.Navigation("QuestionChoices");
                });

            modelBuilder.Entity("exam_app.Models.Student", b =>
                {
                    b.Navigation("ExamStdQuestions");

                    b.Navigation("StudentCourses");

                    b.Navigation("StudentExams");

                    b.Navigation("StudentsInTracks");
                });

            modelBuilder.Entity("exam_app.Models.Topic", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("exam_app.Models.Track", b =>
                {
                    b.Navigation("StudentsInTracks");
                });
#pragma warning restore 612, 618
        }
    }
}
