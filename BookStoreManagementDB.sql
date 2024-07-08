Create Database BookStoreManagementDB;

go

Use BookStoreManagementDB;

go

-- Create the User table
CREATE TABLE [User] (
    UserId INT IDENTITY PRIMARY KEY,
    FullName VARCHAR(255) NOT NULL,
    Password VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    Role VARCHAR(50) NOT NULL,
    Status VARCHAR(50) NOT NULL
);
go
-- Create the Publishers table
CREATE TABLE Publishers (
    PublisherId INT IDENTITY PRIMARY KEY,
    PublisherName VARCHAR(255) NOT NULL,
    PublisherEmail VARCHAR(255),
    PublisherDescription TEXT,
    PublisherPhoneNo VARCHAR(20)
);
go
-- Create the Authors table
CREATE TABLE Authors (
    AuthorId INT IDENTITY PRIMARY KEY,
    AuthorName VARCHAR(255) NOT NULL,
    AuthorDescription TEXT,
    AuthorAge INT
);
go
-- Create the Categories table
CREATE TABLE Categories (
    CategoryId INT IDENTITY PRIMARY KEY,
    CategoryName VARCHAR(255) NOT NULL,
    CategoryDescription TEXT
);
Go
-- Create the Books table
CREATE TABLE Books (
    BookId INT IDENTITY PRIMARY KEY,
    BookName VARCHAR(255) NOT NULL,
    AuthorId INT,
    PublisherId INT,
    CategoryId INT,
    Quantity INT,
    Price DECIMAL(10, 2),
    FOREIGN KEY (AuthorId) REFERENCES Authors(AuthorId),
    FOREIGN KEY (PublisherId) REFERENCES Publishers(PublisherId),
    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
);

GO
-- Sample Data for User Table
INSERT INTO [User] (FullName, Password, Email, Role, Status) VALUES
('Admin', '1', 'admin@bookstore.com', 'Admin', 'Active'),
('Linh Co Don', '2', 'lonelystonie@bookstore.com', 'Staff', 'Active'),
('Hoang Sa Co', '3', 'staff2@bookstore.com', 'Staff', 'Active'),
('Le Hong Gam', '4', 'staff3@bookstore.com', 'Staff', 'Disabled');

