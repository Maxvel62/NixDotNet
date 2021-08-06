﻿// <auto-generated />
using System;
using FitnessSuperiorMvc.DA.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FitnessSuperiorMvc.DA.Migrations
{
    [DbContext(typeof(FitnessAppContext))]
    partial class FitnessAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FitnessSuperiorMvc.DA.Entities.Interaction.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("NutritionistId")
                        .HasColumnType("int");

                    b.Property<int?>("TrainerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NutritionistId");

                    b.HasIndex("TrainerId");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.DA.Entities.Nutrition.NutritionProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("NutritionistId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NutritionistId");

                    b.HasIndex("UserId");

                    b.ToTable("NutritionProgram");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.DA.Entities.People.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("IdentityId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.DA.Entities.People.Nutritionist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("AgeSpecialization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Education")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkExperience")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Nutritionists");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.DA.Entities.People.Trainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Education")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkExperience")
                        .HasColumnType("int");

                    b.Property<string>("WorkWithGender")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.DA.Entities.People.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("IdentityId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UsersDto");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.DA.Entities.Sport.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MuscleGroups")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YoutubeUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.DA.Entities.Sport.TrainingProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("TrainerId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrainerId");

                    b.HasIndex("UserId");

                    b.ToTable("TrainingProgram");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.DA.Entities.Interaction.Feedback", b =>
                {
                    b.HasOne("FitnessSuperiorMvc.DA.Entities.People.Nutritionist", null)
                        .WithMany("Feedback")
                        .HasForeignKey("NutritionistId");

                    b.HasOne("FitnessSuperiorMvc.DA.Entities.People.Trainer", null)
                        .WithMany("Feedback")
                        .HasForeignKey("TrainerId");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.DA.Entities.Nutrition.NutritionProgram", b =>
                {
                    b.HasOne("FitnessSuperiorMvc.DA.Entities.People.Nutritionist", null)
                        .WithMany("NutritionPrograms")
                        .HasForeignKey("NutritionistId");

                    b.HasOne("FitnessSuperiorMvc.DA.Entities.People.User", null)
                        .WithMany("NutritionPrograms")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.DA.Entities.Sport.TrainingProgram", b =>
                {
                    b.HasOne("FitnessSuperiorMvc.DA.Entities.People.Trainer", null)
                        .WithMany("TrainingPrograms")
                        .HasForeignKey("TrainerId");

                    b.HasOne("FitnessSuperiorMvc.DA.Entities.People.User", null)
                        .WithMany("TrainingPrograms")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.DA.Entities.People.Nutritionist", b =>
                {
                    b.Navigation("Feedback");

                    b.Navigation("NutritionPrograms");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.DA.Entities.People.Trainer", b =>
                {
                    b.Navigation("Feedback");

                    b.Navigation("TrainingPrograms");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.DA.Entities.People.User", b =>
                {
                    b.Navigation("NutritionPrograms");

                    b.Navigation("TrainingPrograms");
                });
#pragma warning restore 612, 618
        }
    }
}
