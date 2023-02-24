create database cadastro;
use cadastro;
create table cadastrar(
id bigint primary key auto_increment not null,
nome varchar(50),
endereco varchar (200),
rg varchar(20),
cpf int (11)
);

desc cadastrar;

