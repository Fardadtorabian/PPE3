USE [domy59]
GO
/*------------------------------------------------------------
*        Scripts Création tables SQLSERVER    V1.4
------------------------------------------------------------*/
CREATE TABLE civilite(
	idCivilite INT IDENTITY (1,1) NOT NULL ,
	titre     NVARCHAR (15) NOT NULL ,
	abreviation NVARCHAR (6) NOT NULL ,
	CONSTRAINT prk_constraint_civilite PRIMARY KEY NONCLUSTERED (idCivilite)
);

USE [domy59]
GO
INSERT INTO civilite (titre , abreviation)
VALUES 
('Madame', 'Mme'),
('Monsieur', 'Mr');
GO

USE [domy59]
GO
 CREATE TABLE etatClient(
	idEtatClient INT IDENTITY (1,1) NOT NULL ,
	etat NVARCHAR (15) NOT NULL ,
	CONSTRAINT prk_constraint_etatClient PRIMARY KEY NONCLUSTERED (idEtatClient)
);
GO

USE [domy59]
GO
INSERT INTO etatClient (etat)
VALUES 
('validé'),
('impayé'),
('a supprimer');
GO
 
CREATE TABLE employe(
	loginE	   NVARCHAR (25) NOT NULL ,
	prenom     NVARCHAR (20) NOT NULL ,
	nom        NVARCHAR (30) NOT NULL ,
	groupe NVARCHAR (25) NOT NULL ,
	CONSTRAINT prk_constraint_employe PRIMARY KEY NONCLUSTERED (loginE)
);

CREATE TABLE materiel(
	idMateriel   INT IDENTITY (1,1) NOT NULL ,
	typeMateriel NVARCHAR (100) NOT NULL ,
	numeroSerie	 NVARCHAR (50) NOT NULL ,
	numeroTel    NVARCHAR (12) ,
	imei         NVARCHAR (17) ,
	idGoogle     TEXT   ,
	dateEnregistrement DATETIME NOT NULL,
	dateAffectation  DATETIME  ,
	fkLoginE       NVARCHAR (25) ,
	etatMateriel NVARCHAR(15) CHECK (etatMateriel IN ('stock','enService','enPanne','vol','declasse','perdu'))
	CONSTRAINT prk_constraint_materiel PRIMARY KEY NONCLUSTERED (idMateriel),
	CONSTRAINT FK_materiel_loginE FOREIGN KEY (fkLoginE) REFERENCES employe(loginE) ON DELETE SET NULL,
	CONSTRAINT unicite_numero_serie UNIQUE (numeroSerie)
);

CREATE TABLE technicien(
	loginT    NVARCHAR (25) NOT NULL ,
	prenom    NVARCHAR (20) NOT NULL ,
	nom       NVARCHAR (30) NOT NULL ,
	passwdT   NVARCHAR(32) ,
	fkIdMateriel INT NULL,
	CONSTRAINT prk_constraint_technicien PRIMARY KEY NONCLUSTERED (loginT),
	CONSTRAINT FK_technicien_idMateriel FOREIGN KEY (fkIdMateriel) REFERENCES materiel(idMateriel)
);

CREATE TABLE client(
	idClient   INT IDENTITY (1,1) NOT NULL ,
	entreprise NVARCHAR (75),
	fkIdCivilite   INT  NOT NULL,
	prenom     NVARCHAR (20) NOT NULL ,
	nom        NVARCHAR (30) NOT NULL ,
	adresse    NVARCHAR (75) NOT NULL ,
	compAdresse NVARCHAR (75) ,
	codePostal NVARCHAR (10) NOT NULL ,
	ville      NVARCHAR (30) NOT NULL ,
	numeroTel  NVARCHAR (12) NOT NULL ,
	email	   NVARCHAR (30),
	photoent   VARBINARY(MAX),
	latitude   NVARCHAR (20) ,
	longitude  NVARCHAR (20) ,
	dateCreation DATETIME  NOT NULL ,
	dateModification DATETIME ,
	fkIdEtatClient INT  NOT NULL,
	fkLoginE     NVARCHAR (25),
	CONSTRAINT prk_constraint_client PRIMARY KEY NONCLUSTERED (idClient),
	CONSTRAINT FK_client_loginE FOREIGN KEY (fkLoginE) REFERENCES employe(loginE) ON DELETE SET NULL,
	CONSTRAINT FK_client_idCivilite FOREIGN KEY (fkIdCivilite) REFERENCES civilite(idCivilite),
	CONSTRAINT FK_client_idEtatClient FOREIGN KEY (fkIdEtatClient) REFERENCES etatClient(idEtatClient),
	CONSTRAINT unicite_prenom_nom UNIQUE (prenom,nom)
);

