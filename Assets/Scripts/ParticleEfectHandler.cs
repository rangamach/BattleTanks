using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEfectHandler : MonoBehaviour
{
    private void Update()
    {
        if(!this.gameObject.GetComponent<ParticleSystem>().isPlaying)
            Destroy(this.gameObject);
    }
}
