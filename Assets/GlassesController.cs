using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassesController : MonoBehaviour
{
    public GameObject[] glasses;
    private GameObject currentGlasses;

    void OnEnable()
    {
        Invoke("DisableAll", 0.5f);
    }

    void DisableAll()
    {
        foreach (GameObject g in glasses)
        {
            if (g != null)
            {
                Renderer r = g.GetComponentInChildren<Renderer>();
                if (r != null)
                {
                    r.enabled = false;
                }
            }
        }
    }

    public void SelectGlasses(int index)
    {
        DisableAll();

        if (index < glasses.Length && glasses[index] != null)
        {
            Renderer r = glasses[index].GetComponentInChildren<Renderer>();
            if (r != null)
            {
                r.enabled = true;
            }

            currentGlasses = glasses[index];
        }
    }

    public void SetHotPink()
    {
        SetColor(new Color(1f, 0.1f, 0.5f));
    }

    public void SetCyan()
    {
        SetColor(Color.cyan);
    }

    public void SetPurple()
    {
        SetColor(new Color(0.5f, 0f, 0.5f));
    }

    void SetColor(Color color)
    {
        if (currentGlasses != null)
        {
            Renderer r = currentGlasses.GetComponentInChildren<Renderer>();
            if (r != null)
            {
                r.material.color = color;
            }
        }
    }
}