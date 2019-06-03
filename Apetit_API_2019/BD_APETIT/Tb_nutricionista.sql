CREATE TABLE [dbo].[Tb_nutricionista]
(
	[Id_Nutricionista] INT NOT NULL PRIMARY KEY,
	[crn] VARCHAR(20) not null,
	[nome_nutricionista] varchar(20) not null,	
	[sobrenome_nutricionista]  varchar(50) not null,
	[cpf] varchar(50) not null unique,
	[dt_nascimento] date not null,
	[sexo] char(1) not null,
	[login] varchar(11) not null unique,
	[senha] varchar (11) not null,
	[email] varchar(50) not null,
	num_celular varchar(11) NOT NULL,
)
