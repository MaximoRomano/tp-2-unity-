using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContrasenia : MonoBehaviour
{
    string contraseniaCorrecta;
    string contraseniausuario;
    public Text ingresousuario;
    public GameObject cartelitomsj;
    public Text textomsj;

    void Start()
    {
        contraseniaCorrecta = "12345";
        cartelitomsj.SetActive(false);
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
            
            cartelitomsj.SetActive(true);
            textomsj.text = "bienvenido";
        }
        else
        {
            cartelitomsj.SetActive(true);
            textomsj.text = "contraseña incorrecta";
        }
    }
}
