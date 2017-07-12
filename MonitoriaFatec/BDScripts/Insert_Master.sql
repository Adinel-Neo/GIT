USE MONITORIA_FATEC;
GO
INSERT INTO [dbo].[TYPEMESSAGE]
           ([NMTYPEMESSAGE])
     VALUES
           ('Duvida'),
		   ('Sugestão'),
		   ('Reclamação')
GO

INSERT INTO [dbo].[TYPECONTENT]
           ([NMTYPECONTENT])
     VALUES
           ('Link para pagina externa'),
		   ('Arquivo'),
		   ('Video Aula')
GO

INSERT INTO [dbo].[STATUSCONTENT]
           ([NMSTATUS])
     VALUES
           ('Pendente'),
		   ('Aprovado'),
		   ('Reprovado')
		   
GO


INSERT INTO [dbo].[SCOPE]
           ([SCOPE])
     VALUES
           ('Administrador'),
		   ('Coordenador'),
		   ('Professor'),
		   ('Monitor'),
		   ('Aluno')
		   
GO

INSERT INTO [dbo].[COURSE]
           ([IDCOORDINATOR]
           ,[NMCOURSE])
     VALUES
           (2, 'ADS')
GO

INSERT INTO [dbo].[USUARIO]
           ([USERPASSWORD]
           ,[NMUSER]
		   ,[EMAILUSER]
           ,[IDSCOPE])
     VALUES
           ('adm1234',
           'Adminstrador',
		   'adm@adm.com',
           1),
		   ('1234',
           'Coordenador',
		   'coordenador@coordenador.com',
           2),
		   ('professor1234',
           'Professor',
		   'professor@professor.com',
           3),
		   ('monitor1234',
           'Monitor',
		   'monitor@monitor.com',
           4),
		   ('aluno1234',
           'Aluno',
		   'aluno@aluno.com',
           5)
GO


