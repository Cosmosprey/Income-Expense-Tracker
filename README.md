# Income-Expense-Tracker

**Income-Expense-Tracker** is a Windows desktop application designed for users to track their personal income and expenses. Users can register, log in, and manage their financial records to view a monthly summary showing whether they ended the month in surplus or deficit.

## 💡 Features

- User registration and login system
- Add and delete income/expense records
- Record details like amount, date, source, and type
- View income and expense data in a tabular format
- Display monthly financial balance (surplus or deficit)

## 🛠️ Technologies Used

- Windows Forms (WinForms)
- C# (.NET)
- Class Libraries

## 🚀 How to Run the Project

> ⚠️ This project does not include an installer. You must open and run it via Visual Studio.

1. Clone the repository or download it as a ZIP file from [GitHub](https://github.com/Cosmosprey/Income-Expense-Tracker).
2. Open the solution file (`.sln`) in Visual Studio 2022.
3. Build and run the project to launch the application.

## 📌 Notes

- This project was originally created in between December 2024 and January 2025 as part of my "Object-Oriented Programming I" course.
- Assistance from various educational and programming-related sources was used during the development of this project, as part of the learning process.
- This code was developed for educational purposes as part of a course project.
- All prompts and messages are in Turkish.
- It may contain bugs or incomplete functionality.
- Some image files (icons) are used for navigation buttons (e.g., back/forward). No external libraries were used.


## 🔧 Planned Improvements

* Add sorting options to the income-expense table (e.g., sort by amount)
* Improve UI design and overall visuals, especially for the table and form backgrounds
* Make deletion of income/expense entries more user-friendly (e.g., replace backspace-based deletion with a selectable blank option for mouse-only use)
* Implement a proper database to handle user registrations and financial records
  * This would allow storing cumulative data for each user, especially useful for long-term tracking
  * Learning database integration with the application is required
* For known issue number 2 : Update the "end of month status" label in the table, as the current logic does not distinguish between months
  * Replace with a more general label like "total status"
  * Add the ability to filter financial summaries by specific months (e.g., April, May) or custom timeframes
* Add delete user option which completely deletes user's username, password and all financial data
## 🐞 Known Issues

1 - The application currently shows the same financial data across all users

  * Each user should have separate income/expense records

2 - Monthly summaries are not actually separated by month

  * The date field accepts any date, but the summary calculation does not group or filter by month
  * This misrepresents the actual monthly financial status

1 and 2 numbered known issues were discovered while I was preparing the project for uploading to GitHub.
When I first developed it for my Object-Oriented Programming I course, I was mainly focused on completing the project and its problems which took many hours and a lot of exhaustion, so I overlooked some logical errors.

## Changelog

### v1.0.0 - 2025-05-14
- Initial version with income-expense tracking and reporting

