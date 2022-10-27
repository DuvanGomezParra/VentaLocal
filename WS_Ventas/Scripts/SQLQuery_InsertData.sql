Select * from cliente;
SELECT * FROM Concepto;
SELECT * FROM Producto;
SELECT * FROM Venta;

--INSERT INTO Producto (nombre, precioUnitario, costo) values('Shampoo Savital', 12500, 10500), ('Acondicionador Savital', 15600, 12000);

--INSERT INTO Concepto (id_venta, cantidad, precioUnitario, importe, id_producto) VALUES (1, 2, 12500, 10, 1)

--INSERT INTO Venta (fecha, id_cliente, total) VALUES (GETDATE(),4, 25000), (GETDATE(),10027, 156000);