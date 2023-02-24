# DataGridView
Aplicação em C# com banco de dados MySQL de cadastro de informações de usuários

### cadastro.sql:

- create database cadastro;
- use cadastro;
- create table cadastrar(
- id bigint primary key auto_increment not null,
- nome varchar(50),
- endereco varchar (200),
- rg varchar(20),
- cpf int (11)
- );
