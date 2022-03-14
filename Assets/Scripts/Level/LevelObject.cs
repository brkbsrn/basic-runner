using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelObject : MonoBehaviour
{
    public GameObject[] LevelObjects;

    private void OnEnable()
    {
        for (int i = 0; i < LevelObjects.Length; i++)
        {
            LevelObjects[i].SetActive(true);
        }
    }
}
