using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLoseState : MonoBehaviour
{
    public Button RetryButton;
    public Text LosedCoinText;
    private int losedCoin;

    public Text CoinText;

    private void Awake()
    {
        RetryButton.onClick.AddListener(OnRetryButtonClicked);
    }

    private void OnRetryButtonClicked()
    {
        GameManager.Instance.TapToStartOpened();
    }

    private void OnEnable()
    {
        GetAndWriteCollectedCoin();
        WriteCoin();
    }

    private void GetAndWriteCollectedCoin()
    {
        losedCoin = GameManager.Instance.InGameState.CollectedCoin;
        LosedCoinText.text = losedCoin.ToString();
    }

    private void WriteCoin()
    {
        int coin = GameManager.Instance.PrefManager.GetMoney();
        CoinText.text = coin.ToString();
    }
}
