using System.ComponentModel.Design;
using tarea_10;
bool continuar = true;
List<Productos> productsList = new List<Productos>();
do
{
	try
	{
        SwitchMenu();
	}
	catch (Exception ex)
	{

        Console.WriteLine(ex.Message);
    }
} while (continuar);

 
}
static void SwitchMenu()
{
    switch (Menu())
    {
        case 1: 
            break;
            case 2:
            break;
            case 3:
            break;
            case 4:
            break;
    }
}