CREATE TABLE intervention(
	idIntervention INT IDENTITY (1,1) NOT NULL ,
	compteRendu    TEXT ,
	debutIntervention DATETIME  NOT NULL ,
	finIntervention   DATETIME  NOT NULL ,
	objectifVisite TEXT  NOT NULL ,
	photoLieu   VARBINARY(MAX),
	nomContact      NVARCHAR (30)  ,
	prenomContact   NVARCHAR (20)  ,
	telContact      NVARCHAR (12)  ,
	etatVisite      NVARCHAR (25) CHECK (etatVisite IN ('planifiée','effectuée','absence','aRenouveler')) ,
	fkLoginE        NVARCHAR (25) ,
	fkIdClient      INT  NOT NULL ,
	fkLoginT        NVARCHAR (25) ,
	CONSTRAINT prk_constraint_intervention PRIMARY KEY NONCLUSTERED (idIntervention),
    CONSTRAINT FK_intervention_loginE FOREIGN KEY (fkLoginE) REFERENCES employe(loginE) ON DELETE SET NULL,
	CONSTRAINT FK_intervention_idClient FOREIGN KEY (fkIdClient) REFERENCES client(idClient),
	CONSTRAINT FK_intervention_loginT FOREIGN KEY (fkLoginT) REFERENCES technicien(loginT) ON DELETE SET NULL
);

CREATE TABLE notification(
	idNotification INT IDENTITY (1,1) NOT NULL ,
	dateEnvoi      DATETIME  NOT NULL ,
	contenu        NVARCHAR (50) NOT NULL ,
	fkLoginT       NVARCHAR (25) ,
	fkLoginE       NVARCHAR (25),
	CONSTRAINT prk_constraint_notification PRIMARY KEY NONCLUSTERED (idNotification),
	CONSTRAINT FK_notification_loginT FOREIGN KEY (fkLoginT) REFERENCES technicien(loginT) ON DELETE SET NULL,
	CONSTRAINT FK_notification_loginE FOREIGN KEY (fkLoginE) REFERENCES employe(loginE) ON DELETE SET NULL
);
CREATE TABLE sessionTechnicien(
     idSession [int] IDENTITY(1,1) NOT NULL ,
     jeton NVARCHAR(255) ,
     dateDerniereRequete DATETIME ,
	 fkLoginT  NVARCHAR (25) NOT NULL ,
     CONSTRAINT prk_constraint_sessionTechnicien PRIMARY KEY NONCLUSTERED (idSession),
	 CONSTRAINT FK_session_technicien_loginT FOREIGN KEY (fkLoginT) REFERENCES technicien(loginT)
);

CREATE TABLE positionTechnicien(
	idPos     INT IDENTITY (1,1) NOT NULL ,
	latitude  NVARCHAR (15) NOT NULL ,
	longitude NVARCHAR (15) NOT NULL ,
	datepos   DATETIME  NOT NULL ,
	fkLoginT  NVARCHAR (25) NOT NULL ,
	CONSTRAINT prk_constraint_positionTechnicien PRIMARY KEY NONCLUSTERED (idPos),
	CONSTRAINT FK_positionTechnicien_loginT FOREIGN KEY (fkLoginT) REFERENCES technicien(loginT)
);

----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
-- DEBUT SECTION PROCEDURES STOCKEES
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------
-- Procédures liées à la table intervention
----------------------------------------------------------------------------------------

