create database dbs_comercio
go
use dbs_comercio

go

create TABLE tblusuarios(
	Pkcodigo varchar(20) PRIMARY KEY,
    Nombre varchar(5000),
    Contacto varchar(10),
    Correo varchar(10),
    Direccion varchar(200)
)


create TABLE tblcomprador(
	Pkcodigo varchar(10) PRIMARY KEY,
    Nombre varchar(5000),
    Contacto varchar(10),
    Correo varchar(10),
    Direccion varchar(200)
)


create TABLE tblcategoria(
	Pkcodigo bigint identity(0,1) PRIMARY KEY,
    Descripcion varchar(5000),
    Nomenclatura varchar(10)
)


create TABLE tblestado(
	Pkcodigo bigint identity(0,1) PRIMARY KEY,
    Descripcion varchar(5000),
    Nomenclatura varchar(10)
)


create table  tblproductos(
	Pkcodigo varchar(20) PRIMARY KEY,
    Nombre varchar(200) not null,
    Existencia bigint not null,
    Valor_compra float not null,
    Ganancia float not null,
    Fkcodigo_tblcategoria bigint not null,
    Especificaciones varchar(5000) not null,
    Valor_venta float  not null,
    Fkcodigo_tblestado bigint not null,
    Fkid_tblusuario varchar(20) not null,  
)


create table tblfactura(
	Pknfactura bigint identity(1,1) PRIMARY KEY,
    Fkid_tblcomprador varchar(10) not null,
    Fecha date not null,
    Hora time not null,
    Fkcodigo_tblproductos varchar(20) not null,
    Fkcodigo_tblestado1 bigint not null,
	Valor_venta float not null
)



