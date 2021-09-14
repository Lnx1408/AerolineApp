USE Aereolinea



CREATE TABLE [dbo].[compra](
	[Cedula] [nchar](10) NULL,
	[Nombres] [nchar](50) NULL,
	[Apellidos] [nchar](50) NULL,
	[NumeroPasajeros] [int] NULL,
	[Clase] [nchar](20) NULL,
	[Pais] [nchar](30) NULL,
	[Origen] [nchar](100) NULL,
	[Destino] [nchar](100) NULL,
	[FechaIda] [nchar] (100) NULL,
	[FechaRegreso] [nchar] (100) NULL,
	[ValorTotal] [float] NULL
) ON [PRIMARY]

ALTER TABLE compra
ADD UNIQUE (Cedula)

select * from compra
