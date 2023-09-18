CREATE TABLE [dbo].[empleados](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dni] [varchar](50) NULL,
	[nombre_apellido] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[fecha_ingreso] [datetime] NULL,
	[salario] [numeric](18, 2) NULL,
	[dpto_id] [int] NULL
 CONSTRAINT [PK_empleados] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[empleados] ADD  CONSTRAINT [DF_empleados_anulado]  DEFAULT ((0)) FOR [anulado]
GO


