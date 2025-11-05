create database	LabuStore;

use labustore;

create table usuarios(
	id_usuario int primary key auto_increment,
    nome_usuario varchar(100) unique not null,
    senha_usuario varchar(64) not null
);

create table labubus(
	id_labubu int primary key auto_increment,
    nome_labubu varchar(100) not null unique,
    valor_labubu decimal(6,2) not null,
    quantidade_labubu int not null,
    imagem_labubu text
);

insert into usuarios (nome_usuario, senha_usuario) values ('1234', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4');