------------- CREER UNE INTERVENTION ----------------------------------------------
USE [domy59]
GO
CREATE PROCEDURE [dbo].[spInsertIntervention]	
	@pCompteRendu TEXT = NULL,
	@pDebutIntervention DATETIME ,
	@pFinIntervention   DATETIME ,
	@pObjectifVisite TEXT ,
	@pPhotoLieu VARBINARY(MAX) = NULL,
	@pNomContact      NVARCHAR (30) ,
	@pPrenomContact   NVARCHAR (20) ,
	@pTelContact      NVARCHAR (12) ,
	@pEtatVisite      NVARCHAR (25) ,
	@pFkLoginE        NVARCHAR (25) ,
	@pFkIdClient      INT,
	@pFkLoginT        NVARCHAR (25) 	
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON 
	BEGIN
		INSERT INTO [dbo].[intervention] 
			([compteRendu], [debutIntervention], [finIntervention], [objectifVisite], [photoLieu], 
			[nomContact], [prenomContact], [telContact], [etatVisite], [fkLoginE], [fkIdClient], [fkLoginT])
		SELECT @pCompteRendu, @pDebutIntervention, @pFinIntervention, @pObjectifVisite, @pPhotoLieu, 
		@pNomContact, @pPrenomContact, @pTelContact, @pEtatVisite , @pFkLoginE, @pFkIdClient, @pFkLoginT
	END
GO

------------- RECUPERER LISTE D'INTERVENTIONS POUR UN TECHNICIEN A UN JOUR DONNEE -------------------------------
USE [domy59]
GO
CREATE PROCEDURE [dbo].[spGetlistInterventionsByTechnicienByDate]
	@pFkLoginT NVARCHAR (25), 
	@pDateJour DATETIME
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT * FROM intervention 
		WHERE  fkLoginT = @pFkLoginT AND debutIntervention BETWEEN @pDateJour AND DATEADD(s,-1,DATEADD(d,1,@pDateJour))
	END
GO
------------- SUPPRIMER UNE INTERVENTION POUR UN TECHNICIEN A UNE DATE DEBUT DONNEE -------------------------------
USE [domy59]
GO
CREATE PROCEDURE [dbo].[spDeleteInterventionByTechnicienByDate]
	@pFkLoginT NVARCHAR (25), 
	@pDebutIntervention DATETIME
AS
	BEGIN
		SET NOCOUNT ON;
		DELETE FROM intervention 
		WHERE  fkLoginT = @pFkLoginT AND debutIntervention = @pDebutIntervention;
	END
GO
------------- RECUPERER UNE INTERVENTION POUR UN TECHNICIEN A UNE DATE DEBUT DONNEE OU PAR SON ID -------------------------------
USE [domy59]
GO
CREATE PROCEDURE [dbo].[spGetInterventionByTechnicienByDate]
	@pIdIntervention int,
	@pFkLoginT NVARCHAR (25), 
	@pDebutIntervention DATETIME
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT [idIntervention],[compteRendu], [debutIntervention], [finIntervention], [objectifVisite], [photoLieu], 
			[nomContact], [prenomContact], [telContact], [etatVisite], [fkLoginE], [fkIdClient], [fkLoginT]
		FROM intervention 
		WHERE (([idIntervention] = @pIdIntervention OR @pIdIntervention IS NULL) OR
		((fkLoginT = @pFkLoginT OR @pFkLoginT IS NULL) AND (debutIntervention = @pDebutIntervention OR @pDebutIntervention IS NULL))
		)
	END
GO

------------- UPDATE UNE INTERVENTION SELECTIONNEE PAR SON ID -------------------------------
USE [domy59]
GO
CREATE PROCEDURE [dbo].[spUpdateInterventionById]
	@pIdIntervention int,
	@pCompteRendu TEXT = NULL,
	@pDebutIntervention DATETIME ,
	@pFinIntervention   DATETIME ,
	@pObjectifVisite TEXT ,
	@pPhotoLieu VARBINARY(MAX) = NULL,
	@pNomContact      NVARCHAR (30) ,
	@pPrenomContact   NVARCHAR (20) ,
	@pTelContact      NVARCHAR (12) ,
	@pEtatVisite      NVARCHAR (25) ,
	@pFkLoginE        NVARCHAR (25) ,
	@pFkIdClient      INT,
	@pFkLoginT        NVARCHAR (25)
