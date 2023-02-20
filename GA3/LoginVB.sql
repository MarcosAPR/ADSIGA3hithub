create database Login5CA
use Login5CA


create table Usuarios (id_usuario int primary key not null,contraseña varchar(20), Nombre varchar (50), Roll varchar(50))
 --drop table usuarios
 insert into Usuarios values(1,'Vale2000ria','Valeria Maria de la Cruz','Secretaria')
  insert into Usuarios values(2,'rocky777',' Julia Del Valle','Secretaria')
   insert into Usuarios values(3,'LagorRivers','Lupe Rivera','Secretaria')
   Select * from Usuarios 

  insert into Usuarios values(4,'rubiuconh','Edwin Steve Cruz Pérez','Administrador')
  insert into Usuarios values(5,'kafkafkaf','Julian Alejandoro Xitumul','Administrador')
   insert into Usuarios values(6,'Themusicmaster','Fernando Andres Garcia Granados','Administrador')

  insert into Usuarios values(7,'casemiroCR7','Gerardo Garcia','Cliente')
  insert into Usuarios values(8,'Krnlsndr','Karen Alesandra','Cliente')
   insert into Usuarios  values(9,'123abcXD','Carlos Cifuentes','Cliente')
   Select * from Usuarios  where nombre = 'Gerardo Garcia' and contraseña = 'casemiroCR7'

 
