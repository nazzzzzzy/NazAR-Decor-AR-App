using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class SpawnPlane : MonoBehaviour
{
    public ARRaycastManager arRaycastManager;
    public ARPlaneManager planeManager;
    public GameObject spawnPrefab;
    public GameObject spawnPrefab1; // John Lemon
    public GameObject spawnPrefab2; // Beach Town

    private readonly List<ARRaycastHit> hits = new List<ARRaycastHit>();

    private bool planeDetectionEnabled = false;
    private bool objectPlaced = false;
    private GameObject spawnedObject;
    public int buttonID;

    private void Awake()
    {
        DisablePlaneDetection();
    }
    
    void Update()
    {
        if (!planeDetectionEnabled || objectPlaced)
            return;

        if (Input.touchCount == 0)
            return;

        Touch touch = Input.GetTouch(0);

        if (touch.phase != TouchPhase.Began)
            return;

        bool touchedPlane = arRaycastManager.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon);

        if (touchedPlane && !objectPlaced)
        {
            Pose hitPose = hits[0].pose;

            Vector3 cameraForwaard = Camera.main.transform.forward;
            cameraForwaard.y = 0;

            if (cameraForwaard.sqrMagnitude > 0.001f)
            {
                hitPose.rotation = Quaternion.LookRotation(cameraForwaard);
            }

            if (buttonID == 1)
            {
                spawnedObject = Instantiate(spawnPrefab1, hitPose.position, hitPose.rotation);
            }
            else if (buttonID == 2)
            {
                spawnedObject = Instantiate(spawnPrefab2, hitPose.position, hitPose.rotation);
            }
            objectPlaced = true;

            DisablePlaneDetection();
        }
        }
     public void DestroySpawnedObject()
    {         if (spawnedObject != null)
        {
            Destroy(spawnedObject);
            spawnedObject = null;
        }
        objectPlaced = false;
    }

    public void getButtonID(int index)
    {
        buttonID = index;
    }

    public void EnablePlaneDetection()
    {
        planeDetectionEnabled = true;
        objectPlaced = false;

        planeManager.enabled = true;

        foreach (ARPlane plane in planeManager.trackables)
        {
            plane.gameObject.SetActive(true);
        }
    }

    public void DisablePlaneDetection()
    {
        planeDetectionEnabled = false;

        foreach (ARPlane plane in planeManager.trackables)
        {
            plane.gameObject.SetActive(false);
        }

           planeManager.enabled = false;
    }
}
