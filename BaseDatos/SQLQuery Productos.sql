----------------------------------- Creacion de BASE DE DATOS -------------------------------
CREATE DATABASE Productos 
GO 
USE Productos

----------------------------------- Creacion de TABLAS --------------------------------------

CREATE TABLE TablaCategorias (
	Id INT IDENTITY (1,1) PRIMARY KEY,
	Descripcion VARCHAR (100) not null
)
GO

CREATE TABLE TablaMarcas (
	Id INT IDENTITY (1,1) PRIMARY KEY,
	Descripcion VARCHAR (100) not null
)
GO

CREATE TABLE TablaProductos (
	Id INT IDENTITY (1,1) PRIMARY KEY,
	IdCategoria INT not null,
	IdMarca INT not null, 
	Descripcion VARCHAR(100) not null,
	Precio FLOAT not null

	--- RESTRICCIONES
	CONSTRAINT Categoria FOREIGN KEY (IdCategoria) REFERENCES TablaCategorias (Id),
	CONSTRAINT Marca FOREIGN KEY (IdMarca) REFERENCES TablaMarcas(Id)
)
GO

CREATE TABLE TablaUsuarios (
	Id INT IDENTITY (1,1) PRIMARY KEY,
	Email VARCHAR(100) not null UNIQUE,
	Pass VARCHAR(100) not null,
	NombreCompleto VARCHAR(100) not null,
	CreateDateUser DATETIME not null)
GO
----------------------------------- Mockeos de DATOS de cada Tabla -------------------------------

INSERT INTO TablaCategorias VALUES 
(''),
('Laptop'),
('Desktop'),
('Impresora'),
('Monitor'),
('Teclado'),
('Tarjeta'),
('Altavoz')
GO

INSERT INTO TablaMarcas VALUES 
(''),
('HP'),
('LG'),
('Samsung'),
('Logitech'),
('Lenovo'), 
('Asus'),
('Dell'),
('MSI'),
('Gygabyte'),
('Epson'),
('Nvidia')
GO

INSERT INTO TablaUsuarios VALUES
('juanchi@gmail.com', '123', 'Juan Cruz' , GETDATE())
GO


----------------------------------- Procedimientos Almacenados ----------------------------------- 

--- Listado Categorias 
CREATE PROC SpListarCategorias
AS
SELECT * FROM TablaCategorias ORDER BY Descripcion ASC
GO 

--- Listado Categorias 
CREATE PROC SpListarMarcas
AS
SELECT * FROM TablaMarcas ORDER BY Descripcion ASC
GO

----- LISTAR PRODUCTOS
CREATE PROC SpListarProductos
AS
SELECT 
	TablaProductos.Id, 
	TablaProductos.Descripcion, 
	TablaProductos.Precio, 
	TablaCategorias.Descripcion AS Categoria, 
	TablaMarcas.Descripcion AS Marca 
FROM TablaProductos 
INNER JOIN 
	TablaCategorias ON TablaProductos.IdCategoria = TablaCategorias.Id
INNER JOIN 
	TablaMarcas ON TablaProductos.IdMarca = TablaMarcas.Id
GO

-----AGREGAR PRODUCTO
CREATE PROC SpAgregarProducto
@idCategoria INT,
@idMarca INT,
@descripcion VARCHAR (100),
@precio FLOAT
AS
INSERT INTO TablaProductos values (@idCategoria, @idMarca, @descripcion, @precio)
GO

---- Editar PRODUCTO
CREATE PROC SpEditarProducto
@id INT,
@idCategoria INT,
@idMarca INT,
@descripcion VARCHAR (100),
@precio FLOAT
AS
UPDATE TablaProductos SET 
Descripcion = @descripcion, 
Precio = @precio,
IdCategoria = @idCategoria,
IdMarca = @idMarca
WHERE TablaProductos.Id = @id
GO


------- Eliminar PRODUCTO
CREATE PROC SpEliminarProducto
@idProducto INT
AS 
DELETE TablaProductos 
WHERE TablaProductos.Id = @idProducto
GO


---------  Registrar Usuario
CREATE PROC SpAgregarUsuario
@email VARCHAR (100),
@password VARCHAR (100),
@nombreCompleto VARCHAR (100),
@createDateUser DATETIME
AS
INSERT INTO TablaUsuarios values (@email, @password, @nombreCompleto, @createDateUser)
GO

------ INICIAR SESION
CREATE PROC SpObtenerUsuario
@email VARCHAR (100),
@password VARCHAR (100)
AS
SELECT TablaUsuarios.Email, TablaUsuarios.NombreCompleto FROM TablaUsuarios 
WHERE 
TablaUsuarios.Email = @email AND TablaUsuarios.Pass = @password
GO


exec SpObtenerUsuario 'juanchi@gmail.com', '123'


DECLARE @datetime datetime = '1998-01-01 23:59:59.997';  
exec SpAgregarUsuario 'lalala@gmail.com', '123', 'Jose Eduardo', @datetime