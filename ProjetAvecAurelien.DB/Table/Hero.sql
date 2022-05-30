CREATE TABLE [dbo].[Hero]
(
	[Id_Hero] INT NOT NULL IDENTITY,
	[Name] nvarchar(50) NOT NULL,
	[Endurance] int not null,
	Strength int not null,
	[Id_Race] int not null,

	constraint PK_Hero Primary key(Id_Hero),
	constraint FK_Hero__Race Foreign key ([Id_Race])
	REFERENCES [race] (Id_Race)
	on UPDATE CASCADE
	on DELETE NO ACTION

)
