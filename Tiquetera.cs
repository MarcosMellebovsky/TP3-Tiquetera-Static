public static class Tiquetera
{
    private static Dictionary<int, Cliente> dicClientes = new Dictionary<int, Cliente>();

    public static int UltimoIDEntrada = 0;
    public static int DevolverUltimoId()
    {
        return UltimoIDEntrada;
    }
    public static int AgregarCliente(Cliente nuevoCliete)
    {
        UltimoIDEntrada++;
        dicClientes.Add(UltimoIDEntrada, nuevoCliete);
        return UltimoIDEntrada;
    }
    public static Cliente BuscarCliente(int idEntrada)
    {
        if (dicClientes.ContainsKey(idEntrada))
        {
            return dicClientes[idEntrada];
        }
        else
        {
            Cliente clienteVacio = new Cliente();
            return clienteVacio;
        }
    }
    public static int CambiarEntrada(int idEnt, int cambiarEntradaa)
    {        
        bool aceptar = false;
        if (dicClientes.ContainsKey(idEnt))
        {
            if (dicClientes[idEnt].TipoEntrada != 4)
            {
                if (dicClientes[idEnt].TipoEntrada == 2 && cambiarEntradaa == 4)
                {
                    aceptar = true;
                }
                if (dicClientes[idEnt].TipoEntrada == 3)
                {
                    aceptar = true;
                }
                if (dicClientes[idEnt].TipoEntrada == 1 && cambiarEntradaa != 3)
                {
                    aceptar = true;
                }

                if (aceptar == true)
                {
                    if (cambiarEntradaa == 1)
                    {
                        dicClientes[idEnt].TipoEntrada = 1;
                        dicClientes[idEnt].TotalAbonado = 15000;
                    }
                    if (cambiarEntradaa == 2)
                    {
                        dicClientes[idEnt].TipoEntrada = 2;
                        dicClientes[idEnt].TotalAbonado = 30000;
                    }
                    if (cambiarEntradaa == 3)
                    {
                        dicClientes[idEnt].TipoEntrada = 3;
                        dicClientes[idEnt].TotalAbonado = 10000;
                    }
                    if (cambiarEntradaa == 4)
                    {
                        dicClientes[idEnt].TipoEntrada = 4;
                        dicClientes[idEnt].TotalAbonado = 40000;
                    }
                }
            }
        }
        return cambiarEntradaa;
    }
    public static List<string> EstadisticasTicketera()
    {
        List<string> lista = new List<string>();
        int CantidadDeClientesInscriptos = 0;
        int cant1 = 0;
        int cant2 = 0;
        int cant3 = 0;
        int cant4 = 0;
        int plata1 = 0;
        int plata2 = 0;
        int plata3 = 0;
        int plata4 = 0;
        float porcentaje1, porcentaje2,porcentaje3,porcentaje4;
        CantidadDeClientesInscriptos = dicClientes.Count();
        System.Console.WriteLine("El total de personas inscriptas son: " + CantidadDeClientesInscriptos);
        int CantClientesFor = CantidadDeClientesInscriptos + 1;
        if (CantidadDeClientesInscriptos > 0)
        {
            for (int i = 1; i < CantClientesFor; i++)
      {
        if (dicClientes[i].TipoEntrada == 1)
        {
            cant1++;
            plata1 = plata1 + 15000;
        }
        if (dicClientes[i].TipoEntrada == 2)
        {
            cant2++;
            plata2 = plata2 + 30000;
        }
        if (dicClientes[i].TipoEntrada == 3)
        {
            cant3++;
            plata3 = plata3 + 10000;
        }
        if (dicClientes[i].TipoEntrada == 4)
        {
            cant4++;
            plata4 = plata4 + 40000;
        }
      }
      int recaudaciuonTotal = plata1 + plata2 + plata3 + plata4;
      porcentaje1 = (cant1*100/CantidadDeClientesInscriptos);
      porcentaje2 = (cant2*100/CantidadDeClientesInscriptos);
      porcentaje3 = (cant3*100/CantidadDeClientesInscriptos);
      porcentaje4 = (cant4*100/CantidadDeClientesInscriptos);
      System.Console.WriteLine("el porcentaje de las entradas de tipo 1 es de: " + porcentaje1 + "%" + " y la recaudaciuon de plata de este tipo es de: " + plata1);
      System.Console.WriteLine("el porcentaje de las entradas de tipo 2 es de: " + porcentaje2 + "%" + " y la recaudaciuon de plata de este tipo es de: " + plata2);
      System.Console.WriteLine("el porcentaje de las entradas de tipo 3 es de: " + porcentaje3 + "%" + " y la recaudaciuon de plata de este tipo es de: " + plata3);
      System.Console.WriteLine("el porcentaje de las entradas de tipo 4 es de: " + porcentaje4 + "%" + " y la recaudaciuon de plata de este tipo es de: " + plata4);
      System.Console.WriteLine("la recaudacion total es: " + recaudaciuonTotal);
       
    }
    else
    {
        System.Console.WriteLine("Aún no se anotó nadie");
    }
    return lista;     
        }
         
      
}