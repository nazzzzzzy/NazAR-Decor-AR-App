using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class SpawnPlaneProject : MonoBehaviour
{
    public ARRaycastManager arRaycastManager;
    public ARPlaneManager planeManager;

    public GameObject lampPrefab;
    public GameObject vanityPrefab;
    public GameObject gramophonePrefab;
    public GameObject bowlPrefab;

    private readonly List<ARRaycastHit> hits = new List<ARRaycastHit>();

    private bool planeDetectionEnabled = false;
    private bool objectPlaced = false;
    private GameObject spawnedObject;

    public int selectedProductID = 0;

    private void Awake()
    {
        DisablePlaneDetection();
    }

    private void Update()
    {
        if (!planeDetectionEnabled || objectPlaced)
            return;

        if (Input.touchCount == 0)
            return;

        Touch touch = Input.GetTouch(0);

        if (touch.phase != TouchPhase.Began)
            return;

        bool touchedPlane = arRaycastManager.Raycast(
            touch.position,
            hits,
            TrackableType.PlaneWithinPolygon
        );

        if (!touchedPlane)
            return;

        Pose hitPose = hits[0].pose;

        Vector3 cameraForward = Camera.main.transform.forward;
        cameraForward.y = 0f;

        if (cameraForward.sqrMagnitude > 0.001f)
        {
            hitPose.rotation = Quaternion.LookRotation(cameraForward);
        }

        SpawnSelectedObject(hitPose);

        if (spawnedObject != null)
        {
            spawnedObject.tag = "PlacedObject";
            objectPlaced = true;
            DisablePlaneDetection();
        }
    }

    private void SpawnSelectedObject(Pose hitPose)
    {
        DestroySpawnedObject();

        if (selectedProductID == 1)
        {
            spawnedObject = Instantiate(lampPrefab, hitPose.position, hitPose.rotation);
        }
        else if (selectedProductID == 2)
        {
            spawnedObject = Instantiate(vanityPrefab, hitPose.position, hitPose.rotation * Quaternion.Euler(0f, 180f, 0f));
        }

        else if (selectedProductID == 3)
        {
            spawnedObject = Instantiate(gramophonePrefab, hitPose.position, hitPose.rotation);
        }
        else if (selectedProductID == 4)
        {
            spawnedObject = Instantiate(bowlPrefab, hitPose.position, hitPose.rotation);
        }
    }

    public void SelectProduct(int productID)
    {
        selectedProductID = productID;
        DestroySpawnedObject();
        EnablePlaneDetection();
    }

    public void DestroySpawnedObject()
    {
        if (spawnedObject != null)
        {
            Destroy(spawnedObject);
            spawnedObject = null;
        }

        objectPlaced = false;
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
