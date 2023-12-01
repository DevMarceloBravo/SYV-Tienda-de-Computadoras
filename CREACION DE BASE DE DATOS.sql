 -- Creacion Base de Datos
CREATE DATABASE TiendaComputadoras;
USE TiendaComputadoras;

-- EMPLEADO
CREATE TABLE Empleado (
    id_empleado INT AUTO_INCREMENT PRIMARY KEY,
    nombre_empleado VARCHAR(50),
    direccion_empleado VARCHAR(50),
    telefono_empleado INT(30),
    correo_empleado VARCHAR(50),
    ci_empleado BIGINT(30)
);

-- PROVEEDOR
CREATE TABLE Proveedor (
    id_proveedor INT AUTO_INCREMENT PRIMARY KEY,
    nombre_proveedor VARCHAR(50),
    direccion_proveedor VARCHAR(50),
    telefono_proveedor INT(30),
    correo_proveedor VARCHAR(50),
    nit_proveedor BIGINT(30)
);

-- CLIENTE
CREATE TABLE Cliente (
    id_cliente INT AUTO_INCREMENT PRIMARY KEY,
    nombre_cliente VARCHAR(50),
    direccion_cliente VARCHAR(50),
    telefono_cliente INT(30),
    correo_cliente VARCHAR(50),
    nit_cliente BIGINT(30)
);


--  CATEGORIA DE PRODUCTOS
CREATE TABLE CategoriaProductos (
    id_categoria INT AUTO_INCREMENT PRIMARY KEY,
    nombre_categoria VARCHAR(50)
);

-- PRODUCTOS
CREATE TABLE Productos (
    id_producto INT AUTO_INCREMENT PRIMARY KEY,
    nombre_producto VARCHAR(100),
    marca_producto VARCHAR(50),
    descripcion_producto VARCHAR(200),
    precio_producto DECIMAL(20,2),
    stock_producto INT(20),
    id_categoria INT,
    id_proveedor INT,
    FOREIGN KEY (id_categoria) REFERENCES CategoriaProductos(id_categoria),
    FOREIGN KEY (id_proveedor) REFERENCES Proveedor(id_proveedor)
);

-- VENTA
CREATE TABLE Venta (
    id_venta INT AUTO_INCREMENT PRIMARY KEY,
    fecha_venta DATETIME,
    id_empleado INT,
    id_cliente INT,
    FOREIGN KEY (id_empleado) REFERENCES Empleado(id_empleado),
    FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente)
);

-- DETALLE DE VENTA
CREATE TABLE DetalleVenta (
    id_detalle INT AUTO_INCREMENT PRIMARY KEY,
    id_venta INT,
    id_producto INT,
    cantidad INT(50),
    precio_unitario DECIMAL(20,2),
    FOREIGN KEY (id_venta) REFERENCES Venta(id_venta),
    FOREIGN KEY (id_producto) REFERENCES Productos(id_producto)
);

-- Crear tabla RegistroEventos
CREATE TABLE RegistroEventos (
    id_evento INT AUTO_INCREMENT PRIMARY KEY,
    tipo_evento VARCHAR(50) NOT NULL,
    fecha_registro DATETIME NOT NULL,
    id_empleado INT,
    id_cliente INT,
    id_proveedor INT,
    id_producto INT
);

-- Tabla de Permisos
CREATE TABLE permisos (
    idPermiso INT AUTO_INCREMENT PRIMARY KEY,
    permiso VARCHAR(50) NOT NULL
);

-- Tabla de Estados
CREATE TABLE estados (
    idEstado INT AUTO_INCREMENT PRIMARY KEY,
    estado BOOLEAN NOT NULL,
    descripcion VARCHAR(10) NOT NULL
);

-- Tabla de Usuarios
CREATE TABLE usuarios (
    idUsuario INT AUTO_INCREMENT PRIMARY KEY,
    nomUsuario VARCHAR(200) NOT NULL,
    usuario VARCHAR(50) NOT NULL,
    contrasena VARCHAR(10) NOT NULL,
    idPermiso INT NOT NULL,
    idEstado INT NOT NULL,
    CONSTRAINT fk_usuario_permiso FOREIGN KEY (idPermiso) REFERENCES permisos (idPermiso),
    CONSTRAINT fk_usuario_estado FOREIGN KEY (idEstado) REFERENCES estados (idEstado)
);