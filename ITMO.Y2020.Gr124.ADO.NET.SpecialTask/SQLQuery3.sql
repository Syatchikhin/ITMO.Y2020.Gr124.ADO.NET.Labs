USE GasDatabase3
GO

--DROP TABLE Gas.Properties
SELECT * FROM Gas.Composition ORDER BY compositionName , componentVolume DESC

--CREATE TABLE Gas.Properties
--(gasName Char(25) PRIMARY KEY NOT NULL,
--gasSize Smallint  NULL,
--gasDencity Decimal(6,3) NULL,
--gasConstant Decimal(6,3) NULL,
--gasPath NChar(40) NULL)
--GO

CREATE TABLE Gas.Properties
(gasName Char(25) NOT NULL,
gasSize Smallint  NULL DEFAULT 0,
gasDensity Decimal(6,3) NULL DEFAULT 0,
gasConstant Decimal(6,3) NULL DEFAULT 0,
gasPath NChar(40) NULL DEFAULT '',
CONSTRAINT PK_Properties_gasName PRIMARY KEY (gasName),
CONSTRAINT CK_Properties_gasSize CHECK(gasSize>=0 AND gasSize<101),
CONSTRAINT CK_Properties_gasDensity CHECK(gasDensity>=0 AND gasDensity<2),
CONSTRAINT CK_Properties_gasConstant CHECK(gasConstant>=0 AND gasConstant<1000),
);
GO

--INSERT INTO Gas.Properties
--VALUES 
--('Air', 0, 0, 0, ''),
--('Kazatchya.Gas', 0, 0, 0, '')
--GO

--INSERT INTO Gas.Properties
--VALUES 
--('Air',DEFAULT,DEFAULT,DEFAULT,DEFAULT),
--('Kazatchya.Gas',DEFAULT,DEFAULT,DEFAULT,DEFAULT)
--GO

INSERT INTO Gas.Properties (gasName)
VALUES 
('Air'),
('Kazatchya.Gas')
GO

--SELECT * FROM Gas.Properties

CREATE TABLE Media.Components
(componentNumber SmallInt NOT NULL,
componentName Char(25)  NOT NULL,
componentNameRu Char(25) NOT NULL,
componentFormula Char(10) NOT NULL,
componentMolarWeignt Decimal(9,6) NOT NULL,
CONSTRAINT PK_Components_componentFormula PRIMARY KEY (componentFormula),
--CONSTRAINT PK_Components_componentName_componentFormula PRIMARY KEY (componentName, componentFormula),
--CONSTRAINT PK_Components_componentFormula PRIMARY KEY (componentFormula), --my idea--
--CONSTRAINT FK_Components_To_Composition FOREIGN KEY (componentFormula) REFERENCES Gas.Composition (componentFormula),
CONSTRAINT CK_Components_componentNumber CHECK(componentNumber>=0 AND componentNumber<999),
CONSTRAINT CK_Components_componentMolarWeignt CHECK(componentMolarWeignt>=0 AND componentMolarWeignt<999),
CONSTRAINT UQ_Components_componentNumber UNIQUE (componentNumber),
)
GO

--DROP TABLE Media.Components

--DROP TABLE Media.Components 

 --FILL GASES--
INSERT INTO Media.Components
VALUES 
(01, 'Methane','Метан',					'CH4', 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'C')+ 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'H')*4),

(02,'Ethane','Этан',					'C2H6', 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'C')*2 + 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'H')*6 ),

(03, 'Propane',	'Пропан',				'C3H8', 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'C')*3 + 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'H')*8 ),

(04, 'Butane','Бутан',					'C4H10_1', 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'C')*4 + 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'H')*10 ),

(05, 'iso-Butane','изо-Бутан',			'C4H10_2', 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'C')*4 + 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'H')*10 ),

(06, 'Pentane',	'Пентан',				'C5H12_1', 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'C')*5 + 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'H')*12 ),

(07, 'iso-Pentane','изо-Пентан',		'C5H12_2', 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'C')*5 + 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'H')*12 ),

(08, 'neo-Pentane','нео-Пентан',		'C5H12_3', 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'C')*5 + 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'H')*12 ),

(09, 'Hexane','Гексан',					'C6H14', 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'C')*6 + 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'H')*14 ),

(10, 'Heptane',	'Гептан',				'C7H16', 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'C')*7 + 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'H')*16 ),

(11, 'Nitrogen','Азот',					'N2', 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'N')*2 ),

