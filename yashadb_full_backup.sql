-- MySQL dump 10.13  Distrib 8.0.45, for Win64 (x86_64)
--
-- Host: localhost    Database: yashadb
-- ------------------------------------------------------
-- Server version	8.0.45

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
-- Table structure for table `items`
--

DROP TABLE IF EXISTS `items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `items` (
  `iid` int NOT NULL AUTO_INCREMENT,
  `name` varchar(250) NOT NULL,
  `category` varchar(250) NOT NULL,
  `price` bigint NOT NULL,
  PRIMARY KEY (`iid`)
) ENGINE=InnoDB AUTO_INCREMENT=47 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `items`
--

LOCK TABLES `items` WRITE;
/*!40000 ALTER TABLE `items` DISABLE KEYS */;
INSERT INTO `items` VALUES (1,'Pepsi','Soft Drink',90),(2,'Egg Fried Rice','Indian',290),(4,'Red Velvet Cake','Cake',2500),(6,'Idli','South Indian',100),(7,'Dosa','South Indian',100),(8,'Coke','Soft Drink',70),(11,'Sprite','Soft Drink',90),(12,'Mountain Dew','Soft Drink',90),(13,'Sponge Cake','Cake',1500),(14,'Biryani','Indian',300),(15,'Samosa','Indian',40),(16,'Naan','Indian',25),(17,'Butter Chicken','Indian',1200),(18,'Palak Paneer','Indian',750),(19,'Sambar','South Indian',120),(20,'Vada','South Indian',80),(21,'Masala Dosa','South Indian',130),(22,'Pineapple Cake','Cake',1200),(24,'Cheesecake','Cake',2000),(25,'Black Forest Cake','Cake',1800),(26,'Fanta','Soft Drink',100),(27,'Fresh Lime Soda','Soft Drink',80),(28,'Chicken Tikka Masala','Indian',1400),(29,'Chole Bhature','Indian',350),(30,'Tandoori Chicken','Indian',2200),(37,'Red Bull','Soft Drink',350),(38,'Non Veg Thali','Thali',500),(39,'Veg Thali','Thali',550),(40,'Cupcake','Cake',100),(46,'Miranda','Soft Drink',90);
/*!40000 ALTER TABLE `items` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-09-30  2:07:04
