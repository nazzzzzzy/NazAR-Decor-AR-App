using UnityEngine;

public class LampController : MonoBehaviour
{
    public GameObject lampOffObject;
    public GameObject lampOnObject;
    public GameObject infoCanvas;

    private bool isOn = false;

    private void Awake()
    {
        if (lampOffObject != null)
            lampOffObject.SetActive(true);

        if (lampOnObject != null)
            lampOnObject.SetActive(false);

        if (infoCanvas != null)
            infoCanvas.SetActive(false);

        isOn = false;
    }

    public void ToggleLight()
    {
        if (lampOffObject == null || lampOnObject == null)
            return;

        isOn = !isOn;
        lampOffObject.SetActive(!isOn);
        lampOnObject.SetActive(isOn);
    }

    public void ToggleInfo()
    {
        if (infoCanvas == null)
            return;

        infoCanvas.SetActive(!infoCanvas.activeSelf);
    }
}
