using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class mayoriadeedad : MonoBehaviour
{
    public int edadusuario;
    public Text mitexto;
    

    void Start()
    {
       
        

        if (edadusuario >= 18)
        {
            Debug.Log(" es mayor de edad");

            mitexto.text = "es mayor de edad ";
            

        }
        else
        {
            Debug.Log(" No es mayor de edad");
            mitexto.text = " no es mayor de edad ";
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
