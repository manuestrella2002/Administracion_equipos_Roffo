CREATE DATABASE  IF NOT EXISTS `db_roffo` /*!40100 DEFAULT CHARACTER SET utf8mb3 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `db_roffo`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: db_roffo
-- ------------------------------------------------------
-- Server version	8.0.36

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `actualizacion_ordenes_de_trabajo`
--

DROP TABLE IF EXISTS `actualizacion_ordenes_de_trabajo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `actualizacion_ordenes_de_trabajo` (
  `id_actualizacion` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(2000) NOT NULL,
  `Fecha_actualizacion` datetime NOT NULL,
  `Id_orden_de_trabajo` int NOT NULL,
  PRIMARY KEY (`id_actualizacion`),
  KEY `Id_orden_de_trabajo_idx` (`Id_orden_de_trabajo`),
  CONSTRAINT `Id_orden_de_trabajo` FOREIGN KEY (`Id_orden_de_trabajo`) REFERENCES `orden_de_trabajo` (`Id_orden`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `actualizacion_ordenes_de_trabajo`
--

LOCK TABLES `actualizacion_ordenes_de_trabajo` WRITE;
/*!40000 ALTER TABLE `actualizacion_ordenes_de_trabajo` DISABLE KEYS */;
INSERT INTO `actualizacion_ordenes_de_trabajo` VALUES (1,'Faltan lamparas de repuesto, se comenzo la compra y se esta esperando que salga.','2024-06-30 00:30:16',20),(2,'Rechazaron la compra, se devuelve al servicio.','2024-06-30 00:30:54',20),(3,'Derivado a Herreria','2024-06-30 01:46:34',20),(4,'Se comunico a los electricistas que vayan a revisar','2024-06-30 19:11:43',27);
/*!40000 ALTER TABLE `actualizacion_ordenes_de_trabajo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipo`
--

DROP TABLE IF EXISTS `equipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `equipo` (
  `Id_equipo` int NOT NULL AUTO_INCREMENT,
  `Nombre_equipo` varchar(45) NOT NULL,
  `Modelo_equipo` varchar(45) DEFAULT NULL,
  `Marca_equipo` varchar(45) DEFAULT NULL,
  `Nro_serie_equipo` varchar(45) DEFAULT NULL,
  `Fecha_fabricacion_equipo` datetime DEFAULT NULL,
  `Fecha_adquisicion_equipo` datetime DEFAULT NULL,
  `Ubicacion_equipo` varchar(45) DEFAULT NULL,
  `Status_equipo` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id_equipo`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipo`
--

LOCK TABLES `equipo` WRITE;
/*!40000 ALTER TABLE `equipo` DISABLE KEYS */;
INSERT INTO `equipo` VALUES (1,'Electrocardiografo','Modelo GH','Elekta','7542','2024-02-03 09:42:30','2024-01-23 18:09:24','En oficina','Operativo'),(3,'Ecografo','Modelo C','Philips','1861','2023-11-01 21:33:22','2024-01-16 18:24:28','En oficina','Fuera de servicio'),(4,'Respirador','Modelo D','Toshiba Medical Systems','7994','2024-05-16 23:08:39','2024-01-16 21:45:16','Investigaciones','Operativo'),(5,'Monitor multiparametrico','Modelo E','Hitachi Medical Systems','3480','2024-01-13 14:47:25','2024-01-20 05:26:52','En oficina','Fuera de servicio'),(6,'Bomba de infusion','Modelo F','Fujifilm Medical Systems','1262','2024-03-05 23:46:49','2024-01-07 14:36:08','Imagenes','Operativo'),(7,'Analizador de gases en sangre','Modelo G','Shimadzu Medical Systems','4852','2024-03-24 20:23:12','2024-01-04 07:27:48','En oficina','Operativo'),(8,'Electroencefalografo','Modelo H','Canon Medical Systems','8202','2024-03-17 14:18:12','2024-01-20 00:39:48','Investigaciones','Fuera de servicio'),(9,'Tubo rayos x','Modelo I','Mindray','4901','2023-09-14 02:56:05','2024-01-01 06:09:40','Quirofano','Fuera de servicio'),(10,'Bobina magnetica','Modelo J','Hologic','3509','2023-11-23 12:08:26','2024-01-15 18:36:07','En oficina','Fuera de servicio'),(11,'Endoscopio','Modelo K','Karl Storz','8704','2023-11-12 21:57:48','2024-01-07 05:52:05','Imagenes','Fuera de servicio'),(12,'Lampara quirurgica','Modelo L','Stryker','7086','2024-01-26 13:27:22','2024-01-19 02:02:59','En oficina','Fuera de servicio'),(13,'Camara hiperbarica','Modelo M','Olympus Medical','9250','2024-06-05 00:51:24','2024-01-25 14:29:12','Imagenes','Fuera de servicio'),(14,'Maquina de anestesia','Modelo N','Varian Medical Systems','9177','2023-10-05 21:51:44','2024-01-16 17:29:11','En oficina','Fuera de servicio'),(15,'Doppler vascular','Modelo O','Elekta','9178','2023-06-28 09:52:56','2024-01-23 00:56:03','En oficina','Operativo'),(16,'Oftalmoscopio','Modelo P','Zimmer Biomet','9751','2024-03-19 15:21:26','2024-01-29 04:53:00','Quirofano','Fuera de servicio'),(17,'Audiometro','Modelo Q','Boston Scientific','7992','2023-12-26 23:17:59','2024-01-16 02:24:05','En oficina','Fuera de servicio'),(18,'Holter','Modelo R','Medtronic','7335','2024-04-16 10:41:35','2024-01-03 10:27:14','Quirofano','Fuera de servicio'),(19,'Laser quirurgico','Modelo S','Abbott Laboratories','5536','2023-11-07 22:51:02','2024-01-14 18:03:33','En oficina','Fuera de servicio'),(20,'Estimulador neuromuscular','Modelo T','Roche Diagnostics','7081','2023-07-02 10:45:32','2024-01-19 19:12:47','En oficina','Fuera de servicio'),(29,'Camara hiperbarica','DCF','Toshiba Medical Systems','569','2024-06-22 18:14:17','2024-06-22 18:14:17','Imagenes','Operativo'),(31,'Tensiometro','20','Coronet','3568','2024-06-22 18:32:20','2024-06-22 18:32:20','En oficina','Fuera de servicio');
/*!40000 ALTER TABLE `equipo` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `equipo_AFTER_UPDATE` AFTER UPDATE ON `equipo` FOR EACH ROW BEGIN
    IF NEW.Status_equipo = 'Fuera de Servicio' AND OLD.Status_equipo != 'Fuera de Servicio' THEN
        INSERT INTO orden_de_trabajo (Descripcion,Fecha_creacion_orden, equipo_Id_equipo)
        VALUES ('Equipo marcado como fuera de servicio', NOW(),NEW.Id_equipo);
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `equipo_BEFORE_DELETE` BEFORE DELETE ON `equipo` FOR EACH ROW BEGIN
    UPDATE orden_de_trabajo
    SET equipo_Id_equipo = NULL
    WHERE equipo_Id_equipo = OLD.Id_equipo;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `grupo_electrogeno`
--

DROP TABLE IF EXISTS `grupo_electrogeno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `grupo_electrogeno` (
  `Id_grupo` int NOT NULL AUTO_INCREMENT,
  `Nombre_grupo` varchar(45) NOT NULL,
  `Status_grupo` varchar(45) NOT NULL,
  `Combustible_grupo` varchar(45) NOT NULL,
  PRIMARY KEY (`Id_grupo`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grupo_electrogeno`
--

LOCK TABLES `grupo_electrogeno` WRITE;
/*!40000 ALTER TABLE `grupo_electrogeno` DISABLE KEYS */;
INSERT INTO `grupo_electrogeno` VALUES (1,'Bioterio','Operativo','Gasoil Premium'),(2,'Resonador','Operativo','Gasoil Comun'),(3,'Ultrafreezers','Fuera de Servicio','Gasoil Premium'),(4,'Patologia','Fuera de servicio','Gasoil Comun'),(5,'Hemoterapia','Operativo','Gasoil Premium'),(6,'UTI','Operativo','Gasoil Comun'),(7,'Cirugia','Operativo','Gasoil Premium');
/*!40000 ALTER TABLE `grupo_electrogeno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventario`
--

DROP TABLE IF EXISTS `inventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `inventario` (
  `Id_parte` int NOT NULL AUTO_INCREMENT,
  `Nombre_parte` varchar(45) NOT NULL,
  `Marca_parte` varchar(45) DEFAULT NULL,
  `Cantidad_disponible` int NOT NULL,
  `Descripcion` varchar(2000) DEFAULT NULL,
  `proveedor_Id_proveedor` int DEFAULT NULL,
  PRIMARY KEY (`Id_parte`),
  KEY `fk_inventario_proveedor1_idx` (`proveedor_Id_proveedor`),
  CONSTRAINT `fk_inventario_proveedor1` FOREIGN KEY (`proveedor_Id_proveedor`) REFERENCES `proveedor` (`Id_proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventario`
--

LOCK TABLES `inventario` WRITE;
/*!40000 ALTER TABLE `inventario` DISABLE KEYS */;
INSERT INTO `inventario` VALUES (1,'Resistor 2k2','Texas Instruments',5,NULL,21),(2,'Capacitor 30uF','Intel',1,NULL,21),(3,'Transistor PNP','Analog Devices',8,NULL,21),(4,'Diodo 1N4007','Microchip',6,NULL,21),(5,'LED azul','STMicroelectronics',9,NULL,21),(6,'Inductor','NXP',5,NULL,21),(7,'Transformador 9v220v','Infineon',10,NULL,21),(8,'Circuito integrado','Toshiba',4,NULL,21),(9,'Potenciometro 330k','ON Semiconductor',4,NULL,21),(10,'Rele 6 contactos','Vishay',6,NULL,21),(11,'Fusible 3A','Maxim Integrated',3,NULL,21),(12,'Interruptor','Renesas',8,NULL,21),(13,'Conector','Fairchild',7,NULL,21),(14,'Batería','Samsung',5,NULL,21),(15,'Antena','Panasonic',5,NULL,NULL),(16,'Cristal oscilador 30 MHz','Sony',4,NULL,21),(17,'Microcontrolador PIC16F84','Philips',3,NULL,21),(18,'Display de 7 segmentos','Broadcom',1,NULL,21),(19,'Sensor agua','Xilinx',7,NULL,21),(20,'Memoria EEPROM','Rohm',5,NULL,21),(21,'tuerca',NULL,2,NULL,NULL),(22,'perno',NULL,1,NULL,NULL),(23,'perno2vc',NULL,2,NULL,NULL);
/*!40000 ALTER TABLE `inventario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orden_de_trabajo`
--

DROP TABLE IF EXISTS `orden_de_trabajo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orden_de_trabajo` (
  `Id_orden` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(2000) NOT NULL,
  `Fecha_creacion_orden` datetime NOT NULL,
  `Fecha_fin_orden` datetime DEFAULT NULL,
  `equipo_Id_equipo` int DEFAULT NULL,
  `Lugar_orden` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id_orden`),
  KEY `fk_orden_de_trabajo_equipo1_idx` (`equipo_Id_equipo`),
  CONSTRAINT `fk_orden_de_trabajo_equipo1` FOREIGN KEY (`equipo_Id_equipo`) REFERENCES `equipo` (`Id_equipo`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orden_de_trabajo`
--

LOCK TABLES `orden_de_trabajo` WRITE;
/*!40000 ALTER TABLE `orden_de_trabajo` DISABLE KEYS */;
INSERT INTO `orden_de_trabajo` VALUES (1,'Evaluacion de estado en tomografo computarizado (CT)','2024-04-03 15:09:11',NULL,NULL,'Bioterio'),(2,'Verificacion y ajuste de presion en sistema de vacio para liposuccion','2024-05-20 17:26:23',NULL,NULL,'Imagenes'),(3,'Diagnostico y reparacion de problema en lampara quirurgica','2024-04-03 22:41:52',NULL,8,'Quirofano'),(4,'Sincronizacion y ajuste en equipo de terapia laser','2023-12-30 09:17:09',NULL,NULL,'UTI'),(5,'Instalacion de nuevo sensor Doppler vascular','2024-05-03 15:04:50','2024-06-27 08:28:41',NULL,'UTI'),(6,'Sustitucion de baterias en desfibrilador externo','2024-03-12 19:38:50',NULL,NULL,'UTI'),(7,'Verificacion y ajuste de presion en sistema de vacio para liposuccion','2024-01-05 03:19:01',NULL,NULL,'UTI'),(8,'Revision y mantenimiento preventivo de electrocardiografo','2024-02-12 19:16:22',NULL,NULL,'UTI'),(9,'Reparacion de falla en ecografo abdominal','2023-12-22 23:25:34',NULL,NULL,'Imagenes'),(10,'Recambio de piezas en bomba de infusion','2024-04-26 08:16:15',NULL,NULL,'UTI'),(11,'Inspeccion de sistema de iluminacion en quirofano','2023-11-03 22:34:15',NULL,NULL,'Bioterio'),(12,'Ajuste de frecuencia en electroencefalografo (EEG)','2023-12-17 05:44:57','2024-06-22 16:13:08',NULL,'Imagenes'),(13,'Verificacion y ajuste de presion en sistema de vacio para liposuccion','2023-10-23 20:22:27','2024-06-22 16:13:04',NULL,'UTI'),(14,'Diagnostico y reparacion de problema en lampara quirurgica','2023-11-10 00:07:15',NULL,NULL,'Quirofano'),(15,'Inspeccion y limpieza profunda de endoscopio flexible','2024-01-21 20:55:32',NULL,NULL,'UTI'),(16,'Calibracion y prueba de funcionamiento en camara hiperbarica','2024-03-03 09:01:45',NULL,13,'Quirofano'),(17,'Inspeccion y limpieza profunda de endoscopio flexible','2023-10-24 18:49:00','2024-06-22 16:03:07',NULL,'Quirofano'),(18,'Actualizacion de firmware en maquina de anestesia','2024-01-28 21:47:54',NULL,NULL,'Quirofano'),(19,'Sincronizacion y ajuste en equipo de terapia laser','2024-01-16 22:51:26',NULL,NULL,'UTI'),(20,'Diagnostico y reparacion de problema en lampara quirurgica','2024-06-02 21:51:44',NULL,NULL,'Medicina nuclear'),(21,'Baño tapado del dr pepe','2024-06-22 16:51:37','2024-06-23 20:06:56',NULL,'Investigaciones'),(22,'Centrifuga no funciona nose','2024-06-22 16:54:09','2024-06-23 20:07:00',10,'Quirofano'),(23,'No me anda el tensiometro','2024-06-22 18:31:45','2024-06-22 18:33:51',31,'UTI'),(24,'No funcionan las calderas en 2do piso costa','2024-06-23 08:52:55','2024-06-23 08:53:09',NULL,'2do Costa'),(25,'Caldera no funciona','2024-06-23 09:03:46','2024-06-23 09:03:58',NULL,'2do Costa'),(26,'hola','2024-06-26 08:05:46','2024-06-26 08:06:11',29,'Quirofano'),(27,'Hay olor a quemado en laboratorio','2024-06-30 19:10:53',NULL,NULL,'Laboratorio Central');
/*!40000 ALTER TABLE `orden_de_trabajo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `proveedor` (
  `Id_proveedor` int NOT NULL AUTO_INCREMENT,
  `Nombre_proveedor` varchar(45) NOT NULL,
  `Nro_Direccion_proveedor` int DEFAULT NULL,
  `Calle_Direccion_proveedor` varchar(45) DEFAULT NULL,
  `Localidad_Direccion_proveedor` varchar(45) DEFAULT NULL,
  `Mail_proveedor` varchar(45) DEFAULT NULL,
  `Telefono_proveedor` bigint DEFAULT NULL,
  PRIMARY KEY (`Id_proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES (1,'Biotrust',7363,'Avenida Corrientes','CABA','biotrust@mail.com',1112345678),(2,'Massini',3799,'Avenida de Mayo','CABA','massini@mail.com',1123456789),(3,'Nucleolab',7739,'Avenida 9 de Julio','CABA','nucleolab@mail.com',1134567890),(4,'Compania cientifica',6850,'Calle Florida','CABA','companiacientifica@mail.com',1145678901),(5,'Siemmens',9418,'Avenida Santa Fe','CABA','siemmens@mail.com',1156789012),(6,'GE',6374,'Avenida Belgrano','CABA','ge@mail.com',1167890123),(7,'Mindray',1166,'Calle Defensa','CABA','mindray@mail.com',1178901234),(8,'Taussem',6853,'Avenida Cordoba','CABA','taussem@mail.com',1189012345),(9,'Veolia',8526,'Calle Lavalle','CABA','veolia@mail.com',1190123456),(10,'Meditec SRL',2936,'Avenida Rivadavia','CABA','meditec@mail.com',1111223344),(11,'Bioingenieria del Plata',4156,'Calle Suipacha','CABA','bioingenieriadelplata@mail.com',1122334455),(12,'Tecno Hospitalaria',2024,'Calle Tucuman','CABA','tecnohospitalaria@mail.com',1133445566),(13,'Biomedica Argentina',6850,'Calle Esmeralda','CABA','biomedicaargentina@mail.com',1144556677),(14,'Servimed',2954,'Calle Reconquista','CABA','servimed@mail.com',1155667788),(15,'Techno Medical',5530,'Avenida Callao','CABA','technomedical@mail.com',1166778899),(16,'Electromedical Solutions',8893,'Calle San Martin','CABA','electromedicalsolutions@mail.com',1177889900),(18,'Equipos Medicos Argenmed',3506,'Avenida Pueyrredon','CABA','equiposmedicosargenmed@mail.com',1199001122),(19,'Biomedic',4899,'Calle Bolivar','CABA','biomedic@mail.com',1110102020),(20,'Hospitalar',9201,'Calle Sarmiento','CABA','hospitalar@mail.com',1112345678),(21,'Microelectronica',1455,'Tte. Gral. J. D. Peron','CABA','ventas@microelectronicash.com',1143710123);
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reparacion_externa`
--

DROP TABLE IF EXISTS `reparacion_externa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reparacion_externa` (
  `Id_reparacion_externa` int NOT NULL AUTO_INCREMENT,
  `Fecha_salida` datetime NOT NULL,
  `Fecha_reentrada` datetime DEFAULT NULL,
  `equipo_Id_equipo` int NOT NULL,
  `proveedor_Id_proveedor` int NOT NULL,
  `reporte_proovedor` varchar(2000) DEFAULT NULL,
  PRIMARY KEY (`Id_reparacion_externa`),
  KEY `fk_Reparacion_externa_equipo1_idx` (`equipo_Id_equipo`),
  KEY `fk_Reparacion_externa_proveedor1_idx` (`proveedor_Id_proveedor`),
  CONSTRAINT `fk_Reparacion_externa_equipo1` FOREIGN KEY (`equipo_Id_equipo`) REFERENCES `equipo` (`Id_equipo`),
  CONSTRAINT `fk_Reparacion_externa_proveedor1` FOREIGN KEY (`proveedor_Id_proveedor`) REFERENCES `proveedor` (`Id_proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reparacion_externa`
--

LOCK TABLES `reparacion_externa` WRITE;
/*!40000 ALTER TABLE `reparacion_externa` DISABLE KEYS */;
INSERT INTO `reparacion_externa` VALUES (1,'2024-06-21 13:25:16','2024-06-21 13:29:21',3,1,'Se cambio la placa del equipo'),(2,'2024-06-30 16:14:20','2024-06-30 17:55:30',17,11,'Se cambio electronica');
/*!40000 ALTER TABLE `reparacion_externa` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `reparacion_externa_AFTER_INSERT` AFTER INSERT ON `reparacion_externa` FOR EACH ROW BEGIN
    -- Verificar si la fecha de reentrada es NULL
    DECLARE nombre VARCHAR(100);
    
    -- Obtener el nombre del proveedor de la reparación
    SELECT p.nombre_proveedor INTO nombre FROM proveedor AS p
    JOIN reparacion_externa  AS re ON p.Id_proveedor=re.proveedor_Id_proveedor
    WHERE Id_reparacion_externa = NEW.Id_reparacion_externa;
   
   IF NEW.fecha_reentrada IS NULL THEN
        -- Actualizar el estado del equipo a "Equipo en reparación externa"
        UPDATE equipo
        SET Ubicacion_equipo = CONCAT('Equipo en taller de ', nombre)
        WHERE Id_equipo = NEW.equipo_Id_equipo;
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `reparacion_externa_AFTER_UPDATE` AFTER UPDATE ON `reparacion_externa` FOR EACH ROW BEGIN
    -- Verificar si se actualizó la fecha de reentrada
    IF NEW.fecha_reentrada IS NOT NULL AND OLD.fecha_reentrada IS NULL THEN
        -- Actualizar el estado del equipo a "En oficina"
        UPDATE equipo
        SET Ubicacion_equipo = 'En oficina'
        WHERE Id_equipo = NEW.equipo_Id_equipo;
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `reparacion_externa_AFTER_DELETE` AFTER DELETE ON `reparacion_externa` FOR EACH ROW BEGIN
    UPDATE equipo
    SET Status_equipo = 'En oficina'
    WHERE Id_equipo = OLD.equipo_Id_equipo;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `reporte_equipo`
--

DROP TABLE IF EXISTS `reporte_equipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reporte_equipo` (
  `Id_reporte_equipo` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(2000) NOT NULL,
  `Fecha` datetime NOT NULL,
  `equipo_Id_equipo` int NOT NULL,
  PRIMARY KEY (`Id_reporte_equipo`),
  KEY `fk_Reporte_equipo_equipo1_idx` (`equipo_Id_equipo`),
  CONSTRAINT `fk_Reporte_equipo_equipo1` FOREIGN KEY (`equipo_Id_equipo`) REFERENCES `equipo` (`Id_equipo`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reporte_equipo`
--

LOCK TABLES `reporte_equipo` WRITE;
/*!40000 ALTER TABLE `reporte_equipo` DISABLE KEYS */;
INSERT INTO `reporte_equipo` VALUES (1,'Se hizo seguridad electrica','2024-06-30 21:14:05',7),(2,'Se midio temperatura','2024-06-30 21:15:33',7);
/*!40000 ALTER TABLE `reporte_equipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reporte_grupo_electrogeno`
--

DROP TABLE IF EXISTS `reporte_grupo_electrogeno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reporte_grupo_electrogeno` (
  `Id_reporte_grupo` int NOT NULL AUTO_INCREMENT,
  `Fecha` datetime NOT NULL,
  `Observaciones_grupo` varchar(2000) DEFAULT NULL,
  `Refrigerante` varchar(45) NOT NULL,
  `Nivel_Aceite` varchar(45) NOT NULL,
  `Nivel_Agua_Bateria` varchar(45) DEFAULT NULL,
  `Nivel_Combustible` int unsigned NOT NULL,
  `Voltaje_Bateria_Reposo` decimal(2,0) unsigned NOT NULL,
  `Voltaje_Bateria_Carga` decimal(2,0) unsigned DEFAULT NULL,
  `Frecuencia` decimal(2,0) unsigned DEFAULT NULL,
  `RPM` int unsigned DEFAULT NULL,
  `Temperatura` decimal(2,0) unsigned DEFAULT NULL,
  `Presion_Aceite` decimal(2,0) unsigned DEFAULT NULL,
  `HorasUso` int unsigned DEFAULT NULL,
  `Minutos_uso` int unsigned DEFAULT NULL,
  `Numero_Arranques` int unsigned DEFAULT NULL,
  `V_Generador_R` int unsigned DEFAULT NULL,
  `V_Generador_S` int unsigned DEFAULT NULL,
  `V_Generador_T` int unsigned DEFAULT NULL,
  `V_Linea_R` int unsigned DEFAULT NULL,
  `V_Linea_S` int unsigned DEFAULT NULL,
  `V_Linea_T` int unsigned DEFAULT NULL,
  `A_Generador_R` int unsigned DEFAULT NULL,
  `A_Generador_S` int unsigned DEFAULT NULL,
  `A_Generador_T` int unsigned DEFAULT NULL,
  `Estado` varchar(45) NOT NULL,
  `grupo_electrogeno_Id_grupo` int NOT NULL,
  `A_Linea_R` int unsigned DEFAULT NULL,
  `A_Linea_S` int unsigned DEFAULT NULL,
  `A_Linea_T` int unsigned DEFAULT NULL,
  PRIMARY KEY (`Id_reporte_grupo`),
  KEY `fk_Report_grupo_electrogeno_grupo_electrogeno1_idx` (`grupo_electrogeno_Id_grupo`),
  CONSTRAINT `fk_Report_grupo_electrogeno_grupo_electrogeno1` FOREIGN KEY (`grupo_electrogeno_Id_grupo`) REFERENCES `grupo_electrogeno` (`Id_grupo`)
) ENGINE=InnoDB AUTO_INCREMENT=74 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reporte_grupo_electrogeno`
--

LOCK TABLES `reporte_grupo_electrogeno` WRITE;
/*!40000 ALTER TABLE `reporte_grupo_electrogeno` DISABLE KEYS */;
INSERT INTO `reporte_grupo_electrogeno` VALUES (53,'2024-06-24 22:28:47',NULL,'OK','OK',NULL,15,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'Operativo',2,0,0,0),(54,'2024-06-30 22:28:47',NULL,'OK','OK',NULL,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'Fuera de servicio',3,0,0,0),(55,'2024-06-30 22:28:47',NULL,'OK','OK',NULL,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'Fuera de servicio',4,0,0,0),(56,'2024-06-30 22:28:48',NULL,'OK','OK OSCURO','OK',23,0,0,0,NULL,0,0,NULL,NULL,NULL,0,NULL,NULL,NULL,NULL,NULL,0,0,0,'Operativo',5,0,0,0),(57,'2024-06-30 22:28:48',NULL,'OK','OK',NULL,24,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'Operativo',7,0,0,0),(58,'2024-06-30 22:28:48',NULL,'OK','OK OSCURO','OK',22,0,0,0,NULL,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'Operativo',6,0,0,0),(59,'2024-06-30 22:28:48',NULL,'OK','OK OSCURO',NULL,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'Operativo',1,0,0,0),(60,'2024-06-30 22:29:40',NULL,'OK','OK',NULL,25,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'Operativo',2,0,0,0),(61,'2024-06-30 22:29:41',NULL,'OK','OK OSCURO',NULL,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'Fuera de servicio',3,0,0,0),(62,'2024-06-30 22:29:41',NULL,'OK','OK OSCURO',NULL,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'Fuera de servicio',4,0,0,0),(63,'2024-06-30 22:29:41',NULL,'OK','OK OSCURO','OK',14,0,0,0,NULL,0,0,NULL,NULL,NULL,0,NULL,NULL,NULL,NULL,NULL,0,0,0,'Operativo',5,0,0,0),(64,'2024-06-30 22:29:41',NULL,'OK','OK OSCURO',NULL,52,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'Operativo',7,0,0,0),(65,'2024-06-30 22:29:41',NULL,'OK','OK OSCURO','OK',17,0,0,0,NULL,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'Operativo',6,0,0,0),(66,'2024-06-30 22:29:41',NULL,'OK','OK OSCURO',NULL,45,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'Operativo',1,0,0,0),(67,'2024-07-02 22:30:30',NULL,'OK','OK',NULL,32,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'Operativo',2,0,0,0),(68,'2024-06-30 22:30:30',NULL,'OK','OK OSCURO',NULL,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'Fuera de servicio',3,0,0,0),(69,'2024-06-30 22:30:31',NULL,'OK','OK OSCURO',NULL,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'Fuera de servicio',4,0,0,0),(70,'2024-06-30 22:30:33',NULL,'OK','OK OSCURO','OK',25,0,0,0,NULL,0,0,NULL,NULL,NULL,0,NULL,NULL,NULL,NULL,NULL,0,0,0,'Operativo',5,0,0,0),(71,'2024-06-30 22:30:34',NULL,'OK','OK OSCURO',NULL,20,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'Operativo',7,0,0,0),(72,'2024-06-30 22:30:34',NULL,'OK','OK OSCURO','OK',14,0,0,0,NULL,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'Operativo',6,0,0,0),(73,'2024-06-30 22:30:35',NULL,'OK','OK',NULL,25,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'Operativo',1,0,0,0);
/*!40000 ALTER TABLE `reporte_grupo_electrogeno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'db_roffo'
--

--
-- Dumping routines for database 'db_roffo'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-06-30 22:47:25
