using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    public MeshRenderer MeshRenderer;
    public Material[] Materials;

    private void OnEnable()
    {
        int index = Random.Range(0, Materials.Length);
        MeshRenderer.material = Materials[index];
    }
}
