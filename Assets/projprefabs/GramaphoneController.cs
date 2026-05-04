using UnityEngine;

public class GramophoneController : MonoBehaviour
{
    public AudioSource audioSource;
    public Transform recordTransform;
    public float rotationAmount = 30f;
    public float spinSpeed = 180f;

    private bool isPlaying = false;

    public void RotateObject()
    {
        transform.Rotate(0f, rotationAmount, 0f);
    }

    public void ToggleAudio()
    {
        if (audioSource == null)
            return;

        isPlaying = !isPlaying;

        if (isPlaying)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Stop();
        }
    }

    private void Update()
    {
        if (isPlaying && recordTransform != null)
        {
            recordTransform.Rotate(0f, spinSpeed * Time.deltaTime, 0f);
        }
    }
}