AS
	BEGIN
		SET NOCOUNT ON;
		UPDATE [dbo].[intervention]
			SET [compteRendu]=@pCompteRendu, [debutIntervention]=@pDebutIntervention, [finIntervention]=@pFinIntervention, 
			[objectifVisite]=@pObjectifVisite, [photoLieu]=@pPhotoLieu, 
			[nomContact]=@pNomContact, [prenomContact]=@pPrenomContact, [telContact]=@pTelContact , [etatVisite]=@pEtatVisite, 
			[fkLoginE]=@pFkLoginE, [fkIdClient]=@pFkIdClient, [fkLoginT]=@pFkLoginT
		WHERE  [idIntervention] = @pIdIntervention
	END
GO
	
----------------------------------------------------------------------------------------
-- Procédures liées à la table client
----------------------------------------------------------------------------------------
-- comprendre transaction
-- http://blog.cellenza.com/data/sql-server/les-transactions-sous-sql-server-2012-partie-1/
------------- CREER OU MODIFIER UN CLIENT ----------------------------------------------
USE [domy59]
GO
CREATE PROCEDURE [dbo].[spInsUpdateClient] 
@pIdClient int,
@pEntreprise NVARCHAR(75),
@pFkIdCivilite int,
@pPrenom NVARCHAR(20),
@pNom NVARCHAR(30),
@pAdresse NVARCHAR(75),
@pCompAdresse NVARCHAR (75)= NULL,
@pCodepostal NVARCHAR(10), 
@pVille NVARCHAR(30),
@pNumeroTel NVARCHAR(12),
@pEmail NVARCHAR(30),
@pPhotoent VARBINARY(MAX) = NULL,
@pLatitude NVARCHAR(20) = NULL,
@pLongitude NVARCHAR(20) = NULL,
@pFkIdEtatClient int,
@pLoginE NVARCHAR (25) 

AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	IF NOT EXISTS (SELECT idClient FROM [dbo].[client]	WHERE prenom = @pPrenom AND nom = @pNom)
			BEGIN
			INSERT INTO [dbo].[client]
				([entreprise],[fkIdCivilite],[prenom],[nom],[adresse],[compAdresse],[codePostal],[ville],
				[numeroTel],[email],[photoent],[latitude],[longitude],[dateCreation],[fkIdEtatClient],[fkLoginE])
				SELECT @pEntreprise,@pFkIdCivilite,@pPrenom,@pNom,@pAdresse,@pCompAdresse,@pCodepostal,@pVille,
				@pNumeroTel,@pEmail,@pPhotoent,@pLatitude,@pLongitude,GETDATE(),@pFkIdEtatClient,@pLoginE		
			END
	ELSE
		UPDATE [dbo].[client]
			SET [entreprise] = @pEntreprise, [fkIdCivilite]=@pFkIdCivilite,[prenom] = @pPrenom, [nom] = @pNom, 
				[adresse] = @pAdresse,[compAdresse] = @pCompAdresse, [codePostal] = @pCodePostal,
				[ville]=@pVille, [numeroTel] = @pNumeroTel,[email]=@pEmail, [photoent] = @pPhotoent , 
				[latitude] = @pLatitude, [longitude] = @pLongitude,[dateModification]=GETDATE(),[fkIdEtatClient]=@pFkIdEtatClient,[fKLoginE]=@pLoginE
			WHERE  (([idClient] = @pIdClient OR @pIdClient IS NULL) OR
					(([nom]=@pNom OR @pNom IS NULL)AND([prenom]=@pPrenom OR @pPrenom IS NULL))
					)	
	
		-- Begin Return Select 
	SELECT [idClient], [entreprise],[fkIdCivilite],[prenom],[nom],[adresse],[compAdresse],[codePostal],[ville],
		[numeroTel],[email],[photoent],[latitude],[longitude],[dateCreation],[dateModification],[fkIdEtatClient],[fkLoginE]
		FROM   [dbo].[client] 
		WHERE  [idClient] = @pIdClient			
		-- End Return Select 
	COMMIT
GO

