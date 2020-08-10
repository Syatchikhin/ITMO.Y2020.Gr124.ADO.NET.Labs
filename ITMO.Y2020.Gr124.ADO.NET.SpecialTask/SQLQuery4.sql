--PROCEDURES--

--описание процедуры--
USE GasDatabase3;
GO

CREATE PROCEDURE gas.mixtureCalculation 
		 @mixtureName varchar(20)
AS
     --начало процедуры

		IF  OBJECT_ID (N'Gas.#Calculation') IS NOT NULL 
			BEGIN
					DROP TABLE Gas.#Calculation
			END;
		

		CREATE TABLE Gas.#Calculation
		(compositionName Char(25) NOT NULL,
		componentFormula Char(10)  NOT NULL,
		componentMolarWeight Decimal(6,3) NULL,
		componentVolume Decimal(6,4) NOT NULL,
		componentVolumeIn1000 As componentVolume *10,
		--componentMoles  AS componentVolume * 10/22.41396954,
		componentMoles  Decimal(6,3) NULL,
		componentWeight Decimal(6,3) NULL,
		componentPercentWeight Decimal(6,3) NULL,
		componentR Decimal(6,3) NULL,
		componentMiRi Decimal(9,3) NULL,
		PRIMARY KEY (compositionName, componentFormula))
		
		--GO

		INSERT into Gas.#Calculation (compositionName, componentFormula, componentMolarWeight, componentVolume)
		SELECT compositionName, GC.componentFormula,  MC.componentMolarWeignt, componentVolume
		FROM Gas.Composition As Gc
		INNER JOIN 
		 Media.Components AS MC
		ON (GC.componentFormula = MC.componentFormula)
		WHERE compositionName = @mixtureName

		UPDATE Gas.#Calculation
		SET componentMoles = componentVolumeIn1000 / 22.41396954;

		UPDATE gas.Properties 
		SET gasSize=(SELECT COUNT(*) FROM Gas.#Calculation)
		WHERE gasName = @mixtureName

		UPDATE Gas.#Calculation
		SET componentWeight = componentMoles * componentMolarWeight;
		
		DECLARE @fullWeight decimal (8,3);
		SELECT  @fullWeight = SUM(ComponentWeight) 
		FROM Gas.#Calculation 
		
		--print @fullWeight;
		--GO

		UPDATE gas.Properties 
		SET gasdensity=@fullWeight/1000
		WHERE gasName = @mixtureName

		UPDATE Gas.#Calculation
		SET componentPercentWeight = (ComponentWeight / @fullWeight ) * 100;

		UPDATE Gas.#Calculation
		SET componentR =   8314.462618 / componentMolarWeight;

		UPDATE Gas.#Calculation
		SET componentMiRi = componentPercentWeight * componentR;
		

		DECLARE @mixtureR decimal (9,3);
		SELECT  @mixtureR = SUM(ComponentMiRi) 
		FROM Gas.#Calculation 

		UPDATE gas.Properties 
		SET gasConstant=@mixtureR/100
		WHERE gasName = @mixtureName

		DROP TABLE Gas.#Calculation
	 --конец процедуры

GO