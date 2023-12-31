﻿ALTER PROCEDURE [dbo].[empleadosGet]
	--parametros
	@id int = null,
	@nombre_apellido varchar(50) = null
AS
BEGIN
	--cuerpo del procedimiento 
	select e.*,d.nombre_dpto from empleados e
	left join departamentos d on e.dpto_id = d.id
	where (e.id = @id or @id is null)
	and (e.nombre_apellido = @nombre_apellido or @nombre_apellido is null)
END
