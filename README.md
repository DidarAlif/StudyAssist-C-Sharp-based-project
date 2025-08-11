# Study Assist 📚

Study Assist is a C# Windows Forms desktop application designed to streamline the administrative tasks of a study center or similar educational institution. It provides administrators with a user-friendly interface to manage staff, track attendance, schedule classes, and handle financial operations.

## ✨ Features

-   **Manager Management**: Easily create, view, edit, and delete manager records, including personal details, branch assignments, and salary information.
-   **Tutor Management**: Maintain a comprehensive database of tutors, with the ability to add, update, and remove their personal information, assigned subjects, and contact details.
-   **Attendance Tracking**: A dedicated module for taking and tracking tutor attendance, marking them as Present or Absent on specific dates.
-   **Schedule Management**: Create and manage class or event schedules by specifying a description, date, and duration.
-   **Salary Payment**: A system to process and record salary payments for managers, complete with a check to prevent duplicate payments for the same month.
-   **Dashboard**: A dynamic dashboard that provides a quick overview of key metrics, such as the total count of managers, tutors, schedules, and the cumulative salary paid.
-   **Secure Login**: A basic login system to restrict access to authorized users.

## 🛠️ Technologies Used

-   **Frontend**: C# with Windows Forms
-   **Database**: SQL Server
-   **Data Access**: ADO.NET for direct database interaction

## 🚀 Getting Started

### Database Setup

The application connects to a SQL Server database. The connection string used is:

`Data Source=ALIFS-STATION\SQLEXPRESS;Initial Catalog=StudyAssistDb;Persist Security Info=True;User ID=sa;Password=alif123`

To set up the database:
1.  Ensure you have a SQL Server instance running.
2.  Create a new database named `StudyAssistDb`.
3.  Manually create the necessary tables (`ManagerTbl`, `TtrTbl`, `AttnTbl`, `SdlTbl`, `SlryTbl`) with columns that match the data being saved and retrieved in the C# code.

### Running the Project

1.  Clone this repository to your local machine.
2.  Open the project's `.sln` file in **Visual Studio**.
3.  Build and run the project.

### Default Login Credentials

For initial access, use the following hardcoded credentials:
-   **Username**: `Admin`
-   **Password**: `Password`

