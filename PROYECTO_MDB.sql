CREATE DATABASE BaseAutos_ProyectoMDB
GO

USE BaseAutos_ProyectoMDB
GO

CREATE TABLE Acceso
(ID int primary key identity (1,1),
usuario varchar (100) UNIQUE,
clave varchar(15)
)

INSERT INTO Acceso VALUES
('Admin','123'),
('Carlos','456')

CREATE TABLE Clientes
(Id int NOT NULL,
Nombres varchar(100) NOT NULL,
PrimerApellido varchar(50) NOT NULL,
SegundoApellido varchar(50),
DUI varchar(11) NOT NULL,
NIT varchar(18) NOT NULL,
Direccion varchar(250) NOT NULL,
Municipio varchar(100) NOT NULL,
--creando llave primaria
CONSTRAINT Pk_Cliente PRIMARY KEY(Id),
--Añadi la restriccion UNIQUE
CONSTRAINT Un_DUI UNIQUE(DUI),
CONSTRAINT Un_NIT UNIQUE(NIT)
)

CREATE TABLE Telefono
(
Id_Cliente int NOT NULL, --fk tabla clientes
Telefono varchar(14)
)

CREATE TABLE Correo
(
Id_Cliente int NOT NULL,--fk tabla clientes
Correo varchar(100),
)

CREATE TABLE Vehiculos
(Id int NOT NULL,
Tipo_Vehiculo int NOT NULL, --foreign key tabla tipo_vehiculo
Marca_Modelo int NOT NULL, --FK TABLA MARCA_Modelo
Año int NOT NULL,
Color int NOT NULL, --FK TABLA COLOR
Tipo_Transmision int NOT NULL, --FK tabla transmision
Precio money NOT NULL,
--creando llave primaria
CONSTRAINT Pk_Vehiculo PRIMARY KEY(Id),
)
INSERT INTO Vehiculos VALUES
(1,1,7,2020,4,1,20450),
(2,1,7,2020,6,1,20450),
(3,1,8,2021,4,2,23000),
(4,1,8,2021,6,2,23000),
(5,1,9,2019,1,1,36230),
(6,1,9,2019,2,1,36230),
(7,1,10,2021,1,2,39560),
(8,1,10,2021,2,2,39560),
(9,1,11,2021,5,2,25000),
(10,1,11,2021,6,2,25000),
(11,1,12,2021,5,2,27220),
(12,1,12,2021,6,2,27220)

INSERT INTO Vehiculos VALUES
(13,2,1,2018,2,1,15150),
(14,2,1,2018,6,1,15150),
(15,2,2,2020,2,1,12300),
(16,2,2,2020,6,1,12300),
(17,2,3,2020,2,2,18450),
(18,2,3,2020,1,2,18450),
(19,2,4,2021,2,2,20000),
(20,2,4,2021,1,2,20000),
(21,2,5,2019,2,1,17100),
(22,2,5,2019,6,1,17100),
(23,2,6,2020,2,2,16450),
(24,2,6,2020,6,2,16450)

INSERT INTO Vehiculos VALUES
(25,3,13,2020,1,2,23000),
(26,3,13,2020,5,2,23000),
(27,3,14,2021,1,1,30200),
(28,3,14,2021,5,1,30200),
(29,3,15,2019,1,2,36745),
(30,3,15,2019,5,2,36745),
(31,3,16,2021,1,2,45150),
(32,3,16,2021,5,2,45150),
(33,3,17,2018,4,2,34256),
(34,3,17,2018,3,2,34256),
(35,3,18,2020,4,1,40000),
(36,3,18,2020,3,1,40000)

select*from Color
select*from Marca_Modelo

CREATE TABLE Tipo_Vehiculo
(Id int NOT NULL,
Tipo_Vehiculo Varchar(20) NOT NULL,
--creando llave primaria
CONSTRAINT Pk_TipoVeh PRIMARY KEY(Id),
)
INSERT INTO Tipo_Vehiculo VALUES
(1,'Carro'),
(2,'Motocicleta'),
(3,'Camioneta')
SELECT*FROM Tipo_Vehiculo

