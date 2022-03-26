/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package clase.pkg3;
public class Clase3 {
    public static void main(String[] args) {
        /*Utilizando lo visto en las clases 2 y 3, elaborar un programa
        que permita almacenar un nombre, una edad, y que muestre
        en la pantalla el mensaje “Hola mi nombre es... y mi edad es...”
        (En donde aparecen los puntos suspensivos que aparezcan el
        nombre y la edad guardados antes).*/
        String nombre = "Luis";
        int edad = 35;
        System.out.println("Hola mi nombre es " + nombre + " y mi edad es " + edad);
        /*Elaborar un programa que almacene en una variable el precio
        unitario de un producto y en otra variable la cantidad
        comprada de ese producto, y después muestre en la consola
        “El precio unitario es... y si compro ... unidades el total es...”
        (En donde aparecen los puntos suspensivos aparezcan el
        precio unitario, la cantidad comprada, y el total)
        Ejemplo:
        Precio unitario: 6
        Cantidad comprada: 3
        Total: 18
        “El precio unitario es 6 y si compro 3 unidades el total es 18."*/
        int precioUnit = 6;
        int cantComprada = 3;
        int total = precioUnit * cantComprada;
        System.out.println("El precio unitario es " + precioUnit + " y si compro " + cantComprada + " unidades el total es " + total);
        /*Elaborar un programa que reciba una medida en METROS y la
        muestre en KILOMETROS de la siguiente manera:
        “La medida es de .... Metros, pasada a kilómetros es...”
        (En donde aparecen los puntos suspensivos que aparezcan la
        medida original y la medida pasada a kilómetros.)
        Recuerden, 1 kilómetro son 1000 metros.*/
        int metros=1000;
        int kilometros=1000/1000;
        System.out.println("La medida es de " + metros + " Metros, pasada a kilómetros es " + kilometros);
    }    
}
