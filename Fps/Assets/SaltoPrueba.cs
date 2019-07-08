using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltoPrueba : MonoBehaviour
{



    // esto es nada mas una prueba no se pide en el taller se un salto para el personaje el cual  no se como limitar se puede hacer con un bool una dectecion del  terrono
    public Rigidbody rby; // se defina un  rigibody publico 
    
    
   public bool salto = false; // una variable  bool para tener un  boton para activa o desactivar


    void Update()
    {
        if (salto == true) // el cual si es true  se ejecuta
        {
            rby = GetComponent<Rigidbody>(); //en el cual rby es igual al mismo como tal 
            if (Input.GetButtonDown("Jump")) //  conotro condicional se  el cual  devuelve un verdadero al ser oprimido el boton que se definio

                rby.velocity = new Vector3(0, 5, 0); //ejecuata  el salto de la esfera ella se  moverá hacia arriba en 5 unidades 

        }

     }
}
