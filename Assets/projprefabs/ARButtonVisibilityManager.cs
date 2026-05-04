using UnityEngine;

public class ARButtonVisibilityManager : MonoBehaviour
{
    public GameObject backButton;

    public GameObject colorButton;
    public GameObject effectsButton;
    public GameObject lightButton;
    public GameObject rotateButton;
    public GameObject resizeButton;
    public GameObject moveButton;
    public GameObject audioButton;
    public GameObject drawerButton;
    public GameObject infoButton;
    public GameObject showHideButton;

    public void ShowButtonsForProduct(int selectedID)
    {
        HideAllActionButtons();

        if (backButton != null)
            backButton.SetActive(true);

        if (selectedID == 1)
        {
            if (lightButton != null) lightButton.SetActive(true);
            if (infoButton != null) infoButton.SetActive(true);
        }
        else if (selectedID == 2)
        {
            if (colorButton != null) colorButton.SetActive(true);
            if (drawerButton != null) drawerButton.SetActive(true);
            if (showHideButton != null) showHideButton.SetActive(true);
        }
        else if (selectedID == 3)
        {
            if (rotateButton != null) rotateButton.SetActive(true);
            if (audioButton != null) audioButton.SetActive(true);
            if (moveButton != null) moveButton.SetActive(true);
        }
        else if (selectedID == 4)
        {
            if (resizeButton != null) resizeButton.SetActive(true);
            if (effectsButton != null) effectsButton.SetActive(true);
        }
    }

    public void HideAllActionButtons()
    {
        if (colorButton != null) colorButton.SetActive(false);
        if (effectsButton != null) effectsButton.SetActive(false);
        if (lightButton != null) lightButton.SetActive(false);
        if (rotateButton != null) rotateButton.SetActive(false);
        if (resizeButton != null) resizeButton.SetActive(false);
        if (moveButton != null) moveButton.SetActive(false);
        if (audioButton != null) audioButton.SetActive(false);
        if (drawerButton != null) drawerButton.SetActive(false);
        if (infoButton != null) infoButton.SetActive(false);
        if (showHideButton != null) showHideButton.SetActive(false);
    }
}
