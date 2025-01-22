# Student Management System

A **C# Student Management System** built with Visual Studio and MySQL to simplify the process of managing student records. This application provides a user-friendly interface to perform CRUD operations (Create, Read, Update, Delete) on student data. Ideal for small educational institutions or learning purposes.

## Features
- Add, edit, delete, and view student records.
- Search functionality to locate specific students quickly.
- MySQL database integration for secure and efficient data storage.
- Responsive and intuitive design for seamless user interaction.

## Prerequisites
- Visual Studio (2019 or later)
- MySQL Server and MySQL Workbench
- .NET Framework or .NET Core (depending on your project setup)

## Installation

1. **Clone the Repository**  
   ```bash
   git clone https://github.com/your-username/student-management-system.git
   cd student-management-system
   
# Setup and Configuration Guide

This guide provides detailed steps to set up the **Student Management System** using Visual Studio and MySQL.

## Setup MySQL Database
1. Open MySQL Workbench and create a new database (e.g., `StudentDB`).
2. Execute the provided SQL script (`database.sql`) to set up the required tables.

## Configure Database Connection
1. Open the project in Visual Studio.
2. Locate the `appsettings.json` or database configuration file.
3. Update the connection string with your MySQL credentials:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost;Database=StudentDB;User Id=root;Password=yourpassword;"
   }
## Restore NuGet Packages
1. In Visual Studio, navigate to the **Tools** menu.
2. Select **NuGet Package Manager** > **Manage NuGet Packages for Solution**.
3. Restore all required packages for the project.

## Build the Project
1. Go to the **Build** menu in Visual Studio.
2. Select **Build Solution** or press `Ctrl+Shift+B` to compile the project.

## Run the Application
1. Press `F5` or navigate to the **Debug** menu and select **Start Debugging**.
2. The application will launch, allowing you to manage student records.

## Test the Application
1. Use the provided GUI to:
   - **Add** student records.
   - **Edit** existing student records.
   - **Delete** student records.
   - **View** all student records.
2. Verify that all database operations (**CRUD**) function as expected.

---

## Technologies Used
- **Programming Language:** C#
- **IDE:** Visual Studio
- **Database:** MySQL
- **Framework:** Windows Forms or WPF (as applicable)