------------- RECUPERER UN CLIENT --------------------------------------------------------
-- On récupère un client soit avec son id soit si on connait à la fois son prenom et son nom
USE [domy59]
GO
CREATE PROCEDURE [dbo].[spGetClient]
@pIdClient int,
@pPrenom NVARCHAR(20),
@pNom NVARCHAR(30)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN
		SELECT [idClient], [entreprise],[fkIdCivilite],[prenom],[nom],[adresse],[compAdresse],[codePostal],[ville],[numeroTel],[email],
		[photoent],[latitude],[longitude],[dateCreation],[dateModification],[fkIdEtatClient],[fkLoginE]
		FROM   [dbo].[client] 
		WHERE  (([idClient] = @pIdClient OR @pIdClient IS NULL) OR
		(([nom]=@pNom OR @pNom IS NULL)AND([prenom]=@pPrenom OR @pPrenom IS NULL))
		)	
	END
GO

------------- SUPPRIMER UN CLIENT --------------------------------------------------------
USE [domy59]
GO
CREATE PROC [dbo].[spClientDelete] 
    @pIdClient int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  	
	BEGIN 
		DELETE
		FROM   [dbo].[Client]
		WHERE  [idClient] =  @pIdClient
	END
GO

----------------------------------------------------------------------------------------
-- Procédures liées à la table employé
----------------------------------------------------------------------------------------
------------- SUPPRIMER UN EMPLOYE (utiliser avec précaution) --------------------------
USE [domy59]
GO
CREATE PROC [dbo].[spEmployeDelete] 
    @pLoginE NVARCHAR (25) 
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
		DELETE
		FROM   [dbo].[employe]
		WHERE  [loginE] =  @pLoginE
	COMMIT
GO

------------- INSERER ou METTRE A JOUR UN EMPLOYE --------------------------------------
USE [domy59]
GO
CREATE PROCEDURE [dbo].[spInsUpdateEmploye]
@pLoginE NVARCHAR (25),
@pPrenom NVARCHAR(20),
@pNom NVARCHAR(30),
@pGroupe NVARCHAR (25)

AS
	SET NOCOUNT ON 
	SET XACT_ABORT ON 
	BEGIN TRAN 
		IF NOT EXISTS (SELECT loginE FROM [dbo].[employe] 
		WHERE loginE = @pLoginE) 
			BEGIN
				INSERT INTO [employe] (
					[loginE],[prenom],[nom],[groupe]
				) VALUES ( 
					@pLoginE,@pPrenom,@pNom,@pGroupe) 
			END
    	ELSE
			BEGIN
				UPDATE  [employe]
				SET     prenom = @pPrenom,nom = @pNom,groupe=@pGroupe
				WHERE   loginE = @pLoginE	
			END
	COMMIT
GO
------------- RECUPERER UN EMPLOYE --------------------------------------------------------
-- On récupère un employe soit avec son loginE soit si on connait à la fois son prenom et son nom
USE [domy59]
GO
CREATE PROCEDURE [dbo].[spGetEmploye]
@pLoginE NVARCHAR (25),
@pPrenom NVARCHAR(20),
@pNom NVARCHAR(30)

AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN 
		SELECT [loginE], [prenom],[nom],[groupe]
		FROM   [dbo].[employe] 
		WHERE  (([loginE] = @pLoginE OR @pLoginE IS NULL) OR
		(([nom]=@pNom OR @pNom IS NULL)AND([prenom]=@pPrenom OR @pPrenom IS NULL))
		)	
	END
GO
----------------------------------------------------------------------------------------
-- Procédures liées à la table Technicien
----------------------------------------------------------------------------------------
------------- SUPPRIMER UN TECHNICIEN(utiliser avec précaution) --------------------------
USE [domy59]
GO
	CREATE PROC [dbo].[spTechnicienDelete] 
    @pLoginT NVARCHAR (25) 
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN 
		DELETE
		FROM   [dbo].[technicien]
		WHERE  [loginT] =  @pLoginT
	END
GO

