# 🎓StudentTrack – Role-Based Student Information System

A secure and centralized Student & Teacher Information Management System built using ASP.NET Web Forms, C#, and SQL Server.
StudentTrack enables educational institutions to manage academic records digitally with clear role-based privileges for Admin, Teacher, and Student.

🚀 Project Overview

StudentTrack modernizes traditional student record handling by replacing paperwork with a digital, accurate, and secure data management system.

The system ensures:

✔ Role-based authentication

✔ Centralized student/teacher data

✔ Secure login access

✔ Reduced administrative workload

✔ Effortless tracking of academic information

🔐 User Roles & Permissions
Role	Permissions
Admin	Manage Teachers, Manage Students, Create/Update/Delete Records, Generate Reports, Maintain System Security
Teacher	Manage Student Details for Assigned Classes, View Class Information
Student	View Their Own Academic Details & Personal Profile Only
🛠️ Technologies Used
Layer	Technology
Frontend	ASP.NET Web Forms (.aspx), HTML, CSS
Backend	C#
Database	Microsoft SQL Server
Connectivity	ADO.NET
IDE	Visual Studio
Framework	.NET Framework
📌 Features
🔑 Authentication

Secure login system

Role-based redirection to respective dashboards

🖥 Admin Dashboard

Add / Edit / Delete Teachers

Add / Edit / Delete Students

View performance and student reports

Full control over system data

👨‍🏫 Teacher Dashboard

Manage student details and academic records

Update student information for assigned classes

👨‍🎓 Student Panel

View personal profile

Access academic performance details securely

📂 Project Structure
StudentTrack/
│
├── Admin/
│   ├── AdminDashboard.aspx
│   ├── ManageTeachers.aspx
│   └── ManageStudents.aspx
│
├── Teacher/
│   ├── TeacherDashboard.aspx
│   └── ManageClassStudents.aspx
│
├── Student/
│   └── StudentProfile.aspx
│
├── Database/
│   └── StudentTrackDb.sql
│
├── Login.aspx
└── Web.config

🗄️ Database Schema
Tables

Admin

Teacher

Student

Class

LoginMaster (stores credentials and role type)

Sample Columns
Column	Description
UserId	Unique login ID
Role	Admin / Teacher / Student
Name	Full Name
Class	Assigned class (for students)
Contact	Email / Phone
Password	Encrypted password
📸 Screenshots (Optional to Add)

Login Page

Admin Dashboard

Teacher Dashboard

Student Profile View

(You can upload UI images and link here when ready)

▶️ How to Run the Project

Open the .sln file in Visual Studio

Import the SQL database:

Open SQL Server Management Studio

Restore/Execute the StudentTrackDb.sql file

Update your Web.config connection string:

<connectionStrings>
  <add name="con" connectionString="Data Source=YOUR_SERVER;Initial Catalog=StudentTrackDb;Integrated Security=True" />
</connectionStrings>


Run the project using IIS Express

📊 Future Enhancements

📌 Attendance Management Module

📌 SMS/Email Notification to Parents

📌 Online Assignment & Marking System

📌 Result Generation & Report Cards

📌 Cloud Deployment (Azure)

🤝 Contributing

Contributions are welcome!
Feel free to fork the project, open issues, or submit pull requests with improvements.

📬 Contact

📌 Developer: Sushil Kumar
🔗 GitHub: https://github.com/sushilkumar121225

💼 LinkedIn: https://www.linkedin.com/in/sushil-kumar-471614289/

⭐ If you like this project, don’t forget to Star the repository!

  -----------------------------------------------------------------------------------------------------------
                                                Follow Me
-----------------------------------------------------------------------------------------------------------
🤝 Contributing
Feel free to fork the repository, improve the project, and submit a pull request.

🔗 Connect With Me
If you want to see more Major and Minor projects, tutorials, and updates, follow me on:
GitHub: https://github.com/sushilkumar121225
LinkedIn: https://www.linkedin.com/in/sushil-kumar-471614289/

🙌 Thank You for Visiting This Repository!
Happy Learning and Keep Exploring 🚀
