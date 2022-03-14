using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapToStartState : MonoBehaviour
{
    public Text LevelText;
    public Text CoinText;
    private void WriteLevel()
    {
        int level = GameManager.Instance.PrefManager.GetLevel();
        LevelText.text = level.ToString();
    }
    private void OnEnable()
    {
        WriteLevel();
        WriteCoin();
    }
    private void WriteCoin()
    {
        int coin = GameManager.Instance.PrefManager.GetMoney();
        CoinText.text = coin.ToString();
    }
}
