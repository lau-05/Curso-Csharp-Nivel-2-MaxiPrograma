select * from DISCOS
select * from ESTILOS
select * from TIPOSEDICION

update DISCOS set UrlImagenTapa = '' where Id = 2
update DISCOS set UrlImagenTapa = 'https://www.infobae.com/new-resizer/BfZZXCLnDFdHYIgwP2x2ckbany4=/arc-anglerfish-arc2-prod-infobae/public/K3OAMSV6CVG4XIRRZC2Q3XE6UY.jpg' where Id = 5

select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion as Estilo, T.Descripcion as Edicion from DISCOS D, ESTILOS E, TIPOSEDICION T where E.Id = D.IdEstilo and T.Id = D.IdTipoEdicion