-- MySqlBackup.NET 2.0.9.2
-- Dump Time: 2016-07-05 07:51:43
-- --------------------------------------
-- Server version 5.7.11-log MySQL Community Server (GPL)


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of barrios
-- 

DROP TABLE IF EXISTS `barrios`;
CREATE TABLE IF NOT EXISTS `barrios` (
  `idBarrio` int(11) NOT NULL AUTO_INCREMENT,
  `idLocalidad` int(11) NOT NULL,
  `barrio` varchar(100) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idBarrio`),
  KEY `FK_bLocalidad_idLocalidad_idx` (`idLocalidad`),
  CONSTRAINT `FK_bLocalidad_idLocalidad` FOREIGN KEY (`idLocalidad`) REFERENCES `localidades` (`idLocalidad`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=412 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table barrios
-- 

/*!40000 ALTER TABLE `barrios` DISABLE KEYS */;
INSERT INTO `barrios`(`idBarrio`,`idLocalidad`,`barrio`,`estado`) VALUES
(1,26,'1 de mayo',1),
(2,26,'16 de noviembre',1),
(3,26,'2 de septiembre',1),
(4,26,'20 de junio',1),
(5,26,'23 de abril',1),
(6,26,'4 de febrero',1),
(7,26,'Achaval Peña',1),
(8,26,'Acosta',1),
(9,26,'Aeronautico',1),
(10,26,'Alberdi',1),
(11,26,'Alberto',1),
(12,26,'Alborada Norte',1),
(13,26,'Alborada Sur',1),
(14,26,'Alejandro Centeno',1),
(15,26,'Almirante Brown',1),
(16,26,'Alta Cordoba',1),
(17,26,'Altamira',1),
(18,26,'Alto Alberdi',1),
(19,26,'Alto Hermoso',1),
(20,26,'Alto Palermo',1),
(21,26,'Alto Verde',1),
(22,26,'Altos de Velez Sarsfield',1),
(23,26,'Altos de Villa Cabrera',1),
(24,26,'Altos San Martin',1),
(25,26,'Altos Sud de San Vicente',1),
(26,26,'Ameghino Norte',1),
(27,26,'Ameghino Sud',1),
(28,26,'Ampliacion 1 De Mayo',1),
(29,26,'Ampliacion Altamira',1),
(30,26,'Ampliacion Benjamin Matienzo',1),
(31,26,'Ampliacion Cerveceros',1),
(32,26,'Ampliacion Empalme',1),
(33,26,'Ampliacion Farina',1),
(34,26,'Ampliacion Jardin Espinosa',1),
(35,26,'Ampliacion Kennedy',1),
(36,26,'Ampliacion Las Palmas',1),
(37,26,'Ampliacion Los Platanos',1),
(38,26,'Ampliacion Palmar',1),
(39,26,'Ampliacion Panamericano',1),
(40,26,'Ampliacion Poeta Lugones',1),
(41,26,'Ampliacion Pueyrredon',1),
(42,26,'Ampliacion Residencial America',1),
(43,26,'Ampliacion Rosedal',1),
(44,26,'Ampliacion San Fernando',1),
(45,26,'Ampliacion San Pablo',1),
(46,26,'Ampliacion Urca',1),
(47,26,'Ampliacion Velez Sarsfield',1),
(48,26,'Ampliacion Yapeyu',1),
(49,26,'Ana Maria Zumaran',1),
(50,26,'Apeadero La Tablada',1),
(51,26,'Arcos I',1),
(52,26,'Argüello',1),
(53,26,'Argüello Lourdes',1),
(54,26,'Argüello Norte',1),
(55,26,'Arturo Capdevila',1),
(56,26,'Ate',1),
(57,26,'Autodromo',1),
(58,26,'Avenida',1),
(59,26,'Ayacucho',1),
(60,26,'Bajada De Piedra',1),
(61,26,'Bajada San Roque',1),
(62,26,'Bajo Galan',1),
(63,26,'Bajo General Paz',1),
(64,26,'Bella Vista',1),
(65,26,'Bella Vista Oeste',1),
(66,26,'Betania',1),
(67,26,'Bialet Masse',1),
(68,26,'Boedo',1),
(69,26,'Brigadier San Martin',1),
(70,26,'Cabaña del Pilar',1),
(71,26,'Cabo Farina',1),
(72,26,'Caceres',1),
(73,26,'California',1),
(74,26,'Camino A Villa Posse',1),
(75,26,'Carbo',1),
(76,26,'Carola Lorenzini',1),
(77,26,'Carrara',1),
(78,26,'Caseros',1),
(79,26,'Centro',1),
(80,26,'Centro America',1),
(81,26,'Cerro Chico',1),
(82,26,'Cerro de las Rosas',1),
(83,26,'Cerro Norte',1),
(84,26,'Cerveceros',1),
(85,26,'Chateau Carreras',1),
(86,26,'Ciudadela',1),
(87,26,'Cofico',1),
(88,26,'Colinas de Bella Vista',1),
(89,26,'Colinas de Velez Sarsfield',1),
(90,26,'Colinas del Cerro',1),
(91,26,'Colinas del Cerro Ampliacion',1),
(92,26,'Colon',1),
(93,26,'Colonia Lola',1),
(94,26,'Comandante Espora',1),
(95,26,'Comercial',1),
(96,26,'Congreso',1),
(97,26,'Consorcio Esperanza',1),
(98,26,'Cooperativa La Unidad',1),
(99,26,'Cordoba 4',1),
(100,26,'Cordoba 5',1),
(101,26,'Corral de Palos',1),
(102,26,'Country Club',1),
(103,26,'Country Fortin del Pozo',1),
(104,26,'Country Jockey Club',1),
(105,26,'Country Las Delicias',1),
(106,26,'Country Lomas de la Carolina',1),
(107,26,'Covico',1),
(108,26,'Crisol Norte',1),
(109,26,'Crisol Sud',1),
(110,26,'Cupani',1),
(111,26,'De Los Bioquimicos',1),
(112,26,'Dean Funes',1),
(113,26,'Ducasse',1),
(114,26,'Ejercito Argentino',1),
(115,26,'El Cabildo',1),
(116,26,'El Cerrito',1),
(117,26,'El Pueblito',1),
(118,26,'El Quebracho',1),
(119,26,'El Refugio',1),
(120,26,'El Trebol',1),
(121,26,'Emaus',1),
(122,26,'Empalme',1),
(123,26,'Empalme Casas De Obreros Y Empleados',1),
(124,26,'Escobar',1),
(125,26,'Estacion Flores',1),
(126,26,'Ferrer',1),
(127,26,'Ferreyra',1),
(128,26,'Ferroviario Mitre',1),
(129,26,'Finca La Dorotea',1),
(130,26,'General Arenales',1),
(131,26,'General Artigas',1),
(132,26,'General Belgrano',1),
(133,26,'General Bustos',1),
(134,26,'General Mosconi',1),
(135,26,'General Paz',1),
(136,26,'General Pueyrredon',1),
(137,26,'General Savio',1),
(138,26,'Granadero Pringles',1),
(139,26,'Granja De Funes',1),
(140,26,'Guarnicion Aerea Cba',1),
(141,26,'Guarnicion Militar Cba',1),
(142,26,'Guayaquil',1),
(143,26,'Güemes',1),
(144,26,'Guiñazu',1),
(145,26,'Guiñazu Sud',1),
(146,26,'Hipolito Yrigoyen',1),
(147,26,'Hogar Propio',1),
(148,26,'Horizonte',1),
(149,26,'Inaudi',1),
(150,26,'Independencia',1),
(151,26,'Industrial Este',1),
(152,26,'Industrial Oeste',1),
(153,26,'Ipona',1),
(154,26,'Ipv Ituzaingo Anexo',1),
(155,26,'Irupe',1),
(156,26,'Ituzaingo',1),
(157,26,'Ituzaingo Anexo',1),
(158,26,'Jardin',1),
(159,26,'Jardin Del Pilar',1),
(160,26,'Jardin Del Sud',1),
(161,26,'Jardin Espinosa',1),
(162,26,'Jardin Hipodromo',1),
(163,26,'Jeronimo Luis De Cabrera',1),
(164,26,'Jockey Club',1),
(165,26,'Jose Hernandez',1),
(166,26,'Jose I Rucci',1),
(167,26,'Jose Ignacio Diaz Seccion 1',1),
(168,26,'Jose Ignacio Diaz Seccion 2',1),
(169,26,'Jose Ignacio Diaz Seccion 3',1),
(170,26,'Jose Ignacio Diaz Seccion 4',1),
(171,26,'Jose Ignacio Diaz Seccion 5',1),
(172,26,'Juan B Justo',1),
(173,26,'Juan Xxiii',1),
(174,26,'Juniors',1),
(175,26,'Kairos',1),
(176,26,'Kennedy',1),
(177,26,'La Carolina',1),
(178,26,'La Floresta',1),
(179,26,'La France',1),
(180,26,'La Fraternidad',1),
(181,26,'La Hortensia',1),
(182,26,'La Salle',1),
(183,26,'La Toma',1),
(184,26,'Lamadrid',1),
(185,26,'Las Dalias',1),
(186,26,'Las Delicias',1),
(187,26,'Las Flores',1),
(188,26,'Las Lilas',1),
(189,26,'Las Magnolias',1),
(190,26,'Las Margaritas',1),
(191,26,'Las Palmas',1),
(192,26,'Las Palmas Anexo',1),
(193,26,'Las Playas',1),
(194,26,'Las Rosas',1),
(195,26,'Las Violetas',1),
(196,26,'Liceo General Paz',1),
(197,26,'Lomas De San Martin',1),
(198,26,'Lomas Del Suquia',1),
(199,26,'Los Alamos',1),
(200,26,'Los Angeles',1),
(201,26,'Los Boulevares',1),
(202,26,'Los Ceibos',1),
(203,26,'Los Eucaliptus',1),
(204,26,'Los Filtros',1),
(205,26,'Los Gigantes',1),
(206,26,'Los Granados',1),
(207,26,'Los Jacarandaes',1),
(208,26,'Los Josefinos',1),
(209,26,'Los Naranjos',1),
(210,26,'Los Olmos',1),
(211,26,'Los Olmos Sud',1),
(212,26,'Los Paraisos',1),
(213,26,'Los Pinos',1),
(214,26,'Los Platanos',1),
(215,26,'Los Principios',1),
(216,26,'Los Robles',1),
(217,26,'Los Sauces',1),
(218,26,'Maipu Seccion 1',1),
(219,26,'Maipu Seccion 2',1),
(220,26,'Maldonado',1),
(221,26,'Marcelo T De Alvear',1),
(222,26,'Marcos Sastre',1),
(223,26,'Marechal',1),
(224,26,'Maria Lastenia',1),
(225,26,'Mariano Balcarce',1),
(226,26,'Mariano Fragueiro',1),
(227,26,'Marques Anexo',1),
(228,26,'Marques De Sobremonte',1),
(229,26,'Mauller',1),
(230,26,'Maurizi',1),
(231,26,'Mercantil',1),
(232,26,'Militar General Deheza',1),
(233,26,'Mirador',1),
(234,26,'Miralta',1),
(235,26,'Mirizzi',1),
(236,26,'Mitre',1),
(237,26,'Nicolas Avellaneda',1),
(238,26,'Nuestro Hogar I',1),
(239,26,'Nueva Cordoba',1),
(240,26,'Nueva Cordoba Anexa',1),
(241,26,'Nueva Italia',1),
(242,26,'Observatorio',1),
(243,26,'Ombu',1),
(244,26,'Oña',1),
(245,26,'OSN',1),
(246,26,'Padre Claret',1),
(247,26,'Palermo Bajo',1),
(248,26,'Palmar',1),
(249,26,'Panamericano',1),
(250,26,'Parque Alameda',1),
(251,26,'Parque Atlantica',1),
(252,26,'Parque Capital',1),
(253,26,'Parque Capital Sud',1),
(254,26,'Parque Chacabuco',1),
(255,26,'Parque Corema',1),
(256,26,'Parque De La Vega Tres',1),
(257,26,'Parque Don Bosco',1),
(258,26,'Parque Futura',1),
(259,26,'Parque Jorge Newbery',1),
(260,26,'Parque Latino',1),
(261,26,'Parque Liceo Seccion 1',1),
(262,26,'Parque Liceo Seccion 2',1),
(263,26,'Parque Liceo Seccion 3',1),
(264,26,'Parque Los Molinos',1),
(265,26,'Parque Modelo',1),
(266,26,'Parque Montecristo',1),
(267,26,'Parque Republica',1),
(268,26,'Parque San Carlos',1),
(269,26,'Parque San Vicente',1),
(270,26,'Parque Sarmiento',1),
(271,26,'Parque Tablada',1),
(272,26,'Parque Velez Sarsfield',1),
(273,26,'Paso De Los Andes',1),
(274,26,'Patria',1),
(275,26,'Patricios',1),
(276,26,'Patricios Este',1),
(277,26,'Patricios Norte',1),
(278,26,'Patricios Oeste',1),
(279,26,'Poeta Lugones',1),
(280,26,'Policarpio Cabral',1),
(281,26,'Policial',1),
(282,26,'Portal Del Jacaranda',1),
(283,26,'Posta De Vargas',1),
(284,26,'Primera Junta',1),
(285,26,'Providencia',1),
(286,26,'Puente Blanco',1),
(287,26,'Quebrada De Las Rosas',1),
(288,26,'Quinta Santa Ana',1),
(289,26,'Quintas De Arguello',1),
(290,26,'Quintas De San Jorge',1),
(291,26,'Ramon J Carcano',1),
(292,26,'Recreo Del Norte',1),
(293,26,'Remedios De Escalada',1),
(294,26,'Renacimiento',1),
(295,26,'Rene Favaloro',1),
(296,26,'Residencial America',1),
(297,26,'Residencial Aragon',1),
(298,26,'Residencial Chateau',1),
(299,26,'Residencial Olivos',1),
(300,26,'Residencial San Carlos',1),
(301,26,'Residencial San Jorge',1),
(302,26,'Residencial San Roque',1),
(303,26,'Residencial Santa Ana',1),
(304,26,'Residencial Santa Rosa',1),
(305,26,'Residencial Sud',1),
(306,26,'Residencial Velez Sarsfield',1),
(307,26,'Rivadavia',1),
(308,26,'Rivera Indarte',1),
(309,26,'Rogelio Martinez',1),
(310,26,'Rosedal',1),
(311,26,'Rosedal Anexo',1),
(312,26,'Sachi',1),
(313,26,'San Antonio',1),
(314,26,'San Cayetano',1),
(315,26,'San Daniel',1),
(316,26,'San Felipe',1),
(317,26,'San Fernando',1),
(318,26,'San Francisco',1),
(319,26,'San Ignacio',1),
(320,26,'San Javier',1),
(321,26,'San Jose',1),
(322,26,'San Lorenzo',1),
(323,26,'San Lorenzo Norte',1),
(324,26,'San Luis De Francia',1),
(325,26,'San Marcelo',1),
(326,26,'San Martin',1),
(327,26,'San Martin Anexo',1),
(328,26,'San Martin Norte',1),
(329,26,'San Nicolas',1),
(330,26,'San Pablo',1),
(331,26,'San Pedro Nolasco',1),
(332,26,'San Rafael',1),
(333,26,'San Ramon',1),
(334,26,'San Salvador',1),
(335,26,'San Vicente',1),
(336,26,'Santa Cecilia',1),
(337,26,'Santa Clara De Asis',1),
(338,26,'Santa Isabel Seccion 1',1),
(339,26,'Santa Isabel Seccion 2',1),
(340,26,'Santa Isabel Seccion 3',1),
(341,26,'Santa Rita',1),
(342,26,'Sargento Cabral',1),
(343,26,'Sarmiento',1),
(344,26,'SEP',1),
(345,26,'SMATA',1),
(346,26,'Suarez',1),
(347,26,'Tablada Park',1),
(348,26,'Talleres Este',1),
(349,26,'Talleres Oeste',1),
(350,26,'Talleres Sud',1),
(351,26,'Tejas Del Sur',1),
(352,26,'Teniente Benjamin Matienzo',1),
(353,26,'Teodoro Felds',1),
(354,26,'Tranviarios',1),
(355,26,'UOCRA',1),
(356,26,'Urca',1),
(357,26,'Uritorco',1),
(358,26,'Urquiza',1),
(359,26,'Valle Del Cerro',1),
(360,26,'Vicor',1),
(361,26,'Villa 4 De Agosto',1),
(362,26,'Villa 9 De Julio',1),
(363,26,'Villa Adela',1),
(364,26,'Villa Alberdi',1),
(365,26,'Villa Alicia Risler',1),
(366,26,'Villa Allende Parque',1),
(367,26,'Villa Argentina',1),
(368,26,'Villa Aspacia',1),
(369,26,'Villa Avalos',1),
(370,26,'Villa Azalais',1),
(371,26,'Villa Azalais Oeste',1),
(372,26,'Villa Belgrano',1),
(373,26,'Villa Bustos',1),
(374,26,'Villa Cabrera',1),
(375,26,'Villa Centenario',1),
(376,26,'Villa Claret',1),
(377,26,'Villa Claudina',1),
(378,26,'Villa Corina',1),
(379,26,'Villa Cornu',1),
(380,26,'Villa Coronel Olmedo',1),
(381,26,'Villa El Libertador',1),
(382,26,'Villa Esquiu',1),
(383,26,'Villa Eucaristica',1),
(384,26,'Villa General Urquiza',1),
(385,26,'Villa Gran Parque',1),
(386,26,'Villa Mafekin',1),
(387,26,'Villa Marta',1),
(388,26,'Villa Martinez',1),
(389,26,'Villa Paez',1),
(390,26,'Villa Quisquizacate',1),
(391,26,'Villa Retiro',1),
(392,26,'Villa Revol',1),
(393,26,'Villa Revol Anexo',1),
(394,26,'Villa Rivadavia',1),
(395,26,'Villa Rivera Indarte',1),
(396,26,'Villa Saldan',1),
(397,26,'Villa San Carlos',1),
(398,26,'Villa San Isidro',1),
(399,26,'Villa Serrana',1),
(400,26,'Villa Siburu',1),
(401,26,'Villa Silvano Funes',1),
(402,26,'Villa Solferino',1),
(403,26,'Villa Union',1),
(404,26,'Villa Warcalde',1),
(405,26,'Vivero Norte',1),
(406,26,'Yapeyu',1),
(407,26,'Yofre H',1),
(408,26,'Yofre I',1),
(409,26,'Yofre Norte',1),
(410,26,'Yofre Sud',1),
(411,26,'Obrero',1);
/*!40000 ALTER TABLE `barrios` ENABLE KEYS */;

-- 
-- Definition of calles
-- 

DROP TABLE IF EXISTS `calles`;
CREATE TABLE IF NOT EXISTS `calles` (
  `idCalle` int(11) NOT NULL AUTO_INCREMENT,
  `idBarrio` int(11) DEFAULT NULL,
  `calle` varchar(100) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idCalle`),
  KEY `FK_CidBarrio_BidBarrio_idx` (`idBarrio`),
  CONSTRAINT `FK_CidBarrio_BidBarrio` FOREIGN KEY (`idBarrio`) REFERENCES `barrios` (`idBarrio`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=309 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table calles
-- 

/*!40000 ALTER TABLE `calles` DISABLE KEYS */;
INSERT INTO `calles`(`idCalle`,`idBarrio`,`calle`,`estado`) VALUES
(1,5,'COCHABAMBA',1),
(2,5,'M. DEL PONT',1),
(3,5,'24 DE SEPTIEMBRE',1),
(4,5,'27 DE FEBRERO',1),
(5,5,'3 DE JUNIO',1),
(6,5,'4 DE FEBRERO',1),
(7,5,'AV. CONDARCO',1),
(8,5,'AV. ARCOS',1),
(9,5,'AV. BONPLAND',1),
(10,5,'AV. CAPDEVILA',1),
(11,5,'AV. DE BRUN',1),
(12,5,'AV. DE PUCH',1),
(13,5,'AV. DE VERA Y ARAGON',1),
(14,5,'AV. M. JANER',1),
(15,5,'AV. TROILO',1),
(16,5,'AV. UDICELO',1),
(17,5,'AV. VILLODO',1),
(18,5,'AV. Y ORTEGA',1),
(19,5,'ABAD E ILLANA',1),
(20,5,'ALARCON',1),
(21,5,'ALCARAZ',1),
(22,5,'ALEM',1),
(23,5,'ALSINA',1),
(24,5,'ALTOLAGUIRRE',1),
(25,5,'ANCHORIS',1),
(26,5,'ANTRANIK',1),
(27,5,'ARGENSOLA',1),
(28,5,'ARREDONDO',1),
(29,5,'ARRIOLA',1),
(30,5,'ASTORGA',1),
(31,5,'ASTORI',1),
(32,5,'AV. LAS MALVINAS',1),
(33,5,'AV. NAOM',1),
(34,5,'AV. PATRIA',1),
(35,5,'B. MARQUEZ',1),
(36,5,'B. DE MENESES',1),
(37,5,'B. DE PERALTA',1),
(38,5,'B. HIDALGO',1),
(39,5,'B. MENENDEZ',1),
(40,5,'BALBASTRO',1),
(41,5,'BARI',1),
(42,5,'BLAS DE PERALTA',1),
(43,5,'BOLE PERALTA',1),
(44,5,'BULNES',1),
(45,5,'BV. OCAMPO',1),
(46,5,'C. DE SAA',1),
(47,5,'C. BROCHERO',1),
(48,5,'C. CONTRERAS',1),
(49,5,'C. DE LA BARCA',1),
(50,5,'C. GALVAN',1),
(51,5,'C. SAAVEDRA',1),
(52,5,'C. SALGUEIRO',1),
(53,5,'C. VIDAL',1),
(54,5,'CALABALUMBA',1),
(55,5,'CAPDEVILA',1),
(56,5,'CARASSA',1),
(57,5,'CARBAJAL',1),
(58,5,'CARLOS III',1),
(59,5,'CASTAÑARES',1),
(60,5,'CATAMARCA',1),
(61,5,'CELESTINO VIDAL',1),
(62,5,'CERRITO',1),
(63,5,'CHACHAPOYAS',1),
(64,5,'CHARCAS',1),
(65,5,'CHICHILLA',1),
(66,5,'CHILAVERT',1),
(67,5,'CHORROARIN',1),
(68,5,'CALLE PUBLICA',1),
(69,5,'COCHABAMBA',1),
(70,5,'COLODRERO',1),
(71,5,'CORONEL OLMEDO',1),
(72,5,'CORREA DE SAA',1),
(73,5,'CORTAZAR',1),
(74,5,'D. COLODRERO',1),
(75,5,'D. DEL PUNCH',1),
(76,5,'D. ECHAURI',1),
(77,5,'D. VELEZ ',1),
(78,5,'DEL ESCRIBARI',1),
(79,5,'DIAZ GOMES',1),
(80,5,'DISCEPOLO',1),
(81,5,'DOS BARRIOS',1),
(82,5,'E. Y USTARIZ',1),
(83,5,'E. MARQUINA',1),
(84,5,'ECHAURI',1),
(85,5,'EDISON',1),
(86,5,'ESCALADA',1),
(87,5,'F. SUAREZ ',1),
(88,5,'F. ABRAMO',1),
(89,5,'F. DE ALARCON',1),
(90,5,'F. MENESES',1),
(91,5,'F. P LUCENA',1),
(92,5,'F. RAUCH',1),
(93,5,'F. SANCHEZ',1),
(94,5,'FCO. DEL PRADO',1),
(95,5,'FELIPE II',1),
(96,5,'FLORENCIA',1),
(97,5,'FRAGUEIRO',1),
(98,5,'FRANKFURT',1),
(99,5,'G. DE PUCH',1),
(100,5,'G. NUÑEZ',1),
(101,5,'G. P. DE DENIS',1),
(102,5,'G. PUCH ',1),
(103,5,'G. TOBAS',1),
(104,5,'GALARZA',1),
(105,5,'GARAGLIO',1),
(106,5,'GAVILAN',1),
(107,5,'GEORGETOWN',1),
(108,5,'GERCHUNOF',1),
(109,5,'GOB. NUÑEZ',1),
(110,5,'GRANADERO TOBA',1),
(111,5,'GUAHANANI',1),
(112,5,'GUATILIGUALA',1),
(113,5,'GUEMES',1),
(114,5,'H. VILCP',1),
(115,5,'H. DE AYOHUMA',1),
(116,5,'H. DE VICAPUGIO',1),
(117,5,'H. DE VILCAPUGIO',1),
(118,5,'HELSINSKY',1),
(119,5,'HOMERO',1),
(120,5,'HUARTE',1),
(121,5,'HUBERMAN',1),
(122,5,'ISABEL LA CATOLICA',1),
(123,5,'ISASMENDI',1),
(124,5,'J. CASTELLANOS',1),
(125,5,'J. CLONER',1),
(126,5,'J. DE QUEVEDO',1),
(127,5,'J. DE AREVALOS',1),
(128,5,'J. DE MEDEIROS',1),
(129,5,'J. DE VEDIA',1),
(130,5,'J. HERNANDEZ',1),
(131,5,'J. LAGUNA',1),
(132,5,'J. LIENDO',1),
(133,5,'J. M. LA HORA',1),
(134,5,'J. MELIAN',1),
(135,5,'J. RIOS',1),
(136,5,'J. SARAVIA',1),
(137,5,'J. VILLEGAS',1),
(138,5,'JUAN B. JUSTO',1),
(139,5,'JAMAICA',1),
(140,5,'JANER',1),
(141,5,'JOSE VILLEGAS',1),
(142,5,'JUAN LIENDO',1),
(143,5,'JUAN XXIII',1),
(144,5,'KANGOO',1),
(145,5,'KM 5 LAS MALVINAS',1),
(146,5,'L. VERNET ',1),
(147,5,'L Y M. TORRES',1),
(148,5,'L. Y PIZARRO',1),
(149,5,'L. GADEA',1),
(150,5,'L. Y PIZARRO',1),
(151,5,'LA HABANA',1),
(152,5,'LA HORA',1),
(153,5,'LAVALLEJA',1),
(154,5,'LEVILLIER',1),
(155,5,'LIBERTAD',1),
(156,5,'LITUANIA',1),
(157,5,'LOCALINO',1),
(158,5,'LOS TINTINES',1),
(159,5,'LUCENA',1),
(160,5,'LUIS PY',1),
(161,5,'M. CASTRO',1),
(162,5,'M. ALLENDE',1),
(163,5,'M. DE CABRERA',1),
(164,5,'M. DEL PONT',1),
(165,5,'M. GUEMES ',1),
(166,5,'M. USANDIVARAS',1),
(167,5,'M. VELASCO',1),
(168,5,'M. Y TORRES',1),
(169,5,'MACHONI',1),
(170,5,'MAG CERVANTES',1),
(171,5,'MALLORCA',1),
(172,5,'MARACAIBO',1),
(173,5,'MARQUINA',1),
(174,5,'MEDEIROS',1),
(175,5,'MEJESTRE',1),
(176,5,'MEJICO',1),
(177,5,'MENESES',1),
(178,5,'MILAN',1),
(179,5,'MILLER',1),
(180,5,'MINISTALALO',1),
(181,5,'MOCHONI',1),
(182,5,'MONTEMAYOR',1),
(183,5,'MUIÑO',1),
(184,5,'MURIEL',1),
(185,5,'MUSLERA',1),
(186,5,'MZA 50',1),
(187,5,'MZA 64',1),
(188,5,'MZA 72',1),
(189,5,'N. DE ISASMENDI',1),
(190,5,'N. DE LA CAMARA',1),
(191,5,'N. DE ISASMENDI',1),
(192,5,'N. DE LA CAMARA',1),
(193,5,'N. VEGA',1),
(194,5,'NAZARET ALEJO',1),
(195,5,'NICETO VEGA',1),
(196,5,'O. A. RODRIGUEZ',1),
(197,5,'O. BALBA',1),
(198,5,'O. DE LEDESMA',1),
(199,5,'O. MONTIEL',1),
(200,5,'O. Y BEAUMONT',1),
(201,5,'OB. ARESTI',1),
(202,5,'OCA BALDA',1),
(203,5,'OCARINA',1),
(204,5,'ORREGO',1),
(205,5,'OYAITA',1),
(206,5,'P. AVALOS',1),
(207,5,'P. DE LEDESMA',1),
(208,5,'P. DE PALOS',1),
(209,5,'P. DEL SAUCE',1),
(210,5,'P. DENIS',1),
(211,5,'P. J. RODRIGUEZ',1),
(212,5,'P. L. MONTI',1),
(213,5,'P. LA CASA',1),
(214,5,'P. LA MONACA',1),
(215,5,'P. MENESES',1),
(216,5,'P. RICO',1),
(217,5,'P. SANGUINETO',1),
(218,5,'P.L. MONTI',1),
(219,5,'PAISANDU',1),
(220,5,'PALERMO',1),
(221,5,'PANAHOLMA',1),
(222,5,'PARANAIBA',1),
(223,5,'PARRAVICHINI',1),
(224,5,'PASAJE',1),
(225,5,'PASTORINO',1),
(226,5,'PEDRIEL',1),
(227,5,'PINAGASTA',1),
(228,5,'PIZARRO',1),
(229,5,'PJE. E Y USTARIZ',1),
(230,5,'PJE. M Y CASTRO',1),
(231,5,'PJE. TINTA',1),
(232,5,'PJE. ALMAFUERTE',1),
(233,5,'PJE. AVALOS',1),
(234,5,'PJE. BAYO',1),
(235,5,'PJE. J. LAGUNA',1),
(236,5,'PJE. LAMES',1),
(237,5,'PJE. NAZAR',1),
(238,5,'PJE. RECARREY',1),
(239,5,'QUESADA',1),
(240,5,'QUEZALTENANCO',1),
(241,5,'QUILAMBE',1),
(242,5,'R. CASAUY',1),
(243,5,'R. DE CARASA',1),
(244,5,'R. DE CLAIRAC',1),
(245,5,'R. DE PALENCIA',1),
(246,5,'R. DE SNATA',1),
(247,5,'R. DEL LIBANO',1),
(248,5,'R. LISTA',1),
(249,5,'R. ORO',1),
(250,5,'R. TOLLO',1),
(251,5,'R. WALSH',1),
(252,5,'RAFAEL DE PALENCIA',1),
(253,5,'RAMON DE CARAZA',1),
(254,5,'RAMON LISTA',1),
(255,5,'RANCAGUA',1),
(256,5,'RAUCH',1),
(257,5,'RINCON',1),
(258,5,'RIO PASAJE',1),
(259,5,'ROCAMORA',1),
(260,5,'ROTTERDAM',1),
(261,5,'RUIZ MORENO',1),
(262,5,'S. ARIÑO',1),
(263,5,'S. DE FIGUEROA',1),
(264,5,'S. DOMINGO',1),
(265,5,'S. LEANDRO',1),
(266,5,'S. Y MOSCOSO',1),
(267,5,'SALTO',1),
(268,5,'SAN CELESTINO',1),
(269,5,'SAN FERNANDO',1),
(270,5,'SAN FRANCISCO',1),
(271,5,'SAN LEANDRO',1),
(272,5,'SAN RAMON',1),
(273,5,'SANGUINETO',1),
(274,5,'SANTA FE ',1),
(275,5,'SARAVIA',1),
(276,5,'SARMIENTO',1),
(277,5,'SAVALIA',1),
(278,5,'SAYOS',1),
(279,5,'SETUBAL',1),
(280,5,'SOLDADO RUIZ',1),
(281,5,'SUCRE',1),
(282,5,'SUIPACHA',1),
(283,5,'T . Y LEMOS',1),
(284,5,'T. DE ROCAMORA',1),
(285,5,'T. DE ARCHONDO',1),
(286,5,'T. CASTELLANOS',1),
(287,5,'T. DAVILA',1),
(288,5,'TADEO DAVILA',1),
(289,5,'TARIJA',1),
(290,5,'TEGUCIGALPA',1),
(291,5,'TINTA',1),
(292,5,'TOCO TOCO',1),
(293,5,'TOKINGA',1),
(294,5,'TONADA',1),
(295,5,'TULA CERVIN',1),
(296,5,'URIEM',1),
(297,5,'USANDIVARAS',1),
(298,5,'V. MACKENA',1),
(299,5,'V. Y MONTOYA',1),
(300,5,'VERACRUZ',1),
(301,5,'VIDELA CASTILLO',1),
(302,5,'VILCAPUGIO',1),
(303,5,'VILLARICA',1),
(304,5,'VILLEGAS',1),
(305,5,'VILLOLDO',1),
(306,5,'WILSON',1),
(307,239,'BV. CHACABUCO',1),
(308,239,'ITUZAINGO',1);
/*!40000 ALTER TABLE `calles` ENABLE KEYS */;

-- 
-- Definition of clientes
-- 

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE IF NOT EXISTS `clientes` (
  `idCliente` int(11) NOT NULL AUTO_INCREMENT,
  `rol` int(11) DEFAULT NULL,
  `tipoPersona` varchar(45) DEFAULT NULL,
  `fechaAlta` date DEFAULT NULL,
  `tipoDoc` int(11) DEFAULT NULL,
  `numDoc` varchar(15) DEFAULT NULL,
  `sexo` varchar(11) DEFAULT NULL,
  `cuil` varchar(13) DEFAULT NULL,
  `apellido` varchar(45) DEFAULT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `estadoCivil` varchar(45) DEFAULT NULL,
  `condicionIVA` varchar(45) DEFAULT NULL,
  `tipoCliente` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idCliente`),
  KEY `FK_tipoDoc_idTipoDoc_idx` (`tipoDoc`),
  KEY `FK_tipoPersona_idTipoPersona_idx` (`rol`),
  KEY `FK_ctCliente_tcidtCliente_idx` (`tipoCliente`),
  CONSTRAINT `FK_ctCliente_tcidtCliente` FOREIGN KEY (`tipoCliente`) REFERENCES `tipocliente` (`idtipoCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_rol_idRol` FOREIGN KEY (`rol`) REFERENCES `roles` (`idRol`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_tipoDoc_idTipoDoc` FOREIGN KEY (`tipoDoc`) REFERENCES `tipodocumento` (`idTipoDoc`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=1500 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table clientes
-- 

/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes`(`idCliente`,`rol`,`tipoPersona`,`fechaAlta`,`tipoDoc`,`numDoc`,`sexo`,`cuil`,`apellido`,`nombre`,`estadoCivil`,`condicionIVA`,`tipoCliente`,`estado`) VALUES
(1,1,'P','2016-04-04 00:00:00',1,'32000001','Masculino','20320000017','OYOLA JULIO','A','Soltero','Consumidor Final',1,1),
(2,1,'P','2016-04-04 00:00:00',1,'32000002','Masculino','20320000117','BUSTOS','A','Soltero','Consumidor Final',1,1),
(3,1,'P','2016-04-04 00:00:00',1,'32000003','Masculino','20320000217','AMADOR','A','Soltero','Consumidor Final',1,1),
(4,1,'P','2016-04-04 00:00:00',1,'32000004','Masculino','20320000317','AGUERO LUIS','A','Soltero','Consumidor Final',1,1),
(5,1,'P','2016-04-04 00:00:00',1,'32000005','Masculino','20320000417','OMAR GIORDANO','A','Soltero','Consumidor Final',1,1),
(6,1,'P','2016-04-04 00:00:00',1,'32000006','Masculino','20320000517','GRIBAUDO','A','Soltero','Consumidor Final',1,1),
(7,1,'P','2016-04-04 00:00:00',1,'32000007','Masculino','20320000617','NANCY','A','Soltero','Consumidor Final',1,1),
(8,1,'P','2016-04-04 00:00:00',1,'32000008','Masculino','20320000717','ARREGUI PANCHO','A','Soltero','Consumidor Final',1,1),
(9,1,'P','2016-04-04 00:00:00',1,'32000009','Masculino','20320000817','ACOSTA GOMEZ GRACIELA','A','Soltero','Consumidor Final',1,1),
(10,1,'P','2016-04-04 00:00:00',1,'32000010','Masculino','20320000917','MONTENEGRO','A','Soltero','Consumidor Final',1,1),
(11,1,'P','2016-04-04 00:00:00',1,'32000011','Masculino','20320001017','LINARES/NAVA','A','Soltero','Consumidor Final',1,1),
(12,1,'P','2016-04-04 00:00:00',1,'32000012','Masculino','20320001117','GABOTO','A','Soltero','Consumidor Final',1,1),
(13,1,'P','2016-04-04 00:00:00',1,'32000013','Masculino','20320001217','SANCHEZ','A','Soltero','Consumidor Final',1,1),
(14,1,'P','2016-04-04 00:00:00',1,'32000014','Masculino','20320001317','TOSOLINI','A','Soltero','Consumidor Final',1,1),
(15,1,'P','2016-04-04 00:00:00',1,'32000015','Masculino','20320001417','BARTOLOME','A','Soltero','Consumidor Final',1,1),
(16,1,'P','2016-04-04 00:00:00',1,'32000016','Masculino','20320001517','PESENDA','A','Soltero','Consumidor Final',1,1),
(17,1,'P','2016-04-04 00:00:00',1,'32000017','Masculino','20320001617','VITURE','A','Soltero','Consumidor Final',1,1),
(18,1,'P','2016-04-04 00:00:00',1,'32000018','Masculino','20320001717','NIEVAS GRACIELA','A','Soltero','Consumidor Final',1,1),
(19,1,'P','2016-04-04 00:00:00',1,'32000019','Masculino','20320001817','FERRERO','A','Soltero','Consumidor Final',1,1),
(20,1,'P','2016-04-04 00:00:00',1,'32000020','Masculino','20320001917','TORREANI','A','Soltero','Consumidor Final',1,1),
(21,1,'P','2016-04-04 00:00:00',1,'32000021','Masculino','20320002017','VACA','A','Soltero','Consumidor Final',1,1),
(22,1,'P','2016-04-04 00:00:00',1,'32000022','Masculino','20320002117','PONCE','A','Soltero','Consumidor Final',1,1),
(23,1,'P','2016-04-04 00:00:00',1,'32000023','Masculino','20320002217','GOMEZ ALBERTO','A','Soltero','Consumidor Final',1,1),
(24,1,'P','2016-04-04 00:00:00',1,'32000024','Masculino','20320002317','POROTA','A','Soltero','Consumidor Final',1,1),
(25,1,'P','2016-04-04 00:00:00',1,'32000025','Masculino','20320002417','BRAMATI','A','Soltero','Consumidor Final',1,1),
(26,1,'P','2016-04-04 00:00:00',1,'32000026','Masculino','20320002517','DAGA','A','Soltero','Consumidor Final',1,1),
(27,1,'P','2016-04-04 00:00:00',1,'32000027','Masculino','20320002617','GUITIERREZ LUIS','A','Soltero','Consumidor Final',1,1),
(28,1,'P','2016-04-04 00:00:00',1,'32000028','Masculino','20320002717','CRUZ','A','Soltero','Consumidor Final',1,1),
(29,1,'P','2016-04-04 00:00:00',1,'32000029','Masculino','20320002817','DURAN POLLERIA','A','Soltero','Consumidor Final',1,1),
(30,1,'P','2016-04-04 00:00:00',1,'32000030','Masculino','20320002917','ARTAZA','A','Soltero','Consumidor Final',1,1),
(31,1,'P','2016-04-04 00:00:00',1,'32000031','Masculino','20320003017','CASTRO','A','Soltero','Consumidor Final',1,1),
(32,1,'P','2016-04-04 00:00:00',1,'32000032','Masculino','20320003117','DOMINGUEZ VERONICA','A','Soltero','Consumidor Final',1,1),
(33,1,'P','2016-04-04 00:00:00',1,'32000033','Masculino','20320003217','CESAR','A','Soltero','Consumidor Final',1,1),
(34,1,'P','2016-04-04 00:00:00',1,'32000034','Masculino','20320003317','CAMILO','A','Soltero','Consumidor Final',1,1),
(35,1,'P','2016-04-04 00:00:00',1,'32000035','Masculino','20320003417','COCO','A','Soltero','Consumidor Final',1,1),
(36,1,'P','2016-04-04 00:00:00',1,'32000036','Masculino','20320003517','LOZA LAVERAP','A','Soltero','Consumidor Final',1,1),
(37,1,'P','2016-04-04 00:00:00',1,'32000037','Masculino','20320003617','ASTUDILLO BLANCA','A','Soltero','Consumidor Final',1,1),
(38,1,'P','2016-04-04 00:00:00',1,'32000038','Masculino','20320003717','LOZA','A','Soltero','Consumidor Final',1,1),
(39,1,'P','2016-04-04 00:00:00',1,'32000039','Masculino','20320003817','KIOSCO','A','Soltero','Consumidor Final',1,1),
(40,1,'P','2016-04-04 00:00:00',1,'32000040','Masculino','20320003917','FERREYRA','A','Soltero','Consumidor Final',1,1),
(41,1,'P','2016-04-04 00:00:00',1,'32000041','Masculino','20320004017','PAZ','A','Soltero','Consumidor Final',1,1),
(42,1,'P','2016-04-04 00:00:00',1,'32000042','Masculino','20320004117','RIVAROLA','A','Soltero','Consumidor Final',1,1),
(43,1,'P','2016-04-04 00:00:00',1,'32000043','Masculino','20320004217','GARZON MERCEDES','A','Soltero','Consumidor Final',1,1),
(44,1,'P','2016-04-04 00:00:00',1,'32000044','Masculino','20320004317','CABRERA','A','Soltero','Consumidor Final',1,1),
(45,1,'P','2016-04-04 00:00:00',1,'32000045','Masculino','20320004417','ALMACEN','A','Soltero','Consumidor Final',1,1),
(46,1,'P','2016-04-04 00:00:00',1,'32000046','Masculino','20320004517','TONUITTI','A','Soltero','Consumidor Final',1,1),
(47,1,'P','2016-04-04 00:00:00',1,'32000047','Masculino','20320004617','CARLOS','A','Soltero','Consumidor Final',1,1),
(48,1,'P','2016-04-04 00:00:00',1,'32000048','Masculino','20320004717','CRISTINA','A','Soltero','Consumidor Final',1,1),
(49,1,'P','2016-04-04 00:00:00',1,'32000049','Masculino','20320004817','RUIZ','A','Soltero','Consumidor Final',1,1),
(50,1,'P','2016-04-04 00:00:00',1,'32000050','Masculino','20320004917','BARROSO','A','Soltero','Consumidor Final',1,1),
(51,1,'P','2016-04-04 00:00:00',1,'32000051','Masculino','20320005017','GONZALES','A','Soltero','Consumidor Final',1,1),
(52,1,'P','2016-04-04 00:00:00',1,'32000052','Masculino','20320005117','FERNADEZ','A','Soltero','Consumidor Final',1,1),
(53,1,'P','2016-04-04 00:00:00',1,'32000053','Masculino','20320005217','MERCEDEZ','A','Soltero','Consumidor Final',1,1),
(54,1,'P','2016-04-04 00:00:00',1,'32000054','Masculino','20320005317','BRUSTIA','A','Soltero','Consumidor Final',1,1),
(55,1,'P','2016-04-04 00:00:00',1,'32000055','Masculino','20320005417','NAVARRO','A','Soltero','Consumidor Final',1,1),
(56,1,'P','2016-04-04 00:00:00',1,'32000056','Masculino','20320005517','CAMURRI','A','Soltero','Consumidor Final',1,1),
(57,1,'P','2016-04-04 00:00:00',1,'32000057','Masculino','20320005617','BALISTRERI','A','Soltero','Consumidor Final',1,1),
(58,1,'P','2016-04-04 00:00:00',1,'32000058','Masculino','20320005717','LUCAS','A','Soltero','Consumidor Final',1,1),
(59,1,'P','2016-04-04 00:00:00',1,'32000059','Masculino','20320005817','PEREZ','A','Soltero','Consumidor Final',1,1),
(60,1,'P','2016-04-04 00:00:00',1,'32000060','Masculino','20320005917','PETRUCCI','A','Soltero','Consumidor Final',1,1),
(61,1,'P','2016-04-04 00:00:00',1,'32000061','Masculino','20320006017','CENTENO','A','Soltero','Consumidor Final',1,1),
(62,1,'P','2016-04-04 00:00:00',1,'32000062','Masculino','20320006117','OLIVEROS','A','Soltero','Consumidor Final',1,1),
(63,1,'P','2016-04-04 00:00:00',1,'32000063','Masculino','20320006217','NAVARRO..','A','Soltero','Consumidor Final',1,1),
(64,1,'P','2016-04-04 00:00:00',1,'32000064','Masculino','20320006317','BORIOGLIO','A','Soltero','Consumidor Final',1,1),
(65,1,'P','2016-04-04 00:00:00',1,'32000065','Masculino','20320006417','ARANDA ROSA','A','Soltero','Consumidor Final',1,1),
(66,1,'P','2016-04-04 00:00:00',1,'32000066','Masculino','20320006517','MADRIAGA','A','Soltero','Consumidor Final',1,1),
(67,1,'P','2016-04-04 00:00:00',1,'32000067','Masculino','20320006617','BRAVO MARY','A','Soltero','Consumidor Final',1,1),
(68,1,'P','2016-04-04 00:00:00',1,'32000068','Masculino','20320006717','MARTI','A','Soltero','Consumidor Final',1,1),
(69,1,'P','2016-04-04 00:00:00',1,'32000069','Masculino','20320006817','HEREDIA HUGO','A','Soltero','Consumidor Final',1,1),
(70,1,'P','2016-04-04 00:00:00',1,'32000070','Masculino','20320006917','BAZAN','A','Soltero','Consumidor Final',1,1),
(71,1,'P','2016-04-04 00:00:00',1,'32000071','Masculino','20320007017','BAZAN HIJA','A','Soltero','Consumidor Final',1,1),
(72,1,'P','2016-04-04 00:00:00',1,'32000072','Masculino','20320007117','ALBA','A','Soltero','Consumidor Final',1,1),
(73,1,'P','2016-04-04 00:00:00',1,'32000073','Masculino','20320007217','CLARA','A','Soltero','Consumidor Final',1,1),
(74,1,'P','2016-04-04 00:00:00',1,'32000074','Masculino','20320007317','BRAVO GIMENEZ','A','Soltero','Consumidor Final',1,1),
(75,1,'P','2016-04-04 00:00:00',1,'32000075','Masculino','20320007417','PANTELIX','A','Soltero','Consumidor Final',1,1),
(76,1,'P','2016-04-04 00:00:00',1,'32000076','Masculino','20320007517','ACOSTA','A','Soltero','Consumidor Final',1,1),
(77,1,'P','2016-04-04 00:00:00',1,'32000077','Masculino','20320007617','NAVARRO.','A','Soltero','Consumidor Final',1,1),
(78,1,'P','2016-04-04 00:00:00',1,'32000078','Masculino','20320007717','RODAS RAUL','A','Soltero','Consumidor Final',1,1),
(79,1,'P','2016-04-04 00:00:00',1,'32000079','Masculino','20320007817','CABRERA.','A','Soltero','Consumidor Final',1,1),
(80,1,'P','2016-04-04 00:00:00',1,'32000080','Masculino','20320007917','FARIAS GUILLERMO','A','Soltero','Consumidor Final',1,1),
(81,1,'P','2016-04-04 00:00:00',1,'32000081','Masculino','20320008017','vecina  -  dejar en viture-','A','Soltero','Consumidor Final',1,1),
(82,1,'P','2016-04-04 00:00:00',1,'32000082','Masculino','20320008117','MANSILLA','A','Soltero','Consumidor Final',1,1),
(83,1,'P','2016-04-04 00:00:00',1,'32000083','Masculino','20320008217','GLADIS','A','Soltero','Consumidor Final',1,1),
(84,1,'P','2016-04-04 00:00:00',1,'32000084','Masculino','20320008317','ZABALA.','A','Soltero','Consumidor Final',1,1),
(85,1,'P','2016-04-04 00:00:00',1,'32000085','Masculino','20320008417','ZABALA ESTELA','A','Soltero','Consumidor Final',1,1),
(86,1,'P','2016-04-04 00:00:00',1,'32000086','Masculino','20320008517','GODOY JORGE','A','Soltero','Consumidor Final',1,1),
(87,1,'P','2016-04-04 00:00:00',1,'32000087','Masculino','20320008617','ARMONELLI','A','Soltero','Consumidor Final',1,1),
(88,1,'P','2016-04-04 00:00:00',1,'32000088','Masculino','20320008717','FORNARI IVANA','A','Soltero','Consumidor Final',1,1),
(89,1,'P','2016-04-04 00:00:00',1,'32000089','Masculino','20320008817','DI PIETRO','A','Soltero','Consumidor Final',1,1),
(90,1,'P','2016-04-04 00:00:00',1,'32000090','Masculino','20320008917','BARRERA','A','Soltero','Consumidor Final',1,1),
(91,1,'P','2016-04-04 00:00:00',1,'32000091','Masculino','20320009017',' OCHOA JORGE','A','Soltero','Consumidor Final',1,1),
(92,1,'P','2016-04-04 00:00:00',1,'32000092','Masculino','20320009117','PEREYRA HNO','A','Soltero','Consumidor Final',1,1),
(93,1,'P','2016-04-04 00:00:00',1,'32000093','Masculino','20320009217','ANA','A','Soltero','Consumidor Final',1,1),
(94,1,'P','2016-04-04 00:00:00',1,'32000094','Masculino','20320009317','PACHECO','A','Soltero','Consumidor Final',1,1),
(95,1,'P','2016-04-04 00:00:00',1,'32000095','Masculino','20320009417','ZURITA','A','Soltero','Consumidor Final',1,1),
(96,1,'P','2016-04-04 00:00:00',1,'32000096','Masculino','20320009517','PACHELA','A','Soltero','Consumidor Final',1,1),
(97,1,'P','2016-04-04 00:00:00',1,'32000097','Masculino','20320009617','GUERRERO','A','Soltero','Consumidor Final',1,1),
(98,1,'P','2016-04-04 00:00:00',1,'32000098','Masculino','20320009717','GABRIELA','A','Soltero','Consumidor Final',1,1),
(99,1,'P','2016-04-04 00:00:00',1,'32000099','Masculino','20320009817','LASO','A','Soltero','Consumidor Final',1,1),
(100,1,'P','2016-04-04 00:00:00',1,'32000100','Masculino','20320009917','ARAOZ','A','Soltero','Consumidor Final',1,1),
(101,1,'P','2016-04-04 00:00:00',1,'32000101','Masculino','20320010017','GIORDANO','A','Soltero','Consumidor Final',1,1),
(102,1,'P','2016-04-04 00:00:00',1,'32000102','Masculino','20320010117','ROMERO','A','Soltero','Consumidor Final',1,1),
(103,1,'P','2016-04-04 00:00:00',1,'32000103','Masculino','20320010217','IPARRAGUIRRE ALEJANDRA','A','Soltero','Consumidor Final',1,1),
(104,1,'P','2016-04-04 00:00:00',1,'32000104','Masculino','20320010317','HEREDIA','A','Soltero','Consumidor Final',1,1),
(105,1,'P','2016-04-04 00:00:00',1,'32000105','Masculino','20320010417','GUTIERREZ / DI PALMA','A','Soltero','Consumidor Final',1,1),
(106,1,'P','2016-04-04 00:00:00',1,'32000106','Masculino','20320010517','GUTIERREZ JAVIER','A','Soltero','Consumidor Final',1,1),
(107,1,'P','2016-04-04 00:00:00',1,'32000107','Masculino','20320010617','GIUSTON','A','Soltero','Consumidor Final',1,1),
(108,1,'P','2016-04-04 00:00:00',1,'32000108','Masculino','20320010717','LEANDRO','A','Soltero','Consumidor Final',1,1),
(109,1,'P','2016-04-04 00:00:00',1,'32000109','Masculino','20320010817','AGUERO','A','Soltero','Consumidor Final',1,1),
(110,1,'P','2016-04-04 00:00:00',1,'32000110','Masculino','20320010917','CARRIZO MERCEDES','A','Soltero','Consumidor Final',1,1),
(111,1,'P','2016-04-04 00:00:00',1,'32000111','Masculino','20320011017','PEREYRA','A','Soltero','Consumidor Final',1,1),
(112,1,'P','2016-04-04 00:00:00',1,'32000112','Masculino','20320011117','CARRIZO','A','Soltero','Consumidor Final',1,1),
(113,1,'P','2016-04-04 00:00:00',1,'32000113','Masculino','20320011217','GONZALEZ','A','Soltero','Consumidor Final',1,1),
(114,1,'P','2016-04-04 00:00:00',1,'32000114','Masculino','20320011317','DIZ HIJA','A','Soltero','Consumidor Final',1,1),
(115,1,'P','2016-04-04 00:00:00',1,'32000115','Masculino','20320011417','KARINA','A','Soltero','Consumidor Final',1,1),
(116,1,'P','2016-04-04 00:00:00',1,'32000116','Masculino','20320011517','SALDIVIA SILVIA','A','Soltero','Consumidor Final',1,1),
(117,1,'P','2016-04-04 00:00:00',1,'32000117','Masculino','20320011617','PALACIOS','A','Soltero','Consumidor Final',1,1),
(118,1,'P','2016-04-04 00:00:00',1,'32000118','Masculino','20320011717','VENEDI','A','Soltero','Consumidor Final',1,1),
(119,1,'P','2016-04-04 00:00:00',1,'32000119','Masculino','20320011817','GONZALEZ.','A','Soltero','Consumidor Final',1,1),
(120,1,'P','2016-04-04 00:00:00',1,'32000120','Masculino','20320011917','ARGUELLO','A','Soltero','Consumidor Final',1,1),
(121,1,'P','2016-04-04 00:00:00',1,'32000121','Masculino','20320012017','MORRESI ANGULO','A','Soltero','Consumidor Final',1,1),
(122,1,'P','2016-04-04 00:00:00',1,'32000122','Masculino','20320012117','BARTOLINI','A','Soltero','Consumidor Final',1,1),
(123,1,'P','2016-04-04 00:00:00',1,'32000123','Masculino','20320012217','BELTRAN','A','Soltero','Consumidor Final',1,1),
(124,1,'P','2016-04-04 00:00:00',1,'32000124','Masculino','20320012317','BELTRAN NIETO','A','Soltero','Consumidor Final',1,1),
(125,1,'P','2016-04-04 00:00:00',1,'32000125','Masculino','20320012417','LUJAN SILVIA','A','Soltero','Consumidor Final',1,1),
(126,1,'P','2016-04-04 00:00:00',1,'32000126','Masculino','20320012517','ROJAS / LUJAN','A','Soltero','Consumidor Final',1,1),
(127,1,'P','2016-04-04 00:00:00',1,'32000127','Masculino','20320012617','DORADO MONICA','A','Soltero','Consumidor Final',1,1),
(128,1,'P','2016-04-04 00:00:00',1,'32000128','Masculino','20320012717','MARTINES','A','Soltero','Consumidor Final',1,1),
(129,1,'P','2016-04-04 00:00:00',1,'32000129','Masculino','20320012817','MENEHEM','A','Soltero','Consumidor Final',1,1),
(130,1,'P','2016-04-04 00:00:00',1,'32000130','Masculino','20320012917','MARIZA','A','Soltero','Consumidor Final',1,1),
(131,1,'P','2016-04-04 00:00:00',1,'32000131','Masculino','20320013017','BUSTAMANTE LORENA','A','Soltero','Consumidor Final',1,1),
(132,1,'P','2016-04-04 00:00:00',1,'32000132','Masculino','20320013117','BUSTAMANTE CRISTIAN','A','Soltero','Consumidor Final',1,1),
(133,1,'P','2016-04-04 00:00:00',1,'32000133','Masculino','20320013217','CERESO','A','Soltero','Consumidor Final',1,1),
(134,1,'P','2016-04-04 00:00:00',1,'32000134','Masculino','20320013317','MALDONADO','A','Soltero','Consumidor Final',1,1),
(135,1,'P','2016-04-04 00:00:00',1,'32000135','Masculino','20320013417','VARELA','A','Soltero','Consumidor Final',1,1),
(136,1,'P','2016-04-04 00:00:00',1,'32000136','Masculino','20320013517','GONZALES SILVIA','A','Soltero','Consumidor Final',1,1),
(137,1,'P','2016-04-04 00:00:00',1,'32000137','Masculino','20320013617','WILER','A','Soltero','Consumidor Final',1,1),
(138,1,'P','2016-04-04 00:00:00',1,'32000138','Masculino','20320013717','LIENDO','A','Soltero','Consumidor Final',1,1),
(139,1,'P','2016-04-04 00:00:00',1,'32000139','Masculino','20320013817','CAPORELLI','A','Soltero','Consumidor Final',1,1),
(140,1,'P','2016-04-04 00:00:00',1,'32000140','Masculino','20320013917','LEDEZMA','A','Soltero','Consumidor Final',1,1),
(141,1,'P','2016-04-04 00:00:00',1,'32000141','Masculino','20320014017','PACHECO CLAUDIA','A','Soltero','Consumidor Final',1,1),
(142,1,'P','2016-04-04 00:00:00',1,'32000142','Masculino','20320014117','ROMERO','A','Soltero','Consumidor Final',1,1),
(143,1,'P','2016-04-04 00:00:00',1,'32000143','Masculino','20320014217','PABLO','A','Soltero','Consumidor Final',1,1),
(144,1,'P','2016-04-04 00:00:00',1,'32000144','Masculino','20320014317','GIMENEZ JAVIER','A','Soltero','Consumidor Final',1,1),
(145,1,'P','2016-04-04 00:00:00',1,'32000145','Masculino','20320014417','AMATO','A','Soltero','Consumidor Final',1,1),
(146,1,'P','2016-04-04 00:00:00',1,'32000146','Masculino','20320014517','PUENTE','A','Soltero','Consumidor Final',1,1),
(147,1,'P','2016-04-04 00:00:00',1,'32000147','Masculino','20320014617','CORDOBA','A','Soltero','Consumidor Final',1,1),
(148,1,'P','2016-04-04 00:00:00',1,'32000148','Masculino','20320014717','JAVIER','A','Soltero','Consumidor Final',1,1),
(149,1,'P','2016-04-04 00:00:00',1,'32000149','Masculino','20320014817','JUAREZ','A','Soltero','Consumidor Final',1,1),
(150,1,'P','2016-04-04 00:00:00',1,'32000150','Masculino','20320014917','HOLMOS CATLINA','A','Soltero','Consumidor Final',1,1),
(151,1,'P','2016-04-04 00:00:00',1,'32000151','Masculino','20320015017','GORDILLO','A','Soltero','Consumidor Final',1,1),
(152,1,'P','2016-04-04 00:00:00',1,'32000152','Masculino','20320015117','SEMINARI FARMACIA','A','Soltero','Consumidor Final',1,1),
(153,1,'P','2016-04-04 00:00:00',1,'32000153','Masculino','20320015217','PALACIO PATRICIA','A','Soltero','Consumidor Final',1,1),
(154,1,'P','2016-04-04 00:00:00',1,'32000154','Masculino','20320015317','MARIA','A','Soltero','Consumidor Final',1,1),
(155,1,'P','2016-04-04 00:00:00',1,'32000155','Masculino','20320015417','AGUIRRE','A','Soltero','Consumidor Final',1,1),
(156,1,'P','2016-04-04 00:00:00',1,'32000156','Masculino','20320015517','PATIÑO ROXANA','A','Soltero','Consumidor Final',1,1),
(157,1,'P','2016-04-04 00:00:00',1,'32000157','Masculino','20320015617','NIETO WALTER','A','Soltero','Consumidor Final',1,1),
(158,1,'P','2016-04-04 00:00:00',1,'32000158','Masculino','20320015717','HEREDIA MIGUEL','A','Soltero','Consumidor Final',1,1),
(159,1,'P','2016-04-04 00:00:00',1,'32000159','Masculino','20320015817','HEREDIA MADRE','A','Soltero','Consumidor Final',1,1),
(160,1,'P','2016-04-04 00:00:00',1,'32000160','Masculino','20320015917','LIZ ALBA','A','Soltero','Consumidor Final',1,1),
(161,1,'P','2016-04-04 00:00:00',1,'32000161','Masculino','20320016017','CASTRO.','A','Soltero','Consumidor Final',1,1),
(162,1,'P','2016-04-04 00:00:00',1,'32000162','Masculino','20320016117','CONTRERAS','A','Soltero','Consumidor Final',1,1),
(163,1,'P','2016-04-04 00:00:00',1,'32000163','Masculino','20320016217','TORRES','A','Soltero','Consumidor Final',1,1),
(164,1,'P','2016-04-04 00:00:00',1,'32000164','Masculino','20320016317','GIL CARLOS','A','Soltero','Consumidor Final',1,1),
(165,1,'P','2016-04-04 00:00:00',1,'32000165','Masculino','20320016417','BRITOS.','A','Soltero','Consumidor Final',1,1),
(166,1,'P','2016-04-04 00:00:00',1,'32000166','Masculino','20320016517','MARTINEZ','A','Soltero','Consumidor Final',1,1),
(167,1,'P','2016-04-04 00:00:00',1,'32000167','Masculino','20320016617','NULFO','A','Soltero','Consumidor Final',1,1),
(168,1,'P','2016-04-04 00:00:00',1,'32000168','Masculino','20320016717','CARRION HIJO','A','Soltero','Consumidor Final',1,1),
(169,1,'P','2016-04-04 00:00:00',1,'32000169','Masculino','20320016817','VALERIA','A','Soltero','Consumidor Final',1,1),
(170,1,'P','2016-04-04 00:00:00',1,'32000170','Masculino','20320016917','KARINA.','A','Soltero','Consumidor Final',1,1),
(171,1,'P','2016-04-04 00:00:00',1,'32000171','Masculino','20320017017','GUSMAN','A','Soltero','Consumidor Final',1,1),
(172,1,'P','2016-04-04 00:00:00',1,'32000172','Masculino','20320017117','SILVA','A','Soltero','Consumidor Final',1,1),
(173,1,'P','2016-04-04 00:00:00',1,'32000173','Masculino','20320017217','LAYUNTA','A','Soltero','Consumidor Final',1,1),
(174,1,'P','2016-04-04 00:00:00',1,'32000174','Masculino','20320017317','BAZAN.','A','Soltero','Consumidor Final',1,1),
(175,1,'P','2016-04-04 00:00:00',1,'32000175','Masculino','20320017417','DE LA O','A','Soltero','Consumidor Final',1,1),
(176,1,'P','2016-04-04 00:00:00',1,'32000176','Masculino','20320017517','BAGHIN RUBEN','A','Soltero','Consumidor Final',1,1),
(177,1,'P','2016-04-04 00:00:00',1,'32000177','Masculino','20320017617','HEREDIA DELIA','A','Soltero','Consumidor Final',1,1),
(178,1,'P','2016-04-04 00:00:00',1,'32000178','Masculino','20320017717','MORENO','A','Soltero','Consumidor Final',1,1),
(179,1,'P','2016-04-04 00:00:00',1,'32000179','Masculino','20320017817','MATEO','A','Soltero','Consumidor Final',1,1),
(180,1,'P','2016-04-04 00:00:00',1,'32000180','Masculino','20320017917','MATEO GASTON.','A','Soltero','Consumidor Final',1,1),
(181,1,'P','2016-04-04 00:00:00',1,'32000181','Masculino','20320018017','LOCACIO','A','Soltero','Consumidor Final',1,1),
(182,1,'P','2016-04-04 00:00:00',1,'32000182','Masculino','20320018117','CENTINI CARLOS','A','Soltero','Consumidor Final',1,1),
(183,1,'P','2016-04-04 00:00:00',1,'32000183','Masculino','20320018217','OBREGO OMAR','A','Soltero','Consumidor Final',1,1),
(184,1,'P','2016-04-04 00:00:00',1,'32000184','Masculino','20320018317','MOYANO VALERIA / JOSE','A','Soltero','Consumidor Final',1,1),
(185,1,'P','2016-04-04 00:00:00',1,'32000185','Masculino','20320018417','MOYANO','A','Soltero','Consumidor Final',1,1),
(186,1,'P','2016-04-04 00:00:00',1,'32000186','Masculino','20320018517','RAMOS','A','Soltero','Consumidor Final',1,1),
(187,1,'P','2016-04-04 00:00:00',1,'32000187','Masculino','20320018617','SANCHEZ WALTER','A','Soltero','Consumidor Final',1,1),
(188,1,'P','2016-04-04 00:00:00',1,'32000188','Masculino','20320018717','ARANCIBIA OMAR','A','Soltero','Consumidor Final',1,1),
(189,1,'P','2016-04-04 00:00:00',1,'32000189','Masculino','20320018817','ARANCIBIA MADRE','A','Soltero','Consumidor Final',1,1),
(190,1,'P','2016-04-04 00:00:00',1,'32000190','Masculino','20320018917','ALFARO','A','Soltero','Consumidor Final',1,1),
(191,1,'P','2016-04-04 00:00:00',1,'32000191','Masculino','20320019017','MEDICI','A','Soltero','Consumidor Final',1,1),
(192,1,'P','2016-04-04 00:00:00',1,'32000192','Masculino','20320019117','GROSO GRACIELA','A','Soltero','Consumidor Final',1,1),
(193,1,'P','2016-04-04 00:00:00',1,'32000193','Masculino','20320019217','ALDECO NATY','A','Soltero','Consumidor Final',1,1),
(194,1,'P','2016-04-04 00:00:00',1,'32000194','Masculino','20320019317','OYOLA','A','Soltero','Consumidor Final',1,1),
(195,1,'P','2016-04-04 00:00:00',1,'32000195','Masculino','20320019417','OLMEDO MARIO','A','Soltero','Consumidor Final',1,1),
(196,1,'P','2016-04-04 00:00:00',1,'32000196','Masculino','20320019517','CORVALAN','A','Soltero','Consumidor Final',1,1),
(197,1,'P','2016-04-04 00:00:00',1,'32000197','Masculino','20320019617','BRIZUELA TALLER','A','Soltero','Consumidor Final',1,1),
(198,1,'P','2016-04-04 00:00:00',1,'32000198','Masculino','20320019717','MALDONADO ALFREDO','A','Soltero','Consumidor Final',1,1),
(199,1,'P','2016-04-04 00:00:00',1,'32000199','Masculino','20320019817','JOSE','A','Soltero','Consumidor Final',1,1),
(200,1,'P','2016-04-04 00:00:00',1,'32000200','Masculino','20320019917','FLORI','A','Soltero','Consumidor Final',1,1),
(201,1,'P','2016-04-04 00:00:00',1,'32000201','Masculino','20320020017','NIETO','A','Soltero','Consumidor Final',1,1),
(202,1,'P','2016-04-04 00:00:00',1,'32000202','Masculino','20320020117','CARI ROMINA','A','Soltero','Consumidor Final',1,1),
(203,1,'P','2016-04-04 00:00:00',1,'32000203','Masculino','20320020217','CARI CAROLA','A','Soltero','Consumidor Final',1,1),
(204,1,'P','2016-04-04 00:00:00',1,'32000204','Masculino','20320020317','ROJO DEPOSITO','A','Soltero','Consumidor Final',1,1),
(205,1,'P','2016-04-04 00:00:00',1,'32000205','Masculino','20320020417','ALVAREZ','A','Soltero','Consumidor Final',1,1),
(206,1,'P','2016-04-04 00:00:00',1,'32000206','Masculino','20320020517','AGUERO.','A','Soltero','Consumidor Final',1,1),
(207,1,'P','2016-04-04 00:00:00',1,'32000207','Masculino','20320020617','LORENZO','A','Soltero','Consumidor Final',1,1),
(208,1,'P','2016-04-04 00:00:00',1,'32000208','Masculino','20320020717','NAPOLI','A','Soltero','Consumidor Final',1,1),
(209,1,'P','2016-04-04 00:00:00',1,'32000209','Masculino','20320020817','BRIZUELA','A','Soltero','Consumidor Final',1,1),
(210,1,'P','2016-04-04 00:00:00',1,'32000210','Masculino','20320020917','BRIZUELA P','A','Soltero','Consumidor Final',1,1),
(211,1,'P','2016-04-04 00:00:00',1,'32000211','Masculino','20320021017','POLLINO','A','Soltero','Consumidor Final',1,1),
(212,1,'P','2016-04-04 00:00:00',1,'32000212','Masculino','20320021117','MARTINEZ','A','Soltero','Consumidor Final',1,1),
(213,1,'P','2016-04-04 00:00:00',1,'32000213','Masculino','20320021217','RIMOLDI','A','Soltero','Consumidor Final',1,1),
(214,1,'P','2016-04-04 00:00:00',1,'32000214','Masculino','20320021317','ARIAS MARCELA','A','Soltero','Consumidor Final',1,1),
(215,1,'P','2016-04-04 00:00:00',1,'32000215','Masculino','20320021417','ARIAS','A','Soltero','Consumidor Final',1,1),
(216,1,'P','2016-04-04 00:00:00',1,'32000216','Masculino','20320021517','SANCHEZ','A','Soltero','Consumidor Final',1,1),
(217,1,'P','2016-04-04 00:00:00',1,'32000217','Masculino','20320021617','TABELLA','A','Soltero','Consumidor Final',1,1),
(218,1,'P','2016-04-04 00:00:00',1,'32000218','Masculino','20320021717','SARA','A','Soltero','Consumidor Final',1,1),
(219,1,'P','2016-04-04 00:00:00',1,'32000219','Masculino','20320021817','ALERCIA','A','Soltero','Consumidor Final',1,1),
(220,1,'P','2016-04-04 00:00:00',1,'32000220','Masculino','20320021917','NATALIA','A','Soltero','Consumidor Final',1,1),
(221,1,'P','2016-04-04 00:00:00',1,'32000221','Masculino','20320022017','NUEDO PATRICIA','A','Soltero','Consumidor Final',1,1),
(222,1,'P','2016-04-04 00:00:00',1,'32000222','Masculino','20320022117','VELAZQUEZ','A','Soltero','Consumidor Final',1,1),
(223,1,'P','2016-04-04 00:00:00',1,'32000223','Masculino','20320022217','BROGYAY','A','Soltero','Consumidor Final',1,1),
(224,1,'P','2016-04-04 00:00:00',1,'32000224','Masculino','20320022317','BROGYAY GLORIA','A','Soltero','Consumidor Final',1,1),
(225,1,'P','2016-04-04 00:00:00',1,'32000225','Masculino','20320022417','MIGUEL','A','Soltero','Consumidor Final',1,1),
(226,1,'P','2016-04-04 00:00:00',1,'32000226','Masculino','20320022517','ANDREA','A','Soltero','Consumidor Final',1,1),
(227,1,'P','2016-04-04 00:00:00',1,'32000227','Masculino','20320022617','CORDOBA.','A','Soltero','Consumidor Final',1,1),
(228,1,'P','2016-04-04 00:00:00',1,'32000228','Masculino','20320022717','GIACAGLI','A','Soltero','Consumidor Final',1,1),
(229,1,'P','2016-04-04 00:00:00',1,'32000229','Masculino','20320022817','DANIELE YANINA','A','Soltero','Consumidor Final',1,1),
(230,1,'P','2016-04-04 00:00:00',1,'32000230','Masculino','20320022917','MORIS','A','Soltero','Consumidor Final',1,1),
(231,1,'P','2016-04-04 00:00:00',1,'32000231','Masculino','20320023017','MEDINA SEBASTIAN','A','Soltero','Consumidor Final',1,1),
(232,1,'P','2016-04-04 00:00:00',1,'32000232','Masculino','20320023117','BURGOS','A','Soltero','Consumidor Final',1,1),
(233,1,'P','2016-04-04 00:00:00',1,'32000233','Masculino','20320023217','BAR','A','Soltero','Consumidor Final',1,1),
(234,1,'P','2016-04-04 00:00:00',1,'32000234','Masculino','20320023317','GONZALES','A','Soltero','Consumidor Final',1,1),
(235,1,'P','2016-04-04 00:00:00',1,'32000235','Masculino','20320023417','VACA PAOLA','A','Soltero','Consumidor Final',1,1),
(236,1,'P','2016-04-04 00:00:00',1,'32000236','Masculino','20320023517','LEONEL GABRIEL','A','Soltero','Consumidor Final',1,1),
(237,1,'P','2016-04-04 00:00:00',1,'32000237','Masculino','20320023617','DOÑA LUISA','A','Soltero','Consumidor Final',1,1),
(238,1,'P','2016-04-04 00:00:00',1,'32000238','Masculino','20320023717','OYOLA.','A','Soltero','Consumidor Final',1,1),
(239,1,'P','2016-04-04 00:00:00',1,'32000239','Masculino','20320023817','LUDUEÑA','A','Soltero','Consumidor Final',1,1),
(240,1,'P','2016-04-04 00:00:00',1,'32000240','Masculino','20320023917','CREADO','A','Soltero','Consumidor Final',1,1),
(241,1,'P','2016-04-04 00:00:00',1,'32000241','Masculino','20320024017','CASTILLOS','A','Soltero','Consumidor Final',1,1),
(242,1,'P','2016-04-04 00:00:00',1,'32000242','Masculino','20320024117','SANCHEZ.','A','Soltero','Consumidor Final',1,1),
(243,1,'P','2016-04-04 00:00:00',1,'32000243','Masculino','20320024217','TORRES.','A','Soltero','Consumidor Final',1,1),
(244,1,'P','2016-04-04 00:00:00',1,'32000244','Masculino','20320024317','SANGENIS','A','Soltero','Consumidor Final',1,1),
(245,1,'P','2016-04-04 00:00:00',1,'32000245','Masculino','20320024417','APAZE','A','Soltero','Consumidor Final',1,1),
(246,1,'P','2016-04-04 00:00:00',1,'32000246','Masculino','20320024517','LULA','A','Soltero','Consumidor Final',1,1),
(247,1,'P','2016-04-04 00:00:00',1,'32000247','Masculino','20320024617','MENDOZA','A','Soltero','Consumidor Final',1,1),
(248,1,'P','2016-04-04 00:00:00',1,'32000248','Masculino','20320024717','ARIEL','A','Soltero','Consumidor Final',1,1),
(249,1,'P','2016-04-04 00:00:00',1,'32000249','Masculino','20320024817','ALEJANDRA','A','Soltero','Consumidor Final',1,1),
(250,1,'P','2016-04-04 00:00:00',1,'32000250','Masculino','20320024917','ROSAS','A','Soltero','Consumidor Final',1,1),
(251,1,'P','2016-04-04 00:00:00',1,'32000251','Masculino','20320025017','ISABEL','A','Soltero','Consumidor Final',1,1),
(252,1,'P','2016-04-04 00:00:00',1,'32000252','Masculino','20320025117','HECTOR.','A','Soltero','Consumidor Final',1,1),
(253,1,'P','2016-04-04 00:00:00',1,'32000253','Masculino','20320025217','MARIA.','A','Soltero','Consumidor Final',1,1),
(254,1,'P','2016-04-04 00:00:00',1,'32000254','Masculino','20320025317','OLEA','A','Soltero','Consumidor Final',1,1),
(255,1,'P','2016-04-04 00:00:00',1,'32000255','Masculino','20320025417','PEDERNERA','A','Soltero','Consumidor Final',1,1),
(256,1,'P','2016-04-04 00:00:00',1,'32000256','Masculino','20320025517','ARCARI','A','Soltero','Consumidor Final',1,1),
(257,1,'P','2016-04-04 00:00:00',1,'32000257','Masculino','20320025617','JUARES','A','Soltero','Consumidor Final',1,1),
(258,1,'P','2016-04-04 00:00:00',1,'32000258','Masculino','20320025717','ANGIOLINI','A','Soltero','Consumidor Final',1,1),
(259,1,'P','2016-04-04 00:00:00',1,'32000259','Masculino','20320025817','FAVALESA','A','Soltero','Consumidor Final',1,1),
(260,1,'P','2016-04-04 00:00:00',1,'32000260','Masculino','20320025917','ACEVEDO','A','Soltero','Consumidor Final',1,1),
(261,1,'P','2016-04-04 00:00:00',1,'32000261','Masculino','20320026017','BLANC HECTOR','A','Soltero','Consumidor Final',1,1),
(262,1,'P','2016-04-04 00:00:00',1,'32000262','Masculino','20320026117','ARANDA','A','Soltero','Consumidor Final',1,1),
(263,1,'P','2016-04-04 00:00:00',1,'32000263','Masculino','20320026217','ANGULO','A','Soltero','Consumidor Final',1,1),
(264,1,'P','2016-04-04 00:00:00',1,'32000264','Masculino','20320026317','TEMER','A','Soltero','Consumidor Final',1,1),
(265,1,'P','2016-04-04 00:00:00',1,'32000265','Masculino','20320026417','DOMINI','A','Soltero','Consumidor Final',1,1),
(266,1,'P','2016-04-04 00:00:00',1,'32000266','Masculino','20320026517','ACEVEDO JOSE','A','Soltero','Consumidor Final',1,1),
(267,1,'P','2016-04-04 00:00:00',1,'32000267','Masculino','20320026617','OLIVA','A','Soltero','Consumidor Final',1,1),
(268,1,'P','2016-04-04 00:00:00',1,'32000268','Masculino','20320026717','FASULLO EDUARDO','A','Soltero','Consumidor Final',1,1),
(269,1,'P','2016-04-04 00:00:00',1,'32000269','Masculino','20320026817','MARTINI','A','Soltero','Consumidor Final',1,1),
(270,1,'P','2016-04-04 00:00:00',1,'32000270','Masculino','20320026917','FASULLO','A','Soltero','Consumidor Final',1,1),
(271,1,'P','2016-04-04 00:00:00',1,'32000271','Masculino','20320027017','ORTIZ','A','Soltero','Consumidor Final',1,1),
(272,1,'P','2016-04-04 00:00:00',1,'32000272','Masculino','20320027117','VILLAFAÑE','A','Soltero','Consumidor Final',1,1),
(273,1,'P','2016-04-04 00:00:00',1,'32000273','Masculino','20320027217','RODRIGUES','A','Soltero','Consumidor Final',1,1),
(274,1,'P','2016-04-04 00:00:00',1,'32000274','Masculino','20320027317','LEDESMA','A','Soltero','Consumidor Final',1,1),
(275,1,'P','2016-04-04 00:00:00',1,'32000275','Masculino','20320027417','LEGUIZAMON','A','Soltero','Consumidor Final',1,1),
(276,1,'P','2016-04-04 00:00:00',1,'32000276','Masculino','20320027517','COLLANTE ELIO','A','Soltero','Consumidor Final',1,1),
(277,1,'P','2016-04-04 00:00:00',1,'32000277','Masculino','20320027617','MOYANO.','A','Soltero','Consumidor Final',1,1),
(278,1,'P','2016-04-04 00:00:00',1,'32000278','Masculino','20320027717','MOYANO ADRIANA','A','Soltero','Consumidor Final',1,1),
(279,1,'P','2016-04-04 00:00:00',1,'32000279','Masculino','20320027817','PERALTA','A','Soltero','Consumidor Final',1,1),
(280,1,'P','2016-04-04 00:00:00',1,'32000280','Masculino','20320027917','AGUELLAY MATILDE','A','Soltero','Consumidor Final',1,1),
(281,1,'P','2016-04-04 00:00:00',1,'32000281','Masculino','20320028017','ACOSTA.','A','Soltero','Consumidor Final',1,1),
(282,1,'P','2016-04-04 00:00:00',1,'32000282','Masculino','20320028117','DIESTEFANO','A','Soltero','Consumidor Final',1,1),
(283,1,'P','2016-04-04 00:00:00',1,'32000283','Masculino','20320028217','PEREZ.','A','Soltero','Consumidor Final',1,1),
(284,1,'P','2016-04-04 00:00:00',1,'32000284','Masculino','20320028317','BORDAGORRI','A','Soltero','Consumidor Final',1,1),
(285,1,'P','2016-04-04 00:00:00',1,'32000285','Masculino','20320028417','ORTIZ.','A','Soltero','Consumidor Final',1,1),
(286,1,'P','2016-04-04 00:00:00',1,'32000286','Masculino','20320028517','FERNANDEZ','A','Soltero','Consumidor Final',1,1),
(287,1,'P','2016-04-04 00:00:00',1,'32000287','Masculino','20320028617','ROMAGNOLO','A','Soltero','Consumidor Final',1,1),
(288,1,'P','2016-04-04 00:00:00',1,'32000288','Masculino','20320028717','ROSSI','A','Soltero','Consumidor Final',1,1),
(289,1,'P','2016-04-04 00:00:00',1,'32000289','Masculino','20320028817','ABEL','A','Soltero','Consumidor Final',1,1),
(290,1,'P','2016-04-04 00:00:00',1,'32000290','Masculino','20320028917','CODA NATALIA','A','Soltero','Consumidor Final',1,1),
(291,1,'P','2016-04-04 00:00:00',1,'32000291','Masculino','20320029017','SANCHEZ JAVIER','A','Soltero','Consumidor Final',1,1),
(292,1,'P','2016-04-04 00:00:00',1,'32000292','Masculino','20320029117','PASTORINO','A','Soltero','Consumidor Final',1,1),
(293,1,'P','2016-04-04 00:00:00',1,'32000293','Masculino','20320029217','NOELIA..','A','Soltero','Consumidor Final',1,1),
(294,1,'P','2016-04-04 00:00:00',1,'32000294','Masculino','20320029317','RIBOTI','A','Soltero','Consumidor Final',1,1),
(295,1,'P','2016-04-04 00:00:00',1,'32000295','Masculino','20320029417','LLANOS','A','Soltero','Consumidor Final',1,1),
(296,1,'P','2016-04-04 00:00:00',1,'32000296','Masculino','20320029517','TONON','A','Soltero','Consumidor Final',1,1),
(297,1,'P','2016-04-04 00:00:00',1,'32000297','Masculino','20320029617','OLIVA.','A','Soltero','Consumidor Final',1,1),
(298,1,'P','2016-04-04 00:00:00',1,'32000298','Masculino','20320029717','JULIA','A','Soltero','Consumidor Final',1,1),
(299,1,'P','2016-04-04 00:00:00',1,'32000299','Masculino','20320029817','VARAS','A','Soltero','Consumidor Final',1,1),
(300,1,'P','2016-04-04 00:00:00',1,'32000300','Masculino','20320029917','RAMB','A','Soltero','Consumidor Final',1,1),
(301,1,'P','2016-04-04 00:00:00',1,'32000301','Masculino','20320030017','KARAMELO ZAPATERIA','A','Soltero','Consumidor Final',1,1),
(302,1,'P','2016-04-04 00:00:00',1,'32000302','Masculino','20320030117','DELTA','A','Soltero','Consumidor Final',1,1),
(303,1,'P','2016-04-04 00:00:00',1,'32000303','Masculino','20320030217','SOSA JULIA','A','Soltero','Consumidor Final',1,1),
(304,1,'P','2016-04-04 00:00:00',1,'32000304','Masculino','20320030317','VILLAFAÑE VERONICA','A','Soltero','Consumidor Final',1,1),
(305,1,'P','2016-04-04 00:00:00',1,'32000305','Masculino','20320030417','MONICA.','A','Soltero','Consumidor Final',1,1),
(306,1,'P','2016-04-04 00:00:00',1,'32000306','Masculino','20320030517','PASTORINO.','A','Soltero','Consumidor Final',1,1),
(307,1,'P','2016-04-04 00:00:00',1,'32000307','Masculino','20320030617','MARTINEZ.','A','Soltero','Consumidor Final',1,1),
(308,1,'P','2016-04-04 00:00:00',1,'32000308','Masculino','20320030717','TABORDA','A','Soltero','Consumidor Final',1,1),
(309,1,'P','2016-04-04 00:00:00',1,'32000309','Masculino','20320030817','LAURIA','A','Soltero','Consumidor Final',1,1),
(310,1,'P','2016-04-04 00:00:00',1,'32000310','Masculino','20320030917','GUZMAN','A','Soltero','Consumidor Final',1,1),
(311,1,'P','2016-04-04 00:00:00',1,'32000311','Masculino','20320031017','GLORIA','A','Soltero','Consumidor Final',1,1),
(312,1,'P','2016-04-04 00:00:00',1,'32000312','Masculino','20320031117','DAVILA','A','Soltero','Consumidor Final',1,1),
(313,1,'P','2016-04-04 00:00:00',1,'32000313','Masculino','20320031217','CARRIZO MANUEL','A','Soltero','Consumidor Final',1,1),
(314,1,'P','2016-04-04 00:00:00',1,'32000314','Masculino','20320031317','RAMOS GABY','A','Soltero','Consumidor Final',1,1),
(315,1,'P','2016-04-04 00:00:00',1,'32000315','Masculino','20320031417','MARRUCO','A','Soltero','Consumidor Final',1,1),
(316,1,'P','2016-04-04 00:00:00',1,'32000316','Masculino','20320031517','ANDREANI','A','Soltero','Consumidor Final',1,1),
(317,1,'P','2016-04-04 00:00:00',1,'32000317','Masculino','20320031617','BARROS','A','Soltero','Consumidor Final',1,1),
(318,1,'P','2016-04-04 00:00:00',1,'32000318','Masculino','20320031717','SALVATELLI','A','Soltero','Consumidor Final',1,1),
(319,1,'P','2016-04-04 00:00:00',1,'32000319','Masculino','20320031817','ALEJO CELINA','A','Soltero','Consumidor Final',1,1),
(320,1,'P','2016-04-04 00:00:00',1,'32000320','Masculino','20320031917','RINALDI / MENDEZ','A','Soltero','Consumidor Final',1,1),
(321,1,'P','2016-04-04 00:00:00',1,'32000321','Masculino','20320032017','NIEVAS','A','Soltero','Consumidor Final',1,1),
(322,1,'P','2016-04-04 00:00:00',1,'32000322','Masculino','20320032117','SERVICIO DEL VALLE','A','Soltero','Consumidor Final',1,1),
(323,1,'P','2016-04-04 00:00:00',1,'32000323','Masculino','20320032217','SOTO','A','Soltero','Consumidor Final',1,1),
(324,1,'P','2016-04-04 00:00:00',1,'32000324','Masculino','20320032317','CONTI','A','Soltero','Consumidor Final',1,1),
(325,1,'P','2016-04-04 00:00:00',1,'32000325','Masculino','20320032417','RAMELLO','A','Soltero','Consumidor Final',1,1),
(326,1,'P','2016-04-04 00:00:00',1,'32000326','Masculino','20320032517','BADARIOTI','A','Soltero','Consumidor Final',1,1),
(327,1,'P','2016-04-04 00:00:00',1,'32000327','Masculino','20320032617','ZARATE','A','Soltero','Consumidor Final',1,1),
(328,1,'P','2016-04-04 00:00:00',1,'32000328','Masculino','20320032717','ARRASCAETA','A','Soltero','Consumidor Final',1,1),
(329,1,'P','2016-04-04 00:00:00',1,'32000329','Masculino','20320032817','GARCIA CLARA','A','Soltero','Consumidor Final',1,1),
(330,1,'P','2016-04-04 00:00:00',1,'32000330','Masculino','20320032917','GARCIA CLAUDIA','A','Soltero','Consumidor Final',1,1),
(331,1,'P','2016-04-04 00:00:00',1,'32000331','Masculino','20320033017','MOLINA','A','Soltero','Consumidor Final',1,1),
(332,1,'P','2016-04-04 00:00:00',1,'32000332','Masculino','20320033117','SUAREZ','A','Soltero','Consumidor Final',1,1),
(333,1,'P','2016-04-04 00:00:00',1,'32000333','Masculino','20320033217','ANGULO.','A','Soltero','Consumidor Final',1,1),
(334,1,'P','2016-04-04 00:00:00',1,'32000334','Masculino','20320033317','CARNERO MARIANO','A','Soltero','Consumidor Final',1,1),
(335,1,'P','2016-04-04 00:00:00',1,'32000335','Masculino','20320033417','ARCE KARINA','A','Soltero','Consumidor Final',1,1),
(336,1,'P','2016-04-04 00:00:00',1,'32000336','Masculino','20320033517','JORGELINA','A','Soltero','Consumidor Final',1,1),
(337,1,'P','2016-04-04 00:00:00',1,'32000337','Masculino','20320033617','ORIETA MARY','A','Soltero','Consumidor Final',1,1),
(338,1,'P','2016-04-04 00:00:00',1,'32000338','Masculino','20320033717','ORIETA RAMONA','A','Soltero','Consumidor Final',1,1),
(339,1,'P','2016-04-04 00:00:00',1,'32000339','Masculino','20320033817','MAURICIO','A','Soltero','Consumidor Final',1,1),
(340,1,'P','2016-04-04 00:00:00',1,'32000340','Masculino','20320033917','FARIAS WALTER','A','Soltero','Consumidor Final',1,1),
(341,1,'P','2016-04-04 00:00:00',1,'32000341','Masculino','20320034017','CANO LUCAS','A','Soltero','Consumidor Final',1,1),
(342,1,'P','2016-04-04 00:00:00',1,'32000342','Masculino','20320034117','CANO RULO','A','Soltero','Consumidor Final',1,1),
(343,1,'P','2016-04-04 00:00:00',1,'32000343','Masculino','20320034217','CORDOBA..','A','Soltero','Consumidor Final',1,1),
(344,1,'P','2016-04-04 00:00:00',1,'32000344','Masculino','20320034317','RISSO','A','Soltero','Consumidor Final',1,1),
(345,1,'P','2016-04-04 00:00:00',1,'32000345','Masculino','20320034417','RISSO.','A','Soltero','Consumidor Final',1,1),
(346,1,'P','2016-04-04 00:00:00',1,'32000346','Masculino','20320034517','ROMAGNOLO.','A','Soltero','Consumidor Final',1,1),
(347,1,'P','2016-04-04 00:00:00',1,'32000347','Masculino','20320034617','ROMERO','A','Soltero','Consumidor Final',1,1),
(348,1,'P','2016-04-04 00:00:00',1,'32000348','Masculino','20320034717','SEGURA ROSA','A','Soltero','Consumidor Final',1,1),
(349,1,'P','2016-04-04 00:00:00',1,'32000349','Masculino','20320034817','ROMAGNOLO..','A','Soltero','Consumidor Final',1,1),
(350,1,'P','2016-04-04 00:00:00',1,'32000350','Masculino','20320034917','ROJAS','A','Soltero','Consumidor Final',1,1),
(351,1,'P','2016-04-04 00:00:00',1,'32000351','Masculino','20320035017','MARIA JOSE','A','Soltero','Consumidor Final',1,1),
(352,1,'P','2016-04-04 00:00:00',1,'32000352','Masculino','20320035117','LENCINAS','A','Soltero','Consumidor Final',1,1),
(353,1,'P','2016-04-04 00:00:00',1,'32000353','Masculino','20320035217','MOYANO..','A','Soltero','Consumidor Final',1,1),
(354,1,'P','2016-04-04 00:00:00',1,'32000354','Masculino','20320035317','HUGO HERNANDEZ','A','Soltero','Consumidor Final',1,1),
(355,1,'P','2016-04-04 00:00:00',1,'32000355','Masculino','20320035417','GONZALES','A','Soltero','Consumidor Final',1,1),
(356,1,'P','2016-04-04 00:00:00',1,'32000356','Masculino','20320035517','CORTEZ CELESTE','A','Soltero','Consumidor Final',1,1),
(357,1,'P','2016-04-04 00:00:00',1,'32000357','Masculino','20320035617','CENTRO DE JUBILADOS','A','Soltero','Consumidor Final',1,1),
(358,1,'P','2016-04-04 00:00:00',1,'32000358','Masculino','20320035717','BERNARDIN HUGO','A','Soltero','Consumidor Final',1,1),
(359,1,'P','2016-04-04 00:00:00',1,'32000359','Masculino','20320035817','SANDRA/ALEJANDRO','A','Soltero','Consumidor Final',1,1),
(360,1,'P','2016-04-04 00:00:00',1,'32000360','Masculino','20320035917','MOTOS','A','Soltero','Consumidor Final',1,1),
(361,1,'P','2016-04-04 00:00:00',1,'32000361','Masculino','20320036017','TORRES','A','Soltero','Consumidor Final',1,1),
(362,1,'P','2016-04-04 00:00:00',1,'32000362','Masculino','20320036117','CANO CHICHA','A','Soltero','Consumidor Final',1,1),
(363,1,'P','2016-04-04 00:00:00',1,'32000363','Masculino','20320036217','JOSEFA','A','Soltero','Consumidor Final',1,1),
(364,1,'P','2016-04-04 00:00:00',1,'32000364','Masculino','20320036317','GARCIA','A','Soltero','Consumidor Final',1,1),
(365,1,'P','2016-04-04 00:00:00',1,'32000365','Masculino','20320036417','NAVA ROMINA','A','Soltero','Consumidor Final',1,1),
(366,1,'P','2016-04-04 00:00:00',1,'32000366','Masculino','20320036517','GUTIERREZ','A','Soltero','Consumidor Final',1,1),
(367,1,'P','2016-04-04 00:00:00',1,'32000367','Masculino','20320036617','TOLEDO JACKELIN','A','Soltero','Consumidor Final',1,1),
(368,1,'P','2016-04-04 00:00:00',1,'32000368','Masculino','20320036717','GAUNA','A','Soltero','Consumidor Final',1,1),
(369,1,'P','2016-04-04 00:00:00',1,'32000369','Masculino','20320036817','LORENA / GUSTAVO','A','Soltero','Consumidor Final',1,1),
(370,1,'P','2016-04-04 00:00:00',1,'32000370','Masculino','20320036917','ROBERTO','A','Soltero','Consumidor Final',1,1),
(371,1,'P','2016-04-04 00:00:00',1,'32000371','Masculino','20320037017','VARELA QUIQUE','A','Soltero','Consumidor Final',1,1),
(372,1,'P','2016-04-04 00:00:00',1,'32000372','Masculino','20320037117','TOLEDO','A','Soltero','Consumidor Final',1,1),
(373,1,'P','2016-04-04 00:00:00',1,'32000373','Masculino','20320037217','FIGUEROA FANI','A','Soltero','Consumidor Final',1,1),
(374,1,'P','2016-04-04 00:00:00',1,'32000374','Masculino','20320037317','OVIEDO TERESA','A','Soltero','Consumidor Final',1,1),
(375,1,'P','2016-04-04 00:00:00',1,'32000375','Masculino','20320037417','OVIEDO DANIEL','A','Soltero','Consumidor Final',1,1),
(376,1,'P','2016-04-04 00:00:00',1,'32000376','Masculino','20320037517','FATIMA NAVA','A','Soltero','Consumidor Final',1,1),
(377,1,'P','2016-04-04 00:00:00',1,'32000377','Masculino','20320037617','TREFILIO','A','Soltero','Consumidor Final',1,1),
(378,1,'P','2016-04-04 00:00:00',1,'32000378','Masculino','20320037717','MORALES','A','Soltero','Consumidor Final',1,1),
(379,1,'P','2016-04-04 00:00:00',1,'32000379','Masculino','20320037817','RIVERO','A','Soltero','Consumidor Final',1,1),
(380,1,'P','2016-04-04 00:00:00',1,'32000380','Masculino','20320037917','ROMERO.','A','Soltero','Consumidor Final',1,1),
(381,1,'P','2016-04-04 00:00:00',1,'32000381','Masculino','20320038017','SANCHEZ / GARCIA','A','Soltero','Consumidor Final',1,1),
(382,1,'P','2016-04-04 00:00:00',1,'32000382','Masculino','20320038117','MONICA','A','Soltero','Consumidor Final',1,1),
(383,1,'P','2016-04-04 00:00:00',1,'32000383','Masculino','20320038217','RAMIREZ','A','Soltero','Consumidor Final',1,1),
(384,1,'P','2016-04-04 00:00:00',1,'32000384','Masculino','20320038317','ARCE ANDREA','A','Soltero','Consumidor Final',1,1),
(385,1,'P','2016-04-04 00:00:00',1,'32000385','Masculino','20320038417','MARTINEZ..','A','Soltero','Consumidor Final',1,1),
(386,1,'P','2016-04-04 00:00:00',1,'32000386','Masculino','20320038517','BAZAN..','A','Soltero','Consumidor Final',1,1),
(387,1,'P','2016-04-04 00:00:00',1,'32000387','Masculino','20320038617','SUAREZ.','A','Soltero','Consumidor Final',1,1),
(388,1,'P','2016-04-04 00:00:00',1,'32000388','Masculino','20320038717','ALCAZAR','A','Soltero','Consumidor Final',1,1),
(389,1,'P','2016-04-04 00:00:00',1,'32000389','Masculino','20320038817','CENA','A','Soltero','Consumidor Final',1,1),
(390,1,'P','2016-04-04 00:00:00',1,'32000390','Masculino','20320038917','CANO ARIEL','A','Soltero','Consumidor Final',1,1),
(391,1,'P','2016-04-04 00:00:00',1,'32000391','Masculino','20320039017','SANCHEZ','A','Soltero','Consumidor Final',1,1),
(392,1,'P','2016-04-04 00:00:00',1,'32000392','Masculino','20320039117','SALAS','A','Soltero','Consumidor Final',1,1),
(393,1,'P','2016-04-04 00:00:00',1,'32000393','Masculino','20320039217','SALAS HIJA','A','Soltero','Consumidor Final',1,1),
(394,1,'P','2016-04-04 00:00:00',1,'32000394','Masculino','20320039317','VEGA MARINA','A','Soltero','Consumidor Final',1,1),
(395,1,'P','2016-04-04 00:00:00',1,'32000395','Masculino','20320039417','VERDULERIA ROQUE','A','Soltero','Consumidor Final',1,1),
(396,1,'P','2016-04-04 00:00:00',1,'32000396','Masculino','20320039517','QUIROGA','A','Soltero','Consumidor Final',1,1),
(397,1,'P','2016-04-04 00:00:00',1,'32000397','Masculino','20320039617','GALANTE ALEJANDRA','A','Soltero','Consumidor Final',1,1),
(398,1,'P','2016-04-04 00:00:00',1,'32000398','Masculino','20320039717','TULIAN','A','Soltero','Consumidor Final',1,1),
(399,1,'P','2016-04-04 00:00:00',1,'32000399','Masculino','20320039817','LUJAN ARMINDA','A','Soltero','Consumidor Final',1,1),
(400,1,'P','2016-04-04 00:00:00',1,'32000400','Masculino','20320039917','MOLINA','A','Soltero','Consumidor Final',1,1),
(401,1,'P','2016-04-04 00:00:00',1,'32000401','Masculino','20320040017','MARINIER','A','Soltero','Consumidor Final',1,1),
(402,1,'P','2016-04-04 00:00:00',1,'32000402','Masculino','20320040117','MARQUEZ','A','Soltero','Consumidor Final',1,1),
(403,1,'P','2016-04-04 00:00:00',1,'32000403','Masculino','20320040217','OCHOA','A','Soltero','Consumidor Final',1,1),
(404,1,'P','2016-04-04 00:00:00',1,'32000404','Masculino','20320040317','BAIGORRIA','A','Soltero','Consumidor Final',1,1),
(405,1,'P','2016-04-04 00:00:00',1,'32000405','Masculino','20320040417','MOLINA.','A','Soltero','Consumidor Final',1,1),
(406,1,'P','2016-04-04 00:00:00',1,'32000406','Masculino','20320040517','BAZAN','A','Soltero','Consumidor Final',1,1),
(407,1,'P','2016-04-04 00:00:00',1,'32000407','Masculino','20320040617','OLMOS PAOLA','A','Soltero','Consumidor Final',1,1),
(408,1,'P','2016-04-04 00:00:00',1,'32000408','Masculino','20320040717','LUDUEÑA-','A','Soltero','Consumidor Final',1,1),
(409,1,'P','2016-04-04 00:00:00',1,'32000409','Masculino','20320040817','OLMOS','A','Soltero','Consumidor Final',1,1),
(410,1,'P','2016-04-04 00:00:00',1,'32000410','Masculino','20320040917','BERGARA','A','Soltero','Consumidor Final',1,1),
(411,1,'P','2016-04-04 00:00:00',1,'32000411','Masculino','20320041017','PEREZ..','A','Soltero','Consumidor Final',1,1),
(412,1,'P','2016-04-04 00:00:00',1,'32000412','Masculino','20320041117','PISISTELO BEATRIZ','A','Soltero','Consumidor Final',1,1),
(413,1,'P','2016-04-04 00:00:00',1,'32000413','Masculino','20320041217','PILI REMIS','A','Soltero','Consumidor Final',1,1),
(414,1,'P','2016-04-04 00:00:00',1,'32000414','Masculino','20320041317','LOPEZ MIGUEL','A','Soltero','Consumidor Final',1,1),
(415,1,'P','2016-04-04 00:00:00',1,'32000415','Masculino','20320041417','SARMIENTO','A','Soltero','Consumidor Final',1,1),
(416,1,'P','2016-04-04 00:00:00',1,'32000416','Masculino','20320041517','RAMIREZ.','A','Soltero','Consumidor Final',1,1),
(417,1,'P','2016-04-04 00:00:00',1,'32000417','Masculino','20320041617','LOPEZ','A','Soltero','Consumidor Final',1,1),
(418,1,'P','2016-04-04 00:00:00',1,'32000418','Masculino','20320041717','BUSTOS.','A','Soltero','Consumidor Final',1,1),
(419,1,'P','2016-04-04 00:00:00',1,'32000419','Masculino','20320041817','SANTANDER','A','Soltero','Consumidor Final',1,1),
(420,1,'P','2016-04-04 00:00:00',1,'32000420','Masculino','20320041917','MOLINA','A','Soltero','Consumidor Final',1,1),
(421,1,'P','2016-04-04 00:00:00',1,'32000421','Masculino','20320042017','MOYANO','A','Soltero','Consumidor Final',1,1),
(422,1,'P','2016-04-04 00:00:00',1,'32000422','Masculino','20320042117','QUINTEROS','A','Soltero','Consumidor Final',1,1),
(423,1,'P','2016-04-04 00:00:00',1,'32000423','Masculino','20320042217','CRISTINA..','A','Soltero','Consumidor Final',1,1),
(424,1,'P','2016-04-04 00:00:00',1,'32000424','Masculino','20320042317','QUIRICONI','A','Soltero','Consumidor Final',1,1),
(425,1,'P','2016-04-04 00:00:00',1,'32000425','Masculino','20320042417','PREVITERA','A','Soltero','Consumidor Final',1,1),
(426,1,'P','2016-04-04 00:00:00',1,'32000426','Masculino','20320042517','REYNA','A','Soltero','Consumidor Final',1,1),
(427,1,'P','2016-04-04 00:00:00',1,'32000427','Masculino','20320042617','FABIAN','A','Soltero','Consumidor Final',1,1),
(428,1,'P','2016-04-04 00:00:00',1,'32000428','Masculino','20320042717','ESTELA','A','Soltero','Consumidor Final',1,1),
(429,1,'P','2016-04-04 00:00:00',1,'32000429','Masculino','20320042817','GARRIDO','A','Soltero','Consumidor Final',1,1),
(430,1,'P','2016-04-04 00:00:00',1,'32000430','Masculino','20320042917','CUNTA','A','Soltero','Consumidor Final',1,1),
(431,1,'P','2016-04-04 00:00:00',1,'32000431','Masculino','20320043017','MARTA','A','Soltero','Consumidor Final',1,1),
(432,1,'P','2016-04-04 00:00:00',1,'32000432','Masculino','20320043117','AGUIRRE.','A','Soltero','Consumidor Final',1,1),
(433,1,'P','2016-04-04 00:00:00',1,'32000433','Masculino','20320043217','MALDONADO SONIA','A','Soltero','Consumidor Final',1,1),
(434,1,'P','2016-04-04 00:00:00',1,'32000434','Masculino','20320043317','QUINTEROS.','A','Soltero','Consumidor Final',1,1),
(435,1,'P','2016-04-04 00:00:00',1,'32000435','Masculino','20320043417','QUINTEROS ABUELA','A','Soltero','Consumidor Final',1,1),
(436,1,'P','2016-04-04 00:00:00',1,'32000436','Masculino','20320043517','MARTINEZ RAUL','A','Soltero','Consumidor Final',1,1),
(437,1,'P','2016-04-04 00:00:00',1,'32000437','Masculino','20320043617','MALDONADO ESTER','A','Soltero','Consumidor Final',1,1),
(438,1,'P','2016-04-04 00:00:00',1,'32000438','Masculino','20320043717','MARTA..','A','Soltero','Consumidor Final',1,1),
(439,1,'P','2016-04-04 00:00:00',1,'32000439','Masculino','20320043817','MERCADO','A','Soltero','Consumidor Final',1,1),
(440,1,'P','2016-04-04 00:00:00',1,'32000440','Masculino','20320043917','PALACIOS.','A','Soltero','Consumidor Final',1,1),
(441,1,'P','2016-04-04 00:00:00',1,'32000441','Masculino','20320044017','MARIZA.','A','Soltero','Consumidor Final',1,1),
(442,1,'P','2016-04-04 00:00:00',1,'32000442','Masculino','20320044117','GRACIELA','A','Soltero','Consumidor Final',1,1),
(443,1,'P','2016-04-04 00:00:00',1,'32000443','Masculino','20320044217','SIMENTEL','A','Soltero','Consumidor Final',1,1),
(444,1,'P','2016-04-04 00:00:00',1,'32000444','Masculino','20320044317','FLORES','A','Soltero','Consumidor Final',1,1),
(445,1,'P','2016-04-04 00:00:00',1,'32000445','Masculino','20320044417','PALACIOS..','A','Soltero','Consumidor Final',1,1),
(446,1,'P','2016-04-04 00:00:00',1,'32000446','Masculino','20320044517','DIAZ','A','Soltero','Consumidor Final',1,1),
(447,1,'P','2016-04-04 00:00:00',1,'32000447','Masculino','20320044617','RUIZ CARLA','A','Soltero','Consumidor Final',1,1),
(448,1,'P','2016-04-04 00:00:00',1,'32000448','Masculino','20320044717','RODRIGUEZ FLORENCIO','A','Soltero','Consumidor Final',1,1),
(449,1,'P','2016-04-04 00:00:00',1,'32000449','Masculino','20320044817','BRAVO','A','Soltero','Consumidor Final',1,1),
(450,1,'P','2016-04-04 00:00:00',1,'32000450','Masculino','20320044917','GARCIA YOLANDA','A','Soltero','Consumidor Final',1,1),
(451,1,'P','2016-04-04 00:00:00',1,'32000451','Masculino','20320045017','KIRCICH','A','Soltero','Consumidor Final',1,1),
(452,1,'P','2016-04-04 00:00:00',1,'32000452','Masculino','20320045117','CERINI ALCIRA','A','Soltero','Consumidor Final',1,1),
(453,1,'P','2016-04-04 00:00:00',1,'32000453','Masculino','20320045217','VICENTE','A','Soltero','Consumidor Final',1,1),
(454,1,'P','2016-04-04 00:00:00',1,'32000454','Masculino','20320045317','CANO DIEGO','A','Soltero','Consumidor Final',1,1),
(455,1,'P','2016-04-04 00:00:00',1,'32000455','Masculino','20320045417','NARVAEZ','A','Soltero','Consumidor Final',1,1),
(456,1,'P','2016-04-04 00:00:00',1,'32000456','Masculino','20320045517','LUQUE CLAUDIA','A','Soltero','Consumidor Final',1,1),
(457,1,'P','2016-04-04 00:00:00',1,'32000457','Masculino','20320045617','PERETTI','A','Soltero','Consumidor Final',1,1),
(458,1,'P','2016-04-04 00:00:00',1,'32000458','Masculino','20320045717','GOMEZ LUCY','A','Soltero','Consumidor Final',1,1),
(459,1,'P','2016-04-04 00:00:00',1,'32000459','Masculino','20320045817','PEREYRA.','A','Soltero','Consumidor Final',1,1),
(460,1,'P','2016-04-04 00:00:00',1,'32000460','Masculino','20320045917','BETY','A','Soltero','Consumidor Final',1,1),
(461,1,'P','2016-04-04 00:00:00',1,'32000461','Masculino','20320046017','MANSILLA HECTOR','A','Soltero','Consumidor Final',1,1),
(462,1,'P','2016-04-04 00:00:00',1,'32000462','Masculino','20320046117','SIMONETY','A','Soltero','Consumidor Final',1,1),
(463,1,'P','2016-04-04 00:00:00',1,'32000463','Masculino','20320046217','MACHUCA','A','Soltero','Consumidor Final',1,1),
(464,1,'P','2016-04-04 00:00:00',1,'32000464','Masculino','20320046317','CEPEDA NORBERTO','A','Soltero','Consumidor Final',1,1),
(465,1,'P','2016-04-04 00:00:00',1,'32000465','Masculino','20320046417','TRASOVARES ROBERTO','A','Soltero','Consumidor Final',1,1),
(466,1,'P','2016-04-04 00:00:00',1,'32000466','Masculino','20320046517','VIKY','A','Soltero','Consumidor Final',1,1),
(467,1,'P','2016-04-04 00:00:00',1,'32000467','Masculino','20320046617','CACERES SEBASTIAN','A','Soltero','Consumidor Final',1,1),
(468,1,'P','2016-04-04 00:00:00',1,'32000468','Masculino','20320046717','CAPUANO','A','Soltero','Consumidor Final',1,1),
(469,1,'P','2016-04-04 00:00:00',1,'32000469','Masculino','20320046817','LEIVA','A','Soltero','Consumidor Final',1,1),
(470,1,'P','2016-04-04 00:00:00',1,'32000470','Masculino','20320046917','LUDUEÑA','A','Soltero','Consumidor Final',1,1),
(471,1,'P','2016-04-04 00:00:00',1,'32000471','Masculino','20320047017','OLMOS','A','Soltero','Consumidor Final',1,1),
(472,1,'P','2016-04-04 00:00:00',1,'32000472','Masculino','20320047117','MARTINEZ MONICA','A','Soltero','Consumidor Final',1,1),
(473,1,'P','2016-04-04 00:00:00',1,'32000473','Masculino','20320047217','SOSA','A','Soltero','Consumidor Final',1,1),
(474,1,'P','2016-04-04 00:00:00',1,'32000474','Masculino','20320047317','MARTINEZ MARIELA','A','Soltero','Consumidor Final',1,1),
(475,1,'P','2016-04-04 00:00:00',1,'32000475','Masculino','20320047417','POSSE KARINA','A','Soltero','Consumidor Final',1,1),
(476,1,'P','2016-04-04 00:00:00',1,'32000476','Masculino','20320047517','AZNAL','A','Soltero','Consumidor Final',1,1),
(477,1,'P','2016-04-04 00:00:00',1,'32000477','Masculino','20320047617','CARRION MARCELA','A','Soltero','Consumidor Final',1,1),
(478,1,'P','2016-04-04 00:00:00',1,'32000478','Masculino','20320047717','CHAUVIE ESTELA','A','Soltero','Consumidor Final',1,1),
(479,1,'P','2016-04-04 00:00:00',1,'32000479','Masculino','20320047817','BUSTO JUAN','A','Soltero','Consumidor Final',1,1),
(480,1,'P','2016-04-04 00:00:00',1,'32000480','Masculino','20320047917','GUERRERO.','A','Soltero','Consumidor Final',1,1),
(481,1,'P','2016-04-04 00:00:00',1,'32000481','Masculino','20320048017','JAVIER.','A','Soltero','Consumidor Final',1,1),
(482,1,'P','2016-04-04 00:00:00',1,'32000482','Masculino','20320048117','CAPDEVILA MADRE','A','Soltero','Consumidor Final',1,1),
(483,1,'P','2016-04-04 00:00:00',1,'32000483','Masculino','20320048217','GUEVARA YOLI','A','Soltero','Consumidor Final',1,1),
(484,1,'P','2016-04-04 00:00:00',1,'32000484','Masculino','20320048317','MARQUEZ.','A','Soltero','Consumidor Final',1,1),
(485,1,'P','2016-04-04 00:00:00',1,'32000485','Masculino','20320048417','PAZ JOSE','A','Soltero','Consumidor Final',1,1),
(486,1,'P','2016-04-04 00:00:00',1,'32000486','Masculino','20320048517','ROSSI FLAVIA','A','Soltero','Consumidor Final',1,1),
(487,1,'P','2016-04-04 00:00:00',1,'32000487','Masculino','20320048617','HERRERA VERONICA','A','Soltero','Consumidor Final',1,1),
(488,1,'P','2016-04-04 00:00:00',1,'32000488','Masculino','20320048717','AGUIRRE..','A','Soltero','Consumidor Final',1,1),
(489,1,'P','2016-04-04 00:00:00',1,'32000489','Masculino','20320048817','ARRIETA','A','Soltero','Consumidor Final',1,1),
(490,1,'P','2016-04-04 00:00:00',1,'32000490','Masculino','20320048917','VIDELA','A','Soltero','Consumidor Final',1,1),
(491,1,'P','2016-04-04 00:00:00',1,'32000491','Masculino','20320049017','MEDINA NANCY','A','Soltero','Consumidor Final',1,1),
(492,1,'P','2016-04-04 00:00:00',1,'32000492','Masculino','20320049117','ALE','A','Soltero','Consumidor Final',1,1),
(493,1,'P','2016-04-04 00:00:00',1,'32000493','Masculino','20320049217','PONCE INES','A','Soltero','Consumidor Final',1,1),
(494,1,'P','2016-04-04 00:00:00',1,'32000494','Masculino','20320049317','VIVIANA','A','Soltero','Consumidor Final',1,1),
(495,1,'P','2016-04-04 00:00:00',1,'32000495','Masculino','20320049417','DIAS ELI','A','Soltero','Consumidor Final',1,1),
(496,1,'P','2016-04-04 00:00:00',1,'32000496','Masculino','20320049517','ESCOBAR LAURA','A','Soltero','Consumidor Final',1,1),
(497,1,'P','2016-04-04 00:00:00',1,'32000497','Masculino','20320049617','LOPEZ.','A','Soltero','Consumidor Final',1,1),
(498,1,'P','2016-04-04 00:00:00',1,'32000498','Masculino','20320049717','MACHADO','A','Soltero','Consumidor Final',1,1),
(499,1,'P','2016-04-04 00:00:00',1,'32000499','Masculino','20320049817','FERNANDES','A','Soltero','Consumidor Final',1,1),
(500,1,'P','2016-04-04 00:00:00',1,'32000500','Masculino','20320049917','GUTIERREZ..','A','Soltero','Consumidor Final',1,1),
(501,1,'P','2016-04-04 00:00:00',1,'32000501','Masculino','20320050017','FLORES MARIELA','A','Soltero','Consumidor Final',1,1),
(502,1,'P','2016-04-04 00:00:00',1,'32000502','Masculino','20320050117','LOBO ENRIQUE','A','Soltero','Consumidor Final',1,1),
(503,1,'P','2016-04-04 00:00:00',1,'32000503','Masculino','20320050217','ZAMUDIO CLAUDIO','A','Soltero','Consumidor Final',1,1),
(504,1,'P','2016-04-04 00:00:00',1,'32000504','Masculino','20320050317','ZAMUDIO JOSE','A','Soltero','Consumidor Final',1,1),
(505,1,'P','2016-04-04 00:00:00',1,'32000505','Masculino','20320050417','OLIVA FABIAN','A','Soltero','Consumidor Final',1,1),
(506,1,'P','2016-04-04 00:00:00',1,'32000506','Masculino','20320050517','SOLIS','A','Soltero','Consumidor Final',1,1),
(507,1,'P','2016-04-04 00:00:00',1,'32000507','Masculino','20320050617','MARTINEZ MARGARITA','A','Soltero','Consumidor Final',1,1),
(508,1,'P','2016-04-04 00:00:00',1,'32000508','Masculino','20320050717','NIETO..','A','Soltero','Consumidor Final',1,1),
(509,1,'P','2016-04-04 00:00:00',1,'32000509','Masculino','20320050817','DELGADO AMADO','A','Soltero','Consumidor Final',1,1),
(510,1,'P','2016-04-04 00:00:00',1,'32000510','Masculino','20320050917','VELEZ GABRIELA','A','Soltero','Consumidor Final',1,1),
(511,1,'P','2016-04-04 00:00:00',1,'32000511','Masculino','20320051017','IBAÑEZ VALERIA','A','Soltero','Consumidor Final',1,1),
(512,1,'P','2016-04-04 00:00:00',1,'32000512','Masculino','20320051117','MAXI','A','Soltero','Consumidor Final',1,1),
(513,1,'P','2016-04-04 00:00:00',1,'32000513','Masculino','20320051217','AYENDE CLAUDIA','A','Soltero','Consumidor Final',1,1),
(514,1,'P','2016-04-04 00:00:00',1,'32000514','Masculino','20320051317','ROMAGNOLO','A','Soltero','Consumidor Final',1,1),
(515,1,'P','2016-04-04 00:00:00',1,'32000515','Masculino','20320051417','SANTANDER VANESA','A','Soltero','Consumidor Final',1,1),
(516,1,'P','2016-04-04 00:00:00',1,'32000516','Masculino','20320051517','CINTIA.','A','Soltero','Consumidor Final',1,1),
(517,1,'P','2016-04-04 00:00:00',1,'32000517','Masculino','20320051617','NUÑEZ','A','Soltero','Consumidor Final',1,1),
(518,1,'P','2016-04-04 00:00:00',1,'32000518','Masculino','20320051717','RODRIGUES GLADIS','A','Soltero','Consumidor Final',1,1),
(519,1,'P','2016-04-04 00:00:00',1,'32000519','Masculino','20320051817','BRAVO.','A','Soltero','Consumidor Final',1,1),
(520,1,'P','2016-04-04 00:00:00',1,'32000520','Masculino','20320051917','HEREDIA.','A','Soltero','Consumidor Final',1,1),
(521,1,'P','2016-04-04 00:00:00',1,'32000521','Masculino','20320052017','SACHETO SUSANA','A','Soltero','Consumidor Final',1,1),
(522,1,'P','2016-04-04 00:00:00',1,'32000522','Masculino','20320052117','SOLIS.','A','Soltero','Consumidor Final',1,1),
(523,1,'P','2016-04-04 00:00:00',1,'32000523','Masculino','20320052217','YOLANDA','A','Soltero','Consumidor Final',1,1),
(524,1,'P','2016-04-04 00:00:00',1,'32000524','Masculino','20320052317','GUTIERRES..','A','Soltero','Consumidor Final',1,1),
(525,1,'P','2016-04-04 00:00:00',1,'32000525','Masculino','20320052417','VARELA CARLOS','A','Soltero','Consumidor Final',1,1),
(526,1,'P','2016-04-04 00:00:00',1,'32000526','Masculino','20320052517','AMAYA GRACIELA','A','Soltero','Consumidor Final',1,1),
(527,1,'P','2016-04-04 00:00:00',1,'32000527','Masculino','20320052617','MONTENEGRO RUTH','A','Soltero','Consumidor Final',1,1),
(528,1,'P','2016-04-04 00:00:00',1,'32000528','Masculino','20320052717','MARQUEZ MIRTA','A','Soltero','Consumidor Final',1,1),
(529,1,'P','2016-04-04 00:00:00',1,'32000529','Masculino','20320052817','PEREYRA KARINA','A','Soltero','Consumidor Final',1,1),
(530,1,'P','2016-04-04 00:00:00',1,'32000530','Masculino','20320052917','MARQUEZ NILDA','A','Soltero','Consumidor Final',1,1),
(531,1,'P','2016-04-04 00:00:00',1,'32000531','Masculino','20320053017','EMILIA','A','Soltero','Consumidor Final',1,1),
(532,1,'P','2016-04-04 00:00:00',1,'32000532','Masculino','20320053117','GUTIERREZ VICTOR','A','Soltero','Consumidor Final',1,1),
(533,1,'P','2016-04-04 00:00:00',1,'32000533','Masculino','20320053217','ELIAS CLAUDIA','A','Soltero','Consumidor Final',1,1),
(534,1,'P','2016-04-04 00:00:00',1,'32000534','Masculino','20320053317','ELIAS','A','Soltero','Consumidor Final',1,1),
(535,1,'P','2016-04-04 00:00:00',1,'32000535','Masculino','20320053417','RODRIGUEZ VIVIANA','A','Soltero','Consumidor Final',1,1),
(536,1,'P','2016-04-04 00:00:00',1,'32000536','Masculino','20320053517','MATEO.','A','Soltero','Consumidor Final',1,1),
(537,1,'P','2016-04-04 00:00:00',1,'32000537','Masculino','20320053617','RODRIGUES..','A','Soltero','Consumidor Final',1,1),
(538,1,'P','2016-04-04 00:00:00',1,'32000538','Masculino','20320053717','BENITEZ MARIO','A','Soltero','Consumidor Final',1,1),
(539,1,'P','2016-04-04 00:00:00',1,'32000539','Masculino','20320053817','MATEO CLAUDIA','A','Soltero','Consumidor Final',1,1),
(540,1,'P','2016-04-04 00:00:00',1,'32000540','Masculino','20320053917','LUQUE AGUSTINA','A','Soltero','Consumidor Final',1,1),
(541,1,'P','2016-04-04 00:00:00',1,'32000541','Masculino','20320054017','GONZALES ADRIANA','A','Soltero','Consumidor Final',1,1),
(542,1,'P','2016-04-04 00:00:00',1,'32000542','Masculino','20320054117','LUQUE ANDREA','A','Soltero','Consumidor Final',1,1),
(543,1,'P','2016-04-04 00:00:00',1,'32000543','Masculino','20320054217','HEREDIA..','A','Soltero','Consumidor Final',1,1),
(544,1,'P','2016-04-04 00:00:00',1,'32000544','Masculino','20320054317','FERREYRA.','A','Soltero','Consumidor Final',1,1),
(545,1,'P','2016-04-04 00:00:00',1,'32000545','Masculino','20320054417','FERREYRA OLINDA','A','Soltero','Consumidor Final',1,1),
(546,1,'P','2016-04-04 00:00:00',1,'32000546','Masculino','20320054517','GOMEZ','A','Soltero','Consumidor Final',1,1),
(547,1,'P','2016-04-04 00:00:00',1,'32000547','Masculino','20320054617','CORONEL','A','Soltero','Consumidor Final',1,1),
(548,1,'P','2016-04-04 00:00:00',1,'32000548','Masculino','20320054717','DAGA.','A','Soltero','Consumidor Final',1,1),
(549,1,'P','2016-04-04 00:00:00',1,'32000549','Masculino','20320054817','GABOARDI','A','Soltero','Consumidor Final',1,1),
(550,1,'P','2016-04-04 00:00:00',1,'32000550','Masculino','20320054917','LOENZONI GRACIELA','A','Soltero','Consumidor Final',1,1),
(551,1,'P','2016-04-04 00:00:00',1,'32000551','Masculino','20320055017','TRIVELLI','A','Soltero','Consumidor Final',1,1),
(552,1,'P','2016-04-04 00:00:00',1,'32000552','Masculino','20320055117','SOLE TEREZA','A','Soltero','Consumidor Final',1,1),
(553,1,'P','2016-04-04 00:00:00',1,'32000553','Masculino','20320055217','GARCIA.','A','Soltero','Consumidor Final',1,1),
(554,1,'P','2016-04-04 00:00:00',1,'32000554','Masculino','20320055317','ALVAREZ JAVIER','A','Soltero','Consumidor Final',1,1),
(555,1,'P','2016-04-04 00:00:00',1,'32000555','Masculino','20320055417','MARY (NORES)','A','Soltero','Consumidor Final',1,1),
(556,1,'P','2016-04-04 00:00:00',1,'32000556','Masculino','20320055517','JARDIN NORES','A','Soltero','Consumidor Final',1,1),
(557,1,'P','2016-04-04 00:00:00',1,'32000557','Masculino','20320055617','VILLANUEVA CARLOS','A','Soltero','Consumidor Final',1,1),
(558,1,'P','2016-04-04 00:00:00',1,'32000558','Masculino','20320055717','VILLANUEVA GRACIELA','A','Soltero','Consumidor Final',1,1),
(559,1,'P','2016-04-04 00:00:00',1,'32000559','Masculino','20320055817','MATALONI','A','Soltero','Consumidor Final',1,1),
(560,1,'P','2016-04-04 00:00:00',1,'32000560','Masculino','20320055917','CERVATO','A','Soltero','Consumidor Final',1,1),
(561,1,'P','2016-04-04 00:00:00',1,'32000561','Masculino','20320056017','GIMENEZ','A','Soltero','Consumidor Final',1,1),
(562,1,'P','2016-04-04 00:00:00',1,'32000562','Masculino','20320056117','BERGARA.','A','Soltero','Consumidor Final',1,1),
(563,1,'P','2016-04-04 00:00:00',1,'32000563','Masculino','20320056217','CUELLO','A','Soltero','Consumidor Final',1,1),
(564,1,'P','2016-04-04 00:00:00',1,'32000564','Masculino','20320056317','GOTERO','A','Soltero','Consumidor Final',1,1),
(565,1,'P','2016-04-04 00:00:00',1,'32000565','Masculino','20320056417','GONZALEZ RICARDO','A','Soltero','Consumidor Final',1,1),
(566,1,'P','2016-04-04 00:00:00',1,'32000566','Masculino','20320056517','CORREA','A','Soltero','Consumidor Final',1,1),
(567,1,'P','2016-04-04 00:00:00',1,'32000567','Masculino','20320056617','LAZARO','A','Soltero','Consumidor Final',1,1),
(568,1,'P','2016-04-04 00:00:00',1,'32000568','Masculino','20320056717','USABARRENA PABLO','A','Soltero','Consumidor Final',1,1),
(569,1,'P','2016-04-04 00:00:00',1,'32000569','Masculino','20320056817','BRUNO','A','Soltero','Consumidor Final',1,1),
(570,1,'P','2016-04-04 00:00:00',1,'32000570','Masculino','20320056917','GILABERT VALERIA','A','Soltero','Consumidor Final',1,1),
(571,1,'P','2016-04-04 00:00:00',1,'32000571','Masculino','20320057017','TASSI','A','Soltero','Consumidor Final',1,1),
(572,1,'P','2016-04-04 00:00:00',1,'32000572','Masculino','20320057117','NIEVAS..','A','Soltero','Consumidor Final',1,1),
(573,1,'P','2016-04-04 00:00:00',1,'32000573','Masculino','20320057217','ROSSI RAUL','A','Soltero','Consumidor Final',1,1),
(574,1,'P','2016-04-04 00:00:00',1,'32000574','Masculino','20320057317','URAN JORGE','A','Soltero','Consumidor Final',1,1),
(575,1,'P','2016-04-04 00:00:00',1,'32000575','Masculino','20320057417','CASAS LAURA','A','Soltero','Consumidor Final',1,1),
(576,1,'P','2016-04-04 00:00:00',1,'32000576','Masculino','20320057517','GARCIA..','A','Soltero','Consumidor Final',1,1),
(577,1,'P','2016-04-04 00:00:00',1,'32000577','Masculino','20320057617','LARDONE','A','Soltero','Consumidor Final',1,1),
(578,1,'P','2016-04-04 00:00:00',1,'32000578','Masculino','20320057717','MARTINEZ ALICIA','A','Soltero','Consumidor Final',1,1),
(579,1,'P','2016-04-04 00:00:00',1,'32000579','Masculino','20320057817','TASSI.','A','Soltero','Consumidor Final',1,1),
(580,1,'P','2016-04-04 00:00:00',1,'32000580','Masculino','20320057917','ASIS','A','Soltero','Consumidor Final',1,1),
(581,1,'P','2016-04-04 00:00:00',1,'32000581','Masculino','20320058017','ALI','A','Soltero','Consumidor Final',1,1),
(582,1,'P','2016-04-04 00:00:00',1,'32000582','Masculino','20320058117','CAMINOS','A','Soltero','Consumidor Final',1,1),
(583,1,'P','2016-04-04 00:00:00',1,'32000583','Masculino','20320058217','GONZALES','A','Soltero','Consumidor Final',1,1),
(584,1,'P','2016-04-04 00:00:00',1,'32000584','Masculino','20320058317','MESOPEVA ADRIANA','A','Soltero','Consumidor Final',1,1),
(585,1,'P','2016-04-04 00:00:00',1,'32000585','Masculino','20320058417','ANTONIACI','A','Soltero','Consumidor Final',1,1),
(586,1,'P','2016-04-04 00:00:00',1,'32000586','Masculino','20320058517','DE LA IGLESIA','A','Soltero','Consumidor Final',1,1),
(587,1,'P','2016-04-04 00:00:00',1,'32000587','Masculino','20320058617','MONTES','A','Soltero','Consumidor Final',1,1),
(588,1,'P','2016-04-04 00:00:00',1,'32000588','Masculino','20320058717','QUINTEROS SANDRA','A','Soltero','Consumidor Final',1,1),
(589,1,'P','2016-04-04 00:00:00',1,'32000589','Masculino','20320058817','MASCARIÑO','A','Soltero','Consumidor Final',1,1),
(590,1,'P','2016-04-04 00:00:00',1,'32000590','Masculino','20320058917','DANIELE','A','Soltero','Consumidor Final',1,1),
(591,1,'P','2016-04-04 00:00:00',1,'32000591','Masculino','20320059017','LANZA','A','Soltero','Consumidor Final',1,1),
(592,1,'P','2016-04-04 00:00:00',1,'32000592','Masculino','20320059117','DIAS','A','Soltero','Consumidor Final',1,1),
(593,1,'P','2016-04-04 00:00:00',1,'32000593','Masculino','20320059217','HEREDIA','A','Soltero','Consumidor Final',1,1),
(594,1,'P','2016-04-04 00:00:00',1,'32000594','Masculino','20320059317','ROMERO','A','Soltero','Consumidor Final',1,1),
(595,1,'P','2016-04-04 00:00:00',1,'32000595','Masculino','20320059417','PAVON','A','Soltero','Consumidor Final',1,1),
(596,1,'P','2016-04-04 00:00:00',1,'32000596','Masculino','20320059517','SALVATIERRA','A','Soltero','Consumidor Final',1,1),
(597,1,'P','2016-04-04 00:00:00',1,'32000597','Masculino','20320059617','PERALTA..','A','Soltero','Consumidor Final',1,1),
(598,1,'P','2016-04-04 00:00:00',1,'32000598','Masculino','20320059717','BIASUTTI','A','Soltero','Consumidor Final',1,1),
(599,1,'P','2016-04-04 00:00:00',1,'32000599','Masculino','20320059817','GUTIERREZ JULIO','A','Soltero','Consumidor Final',1,1),
(600,1,'P','2016-04-04 00:00:00',1,'32000600','Masculino','20320059917','JUEZ','A','Soltero','Consumidor Final',1,1),
(601,1,'P','2016-04-04 00:00:00',1,'32000601','Masculino','20320060017','MELERO','A','Soltero','Consumidor Final',1,1),
(602,1,'P','2016-04-04 00:00:00',1,'32000602','Masculino','20320060117','LALO','A','Soltero','Consumidor Final',1,1),
(603,1,'P','2016-04-04 00:00:00',1,'32000603','Masculino','20320060217','MOLINA','A','Soltero','Consumidor Final',1,1),
(604,1,'P','2016-04-04 00:00:00',1,'32000604','Masculino','20320060317','FERREYRA CESAR','A','Soltero','Consumidor Final',1,1),
(605,1,'P','2016-04-04 00:00:00',1,'32000605','Masculino','20320060417','VOCOS','A','Soltero','Consumidor Final',1,1),
(606,1,'P','2016-04-04 00:00:00',1,'32000606','Masculino','20320060517','PIVATO GRACIELA','A','Soltero','Consumidor Final',1,1),
(607,1,'P','2016-04-04 00:00:00',1,'32000607','Masculino','20320060617','RODRIGUES VERONICA','A','Soltero','Consumidor Final',1,1),
(608,1,'P','2016-04-04 00:00:00',1,'32000608','Masculino','20320060717','RODRIGUES ARMANDO','A','Soltero','Consumidor Final',1,1),
(609,1,'P','2016-04-04 00:00:00',1,'32000609','Masculino','20320060817','PIVATO ALBERTO','A','Soltero','Consumidor Final',1,1),
(610,1,'P','2016-04-04 00:00:00',1,'32000610','Masculino','20320060917','GILABERT','A','Soltero','Consumidor Final',1,1),
(611,1,'P','2016-04-04 00:00:00',1,'32000611','Masculino','20320061017','GONZALES','A','Soltero','Consumidor Final',1,1),
(612,1,'P','2016-04-04 00:00:00',1,'32000612','Masculino','20320061117','OCAÑO','A','Soltero','Consumidor Final',1,1),
(613,1,'P','2016-04-04 00:00:00',1,'32000613','Masculino','20320061217','PRESTI','A','Soltero','Consumidor Final',1,1),
(614,1,'P','2016-04-04 00:00:00',1,'32000614','Masculino','20320061317','GARRIDO / DIAZ','A','Soltero','Consumidor Final',1,1),
(615,1,'P','2016-04-04 00:00:00',1,'32000615','Masculino','20320061417','MANSILLA GLADIS','A','Soltero','Consumidor Final',1,1),
(616,1,'P','2016-04-04 00:00:00',1,'32000616','Masculino','20320061517','FERREYRA','A','Soltero','Consumidor Final',1,1),
(617,1,'P','2016-04-04 00:00:00',1,'32000617','Masculino','20320061617','PERLO','A','Soltero','Consumidor Final',1,1),
(618,1,'P','2016-04-04 00:00:00',1,'32000618','Masculino','20320061717','CACACE','A','Soltero','Consumidor Final',1,1),
(619,1,'P','2016-04-04 00:00:00',1,'32000619','Masculino','20320061817','DANIELE.','A','Soltero','Consumidor Final',1,1),
(620,1,'P','2016-04-04 00:00:00',1,'32000620','Masculino','20320061917','FERREYRA..','A','Soltero','Consumidor Final',1,1),
(621,1,'P','2016-04-04 00:00:00',1,'32000621','Masculino','20320062017','CEVALLOS','A','Soltero','Consumidor Final',1,1),
(622,1,'P','2016-04-04 00:00:00',1,'32000622','Masculino','20320062117','CANOVAS','A','Soltero','Consumidor Final',1,1),
(623,1,'P','2016-04-04 00:00:00',1,'32000623','Masculino','20320062217','ALONSO','A','Soltero','Consumidor Final',1,1),
(624,1,'P','2016-04-04 00:00:00',1,'32000624','Masculino','20320062317','FARIAS','A','Soltero','Consumidor Final',1,1),
(625,1,'P','2016-04-04 00:00:00',1,'32000625','Masculino','20320062417','VIGIL','A','Soltero','Consumidor Final',1,1),
(626,1,'P','2016-04-04 00:00:00',1,'32000626','Masculino','20320062517','LUC ABUELA','A','Soltero','Consumidor Final',1,1),
(627,1,'P','2016-04-04 00:00:00',1,'32000627','Masculino','20320062617','ARUJ DANI','A','Soltero','Consumidor Final',1,1),
(628,1,'P','2016-04-04 00:00:00',1,'32000628','Masculino','20320062717','TISERA','A','Soltero','Consumidor Final',1,1),
(629,1,'P','2016-04-04 00:00:00',1,'32000629','Masculino','20320062817','CASTILLA GABRIELA','A','Soltero','Consumidor Final',1,1),
(630,1,'P','2016-04-04 00:00:00',1,'32000630','Masculino','20320062917','MACHUCA MARIA','A','Soltero','Consumidor Final',1,1),
(631,1,'P','2016-04-04 00:00:00',1,'32000631','Masculino','20320063017','CASAS GUSTAVO','A','Soltero','Consumidor Final',1,1),
(632,1,'P','2016-04-04 00:00:00',1,'32000632','Masculino','20320063117','MILLER GLORIA','A','Soltero','Consumidor Final',1,1),
(633,1,'P','2016-04-04 00:00:00',1,'32000633','Masculino','20320063217','AVENDAÑO','A','Soltero','Consumidor Final',1,1),
(634,1,'P','2016-04-04 00:00:00',1,'32000634','Masculino','20320063317','MAFALDA','A','Soltero','Consumidor Final',1,1),
(635,1,'P','2016-04-04 00:00:00',1,'32000635','Masculino','20320063417','TULA','A','Soltero','Consumidor Final',1,1),
(636,1,'P','2016-04-04 00:00:00',1,'32000636','Masculino','20320063517','MARCELA','A','Soltero','Consumidor Final',1,1),
(637,1,'P','2016-04-04 00:00:00',1,'32000637','Masculino','20320063617','VIDELA.','A','Soltero','Consumidor Final',1,1),
(638,1,'P','2016-04-04 00:00:00',1,'32000638','Masculino','20320063717','VILLALON KIOSCO','A','Soltero','Consumidor Final',1,1),
(639,1,'P','2016-04-04 00:00:00',1,'32000639','Masculino','20320063817','VILLALON MERCEDES','A','Soltero','Consumidor Final',1,1),
(640,1,'P','2016-04-04 00:00:00',1,'32000640','Masculino','20320063917','ALVAREZ..','A','Soltero','Consumidor Final',1,1),
(641,1,'P','2016-04-04 00:00:00',1,'32000641','Masculino','20320064017','ASTRID','A','Soltero','Consumidor Final',1,1),
(642,1,'P','2016-04-04 00:00:00',1,'32000642','Masculino','20320064117','ROMERO','A','Soltero','Consumidor Final',1,1),
(643,1,'P','2016-04-04 00:00:00',1,'32000643','Masculino','20320064217','GONZALES','A','Soltero','Consumidor Final',1,1),
(644,1,'P','2016-04-04 00:00:00',1,'32000644','Masculino','20320064317','RODRIGUES LUCY','A','Soltero','Consumidor Final',1,1),
(645,1,'P','2016-04-04 00:00:00',1,'32000645','Masculino','20320064417','GALVAN NAHUEL','A','Soltero','Consumidor Final',1,1),
(646,1,'P','2016-04-04 00:00:00',1,'32000646','Masculino','20320064517','QUIROS','A','Soltero','Consumidor Final',1,1),
(647,1,'P','2016-04-04 00:00:00',1,'32000647','Masculino','20320064617','SUSANA','A','Soltero','Consumidor Final',1,1),
(648,1,'P','2016-04-04 00:00:00',1,'32000648','Masculino','20320064717','RAMONA','A','Soltero','Consumidor Final',1,1),
(649,1,'P','2016-04-04 00:00:00',1,'32000649','Masculino','20320064817','BONALDI LUCIO','A','Soltero','Consumidor Final',1,1),
(650,1,'P','2016-04-04 00:00:00',1,'32000650','Masculino','20320064917','DE LA MORA','A','Soltero','Consumidor Final',1,1),
(651,1,'P','2016-04-04 00:00:00',1,'32000651','Masculino','20320065017','MARTINEZ','A','Soltero','Consumidor Final',1,1),
(652,1,'P','2016-04-04 00:00:00',1,'32000652','Masculino','20320065117','USABARRENA','A','Soltero','Consumidor Final',1,1),
(653,1,'P','2016-04-04 00:00:00',1,'32000653','Masculino','20320065217','USABARRENA','A','Soltero','Consumidor Final',1,1),
(654,1,'P','2016-04-04 00:00:00',1,'32000654','Masculino','20320065317','CONTRERAS ARTURO','A','Soltero','Consumidor Final',1,1),
(655,1,'P','2016-04-04 00:00:00',1,'32000655','Masculino','20320065417','SILVIA','A','Soltero','Consumidor Final',1,1),
(656,1,'P','2016-04-04 00:00:00',1,'32000656','Masculino','20320065517','GUEVARA','A','Soltero','Consumidor Final',1,1),
(657,1,'P','2016-04-04 00:00:00',1,'32000657','Masculino','20320065617','PEDERNERA','A','Soltero','Consumidor Final',1,1),
(658,1,'P','2016-04-04 00:00:00',1,'32000658','Masculino','20320065717','MONTI','A','Soltero','Consumidor Final',1,1),
(659,1,'P','2016-04-04 00:00:00',1,'32000659','Masculino','20320065817','CUPER','A','Soltero','Consumidor Final',1,1),
(660,1,'P','2016-04-04 00:00:00',1,'32000660','Masculino','20320065917','QUEVEDO','A','Soltero','Consumidor Final',1,1),
(661,1,'P','2016-04-04 00:00:00',1,'32000661','Masculino','20320066017','RAMOS','A','Soltero','Consumidor Final',1,1),
(662,1,'P','2016-04-04 00:00:00',1,'32000662','Masculino','20320066117','YULIANI CLAUDIO','A','Soltero','Consumidor Final',1,1),
(663,1,'P','2016-04-04 00:00:00',1,'32000663','Masculino','20320066217','MANSILLA','A','Soltero','Consumidor Final',1,1),
(664,1,'P','2016-04-04 00:00:00',1,'32000664','Masculino','20320066317','RIVAROLA..','A','Soltero','Consumidor Final',1,1),
(665,1,'P','2016-04-04 00:00:00',1,'32000665','Masculino','20320066417','ROBLEDO EDITH','A','Soltero','Consumidor Final',1,1),
(666,1,'P','2016-04-04 00:00:00',1,'32000666','Masculino','20320066517','GUTIERREZ LOLA','A','Soltero','Consumidor Final',1,1),
(667,1,'P','2016-04-04 00:00:00',1,'32000667','Masculino','20320066617','GUTIERREZ ANA','A','Soltero','Consumidor Final',1,1),
(668,1,'P','2016-04-04 00:00:00',1,'32000668','Masculino','20320066717','TORRES..','A','Soltero','Consumidor Final',1,1),
(669,1,'P','2016-04-04 00:00:00',1,'32000669','Masculino','20320066817','ZARATE.','A','Soltero','Consumidor Final',1,1),
(670,1,'P','2016-04-04 00:00:00',1,'32000670','Masculino','20320066917','GAZQUES','A','Soltero','Consumidor Final',1,1),
(671,1,'P','2016-04-04 00:00:00',1,'32000671','Masculino','20320067017','ALTAMIRANO','A','Soltero','Consumidor Final',1,1),
(672,1,'P','2016-04-04 00:00:00',1,'32000672','Masculino','20320067117','MOLINA..','A','Soltero','Consumidor Final',1,1),
(673,1,'P','2016-04-04 00:00:00',1,'32000673','Masculino','20320067217','NIETO.','A','Soltero','Consumidor Final',1,1),
(674,1,'P','2016-04-04 00:00:00',1,'32000674','Masculino','20320067317','MARTIN ANGEL','A','Soltero','Consumidor Final',1,1),
(675,1,'P','2016-04-04 00:00:00',1,'32000675','Masculino','20320067417','CORDOBA','A','Soltero','Consumidor Final',1,1),
(676,1,'P','2016-04-04 00:00:00',1,'32000676','Masculino','20320067517','GORDILLO.','A','Soltero','Consumidor Final',1,1),
(677,1,'P','2016-04-04 00:00:00',1,'32000677','Masculino','20320067617','BUSTAMANTE','A','Soltero','Consumidor Final',1,1),
(678,1,'P','2016-04-04 00:00:00',1,'32000678','Masculino','20320067717','BRAVO..','A','Soltero','Consumidor Final',1,1),
(679,1,'P','2016-04-04 00:00:00',1,'32000679','Masculino','20320067817','TERESITA FRANCITORRA','A','Soltero','Consumidor Final',1,1),
(680,1,'P','2016-04-04 00:00:00',1,'32000680','Masculino','20320067917','MOLINA','A','Soltero','Consumidor Final',1,1),
(681,1,'P','2016-04-04 00:00:00',1,'32000681','Masculino','20320068017','GAITAN','A','Soltero','Consumidor Final',1,1),
(682,1,'P','2016-04-04 00:00:00',1,'32000682','Masculino','20320068117','VEGA','A','Soltero','Consumidor Final',1,1),
(683,1,'P','2016-04-04 00:00:00',1,'32000683','Masculino','20320068217','GUZMAN.','A','Soltero','Consumidor Final',1,1),
(684,1,'P','2016-04-04 00:00:00',1,'32000684','Masculino','20320068317','VERA','A','Soltero','Consumidor Final',1,1),
(685,1,'P','2016-04-04 00:00:00',1,'32000685','Masculino','20320068417','BOOS MELI','A','Soltero','Consumidor Final',1,1),
(686,1,'P','2016-04-04 00:00:00',1,'32000686','Masculino','20320068517','VILLAREAL','A','Soltero','Consumidor Final',1,1),
(687,1,'P','2016-04-04 00:00:00',1,'32000687','Masculino','20320068617','LA REYNA','A','Soltero','Consumidor Final',1,1),
(688,1,'P','2016-04-04 00:00:00',1,'32000688','Masculino','20320068717','VICENTE.','A','Soltero','Consumidor Final',1,1),
(689,1,'P','2016-04-04 00:00:00',1,'32000689','Masculino','20320068817','OSMERINI GISELA','A','Soltero','Consumidor Final',1,1),
(690,1,'P','2016-04-04 00:00:00',1,'32000690','Masculino','20320068917','GOROSITO','A','Soltero','Consumidor Final',1,1),
(691,1,'P','2016-04-04 00:00:00',1,'32000691','Masculino','20320069017','CORIA YOLANDA','A','Soltero','Consumidor Final',1,1),
(692,1,'P','2016-04-04 00:00:00',1,'32000692','Masculino','20320069117','ALBARRACIN','A','Soltero','Consumidor Final',1,1),
(693,1,'P','2016-04-04 00:00:00',1,'32000693','Masculino','20320069217','MONICA..','A','Soltero','Consumidor Final',1,1),
(694,1,'P','2016-04-04 00:00:00',1,'32000694','Masculino','20320069317','YOLI','A','Soltero','Consumidor Final',1,1),
(695,1,'P','2016-04-04 00:00:00',1,'32000695','Masculino','20320069417','ACOSTA..','A','Soltero','Consumidor Final',1,1),
(696,1,'P','2016-04-04 00:00:00',1,'32000696','Masculino','20320069517','AGNOLON','A','Soltero','Consumidor Final',1,1),
(697,1,'P','2016-04-04 00:00:00',1,'32000697','Masculino','20320069617','IRMA','A','Soltero','Consumidor Final',1,1),
(698,1,'P','2016-04-04 00:00:00',1,'32000698','Masculino','20320069717','ALMADA','A','Soltero','Consumidor Final',1,1),
(699,1,'P','2016-04-04 00:00:00',1,'32000699','Masculino','20320069817','MARTINES.','A','Soltero','Consumidor Final',1,1),
(700,1,'P','2016-04-04 00:00:00',1,'32000700','Masculino','20320069917','RIGONATO','A','Soltero','Consumidor Final',1,1),
(701,1,'P','2016-04-04 00:00:00',1,'32000701','Masculino','20320070017','GIL LILIANA','A','Soltero','Consumidor Final',1,1),
(702,1,'P','2016-04-04 00:00:00',1,'32000702','Masculino','20320070117','ANA.','A','Soltero','Consumidor Final',1,1),
(703,1,'P','2016-04-04 00:00:00',1,'32000703','Masculino','20320070217','GONZALES.','A','Soltero','Consumidor Final',1,1),
(704,1,'P','2016-04-04 00:00:00',1,'32000704','Masculino','20320070317','CONTRERAS.','A','Soltero','Consumidor Final',1,1),
(705,1,'P','2016-04-04 00:00:00',1,'32000705','Masculino','20320070417','GONZALES VIVIANA','A','Soltero','Consumidor Final',1,1),
(706,1,'P','2016-04-04 00:00:00',1,'32000706','Masculino','20320070517','SUSANA.','A','Soltero','Consumidor Final',1,1),
(707,1,'P','2016-04-04 00:00:00',1,'32000707','Masculino','20320070617','REYNA.','A','Soltero','Consumidor Final',1,1),
(708,1,'P','2016-04-04 00:00:00',1,'32000708','Masculino','20320070717','PIZARRO','A','Soltero','Consumidor Final',1,1),
(709,1,'P','2016-04-04 00:00:00',1,'32000709','Masculino','20320070817','MALDONADO.','A','Soltero','Consumidor Final',1,1),
(710,1,'P','2016-04-04 00:00:00',1,'32000710','Masculino','20320070917','TONI','A','Soltero','Consumidor Final',1,1),
(711,1,'P','2016-04-04 00:00:00',1,'32000711','Masculino','20320071017','FREIRE','A','Soltero','Consumidor Final',1,1),
(712,1,'P','2016-04-04 00:00:00',1,'32000712','Masculino','20320071117','CARDELLI','A','Soltero','Consumidor Final',1,1),
(713,1,'P','2016-04-04 00:00:00',1,'32000713','Masculino','20320071217','ILDA','A','Soltero','Consumidor Final',1,1),
(714,1,'P','2016-04-04 00:00:00',1,'32000714','Masculino','20320071317','BRAVO','A','Soltero','Consumidor Final',1,1),
(715,1,'P','2016-04-04 00:00:00',1,'32000715','Masculino','20320071417','ANA..','A','Soltero','Consumidor Final',1,1),
(716,1,'P','2016-04-04 00:00:00',1,'32000716','Masculino','20320071517','ANDREA.','A','Soltero','Consumidor Final',1,1),
(717,1,'P','2016-04-04 00:00:00',1,'32000717','Masculino','20320071617','AREVALO GRACIELA','A','Soltero','Consumidor Final',1,1),
(718,1,'P','2016-04-04 00:00:00',1,'32000718','Masculino','20320071717','QUINTEROS..','A','Soltero','Consumidor Final',1,1),
(719,1,'P','2016-04-04 00:00:00',1,'32000719','Masculino','20320071817','GONZALES..','A','Soltero','Consumidor Final',1,1),
(720,1,'P','2016-04-04 00:00:00',1,'32000720','Masculino','20320071917','BUCHINI','A','Soltero','Consumidor Final',1,1),
(721,1,'P','2016-04-04 00:00:00',1,'32000721','Masculino','20320072017','QUINTANA MADRE','A','Soltero','Consumidor Final',1,1),
(722,1,'P','2016-04-04 00:00:00',1,'32000722','Masculino','20320072117','SALTO','A','Soltero','Consumidor Final',1,1),
(723,1,'P','2016-04-04 00:00:00',1,'32000723','Masculino','20320072217','GIMENEZ.','A','Soltero','Consumidor Final',1,1),
(724,1,'P','2016-04-04 00:00:00',1,'32000724','Masculino','20320072317','GUTIERREZ.','A','Soltero','Consumidor Final',1,1),
(725,1,'P','2016-04-04 00:00:00',1,'32000725','Masculino','20320072417','PEREZ SILVIA','A','Soltero','Consumidor Final',1,1),
(726,1,'P','2016-04-04 00:00:00',1,'32000726','Masculino','20320072517','GIMENES','A','Soltero','Consumidor Final',1,1),
(727,1,'P','2016-04-04 00:00:00',1,'32000727','Masculino','20320072617','ANDRADA','A','Soltero','Consumidor Final',1,1),
(728,1,'P','2016-04-04 00:00:00',1,'32000728','Masculino','20320072717','RAQUEL','A','Soltero','Consumidor Final',1,1),
(729,1,'P','2016-04-04 00:00:00',1,'32000729','Masculino','20320072817','NANCY.','A','Soltero','Consumidor Final',1,1),
(730,1,'P','2016-04-04 00:00:00',1,'32000730','Masculino','20320072917','ANTONELLO','A','Soltero','Consumidor Final',1,1),
(731,1,'P','2016-04-04 00:00:00',1,'32000731','Masculino','20320073017','QUIÑONES','A','Soltero','Consumidor Final',1,1),
(732,1,'P','2016-04-04 00:00:00',1,'32000732','Masculino','20320073117','BUSTOS..','A','Soltero','Consumidor Final',1,1),
(733,1,'P','2016-04-04 00:00:00',1,'32000733','Masculino','20320073217','ARANDA PAPUCHO','A','Soltero','Consumidor Final',1,1),
(734,1,'P','2016-04-04 00:00:00',1,'32000734','Masculino','20320073317','PAOLA','A','Soltero','Consumidor Final',1,1),
(735,1,'P','2016-04-04 00:00:00',1,'32000735','Masculino','20320073417','BLANCA','A','Soltero','Consumidor Final',1,1),
(736,1,'P','2016-04-04 00:00:00',1,'32000736','Masculino','20320073517','GIMENES.','A','Soltero','Consumidor Final',1,1),
(737,1,'P','2016-04-04 00:00:00',1,'32000737','Masculino','20320073617','BUSTOS','A','Soltero','Consumidor Final',1,1),
(738,1,'P','2016-04-04 00:00:00',1,'32000738','Masculino','20320073717','GOMEZ.','A','Soltero','Consumidor Final',1,1),
(739,1,'P','2016-04-04 00:00:00',1,'32000739','Masculino','20320073817','PEREYRA NANCY','A','Soltero','Consumidor Final',1,1),
(740,1,'P','2016-04-04 00:00:00',1,'32000740','Masculino','20320073917','CLAUDIA','A','Soltero','Consumidor Final',1,1),
(741,1,'P','2016-04-04 00:00:00',1,'32000741','Masculino','20320074017','ERIKA','A','Soltero','Consumidor Final',1,1),
(742,1,'P','2016-04-04 00:00:00',1,'32000742','Masculino','20320074117','CORREA.','A','Soltero','Consumidor Final',1,1),
(743,1,'P','2016-04-04 00:00:00',1,'32000743','Masculino','20320074217','LUNA REMISERO','A','Soltero','Consumidor Final',1,1),
(744,1,'P','2016-04-04 00:00:00',1,'32000744','Masculino','20320074317','CAMPOS','A','Soltero','Consumidor Final',1,1),
(745,1,'P','2016-04-04 00:00:00',1,'32000745','Masculino','20320074417','GONZALEZ..','A','Soltero','Consumidor Final',1,1),
(746,1,'P','2016-04-04 00:00:00',1,'32000746','Masculino','20320074517','FARIAS.','A','Soltero','Consumidor Final',1,1),
(747,1,'P','2016-04-04 00:00:00',1,'32000747','Masculino','20320074617','SIDRA SILVINA','A','Soltero','Consumidor Final',1,1),
(748,1,'P','2016-04-04 00:00:00',1,'32000748','Masculino','20320074717','ZARATE FABIAN','A','Soltero','Consumidor Final',1,1),
(749,1,'P','2016-04-04 00:00:00',1,'32000749','Masculino','20320074817','RIVAROLA.','A','Soltero','Consumidor Final',1,1),
(750,1,'P','2016-04-04 00:00:00',1,'32000750','Masculino','20320074917','MARQUES EDUARDO','A','Soltero','Consumidor Final',1,1),
(751,1,'P','2016-04-04 00:00:00',1,'32000751','Masculino','20320075017','MOLINA','A','Soltero','Consumidor Final',1,1),
(752,1,'P','2016-04-04 00:00:00',1,'32000752','Masculino','20320075117','SCHUB GERMAN','A','Soltero','Consumidor Final',1,1),
(753,1,'P','2016-04-04 00:00:00',1,'32000753','Masculino','20320075217','RIVAROLA SANFRA','A','Soltero','Consumidor Final',1,1),
(754,1,'P','2016-04-04 00:00:00',1,'32000754','Masculino','20320075317','LLANOS..','A','Soltero','Consumidor Final',1,1),
(755,1,'P','2016-04-04 00:00:00',1,'32000755','Masculino','20320075417','LUQUE','A','Soltero','Consumidor Final',1,1),
(756,1,'P','2016-04-04 00:00:00',1,'32000756','Masculino','20320075517','LOYOLA NANCY','A','Soltero','Consumidor Final',1,1),
(757,1,'P','2016-04-04 00:00:00',1,'32000757','Masculino','20320075617','LOYOLA ROSA','A','Soltero','Consumidor Final',1,1),
(758,1,'P','2016-04-04 00:00:00',1,'32000758','Masculino','20320075717','ROMERO..','A','Soltero','Consumidor Final',1,1),
(759,1,'P','2016-04-04 00:00:00',1,'32000759','Masculino','20320075817','EL TURCO','A','Soltero','Consumidor Final',1,1),
(760,1,'P','2016-04-04 00:00:00',1,'32000760','Masculino','20320075917','GOMES','A','Soltero','Consumidor Final',1,1),
(761,1,'P','2016-04-04 00:00:00',1,'32000761','Masculino','20320076017','LOZA.','A','Soltero','Consumidor Final',1,1),
(762,1,'P','2016-04-04 00:00:00',1,'32000762','Masculino','20320076117','CRISTINA.','A','Soltero','Consumidor Final',1,1),
(763,1,'P','2016-04-04 00:00:00',1,'32000763','Masculino','20320076217','CABRAL','A','Soltero','Consumidor Final',1,1),
(764,1,'P','2016-04-04 00:00:00',1,'32000764','Masculino','20320076317','SOSA.','A','Soltero','Consumidor Final',1,1),
(765,1,'P','2016-04-04 00:00:00',1,'32000765','Masculino','20320076417','GUTIERREZ VICTOR.','A','Soltero','Consumidor Final',1,1),
(766,1,'P','2016-04-04 00:00:00',1,'32000766','Masculino','20320076517','ALVAREZ.','A','Soltero','Consumidor Final',1,1),
(767,1,'P','2016-04-04 00:00:00',1,'32000767','Masculino','20320076617','ROMERO','A','Soltero','Consumidor Final',1,1),
(768,1,'P','2016-04-04 00:00:00',1,'32000768','Masculino','20320076717','TEJO','A','Soltero','Consumidor Final',1,1),
(769,1,'P','2016-04-04 00:00:00',1,'32000769','Masculino','20320076817','SANCHEZ..','A','Soltero','Consumidor Final',1,1),
(770,1,'P','2016-04-04 00:00:00',1,'32000770','Masculino','20320076917','ALMACEN CLEDIA','A','Soltero','Consumidor Final',1,1),
(771,1,'P','2016-04-04 00:00:00',1,'32000771','Masculino','20320077017','GRIBELL VANESA','A','Soltero','Consumidor Final',1,1),
(772,1,'P','2016-04-04 00:00:00',1,'32000772','Masculino','20320077117','OVIEDO / GITANO','A','Soltero','Consumidor Final',1,1),
(773,1,'P','2016-04-04 00:00:00',1,'32000773','Masculino','20320077217','FONSECA','A','Soltero','Consumidor Final',1,1),
(774,1,'P','2016-04-04 00:00:00',1,'32000774','Masculino','20320077317','NILDA','A','Soltero','Consumidor Final',1,1),
(775,1,'P','2016-04-04 00:00:00',1,'32000775','Masculino','20320077417','FRANCO','A','Soltero','Consumidor Final',1,1),
(776,1,'P','2016-04-04 00:00:00',1,'32000776','Masculino','20320077517','BAIGORRIA MARIA','A','Soltero','Consumidor Final',1,1),
(777,1,'P','2016-04-04 00:00:00',1,'32000777','Masculino','20320077617','VILLAGRA','A','Soltero','Consumidor Final',1,1),
(778,1,'P','2016-04-04 00:00:00',1,'32000778','Masculino','20320077717','GUTIERRES.','A','Soltero','Consumidor Final',1,1),
(779,1,'P','2016-04-04 00:00:00',1,'32000779','Masculino','20320077817','SANCHES KIOSCO','A','Soltero','Consumidor Final',1,1),
(780,1,'P','2016-04-04 00:00:00',1,'32000780','Masculino','20320077917','MEDINA','A','Soltero','Consumidor Final',1,1),
(781,1,'P','2016-04-04 00:00:00',1,'32000781','Masculino','20320078017','HEREDIA ROXANA','A','Soltero','Consumidor Final',1,1),
(782,1,'P','2016-04-04 00:00:00',1,'32000782','Masculino','20320078117','LUIS','A','Soltero','Consumidor Final',1,1),
(783,1,'P','2016-04-04 00:00:00',1,'32000783','Masculino','20320078217','ALARCON','A','Soltero','Consumidor Final',1,1),
(784,1,'P','2016-04-04 00:00:00',1,'32000784','Masculino','20320078317','CASASA LUCAS','A','Soltero','Consumidor Final',1,1),
(785,1,'P','2016-04-04 00:00:00',1,'32000785','Masculino','20320078417','PEREZ KIOSCO','A','Soltero','Consumidor Final',1,1),
(786,1,'P','2016-04-04 00:00:00',1,'32000786','Masculino','20320078517','RANDAZZO ROXANA','A','Soltero','Consumidor Final',1,1),
(787,1,'P','2016-04-04 00:00:00',1,'32000787','Masculino','20320078617','SANCHEZ KIOSCO','A','Soltero','Consumidor Final',1,1),
(788,1,'P','2016-04-04 00:00:00',1,'32000788','Masculino','20320078717','MARY','A','Soltero','Consumidor Final',1,1),
(789,1,'P','2016-04-04 00:00:00',1,'32000789','Masculino','20320078817','GUZMAN..','A','Soltero','Consumidor Final',1,1),
(790,1,'P','2016-04-04 00:00:00',1,'32000790','Masculino','20320078917','GOMEZ SOLDADOR','A','Soltero','Consumidor Final',1,1),
(791,1,'P','2016-04-04 00:00:00',1,'32000791','Masculino','20320079017','FREYRE','A','Soltero','Consumidor Final',1,1),
(792,1,'P','2016-04-04 00:00:00',1,'32000792','Masculino','20320079117','PARMETIER','A','Soltero','Consumidor Final',1,1),
(793,1,'P','2016-04-04 00:00:00',1,'32000793','Masculino','20320079217','BAZAN','A','Soltero','Consumidor Final',1,1),
(794,1,'P','2016-04-04 00:00:00',1,'32000794','Masculino','20320079317','ARMENANTE','A','Soltero','Consumidor Final',1,1),
(795,1,'P','2016-04-04 00:00:00',1,'32000795','Masculino','20320079417','GOMEZ','A','Soltero','Consumidor Final',1,1),
(796,1,'P','2016-04-04 00:00:00',1,'32000796','Masculino','20320079517','MARTINEZ','A','Soltero','Consumidor Final',1,1),
(797,1,'P','2016-04-04 00:00:00',1,'32000797','Masculino','20320079617','VILLADA','A','Soltero','Consumidor Final',1,1),
(798,1,'P','2016-04-04 00:00:00',1,'32000798','Masculino','20320079717','TASSI..','A','Soltero','Consumidor Final',1,1),
(799,1,'P','2016-04-04 00:00:00',1,'32000799','Masculino','20320079817','TASSI EMILIO','A','Soltero','Consumidor Final',1,1),
(800,1,'P','2016-04-04 00:00:00',1,'32000800','Masculino','20320079917','FERNANDEZ.','A','Soltero','Consumidor Final',1,1),
(801,1,'P','2016-04-04 00:00:00',1,'32000801','Masculino','20320080017','RUIZ.','A','Soltero','Consumidor Final',1,1),
(802,1,'P','2016-04-04 00:00:00',1,'32000802','Masculino','20320080117','LUDUEÑA CHICHA','A','Soltero','Consumidor Final',1,1),
(803,1,'P','2016-04-04 00:00:00',1,'32000803','Masculino','20320080217','MARTINEZ GLORIA','A','Soltero','Consumidor Final',1,1),
(804,1,'P','2016-04-04 00:00:00',1,'32000804','Masculino','20320080317','PELUCHI DANIEL','A','Soltero','Consumidor Final',1,1),
(805,1,'P','2016-04-04 00:00:00',1,'32000805','Masculino','20320080417','SANCHEZ HUGO','A','Soltero','Consumidor Final',1,1),
(806,1,'P','2016-04-04 00:00:00',1,'32000806','Masculino','20320080517','GOMEZ GRACIELA','A','Soltero','Consumidor Final',1,1),
(807,1,'P','2016-04-04 00:00:00',1,'32000807','Masculino','20320080617','BENITO','A','Soltero','Consumidor Final',1,1),
(808,1,'P','2016-04-04 00:00:00',1,'32000808','Masculino','20320080717','APAZ','A','Soltero','Consumidor Final',1,1),
(809,1,'P','2016-04-04 00:00:00',1,'32000809','Masculino','20320080817','ANGELITA','A','Soltero','Consumidor Final',1,1),
(810,1,'P','2016-04-04 00:00:00',1,'32000810','Masculino','20320080917','GOMEZ JOSE','A','Soltero','Consumidor Final',1,1),
(811,1,'P','2016-04-04 00:00:00',1,'32000811','Masculino','20320081017','DANIEL','A','Soltero','Consumidor Final',1,1),
(812,1,'P','2016-04-04 00:00:00',1,'32000812','Masculino','20320081117','HIDALGO','A','Soltero','Consumidor Final',1,1),
(813,1,'P','2016-04-04 00:00:00',1,'32000813','Masculino','20320081217','DANIELI','A','Soltero','Consumidor Final',1,1),
(814,1,'P','2016-04-04 00:00:00',1,'32000814','Masculino','20320081317','PORTO','A','Soltero','Consumidor Final',1,1),
(815,1,'P','2016-04-04 00:00:00',1,'32000815','Masculino','20320081417','MATALONI.','A','Soltero','Consumidor Final',1,1),
(816,1,'P','2016-04-04 00:00:00',1,'32000816','Masculino','20320081517','ROSINA POCHA','A','Soltero','Consumidor Final',1,1),
(817,1,'P','2016-04-04 00:00:00',1,'32000817','Masculino','20320081617','FONTANELI','A','Soltero','Consumidor Final',1,1),
(818,1,'P','2016-04-04 00:00:00',1,'32000818','Masculino','20320081717','BROCHERO','A','Soltero','Consumidor Final',1,1),
(819,1,'P','2016-04-04 00:00:00',1,'32000819','Masculino','20320081817','BRUCESI','A','Soltero','Consumidor Final',1,1),
(820,1,'P','2016-04-04 00:00:00',1,'32000820','Masculino','20320081917','BRUCESI MARIANO','A','Soltero','Consumidor Final',1,1),
(821,1,'P','2016-04-04 00:00:00',1,'32000821','Masculino','20320082017','TIENDA SARMIENTO','A','Soltero','Consumidor Final',1,1),
(822,1,'P','2016-04-04 00:00:00',1,'32000822','Masculino','20320082117','SANCHEZ CARMEN','A','Soltero','Consumidor Final',1,1),
(823,1,'P','2016-04-04 00:00:00',1,'32000823','Masculino','20320082217','SANCHEZ','A','Soltero','Consumidor Final',1,1),
(824,1,'P','2016-04-04 00:00:00',1,'32000824','Masculino','20320082317','SANCHEZ OLGA','A','Soltero','Consumidor Final',1,1),
(825,1,'P','2016-04-04 00:00:00',1,'32000825','Masculino','20320082417','ALVARADO','A','Soltero','Consumidor Final',1,1),
(826,1,'P','2016-04-04 00:00:00',1,'32000826','Masculino','20320082517','BROCHERO GRACIELA','A','Soltero','Consumidor Final',1,1),
(827,1,'P','2016-04-04 00:00:00',1,'32000827','Masculino','20320082617','AGUIRRE','A','Soltero','Consumidor Final',1,1),
(828,1,'P','2016-04-04 00:00:00',1,'32000828','Masculino','20320082717','GLADIS / OSCAR','A','Soltero','Consumidor Final',1,1),
(829,1,'P','2016-04-04 00:00:00',1,'32000829','Masculino','20320082817','AGUIRRE','A','Soltero','Consumidor Final',1,1),
(830,1,'P','2016-04-04 00:00:00',1,'32000830','Masculino','20320082917','GUERRERO..','A','Soltero','Consumidor Final',1,1),
(831,1,'P','2016-04-04 00:00:00',1,'32000831','Masculino','20320083017','FERRERO.','A','Soltero','Consumidor Final',1,1),
(832,1,'P','2016-04-04 00:00:00',1,'32000832','Masculino','20320083117','PEREZ MARY','A','Soltero','Consumidor Final',1,1),
(833,1,'P','2016-04-04 00:00:00',1,'32000833','Masculino','20320083217','CAPELO','A','Soltero','Consumidor Final',1,1),
(834,1,'P','2016-04-04 00:00:00',1,'32000834','Masculino','20320083317','GATTI','A','Soltero','Consumidor Final',1,1),
(835,1,'P','2016-04-04 00:00:00',1,'32000835','Masculino','20320083417','GREGORI','A','Soltero','Consumidor Final',1,1),
(836,1,'P','2016-04-04 00:00:00',1,'32000836','Masculino','20320083517','RAMOS.','A','Soltero','Consumidor Final',1,1),
(837,1,'P','2016-04-04 00:00:00',1,'32000837','Masculino','20320083617','SILVINA','A','Soltero','Consumidor Final',1,1),
(838,1,'P','2016-04-04 00:00:00',1,'32000838','Masculino','20320083717','MONSERRAT','A','Soltero','Consumidor Final',1,1),
(839,1,'P','2016-04-04 00:00:00',1,'32000839','Masculino','20320083817','POBIDAICO OLGA','A','Soltero','Consumidor Final',1,1),
(840,1,'P','2016-04-04 00:00:00',1,'32000840','Masculino','20320083917','ANGELICA','A','Soltero','Consumidor Final',1,1),
(841,1,'P','2016-04-04 00:00:00',1,'32000841','Masculino','20320084017','PINO.','A','Soltero','Consumidor Final',1,1),
(842,1,'P','2016-04-04 00:00:00',1,'32000842','Masculino','20320084117','ROCABADO','A','Soltero','Consumidor Final',1,1),
(843,1,'P','2016-04-04 00:00:00',1,'32000843','Masculino','20320084217','LILIANA','A','Soltero','Consumidor Final',1,1),
(844,1,'P','2016-04-04 00:00:00',1,'32000844','Masculino','20320084317','NISSO','A','Soltero','Consumidor Final',1,1),
(845,1,'P','2016-04-04 00:00:00',1,'32000845','Masculino','20320084417','LOYOLA JOSE','A','Soltero','Consumidor Final',1,1),
(846,1,'P','2016-04-04 00:00:00',1,'32000846','Masculino','20320084517','FIGUEROA','A','Soltero','Consumidor Final',1,1),
(847,1,'P','2016-04-04 00:00:00',1,'32000847','Masculino','20320084617','VARELA.','A','Soltero','Consumidor Final',1,1),
(848,1,'P','2016-04-04 00:00:00',1,'32000848','Masculino','20320084717','GUERRERO JORGELINA / ROJAS','A','Soltero','Consumidor Final',1,1),
(849,1,'P','2016-04-04 00:00:00',1,'32000849','Masculino','20320084817','PEREZ SUSANA','A','Soltero','Consumidor Final',1,1),
(850,1,'P','2016-04-04 00:00:00',1,'32000850','Masculino','20320084917','BARACHIO','A','Soltero','Consumidor Final',1,1),
(851,1,'P','2016-04-04 00:00:00',1,'32000851','Masculino','20320085017','GRIBAUDO (COTILLON)','A','Soltero','Consumidor Final',1,1),
(852,1,'P','2016-04-04 00:00:00',1,'32000852','Masculino','20320085117','RIVAROLA','A','Soltero','Consumidor Final',1,1),
(853,1,'P','2016-04-04 00:00:00',1,'32000853','Masculino','20320085217','FERREYRA HUGUITO','A','Soltero','Consumidor Final',1,1),
(854,1,'P','2016-04-04 00:00:00',1,'32000854','Masculino','20320085317','ISUARDI','A','Soltero','Consumidor Final',1,1),
(855,1,'P','2016-04-04 00:00:00',1,'32000855','Masculino','20320085417','ISUARDI PATRICIA','A','Soltero','Consumidor Final',1,1),
(856,1,'P','2016-04-04 00:00:00',1,'32000856','Masculino','20320085517','TOMACELLI','A','Soltero','Consumidor Final',1,1),
(857,1,'P','2016-04-04 00:00:00',1,'32000857','Masculino','20320085617','MARTINEZ','A','Soltero','Consumidor Final',1,1),
(858,1,'P','2016-04-04 00:00:00',1,'32000858','Masculino','20320085717','AMADO','A','Soltero','Consumidor Final',1,1),
(859,1,'P','2016-04-04 00:00:00',1,'32000859','Masculino','20320085817','KARADRAS (LOCAL DE ROPA)','A','Soltero','Consumidor Final',1,1),
(860,1,'P','2016-04-04 00:00:00',1,'32000860','Masculino','20320085917','VARELA..','A','Soltero','Consumidor Final',1,1),
(861,1,'P','2016-04-04 00:00:00',1,'32000861','Masculino','20320086017','ROBERTO.','A','Soltero','Consumidor Final',1,1),
(862,1,'P','2016-04-04 00:00:00',1,'32000862','Masculino','20320086117','PEZ','A','Soltero','Consumidor Final',1,1),
(863,1,'P','2016-04-04 00:00:00',1,'32000863','Masculino','20320086217','LOCAL ROMINA','A','Soltero','Consumidor Final',1,1),
(864,1,'P','2016-04-04 00:00:00',1,'32000864','Masculino','20320086317','CASTELLI','A','Soltero','Consumidor Final',1,1),
(865,1,'P','2016-04-04 00:00:00',1,'32000865','Masculino','20320086417','PEDERNERA.','A','Soltero','Consumidor Final',1,1),
(866,1,'P','2016-04-04 00:00:00',1,'32000866','Masculino','20320086517','PISARELO','A','Soltero','Consumidor Final',1,1),
(867,1,'P','2016-04-04 00:00:00',1,'32000867','Masculino','20320086617','ALARMAS CAVIAN','A','Soltero','Consumidor Final',1,1),
(868,1,'P','2016-04-04 00:00:00',1,'32000868','Masculino','20320086717','CISNERO AIDEE','A','Soltero','Consumidor Final',1,1),
(869,1,'P','2016-04-04 00:00:00',1,'32000869','Masculino','20320086817','BRUCESI.','A','Soltero','Consumidor Final',1,1),
(870,1,'P','2016-04-04 00:00:00',1,'32000870','Masculino','20320086917','CASTILLO','A','Soltero','Consumidor Final',1,1),
(871,1,'P','2016-04-04 00:00:00',1,'32000871','Masculino','20320087017','GAMARRO JUAN','A','Soltero','Consumidor Final',1,1),
(872,1,'P','2016-04-04 00:00:00',1,'32000872','Masculino','20320087117','ESPINDOLA','A','Soltero','Consumidor Final',1,1),
(873,1,'P','2016-04-04 00:00:00',1,'32000873','Masculino','20320087217','ALVAREZ','A','Soltero','Consumidor Final',1,1),
(874,1,'P','2016-04-04 00:00:00',1,'32000874','Masculino','20320087317','LOPEZ..','A','Soltero','Consumidor Final',1,1),
(875,1,'P','2016-04-04 00:00:00',1,'32000875','Masculino','20320087417','ROXANA','A','Soltero','Consumidor Final',1,1),
(876,1,'P','2016-04-04 00:00:00',1,'32000876','Masculino','20320087517','ALBORNOZ','A','Soltero','Consumidor Final',1,1),
(877,1,'P','2016-04-04 00:00:00',1,'32000877','Masculino','20320087617','ALVAREZ','A','Soltero','Consumidor Final',1,1),
(878,1,'P','2016-04-04 00:00:00',1,'32000878','Masculino','20320087717','BOCOLINI TALLER','A','Soltero','Consumidor Final',1,1),
(879,1,'P','2016-04-04 00:00:00',1,'32000879','Masculino','20320087817','DIAZ.','A','Soltero','Consumidor Final',1,1),
(880,1,'P','2016-04-04 00:00:00',1,'32000880','Masculino','20320087917','RANDAZZO','A','Soltero','Consumidor Final',1,1),
(881,1,'P','2016-04-04 00:00:00',1,'32000881','Masculino','20320088017','CUPER PINO','A','Soltero','Consumidor Final',1,1),
(882,1,'P','2016-04-04 00:00:00',1,'32000882','Masculino','20320088117','JUAN','A','Soltero','Consumidor Final',1,1),
(883,1,'P','2016-04-04 00:00:00',1,'32000883','Masculino','20320088217','ALEJANDRA.','A','Soltero','Consumidor Final',1,1),
(884,1,'P','2016-04-04 00:00:00',1,'32000884','Masculino','20320088317','VOCOS VIVIANA','A','Soltero','Consumidor Final',1,1),
(885,1,'P','2016-04-04 00:00:00',1,'32000885','Masculino','20320088417','TOMASA','A','Soltero','Consumidor Final',1,1),
(886,1,'P','2016-04-04 00:00:00',1,'32000886','Masculino','20320088517','PEREYRA SERGIO','A','Soltero','Consumidor Final',1,1),
(887,1,'P','2016-04-04 00:00:00',1,'32000887','Masculino','20320088617','REYNOSO','A','Soltero','Consumidor Final',1,1),
(888,1,'P','2016-04-04 00:00:00',1,'32000888','Masculino','20320088717','TORRES','A','Soltero','Consumidor Final',1,1),
(889,1,'P','2016-04-04 00:00:00',1,'32000889','Masculino','20320088817','PEREZ ALEJANDRA','A','Soltero','Consumidor Final',1,1),
(890,1,'P','2016-04-04 00:00:00',1,'32000890','Masculino','20320088917','KIOSCO MARIA','A','Soltero','Consumidor Final',1,1),
(891,1,'P','2016-04-04 00:00:00',1,'32000891','Masculino','20320089017','MENDOZA.','A','Soltero','Consumidor Final',1,1),
(892,1,'P','2016-04-04 00:00:00',1,'32000892','Masculino','20320089117','HEREDIA','A','Soltero','Consumidor Final',1,1),
(893,1,'P','2016-04-04 00:00:00',1,'32000893','Masculino','20320089217','RAQUEL.','A','Soltero','Consumidor Final',1,1),
(894,1,'P','2016-04-04 00:00:00',1,'32000894','Masculino','20320089317','TOMACELLI.','A','Soltero','Consumidor Final',1,1),
(895,1,'P','2016-04-04 00:00:00',1,'32000895','Masculino','20320089417','FRANCHINO CRISTINA','A','Soltero','Consumidor Final',1,1),
(896,1,'P','2016-04-04 00:00:00',1,'32000896','Masculino','20320089517','NOEMI','A','Soltero','Consumidor Final',1,1),
(897,1,'P','2016-04-04 00:00:00',1,'32000897','Masculino','20320089617','CASTELLI.','A','Soltero','Consumidor Final',1,1),
(898,1,'P','2016-04-04 00:00:00',1,'32000898','Masculino','20320089717','FERNANDA','A','Soltero','Consumidor Final',1,1),
(899,1,'P','2016-04-04 00:00:00',1,'32000899','Masculino','20320089817','CESAR.','A','Soltero','Consumidor Final',1,1),
(900,1,'P','2016-04-04 00:00:00',1,'32000900','Masculino','20320089917','CUELLO.','A','Soltero','Consumidor Final',1,1),
(901,1,'P','2016-04-04 00:00:00',1,'32000901','Masculino','20320090017','SALAVAGIONE','A','Soltero','Consumidor Final',1,1),
(902,1,'P','2016-04-04 00:00:00',1,'32000902','Masculino','20320090117','RODRIGUES ELENA','A','Soltero','Consumidor Final',1,1),
(903,1,'P','2016-04-04 00:00:00',1,'32000903','Masculino','20320090217','CORDOBA','A','Soltero','Consumidor Final',1,1),
(904,1,'P','2016-04-04 00:00:00',1,'32000904','Masculino','20320090317','CALDERON EDITH','A','Soltero','Consumidor Final',1,1),
(905,1,'P','2016-04-04 00:00:00',1,'32000905','Masculino','20320090417','BOCOLINI.','A','Soltero','Consumidor Final',1,1),
(906,1,'P','2016-04-04 00:00:00',1,'32000906','Masculino','20320090517','ROSALES CLAUDIA','A','Soltero','Consumidor Final',1,1),
(907,1,'P','2016-04-04 00:00:00',1,'32000907','Masculino','20320090617','BALANCINO / ESPECHE','A','Soltero','Consumidor Final',1,1),
(908,1,'P','2016-04-04 00:00:00',1,'32000908','Masculino','20320090717','FERREYRA ALEJANDRA','A','Soltero','Consumidor Final',1,1),
(909,1,'P','2016-04-04 00:00:00',1,'32000909','Masculino','20320090817','ESPINDOLA BARRIONUEVO BETY','A','Soltero','Consumidor Final',1,1),
(910,1,'P','2016-04-04 00:00:00',1,'32000910','Masculino','20320090917','ADAMI','A','Soltero','Consumidor Final',1,1),
(911,1,'P','2016-04-04 00:00:00',1,'32000911','Masculino','20320091017','ESCUDERO','A','Soltero','Consumidor Final',1,1),
(912,1,'P','2016-04-04 00:00:00',1,'32000912','Masculino','20320091117','PABLO.','A','Soltero','Consumidor Final',1,1),
(913,1,'P','2016-04-04 00:00:00',1,'32000913','Masculino','20320091217','DAMIAN','A','Soltero','Consumidor Final',1,1),
(914,1,'P','2016-04-04 00:00:00',1,'32000914','Masculino','20320091317','FIOCHI','A','Soltero','Consumidor Final',1,1),
(915,1,'P','2016-04-04 00:00:00',1,'32000915','Masculino','20320091417','FLORES MARIO','A','Soltero','Consumidor Final',1,1),
(916,1,'P','2016-04-04 00:00:00',1,'32000916','Masculino','20320091517','VALLEJOS EDUARDO','A','Soltero','Consumidor Final',1,1),
(917,1,'P','2016-04-04 00:00:00',1,'32000917','Masculino','20320091617','CHIGIO','A','Soltero','Consumidor Final',1,1),
(918,1,'P','2016-04-04 00:00:00',1,'32000918','Masculino','20320091717','GRIBAUDO ELBA','A','Soltero','Consumidor Final',1,1),
(919,1,'P','2016-04-04 00:00:00',1,'32000919','Masculino','20320091817','GOBERNADORE','A','Soltero','Consumidor Final',1,1),
(920,1,'P','2016-04-04 00:00:00',1,'32000920','Masculino','20320091917','VIVAS JOSE MARIA','A','Soltero','Consumidor Final',1,1),
(921,1,'P','2016-04-04 00:00:00',1,'32000921','Masculino','20320092017','CONTRERAS MADRE','A','Soltero','Consumidor Final',1,1),
(922,1,'P','2016-04-04 00:00:00',1,'32000922','Masculino','20320092117','CONTRERAS SOLEDAD','A','Soltero','Consumidor Final',1,1),
(923,1,'P','2016-04-04 00:00:00',1,'32000923','Masculino','20320092217','ROBERT SERGIO','A','Soltero','Consumidor Final',1,1),
(924,1,'P','2016-04-04 00:00:00',1,'32000924','Masculino','20320092317','RAIA AMELIA','A','Soltero','Consumidor Final',1,1),
(925,1,'P','2016-04-04 00:00:00',1,'32000925','Masculino','20320092417','MORENO.','A','Soltero','Consumidor Final',1,1),
(926,1,'P','2016-04-04 00:00:00',1,'32000926','Masculino','20320092517','PINO NILDA','A','Soltero','Consumidor Final',1,1),
(927,1,'P','2016-04-04 00:00:00',1,'32000927','Masculino','20320092617','LEDEZMA.','A','Soltero','Consumidor Final',1,1),
(928,1,'P','2016-04-04 00:00:00',1,'32000928','Masculino','20320092717','RAMIREZ..','A','Soltero','Consumidor Final',1,1),
(929,1,'P','2016-04-04 00:00:00',1,'32000929','Masculino','20320092817','OYOLA CLAUDIA','A','Soltero','Consumidor Final',1,1),
(930,1,'P','2016-04-04 00:00:00',1,'32000930','Masculino','20320092917','TORANZO','A','Soltero','Consumidor Final',1,1),
(931,1,'P','2016-04-04 00:00:00',1,'32000931','Masculino','20320093017','CHERINO','A','Soltero','Consumidor Final',1,1),
(932,1,'P','2016-04-04 00:00:00',1,'32000932','Masculino','20320093117','BOSIO GERARDO','A','Soltero','Consumidor Final',1,1),
(933,1,'P','2016-04-04 00:00:00',1,'32000933','Masculino','20320093217','TORRES','A','Soltero','Consumidor Final',1,1),
(934,1,'P','2016-04-04 00:00:00',1,'32000934','Masculino','20320093317','IRAZOQUE','A','Soltero','Consumidor Final',1,1),
(935,1,'P','2016-04-04 00:00:00',1,'32000935','Masculino','20320093417','BARRERAS','A','Soltero','Consumidor Final',1,1),
(936,1,'P','2016-04-04 00:00:00',1,'32000936','Masculino','20320093517','ZABALA','A','Soltero','Consumidor Final',1,1),
(937,1,'P','2016-04-04 00:00:00',1,'32000937','Masculino','20320093617','MARTINEZ','A','Soltero','Consumidor Final',1,1),
(938,1,'P','2016-04-04 00:00:00',1,'32000938','Masculino','20320093717','VEIRANO AXEL','A','Soltero','Consumidor Final',1,1),
(939,1,'P','2016-04-04 00:00:00',1,'32000939','Masculino','20320093817','SERANGENI GUANDA','A','Soltero','Consumidor Final',1,1),
(940,1,'P','2016-04-04 00:00:00',1,'32000940','Masculino','20320093917','RUIZ ANA','A','Soltero','Consumidor Final',1,1),
(941,1,'P','2016-04-04 00:00:00',1,'32000941','Masculino','20320094017','NELY','A','Soltero','Consumidor Final',1,1),
(942,1,'P','2016-04-04 00:00:00',1,'32000942','Masculino','20320094117','VACA CLAUDIA','A','Soltero','Consumidor Final',1,1),
(943,1,'P','2016-04-04 00:00:00',1,'32000943','Masculino','20320094217','VANEZA','A','Soltero','Consumidor Final',1,1),
(944,1,'P','2016-04-04 00:00:00',1,'32000944','Masculino','20320094317','TONON.','A','Soltero','Consumidor Final',1,1),
(945,1,'P','2016-04-04 00:00:00',1,'32000945','Masculino','20320094417','SORIA','A','Soltero','Consumidor Final',1,1),
(946,1,'P','2016-04-04 00:00:00',1,'32000946','Masculino','20320094517','REYNOSO.','A','Soltero','Consumidor Final',1,1),
(947,1,'P','2016-04-04 00:00:00',1,'32000947','Masculino','20320094617','ENRIQUE JOSE','A','Soltero','Consumidor Final',1,1),
(948,1,'P','2016-04-04 00:00:00',1,'32000948','Masculino','20320094717','MILAGROS','A','Soltero','Consumidor Final',1,1),
(949,1,'P','2016-04-04 00:00:00',1,'32000949','Masculino','20320094817','SENMA','A','Soltero','Consumidor Final',1,1),
(950,1,'P','2016-04-04 00:00:00',1,'32000950','Masculino','20320094917','TAVANO PEDRO','A','Soltero','Consumidor Final',1,1),
(951,1,'P','2016-04-04 00:00:00',1,'32000951','Masculino','20320095017','CADENA','A','Soltero','Consumidor Final',1,1),
(952,1,'P','2016-04-04 00:00:00',1,'32000952','Masculino','20320095117','CAPDEVILA JULIO','A','Soltero','Consumidor Final',1,1),
(953,1,'P','2016-04-04 00:00:00',1,'32000953','Masculino','20320095217','ANDRADE SARA','A','Soltero','Consumidor Final',1,1),
(954,1,'P','2016-04-04 00:00:00',1,'32000954','Masculino','20320095317','GONZALES','A','Soltero','Consumidor Final',1,1),
(955,1,'P','2016-04-04 00:00:00',1,'32000955','Masculino','20320095417','REYNA LEONARDO','A','Soltero','Consumidor Final',1,1),
(956,1,'P','2016-04-04 00:00:00',1,'32000956','Masculino','20320095517','JOHAN JOSE LUIS','A','Soltero','Consumidor Final',1,1),
(957,1,'P','2016-04-04 00:00:00',1,'32000957','Masculino','20320095617','TONON..','A','Soltero','Consumidor Final',1,1),
(958,1,'P','2016-04-04 00:00:00',1,'32000958','Masculino','20320095717','RAMONA.','A','Soltero','Consumidor Final',1,1),
(959,1,'P','2016-04-04 00:00:00',1,'32000959','Masculino','20320095817','MARTINEZ','A','Soltero','Consumidor Final',1,1),
(960,1,'P','2016-04-04 00:00:00',1,'32000960','Masculino','20320095917','MARTINI GUILLERMO','A','Soltero','Consumidor Final',1,1),
(961,1,'P','2016-04-04 00:00:00',1,'32000961','Masculino','20320096017','MARTINI HUGO','A','Soltero','Consumidor Final',1,1),
(962,1,'P','2016-04-04 00:00:00',1,'32000962','Masculino','20320096117','TORRES','A','Soltero','Consumidor Final',1,1),
(963,1,'P','2016-04-04 00:00:00',1,'32000963','Masculino','20320096217','TUTURRO','A','Soltero','Consumidor Final',1,1),
(964,1,'P','2016-04-04 00:00:00',1,'32000964','Masculino','20320096317','CASTRO.. (PASAR 14 - 14.30)','A','Soltero','Consumidor Final',1,1),
(965,1,'P','2016-04-04 00:00:00',1,'32000965','Masculino','20320096417','MOYANO','A','Soltero','Consumidor Final',1,1),
(966,1,'P','2016-04-04 00:00:00',1,'32000966','Masculino','20320096517','GARECA BEATRIZ','A','Soltero','Consumidor Final',1,1),
(967,1,'P','2016-04-04 00:00:00',1,'32000967','Masculino','20320096617','JUARES.','A','Soltero','Consumidor Final',1,1),
(968,1,'P','2016-04-04 00:00:00',1,'32000968','Masculino','20320096717','MESOPEVA TERESA','A','Soltero','Consumidor Final',1,1),
(969,1,'P','2016-04-04 00:00:00',1,'32000969','Masculino','20320096817','ROAZO','A','Soltero','Consumidor Final',1,1),
(970,1,'P','2016-04-04 00:00:00',1,'32000970','Masculino','20320096917','GEREVINI','A','Soltero','Consumidor Final',1,1),
(971,1,'P','2016-04-04 00:00:00',1,'32000971','Masculino','20320097017','MACHADO.','A','Soltero','Consumidor Final',1,1),
(972,1,'P','2016-04-04 00:00:00',1,'32000972','Masculino','20320097117','GIANRE','A','Soltero','Consumidor Final',1,1),
(973,1,'P','2016-04-04 00:00:00',1,'32000973','Masculino','20320097217','PERALTA.','A','Soltero','Consumidor Final',1,1),
(974,1,'P','2016-04-04 00:00:00',1,'32000974','Masculino','20320097317','GOMEZ (HIJA ANGELA)','A','Soltero','Consumidor Final',1,1),
(975,1,'P','2016-04-04 00:00:00',1,'32000975','Masculino','20320097417','PEREZ GUILLERMO','A','Soltero','Consumidor Final',1,1),
(976,1,'P','2016-04-04 00:00:00',1,'32000976','Masculino','20320097517','GUEVARA.','A','Soltero','Consumidor Final',1,1),
(977,1,'P','2016-04-04 00:00:00',1,'32000977','Masculino','20320097617','PEREZ ANGELA','A','Soltero','Consumidor Final',1,1),
(978,1,'P','2016-04-04 00:00:00',1,'32000978','Masculino','20320097717','GARCIA LUIS','A','Soltero','Consumidor Final',1,1),
(979,1,'P','2016-04-04 00:00:00',1,'32000979','Masculino','20320097817','SCHUA INES','A','Soltero','Consumidor Final',1,1),
(980,1,'P','2016-04-04 00:00:00',1,'32000980','Masculino','20320097917','ARRIOLA','A','Soltero','Consumidor Final',1,1),
(981,1,'P','2016-04-04 00:00:00',1,'32000981','Masculino','20320098017','CISNERO','A','Soltero','Consumidor Final',1,1),
(982,1,'P','2016-04-04 00:00:00',1,'32000982','Masculino','20320098117','ARIAS PAOLA','A','Soltero','Consumidor Final',1,1),
(983,1,'P','2016-04-04 00:00:00',1,'32000983','Masculino','20320098217','VILLAGRAS ANGELICA','A','Soltero','Consumidor Final',1,1),
(984,1,'P','2016-04-04 00:00:00',1,'32000984','Masculino','20320098317','LOYOLA','A','Soltero','Consumidor Final',1,1),
(985,1,'P','2016-04-04 00:00:00',1,'32000985','Masculino','20320098417','PAIVA (ALQ. LOLA)','A','Soltero','Consumidor Final',1,1),
(986,1,'P','2016-04-04 00:00:00',1,'32000986','Masculino','20320098517','LOLA','A','Soltero','Consumidor Final',1,1),
(987,1,'P','2016-04-04 00:00:00',1,'32000987','Masculino','20320098617','OYOLA..','A','Soltero','Consumidor Final',1,1),
(988,1,'P','2016-04-04 00:00:00',1,'32000988','Masculino','20320098717','COPETI','A','Soltero','Consumidor Final',1,1),
(989,1,'P','2016-04-04 00:00:00',1,'32000989','Masculino','20320098817','ANA','A','Soltero','Consumidor Final',1,1),
(990,1,'P','2016-04-04 00:00:00',1,'32000990','Masculino','20320098917','MARY.','A','Soltero','Consumidor Final',1,1),
(991,1,'P','2016-04-04 00:00:00',1,'32000991','Masculino','20320099017','ATIA','A','Soltero','Consumidor Final',1,1),
(992,1,'P','2016-04-04 00:00:00',1,'32000992','Masculino','20320099117','GONZALES ELSA','A','Soltero','Consumidor Final',1,1),
(993,1,'P','2016-04-04 00:00:00',1,'32000993','Masculino','20320099217','GASONI','A','Soltero','Consumidor Final',1,1),
(994,1,'P','2016-04-04 00:00:00',1,'32000994','Masculino','20320099317','LOPEZ','A','Soltero','Consumidor Final',1,1),
(995,1,'P','2016-04-04 00:00:00',1,'32000995','Masculino','20320099417','BETY.','A','Soltero','Consumidor Final',1,1),
(996,1,'P','2016-04-04 00:00:00',1,'32000996','Masculino','20320099517','REYNA..','A','Soltero','Consumidor Final',1,1),
(997,1,'P','2016-04-04 00:00:00',1,'32000997','Masculino','20320099617','CONTRERAS..','A','Soltero','Consumidor Final',1,1),
(998,1,'P','2016-04-04 00:00:00',1,'32000998','Masculino','20320099717','OLMOS.','A','Soltero','Consumidor Final',1,1),
(999,1,'P','2016-04-04 00:00:00',1,'32000999','Masculino','20320099817','LEIGUARDA','A','Soltero','Consumidor Final',1,1),
(1000,1,'P','2016-04-04 00:00:00',1,'32001000','Masculino','20320099917','COCIANI COCA','A','Soltero','Consumidor Final',1,1),
(1001,1,'P','2016-04-04 00:00:00',1,'32001001','Masculino','20320100017','ALVAREZ RAMON','A','Soltero','Consumidor Final',1,1),
(1002,1,'P','2016-04-04 00:00:00',1,'32001002','Masculino','20320100117','TAPIA GISELA','A','Soltero','Consumidor Final',1,1),
(1003,1,'P','2016-04-04 00:00:00',1,'32001003','Masculino','20320100217','LIENDO MARTA','A','Soltero','Consumidor Final',1,1),
(1004,1,'P','2016-04-04 00:00:00',1,'32001004','Masculino','20320100317','CACERES','A','Soltero','Consumidor Final',1,1),
(1005,1,'P','2016-04-04 00:00:00',1,'32001005','Masculino','20320100417','IRMA CARINA','A','Soltero','Consumidor Final',1,1),
(1006,1,'P','2016-04-04 00:00:00',1,'32001006','Masculino','20320100517','BERGARA ALEJANDRA','A','Soltero','Consumidor Final',1,1),
(1007,1,'P','2016-04-04 00:00:00',1,'32001007','Masculino','20320100617','PEREYRA (MADRE)','A','Soltero','Consumidor Final',1,1),
(1008,1,'P','2016-04-04 00:00:00',1,'32001008','Masculino','20320100717','PEÑALOZA','A','Soltero','Consumidor Final',1,1),
(1009,1,'P','2016-04-04 00:00:00',1,'32001009','Masculino','20320100817','DIAZ..','A','Soltero','Consumidor Final',1,1),
(1010,1,'P','2016-04-04 00:00:00',1,'32001010','Masculino','20320100917','ROGELIO','A','Soltero','Consumidor Final',1,1),
(1011,1,'P','2016-04-04 00:00:00',1,'32001011','Masculino','20320101017','ESMERILIO','A','Soltero','Consumidor Final',1,1),
(1012,1,'P','2016-04-04 00:00:00',1,'32001012','Masculino','20320101117','GUZMAN LAURA','A','Soltero','Consumidor Final',1,1),
(1013,1,'P','2016-04-04 00:00:00',1,'32001013','Masculino','20320101217','LUNA GERARDO','A','Soltero','Consumidor Final',1,1),
(1014,1,'P','2016-04-04 00:00:00',1,'32001014','Masculino','20320101317','GUDIÑO','A','Soltero','Consumidor Final',1,1),
(1015,1,'P','2016-04-04 00:00:00',1,'32001015','Masculino','20320101417','ARRASCAETA.','A','Soltero','Consumidor Final',1,1),
(1016,1,'P','2016-04-04 00:00:00',1,'32001016','Masculino','20320101517','SUARES..','A','Soltero','Consumidor Final',1,1),
(1017,1,'P','2016-04-04 00:00:00',1,'32001017','Masculino','20320101617','MALDONADO JUAN','A','Soltero','Consumidor Final',1,1),
(1018,1,'P','2016-04-04 00:00:00',1,'32001018','Masculino','20320101717','VILLARUEL ELISA','A','Soltero','Consumidor Final',1,1),
(1019,1,'P','2016-04-04 00:00:00',1,'32001019','Masculino','20320101817','ANDRADE YOLANDA','A','Soltero','Consumidor Final',1,1),
(1020,1,'P','2016-04-04 00:00:00',1,'32001020','Masculino','20320101917','NIEVAS RAMON','A','Soltero','Consumidor Final',1,1),
(1021,1,'P','2016-04-04 00:00:00',1,'32001021','Masculino','20320102017','URAN','A','Soltero','Consumidor Final',1,1),
(1022,1,'P','2016-04-04 00:00:00',1,'32001022','Masculino','20320102117','PAZ.','A','Soltero','Consumidor Final',1,1),
(1023,1,'P','2016-04-04 00:00:00',1,'32001023','Masculino','20320102217','GARCIA','A','Soltero','Consumidor Final',1,1),
(1024,1,'P','2016-04-04 00:00:00',1,'32001024','Masculino','20320102317','GODOY','A','Soltero','Consumidor Final',1,1),
(1025,1,'P','2016-04-04 00:00:00',1,'32001025','Masculino','20320102417','ASTUDILLO','A','Soltero','Consumidor Final',1,1),
(1026,1,'P','2016-04-04 00:00:00',1,'32001026','Masculino','20320102517','NILDA.','A','Soltero','Consumidor Final',1,1),
(1027,1,'P','2016-04-04 00:00:00',1,'32001027','Masculino','20320102617','GONZALES','A','Soltero','Consumidor Final',1,1),
(1028,1,'P','2016-04-04 00:00:00',1,'32001028','Masculino','20320102717','SANCHEZ','A','Soltero','Consumidor Final',1,1),
(1029,1,'P','2016-04-04 00:00:00',1,'32001029','Masculino','20320102817','MACHADO MARTA','A','Soltero','Consumidor Final',1,1),
(1030,1,'P','2016-04-04 00:00:00',1,'32001030','Masculino','20320102917','CONTRERAS CRISTINA','A','Soltero','Consumidor Final',1,1),
(1031,1,'P','2016-04-04 00:00:00',1,'32001031','Masculino','20320103017','OLIVERO ELIDE','A','Soltero','Consumidor Final',1,1),
(1032,1,'P','2016-04-04 00:00:00',1,'32001032','Masculino','20320103117','NELY.','A','Soltero','Consumidor Final',1,1),
(1033,1,'P','2016-04-04 00:00:00',1,'32001033','Masculino','20320103217','AGUERO (SRA)','A','Soltero','Consumidor Final',1,1),
(1034,1,'P','2016-04-04 00:00:00',1,'32001034','Masculino','20320103317','AGUERO ANTONIO','A','Soltero','Consumidor Final',1,1),
(1035,1,'P','2016-04-04 00:00:00',1,'32001035','Masculino','20320103417','TABELLA FERNANDO','A','Soltero','Consumidor Final',1,1),
(1036,1,'P','2016-04-04 00:00:00',1,'32001036','Masculino','20320103517','QUINTANA FREDY / GRACIELA','A','Soltero','Consumidor Final',1,1),
(1037,1,'P','2016-04-04 00:00:00',1,'32001037','Masculino','20320103617','CARRA','A','Soltero','Consumidor Final',1,1),
(1038,1,'P','2016-04-04 00:00:00',1,'32001038','Masculino','20320103717','NARRETE GRACIELA','A','Soltero','Consumidor Final',1,1),
(1039,1,'P','2016-04-04 00:00:00',1,'32001039','Masculino','20320103817','VIVAS','A','Soltero','Consumidor Final',1,1),
(1040,1,'P','2016-04-04 00:00:00',1,'32001040','Masculino','20320103917','ORONA KOKAL','A','Soltero','Consumidor Final',1,1),
(1041,1,'P','2016-04-04 00:00:00',1,'32001041','Masculino','20320104017','DON OYOLA','A','Soltero','Consumidor Final',1,1),
(1042,1,'P','2016-04-04 00:00:00',1,'32001042','Masculino','20320104117','PAZ..','A','Soltero','Consumidor Final',1,1),
(1043,1,'P','2016-04-04 00:00:00',1,'32001043','Masculino','20320104217','GUTIERRES','A','Soltero','Consumidor Final',1,1),
(1044,1,'P','2016-04-04 00:00:00',1,'32001044','Masculino','20320104317','MONTENEGRO.','A','Soltero','Consumidor Final',1,1),
(1045,1,'P','2016-04-04 00:00:00',1,'32001045','Masculino','20320104417','LAMARRE','A','Soltero','Consumidor Final',1,1),
(1046,1,'P','2016-04-04 00:00:00',1,'32001046','Masculino','20320104517','NOCEDA','A','Soltero','Consumidor Final',1,1),
(1047,1,'P','2016-04-04 00:00:00',1,'32001047','Masculino','20320104617','ALMADA.','A','Soltero','Consumidor Final',1,1),
(1048,1,'P','2016-04-04 00:00:00',1,'32001048','Masculino','20320104717','PACHECO.','A','Soltero','Consumidor Final',1,1),
(1049,1,'P','2016-04-04 00:00:00',1,'32001049','Masculino','20320104817','ANDINE','A','Soltero','Consumidor Final',1,1),
(1050,1,'P','2016-04-04 00:00:00',1,'32001050','Masculino','20320104917','CATALINA','A','Soltero','Consumidor Final',1,1),
(1051,1,'P','2016-04-04 00:00:00',1,'32001051','Masculino','20320105017','ROJAS.','A','Soltero','Consumidor Final',1,1),
(1052,1,'P','2016-04-04 00:00:00',1,'32001052','Masculino','20320105117','SALGUERO','A','Soltero','Consumidor Final',1,1),
(1053,1,'P','2016-04-04 00:00:00',1,'32001053','Masculino','20320105217','PINEDA','A','Soltero','Consumidor Final',1,1),
(1054,1,'P','2016-04-04 00:00:00',1,'32001054','Masculino','20320105317','HILDA','A','Soltero','Consumidor Final',1,1),
(1055,1,'P','2016-04-04 00:00:00',1,'32001055','Masculino','20320105417','PEREZ GUILLERMO.','A','Soltero','Consumidor Final',1,1),
(1056,1,'P','2016-04-04 00:00:00',1,'32001056','Masculino','20320105517','PERALTA (RADIO)','A','Soltero','Consumidor Final',1,1),
(1057,1,'P','2016-04-04 00:00:00',1,'32001057','Masculino','20320105617','HEREDIA','A','Soltero','Consumidor Final',1,1),
(1058,1,'P','2016-04-04 00:00:00',1,'32001058','Masculino','20320105717','TRONCOSO','A','Soltero','Consumidor Final',1,1),
(1059,1,'P','2016-04-04 00:00:00',1,'32001059','Masculino','20320105817','TORRES CHANO','A','Soltero','Consumidor Final',1,1),
(1060,1,'P','2016-04-04 00:00:00',1,'32001060','Masculino','20320105917','HEREDIA','A','Soltero','Consumidor Final',1,1),
(1061,1,'P','2016-04-04 00:00:00',1,'32001061','Masculino','20320106017','MAMMANA REPUESTOS','A','Soltero','Consumidor Final',1,1),
(1062,1,'P','2016-04-04 00:00:00',1,'32001062','Masculino','20320106117','IZQUIERDO','A','Soltero','Consumidor Final',1,1),
(1063,1,'P','2016-04-04 00:00:00',1,'32001063','Masculino','20320106217','CARREO','A','Soltero','Consumidor Final',1,1),
(1064,1,'P','2016-04-04 00:00:00',1,'32001064','Masculino','20320106317','WALTER','A','Soltero','Consumidor Final',1,1),
(1065,1,'P','2016-04-04 00:00:00',1,'32001065','Masculino','20320106417','TITO ELIZALDI','A','Soltero','Consumidor Final',1,1),
(1066,1,'P','2016-04-04 00:00:00',1,'32001066','Masculino','20320106517','BARBOZA','A','Soltero','Consumidor Final',1,1),
(1067,1,'P','2016-04-04 00:00:00',1,'32001067','Masculino','20320106617','SOLEDAD','A','Soltero','Consumidor Final',1,1),
(1068,1,'P','2016-04-04 00:00:00',1,'32001068','Masculino','20320106717','MERCEDEZ.','A','Soltero','Consumidor Final',1,1),
(1069,1,'P','2016-04-04 00:00:00',1,'32001069','Masculino','20320106817','COYA','A','Soltero','Consumidor Final',1,1),
(1070,1,'P','2016-04-04 00:00:00',1,'32001070','Masculino','20320106917','MECANICO','A','Soltero','Consumidor Final',1,1),
(1071,1,'P','2016-04-04 00:00:00',1,'32001071','Masculino','20320107017','GABRIEL CARNICERIA','A','Soltero','Consumidor Final',1,1),
(1072,1,'P','2016-04-04 00:00:00',1,'32001072','Masculino','20320107117','LUCIA','A','Soltero','Consumidor Final',1,1),
(1073,1,'P','2016-04-04 00:00:00',1,'32001073','Masculino','20320107217','SANCHES','A','Soltero','Consumidor Final',1,1),
(1074,1,'P','2016-04-04 00:00:00',1,'32001074','Masculino','20320107317','SARAVIA','A','Soltero','Consumidor Final',1,1),
(1075,1,'P','2016-04-04 00:00:00',1,'32001075','Masculino','20320107417','SARAVIA.','A','Soltero','Consumidor Final',1,1),
(1076,1,'P','2016-04-04 00:00:00',1,'32001076','Masculino','20320107517','JULIA.','A','Soltero','Consumidor Final',1,1),
(1077,1,'P','2016-04-04 00:00:00',1,'32001077','Masculino','20320107617','ORDOEZ','A','Soltero','Consumidor Final',1,1),
(1078,1,'P','2016-04-04 00:00:00',1,'32001078','Masculino','20320107717','ROJAS..','A','Soltero','Consumidor Final',1,1),
(1079,1,'P','2016-04-04 00:00:00',1,'32001079','Masculino','20320107817','MOLINA','A','Soltero','Consumidor Final',1,1),
(1080,1,'P','2016-04-04 00:00:00',1,'32001080','Masculino','20320107917','SOLER','A','Soltero','Consumidor Final',1,1),
(1081,1,'P','2016-04-04 00:00:00',1,'32001081','Masculino','20320108017','SACO','A','Soltero','Consumidor Final',1,1),
(1082,1,'P','2016-04-04 00:00:00',1,'32001082','Masculino','20320108117','JULIO','A','Soltero','Consumidor Final',1,1),
(1083,1,'P','2016-04-04 00:00:00',1,'32001083','Masculino','20320108217','GONZALEZZ','A','Soltero','Consumidor Final',1,1),
(1084,1,'P','2016-04-04 00:00:00',1,'32001084','Masculino','20320108317','LORENA VILLAREAL','A','Soltero','Consumidor Final',1,1),
(1085,1,'P','2016-04-04 00:00:00',1,'32001085','Masculino','20320108417','FASULLO LUCIANO','A','Soltero','Consumidor Final',1,1),
(1086,1,'P','2016-04-04 00:00:00',1,'32001086','Masculino','20320108517','CAMPETELA','A','Soltero','Consumidor Final',1,1),
(1087,1,'P','2016-04-04 00:00:00',1,'32001087','Masculino','20320108617','LAZARTE','A','Soltero','Consumidor Final',1,1),
(1088,1,'P','2016-04-04 00:00:00',1,'32001088','Masculino','20320108717','MOYANO','A','Soltero','Consumidor Final',1,1),
(1089,1,'P','2016-04-04 00:00:00',1,'32001089','Masculino','20320108817','PISISTELO','A','Soltero','Consumidor Final',1,1),
(1090,1,'P','2016-04-04 00:00:00',1,'32001090','Masculino','20320108917','MARIA..','A','Soltero','Consumidor Final',1,1),
(1091,1,'P','2016-04-04 00:00:00',1,'32001091','Masculino','20320109017','HIJA ESMERILIO','A','Soltero','Consumidor Final',1,1),
(1092,1,'P','2016-04-04 00:00:00',1,'32001092','Masculino','20320109117','PONSE','A','Soltero','Consumidor Final',1,1),
(1093,1,'P','2016-04-04 00:00:00',1,'32001093','Masculino','20320109217','ACOSTA','A','Soltero','Consumidor Final',1,1),
(1094,1,'P','2016-04-04 00:00:00',1,'32001094','Masculino','20320109317','ALTAMIRANO.','A','Soltero','Consumidor Final',1,1),
(1095,1,'P','2016-04-04 00:00:00',1,'32001095','Masculino','20320109417','CASTRO..','A','Soltero','Consumidor Final',1,1),
(1096,1,'P','2016-04-04 00:00:00',1,'32001096','Masculino','20320109517','HNA JAVIER','A','Soltero','Consumidor Final',1,1),
(1097,1,'P','2016-04-04 00:00:00',1,'32001097','Masculino','20320109617','TORANZO.','A','Soltero','Consumidor Final',1,1),
(1098,1,'P','2016-04-04 00:00:00',1,'32001098','Masculino','20320109717','OLIVARES','A','Soltero','Consumidor Final',1,1),
(1099,1,'P','2016-04-04 00:00:00',1,'32001099','Masculino','20320109817','GOMEZ','A','Soltero','Consumidor Final',1,1),
(1100,1,'P','2016-04-04 00:00:00',1,'32001100','Masculino','20320109917','CRUZ.','A','Soltero','Consumidor Final',1,1),
(1101,1,'P','2016-04-04 00:00:00',1,'32001101','Masculino','20320110017','PEREZ','A','Soltero','Consumidor Final',1,1),
(1102,1,'P','2016-04-04 00:00:00',1,'32001102','Masculino','20320110117','xxxxxxxx','A','Soltero','Consumidor Final',1,1),
(1103,1,'P','2016-04-04 00:00:00',1,'32001103','Masculino','20320110217','RICARDO','A','Soltero','Consumidor Final',1,1),
(1104,1,'P','2016-04-04 00:00:00',1,'32001104','Masculino','20320110317','CANELO','A','Soltero','Consumidor Final',1,1),
(1105,1,'P','2016-04-04 00:00:00',1,'32001105','Masculino','20320110417',' NATALIA','A','Soltero','Consumidor Final',1,1),
(1106,1,'P','2016-04-04 00:00:00',1,'32001106','Masculino','20320110517','MALDONADO','A','Soltero','Consumidor Final',1,1),
(1107,1,'P','2016-04-04 00:00:00',1,'32001107','Masculino','20320110617','POZO','A','Soltero','Consumidor Final',1,1),
(1108,1,'P','2016-04-04 00:00:00',1,'32001108','Masculino','20320110717','ROMERO','A','Soltero','Consumidor Final',1,1),
(1109,1,'P','2016-04-04 00:00:00',1,'32001109','Masculino','20320110817','MIGUEL.','A','Soltero','Consumidor Final',1,1),
(1110,1,'P','2016-04-04 00:00:00',1,'32001110','Masculino','20320110917','FELIPE','A','Soltero','Consumidor Final',1,1),
(1111,1,'P','2016-04-04 00:00:00',1,'32001111','Masculino','20320111017','CENTINI ENRIQUE','A','Soltero','Consumidor Final',1,1),
(1112,1,'P','2016-04-04 00:00:00',1,'32001112','Masculino','20320111117','RAMOS RICARDO','A','Soltero','Consumidor Final',1,1),
(1113,1,'P','2016-04-04 00:00:00',1,'32001113','Masculino','20320111217','FELIPA','A','Soltero','Consumidor Final',1,1),
(1114,1,'P','2016-04-04 00:00:00',1,'32001114','Masculino','20320111317','PEREZ','A','Soltero','Consumidor Final',1,1),
(1115,1,'P','2016-04-04 00:00:00',1,'32001115','Masculino','20320111417','OFELIA','A','Soltero','Consumidor Final',1,1),
(1116,1,'P','2016-04-04 00:00:00',1,'32001116','Masculino','20320111517','PEZ VICTOR','A','Soltero','Consumidor Final',1,1),
(1117,1,'P','2016-04-04 00:00:00',1,'32001117','Masculino','20320111617','OLMOS (YERNO VILLALON)','A','Soltero','Consumidor Final',1,1),
(1118,1,'P','2016-04-04 00:00:00',1,'32001118','Masculino','20320111717','MORENO..','A','Soltero','Consumidor Final',1,1),
(1119,1,'P','2016-04-04 00:00:00',1,'32001119','Masculino','20320111817','GIANRE (LIBRERIA)','A','Soltero','Consumidor Final',1,1),
(1120,1,'P','2016-04-04 00:00:00',1,'32001120','Masculino','20320111917','dario/BAZAN','A','Soltero','Consumidor Final',1,1),
(1121,1,'P','2016-04-04 00:00:00',1,'32001121','Masculino','20320112017','CASAS.','A','Soltero','Consumidor Final',1,1),
(1122,1,'P','2016-04-04 00:00:00',1,'32001122','Masculino','20320112117','ZAPETI','A','Soltero','Consumidor Final',1,1),
(1123,1,'P','2016-04-04 00:00:00',1,'32001123','Masculino','20320112217','TROKA','A','Soltero','Consumidor Final',1,1),
(1124,1,'P','2016-04-04 00:00:00',1,'32001124','Masculino','20320112317','RODRIGUES.','A','Soltero','Consumidor Final',1,1),
(1125,1,'P','2016-04-04 00:00:00',1,'32001125','Masculino','20320112417','KARINA..','A','Soltero','Consumidor Final',1,1),
(1126,1,'P','2016-04-04 00:00:00',1,'32001126','Masculino','20320112517','VIVIANA.','A','Soltero','Consumidor Final',1,1),
(1127,1,'P','2016-04-04 00:00:00',1,'32001127','Masculino','20320112617','SANCHEZ','A','Soltero','Consumidor Final',1,1),
(1128,1,'P','2016-04-04 00:00:00',1,'32001128','Masculino','20320112717','ARROYO','A','Soltero','Consumidor Final',1,1),
(1129,1,'P','2016-04-04 00:00:00',1,'32001129','Masculino','20320112817','AMAYA','A','Soltero','Consumidor Final',1,1),
(1130,1,'P','2016-04-04 00:00:00',1,'32001130','Masculino','20320112917','FERNANDES.','A','Soltero','Consumidor Final',1,1),
(1131,1,'P','2016-04-04 00:00:00',1,'32001131','Masculino','20320113017','LUNA VICTOR','A','Soltero','Consumidor Final',1,1),
(1132,1,'P','2016-04-04 00:00:00',1,'32001132','Masculino','20320113117','MARIA JOSE.','A','Soltero','Consumidor Final',1,1),
(1133,1,'P','2016-04-04 00:00:00',1,'32001133','Masculino','20320113217','CENMA COLEGIO','A','Soltero','Consumidor Final',1,1),
(1134,1,'P','2016-04-04 00:00:00',1,'32001134','Masculino','20320113317','GOROSITO.','A','Soltero','Consumidor Final',1,1),
(1135,1,'P','2016-04-04 00:00:00',1,'32001135','Masculino','20320113417','URQUIZA','A','Soltero','Consumidor Final',1,1),
(1136,1,'P','2016-04-04 00:00:00',1,'32001136','Masculino','20320113517','CASTRO (PADRE)','A','Soltero','Consumidor Final',1,1),
(1137,1,'P','2016-04-04 00:00:00',1,'32001137','Masculino','20320113617','DANIELA','A','Soltero','Consumidor Final',1,1),
(1138,1,'P','2016-04-04 00:00:00',1,'32001138','Masculino','20320113717','RODRIGO- ELIANA','A','Soltero','Consumidor Final',1,1),
(1139,1,'P','2016-04-04 00:00:00',1,'32001139','Masculino','20320113817','FERREÑO / GIANRE','A','Soltero','Consumidor Final',1,1),
(1140,1,'P','2016-04-04 00:00:00',1,'32001140','Masculino','20320113917','ARCE','A','Soltero','Consumidor Final',1,1),
(1141,1,'P','2016-04-04 00:00:00',1,'32001141','Masculino','20320114017','VARGAS','A','Soltero','Consumidor Final',1,1),
(1142,1,'P','2016-04-04 00:00:00',1,'32001142','Masculino','20320114117','FARMACUEUTICO','A','Soltero','Consumidor Final',1,1),
(1143,1,'P','2016-04-04 00:00:00',1,'32001143','Masculino','20320114217','TORANZO M. GRACIELA','A','Soltero','Consumidor Final',1,1),
(1144,1,'P','2016-04-04 00:00:00',1,'32001144','Masculino','20320114317','NOELIA','A','Soltero','Consumidor Final',1,1),
(1145,1,'P','2016-04-04 00:00:00',1,'32001145','Masculino','20320114417','IBAÑEZ','A','Soltero','Consumidor Final',1,1),
(1146,1,'P','2016-04-04 00:00:00',1,'32001146','Masculino','20320114517','SAVEDRA','A','Soltero','Consumidor Final',1,1),
(1147,1,'P','2016-04-04 00:00:00',1,'32001147','Masculino','20320114617','MARTA.','A','Soltero','Consumidor Final',1,1),
(1148,1,'P','2016-04-04 00:00:00',1,'32001148','Masculino','20320114717',' SGTO. CABRAL','A','Soltero','Consumidor Final',1,1),
(1149,1,'P','2016-04-04 00:00:00',1,'32001149','Masculino','20320114817','MIGUEL..','A','Soltero','Consumidor Final',1,1),
(1150,1,'P','2016-04-04 00:00:00',1,'32001150','Masculino','20320114917','CAROLINA','A','Soltero','Consumidor Final',1,1),
(1151,1,'P','2016-04-04 00:00:00',1,'32001151','Masculino','20320115017','CELIA','A','Soltero','Consumidor Final',1,1),
(1152,1,'P','2016-04-04 00:00:00',1,'32001152','Masculino','20320115117','FERNANDA.','A','Soltero','Consumidor Final',1,1),
(1153,1,'P','2016-04-04 00:00:00',1,'32001153','Masculino','20320115217','ASCUY','A','Soltero','Consumidor Final',1,1),
(1154,1,'P','2016-04-04 00:00:00',1,'32001154','Masculino','20320115317','ROSALES (J)','A','Soltero','Consumidor Final',1,1),
(1155,1,'P','2016-04-04 00:00:00',1,'32001155','Masculino','20320115417','ROMERO-','A','Soltero','Consumidor Final',1,1),
(1156,1,'P','2016-04-04 00:00:00',1,'32001156','Masculino','20320115517','OVIEDO MARIBEL','A','Soltero','Consumidor Final',1,1),
(1157,1,'P','2016-04-04 00:00:00',1,'32001157','Masculino','20320115617','MEDINA CLAUDIO','A','Soltero','Consumidor Final',1,1),
(1158,1,'P','2016-04-04 00:00:00',1,'32001158','Masculino','20320115717','ROLDAN','A','Soltero','Consumidor Final',1,1),
(1159,1,'P','2016-04-04 00:00:00',1,'32001159','Masculino','20320115817','SACABA','A','Soltero','Consumidor Final',1,1),
(1160,1,'P','2016-04-04 00:00:00',1,'32001160','Masculino','20320115917','PINO..','A','Soltero','Consumidor Final',1,1),
(1161,1,'P','2016-04-04 00:00:00',1,'32001161','Masculino','20320116017','CARMEN','A','Soltero','Consumidor Final',1,1),
(1162,1,'P','2016-04-04 00:00:00',1,'32001162','Masculino','20320116117','RODOLFO','A','Soltero','Consumidor Final',1,1),
(1163,1,'P','2016-04-04 00:00:00',1,'32001163','Masculino','20320116217','CASTELLANO','A','Soltero','Consumidor Final',1,1),
(1164,1,'P','2016-04-04 00:00:00',1,'32001164','Masculino','20320116317','CARRILLO MIRIAM','A','Soltero','Consumidor Final',1,1),
(1165,1,'P','2016-04-04 00:00:00',1,'32001165','Masculino','20320116417','SEGURA','A','Soltero','Consumidor Final',1,1),
(1166,1,'P','2016-04-04 00:00:00',1,'32001166','Masculino','20320116517','NIEVAS.','A','Soltero','Consumidor Final',1,1),
(1167,1,'P','2016-04-04 00:00:00',1,'32001167','Masculino','20320116617','HEREDIA','A','Soltero','Consumidor Final',1,1),
(1168,1,'P','2016-04-04 00:00:00',1,'32001168','Masculino','20320116717','SILVIA.','A','Soltero','Consumidor Final',1,1),
(1169,1,'P','2016-04-04 00:00:00',1,'32001169','Masculino','20320116817','CORDOBA','A','Soltero','Consumidor Final',1,1),
(1170,1,'P','2016-04-04 00:00:00',1,'32001170','Masculino','20320116917','FELICIANO','A','Soltero','Consumidor Final',1,1),
(1171,1,'P','2016-04-04 00:00:00',1,'32001171','Masculino','20320117017','BETY (MADRE JAVIER)','A','Soltero','Consumidor Final',1,1),
(1172,1,'P','2016-04-04 00:00:00',1,'32001172','Masculino','20320117117','IVANA MAGRIS','A','Soltero','Consumidor Final',1,1),
(1173,1,'P','2016-04-04 00:00:00',1,'32001173','Masculino','20320117217','BARBOSA','A','Soltero','Consumidor Final',1,1),
(1174,1,'P','2016-04-04 00:00:00',1,'32001174','Masculino','20320117317','OLGA REYNOSO','A','Soltero','Consumidor Final',1,1),
(1175,1,'P','2016-04-04 00:00:00',1,'32001175','Masculino','20320117417','VIVAS (BOCHAS)','A','Soltero','Consumidor Final',1,1),
(1176,1,'P','2016-04-04 00:00:00',1,'32001176','Masculino','20320117517','GOMERO','A','Soltero','Consumidor Final',1,1),
(1177,1,'P','2016-04-04 00:00:00',1,'32001177','Masculino','20320117617','MARTINEZ SILVIA','A','Soltero','Consumidor Final',1,1),
(1178,1,'P','2016-04-04 00:00:00',1,'32001178','Masculino','20320117717','ORTIZ..','A','Soltero','Consumidor Final',1,1),
(1179,1,'P','2016-04-04 00:00:00',1,'32001179','Masculino','20320117817','GODOY.','A','Soltero','Consumidor Final',1,1),
(1180,1,'P','2016-04-04 00:00:00',1,'32001180','Masculino','20320117917','ROBERTO..','A','Soltero','Consumidor Final',1,1),
(1181,1,'P','2016-04-04 00:00:00',1,'32001181','Masculino','20320118017','VIALMETTI','A','Soltero','Consumidor Final',1,1),
(1182,1,'P','2016-04-04 00:00:00',1,'32001182','Masculino','20320118117','VARELA','A','Soltero','Consumidor Final',1,1),
(1183,1,'P','2016-04-04 00:00:00',1,'32001183','Masculino','20320118217','BATALLA','A','Soltero','Consumidor Final',1,1),
(1184,1,'P','2016-04-04 00:00:00',1,'32001184','Masculino','20320118317','SONIA','A','Soltero','Consumidor Final',1,1),
(1185,1,'P','2016-04-04 00:00:00',1,'32001185','Masculino','20320118417','ASTUDILLO.','A','Soltero','Consumidor Final',1,1),
(1186,1,'P','2016-04-04 00:00:00',1,'32001186','Masculino','20320118517','VANESA','A','Soltero','Consumidor Final',1,1),
(1187,1,'P','2016-04-04 00:00:00',1,'32001187','Masculino','20320118617','SANCHEZ HUGO.','A','Soltero','Consumidor Final',1,1),
(1188,1,'P','2016-04-04 00:00:00',1,'32001188','Masculino','20320118717','CARRANZA','A','Soltero','Consumidor Final',1,1),
(1189,1,'P','2016-04-04 00:00:00',1,'32001189','Masculino','20320118817','ESTER','A','Soltero','Consumidor Final',1,1),
(1190,1,'P','2016-04-04 00:00:00',1,'32001190','Masculino','20320118917','GUDIÑO OMAR','A','Soltero','Consumidor Final',1,1),
(1191,1,'P','2016-04-04 00:00:00',1,'32001191','Masculino','20320119017','LARISA','A','Soltero','Consumidor Final',1,1),
(1192,1,'P','2016-04-04 00:00:00',1,'32001192','Masculino','20320119117','PERLO PADRE','A','Soltero','Consumidor Final',1,1),
(1193,1,'P','2016-04-04 00:00:00',1,'32001193','Masculino','20320119217','BRIZUELA.','A','Soltero','Consumidor Final',1,1),
(1194,1,'P','2016-04-04 00:00:00',1,'32001194','Masculino','20320119317','PURA','A','Soltero','Consumidor Final',1,1),
(1195,1,'P','2016-04-04 00:00:00',1,'32001195','Masculino','20320119417','SOLIS DANTE','A','Soltero','Consumidor Final',1,1),
(1196,1,'P','2016-04-04 00:00:00',1,'32001196','Masculino','20320119517','DIAS CONCI','A','Soltero','Consumidor Final',1,1),
(1197,1,'P','2016-04-04 00:00:00',1,'32001197','Masculino','20320119617','RODRIGO','A','Soltero','Consumidor Final',1,1),
(1198,1,'P','2016-04-04 00:00:00',1,'32001198','Masculino','20320119717','ROSA','A','Soltero','Consumidor Final',1,1),
(1199,1,'P','2016-04-04 00:00:00',1,'32001199','Masculino','20320119817','HECTOR','A','Soltero','Consumidor Final',1,1),
(1200,1,'P','2016-04-04 00:00:00',1,'32001200','Masculino','20320119917','LILIANA.','A','Soltero','Consumidor Final',1,1),
(1201,1,'P','2016-04-04 00:00:00',1,'32001201','Masculino','20320120017','TOLEDO.','A','Soltero','Consumidor Final',1,1),
(1202,1,'P','2016-04-04 00:00:00',1,'32001202','Masculino','20320120117','QUEIRUGA','A','Soltero','Consumidor Final',1,1),
(1203,1,'P','2016-04-04 00:00:00',1,'32001203','Masculino','20320120217','QUILES','A','Soltero','Consumidor Final',1,1),
(1204,1,'P','2016-04-04 00:00:00',1,'32001204','Masculino','20320120317','MARCOS','A','Soltero','Consumidor Final',1,1),
(1205,1,'P','2016-04-04 00:00:00',1,'32001205','Masculino','20320120417','SOLEDAD LOYOLA','A','Soltero','Consumidor Final',1,1),
(1206,1,'P','2016-04-04 00:00:00',1,'32001206','Masculino','20320120517','CRISTINA /ACOSTA','A','Soltero','Consumidor Final',1,1),
(1207,1,'P','2016-04-04 00:00:00',1,'32001207','Masculino','20320120617','LALO.','A','Soltero','Consumidor Final',1,1),
(1208,1,'P','2016-04-04 00:00:00',1,'32001208','Masculino','20320120717','XIMENA','A','Soltero','Consumidor Final',1,1),
(1209,1,'P','2016-04-04 00:00:00',1,'32001209','Masculino','20320120817','CASOLA','A','Soltero','Consumidor Final',1,1),
(1210,1,'P','2016-04-04 00:00:00',1,'32001210','Masculino','20320120917','BARRERA ALMACEN','A','Soltero','Consumidor Final',1,1),
(1211,1,'P','2016-04-04 00:00:00',1,'32001211','Masculino','20320121017','JUANA','A','Soltero','Consumidor Final',1,1),
(1212,1,'P','2016-04-04 00:00:00',1,'32001212','Masculino','20320121117','DEMONTE/ fca. Pastas','A','Soltero','Consumidor Final',1,1),
(1213,1,'P','2016-04-04 00:00:00',1,'32001213','Masculino','20320121217','VILLAREAL./godoy','A','Soltero','Consumidor Final',1,1),
(1214,1,'P','2016-04-04 00:00:00',1,'32001214','Masculino','20320121317','PULGA','A','Soltero','Consumidor Final',1,1),
(1215,1,'P','2016-04-04 00:00:00',1,'32001215','Masculino','20320121417','SOSA..','A','Soltero','Consumidor Final',1,1),
(1216,1,'P','2016-04-04 00:00:00',1,'32001216','Masculino','20320121517','LOPEZ','A','Soltero','Consumidor Final',1,1),
(1217,1,'P','2016-04-04 00:00:00',1,'32001217','Masculino','20320121617','LOURDES MARINI','A','Soltero','Consumidor Final',1,1),
(1218,1,'P','2016-04-04 00:00:00',1,'32001218','Masculino','20320121717','MONASTEROLO','A','Soltero','Consumidor Final',1,1),
(1219,1,'P','2016-04-04 00:00:00',1,'32001219','Masculino','20320121817','VARGAS.','A','Soltero','Consumidor Final',1,1),
(1220,1,'P','2016-04-04 00:00:00',1,'32001220','Masculino','20320121917','ROMINA','A','Soltero','Consumidor Final',1,1),
(1221,1,'P','2016-04-04 00:00:00',1,'32001221','Masculino','20320122017','GUSTAVO/VERDULERIA','A','Soltero','Consumidor Final',1,1),
(1222,1,'P','2016-04-04 00:00:00',1,'32001222','Masculino','20320122117','FLORA','A','Soltero','Consumidor Final',1,1),
(1223,1,'P','2016-04-04 00:00:00',1,'32001223','Masculino','20320122217','ALEJANDRA..','A','Soltero','Consumidor Final',1,1),
(1224,1,'P','2016-04-04 00:00:00',1,'32001224','Masculino','20320122317','MARIO','A','Soltero','Consumidor Final',1,1),
(1225,1,'P','2016-04-04 00:00:00',1,'32001225','Masculino','20320122417','SOSA MARIA','A','Soltero','Consumidor Final',1,1),
(1226,1,'P','2016-04-04 00:00:00',1,'32001226','Masculino','20320122517','CERINI ELENA','A','Soltero','Consumidor Final',1,1),
(1227,1,'P','2016-04-04 00:00:00',1,'32001227','Masculino','20320122617','DEBORA','A','Soltero','Consumidor Final',1,1),
(1228,1,'P','2016-04-04 00:00:00',1,'32001228','Masculino','20320122717','RAMIRES ALMACEN','A','Soltero','Consumidor Final',1,1),
(1229,1,'P','2016-04-04 00:00:00',1,'32001229','Masculino','20320122817','CHINO FLORES','A','Soltero','Consumidor Final',1,1),
(1230,1,'P','2016-04-04 00:00:00',1,'32001230','Masculino','20320122917','ANA BAROLI','A','Soltero','Consumidor Final',1,1),
(1231,1,'P','2016-04-04 00:00:00',1,'32001231','Masculino','20320123017','FLAVIA','A','Soltero','Consumidor Final',1,1),
(1232,1,'P','2016-04-04 00:00:00',1,'32001232','Masculino','20320123117','PIRUCHA','A','Soltero','Consumidor Final',1,1),
(1233,1,'P','2016-04-04 00:00:00',1,'32001233','Masculino','20320123217','FUR','A','Soltero','Consumidor Final',1,1),
(1234,1,'P','2016-04-04 00:00:00',1,'32001234','Masculino','20320123317','NORMA','A','Soltero','Consumidor Final',1,1),
(1235,1,'P','2016-04-04 00:00:00',1,'32001235','Masculino','20320123417','CRC COMPUTACION','A','Soltero','Consumidor Final',1,1),
(1236,1,'P','2016-04-04 00:00:00',1,'32001236','Masculino','20320123517','PAOLA.','A','Soltero','Consumidor Final',1,1),
(1237,1,'P','2016-04-04 00:00:00',1,'32001237','Masculino','20320123617','PAZ','A','Soltero','Consumidor Final',1,1),
(1238,1,'P','2016-04-04 00:00:00',1,'32001238','Masculino','20320123717','LOPEZ','A','Soltero','Consumidor Final',1,1),
(1239,1,'P','2016-04-04 00:00:00',1,'32001239','Masculino','20320123817','OLMEDO','A','Soltero','Consumidor Final',1,1),
(1240,1,'P','2016-04-04 00:00:00',1,'32001240','Masculino','20320123917','AME LAURA','A','Soltero','Consumidor Final',1,1),
(1241,1,'P','2016-04-04 00:00:00',1,'32001241','Masculino','20320124017','TERESA','A','Soltero','Consumidor Final',1,1),
(1242,1,'P','2016-04-04 00:00:00',1,'32001242','Masculino','20320124117','ONTIVERO','A','Soltero','Consumidor Final',1,1),
(1243,1,'P','2016-04-04 00:00:00',1,'32001243','Masculino','20320124217','BLANCA.','A','Soltero','Consumidor Final',1,1),
(1244,1,'P','2016-04-04 00:00:00',1,'32001244','Masculino','20320124317','CECILIA','A','Soltero','Consumidor Final',1,1),
(1245,1,'P','2016-04-04 00:00:00',1,'32001245','Masculino','20320124417','LUDUEÑA.','A','Soltero','Consumidor Final',1,1),
(1246,1,'P','2016-04-04 00:00:00',1,'32001246','Masculino','20320124517','IRIARTE','A','Soltero','Consumidor Final',1,1),
(1247,1,'P','2016-04-04 00:00:00',1,'32001247','Masculino','20320124617','SONIA.','A','Soltero','Consumidor Final',1,1),
(1248,1,'P','2016-04-04 00:00:00',1,'32001248','Masculino','20320124717','MARTIN','A','Soltero','Consumidor Final',1,1),
(1249,1,'P','2016-04-04 00:00:00',1,'32001249','Masculino','20320124817','GOMES.','A','Soltero','Consumidor Final',1,1),
(1250,1,'P','2016-04-04 00:00:00',1,'32001250','Masculino','20320124917','SOTO.','A','Soltero','Consumidor Final',1,1),
(1251,1,'P','2016-04-04 00:00:00',1,'32001251','Masculino','20320125017','VANESA.','A','Soltero','Consumidor Final',1,1),
(1252,1,'P','2016-04-04 00:00:00',1,'32001252','Masculino','20320125117','MORETA','A','Soltero','Consumidor Final',1,1),
(1253,1,'P','2016-04-04 00:00:00',1,'32001253','Masculino','20320125217','DARIO HIDALGO.','A','Soltero','Consumidor Final',1,1),
(1254,1,'P','2016-04-04 00:00:00',1,'32001254','Masculino','20320125317','PEDRONA','A','Soltero','Consumidor Final',1,1),
(1255,1,'P','2016-04-04 00:00:00',1,'32001255','Masculino','20320125417','ACOSTA','A','Soltero','Consumidor Final',1,1),
(1256,1,'P','2016-04-04 00:00:00',1,'32001256','Masculino','20320125517','CARLOS.','A','Soltero','Consumidor Final',1,1),
(1257,1,'P','2016-04-04 00:00:00',1,'32001257','Masculino','20320125617','JOSE REGINATO','A','Soltero','Consumidor Final',1,1),
(1258,1,'P','2016-04-04 00:00:00',1,'32001258','Masculino','20320125717','JAVIER USABARRENA','A','Soltero','Consumidor Final',1,1),
(1259,1,'P','2016-04-04 00:00:00',1,'32001259','Masculino','20320125817','LINARES','A','Soltero','Consumidor Final',1,1),
(1260,1,'P','2016-04-04 00:00:00',1,'32001260','Masculino','20320125917','ANGULO..','A','Soltero','Consumidor Final',1,1),
(1261,1,'P','2016-04-04 00:00:00',1,'32001261','Masculino','20320126017','LA ESQUINA DEL PADDLE','A','Soltero','Consumidor Final',1,1),
(1262,1,'P','2016-04-04 00:00:00',1,'32001262','Masculino','20320126117','RIVAROLA NUERA','A','Soltero','Consumidor Final',1,1),
(1263,1,'P','2016-04-04 00:00:00',1,'32001263','Masculino','20320126217','QUIROGA.','A','Soltero','Consumidor Final',1,1),
(1264,1,'P','2016-04-04 00:00:00',1,'32001264','Masculino','20320126317','BUSTOS','A','Soltero','Consumidor Final',1,1),
(1265,1,'P','2016-04-04 00:00:00',1,'32001265','Masculino','20320126417','BAIGORRIA.','A','Soltero','Consumidor Final',1,1),
(1266,1,'P','2016-04-04 00:00:00',1,'32001266','Masculino','20320126517','ÑAÑEZ','A','Soltero','Consumidor Final',1,1),
(1267,1,'P','2016-04-04 00:00:00',1,'32001267','Masculino','20320126617','SANTILLAN','A','Soltero','Consumidor Final',1,1),
(1268,1,'P','2016-04-04 00:00:00',1,'32001268','Masculino','20320126717','BASTINO','A','Soltero','Consumidor Final',1,1),
(1269,1,'P','2016-04-04 00:00:00',1,'32001269','Masculino','20320126817','MARTINA SILVA','A','Soltero','Consumidor Final',1,1),
(1270,1,'P','2016-04-04 00:00:00',1,'32001270','Masculino','20320126917','RAMALLO','A','Soltero','Consumidor Final',1,1),
(1271,1,'P','2016-04-04 00:00:00',1,'32001271','Masculino','20320127017','VILLEGAS','A','Soltero','Consumidor Final',1,1),
(1272,1,'P','2016-04-04 00:00:00',1,'32001272','Masculino','20320127117','ARROYO.','A','Soltero','Consumidor Final',1,1),
(1273,1,'P','2016-04-04 00:00:00',1,'32001273','Masculino','20320127217','RUIZ GABRIEL','A','Soltero','Consumidor Final',1,1),
(1274,1,'P','2016-04-04 00:00:00',1,'32001274','Masculino','20320127317','PAREDES','A','Soltero','Consumidor Final',1,1),
(1275,1,'P','2016-04-04 00:00:00',1,'32001275','Masculino','20320127417','RAMIREZ','A','Soltero','Consumidor Final',1,1),
(1276,1,'P','2016-04-04 00:00:00',1,'32001276','Masculino','20320127517','LEDESMA.','A','Soltero','Consumidor Final',1,1),
(1277,1,'P','2016-04-04 00:00:00',1,'32001277','Masculino','20320127617','GABY','A','Soltero','Consumidor Final',1,1),
(1278,1,'P','2016-04-04 00:00:00',1,'32001278','Masculino','20320127717','CARO','A','Soltero','Consumidor Final',1,1),
(1279,1,'P','2016-04-04 00:00:00',1,'32001279','Masculino','20320127817','FALOTICO','A','Soltero','Consumidor Final',1,1),
(1280,1,'P','2016-04-04 00:00:00',1,'32001280','Masculino','20320127917','FERREYRA','A','Soltero','Consumidor Final',1,1),
(1281,1,'P','2016-04-04 00:00:00',1,'32001281','Masculino','20320128017','MOYA','A','Soltero','Consumidor Final',1,1),
(1282,1,'P','2016-04-04 00:00:00',1,'32001282','Masculino','20320128117','NOVARINO','A','Soltero','Consumidor Final',1,1),
(1283,1,'P','2016-04-04 00:00:00',1,'32001283','Masculino','20320128217','QUINTEROS','A','Soltero','Consumidor Final',1,1),
(1284,1,'P','2016-04-04 00:00:00',1,'32001284','Masculino','20320128317','PEINADO BLANCA','A','Soltero','Consumidor Final',1,1),
(1285,1,'P','2016-04-04 00:00:00',1,'32001285','Masculino','20320128417','SANTILLA','A','Soltero','Consumidor Final',1,1),
(1286,1,'P','2016-04-04 00:00:00',1,'32001286','Masculino','20320128517','LORENA CORDON','A','Soltero','Consumidor Final',1,1),
(1287,1,'P','2016-04-04 00:00:00',1,'32001287','Masculino','20320128617','BALMACEDA','A','Soltero','Consumidor Final',1,1),
(1288,1,'P','2016-04-04 00:00:00',1,'32001288','Masculino','20320128717','LETREROS MAGU','A','Soltero','Consumidor Final',1,1),
(1289,1,'P','2016-04-04 00:00:00',1,'32001289','Masculino','20320128817','SOLER SERGIO','A','Soltero','Consumidor Final',1,1),
(1290,1,'P','2016-04-04 00:00:00',1,'32001290','Masculino','20320128917','CUELLO..','A','Soltero','Consumidor Final',1,1),
(1291,1,'P','2016-04-04 00:00:00',1,'32001291','Masculino','20320129017','DIAZ','A','Soltero','Consumidor Final',1,1),
(1292,1,'P','2016-04-04 00:00:00',1,'32001292','Masculino','20320129117','ANA GUTIERREZ','A','Soltero','Consumidor Final',1,1),
(1293,1,'P','2016-04-04 00:00:00',1,'32001293','Masculino','20320129217','ASIS ANA MARIA','A','Soltero','Consumidor Final',1,1),
(1294,1,'P','2016-04-04 00:00:00',1,'32001294','Masculino','20320129317','GUTIERREZ','A','Soltero','Consumidor Final',1,1),
(1295,1,'P','2016-04-04 00:00:00',1,'32001295','Masculino','20320129417','MONCADA','A','Soltero','Consumidor Final',1,1),
(1296,1,'P','2016-04-04 00:00:00',1,'32001296','Masculino','20320129517','COCA APAZ','A','Soltero','Consumidor Final',1,1),
(1297,1,'P','2016-04-04 00:00:00',1,'32001297','Masculino','20320129617','CORONEL (REJA NEGRA)','A','Soltero','Consumidor Final',1,1),
(1298,1,'P','2016-04-04 00:00:00',1,'32001298','Masculino','20320129717','FLORENCIA','A','Soltero','Consumidor Final',1,1),
(1299,1,'P','2016-04-04 00:00:00',1,'32001299','Masculino','20320129817','ALEJANDRO','A','Soltero','Consumidor Final',1,1),
(1300,1,'P','2016-04-04 00:00:00',1,'32001300','Masculino','20320129917','ANA','A','Soltero','Consumidor Final',1,1),
(1301,1,'P','2016-04-04 00:00:00',1,'32001301','Masculino','20320130017','NUERA CASTRO','A','Soltero','Consumidor Final',1,1),
(1302,1,'P','2016-04-04 00:00:00',1,'32001302','Masculino','20320130117','CUÑADA CASTRO','A','Soltero','Consumidor Final',1,1),
(1303,1,'P','2016-04-04 00:00:00',1,'32001303','Masculino','20320130217','SARAVIA..','A','Soltero','Consumidor Final',1,1),
(1304,1,'P','2016-04-04 00:00:00',1,'32001304','Masculino','20320130317','HIJA VIKY','A','Soltero','Consumidor Final',1,1),
(1305,1,'P','2016-04-04 00:00:00',1,'32001305','Masculino','20320130417','NUERA OLIVERO','A','Soltero','Consumidor Final',1,1),
(1306,1,'P','2016-04-04 00:00:00',1,'32001306','Masculino','20320130517','ROMERO','A','Soltero','Consumidor Final',1,1),
(1307,1,'P','2016-04-04 00:00:00',1,'32001307','Masculino','20320130617','PALLOTO HIJA','A','Soltero','Consumidor Final',1,1),
(1308,1,'P','2016-04-04 00:00:00',1,'32001308','Masculino','20320130717','MARRUCO.','A','Soltero','Consumidor Final',1,1),
(1309,1,'P','2016-04-04 00:00:00',1,'32001309','Masculino','20320130817','PALLOTO.','A','Soltero','Consumidor Final',1,1),
(1310,1,'P','2016-04-04 00:00:00',1,'32001310','Masculino','20320130917','MIRIAM','A','Soltero','Consumidor Final',1,1),
(1311,1,'P','2016-04-04 00:00:00',1,'32001311','Masculino','20320131017','PINTOS','A','Soltero','Consumidor Final',1,1),
(1312,1,'P','2016-04-04 00:00:00',1,'32001312','Masculino','20320131117','D'' RICO','A','Soltero','Consumidor Final',1,1),
(1313,1,'P','2016-04-04 00:00:00',1,'32001313','Masculino','20320131217','ORONADO','A','Soltero','Consumidor Final',1,1),
(1314,1,'P','2016-04-04 00:00:00',1,'32001314','Masculino','20320131317','CAMINOS TALLER','A','Soltero','Consumidor Final',1,1),
(1315,1,'P','2016-04-04 00:00:00',1,'32001315','Masculino','20320131417','ZABALA BARBARA','A','Soltero','Consumidor Final',1,1),
(1316,1,'P','2016-04-04 00:00:00',1,'32001316','Masculino','20320131517','LEGUIZAMON PABLO','A','Soltero','Consumidor Final',1,1),
(1317,1,'P','2016-04-04 00:00:00',1,'32001317','Masculino','20320131617','GRACIELA.','A','Soltero','Consumidor Final',1,1),
(1318,1,'P','2016-04-04 00:00:00',1,'32001318','Masculino','20320131717','OSVALDO','A','Soltero','Consumidor Final',1,1),
(1319,1,'P','2016-04-04 00:00:00',1,'32001319','Masculino','20320131817','CISTERNA','A','Soltero','Consumidor Final',1,1),
(1320,1,'P','2016-04-04 00:00:00',1,'32001320','Masculino','20320131917','TORRES','A','Soltero','Consumidor Final',1,1),
(1321,1,'P','2016-04-04 00:00:00',1,'32001321','Masculino','20320132017','BETY..','A','Soltero','Consumidor Final',1,1),
(1322,1,'P','2016-04-04 00:00:00',1,'32001322','Masculino','20320132117','CARMEN.','A','Soltero','Consumidor Final',1,1),
(1323,1,'P','2016-04-04 00:00:00',1,'32001323','Masculino','20320132217','PEREYRA..','A','Soltero','Consumidor Final',1,1),
(1324,1,'P','2016-04-04 00:00:00',1,'32001324','Masculino','20320132317','GIMENEZ..','A','Soltero','Consumidor Final',1,1),
(1325,1,'P','2016-04-04 00:00:00',1,'32001325','Masculino','20320132417','ANALIA','A','Soltero','Consumidor Final',1,1),
(1326,1,'P','2016-04-04 00:00:00',1,'32001326','Masculino','20320132517','SUAREZ..','A','Soltero','Consumidor Final',1,1),
(1327,1,'P','2016-04-04 00:00:00',1,'32001327','Masculino','20320132617','MORENO','A','Soltero','Consumidor Final',1,1),
(1328,1,'P','2016-04-04 00:00:00',1,'32001328','Masculino','20320132717','LORENA','A','Soltero','Consumidor Final',1,1),
(1329,1,'P','2016-04-04 00:00:00',1,'32001329','Masculino','20320132817','PAEZ GLADIS','A','Soltero','Consumidor Final',1,1),
(1330,1,'P','2016-04-04 00:00:00',1,'32001330','Masculino','20320132917','SUEGRA PAEZ','A','Soltero','Consumidor Final',1,1),
(1331,1,'P','2016-04-04 00:00:00',1,'32001331','Masculino','20320133017','CRISTINA','A','Soltero','Consumidor Final',1,1),
(1332,1,'P','2016-04-04 00:00:00',1,'32001332','Masculino','20320133117','QUILE / RAMIRO','A','Soltero','Consumidor Final',1,1),
(1333,1,'P','2016-04-04 00:00:00',1,'32001333','Masculino','20320133217','SORIANO','A','Soltero','Consumidor Final',1,1),
(1334,1,'P','2016-04-04 00:00:00',1,'32001334','Masculino','20320133317','ESTER.','A','Soltero','Consumidor Final',1,1),
(1335,1,'P','2016-04-04 00:00:00',1,'32001335','Masculino','20320133417','ACOSTA','A','Soltero','Consumidor Final',1,1),
(1336,1,'P','2016-04-04 00:00:00',1,'32001336','Masculino','20320133517','CLARA.','A','Soltero','Consumidor Final',1,1),
(1337,1,'P','2016-04-04 00:00:00',1,'32001337','Masculino','20320133617','FERREYRA EMBRAGUES','A','Soltero','Consumidor Final',1,1),
(1338,1,'P','2016-04-04 00:00:00',1,'32001338','Masculino','20320133717','GUTIERREZ','A','Soltero','Consumidor Final',1,1),
(1339,1,'P','2016-04-04 00:00:00',1,'32001339','Masculino','20320133817','ALE.','A','Soltero','Consumidor Final',1,1),
(1340,1,'P','2016-04-04 00:00:00',1,'32001340','Masculino','20320133917','LEIGUARDA.','A','Soltero','Consumidor Final',1,1),
(1341,1,'P','2016-04-04 00:00:00',1,'32001341','Masculino','20320134017','FONTANINI / BAÑOS','A','Soltero','Consumidor Final',1,1),
(1342,1,'P','2016-04-04 00:00:00',1,'32001342','Masculino','20320134117','JOSE..','A','Soltero','Consumidor Final',1,1),
(1343,1,'P','2016-04-04 00:00:00',1,'32001343','Masculino','20320134217','POLLINO PADRE','A','Soltero','Consumidor Final',1,1),
(1344,1,'P','2016-04-04 00:00:00',1,'32001344','Masculino','20320134317','QUINTEROS','A','Soltero','Consumidor Final',1,1),
(1345,1,'P','2016-04-04 00:00:00',1,'32001345','Masculino','20320134417','CASAS ASUSENA','A','Soltero','Consumidor Final',1,1),
(1346,1,'P','2016-04-04 00:00:00',1,'32001346','Masculino','20320134517','BRAVO','A','Soltero','Consumidor Final',1,1),
(1347,1,'P','2016-04-04 00:00:00',1,'32001347','Masculino','20320134617','RENE PEREYRA','A','Soltero','Consumidor Final',1,1),
(1348,1,'P','2016-04-04 00:00:00',1,'32001348','Masculino','20320134717','CARRANZA MADRE','A','Soltero','Consumidor Final',1,1),
(1349,1,'P','2016-04-04 00:00:00',1,'32001349','Masculino','20320134817','LAURIA P','A','Soltero','Consumidor Final',1,1),
(1350,1,'P','2016-04-04 00:00:00',1,'32001350','Masculino','20320134917','ELIZONDO - VERDULERIA','A','Soltero','Consumidor Final',1,1),
(1351,1,'P','2016-04-04 00:00:00',1,'32001351','Masculino','20320135017','ARMINDA','A','Soltero','Consumidor Final',1,1),
(1352,1,'P','2016-04-04 00:00:00',1,'32001352','Masculino','20320135117','COLARESTI / SANCHEZ','A','Soltero','Consumidor Final',1,1),
(1353,1,'P','2016-04-04 00:00:00',1,'32001353','Masculino','20320135217','PEREYRA','A','Soltero','Consumidor Final',1,1),
(1354,1,'P','2016-04-04 00:00:00',1,'32001354','Masculino','20320135317','ANTONIA','A','Soltero','Consumidor Final',1,1),
(1355,1,'P','2016-04-04 00:00:00',1,'32001355','Masculino','20320135417','MONJE ALICIA','A','Soltero','Consumidor Final',1,1),
(1356,1,'P','2016-04-04 00:00:00',1,'32001356','Masculino','20320135517','LAURA','A','Soltero','Consumidor Final',1,1),
(1357,1,'P','2016-04-04 00:00:00',1,'32001357','Masculino','20320135617','ROBLEDO','A','Soltero','Consumidor Final',1,1),
(1358,1,'P','2016-04-04 00:00:00',1,'32001358','Masculino','20320135717','GODOY..','A','Soltero','Consumidor Final',1,1),
(1359,1,'P','2016-04-04 00:00:00',1,'32001359','Masculino','20320135817','DIPASQUANTONIO','A','Soltero','Consumidor Final',1,1),
(1360,1,'P','2016-04-04 00:00:00',1,'32001360','Masculino','20320135917','SOSA','A','Soltero','Consumidor Final',1,1),
(1361,1,'P','2016-04-04 00:00:00',1,'32001361','Masculino','20320136017','VALERIA.','A','Soltero','Consumidor Final',1,1),
(1362,1,'P','2016-04-04 00:00:00',1,'32001362','Masculino','20320136117','SORIANO.','A','Soltero','Consumidor Final',1,1),
(1363,1,'P','2016-04-04 00:00:00',1,'32001363','Masculino','20320136217','ANALIA ROBERTO','A','Soltero','Consumidor Final',1,1),
(1364,1,'P','2016-04-04 00:00:00',1,'32001364','Masculino','20320136317','VACA ALEJANDRO','A','Soltero','Consumidor Final',1,1),
(1365,1,'P','2016-04-04 00:00:00',1,'32001365','Masculino','20320136417','CABRERA..','A','Soltero','Consumidor Final',1,1),
(1366,1,'P','2016-04-04 00:00:00',1,'32001366','Masculino','20320136517','GIL','A','Soltero','Consumidor Final',1,1),
(1367,1,'P','2016-04-04 00:00:00',1,'32001367','Masculino','20320136617','BASTIDA','A','Soltero','Consumidor Final',1,1),
(1368,1,'P','2016-04-04 00:00:00',1,'32001368','Masculino','20320136717','KAKU','A','Soltero','Consumidor Final',1,1),
(1369,1,'P','2016-04-04 00:00:00',1,'32001369','Masculino','20320136817','AGUIRRE','A','Soltero','Consumidor Final',1,1),
(1370,1,'P','2016-04-04 00:00:00',1,'32001370','Masculino','20320136917','SALDAÑO','A','Soltero','Consumidor Final',1,1),
(1371,1,'P','2016-04-04 00:00:00',1,'32001371','Masculino','20320137017','PIEDRA BUENA','A','Soltero','Consumidor Final',1,1),
(1372,1,'P','2016-04-04 00:00:00',1,'32001372','Masculino','20320137117','ZULMA','A','Soltero','Consumidor Final',1,1),
(1373,1,'P','2016-04-04 00:00:00',1,'32001373','Masculino','20320137217','TABLADA','A','Soltero','Consumidor Final',1,1),
(1374,1,'P','2016-04-04 00:00:00',1,'32001374','Masculino','20320137317','MERILES','A','Soltero','Consumidor Final',1,1),
(1375,1,'P','2016-04-04 00:00:00',1,'32001375','Masculino','20320137417','CARRANZA.','A','Soltero','Consumidor Final',1,1),
(1376,1,'P','2016-04-04 00:00:00',1,'32001376','Masculino','20320137517','KARINA','A','Soltero','Consumidor Final',1,1),
(1377,1,'P','2016-04-04 00:00:00',1,'32001377','Masculino','20320137617','NANCY AGUERO','A','Soltero','Consumidor Final',1,1),
(1378,1,'P','2016-04-04 00:00:00',1,'32001378','Masculino','20320137717','HERRERA','A','Soltero','Consumidor Final',1,1),
(1379,1,'P','2016-04-04 00:00:00',1,'32001379','Masculino','20320137817','HERRERA.','A','Soltero','Consumidor Final',1,1),
(1380,1,'P','2016-04-04 00:00:00',1,'32001380','Masculino','20320137917','LA SALETTE','A','Soltero','Consumidor Final',1,1),
(1381,1,'P','2016-04-04 00:00:00',1,'32001381','Masculino','20320138017','JUAREZ.','A','Soltero','Consumidor Final',1,1),
(1382,1,'P','2016-04-04 00:00:00',1,'32001382','Masculino','20320138117','PIÑA','A','Soltero','Consumidor Final',1,1),
(1383,1,'P','2016-04-04 00:00:00',1,'32001383','Masculino','20320138217','LOYOLA.','A','Soltero','Consumidor Final',1,1),
(1384,1,'P','2016-04-04 00:00:00',1,'32001384','Masculino','20320138317','MALLA','A','Soltero','Consumidor Final',1,1),
(1385,1,'P','2016-04-04 00:00:00',1,'32001385','Masculino','20320138417','PEDRONA ANDRES','A','Soltero','Consumidor Final',1,1),
(1386,1,'P','2016-04-04 00:00:00',1,'32001386','Masculino','20320138517','AMALLA','A','Soltero','Consumidor Final',1,1),
(1387,1,'P','2016-04-04 00:00:00',1,'32001387','Masculino','20320138617','TULIAN.','A','Soltero','Consumidor Final',1,1),
(1388,1,'P','2016-04-04 00:00:00',1,'32001388','Masculino','20320138717','FERREYRA','A','Soltero','Consumidor Final',1,1),
(1389,1,'P','2016-04-04 00:00:00',1,'32001389','Masculino','20320138817','ARCE MOROCHO','A','Soltero','Consumidor Final',1,1),
(1390,1,'P','2016-04-04 00:00:00',1,'32001390','Masculino','20320138917','CARDONA','A','Soltero','Consumidor Final',1,1),
(1391,1,'P','2016-04-04 00:00:00',1,'32001391','Masculino','20320139017','IBARRA PAMELA','A','Soltero','Consumidor Final',1,1),
(1392,1,'P','2016-04-04 00:00:00',1,'32001392','Masculino','20320139117','NIEVAS','A','Soltero','Consumidor Final',1,1),
(1393,1,'P','2016-04-04 00:00:00',1,'32001393','Masculino','20320139217','CONTRERAS','A','Soltero','Consumidor Final',1,1),
(1394,1,'P','2016-04-04 00:00:00',1,'32001394','Masculino','20320139317','NOELIA.','A','Soltero','Consumidor Final',1,1),
(1395,1,'P','2016-04-04 00:00:00',1,'32001395','Masculino','20320139417','CIARIMBOLI','A','Soltero','Consumidor Final',1,1),
(1396,1,'P','2016-04-04 00:00:00',1,'32001396','Masculino','20320139517','RAMIRES','A','Soltero','Consumidor Final',1,1),
(1397,1,'P','2016-04-04 00:00:00',1,'32001397','Masculino','20320139617','CEJAS','A','Soltero','Consumidor Final',1,1),
(1398,1,'P','2016-04-04 00:00:00',1,'32001398','Masculino','20320139717','ZURITA.','A','Soltero','Consumidor Final',1,1),
(1399,1,'P','2016-04-04 00:00:00',1,'32001399','Masculino','20320139817','TALLER DE MOTOS','A','Soltero','Consumidor Final',1,1),
(1400,1,'P','2016-04-04 00:00:00',1,'32001400','Masculino','20320139917','ADRIAN','A','Soltero','Consumidor Final',1,1),
(1401,1,'P','2016-04-04 00:00:00',1,'32001401','Masculino','20320140017','ANA','A','Soltero','Consumidor Final',1,1),
(1402,1,'P','2016-04-04 00:00:00',1,'32001402','Masculino','20320140117','AMANDA','A','Soltero','Consumidor Final',1,1),
(1403,1,'P','2016-04-04 00:00:00',1,'32001403','Masculino','20320140217','ALE LUDUEÑA','A','Soltero','Consumidor Final',1,1),
(1404,1,'P','2016-04-04 00:00:00',1,'32001404','Masculino','20320140317','CISNERO..','A','Soltero','Consumidor Final',1,1),
(1405,1,'P','2016-04-04 00:00:00',1,'32001405','Masculino','20320140417','HEREDIA','A','Soltero','Consumidor Final',1,1),
(1406,1,'P','2016-04-04 00:00:00',1,'32001406','Masculino','20320140517','FERRARESE RAUL','A','Soltero','Consumidor Final',1,1),
(1407,1,'P','2016-04-04 00:00:00',1,'32001407','Masculino','20320140617','GORDILLO NIETO','A','Soltero','Consumidor Final',1,1),
(1408,1,'P','2016-04-04 00:00:00',1,'32001408','Masculino','20320140717','ROMINA.','A','Soltero','Consumidor Final',1,1),
(1409,1,'P','2016-04-04 00:00:00',1,'32001409','Masculino','20320140817','MARCELA.','A','Soltero','Consumidor Final',1,1),
(1410,1,'P','2016-04-04 00:00:00',1,'32001410','Masculino','20320140917','LORENA.','A','Soltero','Consumidor Final',1,1),
(1411,1,'P','2016-04-04 00:00:00',1,'32001411','Masculino','20320141017','ROSSI MARCELO','A','Soltero','Consumidor Final',1,1),
(1412,1,'P','2016-04-04 00:00:00',1,'32001412','Masculino','20320141117','DIAZ ANGEL','A','Soltero','Consumidor Final',1,1),
(1413,1,'P','2016-04-04 00:00:00',1,'32001413','Masculino','20320141217','SORIA..','A','Soltero','Consumidor Final',1,1),
(1414,1,'P','2016-04-04 00:00:00',1,'32001414','Masculino','20320141317','CEJAS.','A','Soltero','Consumidor Final',1,1),
(1415,1,'P','2016-04-04 00:00:00',1,'32001415','Masculino','20320141417','ALLENDE','A','Soltero','Consumidor Final',1,1),
(1416,1,'P','2016-04-04 00:00:00',1,'32001416','Masculino','20320141517','BENITEZ NORMA','A','Soltero','Consumidor Final',1,1),
(1417,1,'P','2016-04-04 00:00:00',1,'32001417','Masculino','20320141617','GOMES..','A','Soltero','Consumidor Final',1,1),
(1418,1,'P','2016-04-04 00:00:00',1,'32001418','Masculino','20320141717','KETTY','A','Soltero','Consumidor Final',1,1),
(1419,1,'P','2016-04-04 00:00:00',1,'32001419','Masculino','20320141817','IVANA','A','Soltero','Consumidor Final',1,1),
(1420,1,'P','2016-04-04 00:00:00',1,'32001420','Masculino','20320141917','VERONICA','A','Soltero','Consumidor Final',1,1),
(1421,1,'P','2016-04-04 00:00:00',1,'32001421','Masculino','20320142017','PEREZ','A','Soltero','Consumidor Final',1,1),
(1422,1,'P','2016-04-04 00:00:00',1,'32001422','Masculino','20320142117','GARETO (DIARIOS)','A','Soltero','Consumidor Final',1,1),
(1423,1,'P','2016-04-04 00:00:00',1,'32001423','Masculino','20320142217','OLGA','A','Soltero','Consumidor Final',1,1),
(1424,1,'P','2016-04-04 00:00:00',1,'32001424','Masculino','20320142317','CAROLINA PEREYRA','A','Soltero','Consumidor Final',1,1),
(1425,1,'P','2016-04-04 00:00:00',1,'32001425','Masculino','20320142417','RAUL GOMES','A','Soltero','Consumidor Final',1,1),
(1426,1,'P','2016-04-04 00:00:00',1,'32001426','Masculino','20320142517','ARMINDA.','A','Soltero','Consumidor Final',1,1),
(1427,1,'P','2016-04-04 00:00:00',1,'32001427','Masculino','20320142617','GABRIELA.','A','Soltero','Consumidor Final',1,1),
(1428,1,'P','2016-04-04 00:00:00',1,'32001428','Masculino','20320142717','RODRIGUES','A','Soltero','Consumidor Final',1,1),
(1429,1,'P','2016-04-04 00:00:00',1,'32001429','Masculino','20320142817','LORENA..','A','Soltero','Consumidor Final',1,1),
(1430,1,'P','2016-04-04 00:00:00',1,'32001430','Masculino','20320142917','GAUNA SILVIA','A','Soltero','Consumidor Final',1,1),
(1431,1,'P','2016-04-04 00:00:00',1,'32001431','Masculino','20320143017','ALFARO.','A','Soltero','Consumidor Final',1,1),
(1432,1,'P','2016-04-04 00:00:00',1,'32001432','Masculino','20320143117','SOLEDAD/ ROBERTO','A','Soltero','Consumidor Final',1,1),
(1433,1,'P','2016-04-04 00:00:00',1,'32001433','Masculino','20320143217','MONTENEGRO..','A','Soltero','Consumidor Final',1,1),
(1434,1,'P','2016-04-04 00:00:00',1,'32001434','Masculino','20320143317','ALVAREZ','A','Soltero','Consumidor Final',1,1),
(1435,1,'P','2016-04-04 00:00:00',1,'32001435','Masculino','20320143417','CONTRERAS FARMACIA','A','Soltero','Consumidor Final',1,1),
(1436,1,'P','2016-04-04 00:00:00',1,'32001436','Masculino','20320143517','ROLDAN NICOLAS','A','Soltero','Consumidor Final',1,1),
(1437,1,'P','2016-04-04 00:00:00',1,'32001437','Masculino','20320143617','ZABALA CESAR','A','Soltero','Consumidor Final',1,1),
(1438,1,'P','2016-04-04 00:00:00',1,'32001438','Masculino','20320143717','ROMERO--','A','Soltero','Consumidor Final',1,1),
(1439,1,'P','2016-04-04 00:00:00',1,'32001439','Masculino','20320143817','RUGERI','A','Soltero','Consumidor Final',1,1),
(1440,1,'P','2016-04-04 00:00:00',1,'32001440','Masculino','20320143917','PIEDRABUENA','A','Soltero','Consumidor Final',1,1),
(1441,1,'P','2016-04-04 00:00:00',1,'32001441','Masculino','20320144017','AMAYA LORENA','A','Soltero','Consumidor Final',1,1),
(1442,1,'P','2016-04-04 00:00:00',1,'32001442','Masculino','20320144117','PEÑA','A','Soltero','Consumidor Final',1,1),
(1443,1,'P','2016-04-04 00:00:00',1,'32001443','Masculino','20320144217','DUEÑO TALLER','A','Soltero','Consumidor Final',1,1),
(1444,1,'P','2016-04-04 00:00:00',1,'32001444','Masculino','20320144317','BERGARA..','A','Soltero','Consumidor Final',1,1),
(1445,1,'P','2016-04-04 00:00:00',1,'32001445','Masculino','20320144417','OFELIA.','A','Soltero','Consumidor Final',1,1),
(1446,1,'P','2016-04-04 00:00:00',1,'32001446','Masculino','20320144517','ARGUELLO.','A','Soltero','Consumidor Final',1,1),
(1447,1,'P','2016-04-04 00:00:00',1,'32001447','Masculino','20320144617','GRACIELA..','A','Soltero','Consumidor Final',1,1),
(1448,1,'P','2016-04-04 00:00:00',1,'32001448','Masculino','20320144717','ESPAÑOLA','A','Soltero','Consumidor Final',1,1),
(1449,1,'P','2016-04-04 00:00:00',1,'32001449','Masculino','20320144817','OCHOA.','A','Soltero','Consumidor Final',1,1),
(1450,1,'P','2016-04-04 00:00:00',1,'32001450','Masculino','20320144917','PINTO','A','Soltero','Consumidor Final',1,1),
(1451,1,'P','2016-04-04 00:00:00',1,'32001451','Masculino','20320145017','BALFRE','A','Soltero','Consumidor Final',1,1),
(1452,1,'P','2016-04-04 00:00:00',1,'32001452','Masculino','20320145117','CHECA','A','Soltero','Consumidor Final',1,1),
(1453,1,'P','2016-04-04 00:00:00',1,'32001453','Masculino','20320145217','ELIO','A','Soltero','Consumidor Final',1,1),
(1454,1,'P','2016-04-04 00:00:00',1,'32001454','Masculino','20320145317','CALDERON','A','Soltero','Consumidor Final',1,1),
(1455,1,'P','2016-04-04 00:00:00',1,'32001455','Masculino','20320145417','SILVA.','A','Soltero','Consumidor Final',1,1),
(1456,1,'P','2016-04-04 00:00:00',1,'32001456','Masculino','20320145517','MARTINEZ MARTA','A','Soltero','Consumidor Final',1,1),
(1457,1,'P','2016-04-04 00:00:00',1,'32001457','Masculino','20320145617','NORMA / RAMON cuñada ester','A','Soltero','Consumidor Final',1,1),
(1458,1,'P','2016-04-04 00:00:00',1,'32001458','Masculino','20320145717','BURDINO','A','Soltero','Consumidor Final',1,1),
(1459,1,'P','2016-04-04 00:00:00',1,'32001459','Masculino','20320145817','SUAREZ','A','Soltero','Consumidor Final',1,1),
(1460,1,'P','2016-04-04 00:00:00',1,'32001460','Masculino','20320145917','LILIANA..','A','Soltero','Consumidor Final',1,1),
(1461,1,'P','2016-04-04 00:00:00',1,'32001461','Masculino','20320146017','ESCOBAR','A','Soltero','Consumidor Final',1,1),
(1462,1,'P','2016-04-04 00:00:00',1,'32001462','Masculino','20320146117','SILVANA','A','Soltero','Consumidor Final',1,1),
(1463,1,'P','2016-04-04 00:00:00',1,'32001463','Masculino','20320146217','HIJO ESTER','A','Soltero','Consumidor Final',1,1),
(1464,1,'P','2016-04-04 00:00:00',1,'32001464','Masculino','20320146317','PATIÑO','A','Soltero','Consumidor Final',1,1),
(1465,1,'P','2016-04-04 00:00:00',1,'32001465','Masculino','20320146417','ROJAS','A','Soltero','Consumidor Final',1,1),
(1466,1,'P','2016-04-04 00:00:00',1,'32001466','Masculino','20320146517','PEREYRA','A','Soltero','Consumidor Final',1,1),
(1467,1,'P','2016-04-04 00:00:00',1,'32001467','Masculino','20320146617','CRISTINA','A','Soltero','Consumidor Final',1,1),
(1468,1,'P','2016-04-04 00:00:00',1,'32001468','Masculino','20320146717','PIZA MARIO BROSS','A','Soltero','Consumidor Final',1,1),
(1469,1,'P','2016-04-04 00:00:00',1,'32001469','Masculino','20320146817','MARCELA QUIROGA','A','Soltero','Consumidor Final',1,1),
(1470,1,'P','2016-04-04 00:00:00',1,'32001470','Masculino','20320146917','QUEVEDO.','A','Soltero','Consumidor Final',1,1),
(1471,1,'P','2016-04-04 00:00:00',1,'32001471','Masculino','20320147017','PEREZ HNO','A','Soltero','Consumidor Final',1,1),
(1472,1,'P','2016-04-04 00:00:00',1,'32001472','Masculino','20320147117','LUCIANA','A','Soltero','Consumidor Final',1,1),
(1473,1,'P','2016-04-04 00:00:00',1,'32001473','Masculino','20320147217','IVANA.','A','Soltero','Consumidor Final',1,1),
(1474,1,'P','2016-04-04 00:00:00',1,'32001474','Masculino','20320147317','NOEMI.','A','Soltero','Consumidor Final',1,1),
(1475,1,'P','2016-04-04 00:00:00',1,'32001475','Masculino','20320147417','GARBARINO','A','Soltero','Consumidor Final',1,1),
(1476,1,'P','2016-04-04 00:00:00',1,'32001476','Masculino','20320147517','SOBRERO','A','Soltero','Consumidor Final',1,1),
(1477,1,'P','2016-04-04 00:00:00',1,'32001477','Masculino','20320147617','MERCEDES DUARTE','A','Soltero','Consumidor Final',1,1),
(1478,1,'P','2016-04-04 00:00:00',1,'32001478','Masculino','20320147717','MIRANDA','A','Soltero','Consumidor Final',1,1),
(1479,1,'P','2016-04-04 00:00:00',1,'32001479','Masculino','20320147817','RODRIGUES','A','Soltero','Consumidor Final',1,1),
(1480,1,'P','2016-04-04 00:00:00',1,'32001480','Masculino','20320147917','BURDINO.','A','Soltero','Consumidor Final',1,1),
(1481,1,'P','2016-04-04 00:00:00',1,'32001481','Masculino','20320148017','MORENO','A','Soltero','Consumidor Final',1,1),
(1482,1,'P','2016-04-04 00:00:00',1,'32001482','Masculino','20320148117','YOST','A','Soltero','Consumidor Final',1,1),
(1483,1,'P','2016-04-04 00:00:00',1,'32001483','Masculino','20320148217','JOHANA','A','Soltero','Consumidor Final',1,1),
(1484,1,'P','2016-04-04 00:00:00',1,'32001484','Masculino','20320148317','MADRE SALDIVIA','A','Soltero','Consumidor Final',1,1),
(1485,1,'P','2016-04-04 00:00:00',1,'32001485','Masculino','20320148417','BONAVITTA','A','Soltero','Consumidor Final',1,1),
(1486,1,'P','2016-04-04 00:00:00',1,'32001486','Masculino','20320148517','SEGOVIA','A','Soltero','Consumidor Final',1,1),
(1487,1,'P','2016-04-04 00:00:00',1,'32001487','Masculino','20320148617','LUDUEÑA..','A','Soltero','Consumidor Final',1,1),
(1488,1,'P','2016-04-04 00:00:00',1,'32001488','Masculino','20320148717','VERA.','A','Soltero','Consumidor Final',1,1),
(1489,1,'P','2016-04-04 00:00:00',1,'32001489','Masculino','20320148817','CUEVAS','A','Soltero','Consumidor Final',1,1),
(1490,1,'P','2016-04-04 00:00:00',1,'32001490','Masculino','20320148917','ARANCIBIA M','A','Soltero','Consumidor Final',1,1),
(1491,1,'P','2016-04-04 00:00:00',1,'32001491','Masculino','20320149017','MIGUEL E','A','Soltero','Consumidor Final',1,1),
(1492,1,'PJ','2016-04-04 00:00:00',5,' ',NULL,'30454354354',NULL,'Nores Primario',NULL,'Responsable Inscripto',1,1),
(1493,1,'PJ','2016-04-04 00:00:00',5,' ',NULL,'33435435433',NULL,'Fundación Nores',NULL,'Responsable Inscripto',1,1),
(1494,1,'PJ','2016-04-04 00:00:00',5,' ',NULL,'30767869643',NULL,'Litex SA',NULL,'Responsable Inscripto',1,1),
(1495,1,'PJ','2016-04-04 00:00:00',5,' ',NULL,'33654894345',NULL,'Cenma 19',NULL,'Responsable Inscripto',1,1),
(1496,1,'P','2016-07-03 00:00:00',1,'32423','Masculino\t','23432423432','fghfgh','fghfghfgh','Soltero','Consumidor Final',1,1),
(1497,NULL,NULL,NULL,NULL,'123',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
(1498,NULL,NULL,NULL,NULL,'123',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
(1499,NULL,NULL,NULL,NULL,'123',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;

-- 
-- Definition of compras
-- 

DROP TABLE IF EXISTS `compras`;
CREATE TABLE IF NOT EXISTS `compras` (
  `idcompras` int(11) NOT NULL AUTO_INCREMENT,
  `proveedor` int(11) DEFAULT NULL,
  `tipofactura` varchar(45) DEFAULT NULL,
  `fecha` datetime DEFAULT NULL,
  `numFactura` varchar(45) DEFAULT NULL,
  `fechaEntrega` varchar(45) DEFAULT NULL,
  `fechaVencimiento` varchar(45) DEFAULT NULL,
  `observaciones` varchar(45) DEFAULT NULL,
  `total` double DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  `formaPago` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idcompras`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table compras
-- 

/*!40000 ALTER TABLE `compras` DISABLE KEYS */;
INSERT INTO `compras`(`idcompras`,`proveedor`,`tipofactura`,`fecha`,`numFactura`,`fechaEntrega`,`fechaVencimiento`,`observaciones`,`total`,`estado`,`formaPago`) VALUES
(1,6,'E','2016-07-02 20:24:36','234324','2016-07-12 20:24:36 ','2016-07-12 20:24:36 ','ll',172.06,'Pendiente',''),
(2,6,'X','2016-07-02 20:25:41','342','2016-07-23 20:25:41 ','2016-07-23 20:25:41 ','sdfdddddd',198.89,'Pagado','Cuenta Corriente');
/*!40000 ALTER TABLE `compras` ENABLE KEYS */;

-- 
-- Definition of costoinsumos
-- 

DROP TABLE IF EXISTS `costoinsumos`;
CREATE TABLE IF NOT EXISTS `costoinsumos` (
  `idcostoInsumo` int(11) NOT NULL AUTO_INCREMENT,
  `insumo` int(11) DEFAULT NULL,
  `fechaActualizacion` datetime DEFAULT NULL,
  `costo` double DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idcostoInsumo`),
  KEY `FK_CIinsumo_IidInsumo_idx` (`insumo`),
  CONSTRAINT `FK_CIinsumo_IidInsumo` FOREIGN KEY (`insumo`) REFERENCES `insumos` (`idInsumo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table costoinsumos
-- 

/*!40000 ALTER TABLE `costoinsumos` DISABLE KEYS */;

/*!40000 ALTER TABLE `costoinsumos` ENABLE KEYS */;

-- 
-- Definition of dias
-- 

DROP TABLE IF EXISTS `dias`;
CREATE TABLE IF NOT EXISTS `dias` (
  `idDias` int(11) NOT NULL,
  `dlunes` tinyint(1) DEFAULT NULL,
  `dmartes` tinyint(1) DEFAULT NULL,
  `dmiercoles` tinyint(1) DEFAULT NULL,
  `djueves` tinyint(1) DEFAULT NULL,
  `dviernes` tinyint(1) DEFAULT NULL,
  `dsabado` tinyint(1) DEFAULT NULL,
  `ddomingo` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idDias`),
  CONSTRAINT `FK_didDias_vidVisita` FOREIGN KEY (`idDias`) REFERENCES `visitas` (`idVisita`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table dias
-- 

/*!40000 ALTER TABLE `dias` DISABLE KEYS */;

/*!40000 ALTER TABLE `dias` ENABLE KEYS */;

-- 
-- Definition of distribuidores
-- 

DROP TABLE IF EXISTS `distribuidores`;
CREATE TABLE IF NOT EXISTS `distribuidores` (
  `idDistribuidor` int(11) NOT NULL AUTO_INCREMENT,
  `rol` int(11) DEFAULT NULL,
  `fechaAlta` date DEFAULT NULL,
  `tipoDoc` int(11) DEFAULT NULL,
  `numDoc` varchar(15) DEFAULT NULL,
  `fechaNacimiento` date DEFAULT NULL,
  `sexo` varchar(11) DEFAULT NULL,
  `cuil` varchar(13) DEFAULT NULL,
  `apellido` varchar(45) DEFAULT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `estadoCivil` varchar(45) DEFAULT NULL,
  `condicionIVA` varchar(45) DEFAULT NULL,
  `vehiculo` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idDistribuidor`),
  KEY `FK_tipoDoc_idTipoDoc_idx` (`tipoDoc`),
  KEY `FK_tipoPersona_idTipoPersona_idx` (`rol`),
  KEY `FK_Dvehiculo_VidVehiulo_idx` (`vehiculo`),
  CONSTRAINT `FK_Dvehiculo_VidVehiulo` FOREIGN KEY (`vehiculo`) REFERENCES `vehiculos` (`idVehiculo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_rol_idRol0` FOREIGN KEY (`rol`) REFERENCES `roles` (`idRol`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_tipoDoc_idTipoDoc0` FOREIGN KEY (`tipoDoc`) REFERENCES `tipodocumento` (`idTipoDoc`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table distribuidores
-- 

/*!40000 ALTER TABLE `distribuidores` DISABLE KEYS */;
INSERT INTO `distribuidores`(`idDistribuidor`,`rol`,`fechaAlta`,`tipoDoc`,`numDoc`,`fechaNacimiento`,`sexo`,`cuil`,`apellido`,`nombre`,`estadoCivil`,`condicionIVA`,`vehiculo`,`estado`) VALUES
(1,3,'2016-03-23 00:00:00',1,'36357387','1990-07-23 00:00:00','Masculino','20363573877','Ramos','Franco',NULL,'Soltero',1,1);
/*!40000 ALTER TABLE `distribuidores` ENABLE KEYS */;

-- 
-- Definition of domicilios
-- 

DROP TABLE IF EXISTS `domicilios`;
CREATE TABLE IF NOT EXISTS `domicilios` (
  `idDomicilio` int(11) NOT NULL AUTO_INCREMENT,
  `rol` int(11) DEFAULT NULL,
  `idPersona` int(11) DEFAULT NULL,
  `provincia` int(11) DEFAULT NULL,
  `localidad` int(11) DEFAULT NULL,
  `barrio` int(11) DEFAULT NULL,
  `calle` int(11) DEFAULT NULL,
  `numero` varchar(10) DEFAULT NULL,
  `piso` varchar(8) DEFAULT NULL,
  `dpto` varchar(10) DEFAULT NULL,
  `CP` varchar(6) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idDomicilio`),
  KEY `FK_provincia_idProvincia_idx` (`provincia`),
  KEY `FK_localidad_idLocalidad_idx` (`localidad`),
  KEY `FK_RolDom_idRol_idx` (`rol`),
  KEY `FK_barrio_idBarrio_idx` (`barrio`),
  CONSTRAINT `FK_RolDom_idRol` FOREIGN KEY (`rol`) REFERENCES `roles` (`idRol`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_barrio_idBarrio` FOREIGN KEY (`barrio`) REFERENCES `barrios` (`idBarrio`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_localidad_idLocalidad` FOREIGN KEY (`localidad`) REFERENCES `localidades` (`idLocalidad`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_provincia_idProvincia` FOREIGN KEY (`provincia`) REFERENCES `provincias` (`idProvincia`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=97 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table domicilios
-- 

/*!40000 ALTER TABLE `domicilios` DISABLE KEYS */;
INSERT INTO `domicilios`(`idDomicilio`,`rol`,`idPersona`,`provincia`,`localidad`,`barrio`,`calle`,`numero`,`piso`,`dpto`,`CP`,`estado`) VALUES
(1,1,1,5,26,239,307,'472','9','G','5000',1),
(2,1,1,5,26,239,308,'400','9','A','5000',1),
(3,1,323,5,26,5,255,'3144',NULL,NULL,NULL,1),
(4,1,1151,5,26,5,88,'1868',NULL,NULL,NULL,1),
(5,1,324,5,26,5,88,'1880',NULL,NULL,NULL,1),
(6,1,325,5,26,5,103,'3564',NULL,NULL,NULL,1),
(7,1,1396,5,26,5,103,'3556',NULL,NULL,NULL,1),
(8,1,1418,5,26,5,103,'3574',NULL,NULL,NULL,1),
(9,1,1215,5,26,5,66,'3729',NULL,NULL,NULL,1),
(10,1,326,5,26,5,74,'3722',NULL,NULL,NULL,1),
(11,1,327,5,26,5,66,'3641',NULL,NULL,NULL,1),
(12,1,1208,5,26,5,66,'3624',NULL,'2',NULL,1),
(13,1,328,5,26,5,66,'3636',NULL,NULL,NULL,1),
(14,1,329,5,26,5,66,'3624',NULL,NULL,NULL,1),
(15,1,1109,5,26,5,66,'3604',NULL,NULL,NULL,1),
(16,1,330,5,26,5,66,'3624',NULL,NULL,NULL,1),
(17,1,331,5,26,5,137,'1881',NULL,NULL,NULL,NULL),
(18,1,332,5,26,5,66,'3585',NULL,NULL,NULL,NULL),
(19,1,333,5,26,5,66,'3548',NULL,NULL,NULL,NULL),
(20,1,335,5,26,5,88,'1974','FDO','',NULL,NULL),
(21,1,336,5,26,5,88,'1974',NULL,NULL,NULL,NULL),
(22,1,1260,5,26,5,74,'3116','',NULL,NULL,NULL),
(23,1,339,5,26,5,74,'3314','FTE','',NULL,NULL),
(24,1,454,5,26,5,226,'3235',NULL,NULL,NULL,NULL),
(25,1,340,5,26,5,74,'3314','PLLO',NULL,NULL,NULL),
(26,1,341,5,26,5,226,'3235','',NULL,NULL,NULL),
(27,1,1430,5,26,5,226,'3237',NULL,NULL,NULL,NULL),
(28,1,342,5,26,5,226,'3235',NULL,NULL,NULL,NULL),
(29,1,343,5,26,5,234,'3224',NULL,NULL,NULL,NULL),
(30,1,344,5,26,5,28,'2237',NULL,NULL,NULL,NULL),
(31,1,345,5,26,5,28,'2243',NULL,NULL,NULL,NULL),
(32,1,346,5,26,5,28,'2249',NULL,NULL,NULL,NULL),
(33,1,1438,5,26,5,28,'2257',NULL,NULL,NULL,NULL),
(34,1,348,5,26,5,28,'2270',NULL,NULL,NULL,NULL),
(35,1,349,5,26,5,28,'2277',NULL,NULL,NULL,NULL),
(36,1,350,5,26,5,5,'2218',NULL,NULL,NULL,NULL),
(37,1,351,5,26,5,5,'2218',NULL,'A',NULL,NULL),
(38,1,352,5,26,5,5,'2223',NULL,NULL,NULL,NULL),
(39,1,1214,5,26,5,259,'2113',NULL,NULL,NULL,NULL),
(40,1,353,5,26,5,131,'2135',NULL,NULL,NULL,NULL),
(41,1,354,5,26,5,131,'2116',NULL,NULL,NULL,NULL),
(42,1,719,5,26,5,225,'3321',NULL,NULL,NULL,NULL),
(43,1,356,5,26,5,259,'2112',NULL,NULL,NULL,NULL),
(44,1,358,5,26,5,259,'2124',NULL,NULL,NULL,NULL),
(45,1,359,5,26,5,259,'2124',NULL,NULL,NULL,NULL),
(46,1,360,5,26,5,259,'2150',NULL,NULL,NULL,NULL),
(47,1,361,5,26,5,259,'2158',NULL,NULL,NULL,NULL),
(48,1,1152,5,26,5,4,'2270','PH',NULL,NULL,NULL),
(49,1,362,5,26,5,217,'3379',NULL,NULL,NULL,NULL),
(50,1,363,5,26,5,4,'2275','Frente',NULL,NULL,NULL),
(51,1,379,5,26,5,193,'2213',NULL,NULL,NULL,NULL),
(52,1,364,5,26,5,4,'2275',NULL,NULL,NULL,NULL),
(53,1,380,5,26,5,86,'1',NULL,NULL,NULL,NULL),
(54,1,1460,5,26,5,193,'2205',NULL,NULL,NULL,NULL),
(55,1,1461,5,26,5,193,'2190',NULL,NULL,NULL,NULL),
(56,1,381,5,26,5,193,'2181',NULL,NULL,NULL,NULL),
(57,1,382,5,26,5,193,'2159',NULL,NULL,NULL,NULL),
(58,1,383,5,26,5,185,'3545',NULL,'1',NULL,NULL),
(59,1,384,5,26,5,185,'3547',NULL,'2',NULL,NULL),
(60,1,1413,5,26,5,225,'3624',NULL,NULL,NULL,NULL),
(61,1,1115,5,26,5,185,'3574',NULL,NULL,NULL,NULL),
(62,1,385,5,26,5,185,'3564',NULL,NULL,NULL,NULL),
(63,1,388,5,26,5,86,'3683',NULL,NULL,NULL,NULL),
(64,1,1329,5,26,5,225,'3647',NULL,NULL,NULL,NULL),
(65,1,1330,5,26,5,225,'3647',NULL,NULL,NULL,NULL),
(66,1,389,5,26,5,86,'3662',NULL,NULL,NULL,NULL),
(67,1,390,5,26,5,86,'3670',NULL,NULL,NULL,NULL),
(68,1,769,5,26,5,86,'3631',NULL,NULL,NULL,NULL),
(69,1,392,5,26,5,86,'3625',NULL,NULL,NULL,NULL),
(70,1,393,5,26,5,86,'3625',NULL,NULL,NULL,NULL),
(71,1,394,5,26,5,86,'3609',NULL,NULL,NULL,NULL),
(72,1,1440,5,26,5,273,'3625',NULL,NULL,NULL,NULL),
(73,1,395,5,26,5,67,'1',NULL,NULL,NULL,NULL),
(74,1,396,5,26,5,67,'2225',NULL,NULL,NULL,NULL),
(75,1,397,5,26,5,304,'2328',NULL,NULL,NULL,NULL),
(76,1,399,5,26,5,129,'3705',NULL,NULL,NULL,NULL),
(77,1,1132,5,26,5,53,'1',NULL,NULL,NULL,NULL),
(78,1,672,5,26,5,217,'3752',NULL,NULL,NULL,NULL),
(79,1,401,5,26,5,217,'3769',NULL,NULL,NULL,NULL),
(80,1,402,5,26,5,217,'3897',NULL,NULL,NULL,NULL),
(81,1,403,5,26,5,217,'3890',NULL,NULL,NULL,NULL),
(82,1,1186,5,26,5,217,'3895',NULL,NULL,NULL,NULL),
(83,1,1227,5,26,5,217,'3862',NULL,NULL,NULL,NULL),
(84,1,1256,5,26,5,53,'3854',NULL,NULL,NULL,NULL),
(85,1,404,5,26,5,217,'3886',NULL,NULL,NULL,NULL),
(86,1,405,5,26,5,249,'2318',NULL,NULL,NULL,NULL),
(87,1,1419,5,26,5,53,'3895',NULL,NULL,NULL,NULL),
(88,1,386,5,26,5,53,'3879',NULL,NULL,NULL,NULL),
(89,1,1257,5,26,5,53,'3794',NULL,NULL,NULL,NULL),
(90,1,407,5,26,5,53,'3897',NULL,NULL,NULL,NULL),
(91,1,408,5,26,5,53,'3784',NULL,NULL,NULL,NULL),
(92,1,1462,5,26,5,53,'3731',NULL,NULL,NULL,NULL),
(93,1,411,5,26,5,53,'3748',NULL,NULL,NULL,NULL),
(94,1,1334,5,26,5,53,'3712',NULL,NULL,NULL,NULL),
(95,1,1089,5,26,5,53,'3729',NULL,NULL,NULL,NULL),
(96,1,5,5,26,5,1,'2','2','3','434324',1);
/*!40000 ALTER TABLE `domicilios` ENABLE KEYS */;

-- 
-- Definition of emails
-- 

DROP TABLE IF EXISTS `emails`;
CREATE TABLE IF NOT EXISTS `emails` (
  `idEmail` int(11) NOT NULL AUTO_INCREMENT,
  `rol` int(11) DEFAULT NULL,
  `idPersona` int(11) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idEmail`),
  KEY `FK_eRol_idRol_idx` (`rol`),
  CONSTRAINT `FK_eRol_idRol` FOREIGN KEY (`rol`) REFERENCES `roles` (`idRol`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table emails
-- 

/*!40000 ALTER TABLE `emails` DISABLE KEYS */;
INSERT INTO `emails`(`idEmail`,`rol`,`idPersona`,`email`,`estado`) VALUES
(1,1,323,'dsfdsf@hotmail.com',1);
/*!40000 ALTER TABLE `emails` ENABLE KEYS */;

-- 
-- Definition of envases
-- 

DROP TABLE IF EXISTS `envases`;
CREATE TABLE IF NOT EXISTS `envases` (
  `idEnvase` int(11) NOT NULL AUTO_INCREMENT,
  `idCliente` int(11) DEFAULT NULL,
  `envaseAgua` varchar(45) DEFAULT NULL,
  `envaseSoda` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idEnvase`),
  KEY `FK_eidCliente_idCliente_idx` (`idCliente`),
  CONSTRAINT `FK_eidCliente_idCliente` FOREIGN KEY (`idCliente`) REFERENCES `clientes` (`idCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table envases
-- 

/*!40000 ALTER TABLE `envases` DISABLE KEYS */;

/*!40000 ALTER TABLE `envases` ENABLE KEYS */;

-- 
-- Definition of estadofactura
-- 

DROP TABLE IF EXISTS `estadofactura`;
CREATE TABLE IF NOT EXISTS `estadofactura` (
  `idestadoFactura` int(11) NOT NULL,
  `estadoFactura` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`idestadoFactura`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table estadofactura
-- 

/*!40000 ALTER TABLE `estadofactura` DISABLE KEYS */;

/*!40000 ALTER TABLE `estadofactura` ENABLE KEYS */;

-- 
-- Definition of facturas
-- 

DROP TABLE IF EXISTS `facturas`;
CREATE TABLE IF NOT EXISTS `facturas` (
  `idfactura` int(11) NOT NULL AUTO_INCREMENT,
  `tipoFactura` varchar(1) DEFAULT NULL,
  `numFactura` int(11) DEFAULT NULL,
  `fechaFactura` datetime DEFAULT NULL,
  `fechaVencimiento` datetime DEFAULT NULL,
  `fechaEntrega` datetime DEFAULT NULL,
  `formaPago` varchar(45) DEFAULT NULL,
  `cliente` int(11) DEFAULT NULL,
  `domicilio` int(11) DEFAULT NULL,
  `observaciones` varchar(45) DEFAULT NULL,
  `total` double DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  `facturascol` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idfactura`),
  KEY `FK_Fcliente_CidCliente_idx` (`cliente`),
  CONSTRAINT `FK_Fcliente_CidCliente` FOREIGN KEY (`cliente`) REFERENCES `clientes` (`idCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=270 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table facturas
-- 

/*!40000 ALTER TABLE `facturas` DISABLE KEYS */;
INSERT INTO `facturas`(`idfactura`,`tipoFactura`,`numFactura`,`fechaFactura`,`fechaVencimiento`,`fechaEntrega`,`formaPago`,`cliente`,`domicilio`,`observaciones`,`total`,`estado`,`facturascol`) VALUES
(1,'C',1,'2016-07-03 00:00:00','0001-01-08 00:00:00','2016-07-03 00:00:00',NULL,323,3,'',12,'Pagado',NULL),
(2,'C',1,'2016-07-03 00:00:00','0001-01-15 00:00:00','2016-07-03 00:00:00',NULL,1151,4,NULL,0,'Pendiente',NULL),
(3,'C',1,'2016-07-03 00:00:00','0001-01-22 00:00:00','2016-07-03 00:00:00',NULL,324,5,NULL,0,'Pendiente',NULL),
(4,'C',1,'2016-07-03 00:00:00','0001-01-29 00:00:00','2016-07-03 00:00:00',NULL,336,21,NULL,0,'Pendiente',NULL),
(5,'C',1,'2016-07-03 00:00:00','0001-02-05 00:00:00','2016-07-03 00:00:00',NULL,335,20,NULL,0,'Pendiente',NULL),
(6,'C',1,'2016-07-03 00:00:00','0001-02-12 00:00:00','2016-07-03 00:00:00',NULL,1396,7,NULL,0,'Pendiente',NULL),
(7,'C',1,'2016-07-03 00:00:00','0001-02-19 00:00:00','2016-07-03 00:00:00',NULL,325,6,NULL,0,'Pendiente',NULL),
(8,'C',1,'2016-07-03 00:00:00','0001-02-26 00:00:00','2016-07-03 00:00:00',NULL,1418,8,NULL,0,'Pendiente',NULL),
(9,'C',1,'2016-07-03 00:00:00','0001-03-05 00:00:00','2016-07-03 00:00:00',NULL,333,19,NULL,0,'Pendiente',NULL),
(10,'C',1,'2016-07-03 00:00:00','0001-03-12 00:00:00','2016-07-03 00:00:00',NULL,332,18,NULL,0,'Pendiente',NULL),
(11,'C',1,'2016-07-03 00:00:00','0001-03-19 00:00:00','2016-07-03 00:00:00',NULL,1109,15,NULL,0,'Pendiente',NULL),
(12,'C',1,'2016-07-03 00:00:00','0001-03-26 00:00:00','2016-07-03 00:00:00',NULL,330,16,NULL,0,'Pendiente',NULL),
(13,'C',1,'2016-07-03 00:00:00','0001-04-02 00:00:00','2016-07-03 00:00:00',NULL,329,14,NULL,0,'Pendiente',NULL),
(14,'C',1,'2016-07-03 00:00:00','0001-04-09 00:00:00','2016-07-03 00:00:00',NULL,1208,12,NULL,0,'Pendiente',NULL),
(15,'C',1,'2016-07-03 00:00:00','0001-04-16 00:00:00','2016-07-03 00:00:00',NULL,328,13,NULL,0,'Pendiente',NULL),
(16,'C',1,'2016-07-03 00:00:00','0001-04-23 00:00:00','2016-07-03 00:00:00',NULL,327,11,NULL,0,'Pendiente',NULL),
(17,'C',1,'2016-07-03 00:00:00','0001-04-30 00:00:00','2016-07-03 00:00:00',NULL,1215,9,NULL,0,'Pendiente',NULL),
(18,'C',1,'2016-07-03 00:00:00','0001-05-07 00:00:00','2016-07-03 00:00:00',NULL,331,17,NULL,0,'Pendiente',NULL),
(19,'C',1,'2016-07-03 00:00:00','0001-05-14 00:00:00','2016-07-03 00:00:00',NULL,342,28,NULL,0,'Pendiente',NULL),
(20,'C',1,'2016-07-03 00:00:00','0001-05-21 00:00:00','2016-07-03 00:00:00',NULL,341,26,NULL,0,'Pendiente',NULL),
(21,'C',1,'2016-07-03 00:00:00','0001-05-28 00:00:00','2016-07-03 00:00:00',NULL,454,24,NULL,0,'Pendiente',NULL),
(22,'C',1,'2016-07-03 00:00:00','0001-06-04 00:00:00','2016-07-03 00:00:00',NULL,1430,27,NULL,0,'Pendiente',NULL),
(23,'C',1,'2016-07-03 00:00:00','0001-06-11 00:00:00','2016-07-03 00:00:00',NULL,343,29,NULL,0,'Pendiente',NULL),
(24,'C',1,'2016-07-03 00:00:00','0001-06-18 00:00:00','2016-07-03 00:00:00',NULL,344,30,NULL,0,'Pendiente',NULL),
(25,'C',1,'2016-07-03 00:00:00','0001-06-25 00:00:00','2016-07-03 00:00:00',NULL,345,31,NULL,0,'Pendiente',NULL),
(26,'C',1,'2016-07-03 00:00:00','0001-07-02 00:00:00','2016-07-03 00:00:00',NULL,346,32,NULL,0,'Pendiente',NULL),
(27,'C',1,'2016-07-03 00:00:00','0001-07-09 00:00:00','2016-07-03 00:00:00',NULL,1438,33,NULL,0,'Pendiente',NULL),
(28,'C',1,'2016-07-03 00:00:00','0001-07-16 00:00:00','2016-07-03 00:00:00',NULL,348,34,NULL,0,'Pendiente',NULL),
(29,'C',1,'2016-07-03 00:00:00','0001-07-23 00:00:00','2016-07-03 00:00:00',NULL,349,35,NULL,0,'Pendiente',NULL),
(30,'C',1,'2016-07-03 00:00:00','0001-07-30 00:00:00','2016-07-03 00:00:00',NULL,351,37,NULL,0,'Pendiente',NULL),
(31,'C',1,'2016-07-03 00:00:00','0001-08-06 00:00:00','2016-07-03 00:00:00',NULL,350,36,NULL,0,'Pendiente',NULL),
(32,'C',1,'2016-07-03 00:00:00','0001-08-13 00:00:00','2016-07-03 00:00:00',NULL,352,38,NULL,0,'Pendiente',NULL),
(33,'C',1,'2016-07-03 00:00:00','0001-08-20 00:00:00','2016-07-03 00:00:00',NULL,356,43,NULL,0,'Pendiente',NULL),
(34,'C',1,'2016-07-03 00:00:00','0001-08-27 00:00:00','2016-07-03 00:00:00',NULL,1214,39,NULL,0,'Pendiente',NULL),
(35,'C',1,'2016-07-03 00:00:00','0001-09-03 00:00:00','2016-07-03 00:00:00',NULL,359,45,NULL,0,'Pendiente',NULL),
(36,'C',1,'2016-07-03 00:00:00','0001-09-10 00:00:00','2016-07-03 00:00:00',NULL,358,44,NULL,0,'Pendiente',NULL),
(37,'C',1,'2016-07-03 00:00:00','0001-09-17 00:00:00','2016-07-03 00:00:00',NULL,360,46,NULL,0,'Pendiente',NULL),
(38,'C',1,'2016-07-03 00:00:00','0001-09-24 00:00:00','2016-07-03 00:00:00',NULL,361,47,NULL,0,'Pendiente',NULL),
(39,'C',1,'2016-07-03 00:00:00','0001-10-01 00:00:00','2016-07-03 00:00:00',NULL,354,41,NULL,0,'Pendiente',NULL),
(40,'C',1,'2016-07-03 00:00:00','0001-10-08 00:00:00','2016-07-03 00:00:00',NULL,353,40,NULL,0,'Pendiente',NULL),
(41,'C',1,'2016-07-03 00:00:00','0001-10-15 00:00:00','2016-07-03 00:00:00',NULL,719,42,NULL,0,'Pendiente',NULL),
(42,'C',1,'2016-07-03 00:00:00','0001-10-22 00:00:00','2016-07-03 00:00:00',NULL,1413,60,NULL,0,'Pendiente',NULL),
(43,'C',1,'2016-07-03 00:00:00','0001-10-29 00:00:00','2016-07-03 00:00:00',NULL,1330,65,NULL,0,'Pendiente',NULL),
(44,'C',1,'2016-07-03 00:00:00','0001-11-05 00:00:00','2016-07-03 00:00:00',NULL,1329,64,NULL,0,'Pendiente',NULL),
(45,'C',1,'2016-07-03 00:00:00','0001-11-12 00:00:00','2016-07-03 00:00:00',NULL,1152,48,NULL,0,'Pendiente',NULL),
(46,'C',1,'2016-07-03 00:00:00','0001-11-19 00:00:00','2016-07-03 00:00:00',NULL,364,52,NULL,0,'Pendiente',NULL),
(47,'C',1,'2016-07-03 00:00:00','0001-11-26 00:00:00','2016-07-03 00:00:00',NULL,363,50,NULL,0,'Pendiente',NULL),
(48,'C',1,'2016-07-03 00:00:00','0001-12-03 00:00:00','2016-07-03 00:00:00',NULL,362,49,NULL,0,'Pendiente',NULL),
(49,'C',1,'2016-07-03 00:00:00','0001-12-10 00:00:00','2016-07-03 00:00:00',NULL,672,78,NULL,0,'Pendiente',NULL),
(50,'C',1,'2016-07-03 00:00:00','0001-12-17 00:00:00','2016-07-03 00:00:00',NULL,401,79,NULL,0,'Pendiente',NULL),
(51,'C',1,'2016-07-03 00:00:00','0001-12-24 00:00:00','2016-07-03 00:00:00',NULL,1227,83,NULL,0,'Pendiente',NULL),
(52,'C',1,'2016-07-03 00:00:00','0001-12-31 00:00:00','2016-07-03 00:00:00',NULL,404,85,NULL,0,'Pendiente',NULL),
(53,'C',1,'2016-07-03 00:00:00','0002-01-07 00:00:00','2016-07-03 00:00:00',NULL,403,81,NULL,0,'Pendiente',NULL),
(54,'C',1,'2016-07-03 00:00:00','0002-01-14 00:00:00','2016-07-03 00:00:00',NULL,1186,82,NULL,0,'Pendiente',NULL),
(55,'C',1,'2016-07-03 00:00:00','0002-01-21 00:00:00','2016-07-03 00:00:00',NULL,402,80,NULL,0,'Pendiente',NULL),
(56,'C',1,'2016-07-03 00:00:00','0002-01-28 00:00:00','2016-07-03 00:00:00',NULL,382,57,NULL,0,'Pendiente',NULL),
(57,'C',1,'2016-07-03 00:00:00','0002-02-04 00:00:00','2016-07-03 00:00:00',NULL,381,56,NULL,0,'Pendiente',NULL),
(58,'C',1,'2016-07-03 00:00:00','0002-02-11 00:00:00','2016-07-03 00:00:00',NULL,1461,55,NULL,0,'Pendiente',NULL),
(59,'C',1,'2016-07-03 00:00:00','0002-02-18 00:00:00','2016-07-03 00:00:00',NULL,1460,54,NULL,0,'Pendiente',NULL),
(60,'C',1,'2016-07-03 00:00:00','0002-02-25 00:00:00','2016-07-03 00:00:00',NULL,379,51,NULL,0,'Pendiente',NULL),
(61,'C',1,'2016-07-03 00:00:00','0002-03-04 00:00:00','2016-07-03 00:00:00',NULL,383,58,NULL,0,'Pendiente',NULL),
(62,'C',1,'2016-07-03 00:00:00','0002-03-11 00:00:00','2016-07-03 00:00:00',NULL,384,59,NULL,0,'Pendiente',NULL),
(63,'C',1,'2016-07-03 00:00:00','0002-03-18 00:00:00','2016-07-03 00:00:00',NULL,385,62,NULL,0,'Pendiente',NULL),
(64,'C',1,'2016-07-03 00:00:00','0002-03-25 00:00:00','2016-07-03 00:00:00',NULL,1115,61,NULL,0,'Pendiente',NULL),
(65,'C',1,'2016-07-03 00:00:00','0002-04-01 00:00:00','2016-07-03 00:00:00',NULL,380,53,NULL,0,'Pendiente',NULL),
(66,'C',1,'2016-07-03 00:00:00','0002-04-08 00:00:00','2016-07-03 00:00:00',NULL,394,71,NULL,0,'Pendiente',NULL),
(67,'C',1,'2016-07-03 00:00:00','0002-04-15 00:00:00','2016-07-03 00:00:00',NULL,393,70,NULL,0,'Pendiente',NULL),
(68,'C',1,'2016-07-03 00:00:00','0002-04-22 00:00:00','2016-07-03 00:00:00',NULL,392,69,NULL,0,'Pendiente',NULL),
(69,'C',1,'2016-07-03 00:00:00','0002-04-29 00:00:00','2016-07-03 00:00:00',NULL,769,68,NULL,0,'Pendiente',NULL),
(70,'C',1,'2016-07-03 00:00:00','0002-05-06 00:00:00','2016-07-03 00:00:00',NULL,389,66,NULL,0,'Pendiente',NULL),
(71,'C',1,'2016-07-03 00:00:00','0002-05-13 00:00:00','2016-07-03 00:00:00',NULL,390,67,NULL,0,'Pendiente',NULL),
(72,'C',1,'2016-07-03 00:00:00','0002-05-20 00:00:00','2016-07-03 00:00:00',NULL,388,63,NULL,0,'Pendiente',NULL),
(73,'C',1,'2016-07-03 00:00:00','0002-05-27 00:00:00','2016-07-03 00:00:00',NULL,1440,72,NULL,0,'Pendiente',NULL),
(74,'C',1,'2016-07-03 00:00:00','0002-06-03 00:00:00','2016-07-03 00:00:00',NULL,395,73,NULL,0,'Pendiente',NULL),
(75,'C',1,'2016-07-03 00:00:00','0002-06-10 00:00:00','2016-07-03 00:00:00',NULL,396,74,NULL,0,'Pendiente',NULL),
(76,'C',1,'2016-07-03 00:00:00','0002-06-17 00:00:00','2016-07-03 00:00:00',NULL,397,75,NULL,0,'Pendiente',NULL),
(77,'C',1,'2016-07-03 00:00:00','0002-06-24 00:00:00','2016-07-03 00:00:00',NULL,399,76,NULL,0,'Pendiente',NULL),
(78,'C',1,'2016-07-03 00:00:00','0002-07-01 00:00:00','2016-07-03 00:00:00',NULL,1132,77,NULL,0,'Pendiente',NULL),
(79,'C',1,'2016-07-03 00:00:00','0002-07-08 00:00:00','2016-07-03 00:00:00',NULL,1334,94,NULL,0,'Pendiente',NULL),
(80,'C',1,'2016-07-03 00:00:00','0002-07-15 00:00:00','2016-07-03 00:00:00',NULL,1089,95,NULL,0,'Pendiente',NULL),
(81,'C',1,'2016-07-03 00:00:00','0002-07-22 00:00:00','2016-07-03 00:00:00',NULL,1462,92,NULL,0,'Pendiente',NULL),
(82,'C',1,'2016-07-03 00:00:00','0002-07-29 00:00:00','2016-07-03 00:00:00',NULL,411,93,NULL,0,'Pendiente',NULL),
(83,'C',1,'2016-07-03 00:00:00','0002-08-05 00:00:00','2016-07-03 00:00:00',NULL,408,91,NULL,0,'Pendiente',NULL),
(84,'C',1,'2016-07-03 00:00:00','0002-08-12 00:00:00','2016-07-03 00:00:00',NULL,1257,89,NULL,0,'Pendiente',NULL),
(85,'C',1,'2016-07-03 00:00:00','0002-08-19 00:00:00','2016-07-03 00:00:00',NULL,1256,84,NULL,0,'Pendiente',NULL),
(86,'C',1,'2016-07-03 00:00:00','0002-08-26 00:00:00','2016-07-03 00:00:00',NULL,386,88,NULL,0,'Pendiente',NULL),
(87,'C',1,'2016-07-03 00:00:00','0002-09-02 00:00:00','2016-07-03 00:00:00',NULL,1419,87,NULL,0,'Pendiente',NULL),
(88,'C',1,'2016-07-03 00:00:00','0002-09-09 00:00:00','2016-07-03 00:00:00',NULL,407,90,NULL,0,'Pendiente',NULL),
(89,'C',1,'2016-07-03 00:00:00','0002-09-16 00:00:00','2016-07-03 00:00:00',NULL,405,86,NULL,0,'Pendiente',NULL),
(90,'C',1,'2016-07-03 00:00:00','0001-01-08 00:00:00','2016-07-03 00:00:00',NULL,323,3,'',0,'Pagado',NULL),
(91,'C',1,'2016-07-04 00:00:00','0001-01-08 00:00:00','2016-07-04 00:00:00',NULL,323,3,NULL,0,'Pendiente',NULL),
(92,'C',1,'2016-07-04 00:00:00','0001-01-15 00:00:00','2016-07-04 00:00:00',NULL,1151,4,NULL,0,'Pendiente',NULL),
(93,'C',1,'2016-07-04 00:00:00','0001-01-22 00:00:00','2016-07-04 00:00:00',NULL,324,5,NULL,0,'Pendiente',NULL),
(94,'C',1,'2016-07-04 00:00:00','0001-01-29 00:00:00','2016-07-04 00:00:00',NULL,336,21,NULL,0,'Pendiente',NULL),
(95,'C',1,'2016-07-04 00:00:00','0001-02-05 00:00:00','2016-07-04 00:00:00',NULL,335,20,NULL,0,'Pendiente',NULL),
(96,'C',1,'2016-07-04 00:00:00','0001-02-12 00:00:00','2016-07-04 00:00:00',NULL,1396,7,NULL,0,'Pendiente',NULL),
(97,'C',1,'2016-07-04 00:00:00','0001-02-19 00:00:00','2016-07-04 00:00:00',NULL,325,6,NULL,0,'Pendiente',NULL),
(98,'C',1,'2016-07-04 00:00:00','0001-02-26 00:00:00','2016-07-04 00:00:00',NULL,1418,8,NULL,0,'Pendiente',NULL),
(99,'C',1,'2016-07-04 00:00:00','0001-03-05 00:00:00','2016-07-04 00:00:00',NULL,333,19,NULL,0,'Pendiente',NULL),
(100,'C',1,'2016-07-04 00:00:00','0001-03-12 00:00:00','2016-07-04 00:00:00',NULL,332,18,NULL,0,'Pendiente',NULL),
(101,'C',1,'2016-07-04 00:00:00','0001-03-19 00:00:00','2016-07-04 00:00:00',NULL,1109,15,NULL,0,'Pendiente',NULL),
(102,'C',1,'2016-07-04 00:00:00','0001-03-26 00:00:00','2016-07-04 00:00:00',NULL,330,16,NULL,0,'Pendiente',NULL),
(103,'C',1,'2016-07-04 00:00:00','0001-04-02 00:00:00','2016-07-04 00:00:00',NULL,329,14,NULL,0,'Pendiente',NULL),
(104,'C',1,'2016-07-04 00:00:00','0001-04-09 00:00:00','2016-07-04 00:00:00',NULL,1208,12,NULL,0,'Pendiente',NULL),
(105,'C',1,'2016-07-04 00:00:00','0001-04-16 00:00:00','2016-07-04 00:00:00',NULL,328,13,NULL,0,'Pendiente',NULL),
(106,'C',1,'2016-07-04 00:00:00','0001-04-23 00:00:00','2016-07-04 00:00:00',NULL,327,11,NULL,0,'Pendiente',NULL),
(107,'C',1,'2016-07-04 00:00:00','0001-04-30 00:00:00','2016-07-04 00:00:00',NULL,1215,9,NULL,0,'Pendiente',NULL),
(108,'C',1,'2016-07-04 00:00:00','0001-05-07 00:00:00','2016-07-04 00:00:00',NULL,331,17,NULL,0,'Pendiente',NULL),
(109,'C',1,'2016-07-04 00:00:00','0001-05-14 00:00:00','2016-07-04 00:00:00',NULL,342,28,NULL,0,'Pendiente',NULL),
(110,'C',1,'2016-07-04 00:00:00','0001-05-21 00:00:00','2016-07-04 00:00:00',NULL,341,26,NULL,0,'Pendiente',NULL),
(111,'C',1,'2016-07-04 00:00:00','0001-05-28 00:00:00','2016-07-04 00:00:00',NULL,454,24,NULL,0,'Pendiente',NULL),
(112,'C',1,'2016-07-04 00:00:00','0001-06-04 00:00:00','2016-07-04 00:00:00',NULL,1430,27,NULL,0,'Pendiente',NULL),
(113,'C',1,'2016-07-04 00:00:00','0001-06-11 00:00:00','2016-07-04 00:00:00',NULL,343,29,NULL,0,'Pendiente',NULL),
(114,'C',1,'2016-07-04 00:00:00','0001-06-18 00:00:00','2016-07-04 00:00:00',NULL,344,30,NULL,0,'Pendiente',NULL),
(115,'C',1,'2016-07-04 00:00:00','0001-06-25 00:00:00','2016-07-04 00:00:00',NULL,345,31,NULL,0,'Pendiente',NULL),
(116,'C',1,'2016-07-04 00:00:00','0001-07-02 00:00:00','2016-07-04 00:00:00',NULL,346,32,NULL,0,'Pendiente',NULL),
(117,'C',1,'2016-07-04 00:00:00','0001-07-09 00:00:00','2016-07-04 00:00:00',NULL,1438,33,NULL,0,'Pendiente',NULL),
(118,'C',1,'2016-07-04 00:00:00','0001-07-16 00:00:00','2016-07-04 00:00:00',NULL,348,34,NULL,0,'Pendiente',NULL),
(119,'C',1,'2016-07-04 00:00:00','0001-07-23 00:00:00','2016-07-04 00:00:00',NULL,349,35,NULL,0,'Pendiente',NULL),
(120,'C',1,'2016-07-04 00:00:00','0001-07-30 00:00:00','2016-07-04 00:00:00',NULL,351,37,NULL,0,'Pendiente',NULL),
(121,'C',1,'2016-07-04 00:00:00','0001-08-06 00:00:00','2016-07-04 00:00:00',NULL,350,36,NULL,0,'Pendiente',NULL),
(122,'C',1,'2016-07-04 00:00:00','0001-08-13 00:00:00','2016-07-04 00:00:00',NULL,352,38,NULL,0,'Pendiente',NULL),
(123,'C',1,'2016-07-04 00:00:00','0001-08-20 00:00:00','2016-07-04 00:00:00',NULL,356,43,NULL,0,'Pendiente',NULL),
(124,'C',1,'2016-07-04 00:00:00','0001-08-27 00:00:00','2016-07-04 00:00:00',NULL,1214,39,NULL,0,'Pendiente',NULL),
(125,'C',1,'2016-07-04 00:00:00','0001-09-03 00:00:00','2016-07-04 00:00:00',NULL,359,45,NULL,0,'Pendiente',NULL),
(126,'C',1,'2016-07-04 00:00:00','0001-09-10 00:00:00','2016-07-04 00:00:00',NULL,358,44,NULL,0,'Pendiente',NULL),
(127,'C',1,'2016-07-04 00:00:00','0001-09-17 00:00:00','2016-07-04 00:00:00',NULL,360,46,NULL,0,'Pendiente',NULL),
(128,'C',1,'2016-07-04 00:00:00','0001-09-24 00:00:00','2016-07-04 00:00:00',NULL,361,47,NULL,0,'Pendiente',NULL),
(129,'C',1,'2016-07-04 00:00:00','0001-10-01 00:00:00','2016-07-04 00:00:00',NULL,354,41,NULL,0,'Pendiente',NULL),
(130,'C',1,'2016-07-04 00:00:00','0001-10-08 00:00:00','2016-07-04 00:00:00',NULL,353,40,NULL,0,'Pendiente',NULL),
(131,'C',1,'2016-07-04 00:00:00','0001-10-15 00:00:00','2016-07-04 00:00:00',NULL,719,42,NULL,0,'Pendiente',NULL),
(132,'C',1,'2016-07-04 00:00:00','0001-10-22 00:00:00','2016-07-04 00:00:00',NULL,1413,60,NULL,0,'Pendiente',NULL),
(133,'C',1,'2016-07-04 00:00:00','0001-10-29 00:00:00','2016-07-04 00:00:00',NULL,1330,65,NULL,0,'Pendiente',NULL),
(134,'C',1,'2016-07-04 00:00:00','0001-11-05 00:00:00','2016-07-04 00:00:00',NULL,1329,64,NULL,0,'Pendiente',NULL),
(135,'C',1,'2016-07-04 00:00:00','0001-11-12 00:00:00','2016-07-04 00:00:00',NULL,1152,48,NULL,0,'Pendiente',NULL),
(136,'C',1,'2016-07-04 00:00:00','0001-11-19 00:00:00','2016-07-04 00:00:00',NULL,364,52,NULL,0,'Pendiente',NULL),
(137,'C',1,'2016-07-04 00:00:00','0001-11-26 00:00:00','2016-07-04 00:00:00',NULL,363,50,NULL,0,'Pendiente',NULL),
(138,'C',1,'2016-07-04 00:00:00','0001-12-03 00:00:00','2016-07-04 00:00:00',NULL,362,49,NULL,0,'Pendiente',NULL),
(139,'C',1,'2016-07-04 00:00:00','0001-12-10 00:00:00','2016-07-04 00:00:00',NULL,672,78,NULL,0,'Pendiente',NULL),
(140,'C',1,'2016-07-04 00:00:00','0001-12-17 00:00:00','2016-07-04 00:00:00',NULL,401,79,NULL,0,'Pendiente',NULL),
(141,'C',1,'2016-07-04 00:00:00','0001-12-24 00:00:00','2016-07-04 00:00:00',NULL,1227,83,NULL,0,'Pendiente',NULL),
(142,'C',1,'2016-07-04 00:00:00','0001-12-31 00:00:00','2016-07-04 00:00:00',NULL,404,85,NULL,0,'Pendiente',NULL),
(143,'C',1,'2016-07-04 00:00:00','0002-01-07 00:00:00','2016-07-04 00:00:00',NULL,403,81,NULL,0,'Pendiente',NULL),
(144,'C',1,'2016-07-04 00:00:00','0002-01-14 00:00:00','2016-07-04 00:00:00',NULL,1186,82,NULL,0,'Pendiente',NULL),
(145,'C',1,'2016-07-04 00:00:00','0002-01-21 00:00:00','2016-07-04 00:00:00',NULL,402,80,NULL,0,'Pendiente',NULL),
(146,'C',1,'2016-07-04 00:00:00','0002-01-28 00:00:00','2016-07-04 00:00:00',NULL,382,57,NULL,0,'Pendiente',NULL),
(147,'C',1,'2016-07-04 00:00:00','0002-02-04 00:00:00','2016-07-04 00:00:00',NULL,381,56,NULL,0,'Pendiente',NULL),
(148,'C',1,'2016-07-04 00:00:00','0002-02-11 00:00:00','2016-07-04 00:00:00',NULL,1461,55,NULL,0,'Pendiente',NULL),
(149,'C',1,'2016-07-04 00:00:00','0002-02-18 00:00:00','2016-07-04 00:00:00',NULL,1460,54,NULL,0,'Pendiente',NULL),
(150,'C',1,'2016-07-04 00:00:00','0002-02-25 00:00:00','2016-07-04 00:00:00',NULL,379,51,NULL,0,'Pendiente',NULL),
(151,'C',1,'2016-07-04 00:00:00','0002-03-04 00:00:00','2016-07-04 00:00:00',NULL,383,58,NULL,0,'Pendiente',NULL),
(152,'C',1,'2016-07-04 00:00:00','0002-03-11 00:00:00','2016-07-04 00:00:00',NULL,384,59,NULL,0,'Pendiente',NULL),
(153,'C',1,'2016-07-04 00:00:00','0002-03-18 00:00:00','2016-07-04 00:00:00',NULL,385,62,NULL,0,'Pendiente',NULL),
(154,'C',1,'2016-07-04 00:00:00','0002-03-25 00:00:00','2016-07-04 00:00:00',NULL,1115,61,NULL,0,'Pendiente',NULL),
(155,'C',1,'2016-07-04 00:00:00','0002-04-01 00:00:00','2016-07-04 00:00:00',NULL,380,53,NULL,0,'Pendiente',NULL),
(156,'C',1,'2016-07-04 00:00:00','0002-04-08 00:00:00','2016-07-04 00:00:00',NULL,394,71,NULL,0,'Pendiente',NULL),
(157,'C',1,'2016-07-04 00:00:00','0002-04-15 00:00:00','2016-07-04 00:00:00',NULL,393,70,NULL,0,'Pendiente',NULL),
(158,'C',1,'2016-07-04 00:00:00','0002-04-22 00:00:00','2016-07-04 00:00:00',NULL,392,69,NULL,0,'Pendiente',NULL),
(159,'C',1,'2016-07-04 00:00:00','0002-04-29 00:00:00','2016-07-04 00:00:00',NULL,769,68,NULL,0,'Pendiente',NULL),
(160,'C',1,'2016-07-04 00:00:00','0002-05-06 00:00:00','2016-07-04 00:00:00',NULL,389,66,NULL,0,'Pendiente',NULL),
(161,'C',1,'2016-07-04 00:00:00','0002-05-13 00:00:00','2016-07-04 00:00:00',NULL,390,67,NULL,0,'Pendiente',NULL),
(162,'C',1,'2016-07-04 00:00:00','0002-05-20 00:00:00','2016-07-04 00:00:00',NULL,388,63,NULL,0,'Pendiente',NULL),
(163,'C',1,'2016-07-04 00:00:00','0002-05-27 00:00:00','2016-07-04 00:00:00',NULL,1440,72,NULL,0,'Pendiente',NULL),
(164,'C',1,'2016-07-04 00:00:00','0002-06-03 00:00:00','2016-07-04 00:00:00',NULL,395,73,NULL,0,'Pendiente',NULL),
(165,'C',1,'2016-07-04 00:00:00','0002-06-10 00:00:00','2016-07-04 00:00:00',NULL,396,74,NULL,0,'Pendiente',NULL),
(166,'C',1,'2016-07-04 00:00:00','0002-06-17 00:00:00','2016-07-04 00:00:00',NULL,397,75,NULL,0,'Pendiente',NULL),
(167,'C',1,'2016-07-04 00:00:00','0002-06-24 00:00:00','2016-07-04 00:00:00',NULL,399,76,NULL,0,'Pendiente',NULL),
(168,'C',1,'2016-07-04 00:00:00','0002-07-01 00:00:00','2016-07-04 00:00:00',NULL,1132,77,NULL,0,'Pendiente',NULL),
(169,'C',1,'2016-07-04 00:00:00','0002-07-08 00:00:00','2016-07-04 00:00:00',NULL,1334,94,NULL,0,'Pendiente',NULL),
(170,'C',1,'2016-07-04 00:00:00','0002-07-15 00:00:00','2016-07-04 00:00:00',NULL,1089,95,NULL,0,'Pendiente',NULL),
(171,'C',1,'2016-07-04 00:00:00','0002-07-22 00:00:00','2016-07-04 00:00:00',NULL,1462,92,NULL,0,'Pendiente',NULL),
(172,'C',1,'2016-07-04 00:00:00','0002-07-29 00:00:00','2016-07-04 00:00:00',NULL,411,93,NULL,0,'Pendiente',NULL),
(173,'C',1,'2016-07-04 00:00:00','0002-08-05 00:00:00','2016-07-04 00:00:00',NULL,408,91,NULL,0,'Pendiente',NULL),
(174,'C',1,'2016-07-04 00:00:00','0002-08-12 00:00:00','2016-07-04 00:00:00',NULL,1257,89,NULL,0,'Pendiente',NULL),
(175,'C',1,'2016-07-04 00:00:00','0002-08-19 00:00:00','2016-07-04 00:00:00',NULL,1256,84,NULL,0,'Pendiente',NULL),
(176,'C',1,'2016-07-04 00:00:00','0002-08-26 00:00:00','2016-07-04 00:00:00',NULL,386,88,NULL,0,'Pendiente',NULL),
(177,'C',1,'2016-07-04 00:00:00','0002-09-02 00:00:00','2016-07-04 00:00:00',NULL,1419,87,NULL,0,'Pendiente',NULL),
(178,'C',1,'2016-07-04 00:00:00','0002-09-09 00:00:00','2016-07-04 00:00:00',NULL,407,90,NULL,0,'Pendiente',NULL),
(179,'C',1,'2016-07-04 00:00:00','0002-09-16 00:00:00','2016-07-04 00:00:00',NULL,405,86,NULL,0,'Pendiente',NULL),
(180,'C',1,'2016-07-04 00:00:00','0002-09-23 00:00:00','2016-07-04 00:00:00',NULL,323,3,NULL,0,'Pendiente',NULL),
(181,'C',1,'2016-07-04 00:00:00','0002-09-30 00:00:00','2016-07-04 00:00:00',NULL,1151,4,NULL,0,'Pendiente',NULL),
(182,'C',1,'2016-07-04 00:00:00','0002-10-07 00:00:00','2016-07-04 00:00:00',NULL,324,5,NULL,0,'Pendiente',NULL),
(183,'C',1,'2016-07-04 00:00:00','0002-10-14 00:00:00','2016-07-04 00:00:00',NULL,336,21,NULL,0,'Pendiente',NULL),
(184,'C',1,'2016-07-04 00:00:00','0002-10-21 00:00:00','2016-07-04 00:00:00',NULL,335,20,NULL,0,'Pendiente',NULL),
(185,'C',1,'2016-07-04 00:00:00','0002-10-28 00:00:00','2016-07-04 00:00:00',NULL,1396,7,NULL,0,'Pendiente',NULL),
(186,'C',1,'2016-07-04 00:00:00','0002-11-04 00:00:00','2016-07-04 00:00:00',NULL,325,6,NULL,0,'Pendiente',NULL),
(187,'C',1,'2016-07-04 00:00:00','0002-11-11 00:00:00','2016-07-04 00:00:00',NULL,1418,8,NULL,0,'Pendiente',NULL),
(188,'C',1,'2016-07-04 00:00:00','0002-11-18 00:00:00','2016-07-04 00:00:00',NULL,333,19,NULL,0,'Pendiente',NULL),
(189,'C',1,'2016-07-04 00:00:00','0002-11-25 00:00:00','2016-07-04 00:00:00',NULL,332,18,NULL,0,'Pendiente',NULL),
(190,'C',1,'2016-07-04 00:00:00','0002-12-02 00:00:00','2016-07-04 00:00:00',NULL,1109,15,NULL,0,'Pendiente',NULL),
(191,'C',1,'2016-07-04 00:00:00','0002-12-09 00:00:00','2016-07-04 00:00:00',NULL,330,16,NULL,0,'Pendiente',NULL),
(192,'C',1,'2016-07-04 00:00:00','0002-12-16 00:00:00','2016-07-04 00:00:00',NULL,329,14,NULL,0,'Pendiente',NULL),
(193,'C',1,'2016-07-04 00:00:00','0002-12-23 00:00:00','2016-07-04 00:00:00',NULL,1208,12,NULL,0,'Pendiente',NULL),
(194,'C',1,'2016-07-04 00:00:00','0002-12-30 00:00:00','2016-07-04 00:00:00',NULL,328,13,NULL,0,'Pendiente',NULL),
(195,'C',1,'2016-07-04 00:00:00','0003-01-06 00:00:00','2016-07-04 00:00:00',NULL,327,11,NULL,0,'Pendiente',NULL),
(196,'C',1,'2016-07-04 00:00:00','0003-01-13 00:00:00','2016-07-04 00:00:00',NULL,1215,9,NULL,0,'Pendiente',NULL),
(197,'C',1,'2016-07-04 00:00:00','0003-01-20 00:00:00','2016-07-04 00:00:00',NULL,331,17,NULL,0,'Pendiente',NULL),
(198,'C',1,'2016-07-04 00:00:00','0003-01-27 00:00:00','2016-07-04 00:00:00',NULL,342,28,NULL,0,'Pendiente',NULL),
(199,'C',1,'2016-07-04 00:00:00','0003-02-03 00:00:00','2016-07-04 00:00:00',NULL,341,26,NULL,0,'Pendiente',NULL),
(200,'C',1,'2016-07-04 00:00:00','0003-02-10 00:00:00','2016-07-04 00:00:00',NULL,454,24,NULL,0,'Pendiente',NULL),
(201,'C',1,'2016-07-04 00:00:00','0003-02-17 00:00:00','2016-07-04 00:00:00',NULL,1430,27,NULL,0,'Pendiente',NULL),
(202,'C',1,'2016-07-04 00:00:00','0003-02-24 00:00:00','2016-07-04 00:00:00',NULL,343,29,NULL,0,'Pendiente',NULL),
(203,'C',1,'2016-07-04 00:00:00','0003-03-03 00:00:00','2016-07-04 00:00:00',NULL,344,30,NULL,0,'Pendiente',NULL),
(204,'C',1,'2016-07-04 00:00:00','0003-03-10 00:00:00','2016-07-04 00:00:00',NULL,345,31,NULL,0,'Pendiente',NULL),
(205,'C',1,'2016-07-04 00:00:00','0003-03-17 00:00:00','2016-07-04 00:00:00',NULL,346,32,NULL,0,'Pendiente',NULL),
(206,'C',1,'2016-07-04 00:00:00','0003-03-24 00:00:00','2016-07-04 00:00:00',NULL,1438,33,NULL,0,'Pendiente',NULL),
(207,'C',1,'2016-07-04 00:00:00','0003-03-31 00:00:00','2016-07-04 00:00:00',NULL,348,34,NULL,0,'Pendiente',NULL),
(208,'C',1,'2016-07-04 00:00:00','0003-04-07 00:00:00','2016-07-04 00:00:00',NULL,349,35,NULL,0,'Pendiente',NULL),
(209,'C',1,'2016-07-04 00:00:00','0003-04-14 00:00:00','2016-07-04 00:00:00',NULL,351,37,NULL,0,'Pendiente',NULL),
(210,'C',1,'2016-07-04 00:00:00','0003-04-21 00:00:00','2016-07-04 00:00:00',NULL,350,36,NULL,0,'Pendiente',NULL),
(211,'C',1,'2016-07-04 00:00:00','0003-04-28 00:00:00','2016-07-04 00:00:00',NULL,352,38,NULL,0,'Pendiente',NULL),
(212,'C',1,'2016-07-04 00:00:00','0003-05-05 00:00:00','2016-07-04 00:00:00',NULL,356,43,NULL,0,'Pendiente',NULL),
(213,'C',1,'2016-07-04 00:00:00','0003-05-12 00:00:00','2016-07-04 00:00:00',NULL,1214,39,NULL,0,'Pendiente',NULL),
(214,'C',1,'2016-07-04 00:00:00','0003-05-19 00:00:00','2016-07-04 00:00:00',NULL,359,45,NULL,0,'Pendiente',NULL),
(215,'C',1,'2016-07-04 00:00:00','0003-05-26 00:00:00','2016-07-04 00:00:00',NULL,358,44,NULL,0,'Pendiente',NULL),
(216,'C',1,'2016-07-04 00:00:00','0003-06-02 00:00:00','2016-07-04 00:00:00',NULL,360,46,NULL,0,'Pendiente',NULL),
(217,'C',1,'2016-07-04 00:00:00','0003-06-09 00:00:00','2016-07-04 00:00:00',NULL,361,47,NULL,0,'Pendiente',NULL),
(218,'C',1,'2016-07-04 00:00:00','0003-06-16 00:00:00','2016-07-04 00:00:00',NULL,354,41,NULL,0,'Pendiente',NULL),
(219,'C',1,'2016-07-04 00:00:00','0003-06-23 00:00:00','2016-07-04 00:00:00',NULL,353,40,NULL,0,'Pendiente',NULL),
(220,'C',1,'2016-07-04 00:00:00','0003-06-30 00:00:00','2016-07-04 00:00:00',NULL,719,42,NULL,0,'Pendiente',NULL),
(221,'C',1,'2016-07-04 00:00:00','0003-07-07 00:00:00','2016-07-04 00:00:00',NULL,1413,60,NULL,0,'Pendiente',NULL),
(222,'C',1,'2016-07-04 00:00:00','0003-07-14 00:00:00','2016-07-04 00:00:00',NULL,1330,65,NULL,0,'Pendiente',NULL),
(223,'C',1,'2016-07-04 00:00:00','0003-07-21 00:00:00','2016-07-04 00:00:00',NULL,1329,64,NULL,0,'Pendiente',NULL),
(224,'C',1,'2016-07-04 00:00:00','0003-07-28 00:00:00','2016-07-04 00:00:00',NULL,1152,48,NULL,0,'Pendiente',NULL),
(225,'C',1,'2016-07-04 00:00:00','0003-08-04 00:00:00','2016-07-04 00:00:00',NULL,364,52,NULL,0,'Pendiente',NULL),
(226,'C',1,'2016-07-04 00:00:00','0003-08-11 00:00:00','2016-07-04 00:00:00',NULL,363,50,NULL,0,'Pendiente',NULL),
(227,'C',1,'2016-07-04 00:00:00','0003-08-18 00:00:00','2016-07-04 00:00:00',NULL,362,49,NULL,0,'Pendiente',NULL),
(228,'C',1,'2016-07-04 00:00:00','0003-08-25 00:00:00','2016-07-04 00:00:00',NULL,672,78,NULL,0,'Pendiente',NULL),
(229,'C',1,'2016-07-04 00:00:00','0003-09-01 00:00:00','2016-07-04 00:00:00',NULL,401,79,NULL,0,'Pendiente',NULL),
(230,'C',1,'2016-07-04 00:00:00','0003-09-08 00:00:00','2016-07-04 00:00:00',NULL,1227,83,NULL,0,'Pendiente',NULL),
(231,'C',1,'2016-07-04 00:00:00','0003-09-15 00:00:00','2016-07-04 00:00:00',NULL,404,85,NULL,0,'Pendiente',NULL),
(232,'C',1,'2016-07-04 00:00:00','0003-09-22 00:00:00','2016-07-04 00:00:00',NULL,403,81,NULL,0,'Pendiente',NULL),
(233,'C',1,'2016-07-04 00:00:00','0003-09-29 00:00:00','2016-07-04 00:00:00',NULL,1186,82,NULL,0,'Pendiente',NULL),
(234,'C',1,'2016-07-04 00:00:00','0003-10-06 00:00:00','2016-07-04 00:00:00',NULL,402,80,NULL,0,'Pendiente',NULL),
(235,'C',1,'2016-07-04 00:00:00','0003-10-13 00:00:00','2016-07-04 00:00:00',NULL,382,57,NULL,0,'Pendiente',NULL),
(236,'C',1,'2016-07-04 00:00:00','0003-10-20 00:00:00','2016-07-04 00:00:00',NULL,381,56,NULL,0,'Pendiente',NULL),
(237,'C',1,'2016-07-04 00:00:00','0003-10-27 00:00:00','2016-07-04 00:00:00',NULL,1461,55,NULL,0,'Pendiente',NULL),
(238,'C',1,'2016-07-04 00:00:00','0003-11-03 00:00:00','2016-07-04 00:00:00',NULL,1460,54,NULL,0,'Pendiente',NULL),
(239,'C',1,'2016-07-04 00:00:00','0003-11-10 00:00:00','2016-07-04 00:00:00',NULL,379,51,NULL,0,'Pendiente',NULL),
(240,'C',1,'2016-07-04 00:00:00','0003-11-17 00:00:00','2016-07-04 00:00:00',NULL,383,58,NULL,0,'Pendiente',NULL),
(241,'C',1,'2016-07-04 00:00:00','0003-11-24 00:00:00','2016-07-04 00:00:00',NULL,384,59,NULL,0,'Pendiente',NULL),
(242,'C',1,'2016-07-04 00:00:00','0003-12-01 00:00:00','2016-07-04 00:00:00',NULL,385,62,NULL,0,'Pendiente',NULL),
(243,'C',1,'2016-07-04 00:00:00','0003-12-08 00:00:00','2016-07-04 00:00:00',NULL,1115,61,NULL,0,'Pendiente',NULL),
(244,'C',1,'2016-07-04 00:00:00','0003-12-15 00:00:00','2016-07-04 00:00:00',NULL,380,53,NULL,0,'Pendiente',NULL),
(245,'C',1,'2016-07-04 00:00:00','0003-12-22 00:00:00','2016-07-04 00:00:00',NULL,394,71,NULL,0,'Pendiente',NULL),
(246,'C',1,'2016-07-04 00:00:00','0003-12-29 00:00:00','2016-07-04 00:00:00',NULL,393,70,NULL,0,'Pendiente',NULL),
(247,'C',1,'2016-07-04 00:00:00','0004-01-05 00:00:00','2016-07-04 00:00:00',NULL,392,69,NULL,0,'Pendiente',NULL),
(248,'C',1,'2016-07-04 00:00:00','0004-01-12 00:00:00','2016-07-04 00:00:00',NULL,769,68,NULL,0,'Pendiente',NULL),
(249,'C',1,'2016-07-04 00:00:00','0004-01-19 00:00:00','2016-07-04 00:00:00',NULL,389,66,NULL,0,'Pendiente',NULL),
(250,'C',1,'2016-07-04 00:00:00','0004-01-26 00:00:00','2016-07-04 00:00:00',NULL,390,67,NULL,0,'Pendiente',NULL),
(251,'C',1,'2016-07-04 00:00:00','0004-02-02 00:00:00','2016-07-04 00:00:00',NULL,388,63,NULL,0,'Pendiente',NULL),
(252,'C',1,'2016-07-04 00:00:00','0004-02-09 00:00:00','2016-07-04 00:00:00',NULL,1440,72,NULL,0,'Pendiente',NULL),
(253,'C',1,'2016-07-04 00:00:00','0004-02-16 00:00:00','2016-07-04 00:00:00',NULL,395,73,NULL,0,'Pendiente',NULL),
(254,'C',1,'2016-07-04 00:00:00','0004-02-23 00:00:00','2016-07-04 00:00:00',NULL,396,74,NULL,0,'Pendiente',NULL),
(255,'C',1,'2016-07-04 00:00:00','0004-03-01 00:00:00','2016-07-04 00:00:00',NULL,397,75,NULL,0,'Pendiente',NULL),
(256,'C',1,'2016-07-04 00:00:00','0004-03-08 00:00:00','2016-07-04 00:00:00',NULL,399,76,NULL,0,'Pendiente',NULL),
(257,'C',1,'2016-07-04 00:00:00','0004-03-15 00:00:00','2016-07-04 00:00:00',NULL,1132,77,NULL,0,'Pendiente',NULL),
(258,'C',1,'2016-07-04 00:00:00','0004-03-22 00:00:00','2016-07-04 00:00:00',NULL,1334,94,NULL,0,'Pendiente',NULL),
(259,'C',1,'2016-07-04 00:00:00','0004-03-29 00:00:00','2016-07-04 00:00:00',NULL,1089,95,NULL,0,'Pendiente',NULL),
(260,'C',1,'2016-07-04 00:00:00','0004-04-05 00:00:00','2016-07-04 00:00:00',NULL,1462,92,NULL,0,'Pendiente',NULL),
(261,'C',1,'2016-07-04 00:00:00','0004-04-12 00:00:00','2016-07-04 00:00:00',NULL,411,93,NULL,0,'Pendiente',NULL),
(262,'C',1,'2016-07-04 00:00:00','0004-04-19 00:00:00','2016-07-04 00:00:00',NULL,408,91,NULL,0,'Pendiente',NULL),
(263,'C',1,'2016-07-04 00:00:00','0004-04-26 00:00:00','2016-07-04 00:00:00',NULL,1257,89,NULL,0,'Pendiente',NULL),
(264,'C',1,'2016-07-04 00:00:00','0004-05-03 00:00:00','2016-07-04 00:00:00',NULL,1256,84,NULL,0,'Pendiente',NULL),
(265,'C',1,'2016-07-04 00:00:00','0004-05-10 00:00:00','2016-07-04 00:00:00',NULL,386,88,NULL,0,'Pendiente',NULL),
(266,'C',1,'2016-07-04 00:00:00','0004-05-17 00:00:00','2016-07-04 00:00:00',NULL,1419,87,NULL,0,'Pendiente',NULL),
(267,'C',1,'2016-07-04 00:00:00','0004-05-24 00:00:00','2016-07-04 00:00:00',NULL,407,90,NULL,0,'Pendiente',NULL),
(268,'C',1,'2016-07-04 00:00:00','0004-05-31 00:00:00','2016-07-04 00:00:00',NULL,405,86,NULL,0,'Pendiente',NULL),
(269,'C',0,'2016-07-04 18:20:29','2016-07-04 18:20:29','2016-07-04 18:20:29','',3,0,'',15,NULL,NULL);
/*!40000 ALTER TABLE `facturas` ENABLE KEYS */;

-- 
-- Definition of facturascompras
-- 

DROP TABLE IF EXISTS `facturascompras`;
CREATE TABLE IF NOT EXISTS `facturascompras` (
  `idfacturasCompras` int(11) NOT NULL AUTO_INCREMENT,
  `numFactura` int(11) DEFAULT NULL,
  `tipoFactura` varchar(4) DEFAULT NULL,
  `proveedor` int(11) DEFAULT NULL,
  PRIMARY KEY (`idfacturasCompras`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table facturascompras
-- 

/*!40000 ALTER TABLE `facturascompras` DISABLE KEYS */;

/*!40000 ALTER TABLE `facturascompras` ENABLE KEYS */;

-- 
-- Definition of insumos
-- 

DROP TABLE IF EXISTS `insumos`;
CREATE TABLE IF NOT EXISTS `insumos` (
  `idInsumo` int(11) NOT NULL AUTO_INCREMENT,
  `proveedor` int(11) DEFAULT NULL,
  `rubro` int(11) DEFAULT NULL,
  `marca` int(11) DEFAULT NULL,
  `insumo` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `stockMin` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  `fecha` datetime DEFAULT NULL,
  `medida` int(11) DEFAULT NULL,
  `cantidad` double DEFAULT NULL,
  PRIMARY KEY (`idInsumo`),
  KEY `FK_IRubro_RidRubro_idx` (`rubro`),
  CONSTRAINT `FK_IRubro_RidRubro` FOREIGN KEY (`rubro`) REFERENCES `rubros` (`idRubro`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table insumos
-- 

/*!40000 ALTER TABLE `insumos` DISABLE KEYS */;
INSERT INTO `insumos`(`idInsumo`,`proveedor`,`rubro`,`marca`,`insumo`,`descripcion`,`stockMin`,`estado`,`fecha`,`medida`,`cantidad`) VALUES
(1,1,1,1,'Tapas','Tapitas de plastico para Sodas.',NULL,1,'2016-05-23 19:17:24',1,1),
(2,1,1,1,'Capsulas',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(3,1,1,1,'Agua',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(4,1,1,1,'Gas Carbonico',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(5,1,1,1,'Sifon',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(6,1,1,1,'Bolsa Termocontraible',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(7,1,1,1,'Detergente (Lavado)',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(8,1,1,1,'Precinto Termocontraible',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(9,1,1,1,'Bidon 4LT',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(10,1,1,1,'Bidon 6LT',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(11,1,1,1,'Bidon 10LT',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(12,1,1,1,'Bidon 12LT',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(13,1,1,1,'Bidon 20LT',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(14,1,1,1,'Bidon 25LT',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(15,1,1,1,'Tapas Multiuso',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(16,1,1,1,'Tapas Antiderrame',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(17,1,1,1,'Tapas Bidones',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(18,1,1,1,'Cloro Concentrado Base',NULL,NULL,1,'2016-05-23 19:17:24',4,5),
(19,1,1,1,'Detergente Concentrado Base',NULL,NULL,1,'2016-05-23 19:17:24',4,5),
(20,1,1,1,'Jabon Liquido Concentrado',NULL,NULL,1,'2016-05-23 19:17:24',4,5),
(21,1,1,1,'Desodorante de Piso Concentrado Frutilla',NULL,NULL,1,'2016-05-23 19:17:24',5,500),
(22,1,1,1,'Desodorante de Piso Concentrado Pino',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(23,1,1,1,'Desodorante de Piso Concentrado Citronella',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(24,1,1,1,'Desodorante de Piso Concentrado Arpeage',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(25,1,1,1,'Desodorante de Piso Concentrado Marino',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(26,1,1,1,'Desodorante de Piso Concentrado Lavanda',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(27,1,1,1,'Etiqueta',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(28,1,1,1,'Pegamento',NULL,NULL,1,'2016-05-23 19:17:24',1,1),
(29,1,1,1,'Bidones',NULL,NULL,1,'2016-05-23 19:17:24',4,5);
/*!40000 ALTER TABLE `insumos` ENABLE KEYS */;

-- 
-- Definition of itemscompra
-- 

DROP TABLE IF EXISTS `itemscompra`;
CREATE TABLE IF NOT EXISTS `itemscompra` (
  `iditemsCompra` int(11) NOT NULL AUTO_INCREMENT,
  `compra` int(11) DEFAULT NULL,
  `idInsumo` int(11) DEFAULT NULL,
  `idRubro` int(11) DEFAULT NULL,
  `marca` varchar(45) DEFAULT NULL,
  `precio` double DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `subTotal` double DEFAULT NULL,
  PRIMARY KEY (`iditemsCompra`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table itemscompra
-- 

/*!40000 ALTER TABLE `itemscompra` DISABLE KEYS */;
INSERT INTO `itemscompra`(`iditemsCompra`,`compra`,`idInsumo`,`idRubro`,`marca`,`precio`,`cantidad`,`subTotal`) VALUES
(1,1,9,0,'Ramos Hnos.',26.83,2,53.66),
(2,1,11,0,'Ramos Hnos.',23.68,5,118.4),
(3,2,9,0,'Ramos Hnos.',26.83,3,80.49),
(4,2,11,0,'Ramos Hnos.',23.68,5,118.4);
/*!40000 ALTER TABLE `itemscompra` ENABLE KEYS */;

-- 
-- Definition of itemsfactura
-- 

DROP TABLE IF EXISTS `itemsfactura`;
CREATE TABLE IF NOT EXISTS `itemsfactura` (
  `iditemFactura` int(11) NOT NULL AUTO_INCREMENT,
  `factura` int(11) DEFAULT NULL,
  `producto` int(11) DEFAULT NULL,
  `cantidad` varchar(45) DEFAULT NULL,
  `precioUnitario` varchar(45) DEFAULT NULL,
  `subTotal` varchar(45) DEFAULT NULL,
  `carga` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`iditemFactura`),
  KEY `FK_IFproducto_PidProducto_idx` (`producto`),
  CONSTRAINT `FK_IFproducto_PidProducto` FOREIGN KEY (`producto`) REFERENCES `productos` (`idProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table itemsfactura
-- 

/*!40000 ALTER TABLE `itemsfactura` DISABLE KEYS */;
INSERT INTO `itemsfactura`(`iditemFactura`,`factura`,`producto`,`cantidad`,`precioUnitario`,`subTotal`,`carga`) VALUES
(1,1,7,'2','6','12','C');
/*!40000 ALTER TABLE `itemsfactura` ENABLE KEYS */;

-- 
-- Definition of itemspedido
-- 

DROP TABLE IF EXISTS `itemspedido`;
CREATE TABLE IF NOT EXISTS `itemspedido` (
  `iditemsPedido` int(11) NOT NULL AUTO_INCREMENT,
  `pedido` int(11) DEFAULT NULL,
  `producto` int(11) DEFAULT NULL,
  `cantidad` varchar(45) DEFAULT NULL,
  `precioUnitario` varchar(45) DEFAULT NULL,
  `subTotal` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`iditemsPedido`),
  KEY `FK_itemsPedido_idProducto_idx` (`producto`),
  CONSTRAINT `FK_itemsPedido_idPedido` FOREIGN KEY (`iditemsPedido`) REFERENCES `pedidos` (`idPedidos`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_itemsPedido_idProducto` FOREIGN KEY (`producto`) REFERENCES `productos` (`idProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table itemspedido
-- 

/*!40000 ALTER TABLE `itemspedido` DISABLE KEYS */;

/*!40000 ALTER TABLE `itemspedido` ENABLE KEYS */;

-- 
-- Definition of itemsproduccion
-- 

DROP TABLE IF EXISTS `itemsproduccion`;
CREATE TABLE IF NOT EXISTS `itemsproduccion` (
  `idItemProduccion` int(11) NOT NULL AUTO_INCREMENT,
  `produccion` int(11) DEFAULT NULL,
  `producto` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  PRIMARY KEY (`idItemProduccion`),
  KEY `FK_IPProduccioc_PidProduccion_idx` (`produccion`),
  CONSTRAINT `FK_IPProduccioc_PidProduccion` FOREIGN KEY (`produccion`) REFERENCES `produccion` (`idProduccion`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table itemsproduccion
-- 

/*!40000 ALTER TABLE `itemsproduccion` DISABLE KEYS */;
INSERT INTO `itemsproduccion`(`idItemProduccion`,`produccion`,`producto`,`cantidad`) VALUES
(1,1,1,0),
(2,1,2,0),
(3,1,3,0),
(4,1,4,0),
(5,1,5,0),
(6,1,6,0),
(7,1,7,0),
(8,1,8,0),
(9,1,9,0),
(10,1,10,0),
(11,1,11,0),
(12,2,7,2);
/*!40000 ALTER TABLE `itemsproduccion` ENABLE KEYS */;

-- 
-- Definition of itemsproducto
-- 

DROP TABLE IF EXISTS `itemsproducto`;
CREATE TABLE IF NOT EXISTS `itemsproducto` (
  `idItemProducto` int(11) NOT NULL AUTO_INCREMENT,
  `producto` int(11) NOT NULL,
  `insumo` int(11) DEFAULT NULL,
  `medida` varchar(5) DEFAULT NULL,
  `cantidad` double DEFAULT NULL,
  PRIMARY KEY (`idItemProducto`,`producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table itemsproducto
-- 

/*!40000 ALTER TABLE `itemsproducto` DISABLE KEYS */;

/*!40000 ALTER TABLE `itemsproducto` ENABLE KEYS */;

-- 
-- Definition of itemsrecorrido
-- 

DROP TABLE IF EXISTS `itemsrecorrido`;
CREATE TABLE IF NOT EXISTS `itemsrecorrido` (
  `idcallesRecorrido` int(11) NOT NULL AUTO_INCREMENT,
  `recorrido` int(11) NOT NULL,
  `calle` varchar(45) DEFAULT NULL,
  `desde` int(11) DEFAULT NULL,
  `hasta` int(11) DEFAULT NULL,
  `sentido` varchar(1) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idcallesRecorrido`),
  KEY `FK_CRrecorrido_RidRecorrido_idx` (`recorrido`),
  CONSTRAINT `FK_CRrecorrido_RidRecorrido` FOREIGN KEY (`recorrido`) REFERENCES `recorridos` (`idRecorrido`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=106 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table itemsrecorrido
-- 

/*!40000 ALTER TABLE `itemsrecorrido` DISABLE KEYS */;
INSERT INTO `itemsrecorrido`(`idcallesRecorrido`,`recorrido`,`calle`,`desde`,`hasta`,`sentido`,`estado`) VALUES
(47,6,'255',0,9000,'M',1),
(48,6,'88',0,9000,'M',1),
(49,6,'103',0,9000,'M',1),
(50,6,'66',0,9000,'M',1),
(51,6,'137',0,9000,'M',1),
(54,6,'226',0,9000,'M',1),
(55,6,'234',0,9000,'M',1),
(56,6,'28',0,9000,'M',1),
(57,6,'5',0,9000,'M',1),
(58,6,'259',0,9000,'M',1),
(59,6,'131',0,9000,'M',1),
(60,6,'225',0,9000,'M',1),
(61,6,'4',0,9000,'M',1),
(62,6,'217',0,9000,'M',1),
(63,6,'193',0,9000,'M',1),
(64,6,'185',0,9000,'M',1),
(65,6,'86',0,9000,'M',1),
(66,6,'273',0,9000,'M',1),
(67,6,'67',0,9000,'M',1),
(68,6,'304',0,9000,'M',1),
(69,6,'129',0,9000,'M',1),
(70,6,'53',0,9000,'M',1),
(71,6,'168',0,9000,'M',1),
(72,6,'249',0,9000,'M',1),
(73,6,'133',0,9000,'M',1),
(74,6,'35',0,9000,'M',1),
(75,6,'224',0,9000,'M',1),
(77,6,'179',0,9000,'M',1),
(78,7,'255',0,9000,'M',1),
(79,7,'88',0,9000,'M',1),
(80,7,'103',0,9000,'M',1),
(81,7,'66',0,9000,'M',1),
(82,7,'137',0,9000,'M',1),
(83,7,'226',0,9000,'M',1),
(84,7,'234',0,9000,'M',1),
(85,7,'28',0,9000,'M',1),
(86,7,'5',0,9000,'M',1),
(87,7,'259',0,9000,'M',1),
(88,7,'131',0,9000,'M',1),
(89,7,'225',0,9000,'M',1),
(90,7,'4',0,9000,'M',1),
(91,7,'217',0,9000,'M',1),
(92,7,'193',0,9000,'M',1),
(93,7,'185',0,9000,'M',1),
(94,7,'86',0,9000,'M',1),
(95,7,'273',0,9000,'M',1),
(96,7,'67',0,9000,'M',1),
(97,7,'304',0,9000,'M',1),
(98,7,'129',0,9000,'M',1),
(99,7,'53',0,9000,'M',1),
(100,7,'168',0,9000,'M',1),
(101,7,'249',0,9000,'M',1),
(102,7,'133',0,9000,'M',1),
(103,7,'35',0,9000,'M',1),
(104,7,'224',0,9000,'M',1),
(105,7,'179',0,9000,'M',1);
/*!40000 ALTER TABLE `itemsrecorrido` ENABLE KEYS */;

-- 
-- Definition of itemsreparto
-- 

DROP TABLE IF EXISTS `itemsreparto`;
CREATE TABLE IF NOT EXISTS `itemsreparto` (
  `idItemReparto` int(11) NOT NULL AUTO_INCREMENT,
  `reparto` int(11) DEFAULT NULL,
  `cliente` int(11) DEFAULT NULL,
  `domicilio` int(11) DEFAULT NULL,
  `idComprobante` int(11) DEFAULT NULL,
  `soda` int(11) DEFAULT NULL,
  `agua4` int(11) DEFAULT NULL,
  `agua10` int(11) DEFAULT NULL,
  `agua12` int(11) DEFAULT NULL,
  `agua20` int(11) DEFAULT NULL,
  `agua25` int(11) DEFAULT NULL,
  `cajon` int(11) DEFAULT NULL,
  `canasta` int(11) DEFAULT NULL,
  `pie` int(11) DEFAULT NULL,
  `dispenser` int(11) DEFAULT NULL,
  `saldo` double DEFAULT NULL,
  `itemsRepartocol` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idItemReparto`)
) ENGINE=InnoDB AUTO_INCREMENT=268 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table itemsreparto
-- 

/*!40000 ALTER TABLE `itemsreparto` DISABLE KEYS */;
INSERT INTO `itemsreparto`(`idItemReparto`,`reparto`,`cliente`,`domicilio`,`idComprobante`,`soda`,`agua4`,`agua10`,`agua12`,`agua20`,`agua25`,`cajon`,`canasta`,`pie`,`dispenser`,`saldo`,`itemsRepartocol`) VALUES
(1,1,323,3,1,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(2,1,1151,4,2,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(3,1,324,5,3,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(4,1,336,21,4,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(5,1,335,20,5,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(6,1,1396,7,6,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(7,1,325,6,7,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(8,1,1418,8,8,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(9,1,333,19,9,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(10,1,332,18,10,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(11,1,1109,15,11,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(12,1,330,16,12,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(13,1,329,14,13,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(14,1,1208,12,14,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(15,1,328,13,15,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(16,1,327,11,16,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(17,1,1215,9,17,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(18,1,331,17,18,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(19,1,342,28,19,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(20,1,341,26,20,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(21,1,454,24,21,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(22,1,1430,27,22,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(23,1,343,29,23,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(24,1,344,30,24,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(25,1,345,31,25,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(26,1,346,32,26,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(27,1,1438,33,27,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(28,1,348,34,28,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(29,1,349,35,29,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(30,1,351,37,30,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(31,1,350,36,31,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(32,1,352,38,32,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(33,1,356,43,33,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(34,1,1214,39,34,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(35,1,359,45,35,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(36,1,358,44,36,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(37,1,360,46,37,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(38,1,361,47,38,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(39,1,354,41,39,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(40,1,353,40,40,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(41,1,719,42,41,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(42,1,1413,60,42,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(43,1,1330,65,43,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(44,1,1329,64,44,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(45,1,1152,48,45,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(46,1,364,52,46,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(47,1,363,50,47,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(48,1,362,49,48,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(49,1,672,78,49,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(50,1,401,79,50,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(51,1,1227,83,51,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(52,1,404,85,52,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(53,1,403,81,53,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(54,1,1186,82,54,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(55,1,402,80,55,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(56,1,382,57,56,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(57,1,381,56,57,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(58,1,1461,55,58,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(59,1,1460,54,59,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(60,1,379,51,60,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(61,1,383,58,61,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(62,1,384,59,62,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(63,1,385,62,63,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(64,1,1115,61,64,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(65,1,380,53,65,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(66,1,394,71,66,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(67,1,393,70,67,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(68,1,392,69,68,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(69,1,769,68,69,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(70,1,389,66,70,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(71,1,390,67,71,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(72,1,388,63,72,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(73,1,1440,72,73,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(74,1,395,73,74,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(75,1,396,74,75,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(76,1,397,75,76,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(77,1,399,76,77,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(78,1,1132,77,78,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(79,1,1334,94,79,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(80,1,1089,95,80,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(81,1,1462,92,81,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(82,1,411,93,82,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(83,1,408,91,83,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(84,1,1257,89,84,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(85,1,1256,84,85,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(86,1,386,88,86,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(87,1,1419,87,87,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(88,1,407,90,88,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(89,1,405,86,89,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(90,2,323,3,90,2,0,0,0,0,0,0,0,0,0,NULL,NULL),
(91,2,1151,4,91,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(92,2,324,5,92,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(93,2,336,21,93,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(94,2,335,20,94,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(95,2,1396,7,95,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(96,2,325,6,96,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(97,2,1418,8,97,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(98,2,333,19,98,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(99,2,332,18,99,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(100,2,1109,15,100,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(101,2,330,16,101,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(102,2,329,14,102,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(103,2,1208,12,103,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(104,2,328,13,104,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(105,2,327,11,105,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(106,2,1215,9,106,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(107,2,331,17,107,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(108,2,342,28,108,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(109,2,341,26,109,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(110,2,454,24,110,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(111,2,1430,27,111,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(112,2,343,29,112,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(113,2,344,30,113,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(114,2,345,31,114,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(115,2,346,32,115,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(116,2,1438,33,116,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(117,2,348,34,117,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(118,2,349,35,118,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(119,2,351,37,119,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(120,2,350,36,120,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(121,2,352,38,121,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(122,2,356,43,122,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(123,2,1214,39,123,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(124,2,359,45,124,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(125,2,358,44,125,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(126,2,360,46,126,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(127,2,361,47,127,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(128,2,354,41,128,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(129,2,353,40,129,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(130,2,719,42,130,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(131,2,1413,60,131,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(132,2,1330,65,132,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(133,2,1329,64,133,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(134,2,1152,48,134,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(135,2,364,52,135,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(136,2,363,50,136,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(137,2,362,49,137,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(138,2,672,78,138,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(139,2,401,79,139,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(140,2,1227,83,140,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(141,2,404,85,141,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(142,2,403,81,142,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(143,2,1186,82,143,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(144,2,402,80,144,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(145,2,382,57,145,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(146,2,381,56,146,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(147,2,1461,55,147,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(148,2,1460,54,148,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(149,2,379,51,149,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(150,2,383,58,150,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(151,2,384,59,151,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(152,2,385,62,152,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(153,2,1115,61,153,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(154,2,380,53,154,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(155,2,394,71,155,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(156,2,393,70,156,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(157,2,392,69,157,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(158,2,769,68,158,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(159,2,389,66,159,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(160,2,390,67,160,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(161,2,388,63,161,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(162,2,1440,72,162,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(163,2,395,73,163,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(164,2,396,74,164,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(165,2,397,75,165,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(166,2,399,76,166,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(167,2,1132,77,167,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(168,2,1334,94,168,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(169,2,1089,95,169,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(170,2,1462,92,170,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(171,2,411,93,171,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(172,2,408,91,172,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(173,2,1257,89,173,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(174,2,1256,84,174,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(175,2,386,88,175,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(176,2,1419,87,176,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(177,2,407,90,177,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(178,2,405,86,178,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(179,3,323,3,179,2,0,0,0,0,0,0,0,0,0,NULL,NULL),
(180,3,1151,4,180,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(181,3,324,5,181,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(182,3,336,21,182,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(183,3,335,20,183,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(184,3,1396,7,184,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(185,3,325,6,185,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(186,3,1418,8,186,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(187,3,333,19,187,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(188,3,332,18,188,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(189,3,1109,15,189,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(190,3,330,16,190,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(191,3,329,14,191,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(192,3,1208,12,192,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(193,3,328,13,193,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(194,3,327,11,194,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(195,3,1215,9,195,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(196,3,331,17,196,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(197,3,342,28,197,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(198,3,341,26,198,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(199,3,454,24,199,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(200,3,1430,27,200,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(201,3,343,29,201,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(202,3,344,30,202,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(203,3,345,31,203,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(204,3,346,32,204,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(205,3,1438,33,205,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(206,3,348,34,206,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(207,3,349,35,207,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(208,3,351,37,208,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(209,3,350,36,209,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(210,3,352,38,210,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(211,3,356,43,211,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(212,3,1214,39,212,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(213,3,359,45,213,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(214,3,358,44,214,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(215,3,360,46,215,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(216,3,361,47,216,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(217,3,354,41,217,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(218,3,353,40,218,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(219,3,719,42,219,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(220,3,1413,60,220,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(221,3,1330,65,221,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(222,3,1329,64,222,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(223,3,1152,48,223,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(224,3,364,52,224,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(225,3,363,50,225,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(226,3,362,49,226,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(227,3,672,78,227,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(228,3,401,79,228,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(229,3,1227,83,229,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(230,3,404,85,230,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(231,3,403,81,231,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(232,3,1186,82,232,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(233,3,402,80,233,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(234,3,382,57,234,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(235,3,381,56,235,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(236,3,1461,55,236,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(237,3,1460,54,237,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(238,3,379,51,238,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(239,3,383,58,239,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(240,3,384,59,240,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(241,3,385,62,241,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(242,3,1115,61,242,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(243,3,380,53,243,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(244,3,394,71,244,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(245,3,393,70,245,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(246,3,392,69,246,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(247,3,769,68,247,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(248,3,389,66,248,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(249,3,390,67,249,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(250,3,388,63,250,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(251,3,1440,72,251,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(252,3,395,73,252,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(253,3,396,74,253,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(254,3,397,75,254,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(255,3,399,76,255,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(256,3,1132,77,256,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(257,3,1334,94,257,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(258,3,1089,95,258,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(259,3,1462,92,259,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(260,3,411,93,260,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(261,3,408,91,261,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(262,3,1257,89,262,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(263,3,1256,84,263,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(264,3,386,88,264,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(265,3,1419,87,265,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(266,3,407,90,266,0,0,0,0,0,0,0,0,0,0,NULL,NULL),
(267,3,405,86,267,0,0,0,0,0,0,0,0,0,0,NULL,NULL);
/*!40000 ALTER TABLE `itemsreparto` ENABLE KEYS */;

-- 
-- Definition of localidades
-- 

DROP TABLE IF EXISTS `localidades`;
CREATE TABLE IF NOT EXISTS `localidades` (
  `idLocalidad` int(11) NOT NULL AUTO_INCREMENT,
  `idProvincia` int(11) DEFAULT NULL,
  `Localidad` varchar(60) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idLocalidad`),
  KEY `FK_Provincia_idProvincia_idx` (`idProvincia`),
  CONSTRAINT `FK_locProvincia_idProvincia` FOREIGN KEY (`idProvincia`) REFERENCES `provincias` (`idProvincia`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=175 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table localidades
-- 

/*!40000 ALTER TABLE `localidades` DISABLE KEYS */;
INSERT INTO `localidades`(`idLocalidad`,`idProvincia`,`Localidad`,`estado`) VALUES
(1,5,'Achiras',1),
(2,5,'Adelia Maria',1),
(3,5,'Alcira (Estacion Gigena)',1),
(4,5,'Alejandro Roca',1),
(5,5,'Alejo Ledesma',1),
(6,5,'Alicia (Cordoba)',1),
(7,5,'Almafuerte (Cordoba)',1),
(8,5,'Alta Gracia',1),
(9,5,'Alto Resbaloso - El Barrial',1),
(10,5,'Anisacate',1),
(11,5,'Arias (Cordoba)',1),
(12,5,'Arroyito',1),
(13,5,'Arroyo Cabral',1),
(14,5,'Ballesteros (Cordoba)',1),
(15,5,'Balnearia',1),
(16,5,'Berrotaran (Cordoba)',1),
(17,5,'Bialet Masse',1),
(18,5,'Brinkmann',1),
(19,5,'Calchin (Cordoba)',1),
(20,5,'Camilo Aldao',1),
(21,5,'Canals (Cordoba)',1),
(22,5,'Capilla del Monte',1),
(23,5,'Casa Grande (Cordoba)',1),
(24,5,'Colonia Caroya',1),
(25,5,'Colonia La Argentina (Dto  Gral  Roca)',1),
(26,5,'Cordoba (Capital)',1),
(27,5,'Coronel Moldes (Cordoba)',1),
(28,5,'Corral de Bustos',1),
(29,5,'Cosquin',1),
(30,5,'Country Chacras de la Villa - Country San Isidro',1),
(31,5,'Cruz Alta (Cordoba)',1),
(32,5,'Cuesta Blanca (Argentina)',1),
(33,5,'Dean Funes (Cordoba)',1),
(34,5,'Del Campillo',1),
(35,5,'Despeñaderos',1),
(36,5,'Devoto (Cordoba)',1),
(37,5,'El Pueblito (San Javier)',1),
(38,5,'El Valle (Argentina)',1),
(39,5,'Elena (Cordoba)',1),
(40,5,'Embalse (Cordoba)',1),
(41,5,'Estacion Juarez Celman',1),
(42,5,'Estancia Vieja',1),
(43,5,'Etruria (Cordoba)',1),
(44,5,'Freyre',1),
(45,5,'General Baldissera',1),
(46,5,'General Cabrera',1),
(47,5,'General Deheza',1),
(48,5,'General Levalle',1),
(49,5,'Guatimozin (Cordoba)',1),
(50,5,'Hernando (Cordoba)',1),
(51,5,'Huerta Grande',1),
(52,5,'Huinca Renanco',1),
(53,5,'Inriville',1),
(54,5,'Isla Verde (Argentina)',1),
(55,5,'James Craik',1),
(56,5,'Jesus Maria (Argentina)',1),
(57,5,'Jose de la Quintana (Cordoba)',1),
(58,5,'Jovita (Cordoba)',1),
(59,5,'Justiniano Posse (Cordoba)',1),
(60,5,'La Carlota (Argentina)',1),
(61,5,'La Cumbre (Cordoba)',1),
(62,5,'La Cumbrecita',1),
(63,5,'La Falda',1),
(64,5,'La Francia',1),
(65,5,'La Para',1),
(66,5,'La Paz (Totoral)',1),
(67,5,'La Perla (Cordoba)',1),
(68,5,'La Poblacion (Cordoba)',1),
(69,5,'La Rancherita',1),
(70,5,'La Serranita',1),
(71,5,'Laborde',1),
(72,5,'Laboulaye',1),
(73,5,'Laguna Larga',1),
(74,5,'Las Acequias',1),
(75,5,'Las Chacras (La Paz)',1),
(76,5,'Las Chacras (Villa de las Rosas)',1),
(77,5,'Las Higueras',1),
(78,5,'Las Perdices',1),
(79,5,'Las Tapias (Cordoba)',1),
(80,5,'Leones',1),
(81,5,'Los Cerrillos (Cordoba)',1),
(82,5,'Los Cocos',1),
(83,5,'Los Condores (Cordoba)',1),
(84,5,'Los Romeros (Argentina)',1),
(85,5,'Los Surgentes',1),
(86,5,'Luque (Argentina)',1),
(87,5,'Malagueño (Argentina)',1),
(88,5,'Malvinas Argentinas (Cordoba)',1),
(89,5,'Marcos Juarez',1),
(90,5,'Mayu Sumaj',1),
(91,5,'Mi Granja',1),
(92,5,'Mina Clavero',1),
(93,5,'Monte Buey',1),
(94,5,'Monte Cristo',1),
(95,5,'Monte Maiz',1),
(96,5,'Morrison (Cordoba)',1),
(97,5,'Morteros',1),
(98,5,'Noetinger',1),
(99,5,'Oliva (Cordoba)',1),
(100,5,'Oncativo',1),
(101,5,'Ordoñez (Argentina)',1),
(102,5,'Pascanas',1),
(103,5,'Paso del Durazno',1),
(104,5,'Pilar (Cordoba)',1),
(105,5,'La Playosa',1),
(106,5,'Porteña',1),
(107,5,'Pozo del Molle',1),
(108,5,'Quilino',1),
(109,5,'Quisquisacate',1),
(110,5,'Rio Primero (Cordoba)',1),
(111,5,'Rio Segundo (ciudad)',1),
(112,5,'Ciudad de Rio Tercero',1),
(113,5,'Rumi Huasi',1),
(114,5,'Sacanta',1),
(115,5,'Sampacho',1),
(116,5,'San Agustin (Cordoba)',1),
(117,5,'San Antonio de Arredondo',1),
(118,5,'San Basilio (Cordoba)',1),
(119,5,'San Esteban (Cordoba)',1),
(120,5,'San Francisco (Cordoba)',1),
(121,5,'San Francisco del Chañar',1),
(122,5,'San Jose de La Dormida',1),
(123,5,'San Marcos Sud',1),
(124,5,'San Pedro (Cordoba)',1),
(125,5,'San Roque (Cordoba)',1),
(126,5,'Santa Catalina (Rio Cuarto)',1),
(127,5,'Santa Elena (Colon)',1),
(128,5,'Santa Maria de Punilla',1),
(129,5,'Santa Monica (Argentina)',1),
(130,5,'Santa Rosa de Calamuchita',1),
(131,5,'Santa Rosa de Rio Primero',1),
(132,5,'Santiago Temple',1),
(133,5,'Saturnino Maria Laspiur (Cordoba)',1),
(134,5,'Sebastian Elcano (Cordoba)',1),
(135,5,'Serrano (Cordoba)',1),
(136,5,'Serrezuela (Argentina)',1),
(137,5,'Tala Huasi',1),
(138,5,'Tancacha',1),
(139,5,'Tanti',1),
(140,5,'Tio Pujio',1),
(141,5,'Toledo (Cordoba)',1),
(142,5,'Transito (Cordoba)',1),
(143,5,'Trinchera (Argentina)',1),
(144,5,'Tronco Pozo',1),
(145,5,'Ucacha',1),
(146,5,'Valle de Anisacate',1),
(147,5,'Valle Hermoso (Cordoba)',1),
(148,5,'Vicuña Mackenna (Argentina)',1),
(149,5,'Villa Ascasubi',1),
(150,5,'Villa Carlos Paz',1),
(151,5,'Villa Cura Brochero',1),
(152,5,'Villa de Las Rosas',1),
(153,5,'Villa de los Ranchos',1),
(154,5,'Villa de Maria',1),
(155,5,'Villa de Soto',1),
(156,5,'Villa del Dique',1),
(157,5,'Villa del Rosario (Cordoba)',1),
(158,5,'Villa del Totoral',1),
(159,5,'Villa Dolores (Cordoba)',1),
(160,5,'Villa General Belgrano',1),
(161,5,'Villa Giardino',1),
(162,5,'Villa Huidobro',1),
(163,5,'Villa Icho Cruz',1),
(164,5,'Villa La Bolsa',1),
(165,5,'Villa Los Aromos',1),
(166,5,'Villa Los Llanos',1),
(167,5,'Villa Nueva (Cordoba)',1),
(168,5,'Villa Parque Siquiman',1),
(169,5,'Villa Reduccion',1),
(170,5,'Villa Rumipal',1),
(171,5,'Villa San Nicolas',1),
(172,5,'Villa Santa Cruz del Lago',1),
(173,5,'Villa Sarmiento (San Alberto)',1),
(174,5,'Villa Valeria',1);
/*!40000 ALTER TABLE `localidades` ENABLE KEYS */;

-- 
-- Definition of marcas
-- 

DROP TABLE IF EXISTS `marcas`;
CREATE TABLE IF NOT EXISTS `marcas` (
  `idmarca` int(11) NOT NULL AUTO_INCREMENT,
  `marca` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idmarca`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table marcas
-- 

/*!40000 ALTER TABLE `marcas` DISABLE KEYS */;
INSERT INTO `marcas`(`idmarca`,`marca`,`estado`) VALUES
(1,'Ramos Hnos.',1);
/*!40000 ALTER TABLE `marcas` ENABLE KEYS */;

-- 
-- Definition of medidas
-- 

DROP TABLE IF EXISTS `medidas`;
CREATE TABLE IF NOT EXISTS `medidas` (
  `idMedida` int(11) NOT NULL AUTO_INCREMENT,
  `medida` varchar(20) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idMedida`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table medidas
-- 

/*!40000 ALTER TABLE `medidas` DISABLE KEYS */;
INSERT INTO `medidas`(`idMedida`,`medida`,`estado`) VALUES
(1,'Unidad',1),
(2,'cm3',1),
(3,'KG',1),
(4,'LT',1),
(5,'ML',1);
/*!40000 ALTER TABLE `medidas` ENABLE KEYS */;

-- 
-- Definition of orden
-- 

DROP TABLE IF EXISTS `orden`;
CREATE TABLE IF NOT EXISTS `orden` (
  `idOrden` int(11) NOT NULL,
  `olunes` int(11) DEFAULT '0',
  `omartes` int(11) DEFAULT '0',
  `omiercoles` int(11) DEFAULT '0',
  `ojueves` int(11) DEFAULT '0',
  `oviernes` int(11) DEFAULT '0',
  `osabado` int(11) DEFAULT '0',
  `odomingo` int(11) DEFAULT NULL,
  PRIMARY KEY (`idOrden`),
  CONSTRAINT `FK_OidOrden_vidVisita` FOREIGN KEY (`idOrden`) REFERENCES `visitas` (`idVisita`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table orden
-- 

/*!40000 ALTER TABLE `orden` DISABLE KEYS */;

/*!40000 ALTER TABLE `orden` ENABLE KEYS */;

-- 
-- Definition of pedidos
-- 

DROP TABLE IF EXISTS `pedidos`;
CREATE TABLE IF NOT EXISTS `pedidos` (
  `idPedidos` int(11) NOT NULL AUTO_INCREMENT,
  `idPersona` int(11) DEFAULT NULL,
  `rol` int(11) DEFAULT NULL,
  `domicilio` varchar(45) DEFAULT NULL,
  `tipoPedido` varchar(45) DEFAULT NULL,
  `fechaPedido` date DEFAULT NULL,
  `fechaEntrega` date DEFAULT NULL,
  `observaciones` varchar(45) DEFAULT NULL,
  `total` double DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idPedidos`),
  KEY `FK_Cliente_idCliente_idx` (`idPersona`),
  CONSTRAINT `FK_Cliente_idCliente` FOREIGN KEY (`idPersona`) REFERENCES `clientes` (`idCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table pedidos
-- 

/*!40000 ALTER TABLE `pedidos` DISABLE KEYS */;

/*!40000 ALTER TABLE `pedidos` ENABLE KEYS */;

-- 
-- Definition of precioinsumos
-- 

DROP TABLE IF EXISTS `precioinsumos`;
CREATE TABLE IF NOT EXISTS `precioinsumos` (
  `idPrecioInsumo` int(11) NOT NULL AUTO_INCREMENT,
  `idInsumo` int(11) DEFAULT NULL,
  `fechaActualizacion` datetime DEFAULT NULL,
  `precio` double DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idPrecioInsumo`),
  KEY `FK_PPinsumi_idInsumo_idx` (`idInsumo`),
  CONSTRAINT `FK_PPinsumi_idInsumo` FOREIGN KEY (`idInsumo`) REFERENCES `insumos` (`idInsumo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table precioinsumos
-- 

/*!40000 ALTER TABLE `precioinsumos` DISABLE KEYS */;
INSERT INTO `precioinsumos`(`idPrecioInsumo`,`idInsumo`,`fechaActualizacion`,`precio`,`estado`) VALUES
(1,1,'2016-03-01 19:12:36',12.3,1),
(2,2,'2016-03-01 19:12:36',50.23,1),
(3,3,'2016-03-01 19:12:36',22.77,1),
(4,4,'2016-03-01 19:12:36',73.84,1),
(5,5,'2016-03-01 19:12:36',34.23,1),
(6,6,'2016-03-01 19:12:36',37.23,1),
(7,7,'2016-03-01 19:12:36',12.78,1),
(8,8,'2016-03-01 19:12:36',67.34,1),
(9,9,'2016-03-01 19:12:36',26.83,1),
(10,10,'2016-03-01 19:12:36',34.31,1),
(11,11,'2016-03-01 19:12:36',23.68,1),
(12,12,'2016-03-01 19:12:36',45.84,1),
(13,13,'2016-03-01 19:12:36',96.45,1),
(14,14,'2016-03-01 19:12:36',45.84,1),
(15,15,'2016-03-01 19:12:36',32.64,1),
(16,16,'2016-03-01 19:12:36',34.32,1),
(17,17,'2016-03-01 19:12:36',12.24,1),
(18,18,'2016-03-01 19:12:36',23.78,1),
(19,19,'2016-03-01 19:12:36',34.87,1),
(20,20,'2016-03-01 19:12:36',23.54,1),
(21,21,'2016-03-01 19:12:36',34.76,1),
(22,22,'2016-03-01 19:12:36',23.76,1),
(23,23,'2016-03-01 19:12:36',27.33,1),
(24,24,'2016-03-01 19:12:36',34.12,1),
(25,25,'2016-03-01 19:12:36',634.23,1),
(26,26,'2016-03-01 19:12:36',57.33,1),
(27,27,'2016-03-01 19:12:36',23.734,1),
(28,28,'2016-03-01 19:12:36',12.56,1),
(29,29,'2016-03-01 19:12:36',23.76,1);
/*!40000 ALTER TABLE `precioinsumos` ENABLE KEYS */;

-- 
-- Definition of precioproductos
-- 

DROP TABLE IF EXISTS `precioproductos`;
CREATE TABLE IF NOT EXISTS `precioproductos` (
  `idPrecioProducto` int(11) NOT NULL AUTO_INCREMENT,
  `idProducto` int(11) DEFAULT NULL,
  `fechaActualizacion` datetime DEFAULT NULL,
  `precio` double DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idPrecioProducto`),
  KEY `FK_producto_idProducto_idx` (`idProducto`),
  CONSTRAINT `FK_PPproducto_idProducto` FOREIGN KEY (`idProducto`) REFERENCES `productos` (`idProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table precioproductos
-- 

/*!40000 ALTER TABLE `precioproductos` DISABLE KEYS */;
INSERT INTO `precioproductos`(`idPrecioProducto`,`idProducto`,`fechaActualizacion`,`precio`,`estado`) VALUES
(1,1,'2016-07-02 00:00:00',13,1),
(2,2,'2016-07-02 00:00:00',20,1),
(3,3,'2016-07-02 00:00:00',30,0),
(4,4,'2016-07-02 00:00:00',36,1),
(5,5,'2016-07-02 00:00:00',50,1),
(6,6,'2016-07-02 00:00:00',60,1),
(7,7,'2016-07-02 00:00:00',6,1),
(8,8,'2016-07-02 00:00:00',1,1),
(9,9,'2016-07-02 00:00:00',1,1),
(10,10,'2016-07-02 00:00:00',1,1),
(11,11,'2016-07-02 00:00:00',1,1),
(12,12,'2016-07-02 00:00:00',6,1),
(13,13,'2016-07-02 00:00:00',7.5,1),
(14,14,'2016-07-02 00:00:00',80,1),
(15,15,'2016-07-02 00:00:00',110,1),
(16,16,'2016-07-02 00:00:00',40,1),
(17,17,'2016-07-02 00:00:00',30,1),
(18,3,'2016-07-04 17:29:51',20.423,1);
/*!40000 ALTER TABLE `precioproductos` ENABLE KEYS */;

-- 
-- Definition of privilegios
-- 

DROP TABLE IF EXISTS `privilegios`;
CREATE TABLE IF NOT EXISTS `privilegios` (
  `idPrivilegio` int(11) NOT NULL AUTO_INCREMENT,
  `privilegio` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idPrivilegio`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table privilegios
-- 

/*!40000 ALTER TABLE `privilegios` DISABLE KEYS */;
INSERT INTO `privilegios`(`idPrivilegio`,`privilegio`,`estado`) VALUES
(1,'Administrador',1),
(2,'Gerente',1),
(3,'Contador',1),
(4,'RRHH',1),
(5,'Marketing',1),
(6,'Mantenimiento',1),
(7,'Produccion',1),
(8,'Compras',1),
(9,'Ventas',1);
/*!40000 ALTER TABLE `privilegios` ENABLE KEYS */;

-- 
-- Definition of produccion
-- 

DROP TABLE IF EXISTS `produccion`;
CREATE TABLE IF NOT EXISTS `produccion` (
  `idProduccion` int(11) NOT NULL AUTO_INCREMENT,
  `fechaProduccion` date DEFAULT NULL,
  `descripcion` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`idProduccion`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table produccion
-- 

/*!40000 ALTER TABLE `produccion` DISABLE KEYS */;
INSERT INTO `produccion`(`idProduccion`,`fechaProduccion`,`descripcion`) VALUES
(1,'2016-04-04 00:00:00','Produccion Inicial'),
(2,'2016-07-03 00:00:00','');
/*!40000 ALTER TABLE `produccion` ENABLE KEYS */;

-- 
-- Definition of productos
-- 

DROP TABLE IF EXISTS `productos`;
CREATE TABLE IF NOT EXISTS `productos` (
  `idProducto` int(11) NOT NULL AUTO_INCREMENT,
  `fechaAlta` date DEFAULT NULL,
  `rubro` int(11) DEFAULT NULL,
  `marca` int(11) DEFAULT NULL,
  `producto` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `cantidad` double DEFAULT NULL,
  `medida` int(11) DEFAULT NULL,
  `estado` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`idProducto`),
  KEY `FK_medida_idMedido_idx` (`medida`),
  KEY `FK_pmarca_midMarca_idx` (`marca`),
  CONSTRAINT `FK_medida_idMedido` FOREIGN KEY (`medida`) REFERENCES `medidas` (`idMedida`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_pmarca_midMarca` FOREIGN KEY (`marca`) REFERENCES `marcas` (`idmarca`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table productos
-- 

/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos`(`idProducto`,`fechaAlta`,`rubro`,`marca`,`producto`,`descripcion`,`cantidad`,`medida`,`estado`) VALUES
(1,'2016-02-23 00:00:00',1,1,'Agua Retornable 4LTs','Agua Retornable 4LTs',4,4,'1'),
(2,'2016-04-21 00:00:00',1,1,'Agua Descartable 6LTs','Agua Descartable 6LTs',6,4,'1'),
(3,'2016-04-17 00:00:00',1,1,'Agua Retornable 10LTs','Agua Retornable 10LTs',10,4,'1'),
(4,'2016-01-27 00:00:00',1,1,'Agua Retornable 12LTs','Agua Retornable 12LTs',12,4,'1'),
(5,'2016-03-12 00:00:00',1,1,'Agua Retornable 20LTs','Agua Retornable 20LTs',20,4,'1'),
(6,'2016-01-23 00:00:00',1,1,'Agua Retornable 25LTs','Agua Retornable 25LTs',25,4,'1'),
(7,'2016-05-21 00:00:00',1,1,'Soda 1 y 1/4 Lts','Soda 1 y 1/4 Lts',1,4,'1'),
(8,'2016-02-02 00:00:00',1,1,'Cajon','Cajon',1,1,'1'),
(9,'2016-02-13 00:00:00',1,1,'Canasta','Canasta',1,1,'1'),
(10,'2016-03-28 00:00:00',1,1,'Pie','Pie',1,1,'1'),
(11,'2016-02-29 00:00:00',1,1,'Dispenser','Dispenser',1,1,'1'),
(12,'2016-06-24 00:00:00',1,1,'Soda 1/2 Lts','Soda 1/2 Lts',1,4,'1'),
(13,'2016-05-28 00:00:00',1,1,'Ramos','Ramos',1,4,'1'),
(14,'2016-02-19 00:00:00',1,1,'Detergente','Detergente',1,4,'1'),
(15,'2016-03-02 00:00:00',1,1,'Jabon','Jabon',1,4,'1'),
(16,'2016-02-07 00:00:00',1,1,'Lavandina','Lavandina',1,4,'1'),
(17,'2016-03-17 00:00:00',1,1,'Perfumina','Perfumina',1,4,'1');
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;

-- 
-- Definition of proveedores
-- 

DROP TABLE IF EXISTS `proveedores`;
CREATE TABLE IF NOT EXISTS `proveedores` (
  `idProveedor` int(11) NOT NULL AUTO_INCREMENT,
  `rol` int(11) DEFAULT NULL,
  `razonSocial` varchar(45) DEFAULT NULL,
  `cuit` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  `condicionIVA` varchar(45) DEFAULT NULL,
  `fechaAlta` datetime DEFAULT NULL,
  `debMAX` double DEFAULT NULL,
  PRIMARY KEY (`idProveedor`),
  KEY `FK_rolProv_idRol_idx` (`rol`),
  CONSTRAINT `FK_rolProv_idRol` FOREIGN KEY (`rol`) REFERENCES `roles` (`idRol`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table proveedores
-- 

/*!40000 ALTER TABLE `proveedores` DISABLE KEYS */;
INSERT INTO `proveedores`(`idProveedor`,`rol`,`razonSocial`,`cuit`,`email`,`estado`,`condicionIVA`,`fechaAlta`,`debMAX`) VALUES
(1,NULL,'Praxair SA','30662067691',NULL,1,'Responsable Inscripto','2016-04-17 00:00:00',NULL),
(2,NULL,'Aguas Cordobesas','33689822989',NULL,1,'Responsable Inscripto','2016-06-15 00:00:00',NULL),
(3,NULL,'Favisa','30708872853',NULL,1,'Responsable Inscripto','2016-02-23 00:00:00',NULL),
(4,NULL,'LineWater','30698743234',NULL,1,'Responsable Inscripto','2016-03-25 00:00:00',NULL),
(5,NULL,'Star Plastic SA','30763798623',NULL,1,'Responsable Inscripto','2016-02-12 00:00:00',NULL),
(6,NULL,'Aeroplastik','30653282934',NULL,1,'Responsable Inscripto','2016-04-19 00:00:00',NULL),
(7,NULL,'Benito Gráfica','30664176297',NULL,1,'Responsable Inscripto','2016-01-25 00:00:00',NULL),
(8,NULL,'El Rey de la Limpieza','30676289546',NULL,1,'Responsable Inscripto','2016-05-04 00:00:00',NULL);
/*!40000 ALTER TABLE `proveedores` ENABLE KEYS */;

-- 
-- Definition of provincias
-- 

DROP TABLE IF EXISTS `provincias`;
CREATE TABLE IF NOT EXISTS `provincias` (
  `idProvincia` int(11) NOT NULL AUTO_INCREMENT,
  `Provincia` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idProvincia`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table provincias
-- 

/*!40000 ALTER TABLE `provincias` DISABLE KEYS */;
INSERT INTO `provincias`(`idProvincia`,`Provincia`,`estado`) VALUES
(1,'Buenos Aires',1),
(2,'Catamarca',1),
(3,'Chaco',1),
(4,'Chubut',1),
(5,'Córdoba',1),
(6,'Corrientes',1),
(7,'Entre Rios',1),
(8,'Formosa',1),
(9,'Jujuy',1),
(10,'La Pampa',1),
(11,'La Rioja',1),
(12,'Mendoza',1),
(13,'Misiones',1),
(14,'Neuquén',1),
(15,'Río Negro',1),
(16,'Salta',1),
(17,'San Juan',1),
(18,'San Luis',1),
(19,'Santa Cruz',1),
(20,'Santa Fe',1),
(21,'Santiago del Estero',1),
(22,'Tierra del Fuego',1),
(23,'Tucumán',1);
/*!40000 ALTER TABLE `provincias` ENABLE KEYS */;

-- 
-- Definition of provinsumo
-- 

DROP TABLE IF EXISTS `provinsumo`;
CREATE TABLE IF NOT EXISTS `provinsumo` (
  `Proveedor` int(11) NOT NULL,
  `Insumo` int(11) NOT NULL,
  PRIMARY KEY (`Proveedor`,`Insumo`),
  KEY `FK_piInsu_idInsu_idx` (`Insumo`),
  CONSTRAINT `FK_piInsu_idInsu` FOREIGN KEY (`Insumo`) REFERENCES `insumos` (`idInsumo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_piProv_idProv` FOREIGN KEY (`Proveedor`) REFERENCES `proveedores` (`idProveedor`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table provinsumo
-- 

/*!40000 ALTER TABLE `provinsumo` DISABLE KEYS */;

/*!40000 ALTER TABLE `provinsumo` ENABLE KEYS */;

-- 
-- Definition of recorridos
-- 

DROP TABLE IF EXISTS `recorridos`;
CREATE TABLE IF NOT EXISTS `recorridos` (
  `idRecorrido` int(11) NOT NULL AUTO_INCREMENT,
  `distribuidor` int(11) DEFAULT NULL,
  `dia` varchar(2) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idRecorrido`),
  KEY `FK_Rdistribuidor_DidDistribuidor_idx` (`distribuidor`),
  CONSTRAINT `FK_Rdistribuidor_DidDistribuidor` FOREIGN KEY (`distribuidor`) REFERENCES `distribuidores` (`idDistribuidor`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table recorridos
-- 

/*!40000 ALTER TABLE `recorridos` DISABLE KEYS */;
INSERT INTO `recorridos`(`idRecorrido`,`distribuidor`,`dia`,`estado`) VALUES
(6,1,'Lu',1),
(7,1,'Ma',1);
/*!40000 ALTER TABLE `recorridos` ENABLE KEYS */;

-- 
-- Definition of repartos
-- 

DROP TABLE IF EXISTS `repartos`;
CREATE TABLE IF NOT EXISTS `repartos` (
  `idReparto` int(11) NOT NULL AUTO_INCREMENT,
  `distribuidor` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `dia` varchar(15) DEFAULT NULL,
  `turno` varchar(1) DEFAULT NULL,
  `generado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idReparto`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table repartos
-- 

/*!40000 ALTER TABLE `repartos` DISABLE KEYS */;
INSERT INTO `repartos`(`idReparto`,`distribuidor`,`fecha`,`dia`,`turno`,`generado`) VALUES
(1,1,'2016-07-03 00:00:00','Lu',NULL,NULL),
(2,1,'2016-07-04 00:00:00','Lu',NULL,NULL),
(3,1,'2016-07-04 00:00:00','Lu',NULL,NULL);
/*!40000 ALTER TABLE `repartos` ENABLE KEYS */;

-- 
-- Definition of roles
-- 

DROP TABLE IF EXISTS `roles`;
CREATE TABLE IF NOT EXISTS `roles` (
  `idRol` int(11) NOT NULL AUTO_INCREMENT,
  `rol` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idRol`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table roles
-- 

/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles`(`idRol`,`rol`,`estado`) VALUES
(1,'Cliente',1),
(2,'Proveedor',1),
(3,'Distribuidores',1);
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;

-- 
-- Definition of rubroproveedores
-- 

DROP TABLE IF EXISTS `rubroproveedores`;
CREATE TABLE IF NOT EXISTS `rubroproveedores` (
  `Proveedor` int(11) NOT NULL,
  `Rubro` int(11) DEFAULT NULL,
  PRIMARY KEY (`Proveedor`),
  KEY `FK_RPrubro_RidRubro_idx` (`Rubro`),
  CONSTRAINT `FK_RPproveedor_PidProveedor` FOREIGN KEY (`Proveedor`) REFERENCES `proveedores` (`idProveedor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_RPrubro_RidRubro` FOREIGN KEY (`Rubro`) REFERENCES `rubros` (`idRubro`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table rubroproveedores
-- 

/*!40000 ALTER TABLE `rubroproveedores` DISABLE KEYS */;

/*!40000 ALTER TABLE `rubroproveedores` ENABLE KEYS */;

-- 
-- Definition of rubros
-- 

DROP TABLE IF EXISTS `rubros`;
CREATE TABLE IF NOT EXISTS `rubros` (
  `idRubro` int(11) NOT NULL AUTO_INCREMENT,
  `rubro` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idRubro`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table rubros
-- 

/*!40000 ALTER TABLE `rubros` DISABLE KEYS */;
INSERT INTO `rubros`(`idRubro`,`rubro`,`estado`) VALUES
(1,'Otro',1);
/*!40000 ALTER TABLE `rubros` ENABLE KEYS */;

-- 
-- Definition of rubrosproductos
-- 

DROP TABLE IF EXISTS `rubrosproductos`;
CREATE TABLE IF NOT EXISTS `rubrosproductos` (
  `idRubro` int(11) NOT NULL AUTO_INCREMENT,
  `idRubroFK` int(11) DEFAULT NULL,
  `rubro` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idRubro`),
  KEY `FK_idRubro_idRubroFK_idx` (`idRubroFK`),
  CONSTRAINT `FK_idRubroFK_idRubro` FOREIGN KEY (`idRubroFK`) REFERENCES `rubrosproductos` (`idRubro`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table rubrosproductos
-- 

/*!40000 ALTER TABLE `rubrosproductos` DISABLE KEYS */;
INSERT INTO `rubrosproductos`(`idRubro`,`idRubroFK`,`rubro`,`descripcion`,`estado`) VALUES
(1,NULL,'Ramos Hnos','Productos de la Soderia',1),
(2,NULL,'Limpieza','Productos de Limpieza',1),
(3,NULL,'Otros','Otros Articulos',1);
/*!40000 ALTER TABLE `rubrosproductos` ENABLE KEYS */;

-- 
-- Definition of saldos
-- 

DROP TABLE IF EXISTS `saldos`;
CREATE TABLE IF NOT EXISTS `saldos` (
  `idSaldo` int(11) NOT NULL AUTO_INCREMENT,
  `rol` int(11) DEFAULT NULL,
  `idPersona` int(11) DEFAULT NULL,
  `creditoMax` double DEFAULT '0',
  `saldoActual` double DEFAULT '0',
  PRIMARY KEY (`idSaldo`),
  KEY `FK_Srol_RidRol_idx` (`rol`),
  CONSTRAINT `FK_Srol_RidRol` FOREIGN KEY (`rol`) REFERENCES `roles` (`idRol`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table saldos
-- 

/*!40000 ALTER TABLE `saldos` DISABLE KEYS */;
INSERT INTO `saldos`(`idSaldo`,`rol`,`idPersona`,`creditoMax`,`saldoActual`) VALUES
(1,1,1496,50,0);
/*!40000 ALTER TABLE `saldos` ENABLE KEYS */;

-- 
-- Definition of stockinsumolog
-- 

DROP TABLE IF EXISTS `stockinsumolog`;
CREATE TABLE IF NOT EXISTS `stockinsumolog` (
  `idStockInsumoLog` int(11) NOT NULL AUTO_INCREMENT,
  `operacion` varchar(1) DEFAULT NULL,
  `comprobante` int(11) DEFAULT NULL,
  `idInsumo` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `stockActual` int(11) DEFAULT NULL,
  `stockNuevo` int(11) DEFAULT NULL,
  `fechaActualizacion` datetime DEFAULT NULL,
  PRIMARY KEY (`idStockInsumoLog`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table stockinsumolog
-- 

/*!40000 ALTER TABLE `stockinsumolog` DISABLE KEYS */;
INSERT INTO `stockinsumolog`(`idStockInsumoLog`,`operacion`,`comprobante`,`idInsumo`,`cantidad`,`stockActual`,`stockNuevo`,`fechaActualizacion`) VALUES
(1,'P',NULL,1,0,0,0,NULL),
(2,'P',NULL,2,0,0,0,NULL),
(3,'P',NULL,3,0,0,0,NULL),
(4,'P',NULL,4,0,0,0,NULL),
(5,'P',NULL,5,0,0,0,NULL),
(6,'P',NULL,6,0,0,0,NULL),
(7,'P',NULL,7,0,0,0,NULL),
(8,'P',NULL,8,0,0,0,NULL),
(9,'P',NULL,9,0,0,0,NULL),
(10,'P',NULL,10,0,0,0,NULL),
(11,'P',NULL,11,0,0,0,NULL),
(12,'P',NULL,12,0,0,0,NULL),
(13,'P',NULL,13,0,0,0,NULL),
(14,'P',NULL,14,0,0,0,NULL),
(15,'P',NULL,15,0,0,0,NULL),
(16,'P',NULL,16,0,0,0,NULL),
(17,'P',NULL,17,0,0,0,NULL),
(18,'P',NULL,18,0,0,0,NULL),
(19,'P',NULL,19,0,0,0,NULL),
(20,'P',NULL,20,0,0,0,NULL),
(21,'P',NULL,21,0,0,0,NULL),
(22,'P',NULL,22,0,0,0,NULL),
(23,'P',NULL,23,0,0,0,NULL),
(24,'P',NULL,24,0,0,0,NULL),
(25,'P',NULL,25,0,0,0,NULL),
(26,'P',NULL,26,0,0,0,NULL),
(27,'P',NULL,27,0,0,0,NULL),
(28,'P',NULL,28,0,0,0,NULL),
(29,'P',NULL,29,0,0,0,NULL),
(30,'P',1,9,2,0,2,NULL),
(31,'P',1,11,5,0,5,NULL),
(32,'P',2,9,3,2,5,NULL),
(33,'P',2,11,5,5,10,NULL);
/*!40000 ALTER TABLE `stockinsumolog` ENABLE KEYS */;

-- 
-- Definition of stockinsumos
-- 

DROP TABLE IF EXISTS `stockinsumos`;
CREATE TABLE IF NOT EXISTS `stockinsumos` (
  `idStock` int(11) NOT NULL AUTO_INCREMENT,
  `idInsumo` varchar(10) DEFAULT NULL,
  `stockMinimo` int(11) DEFAULT NULL,
  `stockMaximo` int(11) DEFAULT NULL,
  `stockActual` int(11) DEFAULT NULL,
  `fechaActualizacion` int(11) DEFAULT NULL,
  PRIMARY KEY (`idStock`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table stockinsumos
-- 

/*!40000 ALTER TABLE `stockinsumos` DISABLE KEYS */;
INSERT INTO `stockinsumos`(`idStock`,`idInsumo`,`stockMinimo`,`stockMaximo`,`stockActual`,`fechaActualizacion`) VALUES
(1,'1',15,100,NULL,NULL),
(2,'2',15,100,NULL,NULL),
(3,'3',15,100,NULL,NULL),
(4,'4',15,100,NULL,NULL),
(5,'5',15,100,NULL,NULL),
(6,'6',15,100,NULL,NULL),
(7,'7',15,100,NULL,NULL),
(8,'8',15,100,NULL,NULL),
(9,'9',15,100,NULL,NULL),
(10,'10',15,100,NULL,NULL),
(11,'11',15,100,NULL,NULL),
(12,'12',15,100,NULL,NULL),
(13,'13',15,100,NULL,NULL),
(14,'14',15,100,NULL,NULL),
(15,'15',15,100,NULL,NULL),
(16,'16',15,100,NULL,NULL),
(17,'17',15,100,NULL,NULL),
(18,'18',15,100,NULL,NULL),
(19,'19',15,100,NULL,NULL),
(20,'20',15,100,NULL,NULL),
(21,'21',15,100,NULL,NULL),
(22,'22',15,100,NULL,NULL),
(23,'23',15,100,NULL,NULL),
(24,'24',15,100,NULL,NULL),
(25,'25',15,100,NULL,NULL),
(26,'26',15,100,NULL,NULL),
(27,'27',15,100,NULL,NULL),
(28,'28',15,100,NULL,NULL),
(29,'29',15,100,NULL,NULL);
/*!40000 ALTER TABLE `stockinsumos` ENABLE KEYS */;

-- 
-- Definition of stockproducto
-- 

DROP TABLE IF EXISTS `stockproducto`;
CREATE TABLE IF NOT EXISTS `stockproducto` (
  `idStock` int(11) NOT NULL AUTO_INCREMENT,
  `idProducto` int(11) DEFAULT NULL,
  `stockMinimo` int(11) DEFAULT NULL,
  `stockMaximo` int(11) DEFAULT NULL,
  `stockActual` int(11) DEFAULT NULL,
  `fechaActualizacion` datetime DEFAULT NULL,
  PRIMARY KEY (`idStock`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table stockproducto
-- 

/*!40000 ALTER TABLE `stockproducto` DISABLE KEYS */;
INSERT INTO `stockproducto`(`idStock`,`idProducto`,`stockMinimo`,`stockMaximo`,`stockActual`,`fechaActualizacion`) VALUES
(1,1,15,100,NULL,NULL),
(2,2,15,100,NULL,NULL),
(3,3,15,100,NULL,NULL),
(4,4,15,100,NULL,NULL),
(5,5,15,100,NULL,NULL),
(6,6,15,100,NULL,NULL),
(7,7,15,100,NULL,NULL),
(8,8,15,100,NULL,NULL),
(9,9,15,100,NULL,NULL),
(10,10,15,100,NULL,NULL),
(11,11,15,100,NULL,NULL);
/*!40000 ALTER TABLE `stockproducto` ENABLE KEYS */;

-- 
-- Definition of stockproductolog
-- 

DROP TABLE IF EXISTS `stockproductolog`;
CREATE TABLE IF NOT EXISTS `stockproductolog` (
  `idStockProductoLog` int(11) NOT NULL AUTO_INCREMENT,
  `operacion` varchar(1) DEFAULT NULL,
  `comprobante` int(11) DEFAULT NULL,
  `idProducto` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `stockActual` int(11) DEFAULT NULL,
  `stockNuevo` int(11) DEFAULT NULL,
  `fechaActualizacion` datetime DEFAULT NULL,
  PRIMARY KEY (`idStockProductoLog`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table stockproductolog
-- 

/*!40000 ALTER TABLE `stockproductolog` DISABLE KEYS */;
INSERT INTO `stockproductolog`(`idStockProductoLog`,`operacion`,`comprobante`,`idProducto`,`cantidad`,`stockActual`,`stockNuevo`,`fechaActualizacion`) VALUES
(1,'P',NULL,1,0,0,0,NULL),
(2,'P',NULL,2,0,0,0,NULL),
(3,'P',NULL,3,0,0,0,NULL),
(4,'P',NULL,4,0,0,0,NULL),
(5,'P',NULL,5,0,0,0,NULL),
(6,'P',NULL,6,0,0,0,NULL),
(7,'P',NULL,7,0,0,0,NULL),
(8,'P',NULL,8,0,0,0,NULL),
(9,'P',NULL,9,0,0,0,NULL),
(10,'P',NULL,10,0,0,0,NULL),
(11,'P',NULL,11,0,0,0,NULL),
(12,'P',2,7,2,0,2,NULL),
(13,'V',1,7,2,2,0,NULL);
/*!40000 ALTER TABLE `stockproductolog` ENABLE KEYS */;

-- 
-- Definition of subrubro1productos
-- 

DROP TABLE IF EXISTS `subrubro1productos`;
CREATE TABLE IF NOT EXISTS `subrubro1productos` (
  `idsubRubro1` int(11) NOT NULL,
  `rubro` int(11) DEFAULT NULL,
  `subRubro1` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idsubRubro1`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table subrubro1productos
-- 

/*!40000 ALTER TABLE `subrubro1productos` DISABLE KEYS */;
INSERT INTO `subrubro1productos`(`idsubRubro1`,`rubro`,`subRubro1`,`estado`) VALUES
(1,1,'Aguas',1),
(2,1,'Sodas',1);
/*!40000 ALTER TABLE `subrubro1productos` ENABLE KEYS */;

-- 
-- Definition of subrubro2productos
-- 

DROP TABLE IF EXISTS `subrubro2productos`;
CREATE TABLE IF NOT EXISTS `subrubro2productos` (
  `idsubRubro2` int(11) NOT NULL,
  `rubro` int(11) DEFAULT NULL,
  `subRubro2` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idsubRubro2`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table subrubro2productos
-- 

/*!40000 ALTER TABLE `subrubro2productos` DISABLE KEYS */;
INSERT INTO `subrubro2productos`(`idsubRubro2`,`rubro`,`subRubro2`,`estado`) VALUES
(1,1,'Retornables',1),
(2,1,'No Retornables',1),
(3,2,'Retornables',1),
(4,2,'No Retornables',1);
/*!40000 ALTER TABLE `subrubro2productos` ENABLE KEYS */;

-- 
-- Definition of telefonos
-- 

DROP TABLE IF EXISTS `telefonos`;
CREATE TABLE IF NOT EXISTS `telefonos` (
  `idTelefono` int(11) NOT NULL AUTO_INCREMENT,
  `rol` int(11) DEFAULT NULL,
  `idPersona` int(11) DEFAULT NULL,
  `TipoTel` int(11) NOT NULL,
  `caracteristica` varchar(6) NOT NULL,
  `numTel` varchar(12) NOT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idTelefono`),
  KEY `FK_tipoTel_idTipoTel_idx` (`TipoTel`),
  KEY `FK_rolCli_idRol_idx` (`rol`),
  CONSTRAINT `FK_rolTel_idRol` FOREIGN KEY (`rol`) REFERENCES `roles` (`idRol`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_tipoTel_idTipoTel` FOREIGN KEY (`TipoTel`) REFERENCES `tipotelefono` (`idTipoTel`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table telefonos
-- 

/*!40000 ALTER TABLE `telefonos` DISABLE KEYS */;
INSERT INTO `telefonos`(`idTelefono`,`rol`,`idPersona`,`TipoTel`,`caracteristica`,`numTel`,`estado`) VALUES
(1,1,5,1,'324234','34324324324',1),
(2,1,323,1,'324234','234234324',1);
/*!40000 ALTER TABLE `telefonos` ENABLE KEYS */;

-- 
-- Definition of tipocliente
-- 

DROP TABLE IF EXISTS `tipocliente`;
CREATE TABLE IF NOT EXISTS `tipocliente` (
  `idtipoCliente` int(11) NOT NULL AUTO_INCREMENT,
  `tipoCliente` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `porcDescuento` varchar(45) DEFAULT NULL,
  `color` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idtipoCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tipocliente
-- 

/*!40000 ALTER TABLE `tipocliente` DISABLE KEYS */;
INSERT INTO `tipocliente`(`idtipoCliente`,`tipoCliente`,`descripcion`,`porcDescuento`,`color`,`estado`) VALUES
(1,'Regular','Regular','0','GreenYellow',1),
(2,'Consumidor','Consumidor','5','LightBlue',1);
/*!40000 ALTER TABLE `tipocliente` ENABLE KEYS */;

-- 
-- Definition of tipodocumento
-- 

DROP TABLE IF EXISTS `tipodocumento`;
CREATE TABLE IF NOT EXISTS `tipodocumento` (
  `idTipoDoc` int(11) NOT NULL AUTO_INCREMENT,
  `tipoDoc` varchar(10) NOT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idTipoDoc`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tipodocumento
-- 

/*!40000 ALTER TABLE `tipodocumento` DISABLE KEYS */;
INSERT INTO `tipodocumento`(`idTipoDoc`,`tipoDoc`,`estado`) VALUES
(1,'DNI',1),
(2,'CI',1),
(3,'LE',1),
(4,'LC',1),
(5,'NOT',1);
/*!40000 ALTER TABLE `tipodocumento` ENABLE KEYS */;

-- 
-- Definition of tipopedido
-- 

DROP TABLE IF EXISTS `tipopedido`;
CREATE TABLE IF NOT EXISTS `tipopedido` (
  `idtipoPedido` int(11) NOT NULL AUTO_INCREMENT,
  `tipoPedido` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idtipoPedido`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tipopedido
-- 

/*!40000 ALTER TABLE `tipopedido` DISABLE KEYS */;

/*!40000 ALTER TABLE `tipopedido` ENABLE KEYS */;

-- 
-- Definition of tipoproducto
-- 

DROP TABLE IF EXISTS `tipoproducto`;
CREATE TABLE IF NOT EXISTS `tipoproducto` (
  `idTipoProducto` int(11) NOT NULL AUTO_INCREMENT,
  `tipoproductos` varchar(30) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idTipoProducto`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tipoproducto
-- 

/*!40000 ALTER TABLE `tipoproducto` DISABLE KEYS */;
INSERT INTO `tipoproducto`(`idTipoProducto`,`tipoproductos`,`estado`) VALUES
(1,'Agua',1),
(2,'Soda',1),
(3,'Limpieza',1);
/*!40000 ALTER TABLE `tipoproducto` ENABLE KEYS */;

-- 
-- Definition of tipotelefono
-- 

DROP TABLE IF EXISTS `tipotelefono`;
CREATE TABLE IF NOT EXISTS `tipotelefono` (
  `idTipoTel` int(11) NOT NULL AUTO_INCREMENT,
  `tipoTel` varchar(10) NOT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idTipoTel`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tipotelefono
-- 

/*!40000 ALTER TABLE `tipotelefono` DISABLE KEYS */;
INSERT INTO `tipotelefono`(`idTipoTel`,`tipoTel`,`estado`) VALUES
(1,'FIJO',1),
(2,'CELULAR',1),
(3,'FAX',1);
/*!40000 ALTER TABLE `tipotelefono` ENABLE KEYS */;

-- 
-- Definition of usuarios
-- 

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `idusuario` int(11) NOT NULL AUTO_INCREMENT,
  `privilegios` int(11) DEFAULT NULL,
  `numDoc` varchar(10) NOT NULL,
  `apellido` varchar(45) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `fechaNacimiento` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) NOT NULL,
  PRIMARY KEY (`idusuario`),
  KEY `FK_uPrivilegios_PidPrivilegio_idx` (`privilegios`),
  CONSTRAINT `FK_uPrivilegios_PidPrivilegio` FOREIGN KEY (`privilegios`) REFERENCES `privilegios` (`idPrivilegio`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table usuarios
-- 

/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;

/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;

-- 
-- Definition of vehiculos
-- 

DROP TABLE IF EXISTS `vehiculos`;
CREATE TABLE IF NOT EXISTS `vehiculos` (
  `idVehiculo` int(11) NOT NULL AUTO_INCREMENT,
  `marca` varchar(45) DEFAULT NULL,
  `modelo` varchar(4) DEFAULT NULL,
  `patente` varchar(7) DEFAULT NULL,
  `color` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idVehiculo`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table vehiculos
-- 

/*!40000 ALTER TABLE `vehiculos` DISABLE KEYS */;
INSERT INTO `vehiculos`(`idVehiculo`,`marca`,`modelo`,`patente`,`color`,`estado`) VALUES
(1,'Trafic','1993','TWX-953','White',1),
(2,'Trafic','1992','TXM-325','White',1),
(3,'Trafic','1998','CPL-361','White',1),
(4,'Trafic','1996','AXG-003','White',1),
(5,'Trafic','1998','CNF-164','White',1),
(6,'Trafic','2013','NDD-392','White',1);
/*!40000 ALTER TABLE `vehiculos` ENABLE KEYS */;

-- 
-- Definition of visita
-- 

DROP TABLE IF EXISTS `visita`;
CREATE TABLE IF NOT EXISTS `visita` (
  `idVisita` int(11) NOT NULL AUTO_INCREMENT,
  `idDomicilio` int(11) NOT NULL,
  `diavisita` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idVisita`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table visita
-- 

/*!40000 ALTER TABLE `visita` DISABLE KEYS */;

/*!40000 ALTER TABLE `visita` ENABLE KEYS */;

-- 
-- Definition of visitas
-- 

DROP TABLE IF EXISTS `visitas`;
CREATE TABLE IF NOT EXISTS `visitas` (
  `idVisita` int(11) NOT NULL AUTO_INCREMENT,
  `cliente` int(11) DEFAULT NULL,
  `domicilio` int(11) DEFAULT NULL,
  `lunes` tinyint(1) DEFAULT NULL,
  `martes` tinyint(1) DEFAULT NULL,
  `miercoles` tinyint(1) DEFAULT NULL,
  `jueves` tinyint(1) DEFAULT NULL,
  `viernes` tinyint(1) DEFAULT NULL,
  `sabado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idVisita`),
  KEY `FK_vrol_ridRol_idx` (`cliente`),
  CONSTRAINT `FK_vrol_ridRol` FOREIGN KEY (`cliente`) REFERENCES `roles` (`idRol`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table visitas
-- 

/*!40000 ALTER TABLE `visitas` DISABLE KEYS */;

/*!40000 ALTER TABLE `visitas` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2016-07-05 07:51:44
-- Total time: 0:0:0:0:884 (d:h:m:s:ms)
