
-- ///////////////////////// EMPLEADOS //////////////////////////////////
-- 1. AGREGAR NUEVO EMPLEADO
DELIMITER $$
CREATE PROCEDURE AgregarEmpleado(IN nombre_empleado VARCHAR(50), direccion_empleado VARCHAR(50), telefono_empleado INT(30), correo_empleado VARCHAR(50), ci_empleado INT(30))
BEGIN
    INSERT INTO Empleado (nombre_empleado, direccion_empleado, telefono_empleado, correo_empleado, ci_empleado)
    VALUES (nombre_empleado, direccion_empleado, telefono_empleado, correo_empleado, ci_empleado);
END $$
DELIMITER ;

-- 2. ACTUALIZAR DATOS DEL EMPLEADO
DELIMITER $$
CREATE PROCEDURE ActualizarEmpleado(IN id int, nombre_empleado varchar(50), direccion_empleado varchar(50), telefono_empleado int(30), correo_empleado varchar(50), ci_empleado int(30))
BEGIN
    UPDATE Empleado
    SET
        nombre_empleado = nombre_empleado,
        direccion_empleado = direccion_empleado,
        telefono_empleado = telefono_empleado,
        correo_empleado = correo_empleado,
        ci_empleado = ci_empleado
    WHERE id_empleado = id;
END $$
DELIMITER ;

-- 3. ELIMINAR EMPLEADO
DELIMITER $$
CREATE PROCEDURE EliminarEmpleado(
    IN id int
)
BEGIN
    DELETE FROM Empleado WHERE id_empleado = id;
END $$
DELIMITER ;


-- 4. BUSCAR EMPLEADO
DELIMITER $$
CREATE PROCEDURE BuscarEmpleado(IN empleado VARCHAR(50))
BEGIN
    SELECT *
    FROM Empleado
    WHERE nombre_empleado LIKE CONCAT(empleado, '%');
END $$
DELIMITER ;

-- 5. OBTENER LISTA DE TODOS LOS EMPLEADOS
DELIMITER $$
CREATE PROCEDURE ObtenerEmpleados()
BEGIN
    SELECT *
    FROM Empleado;
END $$
DELIMITER ;

-- ///////////////////////// PROVEEDORES //////////////////////////////////
-- 6. AGREAR PROVEEDOR
DELIMITER $$
CREATE PROCEDURE AgregarProveedor(
    IN nombre_proveedor VARCHAR(50),
    direccion_proveedor VARCHAR(50),
    telefono_proveedor INT(30),
    correo_proveedor VARCHAR(50),
    nit_proveedor INT(30)
)
BEGIN
    INSERT INTO Proveedor (nombre_proveedor, direccion_proveedor, telefono_proveedor, correo_proveedor, nit_proveedor)
    VALUES (nombre_proveedor, direccion_proveedor, telefono_proveedor, correo_proveedor, nit_proveedor);
END $$
DELIMITER ;

-- 7. ACTUALIZAR DATOS DEL PROVEEDOR
DELIMITER $$
CREATE PROCEDURE ActualizarProveedor(
    IN id INT,
    nombre_proveedor VARCHAR(50),
    direccion_proveedor VARCHAR(50),
    telefono_proveedor INT(30),
    correo_proveedor VARCHAR(50),
    nit_proveedor INT(30)
)
BEGIN
    UPDATE Proveedor
    SET
        nombre_proveedor = nombre_proveedor,
        direccion_proveedor = direccion_proveedor,
        telefono_proveedor = telefono_proveedor,
        correo_proveedor = correo_proveedor,
        nit_proveedor = nit_proveedor
    WHERE id_proveedor = id;
END $$
DELIMITER ;

-- 8. ELIMINAR PROVEEDOR
DELIMITER $$
CREATE PROCEDURE EliminarProveedor(
    IN id INT
)
BEGIN
    DELETE FROM Proveedor WHERE id_proveedor = id;
END $$
DELIMITER ;

-- 9. BUSCAR PROVEEDOR
DELIMITER $$
CREATE PROCEDURE BuscarProveedor(
    IN proveedor VARCHAR(50)
)
BEGIN
    SELECT * FROM Proveedor
    WHERE nombre_proveedor LIKE CONCAT(proveedor, '%');
