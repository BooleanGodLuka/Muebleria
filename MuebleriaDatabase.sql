
CREATE DATABASE Muebleria
GO

USE Muebleria
GO

CREATE TABLE Tipo_Usuarios
(
Ctipo_Usuario_TU char(6) PRIMARY KEY  NOT NULL,
Tipo_Usuario varchar(30) NOT NULL,
)
GO

CREATE TABLE Usuarios
(
Cod_Usuario_US int identity(1,1) PRIMARY KEY NOT NULL,
Ctipo_Usuario_US char(6) NOT NULL,
Nombre varchar(30) NOT NULL,
Apellido varchar(30) NOT NULL,
Contraseña varchar (30) NOT NULL,
DNI varchar(10) NOT NULL,
Telefono varchar(20) NULL,
EMail varchar(35) NULL, 
Estado bit DEFAULT 1 NOT NULL,
)
GO

CREATE TABLE Productos
(
Cod_Producto_PRO char(6) PRIMARY KEY NOT NULL,
Nombre_Producto varchar(25) NOT NULL,
Descripcion varchar(400) NULL,
Foto_Producto varchar(100) NOT NULL, 
Color varchar(50) NOT NULL,
Tipo_Madera varchar(20) NULL,
Precio_Unitario money NOT NULL,
Cod_categoria_Prod char (6) NOT null,
Alto float NULL,
Ancho float NULL,
Largo float NULL,
Estado bit NOT NULL,
)
GO


CREATE TABLE Categorias
(
Cod_Categoria_CAT char(6) PRIMARY KEY NOT NULL,
Nombre_Categoria varchar(25) NOT NULL,
)
GO

CREATE TABLE CatxPro
(
Cod_Producto_CxP char(6) NOT NULL,
Cod_Categoria_CxP char(6) NOT NULL,
CONSTRAINT PK_CatxPro PRIMARY KEY (Cod_Producto_CxP,Cod_Categoria_CxP)
)
GO



CREATE TABLE Compras
(
Cod_Compra_CO int identity (1,1) PRIMARY KEY NOT NULL,
Fecha smalldatetime NOT NULL,
Precio_Total money NULL
)
GO


CREATE TABLE Detalle_Compra
(
Cod_Compra_DC int NOT NULL,
Cod_Marca_DC char(6) NOT NULL,
Cod_Producto_DC char(6) NOT NULL,
Cantidad_Comprada int NOT NULL,
Precio_Unitario money NOT NULL
)
GO


--/////////// CONEXIONES ///////////


ALTER TABLE Usuarios
ADD CONSTRAINT FK_USUARIOS FOREIGN KEY (Ctipo_Usuario_US) REFERENCES Tipo_Usuarios (Ctipo_Usuario_TU)


ALTER TABLE CatxPro
ADD CONSTRAINT FK_CatxPro_Productos FOREIGN KEY (Cod_Producto_CxP) REFERENCES Productos (Cod_Producto_PRO)


ALTER TABLE CatxPro
ADD CONSTRAINT FK_CatxPro_Categorias FOREIGN KEY (Cod_Categoria_CxP) REFERENCES Categorias (Cod_Categoria_CAT)


ALTER TABLE Detalle_Compra
ADD CONSTRAINT FK_Detalle_CompraxCompra FOREIGN KEY (Cod_Compra_DC) REFERENCES Compras (Cod_Compra_CO)


ALTER TABLE Detalle_Compra
ADD CONSTRAINT FK_Detalle_CompraxProductos FOREIGN KEY (Cod_Producto_DC) REFERENCES Productos (Cod_Producto_PRO)


ALTER TABLE Productos
ADD CONSTRAINT FK_Productos_Categorias FOREIGN KEY (Cod_categoria_prod) REFERENCES categorias (Cod_Categoria_CAT)
GO

--/////////// CARGA DE DATOS ///////////

insert into Tipo_Usuarios (Ctipo_Usuario_TU, Tipo_Usuario)
select 'tu1', 'Cliente' UNION
select 'tu2','Administrador' UNION
select 'tu3', 'Vendedor' 


insert into Categorias(Cod_Categoria_CAT, Nombre_Categoria)
select'cat1','Dormitorio'UNION
select'cat2','Cocina'UNION
select'cat3','Comedor'UNION
select'cat4','Living'UNION
select'cat5','Exterior'

