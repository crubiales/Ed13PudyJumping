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

    // tiempo actual

    public float curTime;
    public float maxTime;

    public int coins;

    public CameraFollowSmooth _CameraFollowSmooth;


    private void Start()
    {
        curLifes = maxLifes;
        curTime = maxTime;
        PlayerUI.Instance.UpdateLifes(curLifes);
        PlayerUI.Instance.UpdateTime(curTime);
    }


    //este metodo se ejecuta cuando el jugador muere
    // en principio lo ejecuta PlayerController
    public void PlayerDie()
    {
        curLifes--;// resta una vida
        // Actualizo la intefaz
        PlayerUI.Instance.UpdateLifes(curLifes);
        //si las vidas actuales son suficientes
        if (curLifes >= 0)
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
        //resta a current time el tiempo que ha pasado desde el ultimo frame 
        curTime -= Time.deltaTime;

        //despues de la resta compruebo el tiempo que me queda
        // si es menor o igual que 0 , me he quedado sin tiempo y muero
        if (curTime <= 0)
        {
            PlayerDie();
        }

        // despues actualizo el tiempo en la interfaz para que el jugador vea 
        // cuanto tiempo le queda para pasarse el nivel.
        PlayerUI.Instance.UpdateTime(curTime);

    }

    public void AddCoins(int value)
    {
        coins += value;
        if(coins >= 100)
        {
            curLifes++;
            PlayerUI.Instance.UpdateLifes(curLifes);
           coins -= 100;
        }

        PlayerUI.Instance.UpdateCoins(coins);



    }

    public void changeCameraDirection(bool lookingRight)
    {
        if (lookingRight == false)
        {
            _CameraFollowSmooth.offset = new Vector3(-5, 1.5f, -10);
        }
        else
        {
            _CameraFollowSmooth.offset = new Vector3(5, 1.5f, -10);
        }

    }
}