CREATE TABLE Marca_Modelo
(Id int NOT NULL,
Marca varchar(25) NOT NULL,
--creando llave primaria
CONSTRAINT Pk_Marca_Modelo PRIMARY KEY(Id),
)
INSERT INTO Marca_Modelo VALUES
(1,'Susuki GSX-S1000 GT'),
(2,'Susuki HAYABUSA 1300'),
(3,'Honda PCX125'),
(4,'Honda NT1100'),
(5,'Yamaha XMAX 125'),
(6,'Yamaha MT-07'),
(7,'Nissan Sentra'),
(8,'Nissan Versa'),
(9,'BMW Luxury'),
(10,'BMW Serie4'),
(11,'Honda Civic'),
(12,'Honda Accord'),
(13,'Ford Escape'),
(14,'Ford Xplorer'),
(15,'Chevrolet Tracker'),
(16,'Chevrolet Colorado'),
(17,'Nissan Frontier NP300'),
(18,'Nissan Rogue')

CREATE TABLE Color
(Id int NOT NULL,
Color varchar(20)
--creando llave primaria
CONSTRAINT Pk_Color PRIMARY KEY(Id),
)
INSERT INTO Color VALUES
(1,'Blanco'),
(2,'Negro'),
(3,'Gris'),
(4,'Naranja'),
(5,'Rojo'),
(6,'Azul')

CREATE TABLE Transmision
(Id int NOT NULL,
Tipo_Transmision varchar(20)
--creando llave primaria
CONSTRAINT Pk_TipoTrans PRIMARY KEY(Id),
)
INSERT INTO Transmision VALUES
(1,'Manual'),
(2,'Automatica')

CREATE TABLE Factura
(Id int IDENTITY(1,1) NOT NULL,
Id_Cliente int NOT NULL, --FK tabla clientes
Id_Vehiculo int NOT NULL, --FK tabla vehiculos
IVA money NOT NULL,
Tipo_Vehiculo varchar(20) NOT NULL, 
Marca_Modelo_Vehiculo varchar(50) NOT NULL, 
Color varchar(20) NOT NULL,
Precio_Vehiculo money NOT NULL,
Fecha_Factura datetime NOT NULL,
--creando llave primaria
CONSTRAINT Pk_Factura PRIMARY KEY(Id)
)

--RELACIONES ENTRE TABLAS

--1)Relacion entre tabla Clientes y tabla Telefono
ALTER TABLE Telefono
ADD CONSTRAINT Fk_Tel_Cliente FOREIGN KEY(Id_Cliente) REFERENCES Clientes(Id)
ON UPDATE CASCADE
ON DELETE CASCADE

--2)Relacion entre tabla Clientes y tabla Correo
ALTER TABLE Correo
ADD CONSTRAINT Fk_Correo_Cliente FOREIGN KEY(Id_Cliente) REFERENCES Clientes(Id)
ON UPDATE CASCADE
ON DELETE CASCADE

--3)Relacion entre tabla Vehiculos y tabla Tipo_Vehiculo 
ALTER TABLE Vehiculos
ADD CONSTRAINT Fk_Tipo_Vehiculo FOREIGN KEY(Tipo_Vehiculo) REFERENCES Tipo_Vehiculo(Id)
ON UPDATE CASCADE
ON DELETE CASCADE

--4)Relacion entre tabla Vehiculos y tabla Marca_Modelo
ALTER TABLE Vehiculos
ADD CONSTRAINT Fk_MarcaModelo FOREIGN KEY(Marca_Modelo) REFERENCES Marca_Modelo(Id)
ON UPDATE CASCADE
ON DELETE CASCADE

--5)Relacion entre tabla Vehiculos y tabla Color 
ALTER TABLE Vehiculos
ADD CONSTRAINT Fk_Color FOREIGN KEY(Color) REFERENCES Color(Id)
ON UPDATE CASCADE
ON DELETE CASCADE

--6)Relacion entre tabla Vehiculos y tabla Transmision
ALTER TABLE Vehiculos
ADD CONSTRAINT Fk_Tipo_Transmision FOREIGN KEY(Tipo_Transmision) REFERENCES Transmision(Id)
ON UPDATE CASCADE
ON DELETE CASCADE

