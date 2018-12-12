USE [LIBRARY DB EDITS]


/********************************************************************************
							*TABLE CREATION*  &  *TABLE INSERTSION*
********************************************************************************/

/********************************************************************************
							PUBLISHER TABLE
********************************************************************************/

CREATE TABLE tbl_publisher(
	publisher_id INT PRIMARY KEY NOT NULL IDENTITY (1,1), 
	publisher_name VARCHAR(50) UNIQUE NOT NULL,
	publisher_address VARCHAR(50) NOT NULL,
	publisher_phone VARCHAR(50) NOT NULL
);

INSERT INTO tbl_publisher
	(publisher_name, publisher_address, publisher_phone)
	VALUES
	('Green Books', '513 Turquoise St.', '555-212-5895'),
	('Red Books', '717 Maroon St.', '777-202-2495'),
	('Blue Books', '45 Royal St.', '531-794-1303'),
	('White Books', '888 Eggshell St.', '512-213-9522'),
	('Pink Books', '100 Magenta St.', '333-241-0009')
;

SELECT * FROM tbl_publisher;

/********************************************************************************
							END PUBLISHER TABLE
********************************************************************************/


/********************************************************************************
							BORROWER TABLE
********************************************************************************/


CREATE TABLE tbl_borrower(
	card_no INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	borrower_name VARCHAR(50) NOT NULL,
	borrower_address VARCHAR(50) NOT NULL,
	borrower_phone VARCHAR(50) NOT NULL
);

INSERT INTO tbl_borrower
	(borrower_name, borrower_address, borrower_phone)
	VALUES
	('Luke Evans', '1313 Dead End Drive', '468-579-2234'),
	('Mandy Clouse', '121 Coocoo Nest', '234-674-3445'),
	('Kendra Cutter', '453 Estevez Road', '224-223-3345'),
	('He Mann', '234 Broadway St.', '245-345-4566'),
	('Michelle Kissinger', '339 Boardwalk Ave.', '345-556-3344'),
	('Vanner Sharp', '700 E. Lakewood', '467-556-5567'),
	('Wonder Woman', '54 Centenial', '321-345-1131'),
	('Jack Ellen', '159 Colorado St.', '345-433-4346'),
	('James Sunderland', '666 Silent Hill', '666-666-6666'),
	('Mary Sunderland', '564 Kats Drive', '742-467-3456'),
	('Jill Valentine', '253 Racoon City', '356-468-2355'),
	('Resident Evil', 'PO BOX Unmebrella Corporation', '645-234-6783'),
	('Andrew Ryan', '17 Rapture', '303-543-4573')
;

SELECT * FROM tbl_borrower

/********************************************************************************
							END BORROWER TABLE
********************************************************************************/



/********************************************************************************
							BRANCH TABLE
********************************************************************************/

CREATE TABLE tbl_library_branch(
	branch_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	branch_name VARCHAR(50) NOT NULL,
	branch_address VARCHAR(50) NOT NULL


);


INSERT INTO tbl_library_branch 
	(branch_name, branch_address)
	VALUES
	('Sharpstown','451 Farenheight St.'),
	('Central','1984 Distopia Ave.'),
	('Northville','2 Moons Blvd.'),
	('Southberg','39 Steps St.')
;

SELECT * FROM tbl_library_branch


/********************************************************************************
							END BRANCH TABLE
********************************************************************************/



/********************************************************************************
							BOOK TABLE
********************************************************************************/

CREATE TABLE tbl_book(
	book_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	title VARCHAR(50) NOT NULL ,
	book_publisher VARCHAR(50) NOT NULL CONSTRAINT fk_publisher_name FOREIGN KEY REFERENCES tbl_publisher(publisher_name) ON UPDATE CASCADE ON DELETE CASCADE,
);



INSERT INTO tbl_book
	(title, book_publisher)
	VALUES
	('Cujo', 'Green Books'),
	('The Stand', 'Green Books'),
	('The Great Gatsby', 'Green Books'),
	('To The Lighthouse', 'Green Books'),
	('War and Peace', 'Red Books'),
	('Ulysses', 'Red Books'),
	('The Odyssey', 'Red Books'),
	('Moby Dick', 'Red Books'),
	('Hamlet', 'Blue Books'),
	('The Adventures of Huckleberry Finn', 'Blue Books'),
	('The Iliad', 'Blue Books'),
	('Madame Bovary', 'Blue Books'),
	('Crime and Punishment', 'White Books'),
	('Pride and Prejudice', 'White Books'),
	('Lolita', 'White Books'),
	('Nineteen Eighty Four', 'White Books'),
	('Atlas Shrugs', 'Pink Books'),
	('Alice In Wonderland', 'Pink Books'),
	('Great Expectations', 'Pink Books'),
	('The Catcher In The Rye', 'Pink Books'),
	('The Lost Tribe', 'Pink Books')
