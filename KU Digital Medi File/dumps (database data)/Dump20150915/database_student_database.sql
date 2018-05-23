-- MySQL dump 10.13  Distrib 5.6.24, for Win64 (x86_64)
--
-- Host: localhost    Database: database
-- ------------------------------------------------------
-- Server version	5.6.26-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `student_database`
--

DROP TABLE IF EXISTS `student_database`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `student_database` (
  `Student_Id` varchar(45) NOT NULL,
  `Student_Name` varchar(45) DEFAULT NULL,
  `Discipline` varchar(45) DEFAULT NULL,
  `Gender` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Student_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student_database`
--

LOCK TABLES `student_database` WRITE;
/*!40000 ALTER TABLE `student_database` DISABLE KEYS */;
INSERT INTO `student_database` VALUES ('140201','Rumpa Paul','CSE','F'),('140202','Taohidul Islam','CSE ','M'),('140203','Farhana Khandakar','CSE','F'),('140204','SM Riasat Ali Akash','CSE','M'),('140205','Deep Dutta','CSE','M'),('140206','Soma Paul','CSE ','F'),('140207','Md Juel Hossain','CSE','M'),('140208','Nazia Sultana','CSE','F'),('140209','Farhad Hossen','CSE','M'),('140210','Fazzlay Rabbi','CSE','M'),('140211','Nadira Khatun','CSE','F'),('140212','Avijit Bhattacharjee','CSE','M'),('140214','Sk Rahad Mannan','CSE','M'),('140215','Ashmita Riya','CSE','F'),('140216','Md Moksedul Islam','CSE','M'),('140217','Fahim Ahmed','CSE','M'),('140218 ','Anaytul Islam','CSE','M'),('140219','Saidur Rahman','CSE','M'),('140220','Suman Sardar','CSE','M'),('140222','Sumit Kumar Saha','CSE','M'),('140223','Kushal Ghose','CSE','M'),('140224','Mohsin Ara Tahera','CSE','F'),('140225','Md Shahidul Islam','CSE','M'),('140227','Rifat Hasan Shuvo','CSE','M'),('140228 ','Hasibul Haque Himel','CSE','M'),('140229','Badhan Ahmed Topu','CSE','M'),('140230','Sheikh Saleh Arshad Ripon','CSE','M'),('140231 ','Imran Hosain Arif','CSE','M'),('140232','Anika Das Dipti','CSE','F'),('140233','Sazid Hossain Emon','CSE','M'),('140234','SM Toufiq Hasan','CSE','M'),('140235','Kawser Murshed Ahsan','CSE','M'),('140236','Subrato Sarker','CSE','M'),('140238','Mredul Hasan','CSE','M'),('140239','Khaled Saifullah ','CSE','M'),('140240','Al Zaminur Rahman','CSE','M'),('140241','Tania Khanom','CSE','F');
/*!40000 ALTER TABLE `student_database` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-09-15 17:00:39
