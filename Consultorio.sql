create database Consultorio
go
Use Consultorio
go
create table Paciente
(NoPaciente int primary key identity (1,1),
PrimerNombre varchar (50),
SegundoNombre varchar (50),
PrimerApellido varchar (50),
SegundoApellido varchar (50),
FechaNacimiento date, 
Cedula varchar (50)
)

create table Medico
(NoMedico int primary key identity (1,1),
PrimerNombre varchar (50),
SegundoNombre varchar (50),
PrimerApellido varchar (50),
SegundoApellido varchar (50),
FechaNacimiento date, 
Cedula varchar (50)
)

Create table Consulta
(NoConsulta int primary key identity (1,1),
NoMedico int,
NoPaciente int, 
FechaConsulta date
)

Alter table Consulta 
add foreign key (NoMedico) References Medico(NoMedico)

Alter table Consulta 
add foreign key (NoPaciente) References Paciente(NoPaciente)


Create table Medicamento (
NoMedicamento int primary key identity (1,1),
Nombre varchar(50),
Componentes varchar (50)
)

Create table DetalleConsulta(
NoConsulta int, 
NoMedicamento int, 
Cantidad int, 
Dosis int, 
Descripcion varchar (50)
)

Alter table DetalleConsulta
add foreign key (NoConsulta) references Consulta (NoConsulta)
--------------------------------------------------------------
Alter table DetalleConsulta
add foreign key (NoMedicamento)
References Medicamento(NoMedicamento)
--------------------------------------------------------------
Alter table DetalleConsulta
Alter Column NoConsulta int not null

Alter table DetalleConsulta
Alter Column NoMedicamento int not null

Alter table DetalleConsulta
add primary key (NoConsulta, NoMedicamento)

/*=====================Rellenar base de datos===============*/

