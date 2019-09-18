using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pruebas : MonoBehaviour
{
    
    public void CambioValor(float A)
    {
        Debug.Log(A);
    }

    public void OpenBrowser()
    {
        Application.OpenURL("http://twitter.com");
    }

}
