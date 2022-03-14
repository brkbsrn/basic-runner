using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 public class Health : MonoBehaviour
{
    public int characterHp;
    public int numOfHearts;

    [SerializeField] public Image[] hearts;
    [SerializeField] public Sprite fullHeart;
    [SerializeField] public Sprite emptyHeart;

    

    private void OnEnable()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].sprite = fullHeart;
        }
        characterHp = 3;
    }

    public void UpdateHealth()
    {
        if (characterHp > numOfHearts)
        {
            characterHp = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < characterHp)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}