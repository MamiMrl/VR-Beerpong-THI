using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHighlight : MonoBehaviour
{
    public Material outlineMaterial;
    private Material originalMaterial;
    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        originalMaterial = renderer.material;
    }

    void OnMouseOver()
    {
        renderer.material = outlineMaterial;
    }

    void OnMouseExit()
    {
        renderer.material = originalMaterial;
    }
}
