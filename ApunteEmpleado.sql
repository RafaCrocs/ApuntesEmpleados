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

create table HistorialPagos (
	IdPago INT PRIMARY KEY IDENTITY(1,1),
	IdEmpleado INT NOT NULL,
	Monto DECIMAL(10, 2) NOT NULL,
	Detalle NVARCHAR(200) NOT NULL,
	SePagoEn NVARCHAR(100) NOT NULL,
	FechaPago DATETIME NOT NULL default GETDATE(),
	CONSTRAINT FK_EmpleadoPago FOREIGN KEY (IdEmpleado) REFERENCES Empleados(IdEmpleado)
);

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
	if @Origen NOT IN ('MiniMarket', 'Souvenir', 'Restaurante', 'Heladeria')
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

create or alter procedure sp_PagarApunte
	@IdApunte INT,
	@SePagoEn NVARCHAR(20),
	@Mensaje NVARCHAR(200) OUTPUT,
	@Resultado bit OUTPUT
AS
BEGIN
	IF NOT EXISTS (SELECT 1 FROM Apuntes WHERE IdApunte = @IdApunte)
	BEGIN
		SET @Mensaje = 'El apunte no existe.'
		SET @Resultado = 0
		RETURN
	END

	insert into HistorialPagos (IdEmpleado, Monto, Detalle, SePagoEn)
	select IdEmpleado, Monto, Detalle, @SePagoEn from Apuntes where IdApunte = @IdApunte;


	DELETE FROM Apuntes WHERE IdApunte = @IdApunte;
	SET @Mensaje = 'Apunte pagado correctamente.'
	SET @Resultado = 1
END;
GO
--Probar Pagar Apunte
declare @Mensaje NVARCHAR(200), @Resultado bit;
exec sp_PagarApunte @IdApunte = 1, @SePagoEn = 'MiniMarket', @Mensaje = @Mensaje OUTPUT, @Resultado = @Resultado OUTPUT;
go

create or alter view vw_VerHistorialPagos
AS
select
	h.IdPago,
	e.NombreCompleto,
	h.Monto,
	h.Detalle,
	h.SePagoEn,
	h.FechaPago
	from HistorialPagos h
	left join Empleados e on h.IdEmpleado = e.IdEmpleado
GO

select * from vw_VerHistorialPagos
order by FechaPago desc;
go

create or alter view vw_ApuntesEmpleadosMiniMarket
AS
select
	a.IdApunte,
	e.NombreCompleto,
	e.Trabajo,
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
	e.Trabajo,
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
	e.Trabajo,
	a.Origen,
	a.Monto,
	a.Detalle,
	a.Fecha
	from Empleados e
	left join Apuntes a on e.IdEmpleado = a.IdEmpleado
	where a.Origen = 'Heladeria' and a.IdApunte is not null;
go


-- Procedimiento almaenado para obtener todos los empleados con sus apuntes
create or alter procedure sp_ObtenerApuntesEmpleados
AS
BEGIN
	select
		e.NombreCompleto,
		e.IdEmpleado,
		e.Trabajo,
		SUM(CASE WHEN a.Origen = 'MiniMarket' THEN a.Monto ELSE 0 END) AS MiniMarket,
		SUM(CASE WHEN a.Origen = 'Souvenir' THEN a.Monto ELSE 0 END) AS Souvenir,
		SUM(CASE WHEN a.Origen = 'Restaurante' THEN a.Monto ELSE 0 END) AS Restaurante,
		SUM(CASE WHEN a.Origen = 'Heladeria' THEN a.Monto ELSE 0 END) AS Heladeria,
		SUM(a.Monto) AS Total
	from Empleados e
	left join Apuntes a on e.IdEmpleado = a.IdEmpleado
	where a.IdApunte is not null
	group by e.NombreCompleto, e.Trabajo,e.IdEmpleado;
END;
GO

create or alter procedure sp_DetalleApuntes
	@IdEmpleado INT
AS
BEGIN
	select
		a.IdApunte,
		e.NombreCompleto,
		e.Trabajo,
		a.Origen,
		a.Monto,
		a.Detalle,
		a.Fecha
	from Empleados e
	left join Apuntes a on e.IdEmpleado = a.IdEmpleado
	where e.IdEmpleado = @IdEmpleado and a.IdApunte is not null;
END;
GO

select * from vw_ApuntesEmpleadosMiniMarket;
select * from vw_ApuntesEmpleadosSouvenir;
select * from vw_ApuntesEmpleadosRestaurante;
select * from vw_ApuntesEmpleadosHeladeria;

exec sp_ObtenerApuntesEmpleados;