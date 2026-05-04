using UnityEngine;
using UnityEngine.SceneManagement;

public class ARSceneManager : MonoBehaviour
{
    public void BackToGallery()
    {
        SceneManager.LoadScene("ProductGalleryScene");
    }
}
