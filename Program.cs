List<Cliente> listaProgram = new List<Cliente>();
int opciones; 

do
{
    System.Console.WriteLine("A que opcion desea entrar: ");
    System.Console.WriteLine("Opcion 1: Nueva Inscripción: ");
    System.Console.WriteLine("Opcion 2: Obtener Estadísticas del Evento: ");
    System.Console.WriteLine("Opcion 3: Buscar Cliente: ");
    System.Console.WriteLine("Opcion 4: Cambiar entrada de un Cliente: ");
    System.Console.WriteLine("Opcion 5: Salir");
    opciones = int.Parse(Console.ReadLine());
    switch (opciones)
    {
        case 1:
        opcion1();
        break;
        case 2:
        opcion2();
        break;
        case 3:
        opcion3();
        break;
        case 4:
        opcion4();
        break;
    }
} while (opciones != 5);

void opcion1()
{
    int TotalAbonado = 0;
    int DNI = Funciones.IngresarEntero("Ingrese su dni: ");
    string Apellido = Funciones.IngresarTexto("Ingrese su apellido: ");
    string Nombre = Funciones.IngresarTexto("Ingrese su nombre: ");
    DateTime FechaInscripcion = Funciones.IngresarFecha("Ingrese su fecha de inscripcion:");
    int TipoEntrada = Funciones.IngresarEntero("Ingrese el tipo de entrada: ");
    while (TipoEntrada >4 || TipoEntrada<=0)
    {
        System.Console.WriteLine("No hay ese tipo de entrada!");
        TipoEntrada = int.Parse(Console.ReadLine());
    }
    if (TipoEntrada ==1)
    {
        TotalAbonado = 15000;
        
    }
    if (TipoEntrada ==2)
    {
        TotalAbonado = 30000;
    }
    if (TipoEntrada ==3)
    {
        TotalAbonado = 10000;
    }
    if (TipoEntrada ==4)
    {
        TotalAbonado = 40000;
    }
    Cliente nuevoCliente = new Cliente (DNI, Apellido , Nombre , FechaInscripcion ,TipoEntrada,TotalAbonado);
    Tiquetera.AgregarCliente(nuevoCliente);
    listaProgram.Add(nuevoCliente);
}
void opcion2()
{
    Tiquetera.EstadisticasTicketera();
}
void opcion3()
{
    int idEntrada;
    System.Console.WriteLine("Ingrese el id de entrada que quiera buscar:  ");
    idEntrada= int.Parse(Console.ReadLine());
    Cliente ClienteBuscado = Tiquetera.BuscarCliente(idEntrada);
    if (ClienteBuscado.Nombre =="")
    {
        System.Console.WriteLine("no esta");
    }
    else{
        System.Console.WriteLine("El dni es: " + ClienteBuscado.DNI + "\n el apellido es: " + ClienteBuscado.Apellido + "\n el nombre es: " + ClienteBuscado.Nombre + "\n la fecha de nscripcion es: " + ClienteBuscado.FechaInscripcion + "\n el tipo de entrada es: " + ClienteBuscado.TipoEntrada + "\n el total abonado es: " + ClienteBuscado.TotalAbonado);
    }
}
void opcion4()
{
    int idEnt, cambiarEntradaa;
    System.Console.WriteLine("Ingrese el id de entrada para cambiar su tipo de entrada: ");
    idEnt = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Ingrese a que tipo de entrada desea cambiar: ");
    cambiarEntradaa = int.Parse(Console.ReadLine());
    Tiquetera.CambiarEntrada(idEnt, cambiarEntradaa);
}