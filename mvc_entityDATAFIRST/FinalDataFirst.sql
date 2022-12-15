drop database atrigosAntigos_dataFirst

create database atrigosAntigos_dataFirst

use atrigosAntigos_dataFirst

create table dbo.Categoria(
	IdCategoria int identity primary key not null,
	NomeCategoria varchar(100) not null
)

create table dbo.Item(
	IdItem int identity primary key not null,
	NomeItem varchar(100) not null,
	CategoriaId int FOREIGN KEY REFERENCES Categoria(IdCategoria),
	DataItem date not null,
	CustoItem Decimal(18,2),
	PrecoItem Decimal(18,2),
	Foto nvarchar(250) null,
	
)

create table dbo.Venda(
	IdVenda int identity primary key not null,
	DataVenda date not null
)

create table dbo.Cliente(
	IdCliente int identity primary key not null,
	NomeCliente varchar(100) not null,
	CpfCliente varchar(14) not null
)