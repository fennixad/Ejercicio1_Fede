using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_One : MonoBehaviour
{

    int num = 7, cifra = 3;
    int suma;

    void Start()
    {
        print("Ejercicio 1:\nnum: " + num + ", cifra: " + cifra);

        suma = num + cifra;

        /*
         * Defino la variable suma mediante la palabra reservada int realizando un tipado expl�cito, esto hace que mi variable s�lo pueda contener n�meros enteros
         * Coloco una referencia a la variable con el nombre de "suma", cuando quiera acceder al contenido de esta variable lo har� mediante su referencia.
         * Inicializo la variable asignandole un valor, en este caso la suma de las variables num y cifra.
         */

        print("Ejercicio 2:\nsuma: " + suma);

        num = 5;
        print("Ejercicio 3:\nnum: " + num);
        num += 7;
        print("nuevo num: " + num);

        print("Ejercicio 4:\nsegundos: " + CuantosSegundos(4));
        
    }

    double CuantosSegundos(int dias)
    {
        double segundos;
        segundos = dias * 24 * 60 * 60;

        return segundos;
    }
}
