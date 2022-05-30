CREATE TABLE [dbo].[Race]
(
	[Id_Race] INT NOT NULL identity,
	[Name] nvarchar(50) not null,
	[Endurance_Modifier] int not null default 0,
	[Strentgh_Modifier] int not null default 0,

	constraint PK_Race PRIMARY KEY (Id_Race),
	constraint UK_Race__Name UNIQUE ([Name])

)
