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
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipo`
--

LOCK TABLES `equipo` WRITE;
/*!40000 ALTER TABLE `equipo` DISABLE KEYS */;
INSERT INTO `equipo` VALUES (1,'Electrocardiografo','Modelo A','Siemens','7542','2024-02-03 09:42:30','2024-01-23 18:09:24','En oficina','Fuera de servicio'),(2,'Desfibrilador','Modelo B','GE Healthcare','7854','2023-12-28 17:34:13','2024-01-17 01:08:30','Investigaciones','Fuera de servicio'),(3,'Ecografo','Modelo C','Philips','1861','2023-11-01 21:33:22','2024-01-16 18:24:28','En oficina','Fuera de servicio'),(4,'Respirador','Modelo D','Toshiba Medical Systems','7994','2024-05-16 23:08:39','2024-01-16 21:45:16','Investigaciones','Operativo'),(5,'Monitor multiparametrico','Modelo E','Hitachi Medical Systems','3480','2024-01-13 14:47:25','2024-01-20 05:26:52','En oficina','Fuera de servicio'),(6,'Bomba de infusion','Modelo F','Fujifilm Medical Systems','1262','2024-03-05 23:46:49','2024-01-07 14:36:08','Imagenes','Operativo'),(7,'Analizador de gases en sangre','Modelo G','Shimadzu Medical Systems','4852','2024-03-24 20:23:12','2024-01-04 07:27:48','En oficina','Operativo'),(8,'Electroencefalografo','Modelo H','Canon Medical Systems','8202','2024-03-17 14:18:12','2024-01-20 00:39:48','Investigaciones','Fuera de servicio'),(9,'Tubo rayos x','Modelo I','Mindray','4901','2023-09-14 02:56:05','2024-01-01 06:09:40','Quirofano','Fuera de servicio'),(10,'Bobina magnetica','Modelo J','Hologic','3509','2023-11-23 12:08:26','2024-01-15 18:36:07','En oficina','Fuera de servicio'),(11,'Endoscopio','Modelo K','Karl Storz','8704','2023-11-12 21:57:48','2024-01-07 05:52:05','Imagenes','Fuera de servicio'),(12,'Lampara quirurgica','Modelo L','Stryker','7086','2024-01-26 13:27:22','2024-01-19 02:02:59','En oficina','Fuera de servicio'),(13,'Camara hiperbarica','Modelo M','Olympus Medical','9250','2024-06-05 00:51:24','2024-01-25 14:29:12','Imagenes','Fuera de servicio'),(14,'Maquina de anestesia','Modelo N','Varian Medical Systems','9177','2023-10-05 21:51:44','2024-01-16 17:29:11','En oficina','Fuera de servicio'),(15,'Doppler vascular','Modelo O','Elekta','9178','2023-06-28 09:52:56','2024-01-23 00:56:03','En oficina','Operativo'),(16,'Oftalmoscopio','Modelo P','Zimmer Biomet','9751','2024-03-19 15:21:26','2024-01-29 04:53:00','Quirofano','Fuera de servicio'),(17,'Audiometro','Modelo Q','Boston Scientific','7992','2023-12-26 23:17:59','2024-01-16 02:24:05','Quirofano','Fuera de servicio'),(18,'Holter','Modelo R','Medtronic','7335','2024-04-16 10:41:35','2024-01-03 10:27:14','Quirofano','Fuera de servicio'),(19,'Laser quirurgico','Modelo S','Abbott Laboratories','5536','2023-11-07 22:51:02','2024-01-14 18:03:33','En oficina','Fuera de servicio'),(20,'Estimulador neuromuscular','Modelo T','Roche Diagnostics','7081','2023-07-02 10:45:32','2024-01-19 19:12:47','En oficina','Fuera de servicio'),(21,'Neuralizador','sjds','GE Healthcare','20452','2024-06-21 21:17:46','2024-06-21 21:17:46','En oficina','Operativo'),(22,'prueba2',NULL,NULL,NULL,'2024-06-21 21:34:48','2024-06-21 21:34:48',NULL,NULL),(23,'pruebads',NULL,NULL,NULL,'2024-06-21 21:36:01','2024-06-21 21:36:01',NULL,NULL),(24,'Prueba32',NULL,NULL,NULL,NULL,NULL,NULL,NULL),(25,'Nebulizador adulto','DES','GE Healthcare','2415','2024-06-22 02:28:46','2024-06-22 02:28:46','Investigaciones','Operativo'),(26,'Miografo','cdre','Varian Medical Systems','52145','2024-06-22 01:38:18','2024-06-22 01:38:18','Investigaciones','Operativo'),(27,'Nebulizador neonatal','dre','Philips','1425','2024-06-22 01:54:45','2024-06-22 01:54:45','Investigaciones','Operativo');
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
  PRIMARY KEY (`Id_grupo`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grupo_electrogeno`
