select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad from POKEMONS P, ELEMENTOS E, ELEMENTOS D where E.Id = P.IdTipo and D.Id = P.IdDebilidad
 
