using System.ComponentModel.Design;
using tarea_10;
bool continuar = true;
List<Productos> productsList = new List<Productos>();
do
{
	try
	{
        SwitchMenu(ref productsList,ref  continuar);
	}
	catch (Exception ex)
	{

        Console.WriteLine(ex.Message);
    }
} while (continuar);

 
        static int Menu()
{
    Console.Clear();
    Console.WriteLine("Ingrese una opción ");
    Console.WriteLine("1.Agregar productos");
    Console.WriteLine("2.Listar Productos");
    Console.WriteLine("3.Buscar Productos");
    Console.WriteLine("4.Salir");
    int option = int.Parse(Console.ReadLine());
    return option;  
}
static bool Salir(ref bool  continuar)
{
    Console.Clear();
    continuar = false;
    return continuar;
}
static void SwitchMenu(ref List<Productos>productsList, ref bool continuar)
{
    switch (Menu())
    {
        case 1: 
            Productos.AddProduct(ref productsList);
            break;
            case 2:
            Productos.ListProduct(ref productsList);
            break;
            case 3:
            Productos.SearchProduct(ref productsList);
            break;
            case 4:
            Salir(ref continuar);
            break;
            default:
            Console.WriteLine("INGRESE UNA OPCIÓN VALIDA");
            break;
    }
}
