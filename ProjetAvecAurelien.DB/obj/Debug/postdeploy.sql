/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/



use [HeroesVSMOnster]
GO

set identity_INSERT [Race] ON;
insert into Race (Id_Race, [Name], [Endurance_Modifier],[Strentgh_Modifier]) values (1,N'Human',1,1)
insert into Race (Id_Race, [Name], [Endurance_Modifier],[Strentgh_Modifier]) values (2,N'Dwarf',2,0)

GO

set identity_INSERT [Race] OFF;
GO


--Hero

insert into Hero ([Name], [Endurance],[Strength],[Id_Race]) values (N'Dominique',12,16,1);
insert into Hero ([Name], [Endurance],[Strength],[Id_Race]) values (N'Thierry',18,10,2);
GO
