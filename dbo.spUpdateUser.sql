CREATE PROCEDURE spUpdateUser
    @Id INT,
    @Name NVARCHAR(100),
    @Email NVARCHAR(100),
    @Phone NVARCHAR(15),
    @Address NVARCHAR(255),
    @State NVARCHAR(50),
    @City NVARCHAR(50)
AS
BEGIN
    UPDATE Users
    SET Name = @Name,
        Email = @Email,
        Phone = @Phone,
        Address = @Address,
        State = @State,
        City = @City
    WHERE Id = @Id;
END;