;

SELECT * FROM tbl_book

/********************************************************************************
							END BOOK TABLE
********************************************************************************/




/********************************************************************************
							AUTHOR TABLE
********************************************************************************/

CREATE TABLE tbl_book_authors(
	author_id INT PRIMARY KEY  NOT NULL IDENTITY (1,1),
	author_book_id INT NOT NULL CONSTRAINT fk_book_id FOREIGN KEY REFERENCES tbl_book(book_id) ON UPDATE CASCADE ON DELETE CASCADE,
	author_name VARCHAR(50) NOT NULL 
);

INSERT INTO tbl_book_authors
	(author_book_id, author_name)
	VALUES
	(1, 'Stephen King'),
	(2, 'Stephen King'),
	(3, 'F. Scott Fitzgerald'),
	(4, 'Virginia Woolf'),
	(5, 'Leo Tolstoy'),
	(6, 'James Joyce'),
	(7, 'Homer'),
	(8, 'Herman Melville'),
	(9, 'William Shakespeare'),
	(10, 'Mark Twain'),
	(11, 'Homer'),
	(12, 'Gustave Flaubert'),
	(13, 'Fyodor Dostoyevsky'),
	(14, 'Jane Austen'),
	(15, 'Vladimir Nabokov'),
	(16, 'George Orwell'),
	(17, 'Ayn Rand'),
	(18, 'Lewis Carroll'),
	(19, 'Charles Dickens'),
	(20, 'J.D. Salinger'),
	(21, 'Mark Lee')
;

SELECT * FROM tbl_book_authors

/********************************************************************************
							END AUTHOR TABLE
********************************************************************************/


/********************************************************************************
							 COPIES TABLE
********************************************************************************/


CREATE TABLE tbl_book_copies(
	copies_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	copies_book_id INT NOT NULL CONSTRAINT fk_book_id3 FOREIGN KEY REFERENCES tbl_book(book_id) ON UPDATE CASCADE ON DELETE CASCADE,
	copies_branch_id INT NOT NULL CONSTRAINT fk_branch_id2 FOREIGN KEY REFERENCES tbl_library_branch(branch_id) ON UPDATE CASCADE ON DELETE CASCADE,
	no_of_copies INT NOT NULL
);



INSERT INTO tbl_book_copies
	(copies_book_id, copies_branch_id, no_of_copies)
	VALUES
	(1, 1, 4),
	(11, 1, 2),
	(12, 1, 4),
	(13, 1, 3),
	(14, 1, 7),
	(15, 1, 6),
	(16, 1, 4),
	(17, 1, 3),
	(18, 1, 5),
	(19, 1, 2),
	(20, 1, 2),
	(21, 1, 4),
	(1, 2, 2),
	(2, 2, 5),
	(3, 2, 9),
	(4, 2, 8),
	(5, 2, 3),
	(6, 2, 2),
	(7, 2, 8),
	(8, 2, 9),
	(9, 2, 7),
	(10, 2, 5),
	(11, 3, 3),
	(12, 3, 4),
	(13, 3, 6),
	(14, 3, 9),
	(15, 3, 2),
	(16, 3, 5),
	(17, 3, 6),
	(18, 3, 4),
	(19, 3, 8),
	(20, 3, 6),
	(21, 3, 4),
	(1, 4, 3),
	(2, 4, 5),
	(3, 4, 7),
	(4, 4, 6),
	(5, 4, 5),
	(6, 4, 4),
	(7, 4, 9),
	(8, 4, 2),
	(9, 4, 2),
	(10, 4, 2),
	(11, 4, 6)
	
;

SELECT * FROM tbl_book_copies


/********************************************************************************
							END COPIES TABLE
********************************************************************************/

/********************************************************************************
							LOANS TABLE
********************************************************************************/


