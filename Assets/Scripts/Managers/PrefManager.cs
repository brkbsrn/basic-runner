using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefManager : MonoBehaviour
{
    public const string MoneyKey = "MONEY";
    public const string LevelKey = "LEVEL";

    public void SetLevel(int level)
    {
        PlayerPrefs.SetInt(LevelKey, level);
    }

    public int GetLevel()
    {
        return PlayerPrefs.GetInt(LevelKey, 1);
        
    }

    public void AddMoney(int money) 
    {
        PlayerPrefs.SetInt(MoneyKey, GetMoney() + money);
    }

    public int GetMoney() 
    {
        return PlayerPrefs.GetInt(MoneyKey, 0);
    }

    public void GameOver(bool isWin)
    {
        if (isWin)
        {
            SetLevel(GetLevel() + 1);
        }
    }
}
