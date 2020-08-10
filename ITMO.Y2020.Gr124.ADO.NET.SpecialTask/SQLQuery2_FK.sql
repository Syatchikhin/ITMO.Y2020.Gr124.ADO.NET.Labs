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

CREATE TABLE Gas.Composition
(
compositionName Char(25) NOT NULL,
componentFormula Char(10)  NOT NULL,
componentVolume Decimal(9,6) NOT NULL,
--PRIMARY KEY (compositionName, componentFormula),
--FOREIGN KEY (compositionName) REFERENCES Gas.Properties(gasName) ON DELETE CASCADE ON UPDATE CASCADE,

CONSTRAINT PK_Composition_Name_Fofmula PRIMARY KEY (compositionName, componentFormula),
CONSTRAINT FK_Composition_To_Properties FOREIGN KEY (compositionName) REFERENCES Gas.Properties(gasName) 
ON DELETE CASCADE 
ON UPDATE CASCADE,
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

