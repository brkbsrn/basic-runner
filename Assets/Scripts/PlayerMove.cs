using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Animator anim;
    public float moveSpeed = 3;
    private bool isRunning;
    public Transform StartPoint;
    

    private void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }

    public void GameStart()
    {
        isRunning = true;
        anim.SetBool("IsRunning", isRunning);       
    }
    

    public void GameOver(bool isWin)
    {
        isRunning = false;
        anim.SetBool("GameOver", true);
    }

    public void TapToStartOpened()
    {
        isRunning = false;
        anim.SetBool("IsRunning", isRunning);
        anim.SetBool("GameOver", false);
        transform.position = StartPoint.position;
        
        

        Debug.Log(StartPoint.parent.name);
    }

    private void FixedUpdate()
    {
        if (isRunning)
        {
            transform.Translate(Vector3.forward * Time.fixedDeltaTime * moveSpeed, Space.World);
        }
    }
}
