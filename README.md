Project: ASP.NET Core CRUD Application with Modal Popup and jQuery Ajax
Description:
This project is a basic CRUD (Create, Read, Update, Delete) application built using ASP.NET Core MVC, SQL Server (with Stored Procedures for CRUD operations), and jQuery Ajax for asynchronous operations. The application includes a form that opens in a modal popup for adding or editing records and a listing screen with edit and delete functionality.

Tech Stack:
Frontend: ASP.NET Core MVC, jQuery, Bootstrap (for Modal and styling)
Backend: ASP.NET Core MVC
Database: SQL Server with Stored Procedures
Version Control: Git (GitHub)
Video Tutorial: A video recording demonstrating the project setup and CRUD operations.
Features:
Modal Popup Form for adding and editing records.
Validation for the following fields:
Name (Required)
Email (Required, Proper Email Format)
Phone No. (Phone Number Format Validation)
State and City (dependent dropdowns for cities based on the selected state)
Agree Checkbox (Enables Submit Button)
State and City Dependency: On selecting a state, corresponding cities will be displayed using jQuery.
State List: Gujarat, Maharashtra
City of Gujarat: Surat, Bardoli, Baroda
City of Maharashtra: Mumbai, Pune
CRUD Operations:
Add a new record using a modal popup.
Edit an existing record using a modal popup with pre-filled data.
Delete a record with a confirmation dialog using Ajax.
Listing page with Name, Email, and Phone fields displayed along with Edit and Delete buttons.
Repository Pattern for managing database interactions.
