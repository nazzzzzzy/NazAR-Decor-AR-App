using UnityEngine;

public class GalleryButtonHandler : MonoBehaviour
{
    public UIManager uiManager;
    public SpawnPlaneProject spawnPlaneProject;
    public ARButtonVisibilityManager buttonVisibilityManager;

    public void SelectLamp()
    {
        spawnPlaneProject.SelectProduct(1);
        uiManager.ShowARCanvas();
        buttonVisibilityManager.ShowButtonsForProduct(1);
    }

    public void SelectVanity()
    {
        spawnPlaneProject.SelectProduct(2);
        uiManager.ShowARCanvas();
        buttonVisibilityManager.ShowButtonsForProduct(2);
    }

    public void SelectGramophone()
    {
        spawnPlaneProject.SelectProduct(3);
        uiManager.ShowARCanvas();
        buttonVisibilityManager.ShowButtonsForProduct(3);
    }

    public void SelectBowl()
    {
        spawnPlaneProject.SelectProduct(4);
        uiManager.ShowARCanvas();
        buttonVisibilityManager.ShowButtonsForProduct(4);
    }

    public void BackToFrontPage()
    {
        uiManager.ShowFrontPage();
    }
}
