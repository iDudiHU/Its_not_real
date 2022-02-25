using UnityEngine;
using System.Collections;

public class AudioEndDetector : MonoBehaviour
{
    public GameObject otherButton;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            otherButton.SetActive(true);
        }
    }
}