use MONITORIA_FATEC
--go 
--DROP TABLE DISCIPLINE;
GO 
Create Table DISCIPLINE(
	IDDISCIPLINE INT IDENTITY(0,1) NOT NULL,
	NMDISCIPLINE VARCHAR(255) NOT NULL
	);