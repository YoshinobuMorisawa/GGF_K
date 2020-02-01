using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouth : MonoBehaviour
{
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    AudioSource se;
    static int sePattern;
    static int Pattern;
    
    public float Battery;
    public float Net;
    public bool isNew;

void Start()
    {
        se = GetComponent<AudioSource>();
        Pattern = Random.Range(0, 101);
        sePattern = Random.Range(1,4);

        if(Pattern <= 50)
        {
            isNew = true;
        }
        else
        {
            isNew = false;
        }
        
        if(isNew)
        {
            if (Pattern >= 50)//バッテリー
            {
                if (Pattern >=30)//回線強度
                {
                    if (sePattern == 1)
                    {
                        //A
                        se.PlayOneShot(sound1);
                    }
                    if (sePattern == 2)
                    {
                        //B
                        se.PlayOneShot(sound2);
                    }
                    if (sePattern == 3)
                    {
                        //D
                        se.PlayOneShot(sound3);
                    }
                }
                if (Pattern < 30)//回線強度
                {
                    if (sePattern == 1)
                    {
                        //E
                        se.PlayOneShot(sound1);
                    }
                    if (sePattern == 2)
                    {
                        //B
                        se.PlayOneShot(sound2);
                    }
                    if (sePattern == 3)
                    {
                        //D
                        se.PlayOneShot(sound3);
                    }
                }
            }
            if (Pattern < 50)//バッテリー
            {
                if (Pattern >= 30)//回線強度
                {
                    if (sePattern == 1)
                    {
                        //A
                        se.PlayOneShot(sound1);
                    }
                    if (sePattern == 2)
                    {
                        //B
                        se.PlayOneShot(sound2);
                    }
                    if (sePattern == 3)
                    {
                        //E
                        se.PlayOneShot(sound3);
                    }
                }
                if (Pattern < 30)//回線強度
                {
                    if (sePattern == 1)
                    {
                        //E
                        se.PlayOneShot(sound1);
                    }
                    if (sePattern == 2)
                    {
                        //F
                        se.PlayOneShot(sound2);
                    }
                    if (sePattern == 3)
                    {
                        //G
                        se.PlayOneShot(sound3);
                    }
                }
            }
            if(isNew)
            {
                if (Pattern >= 20)//バッテリー
                {
                    if (Pattern >= 80)//回線強度
                    {
                        if (sePattern == 1)
                        {
                            //G
                            se.PlayOneShot(sound1);
                        }
                        if (sePattern == 2)
                        {
                            //E
                            se.PlayOneShot(sound2);
                        }
                        if (sePattern == 3)
                        {
                            //C
                            se.PlayOneShot(sound3);
                        }
                    }
                    if (Pattern < 80)//回線強度
                    {
                        if (sePattern == 1)
                        {
                            //E
                            se.PlayOneShot(sound1);
                        }
                        if (sePattern == 2)
                        {
                            //B
                            se.PlayOneShot(sound2);
                        }
                        if (sePattern == 3)
                        {
                            //D
                            se.PlayOneShot(sound3);
                        }
                    }
                }
                if (Pattern >= 20)//バッテリー
                {
                    if (Pattern >= 80)//回線強度
                    {
                        if (sePattern == 1)
                        {
                            //A
                            se.PlayOneShot(sound1);
                        }
                        if (sePattern == 2)
                        {
                            //E
                            se.PlayOneShot(sound2);
                        }
                        if (sePattern == 3)
                        {
                            //F
                            se.PlayOneShot(sound3);
                        }
                    }
                    if (Pattern < 80)//回線強度
                    {
                        if (sePattern == 1)
                        {
                            //F
                            se.PlayOneShot(sound1);
                        }
                        if (sePattern == 2)
                        {
                            //F
                            se.PlayOneShot(sound2);
                        }
                        if (sePattern == 3)
                        {
                            //E
                            se.PlayOneShot(sound3);
                        }
                    }
                }
            }
        }
       
    }
    void Update()
    {
       
    }

    public void OnClic()
    {
      
    }
   
}