--

LOCK TABLES `grupo_electrogeno` WRITE;
/*!40000 ALTER TABLE `grupo_electrogeno` DISABLE KEYS */;
INSERT INTO `grupo_electrogeno` VALUES (1,'Resonador','Operativo'),(2,'Ultrafreezers','Fuera de servicio'),(3,'Farmacia','Fuera de servicio'),(4,'Cirugia','Operativo'),(5,'UTI','Operativo'),(6,'Bioterio','Operativo'),(7,'Hemoterapia','Operativo');
/*!40000 ALTER TABLE `grupo_electrogeno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventario`
--

DROP TABLE IF EXISTS `inventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `inventario` (
  `Id_parte` int NOT NULL,
  `Nombre_parte` varchar(45) NOT NULL,
  `Marca_parte` varchar(45) DEFAULT NULL,
  `Cantidad_disponible` int NOT NULL,
  `Descripcion` varchar(2000) DEFAULT NULL,
  `proveedor_Id_proveedor` int NOT NULL,
  PRIMARY KEY (`Id_parte`),
  KEY `fk_inventario_proveedor1_idx` (`proveedor_Id_proveedor`),
  CONSTRAINT `fk_inventario_proveedor1` FOREIGN KEY (`proveedor_Id_proveedor`) REFERENCES `proveedor` (`Id_proveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventario`
--

LOCK TABLES `inventario` WRITE;
/*!40000 ALTER TABLE `inventario` DISABLE KEYS */;
INSERT INTO `inventario` VALUES (1,'Resistor 2k2','Texas Instruments',5,NULL,21),(2,'Capacitor 30uF','Intel',1,NULL,21),(3,'Transistor PNP','Analog Devices',8,NULL,21),(4,'Diodo 1N4007','Microchip',6,NULL,21),(5,'LED azul','STMicroelectronics',9,NULL,21),(6,'Inductor','NXP',5,NULL,21),(7,'Transformador 9v220v','Infineon',10,NULL,21),(8,'Circuito integrado','Toshiba',4,NULL,21),(9,'Potenciometro 330k','ON Semiconductor',4,NULL,21),(10,'Rele 6 contactos','Vishay',6,NULL,21),(11,'Fusible 3A','Maxim Integrated',3,NULL,21),(12,'Interruptor','Renesas',8,NULL,21),(13,'Conector','Fairchild',7,NULL,21),(14,'Batería','Samsung',5,NULL,21),(15,'Antena','Panasonic',6,NULL,21),(16,'Cristal oscilador 30 MHz','Sony',4,NULL,21),(17,'Microcontrolador PIC16F84','Philips',3,NULL,21),(18,'Display de 7 segmentos','Broadcom',1,NULL,21),(19,'Sensor agua','Xilinx',7,NULL,21),(20,'Memoria EEPROM','Rohm',5,NULL,21);
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
  PRIMARY KEY (`Id_orden`),
  KEY `fk_orden_de_trabajo_equipo1_idx` (`equipo_Id_equipo`),
  CONSTRAINT `fk_orden_de_trabajo_equipo1` FOREIGN KEY (`equipo_Id_equipo`) REFERENCES `equipo` (`Id_equipo`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orden_de_trabajo`
--

LOCK TABLES `orden_de_trabajo` WRITE;
/*!40000 ALTER TABLE `orden_de_trabajo` DISABLE KEYS */;
INSERT INTO `orden_de_trabajo` VALUES (1,'Actualizacion de software en respirador automatico','2024-03-22 12:20:37',NULL,NULL),(2,'Revision y mantenimiento preventivo de electrocardiografo','2024-05-19 08:42:54',NULL,NULL),(3,'Actualizacion de firmware en maquina de anestesia','2024-04-30 17:54:41',NULL,NULL),(4,'Mantenimiento preventivo en resonancia magnetica (RM)','2024-01-21 22:49:30',NULL,NULL),(5,'Inspeccion y limpieza profunda de endoscopio flexible','2023-10-23 01:21:24',NULL,NULL),(6,'Mantenimiento preventivo en resonancia magnetica (RM)','2024-06-05 08:45:46',NULL,NULL),(7,'Diagnostico y reparacion de problema en lampara quirurgica','2024-02-25 05:01:01',NULL,NULL),(8,'Evaluacion de estado en tomografo computarizado (CT)','2023-12-23 06:30:55',NULL,NULL),(9,'Inspeccion de sistema de iluminacion en quirofano','2024-06-05 21:38:35',NULL,NULL),(10,'Recambio de piezas en bomba de infusion','2023-10-31 09:04:43',NULL,NULL),(11,'Reparacion de falla en ecografo abdominal','2023-11-19 20:06:12',NULL,NULL),(12,'Evaluacion de estado en tomografo computarizado (CT)','2023-10-23 07:20:58',NULL,NULL),(13,'Limpieza y desinfeccion de oftalmoscopio digital','2024-03-17 16:17:25',NULL,NULL),(14,'Instalacion de nuevo sensor Doppler vascular','2023-11-03 19:40:45',NULL,NULL),(15,'Recambio de piezas en bomba de infusion','2024-06-12 09:21:44',NULL,NULL),(16,'Reparacion de falla en ecografo abdominal','2023-12-15 17:58:49',NULL,NULL),(17,'Inspeccion y limpieza profunda de endoscopio flexible','2024-02-26 17:29:06',NULL,NULL),(18,'Actualizacion de firmware en maquina de anestesia','2023-10-30 22:15:12',NULL,NULL),(19,'Evaluacion de rendimiento en analizador de gases en sangre','2024-02-12 13:53:39',NULL,NULL),(20,'Mantenimiento preventivo en resonancia magnetica (RM)','2024-01-14 14:36:55',NULL,NULL);
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
  `Telefono_proveedor` int DEFAULT NULL,
  PRIMARY KEY (`Id_proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES (1,'Biotrust',7363,'Avenida Corrientes','CABA','biotrust@mail.com',1112345678),(2,'Massini',3799,'Avenida de Mayo','CABA','massini@mail.com',1123456789),(3,'Nucleolab',7739,'Avenida 9 de Julio','CABA','nucleolab@mail.com',1134567890),(4,'Compania cientifica',6850,'Calle Florida','CABA','companiacientifica@mail.com',1145678901),(5,'Siemmens',9418,'Avenida Santa Fe','CABA','siemmens@mail.com',1156789012),(6,'GE',6374,'Avenida Belgrano','CABA','ge@mail.com',1167890123),(7,'Mindray',1166,'Calle Defensa','CABA','mindray@mail.com',1178901234),(8,'Taussem',6853,'Avenida Cordoba','CABA','taussem@mail.com',1189012345),(9,'Veolia',8526,'Calle Lavalle','CABA','veolia@mail.com',1190123456),(10,'Meditec SRL',2936,'Avenida Rivadavia','CABA','meditec@mail.com',1111223344),(11,'Bioingenieria del Plata',4156,'Calle Suipacha','CABA','bioingenieriadelplata@mail.com',1122334455),(12,'Tecno Hospitalaria',2024,'Calle Tucuman','CABA','tecnohospitalaria@mail.com',1133445566),(13,'Biomedica Argentina',6850,'Calle Esmeralda','CABA','biomedicaargentina@mail.com',1144556677),(14,'Servimed',2954,'Calle Reconquista','CABA','servimed@mail.com',1155667788),(15,'Techno Medical',5530,'Avenida Callao','CABA','technomedical@mail.com',1166778899),(16,'Electromedical Solutions',8893,'Calle San Martin','CABA','electromedicalsolutions@mail.com',1177889900),(17,'Argus Med',9736,'Calle Moreno','CABA','argusmed@mail.com',1188990011),(18,'Equipos Medicos Argenmed',3506,'Avenida Pueyrredon','CABA','equiposmedicosargenmed@mail.com',1199001122),(19,'Biomedic',4899,'Calle Bolivar','CABA','biomedic@mail.com',1110102020),(20,'Hospitalar',9201,'Calle Sarmiento','CABA','hospitalar@mail.com',1112345678),(21,'Microelectronica',1455,'Tte. Gral. J. D. Peron','CABA','ventas@microelectronicash.com',1143710123);
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reparacion_externa`
--

LOCK TABLES `reparacion_externa` WRITE;
/*!40000 ALTER TABLE `reparacion_externa` DISABLE KEYS */;
INSERT INTO `reparacion_externa` VALUES (1,'2024-06-21 13:25:16','2024-06-21 13:29:21',3,1,'Se cambio la placa del equipo');
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reporte_equipo`
--

LOCK TABLES `reporte_equipo` WRITE;
/*!40000 ALTER TABLE `reporte_equipo` DISABLE KEYS */;
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
  `Fecha` datetime DEFAULT NULL,
  `Observaciones_grupo` varchar(2000) DEFAULT NULL,
  `grupo_electrogeno_Id_grupo` int NOT NULL,
  PRIMARY KEY (`Id_reporte_grupo`),
  KEY `fk_Report_grupo_electrogeno_grupo_electrogeno1_idx` (`grupo_electrogeno_Id_grupo`),
  CONSTRAINT `fk_Report_grupo_electrogeno_grupo_electrogeno1` FOREIGN KEY (`grupo_electrogeno_Id_grupo`) REFERENCES `grupo_electrogeno` (`Id_grupo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reporte_grupo_electrogeno`
--

LOCK TABLES `reporte_grupo_electrogeno` WRITE;
/*!40000 ALTER TABLE `reporte_grupo_electrogeno` DISABLE KEYS */;
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

-- Dump completed on 2024-06-22 12:54:57