insert into Productos (Cod_Producto_PRO, Nombre_Producto,Descripcion,Foto_Producto,Color,Tipo_Madera,Precio_Unitario,Alto,Ancho,Largo,Estado,Cod_categoria_Prod)
select 'a1','Sillón Barcelona','dos cuerpos, tapizado con pana','fotos\2219190.jpg','beige','pino',18000,80,150,80,1,'cat4'UNION
select 'a2','Sillón Barcelona','dos cuerpos, tapizado con pana','fotos\2219182.jpg','gris','pino',19000,80,150,80,1,'cat4'UNION
select 'a3','Sillón Concept','tres cuerpos, tapizado Ecocuero','fotos\178101X.jpg','beige','pino',30300,73,220,90,1,'cat4'UNION
select 'a4','Sillón Concept','tres cuerpos, tapizado Ecocuero','fotos\1790994.jpg','marrón','pino',30300,73,220,90,1,'cat4'UNION
select 'a5','Sillón Aero','tres cuerpos, tapizado con pana','fotos\2437066.jpg','gris','pino',27000,73,220,80,1,'cat4'UNION
select 'a6','Estantería Oslo','cinco estantes y un cajón','fotos\2168707.jpg','blanco','pino',6380,180,55,48,1,'cat2'UNION
select 'a7','Biblioteca París','Diseño romántico con molduras','fotos\2343940.jpg','blanco','aglomerado',9800,200,96,37,1,'cat3'UNION
select 'a8','Cómoda Docta','Cuatro cajones','fotos\3009188.jpg','caoba','pino',15200,87,103,47,1,'cat1'UNION
select 'a9','Mesa de Luz Docta','dos cajones','fotos\3009280.jpg','caoba','pino',5900,84,94,40,1,'cat1'UNION
select 'a10','Mesa de Luz Eco','un cajon, una puerta','fotos\3009179_1.jpg','caoba','pino',3500,52,57,40,1,'cat1'UNION
select 'a11','Cama Docta dos plazas','dos plazas','fotos\3009197.jpg','caoba','pino',8800,43,140,190,1,'cat1'UNION
select 'a12','Cama Eco una plaza','una plaza','fotos\3011217_1.jpg','caoba','pino',5200,43,80,190,1,'cat1'UNION
select 'a13','Placard Clásico','interior laqueado','fotos\placard_de_algarrobo_1_50x2_40_mts_1_imagen1.jpg','algarrobo','marrón',17000,240,150,60,1,'cat1'UNION
select 'a14','Silla Campestre','estilo campo','fotos\silla_de_pino_estilo_campo_4_imagen1.jpg','pino','caoba',750,100,50,40,1,'cat3'UNION
select 'a15','Silla para Bebe','silla de pino encolada','fotos\silla_de_comer_para_bebe_campo_imagen1.jpg','pino','marrón',700,155,55,55,1,'cat3'UNION
select 'a16','Modular Cristalero','modular de pino estilo campo encolado encastrado macizo','fotos\modular_cristalero_estilo_campo_de_pino_macizo_0_70_mts_3_imagen1.jpg','marrón','pino',3500,200,80,70,1,'cat3'UNION
select 'a17','Mesa TV','Mesa para TV hasta 60¨ con ruedas incorporadas espacio para dispositivos','fotos\rack_mesa_tv_lcd_led_quartzo_imagen1.jpg','Marrón Marrón ocre','ebano',3599,66,125,40,1,'cat4'UNION
select 'a18','Biblioteca Campestre','biblioteca campestre reforzada capacidad 100 libros aproximadamente','fotos\biblioteca_campestre_alta_imagen1.jpg','Marrón','pino',3899,200,80,39,1,'cat4'UNION
select 'a19','Mesa comedor','mesa comedor cuadrada uniones reforzadas','fotos\mesa_estilo_campo_cuadrada_1_20x1_20_mt_3_imagen1.jpg','Marrón claro','pino',3900,80,120,120,1,'cat3'UNION
select 'a20','Mesa de campo','mesa de campo resistente para exterior','fotos\mesa_estilo_campo_varias_medidas_1_20_1_40_1_60_1_80_2_00_pa_imagen1.jpg','Marrón','nogal',4699,80,120,160,1,'cat5'UNION
select 'a21','Hamaca relax dallas','Hamaca tipo paraguaya','fotos\hamaca-de-madera-relax-dallas-3m-verde-39045933z0-03031767.jpg','Marrón','secoya',6499,200,70,300,1,'cat5'UNION
select 'a22','Reposera relax','reposera tipo persiana plegable con almohadon','fotos\hamaca-madera-persiana-6231145z0-00000067.jpg','Marrón','balau',2600,65,55,90,1,'cat5'UNION
select 'a23','Cama ranchera una plaza','Cama estilo campo reforzada','fotos\cama_cruz_3x3_imagen1.jpg','Marrón claro','pino',4000,90,80,190,1,'cat1'UNION
select 'a24','Cama marinera','cama estilo campo marinera o cucheta reforzada con escalera','fotos\cama_cucheta_superpuesta_eco_imagen1.jpg','Marrón','pino',9000,320,80,190,1,'cat1'UNION
select 'a25','Alacena triple','Alacena con tres puertas tipo campo','fotos\alacena297592659_2.jpg','Marrón','roble',15000,195,170,55,1,'cat2'


