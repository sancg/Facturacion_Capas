/*---	DISPARADORES O TRIGGERS PARA LA INSERCIÓN	----
-----   DE NUEVOS DATOS EN LA TABLA PRODUCTOS		----*/

USE DB_FACTURAS
GO

SELECT * FROM tblSeguridad
IF OBJECT_ID ('TR_Producto_Insert') is not null
	BEGIN
		drop trigger TR_Producto_Insert
	END

CREATE TRIGGER TR_Producto_Insert
	on tblProductos for insert
	AS
		SET NOCOUNT ON
		DECLARE @Nombre NVARCHAR(100),
				@Referencia NVARCHAR(30),
				@NumStock INT,
				@Usuario NVARCHAR(130)
		BEGIN
		IF ()
			INSERT INTO LOG_Productos
		END