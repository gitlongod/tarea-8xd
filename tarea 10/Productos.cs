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
      

        public Productos(string id, string name, double price, string type)
        {
            ID = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public static void AddProduct(ref List<Productos> productsList  )
        {
            Console.Clear();
            Console.WriteLine("Ingrese el ID del producto");
            string id = Console.ReadLine();

            Console.WriteLine("Ingrese el Nombre del Producto");
            string name = Console.ReadLine();
            Console.WriteLine("Ingrese el Precio del Producto");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de producto");
            string type = "";
            int option = MenuAddProduct();
            switch (option)
            {
                case 1:
                    type = "telefono";
                    productsList.Add(new Telefonos(id, name, price,type ));
                    Console.WriteLine("\nProducto Agregado con Éxito");
                    Console.ReadKey();
                    break;
                case 2:
                    type = "Ordenador";
                    productsList.Add(new Ordenadores(id, name, price,type));
                    Console.WriteLine("\nProducto Agregado con Éxito");
                    Console.ReadKey();
                    break;
                case 3:
                    type = "Tablet";
                    productsList.Add(new Tablets(id,name,price, type));
                    Console.WriteLine("\nProducto Agregado con Éxito");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("\nIngrese una Opción Válida");
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
                    Console.WriteLine($"\n ID: {product.ID}");
                    Console.WriteLine($"\nNombre: {product.Name}");
                    Console.WriteLine($"\n Precio : {product.Price}");
                    Console.WriteLine($"\nTipo: {product.Type}");
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
                            Console.WriteLine($"\nTipo: {product.Type}");
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