------------- INSERER ou METTRE A JOUR UN TECHNICIEN --------------------------------------
USE [domy59]
GO
CREATE PROCEDURE [dbo].[spInsUpdateTechnicien]
@pLoginT NVARCHAR (25),
@pPrenom NVARCHAR(20),
@pNom NVARCHAR(30),
@pPasswdT NVARCHAR(32) = NULL,
@pFkIdMateriel INT = NULL

AS
	SET NOCOUNT ON 
	SET XACT_ABORT ON 
	
	BEGIN  
		IF NOT EXISTS (SELECT loginT FROM [dbo].[technicien] 
		WHERE loginT = @pLoginT) 
			BEGIN
				INSERT INTO [technicien] (
					[loginT],[prenom],[nom],[passwdT],[fkIdMateriel]
				) VALUES ( 
					@pLoginT,@pPrenom,@pNom,@pPasswdT,@pFkIdMateriel) 
			END
    	ELSE
			BEGIN
				UPDATE  [technicien]
				SET     prenom = @pPrenom, nom = @pNom, passwdT=PasswdT, fkIdMateriel = @pFkIdMateriel
				WHERE   loginT = @pLoginT	
			END
	END
GO

------------- RECUPERER UN TECHNICIEN --------------------------------------------------------
-- On récupère un technicien soit avec son loginT soit si on connait à la fois son prenom et son nom soit on connait le materiel affecté
USE [domy59]
GO
CREATE PROCEDURE [dbo].[spGetTechnicien]
@pLoginT NVARCHAR (25),
@pPrenom NVARCHAR(20),
@pNom NVARCHAR(30),
@pIdMateriel INT = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN 
		SELECT [loginT], [prenom],[nom],[passwdT],[fkIdMateriel]
		FROM   [dbo].[technicien] 
		WHERE  (([loginT] = @pLoginT OR @pLoginT IS NULL) OR ([fkIdMateriel] = @pIdMateriel OR @pIdMateriel IS NULL) OR
		(([nom]=@pNom OR @pNom IS NULL)AND([prenom]=@pPrenom OR @pPrenom IS NULL))
		)	
	END
GO
----------------------------------------------------------------------------------------
-- PROCEDURES LIEES A LA POSITION D'UN TECHNICIEN
----------------------------------------------------------------------------------------
------------- INSERER ou METTRE A JOUR LA POSITION D'UN TECHNICIEN ---------------------
USE [domy59]
GO
CREATE PROCEDURE [dbo].[spInsUpdatePosTechnicien]
@pLatitude NVARCHAR (15) ,
@pLongitude NVARCHAR (15) ,
@pLoginT NVARCHAR (25)

AS
	BEGIN TRAN 
		IF NOT EXISTS (SELECT fkLoginT FROM [dbo].[positionTechnicien] 
		WHERE fkLoginT = @pLoginT) 
			BEGIN
				INSERT INTO [positionTechnicien] (
					[latitude],[longitude],[datepos],[fkLoginT]
				) VALUES ( 
					@pLatitude ,@pLongitude,GETDATE(),@pLoginT) 
			END
    	ELSE
			BEGIN
				UPDATE  [positionTechnicien]
				SET     latitude = @pLatitude, longitude = @pLongitude, datepos = GETDATE()
				WHERE   fkLoginT = @pLoginT	
			END
	COMMIT
GO

------------- RECUPERER LA POSITION D'UN TECHNICIEN ---------------------
USE [domy59]
GO
CREATE PROCEDURE [dbo].[spGetPosTechnicien]
@pLoginT NVARCHAR (25)
AS
	BEGIN
		SELECT latitude, longitude, datepos FROM positionTechnicien 
		WHERE fkLoginT = @pLoginT
	END
GO

------------- INSERER ou METTRE A JOUR LA SESSION D'UN TECHNICIEN ---------------------
USE [domy59]
GO
CREATE PROCEDURE [dbo].[spInsUpdateSessionTechnicien]
@pIdSession INT = NULL,
@pJeton NVARCHAR(255),
@pLoginT NVARCHAR (25)
AS
	BEGIN TRAN 
		IF NOT EXISTS (SELECT fkLoginT FROM [dbo].[sessionTechnicien] 
		WHERE fkLoginT = @pLoginT) 
			BEGIN
				INSERT INTO [sessionTechnicien] (
					[jeton],[dateDerniereRequete],[fkLoginT]
				) VALUES ( 
					@pJeton ,GETDATE(),@pLoginT) 
			END
    	ELSE
			BEGIN
				UPDATE  [sessionTechnicien]
				SET     jeton = @pJeton, dateDerniereRequete = GETDATE()
				WHERE   fkLoginT = @pLoginT	
			END
	COMMIT
