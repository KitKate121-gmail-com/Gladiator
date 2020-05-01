using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fighting : MonoBehaviour
{
    public GameObject[] weapons;
    public Animator pl;
   public  int damage;
    public Audio_Player plclip;
   public int enemydefense;
    // Start is called before the first frame update
    void Start()
    {
        plclip=gameObject.GetComponent<Audio_Player>();
    }

    // Update is called once per frame
    void Update()
    {
       weaponselec();
       check();

    }
   public void check()
    {
     
        if(Input.GetKeyDown("[6]"))
        {
          
          plclip.plsource.clip=plclip.placlips[2];
           plclip.plsource.Play();
          enemydefense=Random.Range(0,4);
          pl.SetInteger("Attack",1);
        }
        else if(Input.GetKeyDown("[8]"))
        {
           
           enemydefense=Random.Range(0,4);
          plclip.plsource.clip=plclip.placlips[2];
           plclip.plsource.Play();
           plclip.num=3;
          pl.SetInteger("Attack",2);
        }
        else if(Input.GetKeyDown("[2]"))
        {
           enemydefense=Random.Range(0,4);
          plclip.plsource.clip=plclip.placlips[2];
           plclip.plsource.Play();
           plclip.num=3;
          pl.SetInteger("Attack",4);
        }
        else if(Input.GetKey("[4]"))
        { 
          plclip.plsource.clip=plclip.placlips[2];
           plclip.plsource.Play();
           plclip.num=3;
          pl.SetInteger("Attack",3);
        }
        else
        {
            pl.SetInteger("Attack",0);
        }
      
    }
    public void damagepoints(){

      if(weapons[0].activeSelf==true)
      {
        damage=2;
       
       
      }
      
      if(weapons[1].activeSelf==true)
      {
        damage=5;
      }
      
      if(weapons[2].activeSelf==true)
      {
        damage=10;
      }
      
      if(weapons[3].activeSelf==true)
      {
        damage=12;
      }
      
      if(weapons[4].activeSelf==true)
      {
        damage=14;
      }
      
      if(weapons[5].activeSelf==true)
      {
        damage=16;
      }
      
      if(weapons[6].activeSelf==true)
      {
        damage=20;
      }
    }

    void weaponselec()
    {
          if (Input.GetKeyDown("1"))
        {
            weapons[0].SetActive(true);
                weapons[1].SetActive(false);
                weapons[2].SetActive(false);
                weapons[3].SetActive(false);
                weapons[4].SetActive(false);
                weapons[5].SetActive(false);
                weapons[6].SetActive(false);
                weapons[7].SetActive(false);
            
        }
          if (Input.GetKeyDown("2"))
        {
            weapons[1].SetActive(true);
            weapons[0].SetActive(false);
                weapons[2].SetActive(false);
                weapons[3].SetActive(false);
                weapons[4].SetActive(false);
                weapons[5].SetActive(false);
                weapons[6].SetActive(false);
                weapons[7].SetActive(false);
            
        }
          if (Input.GetKeyDown("3"))
        {
            weapons[2].SetActive(true);
            weapons[1].SetActive(false);
                weapons[0].SetActive(false);
                weapons[3].SetActive(false);
                weapons[4].SetActive(false);
                weapons[5].SetActive(false);
                weapons[6].SetActive(false);
                weapons[7].SetActive(false);
            
        }
          if (Input.GetKeyDown("4"))
        {
            weapons[3].SetActive(true);
            weapons[1].SetActive(false);
                weapons[0].SetActive(false);
                weapons[2].SetActive(false);
                weapons[4].SetActive(false);
                weapons[5].SetActive(false);
                weapons[6].SetActive(false);
                weapons[7].SetActive(false);
            
        }
          if (Input.GetKeyDown("5"))
        {
            weapons[4].SetActive(true);
            weapons[1].SetActive(false);
                weapons[0].SetActive(false);
                weapons[3].SetActive(false);
                weapons[2].SetActive(false);
                weapons[5].SetActive(false);
                weapons[6].SetActive(false);
                weapons[7].SetActive(false);
            
        }
         if (Input.GetKeyDown("6"))
        {
            weapons[5].SetActive(true);
            weapons[1].SetActive(false);
                weapons[0].SetActive(false);
                weapons[3].SetActive(false);
                weapons[2].SetActive(false);
                weapons[4].SetActive(false);
                weapons[6].SetActive(false);
                weapons[7].SetActive(false);
            
        }
    }
}
