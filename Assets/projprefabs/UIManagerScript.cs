using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject frontPageCanvas;
    public GameObject galleryCanvas;
    public GameObject arCanvas;

    public void ShowFrontPage()
    {
        frontPageCanvas.SetActive(true);
        galleryCanvas.SetActive(false);
        arCanvas.SetActive(false);
    }

    public void ShowGallery()
    {
        frontPageCanvas.SetActive(false);
        galleryCanvas.SetActive(true);
        arCanvas.SetActive(false);
    }

    public void ShowARCanvas()
    {
        frontPageCanvas.SetActive(false);
        galleryCanvas.SetActive(false);
        arCanvas.SetActive(true);
    }

}
