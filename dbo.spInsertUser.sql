CREATE PROCEDURE spInsertUser
    @Name NVARCHAR(100),
    @Email NVARCHAR(100),
    @Phone NVARCHAR(15),
    @Address NVARCHAR(255),
    @State NVARCHAR(50),
    @City NVARCHAR(50)
AS
BEGIN
    INSERT INTO Users (Name, Email, Phone, Address, State, City)
    VALUES (@Name, @Email, @Phone, @Address, @State, @City);
END;