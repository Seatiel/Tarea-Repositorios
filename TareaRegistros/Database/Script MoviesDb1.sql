create table Categorias(
CategoriaId int identity(1,1) primary key,
Categoria varchar(50)
);

create table Peliculas(
PeliculaId int identity(1,1) primary key,
Estrenos varchar(50),
Descripcion varchar(50),
CategoriaId int,
Fecha date
);

create table Usuarios(
UsuarioId int identity(1,1) primary key,
NombreUsuario varchar(50),
Clave varchar(50)
);