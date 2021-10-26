--Procedimientos almacenados
use Consultorio
go

create procedure MostrarPacientes
as
Select 
NoPaciente as IDPaciente,
PrimerNombre + ' ' + COALESCE(SegundoNombre, '') + ' ' + PrimerApellido + ' ' + COALESCE(SegundoApellido, '') as [Nombre del paciente],
FechaNacimiento as [Fecha de nacimiento],
COALESCE(Cedula, '')
from Paciente

Alter procedure MostrarPacientes
as
Select 
NoPaciente as IDPaciente,
PrimerNombre + ' ' + COALESCE(SegundoNombre, '') + ' ' + PrimerApellido + ' ' + COALESCE(SegundoApellido, '') as [Nombre del paciente],
FechaNacimiento as [Fecha de nacimiento],
COALESCE(Cedula, '') as Cedula
from Paciente

Exec MostrarPacientes
go

Alter procedure MostrarMedicos
as
Select 
NoMedico as [Numero de medico],
PrimerNombre + ' ' + COALESCE(SegundoNombre, '') + ' ' + PrimerApellido + ' ' + COALESCE(SegundoApellido, '') as [Nombre del medico],
FechaNacimiento as [Fecha de nacimiento],
Cedula as [Numero de cedula]
from Medico

Exec MostrarMedicos
go

create procedure MostrarConsultas
as 
Select
NoConsulta as [Numero de consulta],
m.PrimerNombre + ' ' + COALESCE(m.SegundoNombre, '') + ' ' + m.PrimerApellido + ' ' + COALESCE(m.SegundoApellido, '') as [Nombre del medico],
p.PrimerNombre + ' ' + COALESCE(p.SegundoNombre, '') + ' ' + p.PrimerApellido + ' ' + COALESCE(p.SegundoApellido, '') as [Nombre del paciente],
FechaConsulta
from Consulta c
inner join Medico m
on m.NoMedico = c.NoMedico
inner join Paciente p
on p.NoPaciente = c.NoPaciente

exec MostrarConsultas
go

Select * from DetalleConsulta
go

create procedure MostrarUsuarios
as
Select idUsuario as IDUsuario,
Usuario as [Nombre de usuario],
rol as Rol,
estado as Estado
from Usuario