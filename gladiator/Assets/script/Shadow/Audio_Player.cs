using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Player : MonoBehaviour
{
    public AudioSource plsource;
    public AudioClip[] placlips;
    public int num;
    int i;
    // Start is called before the first frame update
   public void soundcaller()
   {
       plsource.clip=placlips[num];
       plsource.Play();
   }
}
