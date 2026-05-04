using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class UserTouch : MonoBehaviour
{
    public ARRaycastManager arRaycastManager;
    public TMP_Text debugText;
    public ARPlaneManager planeManager;

    private readonly List<ARRaycastHit> hits = new List<ARRaycastHit>();

    private void Awake()
    {
        if (arRaycastManager == null)
        {
            arRaycastManager = FindObjectOfType<ARRaycastManager>();
        }
    }

    private void Update()
    {
        if (Input.touchCount == 0)
        {
            if (debugText != null)
                debugText.text = "No touch detected.";
            return;
        }

        Touch touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Began)
        {
            return;
        }

        bool touchedPlane = arRaycastManager.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon);

        if (debugText != null)
        {
            debugText.text = "Plane touched: " + touchedPlane.ToString();
        }
        if (touchedPlane)
        {
            Pose hitPose = hits[0].pose;
        }
    }
}
