Create Database BookStoreManagementDB;

go

Use BookStoreManagementDB;

go

-- Create User Table
CREATE TABLE [User] (
    UserId INT PRIMARY KEY,
    FullName VARCHAR(100),
    Password VARCHAR(100),
    Email VARCHAR(100),
    Role VARCHAR(50),
    Status VARCHAR(50)
);
GO
-- Create Books Table
CREATE TABLE Books (
    BookId INT PRIMARY KEY,
    BookName VARCHAR(100),
    AuthorId INT,
    PublisherId INT,
    CategoryId INT,
    Quantity INT,
    Price DECIMAL(10, 2)
);
GO
-- Create Publishers Table
CREATE TABLE Publishers (
    PublisherId INT PRIMARY KEY,
    PublisherName VARCHAR(100),
    PublisherEmail VARCHAR(100),
    PublisherDescription TEXT,
    PublisherPhoneNo VARCHAR(20)
);
GO
-- Create Authors Table
CREATE TABLE Authors (
    AuthorId INT PRIMARY KEY,
    AuthorName VARCHAR(100),
    AuthorDescription TEXT,
    AuthorAge INT
);
GO
-- Create Categories Table
CREATE TABLE Categories (
    CategoryId INT PRIMARY KEY,
    CategoryName VARCHAR(100),
    CategoryDescription TEXT
);
GO
-- Sample Data for User Table
INSERT INTO [User] (UserId, FullName, Password, Email, Role, Status) VALUES
(1, 'Admin User', 'adminpass', 'admin@bookstore.com', 'Admin', 'Active'),
(2, 'Staff One', 'staff1pass', 'staff1@bookstore.com', 'Staff', 'Active'),
(3, 'Staff Two', 'staff2pass', 'staff2@bookstore.com', 'Staff', 'Active'),
(4, 'Staff Three', 'staff3pass', 'staff3@bookstore.com', 'Staff', 'Active');
GO
-- Sample Data for Publishers Table
INSERT INTO Publishers (PublisherId, PublisherName, PublisherEmail, PublisherDescription, PublisherPhoneNo) VALUES
(1, 'Publisher One', 'contact@publisher1.com', 'Description of Publisher One', '1234567890'),
(2, 'Publisher Two', 'contact@publisher2.com', 'Description of Publisher Two', '1234567891'),
(3, 'Publisher Three', 'contact@publisher3.com', 'Description of Publisher Three', '1234567892'),
(4, 'Publisher Four', 'contact@publisher4.com', 'Description of Publisher Four', '1234567893'),
(5, 'Publisher Five', 'contact@publisher5.com', 'Description of Publisher Five', '1234567894'),
(6, 'Publisher Six', 'contact@publisher6.com', 'Description of Publisher Six', '1234567895'),
(7, 'Publisher Seven', 'contact@publisher7.com', 'Description of Publisher Seven', '1234567896'),
(8, 'Publisher Eight', 'contact@publisher8.com', 'Description of Publisher Eight', '1234567897'),
(9, 'Publisher Nine', 'contact@publisher9.com', 'Description of Publisher Nine', '1234567898'),
(10, 'Publisher Ten', 'contact@publisher10.com', 'Description of Publisher Ten', '1234567899');
GO
-- Sample Data for Authors Table
INSERT INTO Authors (AuthorId, AuthorName, AuthorDescription, AuthorAge) VALUES
(1, 'Author One', 'Description of Author One', 45),
(2, 'Author Two', 'Description of Author Two', 50),
(3, 'Author Three', 'Description of Author Three', 60),
(4, 'Author Four', 'Description of Author Four', 55),
(5, 'Author Five', 'Description of Author Five', 35),
(6, 'Author Six', 'Description of Author Six', 40),
(7, 'Author Seven', 'Description of Author Seven', 30),
(8, 'Author Eight', 'Description of Author Eight', 65),
(9, 'Author Nine', 'Description of Author Nine', 70),
(10, 'Author Ten', 'Description of Author Ten', 75),
(11, 'Author Eleven', 'Description of Author Eleven', 80),
(12, 'Author Twelve', 'Description of Author Twelve', 85),
(13, 'Author Thirteen', 'Description of Author Thirteen', 90),
(14, 'Author Fourteen', 'Description of Author Fourteen', 95),
(15, 'Author Fifteen', 'Description of Author Fifteen', 32),
(16, 'Author Sixteen', 'Description of Author Sixteen', 34),
(17, 'Author Seventeen', 'Description of Author Seventeen', 36),
(18, 'Author Eighteen', 'Description of Author Eighteen', 38),
(19, 'Author Nineteen', 'Description of Author Nineteen', 42),
(20, 'Author Twenty', 'Description of Author Twenty', 44);
GO
-- Sample Data for Categories Table
INSERT INTO [Categories] (CategoryId, CategoryName, CategoryDescription) VALUES
(1, 'Fiction', 'Description of Fiction Category'),
(2, 'Non-Fiction', 'Description of Non-Fiction Category'),
(3, 'Science', 'Description of Science Category'),
(4, 'History', 'Description of History Category'),
(5, 'Technology', 'Description of Technology Category'),
(6, 'Biography', 'Description of Biography Category'),
(7, 'Fantasy', 'Description of Fantasy Category');
GO
-- Sample Data for Books Table
INSERT INTO Books (BookId, BookName, AuthorId, PublisherId, CategoryId, Quantity, Price) VALUES
(1, 'Book One', 1, 1, 1, 100, 9.99),
(2, 'Book Two', 2, 2, 2, 200, 19.99),
(3, 'Book Three', 3, 3, 3, 300, 29.99),
(4, 'Book Four', 4, 4, 4, 400, 39.99),
(5, 'Book Five', 5, 5, 5, 500, 49.99),
(6, 'Book Six', 6, 6, 6, 600, 59.99),
(7, 'Book Seven', 7, 7, 7, 700, 69.99),
(8, 'Book Eight', 8, 8, 1, 800, 79.99),
(9, 'Book Nine', 9, 9, 2, 900, 89.99),
(10, 'Book Ten', 10, 10, 3, 1000, 99.99),
(11, 'Book Eleven', 11, 1, 4, 1100, 109.99),
(12, 'Book Twelve', 12, 2, 5, 1200, 119.99),
(13, 'Book Thirteen', 13, 3, 6, 1300, 129.99),
(14, 'Book Fourteen', 14, 4, 7, 1400, 139.99),
(15, 'Book Fifteen', 15, 5, 8, 1500, 149.99),
(16, 'Book Sixteen', 16, 6, 9, 1600, 159.99),
(17, 'Book Seventeen', 17, 7, 10, 1700, 169.99),
(18, 'Book Eighteen', 18, 8, 1, 1800, 179.99),
(19, 'Book Nineteen', 19, 9, 2, 1900, 189.99),
(20, 'Book Twenty', 20, 10, 3, 2000, 199.99),
(21, 'Book Twenty-One', 1, 1, 4, 2100, 209.99),
(22, 'Book Twenty-Two', 2, 2, 5, 2200, 219.99),
(23, 'Book Twenty-Three', 3, 3, 6, 2300, 229.99),
(24, 'Book Twenty-Four', 4, 4, 7, 2400, 239.99),
(25, 'Book Twenty-Five', 5, 5, 8, 2500, 249.99),
(26, 'Book Twenty-Six', 6, 6, 9, 2600, 259.99),
(27, 'Book Twenty-Seven', 7, 7, 10, 2700, 269.99),
(28, 'Book Twenty-Eight', 8, 8, 1, 2800, 279.99),
(29, 'Book Twenty-Nine', 9, 9, 2, 2900, 289.99),
(30, 'Book Thirty', 10, 10, 3, 3000, 299.99);


select * from [User]

select * from [Categories]

select * from Books

select * from Publishers

Select * from Authors