-- //////////////////// Triggers para Empleado ///////////////////////
-- Trigger para Empleado (Inserción)
DELIMITER $$
CREATE TRIGGER tr_empleado_after_insert
AFTER INSERT ON Empleado
FOR EACH ROW
BEGIN
    INSERT INTO RegistroEventos (tipo_evento, fecha_registro, id_empleado)
    VALUES ('Inserción Empleado', NOW(), NEW.id_empleado);
END $$
DELIMITER ;
-- Trigger para Empleado (Actualización)
DELIMITER $$
CREATE TRIGGER tr_empleado_after_update
AFTER UPDATE ON Empleado
FOR EACH ROW
BEGIN
    INSERT INTO RegistroEventos (tipo_evento, fecha_registro, id_empleado)
    VALUES ('Actualización Empleado', NOW(), NEW.id_empleado);
END $$
DELIMITER ;

-- Trigger para Empleado (Eliminación)
DELIMITER $$
CREATE TRIGGER tr_empleado_after_delete
AFTER DELETE ON Empleado
FOR EACH ROW
BEGIN
    INSERT INTO RegistroEventos (tipo_evento, fecha_registro, id_empleado)
    VALUES ('Eliminación Empleado', NOW(), OLD.id_empleado);
END $$
DELIMITER ;


-- //////////////////// Triggers para Proveedor ///////////////////////
-- Trigger para Proveedor (Inserción)
DELIMITER $$
CREATE TRIGGER tr_proveedor_after_insert
AFTER INSERT ON Proveedor
FOR EACH ROW
BEGIN
    INSERT INTO RegistroEventos (tipo_evento, fecha_registro, id_proveedor)
    VALUES ('Inserción Proveedor', NOW(), NEW.id_proveedor);
END $$
DELIMITER ;

-- Trigger para Proveedor (Actualización)
DELIMITER $$
CREATE TRIGGER tr_proveedor_after_update
AFTER UPDATE ON Proveedor
FOR EACH ROW
BEGIN
    INSERT INTO RegistroEventos (tipo_evento, fecha_registro, id_proveedor)
    VALUES ('Actualización Proveedor', NOW(), NEW.id_proveedor);
END $$
DELIMITER ;

-- Trigger para Proveedor (Eliminación)
DELIMITER $$
CREATE TRIGGER tr_proveedor_after_delete
AFTER DELETE ON Proveedor
FOR EACH ROW
BEGIN
    INSERT INTO RegistroEventos (tipo_evento, fecha_registro, id_proveedor)
    VALUES ('Eliminación Proveedor', NOW(), OLD.id_proveedor);
END $$
DELIMITER ;


-- //////////////////// Triggers para Clientes ///////////////////////
-- Trigger para Cliente (Inserción)
DELIMITER $$
CREATE TRIGGER tr_cliente_after_insert
AFTER INSERT ON Cliente
FOR EACH ROW
BEGIN
    INSERT INTO RegistroEventos (tipo_evento, fecha_registro, id_cliente)
    VALUES ('Inserción Cliente', NOW(), NEW.id_cliente);
END $$
DELIMITER ;

-- Trigger para Cliente (Actualización)
DELIMITER $$
CREATE TRIGGER tr_cliente_after_update
AFTER UPDATE ON Cliente
FOR EACH ROW
BEGIN
    INSERT INTO RegistroEventos (tipo_evento, fecha_registro, id_cliente)
    VALUES ('Actualización Cliente', NOW(), NEW.id_cliente);
END $$
DELIMITER ;

-- Trigger para Cliente (Eliminación)
DELIMITER $$
CREATE TRIGGER tr_cliente_after_delete
AFTER DELETE ON Cliente
FOR EACH ROW
BEGIN
    INSERT INTO RegistroEventos (tipo_evento, fecha_registro, id_cliente)
    VALUES ('Eliminación Cliente', NOW(), OLD.id_cliente);
END $$
DELIMITER ;


-- //////////////////// Triggers para Productos ///////////////////////
-- Trigger para Productos (Inserción)
DELIMITER $$
CREATE TRIGGER tr_productos_after_insert
AFTER INSERT ON Productos
FOR EACH ROW
BEGIN
    INSERT INTO RegistroEventos (tipo_evento, fecha_registro, id_producto)
    VALUES ('Inserción Producto', NOW(), NEW.id_producto);
END $$
DELIMITER ;

-- Trigger para Productos (Actualización)
DELIMITER $$
CREATE TRIGGER tr_productos_after_update
AFTER UPDATE ON Productos
FOR EACH ROW
BEGIN
    INSERT INTO RegistroEventos (tipo_evento, fecha_registro, id_producto)
    VALUES ('Actualización Producto', NOW(), NEW.id_producto);
END $$
DELIMITER ;

-- Trigger para Productos (Eliminación)
DELIMITER $$
CREATE TRIGGER tr_productos_after_delete
AFTER DELETE ON Productos
FOR EACH ROW
BEGIN
    INSERT INTO RegistroEventos (tipo_evento, fecha_registro, id_producto)
    VALUES ('Eliminación Producto', NOW(), OLD.id_producto);
END $$
DELIMITER ;