-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 10-12-2019 a las 00:52:54
-- Versión del servidor: 10.1.40-MariaDB
-- Versión de PHP: 7.1.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bolera`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `idcliente` varchar(15) NOT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `apellido` varchar(30) DEFAULT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  `correo` varchar(30) DEFAULT NULL,
  `telefono` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`idcliente`, `nombre`, `apellido`, `fecha_nacimiento`, `correo`, `telefono`) VALUES
('1234', 'carlos', 'perez', '0000-00-00', 'carlos@hotmail.com', '12345'),
('12345', 'a', 'a', '0000-00-00', 'a@hotmial.com', '12313'),
('9999', 'Juan', 'Alvear', '2019-12-04', 'juan@hotmail.com', '3000000');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

CREATE TABLE `empleados` (
  `idempleado` varchar(15) NOT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `apellido` varchar(30) DEFAULT NULL,
  `tipo_empleadoid` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `empleados`
--

INSERT INTO `empleados` (`idempleado`, `nombre`, `apellido`, `tipo_empleadoid`) VALUES
('098767', 'Angelly', 'Cabana', 'admin'),
('1', 'pedro', 'bonghonhon', 'meser'),
('1045699210', 'Brayan', 'Lopez', 'admin'),
('1045699211', 'Brayan', 'Lopez', 'admin'),
('1111', 'jorge', 'ojito', 'meser'),
('2', 'jaime', 'garcia', 'meser'),
('3', 'karla', 'ariza', 'admin');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

CREATE TABLE `factura` (
  `idfactura` int(11) NOT NULL,
  `fecha_inicio` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `fecha_entrega` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `pista_id` varchar(10) DEFAULT NULL,
  `total` int(11) DEFAULT NULL,
  `empleado_id` varchar(10) DEFAULT NULL,
  `cliente_id` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `factura`
--

INSERT INTO `factura` (`idfactura`, `fecha_inicio`, `fecha_entrega`, `pista_id`, `total`, `empleado_id`, `cliente_id`) VALUES
(1, '2019-12-04 01:17:13', '2019-12-04 01:17:13', 'pis1', 1000, '1', '9999'),
(2, '2019-12-04 01:18:09', '2019-12-04 01:18:09', 'pis1', 10, '1', '9999'),
(4, '2019-12-04 01:19:32', '2019-12-04 01:19:32', 'pis1', 1, '3', '9999'),
(5, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 'pis1', 13500, '1111', '9999'),
(6, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 'pis2', 91500, '1111', '1234'),
(7, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 'pis2', 13500, '1111', '9999'),
(8, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 'pis2', 13500, '1', '1234'),
(9, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 'pis2', 13500, '1111', '9999'),
(10, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 'pis2', 13500, '1', '1234'),
(11, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 'pis1', 8000, '1045699211', '1234'),
(12, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 'pis1', 13500, '1045699211', '1234'),
(13, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 'pis1', 35000, '1111', '9999'),
(14, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 'pis1', 10000, '1111', '1234'),
(15, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 'pis2', 54000, '1111', '1234'),
(16, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 'pis1', 51000, '1', '1234');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pistas`
--

CREATE TABLE `pistas` (
  `idpista` varchar(10) NOT NULL,
  `nombre` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `pistas`
--

INSERT INTO `pistas` (`idpista`, `nombre`) VALUES
('pis1', 'Pista 1'),
('pis2', 'Pista 2'),
('pis3', 'Pista 3'),
('pis4', 'Pista 4'),
('pis5', 'Pista 5');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `idproducto` varchar(10) NOT NULL,
  `nombre` varchar(20) DEFAULT NULL,
  `descripcion` varchar(50) DEFAULT NULL,
  `costo` int(11) DEFAULT NULL,
  `fecha_creacion` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`idproducto`, `nombre`, `descripcion`, `costo`, `fecha_creacion`) VALUES
