using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tarea_10
{

    public class Productos
    {

        public string ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
      

        public Productos(string iD, string name, double price, string type)
        {
            ID = iD;
            Name = name;
            Price = price;
            Type = type;
        }

        public static void AddProduct(ref List<Productos> productsList ref )
        {
            Console.Clear();
            Console.WriteLine("Ingrese el ID del producto");
            string idProduct = Console.ReadLine();

            Console.WriteLine("Ingrese el Nombre del Producto");
            string name = Console.ReadLine();
            Console.WriteLine("Ingrese el Precio del Producto");
            double priceProduct = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de producto");
            string type = Console.ReadLine();
            int option = MenuAddProduct();
            switch (option)
            {
                case 1:
                    type = "Teléfono";
                    productsList.Add(new Telefonos(ID, name, price,type ));
                    Console.WriteLine("\nProducto Agregado con Éxito");
                    Console.ReadKey();
                    break;
                case 2:
                    type = "Ordenador";
                    productsList.Add(new Ordenadores(name, type));
                    Console.WriteLine("\nProducto Agregado con Éxito");
                    Console.ReadKey();
                    break;
                case 3:
                    type = "Tablet";
                    productsList.Add(new Tablets(name, type));
                    Console.WriteLine("\nProducto Agregado con Éxito");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("\nIngrese una Opción Válida (1 - 3)");
                    Console.ReadKey();
                    break;
            }
        }
        public static int MenuAddProduct()
        {
            Console.WriteLine("\n¿Qué Tipo de Producto es?");
            Console.WriteLine("1. Teléfono");
            Console.WriteLine("2. Ordenador");
            Console.WriteLine("3. Tablet");
            Console.Write("Seleccione una Opción Válida: ");
            int optionMAP = int.Parse(Console.ReadLine());
            return optionMAP;
        }
        public static void ListProduct(ref List<Productos> productsList)
        {
            if (productsList.Count == 0)
            {
                Console.WriteLine("\nNo Existen Productos Registrados");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("La Lista de los Productos Registrados es:");
                foreach (Productos product in productsList)
                {
                    Console.WriteLine($"\nNombre: {product.Name}");
                    Console.WriteLine($"\nTipo: {product.type}");
                    Console.WriteLine("\n-------------------");
                }
                Console.ReadKey();
            }
        }
        public static void SearchProduct(ref List<Productos> productsList)
        {
            if (productsList.Count == 0)
            {
                Console.WriteLine("\nNo Existen Productos Registrados");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ingrese el Nombre del Producto a Buscar");
                string name = Console.ReadLine();
                Productos searchProduct = productsList.Find(p => p.Name == name);
                if (searchProduct != null)
                {
                    Console.WriteLine("\nProducto Encontrado");
                    foreach (Productos product in productsList)
                    {
                        if (product.Name == name)
                        {
                            Console.WriteLine($"\nNombre: {product.Name}");
                            Console.WriteLine($"\nTipo: {product.type}");
                            Console.ReadKey();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nEl Producto No Existe");
                    Console.ReadKey();
                }
            }
        }
    }

}
