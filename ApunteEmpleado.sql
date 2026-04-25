--Base de datos para apuntes de empleados en la empresa
CREATE DATABASE ApuntesEmpleados3;
GO

USE ApuntesEmpleados3;
GO

CREATE TABLE Empleados (
	IdEmpleado INT PRIMARY KEY IDENTITY(1,1),
	NombreCompleto NVARCHAR(100) NOT NULL,
	Trabajo NVARCHAR(100) NOT NULL
);
go

create table Apuntes (
	IdApunte INT PRIMARY KEY IDENTITY(1,1),
	Origen NVARCHAR(100) NOT NULL,
	IdEmpleado INT NOT NULL,
	Monto DECIMAL(10, 2) NOT NULL,
	Detalle NVARCHAR(200) NOT NULL,
	Fecha DATETIME NOT NULL default GETDATE()

	CONSTRAINT FK_Empleado FOREIGN KEY (IdEmpleado) REFERENCES Empleados(IdEmpleado)
);
GO

-- Insertar datos de ejemplo
INSERT INTO Empleados (NombreCompleto, Trabajo) VALUES ('Jose Cruz', 'Souvenir'),('Wenderlyn', 'MiniMarket'), ('Jared', 'Restaurante');
go


-- Procedimiento almacenado para insertar un empleado
create or alter procedure sp_InsertarEmpleado
	@NombreCompleto NVARCHAR(100),
	@Trabajo NVARCHAR(100)
AS
BEGIN
	if exists (select 1 from Empleados where NombreCompleto = @NombreCompleto)
	begin
		print 'El empleado ya existe.'
		return
	end
	else
	begin
		INSERT INTO Empleados (NombreCompleto, Trabajo)
		VALUES (@NombreCompleto, @Trabajo);
	end
END
go


-- Procedimiento almacenado para insertar un apunte
create or alter procedure sp_InsertarApunte
	@IdEmpleado INT,
	@Origen NVARCHAR(100),
	@Monto DECIMAL(10, 2),
	@Detalle NVARCHAR(200),
	@Mensaje NVARCHAR(200) OUTPUT,
	@Resultado bit OUTPUT
AS
BEGIN
	IF NOT EXISTS (SELECT 1 FROM Empleados WHERE IdEmpleado = @IdEmpleado)
	BEGIN
		SET @Mensaje = 'El empleado no existe.'
		SET @Resultado = 0
		RETURN
	END
	if @Origen NOT IN ('MiniMarket', 'Souvenir', 'Restaurante')
	BEGIN
		SET @Mensaje = 'El origen no es válido.'
		SET @Resultado = 0
		RETURN
	END
	if @Monto <= 0 or @Monto is null
	BEGIN
		SET @Mensaje = 'El monto es Invalido'
		SET @Resultado = 0
		RETURN
	END
	if @Detalle is null or @Detalle = ''
	BEGIN
		SET @Mensaje = 'El detalle no puede estar vacio.'
		SET @Resultado = 0
		RETURN
	END
	INSERT INTO Apuntes (IdEmpleado, Origen, Monto, Detalle)
	VALUES (@IdEmpleado, @Origen, @Monto, @Detalle);
	SET @Mensaje = 'Apunte agregado correctamente.'
	SET @Resultado = 1
END;
GO

declare @Mensaje NVARCHAR(200), @Resultado bit;
exec sp_InsertarApunte @IdEmpleado = 2, @Origen = 'MiniMarket', @Monto = 2500, @Detalle = 'Papas', @Mensaje = @Mensaje OUTPUT, @Resultado = @Resultado OUTPUT;
exec sp_InsertarApunte @IdEmpleado = 1, @Origen = 'Souvenir', @Monto = 13000, @Detalle = 'Zapatos', @Mensaje = @Mensaje OUTPUT, @Resultado = @Resultado OUTPUT;
exec sp_InsertarApunte @IdEmpleado = 3, @Origen = 'Restaurante', @Monto = 5000, @Detalle = 'Comida', @Mensaje = @Mensaje OUTPUT, @Resultado = @Resultado OUTPUT;
exec sp_InsertarApunte @IdEmpleado = 2, @Origen = 'Souvenir', @Monto = 6500, @Detalle = 'Vestido', @Mensaje = @Mensaje OUTPUT, @Resultado = @Resultado OUTPUT;
exec sp_InsertarApunte @IdEmpleado = 1, @Origen = 'MiniMarket', @Monto = 500, @Detalle = 'Bebidas', @Mensaje = @Mensaje OUTPUT, @Resultado = @Resultado OUTPUT;
exec sp_InsertarApunte @IdEmpleado = 3, @Origen = 'MiniMarket', @Monto = 1200, @Detalle = 'Frutas', @Mensaje = @Mensaje OUTPUT, @Resultado = @Resultado OUTPUT;
exec sp_InsertarApunte @IdEmpleado = 1, @Origen = 'Restaurante', @Monto = 3000, @Detalle = 'Cena', @Mensaje = @Mensaje OUTPUT, @Resultado = @Resultado OUTPUT;
go

