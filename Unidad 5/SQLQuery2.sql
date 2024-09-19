 --1. Traer todos los discos con su respectivo estilo. La consulta debe mostrar: Nombre de disco, Fecha de lanzamiento, Estilo (no el id, sino la descripción).
SELECT D.Titulo as 'Nombre del Disco', D.FechaLanzamiento as 'Fecha de Lanzamiento', E.Descripcion as 'Estilo' 
from DISCOS D, ESTILOS E where D.IdEstilo = E.Id

--2. Insertar al menos dos estilos nuevos y un tipo de edición de disco. 
insert into ESTILOS (Descripcion) values ('Hip-Hop'),('Metal')
insert into TIPOSEDICION (Descripcion) values ('Digital')

--3. Insertar al menos dos discos nuevos cargando correctamente su información.
insert into DISCOS values ('Master of Puppets', '1986-03-03', 8, 'https://media.pitchfork.com/photos/5a21b59a6dd6a743aef5aa42/1:1/w_320,c_limit/masterofpuppets.jpg',6, 2) 
insert into DISCOS values ('Illmatic', '1994-04-19', 10, 'https://static.qobuz.com/images/covers/96/24/0886444072496_600.jpg', 5,2)

--4. Actualizar al menos un disco modificando la cantidad de canciones y la fecha de lanzamiento. No te olvides del Where.
update DISCOS set Titulo = 'Nevermind',CantidadCanciones = 13,FechaLanzamiento = '1990-09-24'  where id=5

--5. Borrar un disco a elección.
    --(Asi es como se hace pero no quiero borrarlo) 
    --delete from DISCOS where Titulo = 'Obsesionario';

--6. Traer todos los estilos que estén asociados a algún disco.
select distinct E.Descripcion as 'Estilo' from DISCOS D join ESTILOS E on D.IdEstilo = E.Id;

--7. Traer todos los discos con el siguiente formato: Nombre, Estilo, Edición (todo texto).
select D.Titulo as 'Nombre de Disco', E.Descripcion as 'Estilo', TE.Descripcion as 'Edición' 
from DISCOS D
join ESTILOS E on D.IdEstilo = E.Id
join TIPOSEDICION TE on D.IdTipoEdicion = TE.Id;

--8. Traer todos los discos que contengan en su nombre la letra "e".
select * from DISCOS where Titulo like '%e%';