--7)Relacion entre tabla Factura y tabla Clientes
ALTER TABLE Factura
ADD CONSTRAINT Fk_IdCliente FOREIGN KEY(Id_Cliente) REFERENCES Clientes(Id)
ON UPDATE CASCADE
ON DELETE CASCADE

--8)Relacion entre tabla Factura y tabla Vehiculos
ALTER TABLE Factura
ADD CONSTRAINT Fk_IdVehiculo FOREIGN KEY(Id_Vehiculo) REFERENCES Vehiculos(Id)
ON UPDATE CASCADE
ON DELETE CASCADE

INSERT INTO Clientes Values
(1,'Carlos Alexander','Alvarenga','Claros','06342645-8','0614-542457-141-0','Avenida Bernal BK#2 Casa#4','Mejicanos'),
(2,'Marcos Andres','Marquez','Perez','03453475-9','0454-456346-000-5','Col Escalon BK#7 Casa#5','San Salvador'),
(3,'Adriana Carolina','Martinez','Ramos','02451645-3','0643-546807-124-1','Calle al Volcan Casa#82','Mejicanos'),
(4,'Roberto Carlos','Torres','Cortez','04629585-8','3464-547946-153-0','Colonia Arce BK#1 Casa#6','Ciudad Arce'),
(5,'Marta Claudia','Sanchez','Velasquez','62734736-2','2353-793756-345-0','Calle Proceres Casa#15','La Libertad'),
(6,'Gabriel Ariel','Rivas','Munguia','63717363-2','0464-547827-256-1','Avenida Alcoran BK#2,Casa#1','Los Naranjos'),
(7,'Belen Astrid','Paredes','Bonilla','05372785-1','3536-539107-000-6','Calle La Paz Casa#36','El Sauce'),
(8,'Karla Jessica','Lopez','Dueñas','58391020-8','0614-235324-135-0','Calle Olocuilta Pasaje 2 Casa#4','Olocuilta'),
(9,'Sergio Paolo','Lara','Reyes','63246319-4','0714-236535-245-1','Calle Zaragosa BK#6 Casa#2','Zaragosa'),
(10,'Yesenia Nicole','Alvarez','Gonzales','35235339-2','0353-353556-135-7','Calle Rosario BK#1 Casa#9','Chalchuapa'),
(11,'Sara Paola','Maldonado','Segovia','23634589-2','0363-544679-256-8','Avenida Balboa Pasaje#4 Casa#19','Balboa'),
(12,'Stanley Kevin','Orellana','Suarez','24734467-6','3473-543623-363-0','Calle Barrios BK#3 Casa#22','San Salvador'),
(13,'Rene Gerardo','Monterrosa','Linares','16336337-2','2514-845684-241-7','Avenida Los Prados Pasaje#2 Casa#7','Mariona'),
(14,'Tatiana Jimena','Romero','Valle','23653563-2','2356-563157-335-8','Avenida Solapa Casa#14','Cuscatlan'),
(15,'Pedro Manuel','Beles','Figueroa','03636219-1','0621-978593-461-1','Colonia La Cima BK#4 Casa#10','San Salvador'),
(16,'Francisco Javier','Zaldaña','Alvarez','06292197-9','0742-172839-382-0','Avellanas, casa #87','Colón La Libertad'),
(17,'Monica Alejandra','Campos','Zamora','76499344-0','1849-349062-123-4','Col. San Antonio #24 C, casa #87','Santa Tecla'),
(18,'Lilian Esmeralda','Recinos','Lopez','98235098-1','5200-374829-120-0','Laureles 2 #59','Colón La Libertad'),
(19,'Francisco Armando','Zaldaña','Portillo','45382100-8','1728-438212-122-4','Campos Verdes 33','Lourdes La Libertad'),
(20,'Paolo Alejandro','Allende','Cristales','32279800-3','4536-227890-791-5','Jacarandas, casa #98','Mejicanos San Salvador'),
(21,'Nidia Noemy','Alvarez','Santos','78456322-3','2356-328799-677-8','Acacias, casa #2','Colón La Libertad'),
(22,'Ciro David','Zaldivar','Nuñez','15874533-9','3390-546673-246-0','Jardines de la hacienda, casa #11','Cdad. Merliot La Libertad'),
(23,'Ana Yanci','Zamora','Portales','15467833-8','9845-232425-888-5','La Florida, casa #22 L','Nuevo Cuscatlán'),
(24,'Fernando Jociel','Guevara','Torres','97543212-7','4532-786529-876-9','Laureles I, casa #14','Colón La Libertad'),
(25,'Monica Esmeralda','Zaldaña','Lopez','22378609-7','6342-253647-014-6','Valle Lourdes, casa #20','Lourdes La Libertad'),
(26,'Henry Alejandro','Peña','Nieto','12987614-9','8765-432906-543-4','Col. Altamira, casa #4','Sta. Ana centro'),
(27,'Grecia Gabriela','Mendez','Mendoza','0289615-5','3787-987654-063-2','Villa del Mar, casa #33','Mariona San Salvador'),
(28,'Bryan Ricardo','Lopez','Lazo','12335789-0','1726-384964-321-4','Calle El Poliedro, casa #7','Monserrat Sur'),
(29,'Elisa Alejandra','Funes','Andrade','54980714-2','6543-8865-901-2','Casa Bella, casa #64','Sta. Tecla La Libertad'),
(30,'Fernando Josue','Guevara','Sanchez','56432800-9','1267-647382-788-9','Metropoli San Gabriel, casa #33','Nejapa San Salvador'),
(31,'Maria Fernanda','Cruz','Pineda','77450908-3','2267-667898-902-5','Cima I, casa #12','San Salvador, San Salvador'),
(32,'Maria José','Landaverde','Torres','87889002-1','4566-229405-940-2','Cima 4, casa #21','Ayutuxtepeque San Salvador'),
(33,'Nidia Nicole','Zaldaña','Carías','23998650-6','8921-123456-765-0','Avellanas, casa #86','Colón La Libertad'),
(34,'Antonio José','Barahona','Chavez','54331206-9','4412-158709-367-2','Cumbres de Cuscatlán, casa #16','Antiguo Cuscatlán'),
(35,'Melany Alejandra','Trejo','Rivas','09731453-1','1287-889430-302-1','La Sabana, casa #1','Sta- Tecla La Libertad'),
(36,'Miguel Angel','Sarabia','Quiñones','67900716-9','0614-558982-123-4','Calle Kilombo, casa #33','San Carlos Texacuango'),
(37,'Mario José','Parras','Tilín','33429700-2','3245-656473-876-0','Cdad. Delgado I, casa #13','San Salvador'),
(38,'Ailema Alejandra','Hasbún','Alvarez','22001587-8','3221-674390-832-9','Calle Proceres, casa #21','San José'),
(39,'Gema María','Cañas','Verdes','22368901-2','1023-567890-345-7','Cima 3, casa #16','Sta Tecla, La Libertad'),
(40,'Juan Arnoldo','Valladares','Rodriguez','26547792-1','2212-153907-342-6','Sauces II casa #20','Colón La Libertad'),
(41,'Stanley Alejandro','Cabrera','Roque','21339802-2','3921-061533-672-4','Jacarandas II, casa #19','La Escalón'),
(42,'Maya Eunice','Peña','Laínez','12336759-0','5914-158703-031-4','Col Madre Selva casa #33H','La Libertad'),
(43,'Sofia Michelle','Aranzamendi','Torres','29764533-7','0519-234408-567-9','Col. San Antonio, casa #80','Sta. Tecla La Libertad'),
(44,'Mirna Alejandra','Angulo','Franco','33195406-0','1344-658707-324-1','Col. Santa Teresa, casa #25','San Jacinto San Salvador'),
(45,'Liliana Nicole','Alferez','Quinto','37002193-4','2309-657782-933-1','Cima I, casa #29','Guazapa San Salvador'),
(46,'Marcela Alejandra','Ponce','Iraheta','33457901-3','5647-223901-289-0','Amates, casa #24','Colon La Libertad'),
(47,'Francisco Andrés','Alarcón','Urrutia','12324345-7','8900-342516-435-6','Col MiralValle, casa #11','Mejicanos San Salvador'),
(48,'Federico Alonso','Martinez','Castaneda','21897655-8','2314-567790-037-1','Cumbres de Cuscatlán, casa #20','Antiguo Cuscatlán'),
(49,'Alma Marcela','Herniquez','Tablas','97451533-0','1234-567890-582-0','Amatecampo, casa #3','La Libertad'),
(50,'Juan José','Sanchez','Ortega','32001587-4','5436-789201-389-5','Cima I, casa #9','San Salvador'),
(51,'Julio David','Ayala','Rivas','12456677-0','0914-068354-328-9','Avellanas, casa #59','Colon La Libertad'),
(52,'Carlos Roberto','Portillo','Quijote','45668907-2','9504-067032-458-7','Jacarandas III, casa #102','Colon La Libertad'),
(53,'Marcela Belen','Paredes','Castillo','29336710-8','2103-675590-921-0','Sauces II, casa #52','San Marcos'),
(54,'Pedro Gabriel','Mendoza','Alvarado','02145678-8','1234-432198-573-0','Plaza Madero, casa #33','Anamoros'),
(55,'Mauricio Josué','Bonilla','López','34125909-6','2314-560789-340-4','Laureles II, casa #24','Lourdes La Libertad'),
(56,'Enrico Javier','Dueñas','Guzman','66578904-3','1308-543682-689-5','Cima III, casa #69','San Julian'),
(57,'Pamela Alejandra','Cañas','Alvarez','76549031-2','5568-324567-801-3','Calle Siemens, casa #8E','Ciudad Merliot'),
(58,'Kevin Daniel','Angulo','Estrada','05234896-9','3277-043556-078-1','Col. Tutunichapa, casa #4C','Mejicanos'),
(59,'Carmen María','Cortez','Fernandez','21089540-2','0987-765432-482-6','Avellanas, casa #201','Colon La Libertad'),
(60,'Roberto Rodrigo','Lopez','Alvarado','01949872-2','2938-194857-234-1','Residencial Santa Teresa Senda #12 casa#13','La Libertad'),
(61,'Carlos Manuel','Menendez','Iraheta','19385798-0','9874-938176-374-2','Calle La Sabana senda 13 casa#12','La libertad'),
(62,'David Marcelo','Bran','Montes','98468761-3','7281-987656-123-4','Calle El Jabali casa#20','San Salvador'),
(63,'Valeria Nicole','Saavedra','Perez','48371609-8','3098-298764-109-4','Calle La Mascota casa#17','San Salvador'),
(64,'Claudia Michelle','Gutierrez','Palma','84761908-4','1763-967841-478-1','Colonia Quezaltepeque pasaje 2 casa#1','La libertad'),
(65,'Juan Mateo','Siguenza','Rodriguez','89108765-3','10293-384576-197-1','Calle El pedregal casa#12','Sonsonate'),
(66,'Andrea Giselle','Portan','Larios','18975489-0','6574-165498-999-1','Caserio El Tigre casa#2','La libertad'),
(67,'Jose Alexander','Lopez','Lopez','16489677-1','1234-567890-777-3','Calle La Sultana senda 15 casa#11','Antiguo Cuscatlan'),
(68,'Felix Enrique','Asencio','Martinez','77665498-7','1765-287456-666-7','Colonia San Benito senda 1 casa#5','San Salvador'),
(69,'Nelson Gerardo','Alvarado','Morales','25665487-4','1123-221388-199-6','Calle La Sabana senda 17 casa#9','La libertad'),
(70,'Arturo Daniel','Figueroa','Renderos','96677854-1','1776-990033-176-1','Los Naranjos senda 3 casa#34','Soyapango'),
(71,'Fabiola Adriana','Mejia','Ayala','11445864-9','5588-114466-145-8','Portal del casco casa#19','San Salvador'),
(72,'Mauricio Fernando','Duarte','Aguirre','05733249-7','0098-675849-111-2','Juayua casa#47','Sonsonate'),
(73,'Diego Josue','Argueta','Rivas','12997671-0','1111-123456-198-3','Colonia Quezaltepeque pasaje 1 casa#12','La libertad'),
(74,'Jonathan Angel','Claros','Linares','12398765-9','0987-123409-555-1','Residencial Las Arboledas senda 13 casa#12','Lourdes'),
(75,'Kevin Alejandro','Hernandez','Cortez','51100985-1','8888-119553-000-1','Jardines del volcan pasaje 2 casa#40','Santa Tecla'),
(76,'Gabriela Massiel','Zelaya','Pineda','67584931-0','333-675843-001-7','Residencial Santa Monica senda 7 casa#10','La libertad'),
(77,'Francisco Gabriel','Zaldaña','Zelaya','10939488-3','9587-102947-999-1','La cima senda 2 casa#12','San Salvador'),
(78,'Wilson Patricio','Peña','Pereira','76843921-0','5554-177565-345-0','Armenia av 7 casa #1','Sonsonate'),
(79,'Carlos Isaac','Cuellar','Menjivar','68710898-7','8888-194674-134-1','tutunichapa pasaje 1 casa#8','San Salvador'),
(80,'Wendy Karla','Rico','Cuellar','17765478-9','5861-198533-333-1','Calle La Esperanza casa#12','Ilopango'),
(81,'Auron Ibai','Rivera','Ardon','18759034-0','5644-178722-175-1','Calle El Volcan casa#4','La libertad'),
(82,'Vanessa Daniela','Velasco','Pineda','65009816-6','1887-556782-138-6','Colonia San Francisco casa#1','San Salvador'),
(83,'Pablo David','Lopez','Lopez','44762789-5','8742-177694-875-1','Calle La Sabana senda 2 casa#3','La libertad'),
(84,'Andrea Gabriela','Siguenza','Lopez','12398755-9','5566-887765-198-7','Calle San Pedro Sula casa#14','La Paz'),
(85,'Kevin Elias','Alas','Rodriguez','12367854-0','0995-055168-111-5','Caserio Santa Maria casa#4','Usulutan'),
(86,'Jhay Wheeler','Cortez','Jhayco','18775019-1','5872-095782-229-6','Col Zacamil casa #1','San Salvador'),
(87,'Milena Sarai','Castillo','Escobar','19846657-0','1188-338866-187-8','Calle Santa Rosa casa#12','Ilopango'),
(88,'Jeffrey Anuel','AA','Real','87599816-3','1998-199782-199-4','Calle Santisima trinidad senda 1 casa#10','La Union'),
(89,'Cristiano Manuel','Siuu','Portillo','18867487-9','1776-144578-222-3','Calle El Naranjo casa#18','Soyapango'),
(90,'Mangel Rubius','Perez','Perez','66771984-7','1009-199007-202-1','Calle España senda 8 casa#8','Cojutepeque'),
(91,'Alirio Luis','Quintanilla','Arenivar','55209817-7','2003-199834-334-8','Caserio El Niño Jesus casa#10','Chalatenango'),
(92,'Goku Manuel','Vegetta','Trunks','18879056-3','1009-1987004-555-1','Corporacion Capsula #1','Cuscatlan'),
(93,'Andrea Nicole','Aparicio','Lopez','19997865-0','1044-099664-199-7','Colonia San Sebastian casa$5','Santa Ana'),
(94,'Katherine Elizabeth','Santos','Herrera','19865908-9','9009-698009-197-4','Calle La Gloria casa #3','Sensuntepeque'),
(95,'Marcelo Mario','Bran','Moreno','56809166-7','1006-450988-312-2','Calle La Libertad casa#23','La libertad'),
(96,'Rodrigo Fernando','Mejia','Figueroa','58610994-0','1000-448971-300-5','Calle La Sabana senda 11 casa#9','La libertad'),
(97,'Justin Bieber','Piche','Chinchilla','95567113-8','1992-875561-377-1','Calle El Espino senda 13 casa#12','Panchimalco'),
(98,'Luis Enrique','Majano','Hueso','55681098-0','1999-144562-308-6','Calle Los Santos casa#28','Lourdes'),
(99,'Patrick Edgardo','Colocho','Smith','29664198-7','4444-100758-665-1','Residencial San Rafael calle 2 casa#12','La libertad'),
(100,'Abi Fatima','Herniquez','Larin','19604998-1','5567-199447-678-1','Calle La Sabana senda 11 casa#12','La libertad')

