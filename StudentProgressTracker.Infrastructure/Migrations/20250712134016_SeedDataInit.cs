using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentProgressTracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3253), "Covers fundamental concepts of algebra, geometry, and arithmetic.", true, "Mathematics" },
                    { 2, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3257), "An introduction to biology, chemistry, and physics.", true, "Science" },
                    { 3, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3259), "Focuses on Arabic grammar, literature, and composition.", true, "Arabic Language" },
                    { 4, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3260), "Develops skills in reading, writing, and speaking English.", true, "English Language" },
                    { 5, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3262), "A study of major world events and civilizations.", true, "History" },
                    { 6, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3264), "Learning the basics of programming and computational thinking.", false, "Computer Science" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "EnrollmentDate", "FirstName", "Grade", "LastActivityDate", "LastName", "PasswordHash", "Role", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3026), "teacher1@example.com", null, "Ali", null, null, "Hassan", "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==", "Teacher", new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3027) },
                    { 2, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3037), "teacher2@example.com", null, "Sara", null, null, "Ibrahim", "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==", "Teacher", new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3037) },
                    { 3, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3045), "student1@example.com", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omar", 3, null, "Nabil", "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==", "Student", new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3045) },
                    { 4, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3048), "student2@example.com", new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laila", 4, null, "Adel", "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==", "Student", new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3048) },
                    { 5, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3051), "student3@example.com", new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Youssef", 5, null, "Khaled", "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==", "Student", new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3051) },
                    { 6, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3055), "student4@example.com", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fatima", 3, null, "Gamal", "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==", "Student", new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3056) },
                    { 7, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3058), "student5@example.com", new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karim", 4, null, "Samir", "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==", "Student", new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3059) },
                    { 8, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3061), "student6@example.com", new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hania", 5, null, "Tarek", "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==", "Student", new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3061) },
                    { 9, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3065), "student7@example.com", new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziad", 6, null, "Ashraf", "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==", "Student", new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3065) },
                    { 10, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3113), "student8@example.com", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salma", 2, null, "Ehab", "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==", "Student", new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3113) },
                    { 11, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3116), "student9@example.com", new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahmed", 1, null, "Said", "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==", "Student", new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3116) },
                    { 12, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3119), "student10@example.com", new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nour", 4, null, "Walid", "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==", "Student", new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3119) },
                    { 13, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3122), "student11@example.com", new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mohamed", 5, null, "Sherif", "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==", "Student", new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3122) },
                    { 14, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3125), "student12@example.com", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jana", 3, null, "Hesham", "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==", "Student", new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3125) },
                    { 15, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3127), "student13@example.com", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam", 2, null, "Medhat", "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==", "Student", new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3128) },
                    { 16, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3130), "student14@example.com", new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariam", 6, null, "Fares", "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==", "Student", new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3131) },
                    { 17, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3133), "student15@example.com", new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ibrahim", 1, null, "Amr", "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==", "Student", new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3133) },
                    { 18, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3137), "student16@example.com", new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Farida", 5, null, "Hossam", "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==", "Student", new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3137) },
                    { 19, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3140), "student17@example.com", new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mostafa", 4, null, "Maher", "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==", "Student", new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3140) },
                    { 20, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3143), "student18@example.com", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hana", 2, null, "Ismail", "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==", "Student", new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3143) },
                    { 21, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3146), "student19@example.com", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yassin", 3, null, "Tamer", "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==", "Student", new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3146) },
                    { 22, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3149), "student20@example.com", new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malak", 1, null, "Wael", "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==", "Student", new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3149) }
                });

            migrationBuilder.InsertData(
                table: "ActivityLogs",
                columns: new[] { "Id", "ActivityDate", "ActivityType", "CreatedAt", "Description", "Duration", "StudentId", "SubjectId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), "Video Lecture", new DateTime(2025, 7, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), "Watched 'Introduction to Algebra' video.", new TimeSpan(0, 0, 30, 0, 0), 3, 1 },
                    { 2, new DateTime(2025, 7, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), "Practice Problems", new DateTime(2025, 7, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), "Completed practice set 1 for equations.", new TimeSpan(0, 1, 0, 0, 0), 3, 1 },
                    { 3, new DateTime(2025, 7, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Reading", new DateTime(2025, 7, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Read Chapter 3 of Arabic grammar textbook.", new TimeSpan(0, 0, 45, 0, 0), 3, 3 },
                    { 4, new DateTime(2025, 7, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), "Online Quiz", new DateTime(2025, 7, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), "Attempted photosynthesis quiz.", new TimeSpan(0, 0, 20, 0, 0), 4, 2 },
                    { 5, new DateTime(2025, 7, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "Virtual Lab", new DateTime(2025, 7, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "Simulated chemical reaction experiment.", new TimeSpan(0, 1, 0, 0, 0), 4, 2 },
                    { 6, new DateTime(2025, 7, 12, 13, 0, 0, 0, DateTimeKind.Unspecified), "Essay Writing", new DateTime(2025, 7, 12, 13, 0, 0, 0, DateTimeKind.Unspecified), "Drafted introductory paragraph for literature essay.", new TimeSpan(0, 1, 15, 0, 0), 5, 4 },
                    { 7, new DateTime(2025, 7, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "Grammar Practice", new DateTime(2025, 7, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), "Completed exercises on verb tenses.", new TimeSpan(0, 0, 30, 0, 0), 5, 4 },
                    { 8, new DateTime(2025, 7, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), "Review Session", new DateTime(2025, 7, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), "Attended online math review session.", new TimeSpan(0, 1, 30, 0, 0), 6, 1 },
                    { 9, new DateTime(2025, 7, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "Research", new DateTime(2025, 7, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), "Researched climate change impacts for project.", new TimeSpan(0, 2, 0, 0, 0), 7, 2 },
                    { 10, new DateTime(2025, 7, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), "Vocabulary Practice", new DateTime(2025, 7, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), "Learned new Arabic vocabulary words using flashcards.", new TimeSpan(0, 0, 25, 0, 0), 9, 3 },
                    { 11, new DateTime(2025, 7, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), "Documentary Watching", new DateTime(2025, 7, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), "Watched documentary on ancient Egypt.", new TimeSpan(0, 1, 45, 0, 0), 10, 5 },
                    { 12, new DateTime(2025, 7, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), "Note Taking", new DateTime(2025, 7, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), "Reviewed history notes from last week's lecture.", new TimeSpan(0, 0, 40, 0, 0), 10, 5 },
                    { 13, new DateTime(2025, 7, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), "Problem Solving", new DateTime(2025, 7, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), "Worked on advanced calculus problems.", new TimeSpan(0, 1, 30, 0, 0), 12, 1 },
                    { 14, new DateTime(2025, 7, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), "Study Break", new DateTime(2025, 7, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), "Took a short break from studying.", new TimeSpan(0, 0, 15, 0, 0), 13, null },
                    { 15, new DateTime(2025, 7, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), "Creative Writing", new DateTime(2025, 7, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), "Wrote a short story in Arabic.", new TimeSpan(0, 1, 0, 0, 0), 14, 3 },
                    { 16, new DateTime(2025, 7, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "Reading", new DateTime(2025, 7, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "Read textbook on the Roman Empire.", new TimeSpan(0, 1, 10, 0, 0), 16, 5 }
                });

            migrationBuilder.InsertData(
                table: "Assessments",
                columns: new[] { "Id", "CompletedAt", "CreatedAt", "DueDate", "IsCompleted", "MaxScore", "Score", "StudentId", "SubjectId", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), true, 100.00m, 85.00m, 3, 1, "Algebra Midterm Exam", "Test", new DateTime(2025, 6, 15, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2025, 7, 10, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 10, 23, 59, 59, 0, DateTimeKind.Unspecified), true, 30.00m, 28.00m, 3, 1, "Geometry Homework 5", "Assignment", new DateTime(2025, 7, 10, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, new DateTime(2025, 7, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), false, 20.00m, null, 3, 1, "Fractions Quiz", "Quiz", new DateTime(2025, 7, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2025, 5, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 26, 23, 59, 59, 0, DateTimeKind.Unspecified), true, 100.00m, 92.50m, 4, 2, "Photosynthesis Lab Report", "Project", new DateTime(2025, 5, 25, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2025, 6, 30, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 20.00m, 15.00m, 4, 2, "Chemical Reactions Quiz", "Quiz", new DateTime(2025, 6, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, new DateTime(2025, 6, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 100.00m, null, 4, 2, "Physics Principles Test", "Test", new DateTime(2025, 6, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2025, 7, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 5, 23, 59, 59, 0, DateTimeKind.Unspecified), true, 50.00m, 45.00m, 5, 4, "Essay: My Favorite Book", "Assignment", new DateTime(2025, 7, 5, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2025, 6, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 28, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 20.00m, 18.00m, 5, 4, "Grammar Quiz 2", "Quiz", new DateTime(2025, 6, 1, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2025, 6, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 15, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), true, 100.00m, 70.00m, 6, 1, "Basic Arithmetic Test", "Test", new DateTime(2025, 6, 1, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2025, 7, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 9, 23, 59, 59, 0, DateTimeKind.Unspecified), true, 100.00m, 95.00m, 7, 2, "Ecosystems Project", "Project", new DateTime(2025, 7, 8, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2025, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 20.00m, 10.00m, 8, 4, "Reading Comprehension Quiz", "Quiz", new DateTime(2025, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2025, 6, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), true, 100.00m, 75.00m, 9, 3, "Arabic Grammar Midterm", "Test", new DateTime(2025, 6, 10, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, null, new DateTime(2025, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 25, 23, 59, 59, 0, DateTimeKind.Unspecified), false, 100.00m, null, 10, 5, "World War II Presentation", "Project", new DateTime(2025, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2025, 7, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 8, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 11, 23, 59, 59, 0, DateTimeKind.Unspecified), true, 100.00m, 98.00m, 12, 1, "Calculus Practice Set", "Assignment", new DateTime(2025, 7, 11, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2025, 6, 28, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 28, 23, 59, 59, 0, DateTimeKind.Unspecified), true, 80.00m, 70.00m, 14, 3, "Poetry Analysis", "Assignment", new DateTime(2025, 6, 28, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, null, new DateTime(2025, 7, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 25.00m, null, 15, 2, "Biology Chapter Quiz", "Quiz", new DateTime(2025, 7, 9, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2025, 5, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), true, 100.00m, 95.00m, 16, 5, "Ancient Civilizations Test", "Test", new DateTime(2025, 5, 10, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, null, new DateTime(2025, 6, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 5, 23, 59, 59, 0, DateTimeKind.Unspecified), false, 75.00m, null, 19, 4, "Short Story Creative Writing", "Project", new DateTime(2025, 6, 15, 10, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "StudentProgress",
                columns: new[] { "Id", "CompletedAssignments", "CompletionPercentage", "CreatedAt", "LastActivity", "PerformanceScore", "StudentId", "SubjectId", "TimeSpent", "TotalAssignments", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 15, 75.50m, new DateTime(2025, 4, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3384), new DateTime(2025, 7, 7, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3380), 82.00m, 3, 1, new TimeSpan(1, 21, 0, 0, 0), 20, new DateTime(2025, 7, 11, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3388) },
                    { 2, 18, 90.00m, new DateTime(2025, 4, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3393), new DateTime(2025, 7, 10, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3392), 95.00m, 3, 3, new TimeSpan(2, 12, 0, 0, 0), 18, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3393) },
                    { 3, 10, 60.25m, new DateTime(2025, 1, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3396), new DateTime(2025, 7, 2, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3396), 70.50m, 4, 2, new TimeSpan(1, 6, 0, 0, 0), 20, new DateTime(2025, 7, 9, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3397) },
                    { 4, 12, 85.00m, new DateTime(2025, 3, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3400), new DateTime(2025, 7, 11, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3399), 88.00m, 5, 4, new TimeSpan(2, 2, 0, 0, 0), 15, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3400) },
                    { 5, 8, 50.00m, new DateTime(2025, 5, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3403), new DateTime(2025, 7, 5, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3402), 65.00m, 6, 1, new TimeSpan(1, 1, 0, 0, 0), 16, new DateTime(2025, 7, 10, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3403) },
                    { 6, 14, 70.00m, new DateTime(2025, 5, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3407), new DateTime(2025, 7, 9, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3406), 75.00m, 6, 3, new TimeSpan(1, 16, 0, 0, 0), 20, new DateTime(2025, 7, 11, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3407) },
                    { 7, 19, 95.00m, new DateTime(2025, 2, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3412), new DateTime(2025, 7, 12, 1, 40, 16, 201, DateTimeKind.Utc).AddTicks(3410), 92.00m, 7, 2, new TimeSpan(2, 22, 0, 0, 0), 20, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3412) },
                    { 8, 6, 40.00m, new DateTime(2024, 12, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3415), new DateTime(2025, 6, 27, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3415), 55.00m, 8, 4, new TimeSpan(0, 20, 0, 0, 0), 15, new DateTime(2025, 7, 7, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3416) },
                    { 9, 17, 80.00m, new DateTime(2025, 3, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3418), new DateTime(2025, 7, 8, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3418), 88.00m, 9, 1, new TimeSpan(2, 7, 0, 0, 0), 20, new DateTime(2025, 7, 11, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3419) },
                    { 10, 13, 65.00m, new DateTime(2025, 3, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3423), new DateTime(2025, 7, 6, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3422), 72.00m, 9, 3, new TimeSpan(1, 11, 0, 0, 0), 20, new DateTime(2025, 7, 10, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3423) },
                    { 11, 16, 78.00m, new DateTime(2025, 4, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3426), new DateTime(2025, 7, 10, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3425), 85.00m, 10, 2, new TimeSpan(2, 0, 0, 0, 0), 20, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3426) },
                    { 12, 10, 92.00m, new DateTime(2025, 4, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3429), new DateTime(2025, 7, 11, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3429), 90.00m, 10, 5, new TimeSpan(2, 7, 0, 0, 0), 10, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3430) },
                    { 13, 3, 20.00m, new DateTime(2025, 6, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3432), new DateTime(2025, 6, 22, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3432), 40.00m, 11, 4, new TimeSpan(0, 10, 0, 0, 0), 15, new DateTime(2025, 7, 2, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3433) },
                    { 14, 18, 88.00m, new DateTime(2025, 2, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3436), new DateTime(2025, 7, 11, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3435), 91.00m, 12, 1, new TimeSpan(2, 12, 0, 0, 0), 20, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3436) },
                    { 15, 1, 10.00m, new DateTime(2025, 5, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3439), new DateTime(2025, 6, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3438), 30.00m, 13, 6, new TimeSpan(0, 5, 0, 0, 0), 10, new DateTime(2025, 6, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3440) },
                    { 16, 14, 70.00m, new DateTime(2025, 4, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3442), new DateTime(2025, 7, 9, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3442), 78.00m, 14, 3, new TimeSpan(1, 18, 0, 0, 0), 20, new DateTime(2025, 7, 11, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3443) },
                    { 17, 9, 55.00m, new DateTime(2025, 6, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3446), new DateTime(2025, 7, 4, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3445), 62.00m, 15, 2, new TimeSpan(1, 4, 0, 0, 0), 20, new DateTime(2025, 7, 8, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3446) },
                    { 18, 19, 98.00m, new DateTime(2025, 1, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3449), new DateTime(2025, 7, 11, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3449), 99.00m, 16, 5, new TimeSpan(3, 3, 0, 0, 0), 19, new DateTime(2025, 7, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3450) },
                    { 19, 5, 35.00m, new DateTime(2025, 6, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3453), new DateTime(2025, 6, 30, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3452), 48.00m, 17, 4, new TimeSpan(0, 18, 0, 0, 0), 15, new DateTime(2025, 7, 7, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3453) },
                    { 20, 14, 72.00m, new DateTime(2025, 3, 12, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3456), new DateTime(2025, 7, 6, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3455), 79.00m, 18, 1, new TimeSpan(1, 16, 0, 0, 0), 20, new DateTime(2025, 7, 10, 13, 40, 16, 201, DateTimeKind.Utc).AddTicks(3456) }
                });

            migrationBuilder.InsertData(
                table: "TeacherStudents",
                columns: new[] { "Id", "AssignedDate", "IsActive", "StudentId", "SubjectId", "TeacherId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, 1, 1 },
                    { 2, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6, 1, 1 },
                    { 3, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 9, 1, 1 },
                    { 4, new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4, 2, 1 },
                    { 5, new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 7, 2, 1 },
                    { 6, new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 10, 2, 1 },
                    { 7, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, 3, 2 },
                    { 8, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6, 3, 2 },
                    { 9, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 9, 3, 2 },
                    { 10, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 5, 4, 2 },
                    { 11, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8, 4, 2 },
                    { 12, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 11, 4, 2 },
                    { 13, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 13, 6, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivityLogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ActivityLogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ActivityLogs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ActivityLogs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ActivityLogs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ActivityLogs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ActivityLogs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ActivityLogs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ActivityLogs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ActivityLogs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ActivityLogs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ActivityLogs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ActivityLogs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ActivityLogs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ActivityLogs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ActivityLogs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "StudentProgress",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentProgress",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudentProgress",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentProgress",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StudentProgress",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StudentProgress",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StudentProgress",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StudentProgress",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StudentProgress",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StudentProgress",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StudentProgress",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StudentProgress",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "StudentProgress",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "StudentProgress",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "StudentProgress",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "StudentProgress",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "StudentProgress",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "StudentProgress",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "StudentProgress",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "StudentProgress",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TeacherStudents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TeacherStudents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TeacherStudents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TeacherStudents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TeacherStudents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TeacherStudents",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TeacherStudents",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TeacherStudents",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TeacherStudents",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TeacherStudents",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TeacherStudents",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TeacherStudents",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TeacherStudents",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);
        }
    }
}
