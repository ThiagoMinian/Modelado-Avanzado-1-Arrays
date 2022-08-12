using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioArrays : MonoBehaviour
{
    public int[] numeros;
    private int[] otrosNumeros = new int[4];
    public string nombre;


    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(numeros[0]);
        //Debug.Log(otrosNumeros[0]);
        ////Escribir el primer elemento del array
        //Debug.Log(nombre[0]);
        ////Escribir el ultimo elemento del array
        //Debug.Log(nombre[nombre.Length - 1]);

        //EscribirLetraPorLetramenosO(nombre);

        //ExisteLetraEnCadena(nombre, 'x');

        EscribirCadenaInvertida(nombre);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void EscribirLetraPorLetra (string cadena)
    {
        for (int i = 0; i<cadena.Length; i++)
        {
            if (i == 3)
            {
                i++; 
            }
            Debug.Log(cadena[i]);
        }
       
    }

    void EscribirLetraPorLetramenosO(string cadena)
    {
        for (int i = 0; i < cadena.Length; i++)
        {
            if (cadena[i] != 'o')
            {
                i++;
            }
            Debug.Log(cadena[i]);
        }

    }

    void ExisteLetraEnCadena(string cadena, char letraBuscada)
    {
        bool letraEncontrada = false;
        int counter = 0;
        while (!letraEncontrada && counter < cadena.Length)
        {
            if (cadena[counter] == letraBuscada)
            {
                letraEncontrada = true;
                Debug.Log("Existe la letra en la posicion " + counter);
            }
            
            counter++;
        }
        if (counter == cadena.Length)
        {
            Debug.Log("No existe la letra en la cadena");
        }
    }

    void EscribirCadenaInvertida(string cadena)
    {
        for (int i = cadena.Length - 1; i >= 0 ; i--)
        {
            Debug.Log(cadena[i]);
        }
    }
}