GO
-- Insert sample publishers
INSERT INTO Publishers (PublisherName, PublisherEmail, PublisherDescription, PublisherPhoneNo) VALUES
('Kim Dong', 'contact@nxbkimdong.com', 'Fostering a love of reading in children of all ages.', '1234567890'),
('Hoang Sa', 'contact@nxbhoangsa.com', 'Unearthing historical gems for a new generation.', '1234567891'),
('Nha Co Ay', 'contact@nxhnhacoay.com', 'Award-winning publisher of thought-provoking fiction.', '1234567892'),
('Ban Mai', 'contact@nxbbanmai.com', 'Where tomorrow''s literary stars are born.', '1234567893'),
('Phuong Nam', 'contact@phuongnamog.com', 'Celebrating Vietnamese voices since 1999', '1234567894'),
('Hien Huu', 'contact@bienmat.com', 'Pioneering innovative formats for the modern reader.', '1234567895'),
('Minh Anh Co-op', 'contact@minhanhcoop.com', 'Building strong minds with engaging educational resources.', '1234567896'),
('Min Xu Hao', 'contact@minxuxu.com', 'Building strong minds with engaging educational resources.', '1234567897'),
('Linh Mien Tay', 'contact@khongphaimiendong.com', 'Building strong minds with engaging educational resources.', '1234567898'),
('Mot Dieu Uoc', 'contact@muoidieuuoc.com', 'Turning literary aspirations into reality.', '1234567899');
go
-- Insert sample authors
INSERT INTO Authors (AuthorName, AuthorDescription, AuthorAge) VALUES
('Ho Hoan Kiem', 'Weaving tales of fantasy', 45),
('Nina', 'Stirring emotions with her coming-of-age stories', 50),
('Hoang Tau Hu', 'A veteran author crafting historical fiction', 35),
('Nguoi Tinh Mua Quat', 'Award-winning author with over 60 published works', 60),
('Nguyen Han Anh', 'Delving into the complexities of human nature', 40),
('Pinky', 'A captivating voice with a knack for witty dialogue', 21),
('Kusanali Nahida', 'A fresh new voice debuts with a sci-fi thriller', 500),
('Newdaynewmay', 'Pushing the limits of horror', 65),
('Kisuqua', 'Evoking emotions with her lyrical prose', 38),
('Motnamqua', 'A promising new author emerges with a captivating debut', 48);
go
-- Insert sample categories
INSERT INTO Categories (CategoryName, CategoryDescription) VALUES
('Fantasy', 'Worlds of magic and wonder, where dragons soar and heroes rise.'),
('Mystery & Thriller', 'Unraveling puzzles, following clues, where suspense keeps you on the edge of your seat.'),
('Science Fiction', 'Journeys to distant galaxies, exploring the future of technology and humanity.'),
('Historical Fiction', 'Stepping back in time, experiencing the lives and struggles of those who came before.'),
('Contemporary Fiction', 'Stories that reflect the world around us, exploring modern relationships and social issues.');
go
-- Insert sample books
INSERT INTO Books (BookName, AuthorId, PublisherId, CategoryId, Quantity, Price) VALUES
('The Dragon''s Call', 1, 1, 1, 10, 19.99),
('Secrets of the Forbidden City', 2, 2, 2, 5, 29.99),
('The Alchemist''s Apprentice', 3, 3, 3, 8, 25.99),
('The Midnight Detective', 4, 4, 4, 12, 15.99),
('Love in the Time of War', 5, 5, 5, 6, 20.99),
('Echoes of a Forgotten Empire', 6, 6, 1, 9, 17.99),
('The Haunting of Blackwood Manor', 7, 7, 2, 11, 22.99),
('Beyond the Event Horizon', 8, 8, 3, 14, 18.99),
('The Song of the Last Phoenix', 9, 9, 4, 7, 24.99),
('Whispers of a New Dawn', 10, 10, 5, 13, 21.99),
('A Conspiracy of Shadows', 1, 2, 3, 15, 27.99),
('The Scarlet Pimpernel Returns', 2, 3, 4, 16, 16.99),
('Murder on the Orient Express (Vietnamese Edition)', 3, 4, 5, 17, 23.99),
('The Lost City of Z: A Vietnamese Adventure', 4, 5, 1, 18, 19.99),
('The Book Thief (Vietnamese Translation)', 5, 6, 2, 19, 25.99),
('Romeo and Juliet in Modern Saigon', 6, 7, 3, 20, 29.99),
('The Martian Chronicles: A Vietnamese Perspective', 7, 8, 4, 21, 30.99),
('AI Uprising: Can Humanity Survive?', 8, 9, 5, 22, 22.99),
('The Girl with the Pearl Earring (Vietnamese Edition)', 9, 10, 1, 23, 28.99),
('One Hundred Years of Solitude (Vietnamese Translation)', 10, 1, 2, 24, 26.99),
('The Call of the Wild (Vietnamese Adaptation)', 1, 2, 3, 25, 31.99),
('Pride and Prejudice: A Modern Retelling', 2, 3, 4, 26, 20.99),
('The Count of Monte Cristo (Vietnamese Edition)', 3, 4, 5, 27, 24.99),
('The Adventures of Sherlock Holmes (Vietnamese Collection)', 4, 5, 1, 28, 21.99),
('Jane Eyre (Vietnamese Translation)', 5, 6, 2, 29, 23.99),
('The Great Gatsby: A Vietnamese Interpretation', 6, 7, 3, 30, 27.99),
('To Kill a Mockingbird (Vietnamese Edition)', 7, 8, 4, 31, 19.99),
('Animal Farm (Vietnamese Translation)', 8, 9, 5, 32, 18.99),
('The Catcher in the Rye (Vietnamese Edition)', 9, 10, 1, 33, 20.99),
('Hamlet (Vietnamese Adaptation)', 10, 1, 2, 34, 29.99);

go
select * from [User]
go
select * from [Categories]
go
select * from Books
go
select * from Publishers
go
Select * from Authors

--drop database BookStoreManagementDB