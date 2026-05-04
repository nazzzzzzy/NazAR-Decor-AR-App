using UnityEngine;

public class BowlController : MonoBehaviour
{
    public Transform modelRoot;
    public Vector3 smallScale = new Vector3(0.8f, 0.8f, 0.8f);
    public Vector3 largeScale = new Vector3(1.2f, 1.2f, 1.2f);
    public ParticleSystem steamEffect;
    public GameObject soupObject;

    private bool isLarge = false;
    private bool steamOn = false;

    private void Awake()
    {
        if (modelRoot == null)
        {
            modelRoot = transform;
        }
    }

    public void ToggleSize()
    {
        if (modelRoot == null)
            return;

        modelRoot.localScale = isLarge ? smallScale : largeScale;
        isLarge = !isLarge;
    }

    public void ToggleSteam()
    {
        if (soupObject != null)
        {
            soupObject.SetActive(!steamOn);
        }

        if (steamEffect != null)
        {
            if (!steamEffect.gameObject.activeSelf)
            {
                steamEffect.gameObject.SetActive(true);
            }

            if (steamOn)
            {
                steamEffect.Stop();
            }
            else
            {
                steamEffect.Play();
            }
        }

        steamOn = !steamOn;
    }
}
