using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameWinState : MonoBehaviour
{
    public Button ContinueButton;
    public Text CollectedCoinText;
    private int collectedCoin;

    public Text CoinText;

    private void Awake()
    {
        ContinueButton.onClick.AddListener(OnContinueButtonClicked);
    }

    private void OnContinueButtonClicked() 
    {
        GameManager.Instance.TapToStartOpened();
    }

    private void OnEnable()
    {
        GetAndWriteCollectedCoin();
        GiveCoinsToPlayer();
        WriteCoin();
    }

    private void GiveCoinsToPlayer()
    {
        GameManager.Instance.PrefManager.AddMoney(collectedCoin);
    }

    private void GetAndWriteCollectedCoin()
    {
        collectedCoin = GameManager.Instance.InGameState.CollectedCoin;
        CollectedCoinText.text = "+ " + collectedCoin.ToString();
    }

    private void WriteCoin()
    {
        int coin = GameManager.Instance.PrefManager.GetMoney();
        CoinText.text = coin.ToString();
    }
}