CREATE TABLE tbl_book_loans(
	loans_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	loans_book_id INT NOT NULL CONSTRAINT fk_book_id2 FOREIGN KEY REFERENCES tbl_book(book_id) ON UPDATE CASCADE ON DELETE CASCADE,
	loans_branch_id INT NOT NULL CONSTRAINT fk_branch_id FOREIGN KEY REFERENCES tbl_library_branch(branch_id) ON UPDATE CASCADE ON DELETE CASCADE,
	loans_card_no INT NOT NULL CONSTRAINT fk_card_no FOREIGN KEY REFERENCES tbl_borrower(card_no) ON UPDATE CASCADE ON DELETE CASCADE,
	date_out DATE NOT NULL,
	due_date DATE NOT NULL
);

INSERT INTO tbl_book_loans
	(loans_book_id, loans_branch_id, loans_card_no, date_out, due_date)
	VALUES
	( 1, 1, 1, '2018-04-15','2018-12-31'),
	( 11, 1, 1,'2018-03-01','2018-04-16'),
	( 12, 1, 1,'2018-03-02','2018-04-17'),
	( 13, 1, 1,'2018-03-03','2018-04-18'),
	( 14, 1, 1,'2018-03-04','2018-04-19'),
	( 15, 1, 1,'2018-03-05','2018-04-20'),
	( 16, 1, 2,'2018-04-03','2018-04-21'),
	( 17, 1, 2,'2018-04-03','2018-04-22'),
	( 18, 1, 2,'2018-03-05','2018-04-23'),
	( 19, 1, 2,'2018-04-11','2018-04-24'),
	( 20, 1, 2,'2018-04-03','2018-04-25'),
	( 21, 1, 2,'2018-02-21','2018-04-26'),
	( 11, 1, 2,'2018-04-01','2018-04-27'),
	( 12, 1, 3,'2018-04-03','2018-04-28'),
	( 13, 1, 3,'2018-04-11','2018-04-29'),
	( 14, 1, 3,'2018-04-10','2018-04-30'),
	( 15, 1, 3,'2018-02-21','2018-04-16'),
	( 16, 1, 3,'2018-03-15','2018-04-23'),
	( 17, 1, 3,'2018-03-05','2018-04-22'),
	( 1, 2, 4,'2018-04-06','2018-04-30'),
	( 2, 2, 4,'2018-04-11','2018-05-12'),
	( 3, 2, 4,'2018-03-16','2018-06-01'),
	( 4, 2, 4,'2018-03-17','2018-05-02'),
	( 5, 2, 4,'2018-04-06','2018-07-01'),
	( 6, 2, 5,'2018-03-18','2018-06-11'),
	( 7, 2, 5,'2018-04-06','2018-09-10'),
	( 8, 2, 5,'2018-03-09','2018-05-05'),
	( 9, 2, 5,'2018-04-11','2018-06-13'),
	( 10, 2, 6,'2018-03-19','2018-08-04'),
	( 1, 2, 6,'2018-04-03','2018-05-02'),
	( 11, 3, 6,'2018-04-01','2018-05-02'),
	( 12, 3, 6,'2018-04-10','2018-05-05'),
	( 13, 3, 7,'2018-03-20','2018-04-24'),
	( 14, 3, 7,'2018-03-05','2018-04-26'),
	( 15, 3, 7,'2018-03-21','2018-04-23'),
	( 16, 3, 7,'2018-02-21','2018-06-30'),
	( 17, 3, 8,'2018-04-11','2018-04-30'),
	( 18, 3, 8,'2018-03-29','2018-05-30'),
	( 19, 3, 8,'2018-04-03','2018-06-07'),
	( 20, 3, 8,'2018-04-01','2018-05-05'),
	( 21, 3, 9,'2018-03-05','2018-04-21'),
	( 11, 3, 9,'2018-04-10','2018-06-06'),
	( 1, 4, 9,'2018-04-03','2018-07-07'),
	( 2, 4, 9,'2018-04-08','2018-06-05'),
	( 3, 4, 9,'2018-02-28','2018-09-30'),
	( 4, 4, 10,'2018-04-11','2018-04-29'),
	( 5, 4, 10,'2018-04-12','2018-05-29'),
	( 6, 4, 10,'2018-04-03','2018-05-30'),
	( 7, 4, 11,'2018-04-01','2018-04-21'),
	( 8, 4, 11,'2018-03-05','2018-04-20'),
	( 9, 4, 11,'2018-02-21','2018-05-03')
;

SELECT * FROM tbl_book_loans

