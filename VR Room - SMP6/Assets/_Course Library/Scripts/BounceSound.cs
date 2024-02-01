using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class BounceSound : MonoBehaviour
{
    private Rigidbody rb;
    AudioSource audioSource;
    public AudioClip hitsound;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        audioSource.PlayOneShot(hitsound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