(12, 'Oxygen','Кислород',				'O2', 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'O')*2 ),

(13, 'CarbonDioxide','Диоксид_углерода','CO2', 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'C')+
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'O')*2 ),

(14, 'CarbonMonoxide','Оксид_углерода',	'CO', 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'C')+
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'O')),

(15, 'Methanol','Метанол',				'CH3OH', 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'C')+
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'H')*4 +
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'O')),

(16, 'HydrogenSulfide','Сероводород',	'H2S', 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'H')*2 +
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'S')),

(17, 'Water','Вода',					'H2O', 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'H')*2 +
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'O')),

(18, 'Argone','Аргон',					'Ar', 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'Ar')),

(19, 'Helium','Гелий',					'He', 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'He')),

(20, 'Krypton',	'Криптон',				'Kr', 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'Kr')),

(21, 'Xenon','Ксенон',					'Xe', 
(SELECT elementAtomicWeight FROM Media.Elements WHERE elementName = 'Xe'))

GO

SELECT * 
FROM Media.Components ORDER BY componentNumber
GO


--Переименовать смесь
--UPDATE Gas.Properties
--SET gasName = 'Air'
--WHERE gasName = 'Air2'
--GO

--Удалить смесь
--DELETE Gas.Properties
--WHERE gasName ='Air'
--GO
--DELETE Gas.Properties
--WHERE gasName ='Kazatchya.Gas'
--GO


--SELECT * FROM Gas.Properties
--SELECT * FROM Gas.Composition

IF  OBJECT_ID (N'Gas.Composition') IS NOT NULL 
	BEGIN
			DROP TABLE Gas.Composition
	END
GO

--CREATE TABLE Gas.Composition
--(
--compositionName Char(25) NOT NULL,
--componentFormula Char(10)  NOT NULL,
--componentVolume Decimal(9,6) NOT NULL,
--CONSTRAINT PK_Composition_Name_Fofmula PRIMARY KEY (compositionName, componentFormula),
--CONSTRAINT FK_Composition_To_Properties FOREIGN KEY (compositionName) REFERENCES Gas.Properties(gasName) 
--ON DELETE CASCADE 
--ON UPDATE CASCADE,
--CONSTRAINT CK_Composition_componentVolume CHECK(componentVolume>=0 AND componentVolume<101),
--);
--GO
CREATE TABLE Gas.Composition
(
compositionName Char(25) NOT NULL,
componentFormula Char(10)  NOT NULL,
componentVolume Decimal(9,6) NOT NULL,
CONSTRAINT PK_Composition_Name_Fofmula PRIMARY KEY (compositionName, componentFormula),
CONSTRAINT FK_Composition_To_Properties FOREIGN KEY (compositionName) REFERENCES Gas.Properties(gasName) 
ON DELETE CASCADE 
ON UPDATE CASCADE,
CONSTRAINT FK_Composition_To_Components FOREIGN KEY (componentFormula) REFERENCES Media.Components(componentFormula)
ON DELETE NO ACTION 
ON UPDATE NO ACTION,
CONSTRAINT CK_Composition_componentVolume CHECK(componentVolume>=0 AND componentVolume<101),
);
GO




INSERT INTO Gas.Composition
VALUES 
('Air', 'N2', 78.09),
('Air', 'O2', 20.95),
('Air', 'Ar', 0.93),
('Air', 'CO2', 0.03),
('Kazatchya.Gas', 'CH4', 97.5275),
('Kazatchya.Gas', 'C2H6', 0.8797),
('Kazatchya.Gas', 'C3H8', 0.1397),
('Kazatchya.Gas', 'C4H10_1', 0.0248),
('Kazatchya.Gas', 'C4H10_2', 0.0149),
('Kazatchya.Gas', 'C5H12_2', 0.018),
('Kazatchya.Gas', 'C5H12_3', 0.0203),
('Kazatchya.Gas', 'C6H14', 0.0222),
('Kazatchya.Gas', 'C7H16', 0.0126),
('Kazatchya.Gas', 'N2', 0.9303),
('Kazatchya.Gas', 'CO2', 0.41)
GO

--CREATE TABLE Media.Components
--(componentNumber SmallInt NOT NULL,
--componentName Char(25) PRIMARY KEY NOT NULL,
--componentNameRu Char(25) NOT NULL,
--componentFormula Char(10) NOT NULL,
--componentMolarWeignt Decimal(9,6) NOT NULL)
--GO



--SELECT * FROM Gas.Composition

