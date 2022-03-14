using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameState : MonoBehaviour
{
    public int CollectedCoin;
    public Text CollectedCoinCountDisplay;

    public Text LevelText;

    public void CoinCollected()
    {
        CollectedCoin++;
        CollectedCoinCountDisplay.text = CollectedCoin.ToString();
    }

    private void WriteLevel()
    {
        int level = GameManager.Instance.PrefManager.GetLevel();
        LevelText.text = level.ToString();
    }

    private void OnEnable()
    {
        WriteLevel();
        CollectedCoin = 0;
        CollectedCoinCountDisplay.text = CollectedCoin.ToString();
    }
}
