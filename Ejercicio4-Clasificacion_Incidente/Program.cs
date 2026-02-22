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
Console.WriteLine("");

if (tipoDatoComprometido>=1 && tipoDatoComprometido<=4 && (persistencia=="S" || persistencia=="N") && numeroUsuariosAfectados >= 0)
{
    switch(tipoIncidente)
    {
        case 1:
            switch (activoAfectado)
            {
                case 1:
                    if (numeroUsuariosAfectados<100 || tipoDatoComprometido==1)
                    {
                        Console.WriteLine("Serevidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Supervisión baja");
                    }
                    else if (numeroUsuariosAfectados < 1000 || tipoDatoComprometido == 2)
                    {
                        Console.WriteLine("Serevidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervisión media");
                    }
                    else if ((numeroUsuariosAfectados < 5000 || tipoDatoComprometido == 3) && persistencia=="S")
                    {
                        Console.WriteLine("Serevidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Supervisión alta");
                    }
                    else if ((numeroUsuariosAfectados >= 5000 || tipoDatoComprometido == 3) && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Supervisión inmediata y activación de protocolos de seguridad máxima");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;

                case 2:
                    if (tipoDatoComprometido==1)
                    {
                        Console.WriteLine("Serevidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Supervisión baja");
                    }
                    else if(tipoDatoComprometido == 2)
                    {
                        Console.WriteLine("Serevidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervisión media");
                    }
                    else if (tipoDatoComprometido == 3 && persistencia=="S")
                    {
                        Console.WriteLine("Serevidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Supervisión alta");
                    }
                    else if (tipoDatoComprometido == 4 && persistencia=="S")
                    {
                        Console.WriteLine("Serevidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Supervisión inmediata y activación de protocolos de seguridad máxima");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;

                case 3:
                    if (tipoDatoComprometido == 3)
                    {
                        Console.WriteLine("Serevidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Supervisión baja");
                    }
                    else if (tipoDatoComprometido == 4)
                    {
                        Console.WriteLine("Serevidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervisión media");
                    }
                    else if (tipoDatoComprometido == 3 && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Supervisión alta");
                    }
                    else if (tipoDatoComprometido == 4 && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Supervisión inmediata y activación de protocolos de seguridad máxima");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;

                case 4:
                    if (tipoDatoComprometido == 2)
                    {
                        Console.WriteLine("Serevidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Supervisión baja");
                    }
                    else if (numeroUsuariosAfectados<1000)
                    {
                        Console.WriteLine("Serevidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervisión media");
                    }
                    else if (tipoDatoComprometido == 2 && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Supervisión alta");
                    }
                    else if (numeroUsuariosAfectados>=1000 && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Supervisión inmediata y activación de protocolos de seguridad máxima");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;

                default:
                    Console.WriteLine("Activo afectado no váido.");
                    break;
            }
            break;
        case 2:
            switch (activoAfectado)
            {
                case 1:
                    if (numeroUsuariosAfectados < 100 || tipoDatoComprometido == 1)
                    {
                        Console.WriteLine("Serevidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Supervisión baja");
                    }
                    else if (numeroUsuariosAfectados < 1000 || tipoDatoComprometido == 2)
                    {
                        Console.WriteLine("Serevidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervisión media");
                    }
                    else if ((numeroUsuariosAfectados < 5000 || tipoDatoComprometido == 3) && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Supervisión alta");
                    }
                    else if ((numeroUsuariosAfectados >= 5000 || tipoDatoComprometido == 3) && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Supervisión inmediata y activación de protocolos de seguridad máxima");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;

                case 2:
                    if (tipoDatoComprometido == 1)
                    {
                        Console.WriteLine("Serevidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Supervisión baja");
                    }
                    else if (tipoDatoComprometido == 2)
                    {
                        Console.WriteLine("Serevidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervisión media");
                    }
                    else if (tipoDatoComprometido == 3 && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Supervisión alta");
                    }
                    else if (tipoDatoComprometido == 4 && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Supervisión inmediata y activación de protocolos de seguridad máxima");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;

                case 3:
                    if (tipoDatoComprometido == 3)
                    {
                        Console.WriteLine("Serevidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Supervisión baja");
                    }
                    else if (tipoDatoComprometido == 4)
                    {
                        Console.WriteLine("Serevidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervisión media");
                    }
                    else if (tipoDatoComprometido == 3 && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Supervisión alta");
                    }
                    else if (tipoDatoComprometido == 4 && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Supervisión inmediata y activación de protocolos de seguridad máxima");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;

                case 4:
                    if (tipoDatoComprometido == 2)
                    {
                        Console.WriteLine("Serevidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Supervisión baja");
                    }
                    else if (numeroUsuariosAfectados < 1000)
                    {
                        Console.WriteLine("Serevidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervisión media");
                    }
                    else if (tipoDatoComprometido == 2 && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Supervisión alta");
                    }
                    else if (numeroUsuariosAfectados >= 1000 && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Supervisión inmediata y activación de protocolos de seguridad máxima");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;

                default:
                    Console.WriteLine("Activo afectado no váido.");
                    break;
            }
            break;
        case 3:
            switch (activoAfectado)
            {
                case 1:
                    if (numeroUsuariosAfectados < 100 || tipoDatoComprometido == 1)
                    {
                        Console.WriteLine("Serevidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Supervisión baja");
                    }
                    else if (numeroUsuariosAfectados < 1000 || tipoDatoComprometido == 2)
                    {
                        Console.WriteLine("Serevidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervisión media");
                    }
                    else if ((numeroUsuariosAfectados < 5000 || tipoDatoComprometido == 3) && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Supervisión alta");
                    }
                    else if ((numeroUsuariosAfectados >= 5000 || tipoDatoComprometido == 3) && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Supervisión inmediata y activación de protocolos de seguridad máxima");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;

                case 2:
                    if (tipoDatoComprometido == 1)
                    {
                        Console.WriteLine("Serevidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Supervisión baja");
                    }
                    else if (tipoDatoComprometido == 2)
                    {
                        Console.WriteLine("Serevidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervisión media");
                    }
                    else if (tipoDatoComprometido == 3 && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Supervisión alta");
                    }
                    else if (tipoDatoComprometido == 4 && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Supervisión inmediata y activación de protocolos de seguridad máxima");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;

                case 3:
                    if (tipoDatoComprometido == 3)
                    {
                        Console.WriteLine("Serevidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Supervisión baja");
                    }
                    else if (tipoDatoComprometido == 4)
                    {
                        Console.WriteLine("Serevidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervisión media");
                    }
                    else if (tipoDatoComprometido == 3 && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Supervisión alta");
                    }
                    else if (tipoDatoComprometido == 4 && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Supervisión inmediata y activación de protocolos de seguridad máxima");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;

                case 4:
                    if (tipoDatoComprometido == 2)
                    {
                        Console.WriteLine("Serevidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Supervisión baja");
                    }
                    else if (numeroUsuariosAfectados < 1000)
                    {
                        Console.WriteLine("Serevidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervisión media");
                    }
                    else if (tipoDatoComprometido == 2 && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Supervisión alta");
                    }
                    else if (numeroUsuariosAfectados >= 1000 && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Supervisión inmediata y activación de protocolos de seguridad máxima");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;

                default:
                    Console.WriteLine("Activo afectado no váido.");
                    break;
            }
            break;
        case 4:
            switch (activoAfectado)
            {
                case 1:
                    if (numeroUsuariosAfectados < 100 || tipoDatoComprometido == 1)
                    {
                        Console.WriteLine("Serevidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Supervisión baja");
                    }
                    else if (numeroUsuariosAfectados < 1000 || tipoDatoComprometido == 2)
                    {
                        Console.WriteLine("Serevidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervisión media");
                    }
                    else if ((numeroUsuariosAfectados < 5000 || tipoDatoComprometido == 3) && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Supervisión alta");
                    }
                    else if ((numeroUsuariosAfectados >= 5000 || tipoDatoComprometido == 3) && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Supervisión inmediata y activación de protocolos de seguridad máxima");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;

                case 2:
                    if (tipoDatoComprometido == 1)
                    {
                        Console.WriteLine("Serevidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Supervisión baja");
                    }
                    else if (tipoDatoComprometido == 2)
                    {
                        Console.WriteLine("Serevidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervisión media");
                    }
                    else if (tipoDatoComprometido == 3 && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Supervisión alta");
                    }
                    else if (tipoDatoComprometido == 4 && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Supervisión inmediata y activación de protocolos de seguridad máxima");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;

                case 3:
                    if (tipoDatoComprometido == 3)
                    {
                        Console.WriteLine("Serevidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Supervisión baja");
                    }
                    else if (tipoDatoComprometido == 4)
                    {
                        Console.WriteLine("Serevidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervisión media");
                    }
                    else if (tipoDatoComprometido == 3 && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Supervisión alta");
                    }
                    else if (tipoDatoComprometido == 4 && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Supervisión inmediata y activación de protocolos de seguridad máxima");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;

                case 4:
                    if (tipoDatoComprometido == 2)
                    {
                        Console.WriteLine("Serevidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Supervisión baja");
                    }
                    else if (numeroUsuariosAfectados < 1000)
                    {
                        Console.WriteLine("Serevidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervisión media");
                    }
                    else if (tipoDatoComprometido == 2 && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Supervisión alta");
                    }
                    else if (numeroUsuariosAfectados >= 1000 && persistencia == "S")
                    {
                        Console.WriteLine("Serevidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Supervisión inmediata y activación de protocolos de seguridad máxima");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;

                default:
                    Console.WriteLine("Activo afectado no váido.");
                    break;
            }
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