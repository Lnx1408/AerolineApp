-- parte Neysser ---------------------------------------------------------------------------------------------

use Aereolinea;

CREATE TABLE FLOTA_INFO 
(
  ID_AVION INTEGER 
, MODELO VARCHAR(50) 
, VELOCIDAD INTEGER
, ALTURA VARCHAR(50) 
, CAPACIDAD VARCHAR(50) 
, CONSTRAINT FLOTA_INFO_PK PRIMARY KEY 
  (
    ID_AVION 
  ) 
);

INSERT INTO flota_info (id_avion,modelo,velocidad,altura,capacidad) VALUES (1,'A330_HC-COH - comercial',880,'12500 metros','47000 kilogramos');
INSERT INTO flota_info (id_avion,modelo,velocidad,altura,capacidad) VALUES (2,'A320_HC-COE - comercial',846,'12100 metros.','24200 kilogramos');
INSERT INTO flota_info (id_avion,modelo,velocidad,altura,capacidad) VALUES (3,'A320_HC-CID - comercial',828,'12131 metros.','17600 kilogramos');
INSERT INTO flota_info (id_avion,modelo,velocidad,altura,capacidad) VALUES (4,'A319_HC_CGT - comercial',624,'12300 metros.','15300 kilogramos');
INSERT INTO flota_info (id_avion,modelo,velocidad,altura,capacidad) VALUES (5,'ATR_HC-CMB - carga',440,'7620 metros.','65000 kilogramos');
INSERT INTO flota_info (id_avion,modelo,velocidad,altura,capacidad) VALUES (6,'ATR_HC_CLT - comercial',745,'11680 metros.','16350 kilogramos');
INSERT INTO flota_info (id_avion,modelo,velocidad,altura,capacidad) VALUES (7,'ATR_HC-CMH - comercial',850,'13110 metros.','18320 kilogramos');
INSERT INTO flota_info (id_avion,modelo,velocidad,altura,capacidad) VALUES (8,'EMBRAER_HC-COY - carga',790,'6500 metros.','68000 kilogramos');	


CREATE TABLE "USUARIOS" 
   (	"NOMBRE" VARCHAR(50), 
	"USUARIO" VARCHAR(50), 
	"CONTRASENIA" VARCHAR(50)
   );

ALTER TABLE USUARIOS
ADD UNIQUE (usuario)


-- -----------------------------------------------------------------------------------
create table Destino(
idDestino int,
lugarDestino varchar(40),
Aeropuerto varchar(100),
Ciudad varchar(40),
foto varchar(200));


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

