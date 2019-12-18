CREATE TABLE [dbo].[User]
(
    [id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [email] NCHAR(50) NOT NULL, 
    [mdp] NCHAR(50) NOT NULL,
    [nom] NCHAR(50) NOT NULL,
    [prenom] NCHAR(50) NOT NULL,
    [adresse] NCHAR(256) NOT NULL,
)

CREATE TABLE [dbo].[Offre]
(
    [id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [titre] NCHAR(50) NULL, 
    [description] NCHAR(200) NULL, 
    [photo] NCHAR(50) NULL, 
    [prix] DECIMAL(10,2) NULL,
    [userId] INT NOT NULL,
    CONSTRAINT [fk_user] FOREIGN KEY ([userId]) 
    REFERENCES [User](id)
)   

SET IDENTITY_INSERT [dbo].[User] ON
INSERT INTO [dbo].[User] ([id], [email], [mdp], [nom], [prenom], [adresse]) VALUES (1, 'matthieu@rodrigues.fr', '12346789', 'Rodrigues', 'Matthieu', 'Chez Matthieu')
INSERT INTO [dbo].[User] ([id], [email], [mdp], [nom], [prenom], [adresse]) VALUES (2, 'lilian@berna.fr', '12346789', 'Berna', 'Lilian', 'Chez Lilian')
INSERT INTO [dbo].[User] ([id], [email], [mdp], [nom], [prenom], [adresse]) VALUES (3, 'benjamin@gonzalez.fr', '12346789', 'Gonzalez', 'Benjamin', 'Chez Benjamin')
SET IDENTITY_INSERT [dbo].[User] OFF

SET IDENTITY_INSERT [dbo].[Offre] ON
INSERT INTO [dbo].[Offre] ([id], [titre], [description], [photo], [prix], [userId]) VALUES (1, 'Matthieu le Raton', 'Matthieu est un adorable raton calin', 'raton.png', 12.00, 1)
INSERT INTO [dbo].[Offre] ([id], [titre], [description], [photo], [prix], [userId]) VALUES (2, 'Lilian le Kraken', 'Lilian est en gentil kraken affectif', 'kraken.png', 10.00, 2)
INSERT INTO [dbo].[Offre] ([id], [titre], [description], [photo], [prix], [userId]) VALUES (3, 'Benjamin Lécureuil', 'Benjamin est un écureuil curieux', 'ecu.png', 100.00, 3)
SET IDENTITY_INSERT [dbo].[Offre] OFF