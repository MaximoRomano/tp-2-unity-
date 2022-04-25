using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mayoriadeedad : MonoBehaviour
{
    public int edadusuario;
    void Start()
    {
       
        

        if (edadusuario >= 18)
        {
            Debug.Log(" es mayor de edad");
        }
        else
        {
            Debug.Log(" No es mayor de edad");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
