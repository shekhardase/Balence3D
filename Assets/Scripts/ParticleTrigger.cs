using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem Particles;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Blocks") {
            Particles.Play();
        }
    }
}