END $$
DELIMITER ;

-- 10. OBTENER REPORTE DE PROVEEDORES
DELIMITER $$
CREATE PROCEDURE ObtenerProveedores()
BEGIN
    SELECT * FROM Proveedor;
END $$
DELIMITER ;

-- ///////////////////////// CLIENTES //////////////////////////////////
-- 11. AGREGAR NUEVO CLIENTE
DELIMITER $$
CREATE PROCEDURE AgregarCliente(
    IN nombre_cliente VARCHAR(50),
    direccion_cliente VARCHAR(50),
    telefono_cliente INT(30),
    correo_cliente VARCHAR(50),
    nit_cliente INT(30)
)
BEGIN
    INSERT INTO Cliente (nombre_cliente, direccion_cliente, telefono_cliente, correo_cliente, nit_cliente)
    VALUES (nombre_cliente, direccion_cliente, telefono_cliente, correo_cliente, nit_cliente);
END $$
DELIMITER ;

-- 12. ACTUALIZAR DATOS DEL CLIENTE
DELIMITER $$
CREATE PROCEDURE ActualizarCliente(
    IN id INT,
    nombre_cliente VARCHAR(50),
    direccion_cliente VARCHAR(50),
    telefono_cliente INT(30),
    correo_cliente VARCHAR(50),
    nit_cliente INT(30)
)
BEGIN
    UPDATE Cliente
    SET
        nombre_cliente = nombre_cliente,
        direccion_cliente = direccion_cliente,
        telefono_cliente = telefono_cliente,
        correo_cliente = correo_cliente,
        nit_cliente = nit_cliente
    WHERE id_cliente = id;
END $$
DELIMITER ;

-- 13. ELIMINAR CLIENTE
DELIMITER $$
CREATE PROCEDURE EliminarCliente(
    IN id INT
)
BEGIN
    DELETE FROM Cliente WHERE id_cliente = id;
END $$
DELIMITER ;

-- 14. BUSCAR CLIENTE
DELIMITER $$
CREATE PROCEDURE BuscarCliente(
    IN cliente VARCHAR(50)
)
BEGIN
    SELECT * FROM Cliente
    WHERE nombre_cliente LIKE CONCAT(cliente, '%');
END $$
DELIMITER ;


-- 15. OBTENER REPORTE DE CLIENTES
DELIMITER $$
CREATE PROCEDURE ObtenerClientes()
BEGIN
    SELECT * FROM Cliente;
END $$
DELIMITER ;

-- ///////////////////////// PRODUCTOS //////////////////////////////////
-- 16.INSERTAR NUEVO PRODUCTO
DELIMITER $$
CREATE PROCEDURE InsertarProducto(
    IN nombre_producto VARCHAR(100),
    IN marca_producto VARCHAR(50),
    IN descripcion_producto VARCHAR(200),
    IN precio_producto DECIMAL(20,2),
    IN stock_producto INT,
    IN id_categoria INT,
    IN id_proveedor INT
)
BEGIN
    INSERT INTO Productos (
        nombre_producto,
        marca_producto,
        descripcion_producto,
        precio_producto,
        stock_producto,
        id_categoria,
        id_proveedor
    )
    VALUES (
        nombre_producto,
        marca_producto,
        descripcion_producto,
        precio_producto,
        stock_producto,
        id_categoria,
        id_proveedor
    );
END$$
DELIMITER ;

-- 17. ACTUALIZAR PRODUCTO
DELIMITER $$
CREATE PROCEDURE ActualizarProducto(
    IN id_producto_actualizar INT,
    IN nombre_producto VARCHAR(100),
    IN marca_producto VARCHAR(50),
    IN descripcion_producto VARCHAR(200),
    IN precio_producto DECIMAL(20,2),
    IN stock_producto INT,
    IN id_categoria INT,
    IN id_proveedor INT
)
BEGIN
    UPDATE Productos
    SET
        nombre_producto = nombre_producto,
        marca_producto = marca_producto,
        descripcion_producto = descripcion_producto,
        precio_producto = precio_producto,
        stock_producto = stock_producto,
        id_categoria = id_categoria,
        id_proveedor = id_proveedor
    WHERE
        id_producto = id_producto_actualizar;