('prod1', '15 min Bolos', '15 ministos de juego en pista', 13500, '2019-12-04 03:35:43'),
('prod2', '30 min bolos', '30 minutos de tiempo en las pista', 24000, '2019-12-04 03:36:44'),
('prod3', '1 h bolos', '1 hora de juegos en las pista', 54000, '2019-12-04 03:37:14'),
('prod4', 'calzado', 'calzado para bolos', 4000, '2019-12-04 03:37:42');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productosfacturados`
--

CREATE TABLE `productosfacturados` (
  `factura_id` int(11) DEFAULT NULL,
  `producto_id` varchar(10) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `productosfacturados`
--

INSERT INTO `productosfacturados` (`factura_id`, `producto_id`, `cantidad`) VALUES
(6, 'prod3', 1),
(6, 'prod1', 1),
(6, 'prod2', 1),
(7, 'prod1', 1),
(8, 'prod1', 1),
(9, 'prod1', 1),
(10, 'prod1', 1),
(11, 'prod4', 2),
(12, 'prod1', 1),
(13, 'prod1', 2),
(13, 'prod4', 2),
(14, 'prod3', 5),
(15, 'prod3', 10),
(16, 'prod1', 2),
(16, 'prod2', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipoempleado`
--

CREATE TABLE `tipoempleado` (
  `idtipo` varchar(10) NOT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `descripcion` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipoempleado`
--

INSERT INTO `tipoempleado` (`idtipo`, `nombre`, `descripcion`) VALUES
('admin', 'Administrador', 'Usuarios tipo administrador'),
('Coci', 'Cocinero', 'asdasd'),
('meser', 'Mesero', 'Usuario tipo mesero');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `usuario` varchar(30) NOT NULL,
  `passw` varchar(30) DEFAULT NULL,
  `idempleado` varchar(10) DEFAULT NULL,
  `tipousuario` varchar(10) DEFAULT NULL,
  `fecha_creacion` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`usuario`, `passw`, `idempleado`, `tipousuario`, `fecha_creacion`) VALUES
('a', '1234A.', '2', 'meser', '2019-12-03 04:24:08'),
('admin', '1234A.', '1045699211', 'admin', '2019-12-04 10:16:32'),
('admin2', '1234A.', '1045699210', 'admin', '2019-12-04 16:13:07'),
('angelly', '1234A.', '098767', 'admin', '2019-12-05 16:56:37'),
('bac', '4321B.', '3', 'admin', '2019-12-03 04:26:49');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`idcliente`);

--
-- Indices de la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD PRIMARY KEY (`idempleado`),
  ADD KEY `tipo_empleadoid` (`tipo_empleadoid`);

--
-- Indices de la tabla `factura`
--
ALTER TABLE `factura`
  ADD PRIMARY KEY (`idfactura`),
  ADD KEY `pista_id` (`pista_id`),
  ADD KEY `empleado_id` (`empleado_id`),
  ADD KEY `cliente_id` (`cliente_id`);

--
-- Indices de la tabla `pistas`
--
ALTER TABLE `pistas`
  ADD PRIMARY KEY (`idpista`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`idproducto`);

--
-- Indices de la tabla `productosfacturados`
--
ALTER TABLE `productosfacturados`
  ADD KEY `factura_id` (`factura_id`),
  ADD KEY `producto_id` (`producto_id`);

--
-- Indices de la tabla `tipoempleado`
--
ALTER TABLE `tipoempleado`
  ADD PRIMARY KEY (`idtipo`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`usuario`),
  ADD KEY `idempleado` (`idempleado`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `factura`
--
ALTER TABLE `factura`
  MODIFY `idfactura` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD CONSTRAINT `empleados_ibfk_1` FOREIGN KEY (`tipo_empleadoid`) REFERENCES `tipoempleado` (`idtipo`);

--
-- Filtros para la tabla `factura`
--
ALTER TABLE `factura`
  ADD CONSTRAINT `factura_ibfk_1` FOREIGN KEY (`pista_id`) REFERENCES `pistas` (`idpista`),
  ADD CONSTRAINT `factura_ibfk_2` FOREIGN KEY (`empleado_id`) REFERENCES `empleados` (`idempleado`),
  ADD CONSTRAINT `factura_ibfk_3` FOREIGN KEY (`cliente_id`) REFERENCES `clientes` (`idcliente`);

--
-- Filtros para la tabla `productosfacturados`
--
ALTER TABLE `productosfacturados`
  ADD CONSTRAINT `productosfacturados_ibfk_1` FOREIGN KEY (`factura_id`) REFERENCES `factura` (`idfactura`),
  ADD CONSTRAINT `productosfacturados_ibfk_2` FOREIGN KEY (`producto_id`) REFERENCES `productos` (`idproducto`);

--
-- Filtros para la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`idempleado`) REFERENCES `empleados` (`idempleado`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
