using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public List<GameObject> LevelPrefabs;
    private GameObject[] levelInstances;

    private GameObject currentLevel;

    private void Awake()
    {
        levelInstances = new GameObject[LevelPrefabs.Count];
        for (int i = 0; i < LevelPrefabs.Count; i++)
        {
            levelInstances[i] =Instantiate(LevelPrefabs[i],gameObject.transform);
            levelInstances[i].SetActive(false);
        }
       
    }
    

    public void TapToStartOpened()
    {
        if (currentLevel)
        {
            currentLevel.SetActive(false);
        }
        int level = GameManager.Instance.PrefManager.GetLevel();
        int index = (level - 1) % levelInstances.Length;
        currentLevel = levelInstances[index];
        currentLevel.SetActive(true);
    }
}
