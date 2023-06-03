﻿// <auto-generated />
using System;
using Elearn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Elearn.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230516162131_CreateTableNewsImagesAuthors")]
    partial class CreateTableNewsImagesAuthors
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Elearn.Models.Course", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("CourseAuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("CourseAuthorId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Elearn.Models.CourseAuthor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("CourseAuthors");
                });

            modelBuilder.Entity("Elearn.Models.CourseAuthorImage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("CourseAuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("CourseAuthorId");

                    b.ToTable("CourseAuthorImages");
                });

            modelBuilder.Entity("Elearn.Models.CourseImage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Images")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseImages");
                });

            modelBuilder.Entity("Elearn.Models.Event", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventDay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventMonth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Subtitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Elearn.Models.FeaturedCourse", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FeaturedCourseAuthorId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("FeaturedCourseAuthorId");

                    b.ToTable("FeaturedCourses");
                });

            modelBuilder.Entity("Elearn.Models.FeaturedCourseAuthor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("FeaturedCoursesAuthor");
                });

            modelBuilder.Entity("Elearn.Models.FeaturedCourseImage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FeaturedCourseId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("FeaturedCourseId");

                    b.ToTable("FeaturedCoursesImage");
                });

            modelBuilder.Entity("Elearn.Models.Milestone", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("Milestones");
                });

            modelBuilder.Entity("Elearn.Models.News", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("NewsAuthorid")
                        .HasColumnType("int");

                    b.Property<string>("PostTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("NewsAuthorid");

                    b.ToTable("News");
                });

            modelBuilder.Entity("Elearn.Models.NewsAuthor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("NewsAuthors");
                });

            modelBuilder.Entity("Elearn.Models.NewsImage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NewsId")
                        .HasColumnType("int");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("NewsId");

                    b.ToTable("NewsImages");
                });

            modelBuilder.Entity("Elearn.Models.Slider", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("Elearn.Models.Course", b =>
                {
                    b.HasOne("Elearn.Models.CourseAuthor", "CourseAuthor")
                        .WithMany("Courses")
                        .HasForeignKey("CourseAuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseAuthor");
                });

            modelBuilder.Entity("Elearn.Models.CourseAuthorImage", b =>
                {
                    b.HasOne("Elearn.Models.CourseAuthor", "CourseAuthor")
                        .WithMany("CourseAuthorImages")
                        .HasForeignKey("CourseAuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseAuthor");
                });

            modelBuilder.Entity("Elearn.Models.CourseImage", b =>
                {
                    b.HasOne("Elearn.Models.Course", "Course")
                        .WithMany("CourseImages")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Elearn.Models.FeaturedCourse", b =>
                {
                    b.HasOne("Elearn.Models.FeaturedCourseAuthor", "featuredCourseAuthor")
                        .WithMany("FeaturedCourses")
                        .HasForeignKey("FeaturedCourseAuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("featuredCourseAuthor");
                });

            modelBuilder.Entity("Elearn.Models.FeaturedCourseImage", b =>
                {
                    b.HasOne("Elearn.Models.FeaturedCourse", "FeaturedCourse")
                        .WithMany("FeaturedCourseImages")
                        .HasForeignKey("FeaturedCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FeaturedCourse");
                });

            modelBuilder.Entity("Elearn.Models.News", b =>
                {
                    b.HasOne("Elearn.Models.NewsAuthor", "NewsAuthor")
                        .WithMany("News")
                        .HasForeignKey("NewsAuthorid");

                    b.Navigation("NewsAuthor");
                });

            modelBuilder.Entity("Elearn.Models.NewsImage", b =>
                {
                    b.HasOne("Elearn.Models.News", "News")
                        .WithMany("NewsImages")
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("News");
                });

            modelBuilder.Entity("Elearn.Models.Course", b =>
                {
                    b.Navigation("CourseImages");
                });

            modelBuilder.Entity("Elearn.Models.CourseAuthor", b =>
                {
                    b.Navigation("CourseAuthorImages");

                    b.Navigation("Courses");
                });

            modelBuilder.Entity("Elearn.Models.FeaturedCourse", b =>
                {
                    b.Navigation("FeaturedCourseImages");
                });

            modelBuilder.Entity("Elearn.Models.FeaturedCourseAuthor", b =>
                {
                    b.Navigation("FeaturedCourses");
                });

            modelBuilder.Entity("Elearn.Models.News", b =>
                {
                    b.Navigation("NewsImages");
                });

            modelBuilder.Entity("Elearn.Models.NewsAuthor", b =>
                {
                    b.Navigation("News");
                });
#pragma warning restore 612, 618
        }
    }
}
