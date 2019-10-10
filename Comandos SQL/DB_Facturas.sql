/*---NOTA: Para una comprensión mayor se documentará lo necesario
-----@Autor: Santiago Cano González - Guía N2 ACCESO A DATOS
-----Creación de la base de datos*/

CREATE DATABASE DB_FACTURAS
GO

USE DB_FACTURAS
GO

/* Creación de Tablas*/

/*---- TABLA CLIENTES	----*/
CREATE TABLE tblCliente
(
	idCliente INT IDENTITY(1,1),
	strNombreCliente NVARCHAR(130)not null,
	cedulaCliente BIGINT not null,
	strDireccionCliente NVARCHAR(130),
	celularCliente BIGINT not null,
	strEmailCliente NVARCHAR(130),
	dtmFechaModificacion DATETIME not null DEFAULT GETDATE(),
	strUsuarioModifica NVARCHAR(130),
	PRIMARY KEY (CedulaCliente)
)
GO

/*Datos de ejemplo Cliente*/
INSERT INTO tblCliente (strNombreCliente, cedulaCliente, strDireccionCliente, celularCliente, strEmailCliente) 
VALUES ('Santiago', 1234989392, 'Cll 40A Sur #67-131', 3013280291, 's.cano1090@pascualbravo.edu.co')
INSERT INTO tblCliente (strNombreCliente, cedulaCliente, strDireccionCliente, celularCliente, strEmailCliente) 
VALUES ('Julian Taborda', 234412123, 'cll la esperanza', 3013232123, 'j.taborda@gmail.com')

SELECT * FROM tblCliente ORDER BY idCliente
GO

/*----	TABLA ROLES DE EMPLEADO	----*/
CREATE TABLE tblPuestoEmpleado
(
	idRolEmpleado INT IDENTITY(1,1),
	strDescripcion NVARCHAR(130) not null,
	PRIMARY KEY (idRolEmpleado)
)
GO

/*Datos de ejemplos Tipo de empleado*/
INSERT INTO tblPuestoEmpleado values('Gerente')
INSERT INTO tblPuestoEmpleado values('Desarrollador')
INSERT INTO tblPuestoEmpleado values('Soporte Técnico')
INSERT INTO tblPuestoEmpleado values('Comisionado de ventas')

SELECT * FROM tblPuestoEmpleado ORDER BY idRolEmpleado
GO

/*----	TABLA EMPLEADO	----*/
CREATE TABLE tblEmpleado
(
	idEmpleado BIGINT not null,
	strNombreEmpleado NVARCHAR(130) not null,
	cedulaEmpleado BIGINT not null,
	strDireccionEmpleado NVARCHAR(130) not null,
	strEmailEmpleado NVARCHAR(130),
	idRolEmpleado INT not null,
	dtmIngresoEmpleado DATETIME not null,
	dtmRetiroEmpleado DATETIME not null,
	strDatosAdicionales NVARCHAR(340),
	dtmFechaModificacion DATETIME not null DEFAULT GETDATE(),
	strUsuarioModifica NVARCHAR(130),
	PRIMARY KEY (idEmpleado),
	FOREIGN KEY (idRolEmpleado) REFERENCES tblPuestoEmpleado (idRolEmpleado) ON DELETE CASCADE ON UPDATE CASCADE
)
GO

/*Dato de ejemplo para Empleado*/
INSERT INTO tblEmpleado (idEmpleado, strNombreEmpleado, CedulaEmpleado, strDireccionEmpleado, strEmailEmpleado, idRolEmpleado, dtmIngresoEmpleado, dtmRetiroEmpleado, strDatosAdicionales)
VALUES (12461231, 'Mario Bros', 412423, 'Cll 70 #41-23', 'sdawaw@gmail.com', 5, '04/06/1900', GETDATE(), 'Muy buena persona')
INSERT INTO tblEmpleado (idEmpleado, strNombreEmpleado, CedulaEmpleado, strDireccionEmpleado, strEmailEmpleado, idRolEmpleado, dtmIngresoEmpleado, dtmRetiroEmpleado, strDatosAdicionales)
VALUES (124, 'Santiago Cano', 1234989392, 'Cll 230 #41-23', 'mariadwa@gmail.com', 2, '04/06/2000', GETDATE(), 'Intentando mejorar el sistema')

SELECT * FROM tblEmpleado
GO

/*---- TABLA ESTADO-FACTURA	----*/
CREATE TABLE tblEstadoFactura
(
	idEstado INT IDENTITY(1,1),
	strEstado NVARCHAR(40),
	PRIMARY KEY (idEstado)
)
GO

/*Datos de ejemplo estado*/
INSERT INTO tblEstadoFactura VALUES('Pagado')
INSERT INTO tblEstadoFactura VALUES('Pendiente')

SELECT * FROM tblEstadoFactura
GO

/*----	TABLA FACTURA	----*/
CREATE TABLE tblFactura
(
	idFactura INT IDENTITY(1,1),
	dtmFechaGeneracion DATETIME not null DEFAULT GETDATE(),
	cedulaCliente BIGINT not null,
	idEmpleado BIGINT not null,
	numeroDescuento FLOAT,
	valorImpuesto FLOAT not null,
	valorTotal FLOAT not null,
	idEstado INT not null,
	dtmFechaModificacion DATETIME not null DEFAULT getdate(),
	strUsuarioModifica NVARCHAR(130),
	PRIMARY KEY (idFactura),
	FOREIGN KEY (cedulaCliente) REFERENCES tblCliente(cedulaCliente),
	FOREIGN KEY (idEmpleado) REFERENCES tblEmpleado(idEmpleado) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (idEstado) REFERENCES
	tblEstadoFactura ON DELETE CASCADE ON UPDATE CASCADE
)
GO