INSERT INTO Telefono VALUES
(1,'6202-3564'),
(2,'2234-5636'),
(3,'2224-3565'),
(4,'7472-3556'),
(5,'7735-3535'),
(6,'4523-3535'),
(7,'7245-6352'),
(8,'5263-5356'),
(9,'2525-5335'),
(10,'5242-4356'),
(11,'6353-6374'),
(12,'4763-3367'),
(13,'3466-3364'),
(14,'4363-2363'),
(15,'3535-2363'),
(16,'7435-3220'),
(17,'7354-1234'),
(18,'6059-6982'),
(19,'7129-2329'),
(20,'6214-5906'),
(21,'7873-6465'),
(22,'7873-5897'),
(23,'6457-1813'),
(24,'6324-1587'),
(25,'7453-1482'),
(26,'6954-1566'),
(27,'7086-5432'),
(28,'7687-6969'),
(29,'7714-3220'),
(30,'6719-5678'),
(31,'6000-1456'),
(32,'7654-3212'),
(33,'7481-2334'),
(34,'6544-3787'),
(35,'6059-7200'),
(36,'7832-4330'),
(37,'6609-2134'),
(38,'6709-3224'),
(39,'7454-1500'),
(40,'6009-2836'),
(41,'7200-2133'),
(42,'7000-1569'),
(43,'6432-1200'),
(44,'6319-8806'),
(45,'7039-6544'),
(46,'6408-1533'),
(47,'7318-3406'),
(48,'6219-9153'),
(49,'7783-4219'),
(50,'7654-3211'),
(51,'6903-4212'),
(52,'7543-1202'),
(53,'7644-1903'),
(54,'7129-2229'),
(55,'6015-4329'),
(56,'7773-2129'),
(57,'6003-4015'),
(58,'7655-8909'),
(59,'7435-3390'),
(60,'2257-7777'),
(61,'2276-8876'),
(62,'2298-8972'),
(63,'2289-10293'),
(64,'7778-8276'),
(65,'7767-8398'),
(66,'9766-1876'),
(67,'8767-1029'),
(68,'8765-1877'),
(69,'7756-4469'),
(70,'7765-1198'),
(71,'1887-9087'),
(72,'7756-1954'),
(73,'7777-1111'),
(74,'7788-8877'),
(75,'1567-9887'),
(76,'5567-1987'),
(77,'4876-4877'),
(78,'4271-5483'),
(79,'1287-2776'),
(80,'6754-1987'),
(81,'5766-2998'),
(82,'5674-9876'),
(83,'1887-2776'),
(84,'6784-1145'),
(85,'8796-1332'),
(86,'3887-4876'),
(87,'7756-8876'),
(88,'8767-1001'),
(89,'5577-1199'),
(90,'1999-1445'),
(91,'1223-4444'),
(92,'1876-1127'),
(93,'7769-8878'),
(94,'1990-9987'),
(95,'2250-8546'),
(96,'9877-8187'),
(97,'2289-7756'),
(98,'2217-8176'),
(99,'8876-8136'),
(100,'5893-1887')

