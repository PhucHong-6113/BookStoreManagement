#Book Store Management System
##Description
The Book Store Management System is a WinForms application designed to facilitate the management of books, publishers, authors, and staff in a bookstore.

##Features
###Staff
Manage Books: Create, Read, Update, and Delete (CRUD) operations for books.
Manage Publishers: CRUD operations for publishers.
Manage Authors: CRUD operations for authors.
###Admin
Manage Staff: Create, Read, Update, and Disable staff members.
View Library Data: Access lists of books, publishers, and authors.
Database Schema
###User: UserId (PK), FullName, Password, Email, Role, Status.
###Books: BookId (PK), BookName, AuthorId (FK), PublisherId (FK), CategoryId (FK), Quantity, Price.
###Publishers: PublisherId (PK), PublisherName, PublisherEmail, PublisherDescription, PublisherPhoneNo.
###Authors: AuthorId (PK), AuthorName, AuthorDescription, AuthorAge.
###Categories: CategoryId (PK), CategoryName, CategoryDescription.
##Screens
Authentication

Login
Forgot Password
Main Screen

Book Management
Publisher Management
Author Management
Logout
Books

Book List
Add Book
Book Detail
Update Book
Publishers

Publisher List
Add Publisher
Update Publisher
Authors

Author List
Add Author
Update Author
Categories

Category List
Add Category
Update Category
Admin

Staff List
Add Staff
Update Staff
Library Data
User Flows
Default Screen: Login
Forgot Password: Allows users to reset their password.
View Book Detail: View detailed information of a book.
CRUD Books: Manage books including adding, updating, and deleting.
CRUD Authors: Manage authors including adding, updating, and deleting.
CRUD Publishers: Manage publishers including adding, updating, and deleting.
CRUD Categories: Manage categories including adding, updating, and deleting.
Change Staff Status: Admin can change the status of staff members.
