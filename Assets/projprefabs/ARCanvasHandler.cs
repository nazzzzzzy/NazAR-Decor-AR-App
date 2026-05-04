using UnityEngine;

public class ARCanvasHandler : MonoBehaviour
{
    public UIManager uiManager;
    public SpawnPlaneProject spawnPlaneProject;

    public void BackToGallery()
    {
        spawnPlaneProject.DestroySpawnedObject();
        spawnPlaneProject.DisablePlaneDetection();
        uiManager.ShowGallery();
    }
}