insert into CatxPro (Cod_Producto_CxP, Cod_Categoria_CxP)
select'a1','cat4'UNION
select'a2','cat4'UNION
select'a3','cat4'UNION
select'a4','cat4'UNION
select'a5','cat4'UNION
select'a6','cat4'UNION
select'a7','cat4'UNION
select'a8','cat1'UNION
select'a9','cat1'UNION
select'a10','cat1'UNION
select'a11','cat1'UNION
select'a12','cat1'UNION
select'a13','cat1'UNION
select'a14','cat3'UNION
select'a15','cat3'UNION
select'a16','cat2'UNION
select'a17','cat4'UNION
select'a18','cat4'UNION
select'a19','cat3'UNION
select'a20','cat3'UNION
select'a21','cat5'UNION
select'a22','cat5'UNION
select'a23','cat1'UNION
select'a24','cat1'UNION
select'a25','cat2'

insert into Usuarios (Ctipo_Usuario_US,Nombre,Apellido,Contraseña,DNI,Telefono,EMail,Estado)
select 'tu2','Luciano Gonzalo','Fredes','1234','41897127','1164009455','LGF@ghmail.com',1 Union
select 'tu1','Alexis','Rodriguez','11110','41000000','1164009455','AR@ghmail.com',1 Union
select 'tu3','Rocio','Favre','2222','40111111','1164009455','RF@ghmail.com',1 

insert into Compras (Fecha,Precio_Total)
select GETDATE(),0UNION
select GETDATE(),0 

--delete from Compras

--DBCC CHECKIDENT ( Compras, RESEED, 0 )


insert into Detalle_Compra(Cod_Compra_DC,Cod_Producto_DC,Cod_Marca_DC,Cantidad_Comprada,Precio_Unitario)
select 1,'a14','m4',10,7000 
GO




--/////////// TRIGGERS /////////// Esta parte tendria que ir en otra consulta, create trigger debe ser la unica instruccion del lote

CREATE TRIGGER Disminuirstock
ON Detalle_Factura
AFTER INSERT
AS
BEGIN
SET NOCOUNT ON;
DECLARE @CodMarca CHAR(6), @CodProducto CHAR(6), @CantidadVendida INT
SELECT @CodMarca = Cod_Marca_DF, @CodProducto = Cod_Producto_DF,
@CantidadVendida = Cantidad_Vendida FROM INSERTED
UPDATE ProductosxMarcas set Stock = Stock - @CantidadVendida
where Cod_Marca_PxM = @CodMarca and Cod_Producto_PxM = @CodProducto
END
GO

CREATE TRIGGER Aumentarstock
ON Detalle_Compra
AFTER INSERT
AS
BEGIN
SET NOCOUNT ON;
DECLARE @CodMarca CHAR(6), @CodProducto CHAR(6), @CantidadComprada INT
SELECT @CodMarca = Cod_Marca_DC, @CodProducto = Cod_Producto_DC,
@CantidadComprada = Cantidad_Comprada FROM INSERTED
UPDATE ProductosxMarcas set Stock = Stock + @CantidadComprada
where Cod_Marca_PxM = @CodMarca and Cod_Producto_PxM = @CodProducto
END
GO

CREATE TRIGGER TotalizarCompra
ON Detalle_Compra
AFTER INSERT
AS
BEGIN
SET NOCOUNT ON;
DECLARE @Cod_Compra_DC char(6), @PrecioTotal Money 
select @Cod_Compra_DC = Cod_Compra_DC , @PrecioTotal= Cantidad_Comprada * Precio_Unitario FROM INSERTED
UPDATE Compras set Precio_Total = Precio_Total + @PrecioTotal 
where Cod_Compra_CO = @Cod_Compra_DC
END
GO


CREATE TRIGGER TotalizarFactura
ON Detalle_Factura
AFTER INSERT
AS
BEGIN
SET NOCOUNT ON;
DECLARE @Cod_Factura_DF char(6), @PrecioTotal Money 
select @Cod_Factura_DF = Cod_Factura_DF , @PrecioTotal= Cantidad_Vendida * Precio_Unitario FROM INSERTED
UPDATE Facturas set Precio_Total = Precio_Total + @PrecioTotal 
where Cod_Factura_F = @Cod_Factura_DF
END
GO



CREATE PROCEDURE ProductosxCategoriasGetProductos
@Cod_Categoria char(6)	
AS
SET NOCOUNT ON;
Select * From CatxPro
where  Cod_Categoria_CxP = @Cod_Categoria
GO
 
 Execute ProductosxCategoriasGetProductos @Cod_Categoria='cat1';
 GO