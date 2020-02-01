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
    
void Start()
    {
        se = GetComponent<AudioSource>();
    }

    void Update()
    {
       
    }

    public void OnClic()
    {
        switch (sePattern)
        {
            case 1:
                se.PlayOneShot(sound1);
                break;

            case 2:
                se.PlayOneShot(sound2);
                break;

            case 3:
                se.PlayOneShot(sound3);
                break;

            default:
                break;
        }
    }

    public void init(GameManager GM)
    {
        sePattern = Random.Range(1, 4);
        if (GM.isNew)
        {
            if (GM.battery >= 50)//バッテリー
            {
                if (GM.line >= 30)//回線強度
                {
                    if (sePattern == 1)
                    {
                        //A
                        GM.Answer[1] = 0;
                    }
                    if (sePattern == 2)
                    {
                        //B
                        GM.Answer[1] = 1;
                    }
                    if (sePattern == 3)
                    {
                        //D
                        GM.Answer[1] = 3;
                    }
                }
                if (GM.line < 30)//回線強度
                {
                    if (sePattern == 1)
                    {
                        //E
                        GM.Answer[1] = 4;
                    }
                    if (sePattern == 2)
                    {
                        //B
                        GM.Answer[1] = 1;
                    }
                    if (sePattern == 3)
                    {
                        //D
                        GM.Answer[1] = 3;
                    }
                }
            }
            if (GM.battery < 50)//バッテリー
            {
                if (GM.line >= 30)//回線強度
                {
                    if (sePattern == 1)
                    {
                        //A
                        GM.Answer[1] = 0;
                    }
                    if (sePattern == 2)
                    {
                        //B
                        GM.Answer[1] = 1;
                    }
                    if (sePattern == 3)
                    {
                        //E
                        GM.Answer[1] = 4;
                    }
                }
                if (GM.line < 30)//回線強度
                {
                    if (sePattern == 1)
                    {
                        //E
                        GM.Answer[1] = 4;
                    }
                    if (sePattern == 2)
                    {
                        //F
                        GM.Answer[1] = 5;
                    }
                    if (sePattern == 3)
                    {
                        //G
                        GM.Answer[1] = 6;
                    }
                }
            }
        }
        else
        {
            if (GM.battery >= 20)//バッテリー
            {
                if (GM.line >= 80)//回線強度
                {
                    if (sePattern == 1)
                    {
                        //G
                        GM.Answer[1] = 6;
                    }
                    if (sePattern == 2)
                    {
                        //E
                        GM.Answer[1] = 4;
                    }
                    if (sePattern == 3)
                    {
                        //C
                        GM.Answer[1] = 2;
                    }
                }
                if (GM.line < 80)//回線強度
                {
                    if (sePattern == 1)
                    {
                        //E
                        GM.Answer[1] = 4;
                    }
                    if (sePattern == 2)
                    {
                        //B
                        GM.Answer[1] = 1;
                    }
                    if (sePattern == 3)
                    {
                        //D
                        GM.Answer[1] = 3;
                    }
                }
            }
            if (GM.battery >= 20)//バッテリー
            {
                if (GM.line >= 80)//回線強度
                {
                    if (sePattern == 1)
                    {
                        //A
                        GM.Answer[1] = 0;
                    }
                    if (sePattern == 2)
                    {
                        //E
                        GM.Answer[1] = 4;
                    }
                    if (sePattern == 3)
                    {
                        //F
                        GM.Answer[1] = 5;
                    }
                }
                if (GM.line < 80)//回線強度
                {
                    if (sePattern == 1)
                    {
                        //F
                        GM.Answer[1] = 5;
                    }
                    if (sePattern == 2)
                    {
                        //F
                        GM.Answer[1] = 5;
                    }
                    if (sePattern == 3)
                    {
                        //E
                        GM.Answer[1] = 4;
                    }
                }
            }
        }
    }
}
