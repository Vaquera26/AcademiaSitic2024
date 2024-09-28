using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Metodos
    {
        // Metodos
        static void Main2(string[] args)
        {

            int initialStock = 50;
            int quantityToAdd = 20;
            int addedQuantity;




            UpdateStock(initialStock, quantityToAdd, out int updatedStock, out addedQuantity);

            Console.WriteLine($"Inventario Inicial: {initialStock}");
            Console.WriteLine($"Cantidad Agregada: {quantityToAdd}");
            Console.WriteLine($"Inventario Actualizado: {updatedStock}");

            // Ajuste de entrada
            AdjustStock(ref updatedStock, 10);
            Console.WriteLine($"Ajuste de entrada: {updatedStock}");

            //Ajuste de Salida
            AdjustStock(ref updatedStock, -20);
            Console.WriteLine($"Ajuste de salida: {updatedStock}");

            //Lectura de producto
            // El var ocupa cierto espacio de memoria por que no conoce el tipo de dato
            // var productInfo = GetProductInfo("Laptop", 20);
            // productInfo.productName
            
           (string productName, int stock) = GetProductInfo("Laptop", 20);
            Console.WriteLine($"Nombre del product: {productName}");
            Console.WriteLine($"Inventario del producto: {stock}");
            
            Console.ReadKey();
        }

        public static void UpdateStock(int initialSotck, int quantityToAdd, out int updatedStock, out int addedQuantity)
        {

            addedQuantity = quantityToAdd;
            updatedStock = initialSotck + addedQuantity;
        }

        public static void AdjustStock(ref int stock, int adjustment)
        {
            stock += adjustment;
        }

        public static (string productName, int stock) GetProductInfo(string productName, int stock)
        {
            return (productName, stock);
        }


    }
}
