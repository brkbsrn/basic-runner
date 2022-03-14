using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject TapToStartMainGO;
    public GameObject InGameUI;
    public GameObject GameOverLoseUI;
    public GameObject GameOverWinUI;

    public void GameStart()
    {
        TapToStartMainGO.SetActive(false);
        InGameUI.SetActive(true);
    }

    public void GameOver(bool isWin)
    {
        InGameUI.SetActive(false);
        if (isWin)
        {
            GameOverWinUI.SetActive(true);
        }
        else
        {
            GameOverLoseUI.SetActive(true);
            
        }
    }

    public void TapToStartOpened()
    {
        TapToStartMainGO.SetActive(true);
        GameOverWinUI.SetActive(false);
        GameOverLoseUI.SetActive(false);
        InGameUI.SetActive(false);
    }
}
