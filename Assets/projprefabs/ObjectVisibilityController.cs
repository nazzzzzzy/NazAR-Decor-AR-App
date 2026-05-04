using UnityEngine;

public class ObjectVisibilityController : MonoBehaviour
{
    private Renderer[] objectRenderers;
    private bool isVisible = true;

    private void Awake()
    {
        objectRenderers = GetComponentsInChildren<Renderer>(true);
    }

    public void ToggleVisibility()
    {
        isVisible = !isVisible;

        foreach (Renderer rend in objectRenderers)
        {
            rend.enabled = isVisible;
        }
    }
}
