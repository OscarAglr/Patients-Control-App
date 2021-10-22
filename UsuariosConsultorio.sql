use Consultorio
go
Create login AdminConsultorio with password = 'Hospital#100'
go

Create table Usuario 
(idUsuario int primary key identity(1,1),
 Usuario varchar(50),
 contrasenia varchar(100),
 rol varchar(50),
 estado varchar(50))

 Create procedure [dbo].[InsertarUsuario]
 @usuario varchar(50), @contra varchar(50), @rol varchar(50)
 as
 Insert into Usuario(Usuario, contrasenia, rol, estado)
 values
 (@usuario, ENCRYPTBYPASSPHRASE(@contra, @contra), @rol, 'Habilitado')

Exec dbo.InsertarUsuario 'Admin1', 'sistemas2021', 'Administrador'

Select * from Usuario

 Create procedure Validar_Acceso
 @Usuario varchar(50),
 @Contraseña varchar(50)
 as
 if exists (Select top 1 * from Usuario where Usuario = @usuario 
                   and DECRYPTBYPASSPHRASE(@Contraseña, contrasenia) = @Contraseña
				   and Estado = 'Habilitado')
				   begin
				   Select 'Acceso Exitoso'

				   end
				  else
				  Select 'Acceso Denegado'

Exec Validar_Acceso 'Admin1', 'sistemas2021'