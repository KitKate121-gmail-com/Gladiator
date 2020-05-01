using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    int maxhealth=100;
    public int xp;
    public int health;
    public int scenecount;
    Animator playeranimation;
    public Image healthbar;
    float healthflo;
    // Start is called before the first frame update
    void Start()
    {
        health=100;
        
        xp=PlayerPrefs.GetInt("Xp",0);
        scenecount=PlayerPrefs.GetInt("Scenecount",1);
        playeranimation= gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
          bar();
        PlayerPrefs.SetInt("Health",health);
        PlayerPrefs.SetInt("Xp",xp);
        PlayerPrefs.SetInt("Scenecount",scenecount);
       
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
       
    }
    void bar()
    {
        healthflo=(float)health*4;
        healthbar.rectTransform.sizeDelta=new Vector2(healthflo,19.5f);
    }
}
