create database starlanches;
use starlanches;

create table func(
login varchar(15),
pass varchar(15)
);

create table cli(
usuario varchar(20),
email varchar(60),
senha varchar(20),
nome varchar(50),
cpf varchar(14) Primary Key,
tel varchar(19),
data_nasc varchar(11),
endereco varchar(200),
cep varchar(9),
dir_foto varchar(200)
);

create table prod(
nome_prod varchar(20) Primary Key,
tipo_prod varchar(20),
desc_prod varchar(500),
valor_prod decimal(10,2),
dir_foto varchar(200)
);