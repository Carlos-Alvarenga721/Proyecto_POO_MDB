CREATE DATABASE PROYECTO_POO
GO

use PROYECTO_POO

CREATE TABLE Usuario
(ID int primary key identity (1,1),
usuario varchar (100) UNIQUE,
clave varchar(15)
)

INSERT INTO Usuario VALUES
('Admin','123'),
('Carlos','456')

select*from Usuario
