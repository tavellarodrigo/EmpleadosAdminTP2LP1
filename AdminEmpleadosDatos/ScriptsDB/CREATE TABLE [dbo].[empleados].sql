CREATE TABLE [dbo].[empleados](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dni] [varchar](50) NULL,
	[nombre_apellido] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[fecha_ingreso] [datetime] NULL,
	[salario] [numeric](18, 2) NULL,
	[dpto_id] [int] NULL,
	[anulado] [bit] NULL,
 CONSTRAINT [PK_empleados] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[empleados] ADD  CONSTRAINT [DF_empleados_anulado]  DEFAULT ((0)) FOR [anulado]
GO

ALTER TABLE [dbo].[empleados]  WITH CHECK ADD  CONSTRAINT [FK_empleados_departamentos] FOREIGN KEY([dpto_id])
REFERENCES [dbo].[departamentos] ([id])
GO

ALTER TABLE [dbo].[empleados] CHECK CONSTRAINT [FK_empleados_departamentos]
GO


