--insert into Cliente (nombre) vALUES ('Duván Estiven Gómez Parra'), ('Robert Alexander Gómez Parra'), ('Maicol Andrey Gómez Parra'), ('Yesenia Paola Ramos Valencia'), ('Jhonatan de Jesús Parra Valencia'), ('Danith María Parra Valencia'), ('Leonardo Gómez Gómez')

/*
CREATE TABLE Venta (
    id BIGINT not null IDENTITY Primary Key,
    fecha DATETIME NOT NULL,
    id_cliente BIGINT NOT NULL,
    total DECIMAL(16, 2) NOT NULL,
    foreign key(id_cliente) references Cliente(id) 
)

CREATE TABLE Cliente (
    id BIGINT NOT NULL IDENTITY primary key,
    nombre VARCHAR(50) not null
)

CREATE TABLE Concepto (
    id BIGINT NOT NULL IDENTITY PRIMARY KEY,
    id_venta BIGINT NOT NULL,
    cantidad int NOT NULL,
    precioUnitario DECIMAL(16, 2) NOT NULL,
    importe DECIMAL(16,2) NOT NULL,
    id_producto BIGINT NOT NULL,
    FOREIGN KEY(id_venta) REFERENCES Venta(id),
    FOREIGN KEY(id_producto) REFERENCES Producto(id)
)

CREATE TABLE Producto (
    id BIGINT NOT NULL IDENTITY PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    precioUnitario DECIMAL(16,2) NOT NULL,
    costo DECIMAL(16,0) NOT NULL 
)


INSERT INTO CERVEZA (nombre, marca, alcohol, cantidad) 
values ('Aguila Light','Bavaria', 5,650)

**/



DROP TABLE Cliente

DROP TABLE Concepto

DROP TABLE Producto

DROP TABLE Venta