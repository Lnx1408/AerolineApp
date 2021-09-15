use Aereolinea;

--drop table Destino;

create table Destino(
idDestino int,
lugarDestino varchar(20),
Aeropuerto varchar(20),
Ciudad varchar(20),
foto varchar(200));

select idDestino, lugarDestino, Aeropuerto, Ciudad, foto from Destino;

select idDestino, lugarDestino, Aeropuerto, Ciudad, foto from destino group by lugarDestino;
-- delete from Destino;
select max(idDestino)+1 as numero from destino;