using Registro_Gym;
var menu = new Menu();
Console.WriteLine("Registros de Gym");
bool seguir = true;
int elegir;
List<Cliente> clientes = new List<Cliente>();

while (seguir)
{
    menu.menu();
    Console.WriteLine("Toma una opcion");
    elegir = Convert.ToInt32(Console.ReadLine());
    Seleccion(elegir);
}

void Seleccion(int select)
{
    switch (select)
    {
        case 1:
            
            var cliente1 = new Cliente();
            cliente1.id = ++Cliente.ContadorID;
            Console.Write("Ingresa el nombre ");
            cliente1.nombre = Console.ReadLine();
            Console.Write("Ingrese edad: ");
            cliente1.edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese teléfono: ");
            cliente1.movil = Console.ReadLine();
            clientes.Add(cliente1);
            Console.WriteLine("Cliente registrado con éxito.");
            break;

        case 2:
            MostrarDetalles();
            break;

        case 3:
            ListarClientes();
            break;

        case 4:
            BuscarCliente();
            break;

        case 5:
            DarDeBajaCliente();
            break;

        case 6:
            ModificarCliente();
            break;

        case 7:
            Console.WriteLine("Saliendo del programa ....");
            seguir = false;
            break;
    }
}

void MostrarDetalles()
{
    Console.Write("Ingrese nombre del cliente a mostrar: ");
    string nombre = Console.ReadLine().ToLower();
    var cliente = clientes.Find(c => c.nombre.ToLower().Contains(nombre));
    if (cliente != null)
    {
        Console.WriteLine($"ID: {cliente.id} - Nombre: {cliente.nombre} - Edad: {cliente.edad} - Teléfono: {cliente.movil}");
    }
    else
    {
        Console.WriteLine("Cliente no encontrado.");
    }
}

void ListarClientes()
{
    if (clientes.Count > 0)
    {
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"ID: {cliente.id} - Nombre: {cliente.nombre} - Edad: {cliente.edad} - Teléfono: {cliente.movil}");
        }
    }
    else
    {
        Console.WriteLine("No hay clientes registrados.");
    }
}

void BuscarCliente()
{
    Console.Write("Ingrese nombre a buscar: ");
    string Nombre = Console.ReadLine().ToLower(); 
    var resultados = clientes.FindAll(c => c.nombre.ToLower().Contains(Nombre));
    if (resultados.Count > 0)
    {
        foreach (var cliente in resultados) 
        {
            Console.WriteLine($"ID: {cliente.id} - Nombre: {cliente.nombre} - Edad: {cliente.edad} - Teléfono: {cliente.movil}");
        }
    }
    else
    {
        Console.WriteLine("No se encontraron coincidencias."); 
    }
}

void DarDeBajaCliente()
{
    Console.Write("Ingrese nombre del cliente a dar de baja: ");
    string nombre = Console.ReadLine().ToLower();
    var cliente = clientes.Find(c => c.nombre.ToLower().Contains(nombre));
    if (cliente != null)
    {
        clientes.Remove(cliente);
        Console.WriteLine("Cliente dado de baja con éxito.");
    }
    else
    {
        Console.WriteLine("Cliente no encontrado.");
    }
}

void ModificarCliente()
{
    Console.Write("Ingrese nombre del cliente a modificar: ");
    string nombre = Console.ReadLine().ToLower();
    var cliente = clientes.Find(c => c.nombre.ToLower().Contains(nombre));
    if (cliente != null)
    {
        Console.Write("Ingresa el nuevo nombre (deja en blanco para no cambiar): ");
        string nuevoNombre = Console.ReadLine();
        if (!string.IsNullOrEmpty(nuevoNombre))
        {
            cliente.nombre = nuevoNombre;
        }

        Console.Write("Ingresa la nueva edad (deja en blanco para no cambiar): ");
        string nuevaEdad = Console.ReadLine();
        if (!string.IsNullOrEmpty(nuevaEdad))
        {
            cliente.edad = int.Parse(nuevaEdad);
        }

        Console.Write("Ingresa el nuevo teléfono (deja en blanco para no cambiar): ");
        string nuevoTelefono = Console.ReadLine();
        if (!string.IsNullOrEmpty(nuevoTelefono))
        {
            cliente.movil = nuevoTelefono;
        }

        Console.WriteLine("Cliente modificado con éxito.");
    }
    else
    {
        Console.WriteLine("Cliente no encontrado.");
    }
}
