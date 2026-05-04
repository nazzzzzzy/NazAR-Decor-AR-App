using UnityEngine;
using TMPro;

public class ActionButtons : MonoBehaviour
{
    public SpawnPlaneProject spawnManager;
    public GameObject infoPanel;
    public TMP_Text infoText;

    private GameObject GetPlacedObject()
    {
        GameObject placedObject = GameObject.FindGameObjectWithTag("PlacedObject");

        if (placedObject == null)
        {
            Debug.Log("No object with tag PlacedObject was found.");
        }
        else
        {
            Debug.Log("Placed object found: " + placedObject.name);
        }

        return placedObject;
    }

    private T GetPlacedController<T>() where T : Component
    {
        GameObject placedObject = GetPlacedObject();
        if (placedObject == null)
            return null;

        T controller = placedObject.GetComponentInChildren<T>(true);

        if (controller == null)
        {
            Debug.Log("No controller of type " + typeof(T).Name + " found on placed object or its children.");
        }
        else
        {
            Debug.Log("Found controller: " + typeof(T).Name);
        }

        return controller;
    }

    public void ShowLampInfo()
    {
        GameObject placedObject = GameObject.FindGameObjectWithTag("PlacedObject");
        if (placedObject == null)
            return;

        LampController lamp = placedObject.GetComponentInChildren<LampController>(true);
        if (lamp != null)
        {
            lamp.ToggleInfo();
        }
    }



    public void ChangeVanityColor()
    {
        Debug.Log("ChangeVanityColor clicked");

        VanityController vanity = GetPlacedController<VanityController>();
        if (vanity != null)
        {
            vanity.ChangeColor();
        }
    }

    public void ToggleVanityChair()
    {
        Debug.Log("ToggleVanityChair clicked");

        VanityController vanity = GetPlacedController<VanityController>();
        if (vanity != null)
        {
            vanity.ToggleChairVisibility();
        }
    }

    public void ToggleVanityDrawers()
    {
        Debug.Log("ToggleVanityDrawers clicked");

        VanityController vanity = GetPlacedController<VanityController>();
        if (vanity != null)
        {
            vanity.ToggleDrawers();
        }
    }
    public void ToggleLampLight()
    {
        Debug.Log("ToggleLampLight clicked");

        GameObject placedObject = GameObject.FindGameObjectWithTag("PlacedObject");
        if (placedObject == null)
        {
            Debug.Log("No placed object found.");
            return;
        }

        LampController lamp = placedObject.GetComponentInChildren<LampController>(true);
        if (lamp == null)
        {
            Debug.Log("LampController not found.");
            return;
        }

        lamp.ToggleLight();
    }

    public void RotateGramophone()
    {
        Debug.Log("RotateGramophone clicked");

        GramophoneController gramophone = GetPlacedController<GramophoneController>();
        if (gramophone != null)
        {
            gramophone.RotateObject();
        }
    }

    public void ToggleGramophoneAudio()
    {
        Debug.Log("ToggleGramophoneAudio clicked");

        GramophoneController gramophone = GetPlacedController<GramophoneController>();
        if (gramophone != null)
        {
            gramophone.ToggleAudio();
        }
    }

    public void MovePlacedObject()
    {
        Debug.Log("MovePlacedObject clicked");

        if (spawnManager != null)
        {
            spawnManager.DestroySpawnedObject();
            spawnManager.EnablePlaneDetection();
        }
        else
        {
            Debug.Log("spawnManager is null.");
        }
    }

    public void ToggleBowlSize()
    {
        Debug.Log("ToggleBowlSize clicked");

        BowlController bowl = GetPlacedController<BowlController>();
        if (bowl != null)
        {
            bowl.ToggleSize();
        }
    }

    public void ToggleBowlSteam()
    {
        Debug.Log("ToggleBowlSteam clicked");

        BowlController bowl = GetPlacedController<BowlController>();
        if (bowl != null)
        {
            bowl.ToggleSteam();
        }
    }

    public void HideInfoPanel()
    {
        Debug.Log("HideInfoPanel clicked");

        if (infoPanel != null)
        {
            infoPanel.SetActive(false);
        }
    }
}
