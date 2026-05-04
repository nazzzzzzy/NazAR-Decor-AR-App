using UnityEngine;
using System.Collections;

public class VanityController : MonoBehaviour
{
    public Transform[] drawers;
    public Transform[] handles;

    public Vector3[] closedPositions;
    public Vector3[] openPositions;

    public Vector3[] closedHandlePositions;
    public Vector3[] openHandlePositions;

    public Renderer[] colorRenderers;
    public Material colorOne;
    public Material colorTwo;

    public GameObject chairObject;

    private bool drawersOpen = false;
    private bool usingFirstColor = true;
    private bool chairVisible = true;
    private bool isAnimating = false;

    public void ToggleDrawers()
    {
        if (drawers == null || drawers.Length == 0 || isAnimating)
            return;

        StartCoroutine(AnimateDrawers());
    }

    private IEnumerator AnimateDrawers()
    {
        isAnimating = true;

        float duration = 0.35f;
        float elapsed = 0f;

        Vector3[] startDrawerPositions = new Vector3[drawers.Length];
        Vector3[] targetDrawerPositions = new Vector3[drawers.Length];

        Vector3[] startHandlePositions = new Vector3[handles.Length];
        Vector3[] targetHandlePositions = new Vector3[handles.Length];

        for (int i = 0; i < drawers.Length; i++)
        {
            if (drawers[i] != null)
            {
                startDrawerPositions[i] = drawers[i].localPosition;
                targetDrawerPositions[i] = drawersOpen ? closedPositions[i] : openPositions[i];
            }
        }

        for (int i = 0; i < handles.Length; i++)
        {
            if (handles[i] != null)
            {
                startHandlePositions[i] = handles[i].localPosition;
                targetHandlePositions[i] = drawersOpen ? closedHandlePositions[i] : openHandlePositions[i];
            }
        }

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            float t = Mathf.SmoothStep(0f, 1f, elapsed / duration);

            for (int i = 0; i < drawers.Length; i++)
            {
                if (drawers[i] != null)
                    drawers[i].localPosition = Vector3.Lerp(startDrawerPositions[i], targetDrawerPositions[i], t);
            }

            for (int i = 0; i < handles.Length; i++)
            {
                if (handles[i] != null)
                    handles[i].localPosition = Vector3.Lerp(startHandlePositions[i], targetHandlePositions[i], t);
            }

            yield return null;
        }

        drawersOpen = !drawersOpen;
        isAnimating = false;
    }

    public void ChangeColor()
    {
        if (colorRenderers == null || colorRenderers.Length == 0 || colorOne == null || colorTwo == null)
            return;

        Material targetMaterial = usingFirstColor ? colorTwo : colorOne;

        foreach (Renderer rend in colorRenderers)
        {
            if (rend == null)
                continue;

            Material[] mats = rend.materials;

            for (int i = 0; i < mats.Length; i++)
            {
                mats[i] = targetMaterial;
            }

            rend.materials = mats;
        }

        usingFirstColor = !usingFirstColor;
    }

    public void ToggleChairVisibility()
    {
        if (chairObject == null)
            return;

        chairVisible = !chairVisible;
        chairObject.SetActive(chairVisible);
    }
}
