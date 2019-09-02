using System.Collections;
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

    public void UpdateHealth(int health)
    {

    }

    public void UpdateLifes(int curLifes)
    {

    }

    public void UpdateTime(float curTime)
    {

    }
}
