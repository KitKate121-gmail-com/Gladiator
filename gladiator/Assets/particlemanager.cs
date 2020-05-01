using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlemanager : MonoBehaviour
{
    public ParticleSystem[] particles;
    public int i;
    public void paritclecaller()
    {
        particles[i].Play();
    }
    
}
