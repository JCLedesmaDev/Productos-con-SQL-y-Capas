----------------------------------- Creacion de BASE DE DATOS -------------------------------
CREATE DATABASE Productos 
GO 
USE Productos

----------------------------------- Creacion de TABLAS --------------------------------------

CREATE TABLE TablaCategorias (
	Id VARCHAR(3) PRIMARY KEY,
	Descripcion VARCHAR (100) not null
)
GO

CREATE TABLE TablaMarcas (
	Id VARCHAR(3) PRIMARY KEY,
	Descripcion VARCHAR (100) not null
)
GO

CREATE TABLE TablaProductos (
	Id VARCHAR(3) PRIMARY KEY,
	IdCategoria VARCHAR(3) not null,
	IdMarca VARCHAR(3) not null, 
	Descripcion VARCHAR(100) not null,
	Precio VARCHAR(3) not null

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

----- LISTAR PRODUCTOS
CREATE PROC ListarProductos
AS
SELECT 
	TablaProductos.Id, 
	TablaProductos.Descripcion, 
	TablaProductos.Precio, 
	TablaCategorias.Descripcion, 
	TablaMarcas.Descripcion 
FROM TablaProductos 
INNER JOIN 
	TablaCategorias ON TablaProductos.IdCategoria = TablaCategorias.Id
INNER JOIN 
	TablaMarcas ON TablaProductos.IdMarca = TablaMarcas.Id
GO

-----AGREGAR PRODUCTO
CREATE PROC AgregarProducto
@idCategoria INT,
@idMarca INT,
@descripcion NVARCHAR (100),
@precio FLOAT
AS
INSERT INTO TablaProductos values (@idCategoria, @idMarca, @descripcion, @precio)
GO

---- Editar PRODUCTO
CREATE PROC EditarProducto
@id INT,
@idCategoria INT,
@idMarca INT,
@descripcion NVARCHAR (100),
@precio FLOAT
AS
UPDATE TablaProductos SET 
Id=@id, 
Descripcion=@descripcion, 
Precio=@precio,
IdCategoria=@idCategoria,
IdMarca=@idMarca,
Precio=@precio
GO


------- Eliminar PRODUCTO
CREATE PROC EliminarProducto
@idProducto INT
AS 
DELETE TablaProductos 
WHERE TablaProductos.Id = @idProducto









































