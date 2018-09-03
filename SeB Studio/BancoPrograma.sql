CREATE DATABASE  IF NOT EXISTS `sebstudio` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `sebstudio`;
-- MySQL dump 10.13  Distrib 8.0.12, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: sebstudio
-- ------------------------------------------------------
-- Server version	8.0.12

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `cliente` (
  `idCliente` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) DEFAULT NULL,
  `telefone` varchar(45) DEFAULT NULL,
  `email` varchar(300) DEFAULT NULL,
  `tipoCliente` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (11,'Gustavo','33332948','gustavopedrodesouza@hotmail.com','Cliente Pro'),(12,'ClYYYYY','33333','dawdwa','Cliente Pro'),(16,'Eujácio','1323131','eujaciopedrodesouza@hotmail.com','Vip'),(17,'Jose','2131','adeae','Vip');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `envelopetable`
--

DROP TABLE IF EXISTS `envelopetable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `envelopetable` (
  `idEnvelope` int(11) NOT NULL AUTO_INCREMENT,
  `baixa` tinyint(4) NOT NULL,
  `idCliente` int(11) DEFAULT NULL,
  `observacao` varchar(300) DEFAULT NULL,
  `preco` decimal(10,2) NOT NULL,
  `sinal` decimal(10,2) DEFAULT NULL,
  `total` decimal(10,2) NOT NULL,
  `nome` varchar(45) NOT NULL,
  `telefone` varchar(45) NOT NULL,
  `dataEntrega` datetime DEFAULT NULL,
  `dataEntrada` datetime DEFAULT NULL,
  `atend` varchar(45) DEFAULT NULL,
  `formaPagamento` varchar(45) DEFAULT NULL,
  `OS` int(11) NOT NULL,
  PRIMARY KEY (`idEnvelope`),
  UNIQUE KEY `OS_UNIQUE` (`OS`),
  KEY `fk_idCliente_idx` (`idCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `envelopetable`
--

