create procedure EmpresaByCodigoNombre @codigo char(2)=null, @nombre nvarchar(70)=null
as
if (@nombre is null)
begin
	select * from TblEmpresas where EmpresaCodigo=@codigo;
end
else
begin
	if(@codigo is null)
	begin
		select * from TblEmpresas where Nombre=@nombre;
	end
	else
	begin
		select * from TblEmpresas where EmpresaCodigo=@codigo and Nombre=@nombre;
	end
end
go

create procedure PuestosByEmpresa
as
select TblEmpresas.EmpresaID,TblEmpresas.EmpresaCodigo,TblEmpresas.Nombre,COUNT(TblPuestos.PuestoID) as Cantidad_Puestos from TblEmpresas
inner join TblPuestos on TblEmpresas.EmpresaID=TblPuestos.EmpresaID group by TblEmpresas.EmpresaID,TblEmpresas.EmpresaCodigo,TblEmpresas.Nombre;
go

create procedure ModifyEmpressName @newName nvarchar(70),@empresaCodigo integer
as
begin try
	update TblEmpresas set Nombre=@newName where EmpresaCodigo=@empresaCodigo;
	select * from TblEmpresas where EmpresaCodigo=@empresaCodigo;
end try
begin catch
	SELECT  
        ERROR_NUMBER() AS ErrorNumber  
        ,ERROR_SEVERITY() AS ErrorSeverity  
        ,ERROR_STATE() AS ErrorState  
        ,ERROR_PROCEDURE() AS ErrorProcedure  
        ,ERROR_LINE() AS ErrorLine  
        ,ERROR_MESSAGE() AS ErrorMessage;
end catch
go

create procedure PuestosActivosByEmpresa
as
select TblEmpresas.EmpresaID,TblEmpresas.EmpresaCodigo,TblEmpresas.Nombre,COUNT(TblPuestos.PuestoID) as Cantidad_Puestos_Activos from TblEmpresas
inner join TblPuestos on TblEmpresas.EmpresaID=TblPuestos.EmpresaID where TblPuestos.FechaDeBaja IS NULL group by TblEmpresas.EmpresaID,TblEmpresas.EmpresaCodigo,TblEmpresas.Nombre;
go

create procedure PorcentajePuestosActivos
as
select EmpresaID,EmpresaCodigo,Nombre,ROUND((convert(float,Cantidad_Puestos_Activos)/convert(float,Cantidad_Puestos_Total)) * 100,2) as Puestos_Activos_porcentaje,Cantidad_Puestos_Activos,Cantidad_Puestos_Total from (
select externo.EmpresaID,externo.EmpresaCodigo,externo.Nombre,COUNT(TblPuestos.PuestoID) as Cantidad_Puestos_Activos,(select COUNT(TblPuestos.PuestoID) as Cantidad_Puestos from TblEmpresas
inner join TblPuestos on TblEmpresas.EmpresaID=TblPuestos.EmpresaID where TblEmpresas.EmpresaID=externo.EmpresaID) as Cantidad_Puestos_Total from TblEmpresas as externo
inner join TblPuestos on externo.EmpresaID=TblPuestos.EmpresaID where TblPuestos.FechaDeBaja IS NOT NULL group by externo.EmpresaID,externo.EmpresaCodigo,externo.Nombre
) final
go

exec EmpresaByCodigoNombre @codigo=null,@nombre="Empresa San Diego"
exec PuestosByEmpresa
exec ModifyEmpressName @newName="Empresa", @empresaCodigo=01
exec PuestosActivosByEmpresa
exec PorcentajePuestosActivos