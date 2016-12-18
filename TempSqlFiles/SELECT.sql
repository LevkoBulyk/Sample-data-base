USE Samples;

--SELECT * FROM PercentToCompound AS ptc
--	JOIN Compound as c ON ptc.Compound_id = c.Id
--	JOIN Percentage AS p ON ptc.Percents_id = p.Id
--	JOIN Matrix AS m ON p.Matrix_id=m.Id;

SELECT * FROM PercentToCompound AS ptc
	FULL OUTER JOIN Compound as c ON ptc.Compound_id = c.Id
	FULL OUTER JOIN Percentage AS p ON ptc.Percents_id = p.Id
	FULL OUTER JOIN Matrix AS m ON p.Matrix_id=m.Id;

--SELECT * FROM PercentToCompound;

--SELECT * FROM Compound;

USE master;
