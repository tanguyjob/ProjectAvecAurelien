/*
Script de déploiement pour HeroesVSMOnster

Ce code a été généré par un outil.
La modification de ce fichier peut provoquer un comportement incorrect et sera perdue si
le code est régénéré.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "HeroesVSMOnster"
:setvar DefaultFilePrefix "HeroesVSMOnster"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL15.SQL2019DEV\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL15.SQL2019DEV\MSSQL\DATA\"

GO
:on error exit
GO
/*
Détectez le mode SQLCMD et désactivez l'exécution du script si le mode SQLCMD n'est pas pris en charge.
Pour réactiver le script une fois le mode SQLCMD activé, exécutez ce qui suit :
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'Le mode SQLCMD doit être activé de manière à pouvoir exécuter ce script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
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

insert into Hero ([Name], [Endurance],[Strentgth],[Id_Race]) values (1,N'Dominique',12,16,1);
insert into Hero ([Name], [Endurance],[Strentgth],[Id_Race]) values (2,N'Thierry',18,10,2);
GO

GO
PRINT N'Mise à jour terminée.';


GO
