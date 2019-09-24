﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : Singleton<PlayerUI>
{
    public static PlayerUI Instance
    {
        get
        {
            return ((PlayerUI)mInstance);
        }
        set
        {
            mInstance = value;
        }
    }

    //referencias a los corazones de la interfaz
    public GameObject heart1, heart2, heart3, heart4, heart5;
    // referencia al texto de la interfaz de vidas
    public Text curLifes;

    public Text curTime;

    /// <summary>
    /// Sirve para activar o desactivar los corazones en funcion del parametro
    /// </summary>
    /// <param name="health"></param>
    public void UpdateHealth(int health)
    {
        
        health = Mathf.Clamp(health, 0, 5);
        heart1.SetActive(health >= 1);
        heart2.SetActive(health >= 2);
        heart3.SetActive(health >= 3);
        heart4.SetActive(health >= 4);
        heart5.SetActive(health >= 5);
      

    }

    public void UpdateLifes(int curLifes)
    {

        this.curLifes.text = $"X {curLifes}";

    }

    public void UpdateTime(float curTime)
    {
        this.curTime.text = $"{curTime} S";
    }
}
