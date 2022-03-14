using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private int obstacleDamage;

    public ParticleSystem CoinCollectVFX;
    bool isShieldActive;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collect"))
        {
            GameManager.Instance.InGameState.CoinCollected();
            other.gameObject.SetActive(false);
            CoinCollectVFX.Stop(true);
            CoinCollectVFX.Play(true);
        }
        else if (other.CompareTag("Obstacle"))
        {
            if (isShieldActive)
            {               
                return; 
            }
            
            other.gameObject.SetActive(false);
            Damage();
            if (GameManager.Instance.Health.characterHp <= 0)
            {
                GameManager.Instance.GameOver(false);
            }
        }
        else if (other.CompareTag("Finish"))
        {
            GameManager.Instance.GameOver(true);
        }
        else if (other.CompareTag("Shield"))
        {
            isShieldActive = true;            
            Invoke(nameof(DisableShield),2);
            other.gameObject.SetActive(false);

        }
        
    }
    void Damage()
    {
        GameManager.Instance.Health.characterHp = GameManager.Instance.Health.characterHp - obstacleDamage;
        GameManager.Instance.Health.UpdateHealth();        
    }
    void DisableShield()
    {
        isShieldActive = false;
    }
}
