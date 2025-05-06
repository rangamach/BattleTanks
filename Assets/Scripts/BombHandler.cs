using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombHandler : MonoBehaviour
{
    private AudioSource aud_source;
    [SerializeField] private AudioClip aud_clip;
    private void Start()
    {
        aud_source = GetComponent<AudioSource>();
        aud_source.PlayOneShot(aud_clip);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}
