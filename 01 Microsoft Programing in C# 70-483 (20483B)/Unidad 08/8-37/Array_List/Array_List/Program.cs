using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array_List {
    class Program {
        static void Main(string[] args) {
            //ArrayList arli = new ArrayList();
            //arli.Add(2);
            //arli.Add("dos");
            //arli.Add(12.5);
            //arli.Insert(1, true);
            //arli.RemoveAt(2);
            //arli.Remove(2);
            //Console.WriteLine("la coleccion tienen " + arli.Count + "elementos");                        
            //foreach (object a in arli) {
            //    Console.WriteLine(a.ToString());
            //}

            Clientes cli = new Clientes();
            cli.Agregar("jose perez");
            cli.AgregarLista(new string[] {"cliente2", "cliente3", "cliente4" });
            cli.Editar("cliente2", "Maria Sanchez");
            cli.Eliminar("cliente4");
            cli.Ordenar();
            cli.SelectClientes();
            Console.ReadKey();
        }
    }
}