﻿create table Categorias(
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

create table PeliculasCategorias(
PeliculaCategoriaId int identity(1,1) primary key,
PeliculaId int,
CategoriaId int
);
Create Table PeliculasComentarios(ComentarioId int primary key identity(1,1),PeliculaId int, Comentario varchar(100))