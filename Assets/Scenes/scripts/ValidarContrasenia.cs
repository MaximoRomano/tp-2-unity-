using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContrasenia : MonoBehaviour
{
    string contraseniaCorrecta;
    string contraseniausuario;
    public Text ingresousuario;

    void Start()
    {
        contraseniaCorrecta = "12345";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarContrasenia()
    {
        contraseniausuario = ingresousuario.text;
        if(contraseniausuario == contraseniaCorrecta)
        {
            Debug.Log("bienvenido");
        }
        else
        {
            Debug.Log("Contraseña incorrecta");
        }
    }
}
