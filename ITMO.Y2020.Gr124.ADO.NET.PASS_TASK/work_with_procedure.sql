--выполнение процедуры для воздуха--
EXEC dbo.mixtureCalculation  @mixtureName = 'Air' ;
GO

--выполнение процедуры для метана--
EXEC dbo.mixtureCalculation  @mixtureName = 'Natural Gas' ;
GO



--просмотр временной таблицы--(если не удалена)--
SELECT* FROM dbo.#Calculation ORDER BY componentVolume DESC
GO

--просмотр результатов расчета--
SELECT * FROM dbo.Gases 

--DROP TABLE dbo.#Calculation

--SET 0 --
UPDATE dbo.Gases 
SET gasSize =0,
	gasDensity = 0,
    gasConstant = 0
WHERE gasName = 'Natural Gas'
GO


UPDATE dbo.Gases 
SET gasSize =0,
	gasDensity = 0,
    gasConstant = 0
WHERE gasName = 'Air'
GO