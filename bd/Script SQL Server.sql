CREATE DATABASE _Examen
GO

USE _Examen
GO

CREATE TABLE transactions(
	id INT PRIMARY KEY IDENTITY(1, 1),
	user_id int,
	amount decimal(10, 2),
	transaction_date datetime default current_timestamp
)
GO
