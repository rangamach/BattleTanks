using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BombHandler : MonoBehaviour
{
    private AudioSource aud_source;
    [SerializeField] private AudioClip aud_clip;
    [SerializeField] private AudioClip expl;
    [SerializeField] private ParticleSystem explosionParticles;

    private void Start()
    {
        aud_source = GetComponent<AudioSource>();
        aud_source.PlayOneShot(aud_clip);
    }
    private void OnCollisionEnter(Collision collision)
    {
        explosionParticles.transform.parent = null;
        explosionParticles.Play();
        explosionParticles.AddComponent<ParticleEfectHandler>();
        this.gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;
        aud_source.PlayOneShot(expl);
        Destroy(this.gameObject, 0.02f);
    }
}
