CREATE TABLE Users(
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50),
    UserPassword VARCHAR(50)
);

INSERT INTO Users (Username, UserPassword)
VALUES
('admin', 'admin123'),
('user01', 'user123'),
('guest', 'guest123');



