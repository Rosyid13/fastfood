CREATE DATABASE Fastfood

USE Fastfood

CREATE TABLE pelanggan(
id_pelanggan int identity(1,1) primary key not null,
nama varchar(50) not null,
total int not null
)

CREATE TABLE makanan(
id_makanan int identity(1,1) primary key not null,
nama char(15) not null,
harga int not null
)

CREATE TABLE pesanan(
id_pesanan int identity(1,1) primary key not null,
qty int not null,
subtotal int not null,
id_pelanggan int foreign key references pelanggan(id_pelanggan),
id_makanan int foreign key references makanan(id_makanan)
)

SELECT * FROM makanan
INSERT INTO makanan VALUES ('Calzone', 35000)
INSERT INTO makanan VALUES ('Chicago Style', 38000)
INSERT INTO makanan VALUES ('Greek Pizza', 34000)

select * from pelanggan