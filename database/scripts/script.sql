-- Creación de la tabla Usuario
CREATE TABLE Usuario (
  id INT PRIMARY KEY,
  nombres VARCHAR(60),
  apellidos VARCHAR(60),
  email VARCHAR(100),
  username VARCHAR(30),
  password VARCHAR(20),
  contrasena VARCHAR(255)
);

-- Creación de la tabla Tablero
CREATE TABLE Tablero (
  idTablero INT PRIMARY KEY,
  nombre VARCHAR(255),
  idUsuario INT,
  FOREIGN KEY (idUsuario) REFERENCES Usuario(idUsuario)
);

-- Creación de la tabla Tarea
CREATE TABLE Tarea (
  id INT PRIMARY KEY,
  nombre VARCHAR(255),
  descripcion VARCHAR(255),
  fechaVencimiento DATE,
  estado ENUM('Pendiente', 'En Progreso', 'Terminado'),
  importancia INT,
  idTablero INT,
  FOREIGN KEY (idTablero) REFERENCES Tablero(idTablero)
);