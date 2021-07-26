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

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.BusinessModels.Services.Community.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NutritionistDtoId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrainingProgramDtoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NutritionistDtoId");

                    b.HasIndex("TrainingProgramDtoId");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.People.Staff.ManagerDto", b =>
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

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.People.Staff.NutritionistDto", b =>
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

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.People.Staff.TrainerDto", b =>
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

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.People.Users.UserDto", b =>
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

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.Services.Nutrition.FoodDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BeneficialFeatures")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Calories")
                        .HasColumnType("float");

                    b.Property<int?>("MealPlanDtoId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MealPlanDtoId");

                    b.ToTable("FoodDto");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.Services.Nutrition.MealPlanDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Calories")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NutritionProgramDtoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NutritionProgramDtoId");

                    b.ToTable("MealPlanDto");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.Services.Nutrition.NutritionProgramDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NutritionistDtoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("TypeOfDiet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserDtoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NutritionistDtoId");

                    b.HasIndex("UserDtoId");

                    b.ToTable("NutritionPrograms");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.Services.Sport.ExerciseDto", b =>
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

                    b.Property<int?>("SetOfExercisesDtoId")
                        .HasColumnType("int");

                    b.Property<string>("YoutubeUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SetOfExercisesDtoId");

                    b.ToTable("ExerciseDto");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.Services.Sport.SetOfExercisesDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MuscleGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrainingProgramDtoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("TrainingProgramDtoId");

                    b.ToTable("SetOfExercisesDto");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.Services.Sport.TrainingProgramDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgeRestriction")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("RequiredSkillLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrainerId")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfProgram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserDtoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrainerId");

                    b.HasIndex("UserDtoId");

                    b.ToTable("TrainingPrograms");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Services.AddingComplexes", b =>
                {
                    b.Property<int>("AddingComplexesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SetOfExercisesDtoId")
                        .HasColumnType("int");

                    b.Property<int>("TrainerDtoId")
                        .HasColumnType("int");

                    b.HasKey("AddingComplexesId");

                    b.HasIndex("SetOfExercisesDtoId");

                    b.HasIndex("TrainerDtoId");

                    b.ToTable("AddingComplexes");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Services.AddingExercises", b =>
                {
                    b.Property<int>("AddingExercisesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ExerciseDtoId")
                        .HasColumnType("int");

                    b.Property<int>("TrainerDtoId")
                        .HasColumnType("int");

                    b.HasKey("AddingExercisesId");

                    b.HasIndex("ExerciseDtoId");

                    b.HasIndex("TrainerDtoId");

                    b.ToTable("AddingExercises");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.BusinessModels.Services.Community.Feedback", b =>
                {
                    b.HasOne("FitnessSuperiorMvc.BLL.Dto.People.Staff.NutritionistDto", null)
                        .WithMany("Feedback")
                        .HasForeignKey("NutritionistDtoId");

                    b.HasOne("FitnessSuperiorMvc.BLL.Dto.Services.Sport.TrainingProgramDto", null)
                        .WithMany("Feedback")
                        .HasForeignKey("TrainingProgramDtoId");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.Services.Nutrition.FoodDto", b =>
                {
                    b.HasOne("FitnessSuperiorMvc.BLL.Dto.Services.Nutrition.MealPlanDto", null)
                        .WithMany("Food")
                        .HasForeignKey("MealPlanDtoId");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.Services.Nutrition.MealPlanDto", b =>
                {
                    b.HasOne("FitnessSuperiorMvc.BLL.Dto.Services.Nutrition.NutritionProgramDto", null)
                        .WithMany("MealPlans")
                        .HasForeignKey("NutritionProgramDtoId");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.Services.Nutrition.NutritionProgramDto", b =>
                {
                    b.HasOne("FitnessSuperiorMvc.BLL.Dto.People.Staff.NutritionistDto", null)
                        .WithMany("NutritionPrograms")
                        .HasForeignKey("NutritionistDtoId");

                    b.HasOne("FitnessSuperiorMvc.BLL.Dto.People.Users.UserDto", null)
                        .WithMany("NutritionPrograms")
                        .HasForeignKey("UserDtoId");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.Services.Sport.ExerciseDto", b =>
                {
                    b.HasOne("FitnessSuperiorMvc.BLL.Dto.Services.Sport.SetOfExercisesDto", null)
                        .WithMany("Exercises")
                        .HasForeignKey("SetOfExercisesDtoId");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.Services.Sport.SetOfExercisesDto", b =>
                {
                    b.HasOne("FitnessSuperiorMvc.BLL.Dto.People.Staff.TrainerDto", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("FitnessSuperiorMvc.BLL.Dto.Services.Sport.TrainingProgramDto", null)
                        .WithMany("SetsOfExercises")
                        .HasForeignKey("TrainingProgramDtoId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.Services.Sport.TrainingProgramDto", b =>
                {
                    b.HasOne("FitnessSuperiorMvc.BLL.Dto.People.Staff.TrainerDto", "Trainer")
                        .WithMany("TrainingPrograms")
                        .HasForeignKey("TrainerId");

                    b.HasOne("FitnessSuperiorMvc.BLL.Dto.People.Users.UserDto", null)
                        .WithMany("TrainingPrograms")
                        .HasForeignKey("UserDtoId");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Services.AddingComplexes", b =>
                {
                    b.HasOne("FitnessSuperiorMvc.BLL.Dto.Services.Sport.SetOfExercisesDto", "SetOfExercisesDto")
                        .WithMany()
                        .HasForeignKey("SetOfExercisesDtoId");

                    b.HasOne("FitnessSuperiorMvc.BLL.Dto.People.Staff.TrainerDto", "TrainerDto")
                        .WithMany("AddingComplexes")
                        .HasForeignKey("TrainerDtoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SetOfExercisesDto");

                    b.Navigation("TrainerDto");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Services.AddingExercises", b =>
                {
                    b.HasOne("FitnessSuperiorMvc.BLL.Dto.Services.Sport.ExerciseDto", "ExerciseDto")
                        .WithMany()
                        .HasForeignKey("ExerciseDtoId");

                    b.HasOne("FitnessSuperiorMvc.BLL.Dto.People.Staff.TrainerDto", "TrainerDto")
                        .WithMany("AddingExercises")
                        .HasForeignKey("TrainerDtoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExerciseDto");

                    b.Navigation("TrainerDto");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.People.Staff.NutritionistDto", b =>
                {
                    b.Navigation("Feedback");

                    b.Navigation("NutritionPrograms");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.People.Staff.TrainerDto", b =>
                {
                    b.Navigation("AddingComplexes");

                    b.Navigation("AddingExercises");

                    b.Navigation("TrainingPrograms");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.People.Users.UserDto", b =>
                {
                    b.Navigation("NutritionPrograms");

                    b.Navigation("TrainingPrograms");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.Services.Nutrition.MealPlanDto", b =>
                {
                    b.Navigation("Food");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.Services.Nutrition.NutritionProgramDto", b =>
                {
                    b.Navigation("MealPlans");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.Services.Sport.SetOfExercisesDto", b =>
                {
                    b.Navigation("Exercises");
                });

            modelBuilder.Entity("FitnessSuperiorMvc.BLL.Dto.Services.Sport.TrainingProgramDto", b =>
                {
                    b.Navigation("Feedback");

                    b.Navigation("SetsOfExercises");
                });
#pragma warning restore 612, 618
        }
    }
}