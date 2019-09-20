using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingNewLevelUI : MonoBehaviour
{
    // el Id de la siguiente escena
    public int levelId;
    //referencia a la imagen  de la imagen que vamos a usar para 
    //rellenar la barra de carga
    public Image ImgLoading;

    // variable de carga Asincrona
    // el load async nos rellena esta variable para indicarlos el porcentaje de 
    // carga de la operacion
    public AsyncOperation asyncOperation;

    private void Start()
    {
        LoadNewLevelAsync();
    }

    /// <summary>
    /// Metodo de carga Asincrona
    /// </summary>
    public void LoadNewLevelAsync()
    {
        asyncOperation = SceneManager.LoadSceneAsync(levelId);
    }
    /// <summary>
    /// en cada actualizacion vamos a ir rellenado la 
    /// barra en funcion del porcentaje de carga
    /// </summary>
    private void Update()
    {
        if(asyncOperation != null)
        {
            ImgLoading.fillAmount = asyncOperation.progress;
        }


    }




}