/********************************************************************************
						END LOANS TABLE
********************************************************************************/
/********************************************************************************
						!!STORED PROCEDURES!!
********************************************************************************/


/*   NUMBER 1   */
CREATE PROCEDURE library_sp_1
AS
BEGIN

SELECT 
a1.no_of_copies AS'Number Of Copies' , a2.title AS 'Book Title', a3.branch_name AS 'Branch Location'
	
FROM tbl_book_copies a1
INNER JOIN tbl_book a2 ON a2.book_id= a1.copies_book_id  
INNER JOIN tbl_library_branch a3 ON a3.branch_id = a1.copies_branch_id 
WHERE
title='The Lost Tribe'
AND
branch_name = 'Sharpstown'
;
END 


/*   NUMBER 2   */

CREATE PROCEDURE library_sp_2
AS
BEGIN
SELECT
a1.no_of_copies AS 'Number of Copies', a2.title AS 'Boot Title', a3.branch_name AS 'Branch Location'
FROM tbl_book_copies a1
INNER JOIN tbl_book a2 ON a2.book_id = a1.copies_book_id
INNER JOIN tbl_library_branch a3 ON a3.branch_id = a1.copies_branch_id
WHERE
title = 'The Lost Tribe'
;
END


/*   NUMBER 3   */

CREATE PROCEDURE library_sp_3
AS
BEGIN
SELECT
a2.loans_card_no AS'Books Checked Out', a1.borrower_name AS 'Name'
FROM tbl_borrower a1 
FULL OUTER JOIN tbl_book_loans a2 ON a2.loans_card_no = a1.card_no
WHERE
loans_card_no IS NULL
;
END 


/*   NUMBER 4   */

CREATE PROCEDURE library_sp_4
AS
BEGIN
SELECT
a1.due_date AS'Due Date', a2.branch_name AS'Branch Name', a3.title AS'Book Title', a4.borrower_name AS'Borrowers Name', a4.borrower_address AS'Borrowers Address'
FROM tbl_book_loans a1
INNER JOIN tbl_library_branch a2 ON a2.branch_id = a1.loans_branch_id
INNER JOIN tbl_book a3 ON a3.book_id = a1.loans_id
INNER JOIN tbl_borrower a4 ON a4.card_no = a1.loans_card_no

WHERE
branch_name='Sharpstown'
AND
due_date = CONVERT (date, GETDATE())
;

END

/*   NUMBER 5   */

CREATE PROCEDURE library_sp_5
AS
BEGIN
SELECT
COUNT(loans_branch_id) AS 'Number Of Books Checked Out', a2.branch_name AS 'Branch Name'
FROM tbl_book_loans a1 
INNER JOIN tbl_library_branch a2 ON a2.branch_id = a1.loans_branch_id
GROUP BY branch_name
;
END 

/*   NUMBER 6   */

CREATE PROCEDURE library_sp_6
AS
BEGIN
SELECT
COUNT(loans_card_no) AS 'Number Of Books Checked Out', a2.borrower_name AS 'Borrowers Name', a2.borrower_address AS 'Borrowers Address'

FROM tbl_book_loans a1
INNER JOIN tbl_borrower a2 ON a2.card_no = a1.loans_card_no
GROUP BY borrower_name, borrower_address
HAVING COUNT(loans_card_no) > 5
;
END 




/*   NUMBER 7   */

CREATE PROCEDURE library_sp_7
AS
BEGIN
SELECT
a1.no_of_copies, a2.branch_name, a3.title, a4.author_name
FROM tbl_book_copies a1
INNER JOIN tbl_library_branch a2 ON a2.branch_id = a1.copies_branch_id
INNER JOIN tbl_book a3 ON a3.book_id = a1.copies_book_id
INNER JOIN tbl_book_authors a4 ON a4.author_book_id = a1.copies_book_id

WHERE author_name = 'Stephen King'
AND
branch_name='Central'

;
END
/********************************************************************************
						END STORED PROCEDURES
********************************************************************************/
/********************************************************************************
						STORED PROCEDURES EXECUSION
********************************************************************************/


EXEC library_sp_1 
EXEC library_sp_2
EXEC library_sp_3
EXEC library_sp_4 
EXEC library_sp_5
EXEC library_sp_6
EXEC library_sp_7

/********************************************************************************
						END STORED PROCEDURES EXECUSION
********************************************************************************/



