using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleOpenAnimation : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(OpenRoutine());
    }

    private IEnumerator OpenRoutine()
    {
        transform.localScale = Vector3.zero;

        float scale = 0f;
        for (int i = 0; i <= 20; i++)
        {
            scale = i * 0.05f;
            transform.localScale = Vector3.one * scale;
            yield return new WaitForFixedUpdate();
        }
    }
}
