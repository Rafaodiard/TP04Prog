
USE [Album2026]
GO
/****** Object:  Table [dbo].[Figuritas]    Script Date: 7/5/2026 6:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Figuritas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [int] NOT NULL,
	[idJugador] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jugadores]    Script Date: 7/5/2026 6:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jugadores](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Posicion] [varchar](50) NOT NULL,
	[Ncamiseta] [int] NOT NULL,
	[IdSeleccion] [int] NOT NULL,
	[Imagen] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Selecciones]    Script Date: 7/5/2026 6:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Selecciones](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Grupo] [varchar](1) NOT NULL,
 CONSTRAINT [PK__Seleccio__3214EC2744E11ADD] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 7/5/2026 6:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuariosFiguritas]    Script Date: 7/5/2026 6:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuariosFiguritas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [int] NOT NULL,
	[idFigurita] [int] NOT NULL,
	[Pegada] [bit] NOT NULL,
	[Cantidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Figuritas] ON 

INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (1, 1, 1)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (2, 2, 2)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (3, 3, 3)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (4, 4, 4)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (5, 5, 5)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (6, 6, 6)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (7, 7, 7)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (8, 8, 8)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (9, 9, 9)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (10, 10, 10)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (11, 11, 11)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (12, 12, 12)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (13, 13, 13)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (14, 14, 14)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (15, 15, 15)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (16, 16, 16)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (17, 17, 17)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (18, 18, 18)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (19, 19, 19)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (20, 20, 20)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (21, 21, 21)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (22, 22, 22)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (23, 23, 23)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (24, 24, 24)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (25, 25, 25)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (26, 26, 26)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (27, 27, 27)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (28, 28, 28)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (29, 29, 29)
INSERT [dbo].[Figuritas] ([ID], [Numero], [idJugador]) VALUES (30, 30, 30)
SET IDENTITY_INSERT [dbo].[Figuritas] OFF
GO
SET IDENTITY_INSERT [dbo].[Jugadores] ON 

INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (1, N'Lionel Messi', N'Delantero', 10, 1, N'messi.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (2, N'Julián Álvarez', N'Delantero', 9, 1, N'alvarez.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (3, N'Emiliano Martínez', N'Arquero', 23, 1, N'emiliano.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (4, N'Enzo Fernández', N'Mediocampista', 24, 1, N'enzo.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (5, N'Cristian Romero', N'Defensor', 13, 1, N'romero.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (6, N'Neymar Jr.', N'Delantero', 10, 2, N'neymar.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (7, N'Vinícius Júnior', N'Delantero', 7, 2, N'vinicius.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (8, N'Alisson Becker', N'Arquero', 1, 2, N'alisson.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (9, N'Casemiro', N'Mediocampista', 5, 2, N'casemiro.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (10, N'Marquinhos', N'Defensor', 4, 2, N'marquinhos.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (11, N'Pedri', N'Mediocampista', 20, 3, N'pedri.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (12, N'Gavi', N'Mediocampista', 9, 3, N'gavi.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (13, N'Unai Simón', N'Arquero', 23, 3, N'unai.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (14, N'Ferran Torres', N'Delantero', 11, 3, N'ferran.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (15, N'Pau Cubarsí', N'Defensor', 14, 3, N'pau.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (16, N'Kylian Mbappé', N'Delantero', 10, 4, N'mbappe.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (17, N'Antoine Griezmann', N'Delantero', 7, 4, N'griezmann.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (18, N'Hugo Lloris', N'Arquero', 1, 4, N'lloris.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (19, N'Eduardo Camavinga', N'Mediocampista', 6, 4, N'camavinga.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (20, N'Raphaël Varane', N'Defensor', 4, 4, N'varane.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (21, N'Thomas Müller', N'Delantero', 13, 5, N'muller.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (22, N'Joshua Kimmich', N'Mediocampista', 6, 5, N'kimmich.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (23, N'Manuel Neuer', N'Arquero', 1, 5, N'neuer.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (24, N'Kai Havertz', N'Delantero', 7, 5, N'havertz.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (25, N'Antonio Rüdiger', N'Defensor', 2, 5, N'rudiger.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (26, N'Harry Kane', N'Delantero', 9, 6, N'kane.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (27, N'Bukayo Saka', N'Delantero', 7, 6, N'saka.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (28, N'Jordan Pickford', N'Arquero', 1, 6, N'pickford.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (29, N'Jude Bellingham', N'Mediocampista', 10, 6, N'bellingham.svg')
INSERT [dbo].[Jugadores] ([ID], [Nombre], [Posicion], [Ncamiseta], [IdSeleccion], [Imagen]) VALUES (30, N'Harry Maguire', N'Defensor', 6, 6, N'maguire.svg')
SET IDENTITY_INSERT [dbo].[Jugadores] OFF
GO
SET IDENTITY_INSERT [dbo].[Selecciones] ON 

INSERT [dbo].[Selecciones] ([ID], [Nombre], [Grupo]) VALUES (1, N'Argentina', N'A')
INSERT [dbo].[Selecciones] ([ID], [Nombre], [Grupo]) VALUES (2, N'Brasil', N'B')
INSERT [dbo].[Selecciones] ([ID], [Nombre], [Grupo]) VALUES (3, N'España', N'C')
INSERT [dbo].[Selecciones] ([ID], [Nombre], [Grupo]) VALUES (4, N'Francia', N'D')
INSERT [dbo].[Selecciones] ([ID], [Nombre], [Grupo]) VALUES (5, N'Alemania', N'E')
INSERT [dbo].[Selecciones] ([ID], [Nombre], [Grupo]) VALUES (6, N'Inglaterra', N'F')
SET IDENTITY_INSERT [dbo].[Selecciones] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([ID], [Nombre], [Usuario], [Password]) VALUES (1, N'rafa', N'rafa12', N'12345')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[UsuariosFiguritas] ON 

INSERT [dbo].[UsuariosFiguritas] ([ID], [idUsuario], [idFigurita], [Pegada], [Cantidad]) VALUES (4, 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[UsuariosFiguritas] OFF
GO
ALTER TABLE [dbo].[UsuariosFiguritas] ADD  DEFAULT ((0)) FOR [Pegada]
GO
ALTER TABLE [dbo].[UsuariosFiguritas] ADD  DEFAULT ((1)) FOR [Cantidad]
GO
ALTER TABLE [dbo].[Figuritas]  WITH CHECK ADD  CONSTRAINT [FK_Figuritas_Jugadores] FOREIGN KEY([idJugador])
REFERENCES [dbo].[Jugadores] ([ID])
GO
ALTER TABLE [dbo].[Figuritas] CHECK CONSTRAINT [FK_Figuritas_Jugadores]
GO
ALTER TABLE [dbo].[Jugadores]  WITH CHECK ADD  CONSTRAINT [FK_Jugadores_Selecciones] FOREIGN KEY([IdSeleccion])
REFERENCES [dbo].[Selecciones] ([ID])
GO
ALTER TABLE [dbo].[Jugadores] CHECK CONSTRAINT [FK_Jugadores_Selecciones]
GO
ALTER TABLE [dbo].[UsuariosFiguritas]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosFiguritas_Figuritas] FOREIGN KEY([idFigurita])
REFERENCES [dbo].[Figuritas] ([ID])
GO
ALTER TABLE [dbo].[UsuariosFiguritas] CHECK CONSTRAINT [FK_UsuariosFiguritas_Figuritas]
GO
ALTER TABLE [dbo].[UsuariosFiguritas]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosFiguritas_Usuarios] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuarios] ([ID])
GO
ALTER TABLE [dbo].[UsuariosFiguritas] CHECK CONSTRAINT [FK_UsuariosFiguritas_Usuarios]
GO
USE [master]
GO
ALTER DATABASE [Album2026] SET  READ_WRITE 
GO
