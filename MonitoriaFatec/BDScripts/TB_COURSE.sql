use MONITORIA_FATEC
--go 
--DROP TABLE COURSE;
GO 
Create Table COURSE(
	IDCOURSE INT IDENTITY(0,1) NOT NULL,
	IDCOORDINATOR INT,
	NMCOURSE VARCHAR(255) NOT NULL);