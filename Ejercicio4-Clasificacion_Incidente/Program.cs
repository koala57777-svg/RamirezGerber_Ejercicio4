Console.WriteLine("Ingrese el tipo de incidente (Número):");
Console.WriteLine("");
Console.WriteLine("1. Malware");
Console.WriteLine("2. Phishing");
Console.WriteLine("3. Acceso no autorizado");
Console.WriteLine("4. Fuga de información");
Console.WriteLine("");
int tipoIncidente = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese el activo afectado (Número): ");
Console.WriteLine("");
Console.WriteLine("1. PC");
Console.WriteLine("2. Servidor");
Console.WriteLine("3. Personales");
Console.WriteLine("4. Red");
Console.WriteLine("");
int activoAfectado = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese el tipo de dato que fue comprometido (Número): ");
Console.WriteLine("");
Console.WriteLine("1. Ninguno");
Console.WriteLine("2. Internos");
Console.WriteLine("3. Personales");
Console.WriteLine("4. Financieros");
Console.WriteLine("");
int tipoDatoComprometido = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("¿Hay persistencia? (S/N): ");
Console.WriteLine("");
string persistencia = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Ingrese el número de usuarios afectado: ");
Console.WriteLine("");
int numeroUsuariosAfectados = int.Parse(Console.ReadLine());

if (tipoDatoComprometido>=1 && tipoDatoComprometido<=4 && (persistencia=="S" || persistencia=="N") && numeroUsuariosAfectados >= 0)
{
    switch(tipoIncidente)
    {
        case 1:
            switch (activoAfectado)
            {

            }
            break;
        case 2:
            
            break;
        case 3:
            
            break;
        case 4:
            
            break;

        default:
                        Console.WriteLine("Tipo de incidente no válido.");
            break;
    }
}
else
{
    Console.WriteLine("Datos inváidos. Por favor ingresar datos válidos.");
}