go
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Mellisa', 'Mikol', 'Baynham', 'Muff', '7/17/2002', '491-170702-4298');
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Ariadne', 'Henderson', 'Phripp', 'Gruby', '11/13/2015', null);
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Shay', 'Gasparo', 'Craister', 'Aberdein', '7/27/2015', null);
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Lola', 'Angie', 'Matityahu', 'Mallon', '5/13/2013', null);
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Sandy', 'Irina', 'Patel', 'Blazi', '10/28/1994', '181-281094-7193');
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Wit', null, 'Ponting', null, '7/15/1987', '142-150787-0596');
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Arluene', 'Raquela', 'Kornalik', 'Aubury', '2/4/1990', '557-040290-4736');
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Angeline', 'Barnard', 'Pionter', 'Gillon', '9/11/2020', null);
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Griffy', 'Tricia', 'Thomasson', 'Crinage', '1/20/2012', null);
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Bearnard', null, 'Nassie', null, '10/9/1991', '589-091091-5906');
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Nev', 'Jennie', 'Grayshan', 'Agostini', '8/26/1984', '376-260884-0360');
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Frayda', 'Virginia', 'Callum', 'Girt', '10/6/1989', '384-061089-4001');
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Linzy', 'Hubey', 'Copsey', 'Rigate', '5/8/2013', null);
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Horatia', null, 'Shall', null, '7/23/1993', '225-230793-8865');
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Frasquito', 'Gardener', 'Hazeup', 'Highwood', '11/17/2002', '784-171102-7886');
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Daniella', 'Arthur', 'Hirschmann', 'Barwis', '4/27/1981', '460-270481-5218');
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Dav', 'Eleen', 'Goman', 'Chanson', '7/23/2014', null);
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Welsh', 'Millard', 'Stukings', 'Roseaman', '12/6/2004', '166-061204-6796');
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Toddie', 'Elvina', 'Hugin', 'Arundell', '9/20/1988', '295-200988-4444');
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Dodie', 'Sherill', 'Mattis', 'Sazio', '1/31/2013', null);
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Ambros', 'Ezri', 'Shewry', 'Gallier', '5/28/1990', '144-280590-0159');
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Rudolfo', 'Anselma', 'Kisar', 'Besnardeau', '3/10/1985', '126-100385-2677');
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Stephie', 'Aurel', 'Hauck', 'Teager', '3/11/2015', null);
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Erhart', 'Ethelred', 'Capner', 'Losebie', '8/16/2021', null);
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Jerry', 'Chantalle', 'Ayree', 'Candie', '8/1/2013', null);
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Saree', 'Jarrid', 'Luxmoore', 'Avramovsky', '9/2/1989', '518-020989-9668');
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Daniella', 'Maryjane', 'Novakovic', 'Casarili', '12/1/2019', null);
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Joice', 'Jenelle', 'Tirrey', 'Tommei', '2/14/1997', '491-140297-2041');
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Chelsie', 'Olympia', 'Paolini', 'Borrowman', '6/14/1988', '727-140688-2447');
insert into Paciente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Ofilia', 'Kiele', 'Mowsley', 'Broderick', '5/14/2021', null);
go
insert into Medico (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Dayle', 'Lucila', 'Jenkison', 'Paule', '12/7/1988', '001-071288-0356V');
insert into Medico (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Dosi', 'Zelma', 'Melwall', 'Rhymer', '9/23/1981', '123-230981-7166S');
insert into Medico (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Katheryn', 'Loree', 'Bangham', 'Cottam', '2/18/1976', '001-180276-3823N');
insert into Medico (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Shay', 'Minnie', 'Dayment', 'MacIlwrick', '12/28/1973', '021-281273-4803W');
insert into Medico (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaNacimiento, Cedula) values ('Alie', 'Zaccaria', 'Kidgell', 'Ygoe', '6/10/1987', '001-100687-1032K');
go
insert into Medicamento (Nombre, Componentes) values ('Simvastatina','simvastatina')
insert into Medicamento (Nombre, Componentes) values ('Aspirina','ácido acetilsalicílico')
insert into Medicamento (Nombre, Componentes) values ('Omeprazol','omeprazol')
insert into Medicamento (Nombre, Componentes) values ('Levotiroxina sódica','levotiroxina sódica')
insert into Medicamento (Nombre, Componentes) values ('Ramipril','ramipril')
insert into Medicamento (Nombre, Componentes) values ('Amlodipina','amlodipino (como besilato).')
insert into Medicamento (Nombre, Componentes) values ('Paracetamol','paracetamol')
insert into Medicamento (Nombre, Componentes) values ('Atorvastatina','atorvastatina')
insert into Medicamento (Nombre, Componentes) values ('Salbutamol','Salbutamol base (120 microg de Salbutamol sulfato)')
insert into Medicamento (Nombre, Componentes) values ('Lansoprazol','lansoprazol')
go

insert into Consulta (NoMedico,NoPaciente,FechaConsulta) values (2,18,'5/4/2021')
insert into Consulta (NoMedico,NoPaciente,FechaConsulta) values (1,26,'2/15/2021')
insert into Consulta (NoMedico,NoPaciente,FechaConsulta) values (3,28,'3/21/2021')
insert into Consulta (NoMedico,NoPaciente,FechaConsulta) values (4,22,'12/14/2020')
insert into Consulta (NoMedico,NoPaciente,FechaConsulta) values (5,9,'7/16/2021')
insert into Consulta (NoMedico,NoPaciente,FechaConsulta) values (5,27,'9/11/2021')
insert into Consulta (NoMedico,NoPaciente,FechaConsulta) values (3,3,'6/15/2021')
insert into Consulta (NoMedico,NoPaciente,FechaConsulta) values (2,17,'6/15/2021')
insert into Consulta (NoMedico,NoPaciente,FechaConsulta) values (4,26,'8/8/2021')
insert into Consulta (NoMedico,NoPaciente,FechaConsulta) values (1,19,'8/8/2021')
go
insert into DetalleConsulta (NoConsulta,NoMedicamento, Cantidad, Dosis, Descripcion) values (1,8,14,2,'Tomar 1 vez al día por una semana')
insert into DetalleConsulta (NoConsulta,NoMedicamento, Cantidad, Dosis, Descripcion) values (2,3,21,3,'Tomar 3 vez al día por dos semana cada 8h')
insert into DetalleConsulta (NoConsulta,NoMedicamento, Cantidad, Dosis, Descripcion) values (3,2,16,4,'Tomar 1 vez al día por cuatro dias ')
insert into DetalleConsulta (NoConsulta,NoMedicamento, Cantidad, Dosis, Descripcion) values (4,5,18,3,'Tomar 2 vez al día por tres dias cada 12h')
insert into DetalleConsulta (NoConsulta,NoMedicamento, Cantidad, Dosis, Descripcion) values (5,9,9,3,'Tomar 1 vez al día por tres dias cada 12h')
insert into DetalleConsulta (NoConsulta,NoMedicamento, Cantidad, Dosis, Descripcion) values (6,1,47,2,'Tomar 3 vez al día por una semana cada 8h')
insert into DetalleConsulta (NoConsulta,NoMedicamento, Cantidad, Dosis, Descripcion) values (7,10,14,2,'Tomar 1 vez al día por una semana')
insert into DetalleConsulta (NoConsulta,NoMedicamento, Cantidad, Dosis, Descripcion) values (8,7,28,2,'Tomar 2 vez al día por dos semana cada 12h')
insert into DetalleConsulta (NoConsulta,NoMedicamento, Cantidad, Dosis, Descripcion) values (9,4,28,2,'Tomar 2 vez al día por una semana cada 12h')
insert into DetalleConsulta (NoConsulta,NoMedicamento, Cantidad, Dosis, Descripcion) values (10,6,21,3,'Tomar 1 vez al día por una semana')