create or alter view vw_ApuntesEmpleadosMiniMarket
AS
select
	a.IdApunte,
	e.NombreCompleto,
	a.Origen,
	a.Monto,
	a.Detalle,
	a.Fecha
from Empleados e
left join Apuntes a on e.IdEmpleado = a.IdEmpleado
where a.Origen = 'MiniMarket' and a.IdApunte is not null;
GO

create or alter view vw_ApuntesEmpleadosSouvenir
AS
select
	a.IdApunte,
	e.NombreCompleto,
	a.Origen,
	a.Monto,
	a.Detalle,
	a.Fecha
from Empleados e
left join Apuntes a on e.IdEmpleado = a.IdEmpleado
where a.Origen = 'Souvenir' and a.IdApunte is not null;
GO

create or alter view vw_ApuntesEmpleadosRestaurante
AS
select
	a.IdApunte,
	e.NombreCompleto,
	a.Origen,
	a.Monto,
	a.Detalle,
	a.Fecha
from Empleados e
left join Apuntes a on e.IdEmpleado = a.IdEmpleado
where a.Origen = 'Restaurante' and a.IdApunte is not null;
GO

create or alter view vw_ApuntesEmpleadosHeladeria
AS
select
	a.IdApunte,
	e.NombreCompleto,
	a.Origen,
	a.Monto,
	a.Detalle,
	a.Fecha
	from Empleados e
	left join Apuntes a on e.IdEmpleado = a.IdEmpleado
	where a.Origen = 'Heladeria' and a.IdApunte is not null;
go



-- Procedimiento almaenado para obtener todos los empleados con sus apuntes, quiero que sumen el monto total de cada origen por empleado, pero solo una vez
create or alter procedure sp_ObtenerApuntesEmpleados
AS
BEGIN
	select
		e.NombreCompleto,
		e.Trabajo,
		SUM(CASE WHEN a.Origen = 'MiniMarket' THEN a.Monto ELSE 0 END) AS MiniMarket,
		SUM(CASE WHEN a.Origen = 'Souvenir' THEN a.Monto ELSE 0 END) AS Souvenir,
		SUM(CASE WHEN a.Origen = 'Restaurante' THEN a.Monto ELSE 0 END) AS Restaurante,
		SUM(CASE WHEN a.Origen = 'Heladeria' THEN a.Monto ELSE 0 END) AS Heladeria,
		SUM(a.Monto) AS Total
	from Empleados e
	left join Apuntes a on e.IdEmpleado = a.IdEmpleado
	where a.IdApunte is not null
	group by e.NombreCompleto, e.Trabajo;
END;
GO

select * from vw_ApuntesEmpleadosMiniMarket;
select * from vw_ApuntesEmpleadosSouvenir;
select * from vw_ApuntesEmpleadosRestaurante;
select * from vw_ApuntesEmpleadosHeladeria;
go
exec sp_ObtenerApuntesEmpleados;

USE ApuntesEmpleados3;
GO

USE ApuntesEmpleados3;
GO

-- Crear login con permisos completos
CREATE LOGIN AdminCompleto 
WITH PASSWORD = 'Admin2024!Segura';  -- Cambia esta contraseña
GO

-- Crear usuario en la base de datos
CREATE USER AdminCompleto FOR LOGIN AdminCompleto;
GO

-- Asignar rol de propietario de base de datos (permisos completos)
ALTER ROLE db_owner ADD MEMBER AdminCompleto;
GO

SELECT 'Usuario con permisos completos creado exitosamente' AS Resultado;
GO