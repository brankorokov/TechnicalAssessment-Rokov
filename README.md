## About the app
You are able to sign up as either a librarian or a customer. Librarians on the home page can add books, or click on book titles to update. If the book is checked out, the librarian can check in.
Librarians are also notified when a book they are viewing is past due.

Customers can check out books.

# App Setup

Before running the app, please make sure you have the following prerequisites installed:

- SQL Express: Make sure you have SQL Express installed on your machine. You can download it from the official Microsoft website.

## Database Migration

To set up the database for the app, follow these steps:

1. Open the Package Manager Console in Visual Studio by going to `Tools > NuGet Package Manager > Package Manager Console`.

2. In the Package Manager Console, run the following command to apply the database migrations: `Update-Database`.
This command will create the necessary database tables and seed any initial data.

That's it! You are now ready to run the app. Enjoy!
