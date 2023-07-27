using SystemProducts;
namespace ProgramProducts
{
    class ProductsManagement
    {
        static Dictionary<int, Product> Products = new();

        static void Main(string[] args)
        {
            bool blContinue = true;

            do
            {
                Console.Clear();
                Console.WriteLine(" GESTIÓN DE PRODUCTOS \n\n");
                Console.WriteLine("1. Agregar un producto");
                Console.WriteLine("2. Mostrar un producto");
                Console.WriteLine("3. Listar todos los productos");
                Console.WriteLine("4. Eliminar un producto");
                Console.WriteLine("5. Actualizar el precio de un producto");
                Console.WriteLine("6. Actualizar la cantidad del inventario un producto");
                Console.WriteLine("7. Actualizar el listado de clientes de un producto");
                Console.WriteLine("8. Terminar\n\n");
                Console.WriteLine("******************************");
                Console.Write("Elija una Opción: ");

                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    switch (option)
                    {
                        case 1:
                            AddProduct();
                            break;
                        case 2:
                            ShowProduct();
                            break;
                        case 3:
                            ListAllProducts();
                            break;
                        case 4:
                            DeleteProduct();
                            break;
                        case 5:
                            UpdatePrice();
                            break;
                        case 6:
                            UpateCantInventary();
                            break;
                        case 7:
                            UpdateListClients();
                            break;
                        case 8:
                            blContinue = false;
                            break;
                        default:
                            Console.WriteLine("No tenemos esa opción, sorry");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Hey, ojito, ingresa números.");
                    Console.ReadKey();
                }
            } while (blContinue);
        }

        static void AddProduct()
        {
            Console.Clear();
            Console.WriteLine("Agregar producto");
            Console.Write("Ingrese el código numérico del producto: ");
            if (int.TryParse(Console.ReadLine(), out int code))
            {
                if (Products.ContainsKey(code))
                {
                    Console.WriteLine("Número del código ya existe...");
                }
                else
                {
                    Console.Write("Ingrese nombre del producto: ");
                    string name = Console.ReadLine() ?? "";

                    Console.Write("Ingrese el precio del producto: ");
                    if (float.TryParse(Console.ReadLine(), out float price))
                    {
                        Console.Write("Ingrese la cantidad del producto en stock: ");
                        if (int.TryParse(Console.ReadLine(), out int cant))
                        {
                            Console.Write("Ingrese la lista de clientes del producto (separados por comas): ");
                            List<string> listCLients = new(Console.ReadLine().Split(','));

                            Product newProduct = new(name, price, cant, listCLients);
                            Products.Add(code, newProduct);
                            Console.WriteLine("Producto agregado correctamente.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un valor numérico para la cantidad");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un valor numérico para el precio");
                        Console.ReadKey();
                    }
                }
            }
            else
            {
                Console.WriteLine("Código no válido, ups");
                Console.ReadKey();
            }
        }

        static void ShowProduct()
        {
            Console.Clear();
            Console.WriteLine("Mostrar Producto");
            ListAllProducts();
            Console.Write("Ingrese el código del producto: ");
            if (int.TryParse(Console.ReadLine(), out int code))
            {
                if (Products.TryGetValue(code, out Product product))
                {
                    Console.WriteLine("\n\tNombre\tPrecio\tCant\tClientes");
                 
                    string strClients = "";
                    foreach (var client in product.Clients)
                    {
                        strClients = strClients + " " + client;
                    }
                    Console.WriteLine($"{product.Name}\t{product.Price}\t{product.Quantity}\t{strClients}");
                    Console.WriteLine();
                
                }
                else
                {
                    Console.WriteLine("No se encontró un producto con ese código.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Código NO válido.");
                Console.ReadKey();
            }
            Console.WriteLine("Presione cualquier tecla para continuar.");
            Console.ReadKey();
        }

        static void ListAllProducts()
        {
            Console.Clear();
            Console.WriteLine("Listado de productos ");
            if (Products.Count > 0)
            {
                Console.WriteLine("\nCódigo\tNombre\tPrecio\tCant\tClientes");
                foreach (var product in Products)
                {
                    
                    string strClients = "";
                    foreach (var client in product.Value.Clients)
                    {
                        strClients = strClients + " " + client;
                    }
                    Console.WriteLine($"{product.Key}\t{product.Value.Name}\t{product.Value.Price}\t{product.Value.Quantity}\t{strClients}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No hay productos registrados.");
            }
            Console.WriteLine("Presione cualquier tecla para continuar.");
            Console.ReadKey();
        }

        static void DeleteProduct()
        {
            Console.Clear();
            Console.WriteLine("Eliminar un producto");
            ListAllProducts();
            Console.Write("Ingrese el código del producto: ");
            if (int.TryParse(Console.ReadLine(), out int code))
            {
                if (Products.ContainsKey(code))
                {
                    Products.Remove(code);
                    Console.WriteLine("Producto eliminado");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("No se encontró un producto con ese código");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Código NO válido.");
                Console.ReadKey();
            }
        }

        static void UpdatePrice()
        {
            Console.Clear();
            ListAllProducts();
            Console.Write("Ingrese el código del producto: ");
            if (int.TryParse(Console.ReadLine(), out int code))
            {

                if (Products.ContainsKey(code))
                {
                    Console.Write("Ingrese el nuevo precio del producto: ");
                    if (float.TryParse(Console.ReadLine(), out float price))
                    {
                        Products[code].Price = price;
                        Console.WriteLine("Producto actualizado");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un valor numérico para el precio");
                        Console.ReadKey();
                    }

                }
            }
        }

        static void UpateCantInventary()
        {
            Console.Clear();
            ListAllProducts();
            Console.Write("Ingrese el código del producto: ");
            if (int.TryParse(Console.ReadLine(), out int code))
            {

                if (Products.ContainsKey(code))
                {
                    Console.Write("Ingrese la nueva cantidad producto: ");
                    if (int.TryParse(Console.ReadLine(), out int cant))
                    {
                        Products[code].Quantity = cant;
                        Console.WriteLine("Producto actualizado");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un valor numérico para la cantidad");
                        Console.ReadKey();
                    }

                }
            }
        }

        static void UpdateListClients()
        {
            Console.Clear();
            ListAllProducts();
            Console.Write("Ingrese el código del producto: ");
            if (int.TryParse(Console.ReadLine(), out int code))
            {

                if (Products.ContainsKey(code))
                {
                    Console.Write("Ingrese la lista actualizada de clientes del producto (separados por comas): ");
                    List<string> listCLients = new(Console.ReadLine().Split(','));

                    Products[code].Clients = listCLients;
                    Console.WriteLine("Producto actualizado");
                    Console.ReadKey();

                }
            }
        }
    }
}
