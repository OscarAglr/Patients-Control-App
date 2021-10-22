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

Exec MostrarPacientes
go

create procedure MostrarMedicos
as
Select * from Medico