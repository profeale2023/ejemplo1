Module ejercico4
Dim Nombre, Tipo as string
Dim Precio as integer

Sub main 
	Console.Writeline ("Ingrese un nombre ")
	Nombre= Console.readline()
	Console.Writeline ("Ingrese un precio ")
	Precio= Console.readline()
	Console.Writeline ("Ingrese un tipo (N o I) ")
	Tipo= Console.readline()
if Tipo = "N"
         Precio = Precio + (Precio * 5 / 100)
else
        Precio = Precio + (Precio * 12 / 100)
end if
	Console.Writeline (" El nuevo precio es  ")
	Console.Writeline (Precio) 
	Console.readline()
end sub
end module

