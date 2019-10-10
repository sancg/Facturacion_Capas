/*---	@Autor: Santiago Cano González	---*/

/*---	PROCEDIMIENTOS ALMACENADOS PARA DB_FACTURAS	---*/
Use DB_FACTURAS
GO

IF Object_id ('p_ValidacionUsuario') is not null
	BEGIN
		Drop proc p_ValidacionUsuario
	END
GO

CREATE PROCEDURE p_ValidacionUsuario
	@User nvarchar(100),
	@Pass nvarchar(100)
AS
	BEGIN
	  SELECT tblSeguridad.idEmpleado, strNombreEmpleado as 'Nombre del Empleado', tblPuestoEmpleado.strDescripcion, strEmailEmpleado, strUsuario, Password FROM tblSeguridad 
	  inner join tblEmpleado on tblEmpleado.idEmpleado = tblSeguridad.idEmpleado 
	  inner join tblPuestoEmpleado on tblPuestoEmpleado.idRolEmpleado = tblEmpleado.idRolEmpleado
	  WHERE strUsuario = 'admin' and Password = 'admin';
	END

	select * from tblEmpleado