END$$
DELIMITER ;

-- 18. ELIMINAR PRODUCTO
DELIMITER $$
CREATE PROCEDURE EliminarProducto(
    IN id INT
)
BEGIN
    DELETE FROM Productos WHERE id_producto = id;
END $$
DELIMITER ;

-- 19. Buscar Producto
DELIMITER $$
CREATE PROCEDURE BuscarProducto(
    IN producto VARCHAR(100),
    IN descripcion VARCHAR(200)
)
BEGIN
    SELECT
        *
    FROM
        Productos
    WHERE
        nombre_producto LIKE CONCAT('%', producto, '%')
        OR descripcion_producto LIKE CONCAT('%', descripcion, '%');
END$$
DELIMITER ;

-- 20. OBTENER PRODUCTOS
DELIMITER $$
CREATE PROCEDURE ObtenerProductos()
BEGIN
    SELECT * FROM Productos;
END $$
DELIMITER ;

-- ///////////////////////// CATEGORIAS //////////////////////////////////
-- 21. OBTENER TODAS LAS CATEGORIAS CATEGORIAS
DELIMITER $$

CREATE PROCEDURE ObtenerCategorias()
BEGIN
    SELECT * FROM CategoriaProducto;
END$$

DELIMITER ;

-- ////////////////  REGISTROS /////////////////////
-- 22. OBTENER LISTA DE REGISTROS
DELIMITER $$
CREATE PROCEDURE ObtenerRegistros()
BEGIN
    SELECT * FROM registroeventos;
END $$
DELIMITER ;


-- ////////////////  USUARIOS /////////////////////
-- 23. OBTENER LISTA DE USUARIOS
DELIMITER $$
CREATE PROCEDURE ObtenerUsuarios()
BEGIN
SELECT *
FROM usuarios;
END $$
DELIMITER ;

-- 24. BUSCAR USUARIO
DELIMITER $$
CREATE PROCEDURE BuscarUsuario(IN usuario varchar(200))
BEGIN
SELECT *
FROM usuarios
WHERE nomUsuario LIKE CONCAT(usuario,'%');
END $$
DELIMITER ;

-- 25. INSERTAR USUARIO
DELIMITER $$
CREATE PROCEDURE InsertarUsuario(IN nomUsuario varchar(200), usuario varchar(50), contrasena varchar(10), idPermiso int, idEstado int)
BEGIN
INSERT INTO usuarios (nomUsuario, usuario, contrasena, idPermiso, idEstado)
VALUES (nomUsuario, usuario, contrasena, idPermiso, idEstado);
END $$
DELIMITER ;

-- 26. ACTUALIZAR USUARIO
DELIMITER $$
CREATE PROCEDURE ActualizarUsuario(IN id int, nomUsuario varchar(200), usuario varchar(50), contrasena varchar(10), idPermiso int, idEstado int)
BEGIN
UPDATE usuarios 
SET nomUsuario=nomUsuario, usuario=usuario, contrasena=contrasena, idPermiso=idPermiso, idEstado=idEstado
WHERE idUsuario=id;
END $$
DELIMITER ;

-- ////////////////  LOGIN /////////////////////
-- 27. LOGIN USUARIO
DELIMITER $$
CREATE PROCEDURE LoginUsuario(IN user varchar(50), pass varchar(10))
BEGIN
SELECT *
FROM usuarios
WHERE usuarios.usuario=user AND usuarios.contrasena=pass;
END $$
DELIMITER ;

-- ///////////////////////// ESTADOS //////////////////////////////////
-- 28. OBTENER ESTADOS
DELIMITER $$
CREATE PROCEDURE ObtenerEstados()
BEGIN
SELECT * 
FROM estados;
END $$


-- ///////////////////////// PERMISOS  //////////////////////////////////
-- 29. OBTENER PERMISOS
DELIMITER $$
CREATE PROCEDURE ObtenerPermisos()
BEGIN
SELECT *
FROM permisos;
END $$