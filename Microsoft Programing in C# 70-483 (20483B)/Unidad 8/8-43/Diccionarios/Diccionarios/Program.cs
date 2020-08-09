using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Diccionarios {
    class Program {
        static void Main(string[] args) {
            //Hashtable tabla = new Hashtable();
            //bool encontrado;
            //tabla.Add("1", 34.45);
            //tabla.Add("2", 56.23);
            //tabla.Add("3", 34.67);
            //tabla.Add("4", 12.6);
            //encontrado = tabla.ContainsValue("34.6");
            //foreach (DictionaryEntry dic in tabla) {
            //    Console.WriteLine("key = {0}, valor = {1}", dic.Key, dic.Value);
            //}
            //Console.WriteLine("el elemento es:" + tabla["2"].ToString());
            //Console.WriteLine(encontrado.ToString());

            SortedList sort = new SortedList();
            sort.Add("1", "nombre");
            sort.Add("5", "apellidos");
            sort.Add("3", "direccion");

            foreach (DictionaryEntry dic in sort) {
                Console.WriteLine("key = {0}, valor = {1}", dic.Key, dic.Value);
            }

            sort.SetByIndex(1,"apodo");

            foreach (DictionaryEntry dic in sort) {
                Console.WriteLine("key = {0}, valor = {1}", dic.Key, dic.Value);
            }

            Console.ReadKey();
        }
    }
}