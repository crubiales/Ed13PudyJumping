using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    //2 parte necesarioa para crear un singleton
    public static GameManager Instance
    {
        get
        {
            return ((GameManager)mInstance);
        }
        set
        {
            mInstance = value;
        }
    }
    // vidas actuales
    public int curLifes;
    public int maxLifes;



    private void Start()
    {
        curLifes = maxLifes;

    }


    //este metodo se ejecuta cuando el jugador muere
    // en principio lo ejecuta PlayerController
    public void PlayerDie()
    {
        curLifes--;// resta una vida

        //si las vidas actuales son suficientes
        if(curLifes >= 0)
        {
            //se reinicia el nivel
            RestartLevel();
        }
        else
        {
            //si no , se termina la partida
            GameOver();
        }

    }
    /// <summary>
    /// metodod de reinicio del nivel
    /// </summary>
    private void RestartLevel()
    {
        
        Debug.Log("el player ha muerto y se reinicia el nivel");
        //recargar la Scene Activa
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    /// <summary>
    /// metodo de Game Over
    /// </summary>
    private void GameOver()
    {
        //manda al jugador al la scene del menu principal
        SceneManager.LoadScene(0);
    }

    private void Update()
    {
    }

    public void AddCoins(int value)
    {
    }


}

