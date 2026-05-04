using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActions : MonoBehaviour
{
    public SpawnPlane spawner; 

    private GameObject GetCurrentObject()
    {
        if (spawner.buttonID == 1)
            return GameObject.FindGameObjectWithTag("johnlemon");

        else if (spawner.buttonID == 2)
            return GameObject.FindGameObjectWithTag("beachtown");

        return null;
    }

    public void LeftRotateButton()
    {
        GameObject obj = GetCurrentObject();
        if (obj != null)
        {
            obj.transform.Rotate(0, 20, 0);
        }
    }

    public void RightRotateButton()
    {
        GameObject obj = GetCurrentObject();
        if (obj != null)
        {
            obj.transform.Rotate(0, -20, 0);
        }
    }

    public void InfoButton()
    {
        GameObject obj = GetCurrentObject();
        if (obj != null)
        {
            Canvas popup = obj.GetComponentInChildren<Canvas>(true);
            if (popup != null)
            {
                popup.gameObject.SetActive(!popup.gameObject.activeSelf);
            }
        }
    }
}