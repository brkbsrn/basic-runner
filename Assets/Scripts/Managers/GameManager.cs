using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public PlayerMove PlayerMove;
    public UIManager UIManager;
    public PrefManager PrefManager;
    public TapToStartState TapToStartState;
    public InGameState InGameState;
    public GameWinState GameWinState;
    public GameLoseState GameLoseState;
    public LevelManager LevelManager;
    public Health Health;
    public CameraFollow CameraFollow;


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        TapToStartOpened();
    }

    public void GameStart() 
    {
        PlayerMove.GameStart();
        UIManager.GameStart();
    }

    public void GameOver(bool isWin)
    {
        PlayerMove.GameOver(isWin);
        UIManager.GameOver(isWin);
        PrefManager.GameOver(isWin);
    }
    


    public void TapToStartOpened()
    {
        PlayerMove.TapToStartOpened();
        UIManager.TapToStartOpened();
        LevelManager.TapToStartOpened();
        CameraFollow.SetCamera();
    }
}