LOCK TABLES `envelopetable` WRITE;
/*!40000 ALTER TABLE `envelopetable` DISABLE KEYS */;
INSERT INTO `envelopetable` VALUES (17,1,0,'obs',12.00,NULL,12.00,'g','3333','2018-08-27 14:34:44','2018-08-27 14:34:44','Gustavo','Money',120006),(18,1,16,'',5.10,0.00,5.10,'Pedro','1323131','2018-08-27 14:43:34','2018-08-27 14:43:44','Deomar','Cartão',120007),(20,1,12,'',3.75,0.00,3.75,'gu','33333','2018-08-27 15:02:49','2018-08-27 14:52:55','Gustavo','Dinheiro',120008);
/*!40000 ALTER TABLE `envelopetable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `permissoes`
--

DROP TABLE IF EXISTS `permissoes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `permissoes` (
  `idPermissao` int(11) NOT NULL AUTO_INCREMENT,
  `nivelPermissao` varchar(45) NOT NULL,
  PRIMARY KEY (`idPermissao`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permissoes`
--

LOCK TABLES `permissoes` WRITE;
/*!40000 ALTER TABLE `permissoes` DISABLE KEYS */;
INSERT INTO `permissoes` VALUES (1,'Administrador'),(2,'Funcionario'),(3,'Gerente');
/*!40000 ALTER TABLE `permissoes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produto`
--

DROP TABLE IF EXISTS `produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `produto` (
  `idproduto` int(11) NOT NULL AUTO_INCREMENT,
  `nomeProduto` varchar(45) NOT NULL,
  `valorUnit` decimal(10,2) NOT NULL,
  `codigo` int(11) NOT NULL,
  PRIMARY KEY (`idproduto`),
  UNIQUE KEY `Codigo_UNIQUE` (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=573 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produto`
--

LOCK TABLES `produto` WRITE;
/*!40000 ALTER TABLE `produto` DISABLE KEYS */;
INSERT INTO `produto` VALUES (1,'Temp Excedido a 5mt',1.20,1),(2,'Monatgen ',2.00,2),(3,'Sinal de serviço',0.00,3),(4,'Teste de recup',10.00,4),(5,'Banner 50x60',28.50,317),(6,'Banner 100x75',66.50,321),(7,'Banner 120x80',91.20,322),(8,'Banner m²',95.00,330),(9,'Index 20X30',4.00,332),(10,'Index 20X25',3.50,333),(11,'5x7',8.00,417),(12,' 15x21',2.00,421),(13,'15x21 +100',1.80,422),(14,'15x21 +50',1.90,423),(15,'20x25',3.50,425),(16,'20x28',4.00,428),(17,'20x30',4.00,429),(18,'24x30',8.00,430),(19,'10288',5.00,432),(20,'3x4=6',10.00,433),(21,' 3x4=9',12.00,434),(22,' 28x35',9.00,435),(23,'30x40',10.00,440),(24,'30x45',11.70,445),(25,'30x50',22.50,450),(26,'Black-F-10x15',0.60,455),(27,'Black-F-15x21',1.50,456),(28,'Black-F-20x25',2.90,457),(29,'Black-F-20x30',2.90,458),(30,'30x60',27.00,460),(31,'30x70',31.50,462),(32,' 50x70',55.00,470),(33,'50x75',60.00,475),(34,'recup dados',40.00,480),(35,' 50x83',66.00,483),(36,'30x80',36.00,489),(37,' 30x90',40.50,490),(38,'Promo moedas',0.65,600),(39,'Promo Banner 100x70 ',50.00,601),(40,'Promo 10x15 +Brin 15x21',0.70,602),(41,'Promo 20x30',3.00,603),(42,'Promo 15x21 ',1.50,604),(43,'Promo sábado -10x15',0.65,605),(44,'xxxx',0.00,1015),(45,'Crhistiane S. (10x15)',0.55,1018),(46,'Xerox',0.25,1019),(47,'Impresão doc',0.50,1020),(48,'Daniela Freitas',0.55,1021),(49,'SCaner- Doc Pendrive',1.50,1026),(50,'SCaner /Email',2.00,1040),(51,'Glauter',2.90,1046),(52,'TA11-SENAI',0.59,1056),(53,'Umei Maldonado',0.65,1059),(54,'30X50',22.30,1137),(55,'40X50',30.00,1138),(56,'40X60',36.00,1139),(57,'50X60',45.00,1140),(58,'50X70',52.50,1141),(59,'50X75',55.70,1142),(60,'50X80',60.00,1143),(61,'60X100',90.00,1144),(62,'70X100',105.00,1145),(63,'80X100',120.00,1146),(64,'90x100',135.00,1147),(65,'100X100',150.00,1148),(66,'Hora 10x15',1.50,1225),(67,'15x21 na hora ',2.50,1230),(68,'CodifiCação de video',25.00,1231),(69,'Fita P/DVD',35.00,1232),(70,'Chaveiro c/ foto ',2.00,1235),(71,'Audio converção',15.00,1245),(72,'11.5x15',0.90,1250),(73,'cor margem 10x15 ',0.90,1260),(74,'Retauração ',0.00,1261),(75,'Capa cd Dupla ',3.00,1270),(76,'Capa cd simples ',2.50,1280),(77,'Olhos vermelhos',0.50,1781),(78,'Frase linha ',1.00,1782),(79,'Edição Imagen',20.00,1783),(80,' imã 6x9',2.00,2007),(81,' imã 5x7 ',1.50,2009),(82,' imã 7.5x10 ',2.00,2010),(83,' imã 10x15',2.40,2015),(84,' imã 5x10 ',1.40,2023),(85,'Cartao  5x7.5x9.6x9',1.00,3009),(86,'Cartao 7x10',1.50,3010),(87,'Cartao 10x15',1.80,3015),(88,'Cartao 15x21',2.50,3021),(89,'Cartao 14x14 com- ind',2.50,3022),(90,'5x10',0.90,3023),(92,'Convite indiv /10',2.00,3030),(93,'Calendarios 7x10',1.20,3045),(94,'Calendarios 20x25',5.00,3047),(95,'Calendarios 20x42',10.80,3048),(96,'Calendarios 30x40',20.80,3049),(97,'Calendarios 10x15',1.50,3050),(98,'Calendarios 15x21',3.80,3051),(99,'Calendarios 20x30',5.50,3052),(100,'Call 10x15 com 13 pag',10.00,3056),(101,'Call 15x21 com 13 pag ',15.00,3057),(102,'Call20x30 com 4 pag',12.00,3058),(103,'Gravaçao  DVD',5.00,4081),(104,'Gravar Pen drive',4.00,4082),(105,'Tunel do tempo',100.00,4083),(106,'Silk pro',2.50,4998),(107,'SilkDVD loja',4.00,4999),(108,'Silk DVD Cliente',2.50,5000),(109,' pro 10x15',0.55,5001),(110,' pro 15x21 ',1.30,5002),(111,' pro 20x25 ',3.10,5003),(112,' pro 20x30',3.60,5004),(113,'0',0.00,5005),(114,'Reprodução 20x30',10.00,5006),(115,'Reproduçao 10x15',5.00,5007),(116,'Reproduçao  15x21',5.00,5008),(117,'Reprodução 20x25',10.00,5009),(118,' Monoculos Repro ',5.00,5010),(119,' Monoculos Digi Und',2.50,5011),(120,' Monoculos Digi + de 5',1.20,5012),(121,'Adesivo S/ recorte M²',135.00,5013),(122,'Adesivo furado',105.00,5014),(123,'Adesivo recorte',19.00,5015),(124,'Adesivo C/ recorte M²',145.00,5016),(125,'Serviços Gerais',0.01,5017),(126,'10x15 +1/30',0.85,5020),(127,' 10x15 +31/100',0.80,5021),(128,' 10x15 +101/200',0.75,5022),(129,' 10x15 +201/300',0.65,5023),(130,' 10x15 +301',0.59,5024),(131,'Albinho',1.00,5025),(132,'3x4 cli',2.00,5026),(133,'Caixa Bis',1.50,5027),(134,'Caixa Talento ',1.50,5028),(135,'PlastifiCação P',1.50,5029),(136,'PlastifiCação M',2.00,5030),(137,'PlastifiCação Meio Oficio',3.50,5031),(138,'PlastifiCação A4',4.50,5035),(139,'PlastifiCação A3',6.00,5036),(140,'Enbalagen Bis',7.00,5037),(141,'Adesivo Impre Min 120x20',34.80,5038),(142,'0',0.00,5039),(143,'0',0.00,5040),(144,'Mini Pen Drive 8GB',20.00,10000),(145,'Pen Drive Guitarra 8GB',25.00,10001),(146,'Pen Drive rosa Ver 8GB',30.00,10002),(147,'Pen Drive Picole 64GB',60.00,10003),(148,'Pen Drive Avião 4GB',30.00,10004),(149,'Pen Drive coração 8GB',35.00,10005),(150,'Pen Drive daga 4GB',30.00,10006),(151,'Pen Drive Audi 64GB',60.00,10007),(152,'Pen Drive Chave 8GB',25.00,10008),(153,'Pen Drive Violão made 8GB',42.00,10009),(154,'Pen Drive  Canivete mad  8GB',40.00,10010),(155,'Pen Drive  Mickey  4GB',30.00,10011),(156,'Pen Drive  Dual   64GB',65.00,10012),(157,'Pen Drive  Dual   8GB',30.00,10013),(158,'Pen Drive  Inox 1TB',140.00,10014),(159,'Pen Drive Black 8 GB',20.00,10015),(160,'Pen Drive  Luxo dourado 2TB',210.00,10016),(161,'TRANCEND 2TB',199.00,10017),(162,'Cartão micro Sd 4 GB',15.00,10018),(163,'Cartão micro Sd 8 GB',20.00,10019),(164,'Leitor  micro SD Pen',10.00,10020),(165,'Leitor micro SD Pen Alumi',15.00,10021),(166,'Adaptador micro ',5.00,10022),(167,'Leitor de Cartão Aluminio ',15.00,10023),(168,'Carregador  cel  Veicular ',18.00,10024),(169,'Mini Cabo Usb Iphone',20.00,10025),(170,'Cabo UsB Android 3m',18.00,10026),(171,'Case protetor Smartfone',15.00,10027),(172,'Tripe Mult Uso cel ',35.00,10028),(173,'Tele Objetiva  Aumen 8X ',55.00,10029),(174,'Quit lentes Objetivas  Cel ',90.00,10030),(175,'Tele Objetiva  Aluimio 18X ',190.00,10031),(176,'Lente Copo 24 -105 ',55.00,10032),(177,'Tela apliador Cel ',20.00,10033),(178,'Caneca  300  ML Ades  20unid',1.90,10034),(179,'Caneca  300 ML Silck 1 cor (100 Und)  ',1.70,10035),(180,'Caneca  300 ML Adesivo  ',1.50,10036),(181,'Caneca  450  ML Ades  20unid',2.00,10037),(182,'Caneca  450 ML Silck 1 cor (100 Und)  ',1.90,10038),(183,'Caneca  450 ML Adesivo ',1.70,10039),(184,'Copo L drink  350 ML  Ades 20unid',1.95,10040),(185,'Copo L drink   350 ML Silk 1 cor',1.80,10041),(186,'Copo L drink   350 ML Adesivo ',1.60,10042),(187,'Copo Twister liso Ades  20unid',2.50,10043),(188,'Copo Twister  silck 1 cor (100 Und)',2.80,10044),(189,'Copo Twister  adesivo ',2.50,10045),(190,'Taça 190 ML lisa',1.90,10046),(191,'Taça 190 ML  silck 1 cor (100 Und)',2.30,10047),(192,'Taça 190 ML adesivo 20unid',2.80,10048),(193,'PR Retr 10x15 Mad Liso',6.10,10049),(194,'PR Retr 10x15 Mad Textura ',5.95,10050),(195,'PR Retr 15x21 Mad liso',9.60,10051),(196,'PR Retr 15x21 Mad Textura',8.50,10052),(197,'PR Retr 20x25 Mad  ',10.00,10053),(198,'PR Retr 20x25 Mad Textura ',12.00,10054),(199,'PR Retr 20x30 Mad Liso ',15.00,10055),(200,'PR Retr 20x30 Mad textura',18.00,10056),(201,'PR Retr 24x30 Mad Liso',20.00,10057),(202,'PR Retr 24x30 Mad textura',25.00,10058),(203,'CD print ',1.20,10059),(204,'DVD print',1.50,10060),(205,'CD Comum ',1.00,10061),(206,'DVD comum ',1.30,10062),(207,'PlastiCopo CD UnD',0.25,10063),(208,'PlastiCopo DVD UnD',0.30,10064),(209,'Case CD Slim',1.50,10065),(210,'Case DVD Slim',1.80,10066),(211,'Case DVD box',2.00,10067),(212,'Case CD Box',1.90,10068),(213,'Filme 36 Kodak ',24.90,10069),(214,'Bateria 2032 3V',5.00,10070),(215,'Bateria Lr 44',1.99,10071),(216,'Pilha AlCalina AA',4.50,10072),(217,'Pilha AlCalina AAA',4.50,10073),(218,'Pilha Alfacell Rec  AA',19.90,10074),(219,'Pilha Alfacell Rec  AAA',20.90,10075),(220,'Bateria 23A',7.00,10076),(221,'Chinelo Pen 64 gb',60.00,10077),(222,'Besouro 4Gb',50.00,10078),(223,'Albinho ',1.00,10079),(224,'Carregador  Alc63002 ',27.20,10080),(225,'Carregador  Alc63005',29.40,10081),(226,'Fone  F-3622',9.80,10082),(227,'Fone  NS-1247',11.90,10083),(228,'Fone  sn350VM',10.80,10084),(229,'PR Cubo Sj555',25.00,10085),(230,'PR Cubo Sj666',39.00,10086),(231,'PR  GT124BV',7.50,10087),(232,'PR  GT124HP48',7.20,10088),(233,'PR  GT124VP48',7.90,10089),(234,'PR  GT126BV',12.90,10090),(235,'PR  GT128BV',17.70,10091),(236,'PR  GT128VP48',16.90,10092),(237,'PR  GT134BH',7.50,10093),(238,'PR  GT138BH',17.70,10094),(239,'PR  GT184T',7.90,10095),(240,'PR  HF4333H',11.90,10096),(241,'PR  HF64-2343H',12.50,10097),(242,'PR  HG3259',17.70,10098),(243,'PR  HG3268',12.60,10099),(244,'PR  HG46-2645V',11.80,10100),(245,'PR  HG64-1460H',11.40,10101),(246,'PR  HP46-1707V',19.50,10102),(247,'PR  HP70107',12.90,10103),(248,'PR  HP70113',15.40,10104),(249,'PR  METAL WD1001-1002',12.00,10105),(250,'PR  PHD01007',29.70,10106),(251,'PR SXXK-2067',18.90,10107),(252,'PR  YI22096',17.70,10108),(253,'PR  ZJXK-1774',47.60,10109),(254,'PR  91734',12.30,10110),(255,'PR REL MESA C-27106',33.50,10111),(256,'PR REL PARE YI15255',28.90,10112),(257,'Saco PRES 25X35',0.50,10113),(258,'Saco PRES 30X45',0.70,10114),(259,'Saco PRES 35X53',1.00,10115),(260,'PILHA P/CONTROLE 23A',9.00,10116),(261,'LIVRO DO BEBE 1130579',35.20,10117),(262,'Caixa c/100 envl 10x15 ',37.00,10118),(263,'Envel Car Amsterdan 10x15',0.40,10119),(264,'Envel Car bahamas 10x15',0.40,10120),(265,'Envel Car grecia 10x15',0.40,10121),(266,'Envel Car Marfim 10x15',0.40,10122),(267,'Envel Car Pequim 10x15',0.40,10123),(268,'Envel Car Proto seuro 10x15',0.40,10124),(269,'Envel  vist Amsterdam 7x10',0.25,10125),(270,'Envel vist Brasil 7x10 ',0.25,10126),(271,'Envel vist Cancun 7x10',0.25,10127),(272,'Envel  vist Cartagena 7x10',0.25,10128),(273,'Envel vist los Angeles 7x10',0.25,10129),(274,'Envel  vist Madrid 7x10',0.25,10130),(275,'Envel  vist  Porto serguro 7x10',0.25,10131),(276,'Envel  vist R.janeiro 7x10',0.25,10132),(277,'Envel  vist Scryty 7x10',0.25,10133),(278,'Envel  vist Thaity 7x10',0.25,10134),(279,'Envel  vist Toquio 7x1o',0.25,10135),(280,'Caixa  Envel 7x10 -100 UND',22.50,10136),(281,'Caixa  Envel Carta-100 UND',37.00,10137),(282,'Guitara metal 4GB',30.00,10138),(283,'chaveiro Acrilico',1.50,10139),(284,'Envel  Oficio A4',0.50,10140),(285,'Envel  meio Oficio A5',0.35,10141),(286,'Papel Foto 150 g',1.50,10142),(287,'Papel Foto 180 g',1.70,10143),(288,'Papel Foto  Adesivo',1.90,10144),(289,'Envel Cart Amisterdam  15x21',0.90,10145),(290,'Envel Cart Los Angeles15x21',0.90,10146),(291,'Produtos Diversos',0.00,10147),(292,'Carregador  veiculo Cactor',27.00,10148),(293,'Dvd 8 GB',1.60,10149),(294,'Envel P/ CD-DVD ',0.30,10150),(295,'Caneta CD maker ',2.70,10151),(296,'Cartao M Kings 4 GB ',25.00,10152),(297,'Cartao M SanDisk 8 GB ',30.00,10153),(298,'Pendrive  SanDisk cruse  16 GB ',35.00,10154),(299,'Pendrive  El Shadai 8 GB  ',30.00,10155),(300,'Cartao M SanDisk 16 GB',35.00,10156),(301,'Monocular Telescope',210.00,10157),(302,'Bateria 6LR611B',15.20,10158),(303,'Copo Remedio fiCabonzin',11.90,10159),(304,'Copo remedio relaxotril',11.90,10160),(305,'Copo remedio risopirina',11.90,10161),(306,'Copo remedio vigora',11.90,10162),(307,'ima decor Cartela c/10',5.40,10163),(308,'ima decor unid',1.00,10164),(309,'kit vinho 6080055-1',61.80,10165),(310,'kit vinho garrafa.23cm 1891',57.80,10166),(311,'kit vinho 1892',69.90,10167),(312,'Painel em chapa de aco',43.20,10168),(313,'PR reCado FA2002',2.00,10169),(314,'PR FOT-Q07G',33.60,10170),(315,'PR GT114',10.80,10171),(316,'PR GT116',18.20,10172),(317,'PR GT128V',17.20,10173),(318,'PR GT128VP48',16.90,10174),(319,'PR GT224',13.40,10175),(320,'PR GT224V',14.60,10176),(321,'PR HF64-2343H',12.60,10177),(322,'PR HG4306',22.90,10178),(323,'PR HP70122',19.30,10179),(324,'PR ZJXK-0322',25.60,10180),(325,'Quadro cofre 20x25 LDR-804',45.20,10181),(326,'Relogio parede PDA0208',16.30,10182),(327,'Toalha decor F1152',13.80,10183),(328,'Toalha decor F1154',13.00,10184),(329,'Toalha decor F1155',11.70,10185),(330,'Caneca 300ml tranparente',1.20,10186),(331,'Caneca 300ml azul neon cristal',1.20,10187),(332,'Caneca 300ml azul cristal',1.20,10188),(333,'Caneca 300ml azul tiffany F',1.20,10189),(334,'Caneca 300ml vermelho cristal',1.20,10190),(335,'Caneca 300ml fume cristal',1.20,10191),(336,'Caneca 300ml verde cristal',1.20,10192),(337,'Caneca 300ml prata',1.20,10193),(338,'Caneca 300ml rosa F',1.20,10194),(339,'Caneca 300ml preto F',1.20,10195),(340,'Tripe Cel ',70.00,10196),(341,'Caneca 300ml amarelo F ',1.20,10197),(342,'Caneca 300ml verde neon cristal',1.20,10198),(344,'Caneca 300ml rosa cristal',1.20,10200),(345,'Caneca 300ml vermelho neon cristal',1.20,10201),(346,'Caneca 300ml dourado',1.20,10202),(347,'Caneca 300ml laranja neon cristal',1.20,10203),(348,'Caneca 300ml amarelo neon cristal',1.20,10204),(349,'Caneca 300ml laranja neon F',1.20,10205),(350,'Caneca 450ml tranparente',1.50,10206),(351,'Caneca 450ml azul neon cristal',1.50,10207),(352,'Caneca 450ml azul cristal',1.50,10208),(353,'Caneca 450ml azul tiffany F',1.50,10209),(354,'Caneca 450ml  vermelho cristal',1.50,10210),(355,'Caneca 450ml  fume cristal',1.50,10211),(356,'Caneca 450ml  verde cristal',1.50,10212),(357,'Caneca 450ml  prata',1.50,10213),(358,'Caneca 450ml  rosa F',1.50,10214),(359,'Caneca 450ml  preto F',1.50,10215),(360,'Caneca 450ml  amarelo neon F',1.50,10216),(361,'Caneca 450ml amarelo F ',1.50,10217),(362,'Caneca 450ml  verde neon cristal',1.50,10218),(363,'Caneca 450ml verde cristal',1.50,10219),(364,'Caneca 450ml rosa cristal',1.50,10220),(365,'Caneca 450ml vermelho neon cristal',1.50,10221),(366,'Caneca 450ml dourado',1.50,10222),(367,'Caneca 450ml laranja neon cristal',1.50,10223),(368,'Caneca 450ml amarelo neon cristal',1.50,10224),(369,'Caneca 450ml laranja neon F',1.50,10225),(370,'Copo L drink  350ml tranparente',1.30,10226),(371,'Copo L drink  350ml azul neon cristal',1.30,10227),(372,'Copo L drink  350ml azul escu cristal',1.30,10228),(373,'Copo L drink  350ml azul F',1.30,10229),(374,'Copo L drink  350ml azul tiffany F',1.30,10230),(375,'Copo L drink  350ml  vermelho cristal',1.30,10231),(376,'Copo L drink  350ml vermelho neon cristal',1.30,10232),(377,'Copo L drink  350ml rosa cristal',1.30,10233),(378,'Copo L drink  350ml  rosa F',1.30,10234),(379,'Copo L drink  350ml roxo cristal',1.30,10235),(380,'Copo L drink  350ml roxo F',1.30,10236),(381,'Copo L drink  350ml verde cristal',1.30,10237),(382,'Copo L drink  350ml  verde neon cristal',1.30,10238),(383,'Copo L drink  350ml prata',1.30,10239),(384,'Copo L drink  350ml preto',1.30,10240),(385,'Copo L drink  350ml branco',1.30,10241),(386,'Copo L drink  350ml dourado',1.30,10242),(387,'Copo L drink  350ml laranja neon F',1.30,10243),(388,'Copo L drink  350ml laranja  neon cristal',1.30,10244),(389,'Copo L drink  350ml amarelo neon F',1.30,10245),(390,'Copo L drink  350ml amarelo F',1.30,10246),(391,'Copo L drink  350ml amarelo neon cristal',1.30,10247),(392,'Copo L drink  350ml fume cristal',1.30,10248),(393,'Taça190ml transparente',2.10,10249),(394,'Taça190ml azul tifffany',2.10,10250),(395,'Taça190ml azul cristal',2.10,10251),(396,'Taça190ml vermelho cristal',2.10,10252),(397,'Taça190ml prata',2.10,10253),(398,'Taça190ml verde F',2.10,10254),(399,'Taça190ml rosa F',2.10,10255),(400,'Taça190ml laranja neon F',2.10,10256),(401,'Taça190ml amarelo neon F',2.10,10257),(402,'Taça190ml amarelo neon ',2.10,10258),(403,'Taça190ml preto',2.10,10259),(404,'Taça190ml roxo cristal',2.10,10260),(405,'Taça190ml roxo F',2.10,10261),(406,'Taça190ml branco',2.10,10262),(407,'Taça190ml dourado',2.10,10263),(408,'Copo  twister tranparente',1.90,10264),(409,'Copo  twister azul neon cristal',1.90,10265),(410,'Copo  twister vermelho cristal',1.90,10266),(411,'Copo  twister vermelho neon cristal',1.90,10267),(412,'Copo  twister verde cristal',1.90,10268),(413,'Copo  twister verde neon cristal',1.90,10269),(414,'Copo  twister rosa cristal',1.90,10270),(415,'Copo  twister rosa F',1.90,10271),(416,'Copo  twister roxo cristal',1.90,10272),(417,'Copo  twister amarelo neon cristal',1.90,10273),(418,'Copo  twister amarelo neon F',1.90,10274),(419,'Copo  twister fume',1.90,10275),(420,'Copo  twister branCopo F',1.90,10276),(421,'Copo  twister preto F',1.90,10277),(422,'Copo  twister dourado',1.90,10278),(423,'Copo  twister laranja neon cristal',1.90,10279),(424,'Pilha comum AA C/4',4.00,10280),(425,'Pilha comum AAA C/4',4.00,10281),(426,'Pilha comum AA./.AAA Unid.',1.20,10282),(427,'PR HG86-2648H',16.90,10283),(428,'Pau Self Tripe',45.00,10284),(429,'Adaptador 2 In 1 Micro USB 2.0 OTG',25.00,10285),(430,'Caneca 450 ml Branca',1.50,10286),(431,'Caneca 300 ml Branca',1.20,10287),(432,'Caneca ceramica',24.00,10288),(433,'Caneca ceramica pro',19.00,10289),(434,'Caneca Magica ',35.00,10290),(435,'Caneca Magica pro',25.00,10291),(436,'Bateria Ag01',4.90,10292),(437,'PR FG1382',14.90,10293),(438,'PR GT104',10.80,10294),(439,'PR GT224HP48',14.90,10295),(440,'PR GT224VP48',14.90,10296),(441,'PR HG4363',16.50,10297),(442,'PR GT106',18.50,10298),(443,'PR ZJXK-1967',49.90,10299),(444,'PR 92610',18.40,10300),(445,'PR MD0001',54.90,10301),(446,'PR HG3266',12.90,10302),(447,'PR GT124H',7.60,10303),(448,'PR SXXK126-P01',14.50,10304),(449,'PR PF6300-4R',34.00,10305),(450,'PR HG3274',12.50,10306),(451,'Pilha comum AA C/4',4.00,10307),(452,'FLASH LED',21.90,10308),(453,'PR RELOGIO SXXK-2734',42.00,10309),(454,'PR RELOGIO ASII-720037',25.00,10310),(455,'PR RELOGIO 8028',19.90,10311),(456,'PR RELOGIO PHR003',21.90,10312),(457,'PR RELOGIO PHR002',24.50,10313),(458,'ENVEL TOQUIO10X15',0.40,10314),(459,'ENVEL AMSTERDAN 10X15',0.40,10315),(460,'Saco  METAL 15X22',0.30,10316),(461,'Saco METAL AZUL20X29',0.40,10317),(462,'Case DVD DUPLO',3.50,10318),(463,'Pen Drive Dente 8GB',39.90,10319),(464,'Copo Lente Café',44.90,10320),(465,'Mini tripe',21.90,10321),(466,'Fone ouvido Mic QKZ',35.00,10322),(467,'Grimp  Celular',9.90,10323),(468,'Caixa Branca caneca P Caneca ',1.50,10324),(469,'Caixa Kraft p ca',2.00,10325),(470,'Caneca de Vidro FosCaneca 350 ML',29.90,10326),(471,'Caneca Coração Dupla',38.00,10327),(472,'Caneca Tarja BranCaneca ',25.00,10328),(473,'Caneca Tarja Neon',25.00,10329),(474,'Caneca Vidro Masan for',35.90,10330),(475,'Caneca Alça Coração',25.00,10331),(476,'Caneca Inox ',40.90,10332),(477,'Caneca Aluminio 600 ML',23.00,10333),(478,'Caneca Chop FosCaneca vidro',31.90,10334),(479,'Caneca Chop ceramiCaneca ',38.90,10335),(480,'Squeeze BranCopo 500 ML',19.90,10336),(481,'Caneca Colher',30.90,10337),(482,'Pau Self simples',25.00,10338),(483,'Silk duplo Acrescimo',1.00,10339),(484,'Adesivo Duplo  Acrescimo',0.50,10340),(485,'Album Tab-60F 10x15 Estampas',6.50,10341),(486,'Album F-40 15x21 marfim',13.50,10342),(487,'Album Tab-200F 10x15 Diverços ',18.90,10343),(488,'Chaveiro  Abridor',4.10,10344),(489,'Chaveiro metal ',3.50,10345),(490,'Abridor  Mod Tampinha',9.90,10346),(491,'Caneca Polimero Branca',12.50,10347),(492,'Xicara Pires',35.00,10348),(493,'Xicara Café',16.00,10349),(494,'Caneca de Vidro Trasp 300 ML',22.00,10350),(495,'Caneca  ceramica  Metali',29.00,10351),(496,'Caneca Aluminio 450 ML',20.90,10352),(497,'Doka For Iphone',45.90,10353),(498,'Doka For Android',45.90,10354),(499,'Caneca sem alça',6.50,10355),(500,'PR HV2247 10x15',16.90,10356),(501,'PR HV204 10x15',16.90,10357),(502,'PR HV217 15x21',20.10,10358),(503,'PR HV205 15x21',20.10,10359),(504,'PR SXYK2556',25.90,10360),(505,'PR GT234',14.90,10361),(506,'PR SXXK136P01',14.50,10362),(507,'PR HV216',0.00,10363),(508,'PR HV216',15.99,10364),(509,'Azulejo 15x15',14.80,10365),(510,'Quebra Cab Cora Pet 10 Pçs',13.80,10366),(511,'Quebra Cab Cora Papel 10 Pçs',6.80,10367),(512,'Quebra Cabeça 12 Pçs',13.80,10368),(513,'Quebra Cabeça 24 Pçs',14.80,10369),(514,'Almochaveiro',3.50,10370),(515,'Kit caipirinha',49.90,10371),(516,'Relogio Azulejo 15x15',24.90,10372),(517,'PR Vidro Sublimatico ',32.50,10373),(518,'Pedra 15x20 Subli',32.80,10374),(519,'Pedra Coração Subli',39.90,10375),(520,'Camisa Bran Baby Look P ',0.00,10376),(521,'Camisa Branca Poli P ',19.50,10377),(522,'Camisa Branca Poli M',19.50,10378),(523,'Camisa Branca Poli G',19.50,10379),(524,'Caixa Caneca vazada Sublimatico ',4.00,10380),(525,'Chinelo Adulto do 34 ao 42',24.50,10381),(526,'Chinelo Adulto do 16 ao 32',23.50,10382),(527,'Squeeze Polimero',27.80,10383),(528,'Mouse Pad Redondo',5.90,10384),(529,'Mouse Pad Quadrado ',5.50,10385),(530,'Copo Gel Times',24.90,10386),(532,'Caneca Coração interno',25.50,10387),(534,'PR HV210',16.90,10388),(535,'PR HV214',16.90,10389),(536,'PR HV211',21.90,10390),(537,'PR SS7595',27.20,10391),(538,'PR HG68-2622V',17.50,10392),(539,'PR LC9084',12.30,10393),(540,'PR 92649',14.20,10394),(541,'PR 92517',13.20,10395),(542,' FOTO RELO BIKE XL1309',24.90,10396),(543,' FOTO RELO CAR GR129865',29.50,10397),(544,'Fone Suony sy740',9.90,10398),(545,' FONE INTERPONTE HY82552',9.90,10399),(546,' FOTO RELO 532',16.90,10400),(547,'ALBUM CRUZE 200 FOTO 6030215',19.90,10401),(548,'ALBUM ATLET 200 FOTO 6030216',19.90,10402),(549,'PR CRUZE S1630015',18.50,10403),(550,'PR ATLET  S1630016',18.50,10404),(551,'PR ATLET  RGSZPL16',19.50,10405),(552,'PR CRUZE  RGSZPL15',19.50,10406),(553,'PR  FILME SXXK106P1',19.90,10407),(554,'PR  FRAME SXXX3078',23.90,10408),(555,'AlBUM TAP 200 NAPA10X15',48.26,10409),(556,'AlBUM TAP 200 PRINT 10X15',19.90,10410),(557,'AlBUM TAB 120 OFFSET 10X15',11.50,10411),(558,'AlBUM TAB 120 NEW 10X15 ',11.50,10412),(559,'AlBUM TAB 120 SAVAGE 10X15',11.50,10413),(560,'AlBUM MIMOS 200 10X15 ',49.90,10414),(561,'AlBUM TRAVEL 100 15x21 ',49.80,10415),(562,'AlBUM Menino 120 10x15 ',99.90,10416),(563,'AlBUM Menina 120 10x15',99.90,10417),(564,'AlBUM BEBE 120 10X15',74.90,10418),(565,'AlBUM TAB Bordado 240 10x15 ',149.90,10419);
/*!40000 ALTER TABLE `produto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produtoenvelope`
--

DROP TABLE IF EXISTS `produtoenvelope`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `produtoenvelope` (
  `idProdutoEnvelope` int(11) NOT NULL AUTO_INCREMENT,
  `quantidade` int(11) DEFAULT NULL,
  `cortes` varchar(45) DEFAULT NULL,
  `fk_idEnvelope` int(11) NOT NULL,
  `fk_idProduto` int(11) NOT NULL,
  PRIMARY KEY (`idProdutoEnvelope`),
  KEY `fk_idEnvelope_idx` (`fk_idEnvelope`),
  KEY `fk_idProduto_idx` (`fk_idProduto`),
  CONSTRAINT `fk_idEnvelope` FOREIGN KEY (`fk_idEnvelope`) REFERENCES `envelopetable` (`os`) ON DELETE CASCADE,
  CONSTRAINT `fk_idProduto` FOREIGN KEY (`fk_idProduto`) REFERENCES `produto` (`codigo`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produtoenvelope`
--

LOCK TABLES `produtoenvelope` WRITE;
/*!40000 ALTER TABLE `produtoenvelope` DISABLE KEYS */;
INSERT INTO `produtoenvelope` VALUES (30,6,'',120007,5020),(32,5,'',120008,5022);
/*!40000 ALTER TABLE `produtoenvelope` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `usuarios` (
  `idUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(45) NOT NULL,
  `senha` varchar(45) NOT NULL,
  `codigo` varchar(45) NOT NULL,
  `idPermissao` int(11) NOT NULL,
  PRIMARY KEY (`idUsuario`),
  UNIQUE KEY `usuario_UNIQUE` (`usuario`),
  UNIQUE KEY `codigo_UNIQUE` (`codigo`),
  KEY `fk_idPermissao` (`idPermissao`),
  CONSTRAINT `fkPermissao` FOREIGN KEY (`idPermissao`) REFERENCES `permissoes` (`idpermissao`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'Admin','Admin','12',1),(12,'Thaís','7227','53',3);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'sebstudio'
--

--
-- Dumping routines for database 'sebstudio'
--
/*!50003 DROP PROCEDURE IF EXISTS `retornarUltimoEnvelopeInserido` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `retornarUltimoEnvelopeInserido`(spCod int)
BEGIN
	DECLARE excessao SMALLINT DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	START TRANSACTION;
    
		SELECT max(OS) FROM sebstudio.envelopetable  where OS like concat(spCod,'%'); 
        
	  IF excessao = 1
    THEN
      SELECT 'Erro ao buscar ultimo envelope' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
        
        
 end if;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spCadastroCliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spCadastroCliente`(spNome varchar(45), spTelefone varchar(45),spEmail varchar(45), spTipoCliente varchar(45))
BEGIN
  DECLARE excessao SMALLINT DEFAULT 0;
  DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
  START TRANSACTION;   
	  INSERT INTO cliente(nome,telefone,email,tipoCliente)VALUES(spNome,spTelefone,spEmail,spTipoCliente);
		IF excessao = 1
		THEN
		  SELECT 'Erro ao inserir cliente' AS Retorno;
		  ROLLBACK;
		ELSE
			SELECT DISTINCT LAST_INSERT_ID() FROM cliente;
			COMMIT;
		END IF;
	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spCadastroEnvelope` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spCadastroEnvelope`(spOs int ,spBaixa boolean,spIdCliente int,spObservacao varchar(300),spPreco decimal(10,2), spTotal decimal(10,2),spSinal decimal(10,2),spNome varchar(45),spTelefone varchar(45),spDataEntrega datetime,spDataEntrada datetime,spAtend varchar(45),spFormaPagamento varchar(45))
BEGIN
  DECLARE excessao SMALLINT DEFAULT 0;
  DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
  START TRANSACTION; 
  
  -- idEnvelope, baixa, idCliente, observacao, preco, sinal, total, nome, telefone, dataEntrega, dataEntrada, atend, formaPagamento, OS
	  INSERT INTO envelopeTable(baixa,idCliente,observacao,preco,sinal,total,nome,telefone,dataEntrega,dataEntrada,atend,formaPagamento,OS)VALUES(spBaixa,spIdCliente,spObservacao,spPreco,spSinal,spTotal,spNome,spTelefone,spDataEntrega,spDataEntrada,spAtend,spFormaPagamento,spOs);
		IF excessao = 1
		THEN
		  SELECT 'Erro ao inserir em envelope' AS Retorno;
		  ROLLBACK;
		ELSE
			SELECT DISTINCT LAST_INSERT_ID() FROM envelopeTable;
			COMMIT;
		END IF;
	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spCadastroProduto` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spCadastroProduto`(
 spCodigo int(11),  spNomeProduto varchar(300), spValorUnit decimal(10,2))
BEGIN
  DECLARE excessao SMALLINT DEFAULT 0;
  DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
  START TRANSACTION; 
  
  
	  INSERT INTO produto(nomeProduto,valorUnit,codigo)VALUES(spNomeProduto,spValorUnit,spCodigo);
		IF excessao = 1
		THEN
		  SELECT 'Erro ao inserir produto' AS Retorno;
		  ROLLBACK;
		ELSE
			SELECT DISTINCT LAST_INSERT_ID() FROM produto;
			COMMIT;
		END IF;
	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spCadastroProdutoEnvelope` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spCadastroProdutoEnvelope`(
 spIdEnvelope int(32), spIdProduto int(32),spQuantidade int,spCortes varchar(45))
BEGIN
  DECLARE excessao SMALLINT DEFAULT 0;
  DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
  START TRANSACTION; 
  
  
	  INSERT INTO produtoEnvelope(fk_idEnvelope,fk_idProduto,quantidade,cortes)VALUES(spIdEnvelope,spIdProduto,spQuantidade,spCortes);
		IF excessao = 1
		THEN
		  SELECT 'Erro ao inserir produto em envelope' AS Retorno;
		  ROLLBACK;
		ELSE
			SELECT DISTINCT LAST_INSERT_ID() FROM produtoEnvelope;
			COMMIT;
		END IF;
	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spCadastroUsuario` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spCadastroUsuario`(spUsuario varchar(45),spSenha varchar(45),spCodigo int, spIdPermissao int)
BEGIN
  DECLARE excessao SMALLINT DEFAULT 0;
  DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
  START TRANSACTION; 
  
	IF (
		EXISTS(
			SELECT usuario FROM usuarios WHERE (usuario = spUsuario)))
	THEN
		SELECT 'Usuário já cadastrado.' AS Retorno;
	ROLLBACK;
  ELSE
	  INSERT INTO usuarios(usuario,senha,codigo,idPermissao)VALUES(spUsuario,spSenha,spCodigo,spIdPermissao);
		IF excessao = 1
		THEN
		  SELECT 'Erro ao inserir em usuario' AS Retorno;
		  ROLLBACK;
		ELSE
			SELECT DISTINCT LAST_INSERT_ID() FROM usuarios;
			COMMIT;
		END IF;
	end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spClienteAlterar` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spClienteAlterar`(spIdCliente int ,spNomeCliente varchar(300),spTelefone varchar(45),spEmail varchar(300),spTipoCliente varchar(45))
BEGIN
 DECLARE excessao SMALLINT DEFAULT 0;
  DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
  START TRANSACTION;
  
  update cliente set  nome = spNomeCliente,telefone = spTelefone,email = spEmail,tipoCliente = spTipoCliente
  where idCliente = spIdCliente;
  
  SELECT ROW_COUNT();
	IF excessao = 1
    THEN
      SELECT 'Erro ao alterar cliente' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
        
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spClienteSelecionaTodosPorNome` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spClienteSelecionaTodosPorNome`(spNome varchar(45))
BEGIN
DECLARE excessao SMALLINT DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	START TRANSACTION;
    
select*from cliente where nome like concat('%',spNome,'%');     
     IF excessao = 1
    THEN
      SELECT 'Erro ao selecionar clientes' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
        
        
 end if;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spClienteSelecionaTodosPorTelefone` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spClienteSelecionaTodosPorTelefone`(spTelefone varchar(45))
BEGIN
DECLARE excessao SMALLINT DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	START TRANSACTION;
    
select*from cliente where telefone like concat('%',spTelefone,'%');     
     IF excessao = 1
    THEN
      SELECT 'Erro ao selecionar clientes' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
        
        
 end if;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spClienteSelecionaTodosProPorNome` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spClienteSelecionaTodosProPorNome`(spNome varchar(45))
BEGIN
DECLARE excessao SMALLINT DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	START TRANSACTION;
    
select*from cliente where tipoCliente like 'Cliente Pro' and nome like concat('%',spNome,'%');     
     IF excessao = 1
    THEN
      SELECT 'Erro ao selecionar clientes' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
        
        
 end if;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spClienteSelecionaTodosProPorTelefone` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spClienteSelecionaTodosProPorTelefone`(spTelefone varchar(45))
BEGIN
DECLARE excessao SMALLINT DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	START TRANSACTION;
    
select*from cliente where tipoCliente like 'Cliente Pro' and telefone like concat('%',spTelefone,'%');     
     IF excessao = 1
    THEN
      SELECT 'Erro ao selecionar clientes' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
        
        
 end if;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spClienteSelecionaTodosVipPorNome` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spClienteSelecionaTodosVipPorNome`(spNome varchar(45))
BEGIN
DECLARE excessao SMALLINT DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	START TRANSACTION;
    
select*from cliente where tipoCliente like 'vip' and nome like concat('%',spNome,'%');     
     IF excessao = 1
    THEN
      SELECT 'Erro ao selecionar clientes' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
        
        
 end if;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spClienteSelecionaTodosVipPorTelefone` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spClienteSelecionaTodosVipPorTelefone`(spTelefone varchar(45))
BEGIN
DECLARE excessao SMALLINT DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	START TRANSACTION;
    
select*from cliente where tipoCliente like 'vip' and telefone like concat('%',spTelefone,'%');     
     IF excessao = 1
    THEN
      SELECT 'Erro ao selecionar clientes' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
        
        
 end if;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spConsultarProdutosEnvelope` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spConsultarProdutosEnvelope`(spOS int)
BEGIN
DECLARE excessao SMALLINT DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	START TRANSACTION;
    
select produtoEnvelope.fk_idEnvelope,produtoenvelope.fk_idProduto,produto.nomeProduto,produto.valorUnit,produtoenvelope.cortes,produtoEnvelope.quantidade from produtoenvelope inner join produto on produto.codigo = produtoenvelope.fk_idProduto where fk_idEnvelope = spOS;
 IF excessao = 1
    THEN
      SELECT 'Erro ao selecionar clientes' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;                
end if;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spDeletarCliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spDeletarCliente`(spIdCliente int)
BEGIN

	DECLARE excessao SMALLINT DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	START TRANSACTION;
    
    DELETE FROM cliente WHERE idCliente = spIdCliente;
    SELECT ROW_COUNT();
    IF excessao = 1
    THEN
      SELECT 'Erro ao deletar cliente' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spDeletarEnvelope` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spDeletarEnvelope`(spOS int)
BEGIN

	DECLARE excessao SMALLINT DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	START TRANSACTION;
    
    DELETE FROM envelopeTable WHERE OS= spOS;
    SELECT ROW_COUNT();
    IF excessao = 1
    THEN
      SELECT 'Erro ao deletar envelope' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spDeletarProduto` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spDeletarProduto`(spCod int)
BEGIN

	DECLARE excessao SMALLINT DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	START TRANSACTION;
    
    DELETE FROM produto WHERE codigo = spCod;
    SELECT ROW_COUNT();
    IF excessao = 1
    THEN
      SELECT 'Erro ao deletar Produto' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spEnvelopeAlterar` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spEnvelopeAlterar`(spIdCliente int,spOS int,spBaixa bool,spObservacao varchar(300),spPreco decimal(10,2), spSinal decimal(10,2),spTotal decimal(10,2),spNome varchar(45),spTelefone varchar(45),spDataEntrega datetime,spDataEntrada datetime,spAtend varchar(45), spFormaPagamento varchar(45))
BEGIN
 DECLARE excessao SMALLINT DEFAULT 0;
  DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
  START TRANSACTION;
  
  update envelopeTable set idCliente = spIdCliente, baixa = spBaixa,observacao = spObservacao,preco = spPreco,sinal = spSinal,total = spTotal,nome = spNome,telefone= spTelefone,dataEntrega = spDataEntrega, dataEntrada = spDataEntrada, atend = spAtend, formaPagamento = spFormaPagamento where OS = spOS;

  
  SELECT ROW_COUNT();
	IF excessao = 1
    THEN
      SELECT 'Erro ao alterar produto' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
        
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spEnvelopeSelecionaPorId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spEnvelopeSelecionaPorId`(spOS varchar(45))
BEGIN
DECLARE excessao SMALLINT DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	START TRANSACTION;
    
select*from envelopeTable where OS like concat('%',spOS,'%');     
     IF excessao = 1
    THEN
      SELECT 'Erro ao selecionar envelopes' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
        
        
 end if;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spEnvelopeSelecionaPorNomeCliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spEnvelopeSelecionaPorNomeCliente`(spNome varchar(45))
BEGIN
DECLARE excessao SMALLINT DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	START TRANSACTION;
    
select*from envelopeTable where nome like concat('%',spNome,'%');     
     IF excessao = 1
    THEN
      SELECT 'Erro ao selecionar envelopes' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
        
        
 end if;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spLimparProdutosDeEnvelope` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spLimparProdutosDeEnvelope`(spOS int)
BEGIN

	DECLARE excessao SMALLINT DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	START TRANSACTION;
    
    DELETE FROM produtoEnvelope WHERE fk_idEnvelope = spOS;
    SELECT ROW_COUNT();
    IF excessao = 1
    THEN
      SELECT 'Erro ao deletar Produtos em Envelope' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spProdutoAlterar` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spProdutoAlterar`(spNomeProduto varchar(300),spValorUnit decimal(10,2),spCod int(11))
BEGIN
 DECLARE excessao SMALLINT DEFAULT 0;
  DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
  START TRANSACTION;
  
  update produto set  nomeProduto = spNomeProduto,valorUnit = spValorUnit
  where codigo = spCod;
  
  SELECT ROW_COUNT();
	IF excessao = 1
    THEN
      SELECT 'Erro ao alterar produto' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
        
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spProdutoSelecionaTodos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spProdutoSelecionaTodos`()
BEGIN
DECLARE excessao SMALLINT DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	START TRANSACTION;
    
select*from produto  ;     
     IF excessao = 1
    THEN
      SELECT 'Erro ao selecionar produtos' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
        
        
 end if;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spselecionaProdutoPorId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spselecionaProdutoPorId`(spCod int)
BEGIN
DECLARE excessao SMALLINT DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	START TRANSACTION;
    
select*from produto where codigo like Concat('%', spCod,'%') ;     
     IF excessao = 1
    THEN
      SELECT 'Erro ao selecionar produtos' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
        
        
 end if;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spselecionaProdutoPorId2` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spselecionaProdutoPorId2`(spCod varchar(45))
BEGIN
DECLARE excessao SMALLINT DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	START TRANSACTION;
    
select*from produto where codigo = spCod;     
     IF excessao = 1
    THEN
      SELECT 'Erro ao selecionar produtos' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
        
        
 end if;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spselecionaProdutoPorNome` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spselecionaProdutoPorNome`(sp_nomeProduto varchar(45))
BEGIN
DECLARE excessao SMALLINT DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	START TRANSACTION;
    
select*from produto where nomeProduto like concat('%',sp_nomeProduto,'%') ;     
     IF excessao = 1
    THEN
      SELECT 'Erro ao selecionar produtos' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
        
        
 end if;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spSelecionarUltimoId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spSelecionarUltimoId`()
BEGIN
DECLARE excessao SMALLINT DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	START TRANSACTION;
    
			select max(codigo) from produto;
            
  IF excessao = 1
    THEN
      SELECT 'Erro ao selecionar produtos' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
	end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spUsuarioAlterar` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spUsuarioAlterar`(spUsuario varchar(45),spSenha varchar(45),spCodigo int, spIdPermissao int, spIdUsuario int)
BEGIN
 DECLARE excessao SMALLINT DEFAULT 0;
  DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
  START TRANSACTION;
  
  update usuarios set  usuario = spUsuario,senha = spSenha,codigo = spCodigo,idPermissao = spIdPermissao
  where idUsuario = spIdUsuario;
  
  SELECT ROW_COUNT();
	IF excessao = 1
    THEN
      SELECT 'Erro ao alterar usuario' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
        
end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spUsuarioDeletar` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spUsuarioDeletar`(spIdUsuario int)
BEGIN

	DECLARE excessao SMALLINT DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	START TRANSACTION;
    
    DELETE FROM usuarios WHERE idUsuario = spIdUsuario;
    SELECT ROW_COUNT();
    IF excessao = 1
    THEN
      SELECT 'Erro ao deletar usuario' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spUsuarioLogin` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spUsuarioLogin`(spUsuario varchar(45),spSenha varchar(45))
begin 
DECLARE excessao SMALLINT DEFAULT 0;
  DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;  
  START TRANSACTION;     
	  select codigo,idPermissao from usuarios where senha = spSenha and usuario = spUsuario;
		IF excessao = 1
		THEN
			SELECT 'Usuario ou senha invalido' AS Retorno;
		  ROLLBACK;
		ELSE
			
			COMMIT;
		END IF;
	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spUsuarioSelecionar` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spUsuarioSelecionar`()
BEGIN
DECLARE excessao SMALLINT DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	START TRANSACTION;
    
select usuarios.idUsuario,usuarios.usuario,usuarios.senha,usuarios.codigo,usuarios.idPermissao,permissoes.nivelPermissao from usuarios inner join permissoes on permissoes.idPermissao = usuarios.idPermissao;     
     IF excessao = 1
    THEN
      SELECT 'Erro ao selecionar usuarios' AS Retorno;
      ROLLBACK;
    ELSE
        COMMIT;
        
        
 end if;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-08-27 15:22:52