/*Datos de comprobración*/
INSERT INTO tblFactura (dtmFechaGeneracion, CedulaCliente, idEmpleado, valorImpuesto, valorTotal, idEstado)
VALUES ('12/31/2054', 1234989392, 12461231, 0.19, 190.002003 , 1)
INSERT INTO tblFactura (dtmFechaGeneracion, CedulaCliente, idEmpleado, valorImpuesto, valorTotal, idEstado)
VALUES ('12/31/2054', 1234989392, 124, 0.19, 1304.25 , 2)

SELECT * FROM tblFactura
GO

/*----	TABLA DE SEGURIDAD	----*/
CREATE TABLE tblSeguridad
(
	idSeguridad NVARCHAR(40) not null,
	idEmpleado BIGINT not null,
	strUsuario NVARCHAR(100) not null,
	Password NVARCHAR(100) not null,
	dtmFechaModificacion DATETIME not null DEFAULT GETDATE(),
	strUsuarioModifica NVARCHAR(130) not null DEFAULT 'Desarrollador'
	PRIMARY KEY (idSeguridad),
	FOREIGN KEY (idEmpleado) REFERENCES
	tblEmpleado (idEmpleado) ON DELETE CASCADE ON UPDATE CASCADE
)
GO

CREATE UNIQUE INDEX strUsuario ON tblSeguridad (strUsuario)

INSERT INTO tblSeguridad (idSeguridad, idEmpleado, strUsuario, Password)
VALUES ('S1-0001', 12461231, 'venta', '123')
INSERT INTO tblSeguridad (idSeguridad, idEmpleado, strUsuario, Password) 
VALUES ('S1-0002', 124, 'dev', '123')

select * from tblSeguridad
GO

/*----	TABLA DE SUBCATEGORIAS	----*/
CREATE TABLE tblSubCategoria
(
	refSubCategoria NVARCHAR(12) not null,
	strNombreSubCategoria NVARCHAR(30) not null,
	PRIMARY KEY (refSubCategoria)
)
GO

CREATE UNIQUE INDEX strNombreSubCategoria on tblSubCategoria (strNombreSubCategoria)

/*Datos de ejemplo*/
INSERT INTO tblSubCategoria VALUES('REF-1001', 'Smartphone')
INSERT INTO tblSubCategoria VALUES('REF-1002', 'Computador portátil')
INSERT INTO tblSubCategoria VALUES('REF-1003', 'Computador de escritorio')
INSERT INTO tblSubCategoria VALUES('REF-3001', 'Natación')
INSERT INTO tblSubCategoria VALUES('REF-3002', 'Fútbol')

SELECT * FROM tblSubCategoria order by refSubCategoria
GO

/*----	TABLA DE CATEGORIAS	----*/
CREATE TABLE tblCategoriaProducto
(
	idCategoria INT IDENTITY not null,
	strNombreCategoria NVARCHAR(30) not null,
	refSubCategoria NVARCHAR(12) not null,
	dtmFechaModifica DATETIME not null DEFAULT GETDATE(),
	strUsuarioModifico NVARCHAR(130),
	PRIMARY KEY (idCategoria),
	FOREIGN KEY (refSubCategoria) REFERENCES 
	tblSubCategoria (refSubCategoria) ON DELETE CASCADE ON UPDATE CASCADE
)
GO

/*Datos de comprobación*/
INSERT INTO tblCategoriaProducto (strNombreCategoria, refSubCategoria) VALUES ('Tecnología', 'REF-1001')
INSERT INTO tblCategoriaProducto (strNombreCategoria, refSubCategoria) VALUES ('Electrodomésticos', 'REF-2000') --ERROR INTENSIONAL Solucionar en code.
INSERT INTO tblCategoriaProducto (strNombreCategoria, refSubCategoria) VALUES ('Deporte', 'REF-3001')

select * from tblCategoriaProducto
GO

CREATE TABLE tblProductos
(
	idProducto INT IDENTITY(1,1),
	strNombre NVARCHAR(100) not null,
	strReferencia NVARCHAR(30) not null,
	numPrecioCompra FLOAT not null,
	numPrecioVenta FLOAT not null,
	idCategoria INT not null,
	strDetalle NVARCHAR(250) not null,
	strForo	NVARCHAR(30) not null,
	numStock INT not null,
	dtmFechaModifica DATETIME not null DEFAULT GETDATE(),
	strUsuarioModifico NVARCHAR(130),
	PRIMARY KEY (idProducto),
	FOREIGN KEY (idCategoria) REFERENCES tblCategoriaProducto (idCategoria) ON DELETE CASCADE ON UPDATE CASCADE
)
GO

/*Datos de comprobación*/
INSERT INTO tblProductos (strNombre, strReferencia, numPrecioCompra, numPrecioVenta, idCategoria, strDetalle, strForo, numStock)
VALUES ('Iphone Xs','Celular marca apple', 1233.99, 1300.40, 1, 'No se que contiene', 'no se para que sirve', 15)

SELECT strNombre, strReferencia, numPrecioVenta, strDetalle, strNombreCategoria, strNombreSubCategoria, numStock FROM tblProductos
inner join tblCategoriaProducto on tblCategoriaProducto.idCategoria = tblProductos.idCategoria
inner join tblSubCategoria on tblSubCategoria.refSubCategoria = tblCategoriaProducto.refSubCategoria
GO

/*---	Ensayo de historial para PRODUCTOS	---*/
CREATE TABLE LOG_Productos
(
	strNombreProducto NVARCHAR(100),
	strReferencia NVARCHAR(30),
	numStock INT,
	strUsuarioModifica NVARCHAR(130),
	dtmFechaModifica DATETIME DEFAULT GETDATE()
)