INSERT INTO Correo VALUES
(1,'c.alvarenga.c7@gmail.com'),
(2,'marcos.marq@outlook.com'),
(3,'caroramos82@gmail.com'),
(4,'robert47.torres@yahoo.com'),
(5,'marta.cla935@gmail.com'),
(6,'gabo.ariel64@gmail.com'),
(7,'bonilla.paredes@outlook.com'),
(8,'jessi.lopez@gmail.com'),
(9,'sergio.pao24@yahoo.com'),
(10,'8gonzales.Yes@gmail.com'),
(11,'sara.mald@outlook.com'),
(12,'stan.orellana@gmail.com'),
(13,'rene.mont@gmail.com'),
(14,'taty.romero@yahoo.com'),
(15,'pedro.beles45@outlook.com'),
(16,'francisco.za@gmail.com'),
(17,'Mm.Campos@gmail.com'),
(18,'Lilian.exe@gmail.com'),
(19,'isoArman@gmail.com'),
(20,'MrCristales@gmail.com'),
(21,'Nidix.UDB@gmail.com'),
(22,'cdmas.UDB@gmail.com'),
(23,'Yanx.MBD@gmail.com'),
(24,'JociUwu.UDB@gmail.com'),
(25,'MnotReal@gmail.com'),
(26,'HenryUDB.ESC@gmail.com'),
(27,'Greciam93@gmail.com'),
(28,'bricklaz@gmail.com'),
(29,'EliFun78@gmail.com'),
(30,'ferlol@gmail.com'),
(31,'mCruz69@gmail.com'),
(32,'majo.Real@gmail.com'),
(33,'Nnicole0212@gmail.com'),
(34,'ImToni@gmail.com'),
(35,'MelanyYesSir@gmail.com'),
(36,'Angel13s@gmail.com'),
(37,'SrParras@gmail.com'),
(38,'Aile.Hasbún@gmail.com'),
(39,'Gema.Real@gmail.com'),
(40,'JuanGod@gmail.com'),
(41,'Stan.exe@gmail.com'),
(42,'ItsmeMaya@gmail.com'),
(43,'TheRealSof@gmail.com'),
(44,'Mrn15@gmail.com'),
(45,'LiliUDB@gmail.com'),
(46,'Marcela.UDB@gmail.com'),
(47,'FranckAlv@gmail.com'),
(48,'FAlo@gmail.com'),
(49,'NotRealAlma@gmail.com'),
(50,'JuanFESA@gmail.com'),
(51,'StupJul@gmail.com'),
(52,'delaMancha.UDB@gmail.com'),
(53,'Marce.Belen@gmail.com'),
(54,'PedroaPicapiedras@gmail.com'),
(55,'Mau.Real@gmail.com'),
(56,'EnricoFromHol@gmail.com'),
(57,'Pame.UDB2021@gmail.com'),
(58,'KevinD@gmail.com'),
(59,'CarmeUDB@gmail.com'),
(60,'rodrigo.lopez2001@hotmail.com'),
(61,'carlos.manuel@gmail.com'),
(62,'david.b@gmail.com'),
(63,'v.NicoPe@gmail.com'),
(64,'claudixMiche@yahoo.com'),
(65,'mateosiguenza6996@hotmail.com'),
(66,'Agiselle198@gmail.com'),
(67,'alexander1987@gmail.com'),
(68,'felixmar@gmail.com'),
(69,'NelsonG99@yahoo.com'),
(70,'arturoDani176_1@gmail.com'),
(71,'fAdriana1777@hotmail.com'),
(72,'maurifer@gmail.com'),
(73,'dJosueHK98@gmail.com'),
(74,'JhonyAngel777@hotmail.com'),
(75,'kAlej.9431@gmail.com'),
(76,'GabsMassiel2000@hotmail.com'),
(77,'franckalv@gmail.com'),
(78,'WPtrick@gmail.com'),
(79,'C.Isa@hotmail.com'),
(80,'wendycar87@gmail.com'),
(81,'auronibaifeik@hotmail.com'),
(82,'vanevelasco@gmail.com'),
(83,'pabloDavid1999@gmail.com'),
(84,'AndreaLopezSG@gmail.com'),
(85,'kevElias.12@gmail.com'),
(86,'JWheeler@hotmail.com'),
(87,'SaraiMil@yahoo.com'),
(88,'realhastalamuerte@gmail.com'),
(89,'elbichardo@gmail.com'),
(90,'elrubius100real@gmail.com'),
(91,'luisAfonso@gmail.com'),
(92,'dragonball@yahoo.com'),
(93,'andreaNicole@hotmail.com'),
(94,'kathELi@gmail.com'),
(95,'marselillo@gmail.com'),
(96,'rodrigugie@gmail.com'),
(97,'chinchilla988@gmail.com'),
(98,'insaneMajano@gmail.com'),
(99,'smithColochoxd@gmail.com'),
(100,'AbiHernan@gmail.com')

