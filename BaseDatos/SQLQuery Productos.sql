----------------------------------- Creacion de BASE DE DATOS -------------------------------
CREATE DATABASE Productos 
GO 
USE Productos

----------------------------------- Creacion de TABLAS --------------------------------------

CREATE TABLE TablaCategorias (
	Id INT IDENTITY (1,1) PRIMARY KEY,
	Descripcion NVARCHAR (100)
)
GO

CREATE TABLE TablaMarcas (
	Id INT IDENTITY (1,1) PRIMARY KEY,
	Descripcion NVARCHAR (100)
)
GO

CREATE TABLE TablaProductos (
	Id INT IDENTITY (1,1) PRIMARY KEY,
	IdCategoria INT,
	IdMarca INT, 
	Descripcion NVARCHAR(100),
	Precio FLOAT

	-- Relaciones con las otras tablas
	-- Propiedad de navegacion / Propiedad de Referencia / Nombre de la Tabla a la que apunta / Clave primaria de dicha Tabla.
	CONSTRAINT Categoria FOREIGN KEY (IdCategoria) REFERENCES TablaCategorias (Id),
	CONSTRAINT Marca FOREIGN KEY (IdMarca) REFERENCES TablaMarcas (Id)
)
GO

----------------------------------- Mockeos de DATOS de cada Tabla -------------------------------

INSERT INTO TablaCategorias VALUES 
('Laptop'),
('Desktop'),
('Impresora'),
('Monitor'),
('Teclado'),
('Tarjeta'),
('Altavoz')
GO

INSERT INTO TablaMarcas VALUES 
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


----------------------------------- Procedimientos Almacenados ----------------------------------- 

--- Listado Categorias 
CREATE PROC ListarCategorias
AS
SELECT * FROM TablaCategorias ORDER BY Descripcion ASC
GO 

--- Listado Categorias 
CREATE PROC ListarMarcas
AS
SELECT * FROM TablaMarcas ORDER BY Descripcion ASC
GO


-----AGREGAR PRODUCTO
CREATE PROC AgregarProducto
@idcategoria INT,
@idmarca INT,
@descrip NVARCHAR (100),
@prec FLOAT
AS
INSERT INTO TablaProductos values (@idcategoria,@idmarca,@descrip,@prec)
GO

-----LISTAR PRODUCTOS
CREATE PROC ListarProductos
AS
SELECT Id, Descripcion, Precio, TablaCategorias.Descripcion, TablaMarcas.Descripcion 
FROM TablaProductos 
INNER JOIN 
	TablaCategorias ON TablaProductos.IdCategoria = TablaCategorias.Id
INNER JOIN 
	TablaMarcas ON TablaProductos.IdMarca = TablaMarcas.Id
GO



exec ListarMarcas











































