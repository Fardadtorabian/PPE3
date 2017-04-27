USE [domy59]
GO
CREATE VIEW viewPosTechniciensActifs AS
  SELECT technicien.loginT, technicien.prenom, technicien.nom, positionTechnicien.latitude, positionTechnicien.longitude, positionTechnicien.datepos
	FROM technicien
	INNER JOIN positionTechnicien ON positionTechnicien.fkLoginT = technicien.loginT
	INNER JOIN sessionTechnicien ON sessionTechnicien.fkLoginT = technicien.loginT 
  WHERE sessionTechnicien.jeton IS NOT NULL;
GO 
 
 USE [domy59]
	GO
CREATE VIEW [dbo].[viewAuthentificationTechnicien] AS
	SELECT technicien.loginT,technicien.passwdT,materiel.imei
	FROM technicien
	INNER JOIN materiel ON materiel.idMateriel=technicien.fkIdMateriel
WHERE materiel.etatMateriel='enService' AND imei IS NOT NULL;
GO
