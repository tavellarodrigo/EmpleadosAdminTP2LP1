-- =============================================
-- Author:		Rodrigo
-- Create date: 2022/04/29
-- Description:	Insert de empleado
-- =============================================
CREATE PROCEDURE [dbo].[empleadosInsert]
	@dni varchar(50) ,
	@nombre_apellido varchar(50),
	@direccion varchar(50),
	@fecha_ingreso datetime,
	@salario numeric(18,2),
	@dpto_id int  =null

AS
BEGIN


	INSERT INTO [dbo].[empleados]
           ([dni]
           ,[nombre_apellido]
           ,[direccion]
           ,[fecha_ingreso]
           ,[salario]
           ,[dpto_id])
     VALUES
           (@dni
           ,@nombre_apellido
           ,@direccion
           ,@fecha_ingreso
           ,@salario
           ,@dpto_id)

		   --Con esta consulta devuelvo el ultimo ID generado para la tabla en la que se realizo el insert
		   select SCOPE_IDENTITY()
		  

END