GO

----------------------------------------------------------------------------------------
-- Procédures liées à la table Matériel
----------------------------------------------------------------------------------------

------------- ENREGISTRER OU MODIFIER LES DONNEES D'UN MATERIEL --------------------------------------
USE [domy59]
GO
CREATE PROCEDURE [dbo].[spInsUpdateMateriel] 
@pTypeMateriel NVARCHAR(100),
@pNumeroSerie NVARCHAR (50),
@pNumerotel NVARCHAR(12)= NULL,
@pImei NVARCHAR(17)= NULL, 
@pIdGoogle TEXT= NULL,
@pLoginE NVARCHAR (25),
@pEtatMateriel NVARCHAR (15)

AS
	BEGIN TRAN 
		IF NOT EXISTS (SELECT numeroSerie FROM [dbo].[materiel] 
		WHERE numeroSerie = @pNumeroSerie) 
			BEGIN
				INSERT INTO [materiel] (
					[typeMateriel], [numeroSerie], [numeroTel], [imei], [idGoogle], [dateEnregistrement], [fkLoginE], [etatMateriel]
				) VALUES ( 
					@pTypeMateriel,@pNumeroSerie,@pNumerotel,@pImei,@pIdGoogle,GETDATE(),@pLoginE ,@pEtatMateriel) 
			END
    	ELSE
			BEGIN
				UPDATE  [materiel]
				SET     typeMateriel = @pTypeMateriel, numeroTel = @pNumerotel, imei=@pImei, idGoogle= @pIdGoogle, fkLoginE=@pLoginE, etatMateriel=@pEtatMateriel
				WHERE   numeroSerie = @pNumeroSerie	
			END
	COMMIT
GO

------------- SUPPRIMER UN MATERIEL (utiliser avec précaution) --------------------------
USE [domy59]
GO
CREATE PROC [dbo].[spMaterielDelete] 
    @pIdMateriel INT
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	BEGIN 
		DELETE
		FROM   [dbo].[materiel]
		WHERE  [idMateriel] =  @pIdMateriel
	END
GO
----------------------------------------------------------------------------------------
-- Procédures METIER
----------------------------------------------------------------------------------------
------------- AFFECTER UN NOUVEAU MATERIEL A UN TECHNICIEN -----------------------------

USE [domy59]
GO
CREATE PROCEDURE [dbo].[spAffectationMatériel] 
@pIdMateriel INT,
@pNumerotel NVARCHAR(12) = NULL,
@pImei NVARCHAR(17) = NULL, 
@pIdGoogle TEXT = NULL,
@pLoginT NVARCHAR (25) ,
@pLoginE NVARCHAR (25) ,
@pEtatMateriel NVARCHAR (15)

AS
	BEGIN TRAN
		UPDATE [dbo].[materiel]
			SET    [numeroTel] = @pNumerotel, [imei]=@pImei, [idGoogle] = @pIdGoogle, [dateAffectation] = GETDATE(), [fkLoginE] = @pLoginE, [etatMateriel] = @pEtatMateriel
				WHERE  [idMateriel] = @pIdMateriel
			SELECT [idMateriel], [numeroTel], [imei], [idGoogle], [dateAffectation], [fkLoginE], [etatMateriel]
			FROM   [dbo].[materiel] 
				WHERE  [idMateriel] = @pIdMateriel

		UPDATE  [dbo].[technicien]
		SET     technicien.fkIdMateriel = @pIdMateriel
			WHERE   loginT = @pLoginT
		SELECT [loginT], [prenom],[nom],[passwdT],[fkIdMateriel]
		FROM   [dbo].[technicien] 
			WHERE  loginT = @pLoginT	
	COMMIT
GO


