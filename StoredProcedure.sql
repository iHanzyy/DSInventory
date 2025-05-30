CREATE PROCEDURE sp_login_user
    @username NVARCHAR(50),
    @password NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @id INT, @role NVARCHAR(50);

    SELECT @id = id, @role = role
    FROM users
    WHERE username = @username AND password = @password;

    IF @id IS NOT NULL
    BEGIN
        INSERT INTO login_logs (username, role)
        VALUES (@username, @role);

        SELECT @id AS id, @username AS username, UPPER(@role) AS role;
    END
    ELSE
    BEGIN
        SELECT NULL AS id, NULL AS username, NULL AS role;
    END
END
