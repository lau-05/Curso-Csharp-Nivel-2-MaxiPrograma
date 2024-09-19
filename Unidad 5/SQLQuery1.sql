-- CONSULTAS SQL

-- LEER
--Select * From TIPOSEDICION
--Select * From Discos
--Select * From ESTILOS
--Select * From DISCOS where idestilo = 2 and CantidadCanciones = 12

Select D.Titulo, D.CantidadCanciones, E.Descripcion as Estilo From DISCOS D, ESTILOS E
where D.IdEstilo = E.Id

-- ESCRIBIR
insert into DISCOS (Titulo, CantidadCanciones) values ('Comes Are You Are', 12)
--
insert into DISCOS values ('Comes Are You Are','1992-04-03 00:00:00',14,'url',4,2)

-- MODIFICAR
update DISCOS set Titulo = 'Obsesionario' where id=1
update DISCOS set Titulo = 'Dynamo' where id=2

-- ELIMINAR
delete from DISCOS where id=4

