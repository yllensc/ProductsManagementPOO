# ProductsManagementPOO

Sistema de gestión de productos

Crea un programa en C# para gestionar una lista de productos en una tienda. Cada producto tiene
un código único, un nombre, un precio y una cantidad en inventario.
1. Crea una clase llamada `Producto` con los siguientes atributos:
- `Codigo`: un número entero que representa el código único del producto.
- `Nombre`: una cadena que representa el nombre del producto.
- `Precio`: un número de punto flotante que indica el precio del producto.
- `Inventario`: un número entero que representa la cantidad disponible en inventario.
- `Clientes`: listado de almacenes de cadena que han solicitado en algún momento el producto
2. Implementa un constructor para la clase `Producto` que permita inicializar todos los atributos.
3. Agrega métodos a la clase `Producto` para:
- Mostrar los detalles del producto (código, nombre, precio y cantidad en inventario).
- Actualizar el precio del producto.
- Actualizar la cantidad en inventario.
- Actualizar el listado de clientes.
4. En el programa principal, crea un menú de opciones que permita al usuario realizar las
siguientes acciones:
- Agregar un nuevo producto a la lista de productos.
- Mostrar los detalles de un producto específico, ingresando su código.
- Mostrar la lista completa de productos con sus detalles.
- Actualizar el precio de un producto, ingresando su código y el nuevo precio.
- Actualizar la cantidad en inventario de un producto, ingresando su código y la nueva cantidad.
- Actualizar el listado de clientes, ingresando el código del producto y la lista actualizada
5. Utiliza un diccionario para almacenar los productos, donde la clave sea el código del producto
y el valor sea el objeto `Producto`.
