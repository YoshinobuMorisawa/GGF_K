using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrainPattern : MonoBehaviour
{
    //public enum BrainType
    //{
    //    A,
    //    B,
    //    C,
    //    D,
    //}

    //BrainType brainType = BrainType.A;

    public bool[] isSaid;

    private Image imgKigou1;
    private Image imgKigou2;
    private Image imgKigou3;
    private Image imgKigou4;

    // Start is called before the first frame update
    public void Start()
    {
        imgKigou1 = GameObject.Find("imgKogou1").GetComponent<Image>();
        imgKigou2 = GameObject.Find("imgKogou2").GetComponent<Image>();
        imgKigou3 = GameObject.Find("imgKogou3").GetComponent<Image>();
        imgKigou4 = GameObject.Find("imgKogou4").GetComponent<Image>();
    }

    // Update is called once per frame
    public void Awake()
    {

    }

    public void init(GameManager GM)
    {
        for (int i = 0; i < isSaid.Length; i++)
        {
            if (Random.Range(0, 2) == 0)
            {
                isSaid[i] = true;
            }
            else
            {
                isSaid[i] = false;
            }
        }
        if (isSaid[0])
        {
            imgKigou1.enabled = true;
        }
        else
        {
            imgKigou1.enabled = false;
        }
        if (isSaid[1])
        {
            imgKigou2.enabled = true;
        }
        else
        {
            imgKigou2.enabled = false;
        }
        if (isSaid[2])
        {
            imgKigou3.enabled = true;
        }
        else
        {
            imgKigou3.enabled = false;
        }
        if (isSaid[3])
        {
            imgKigou4.enabled = true;
        }
        else
        {
            imgKigou4.enabled = false;
        }

        //新型
        if (GM.isNew)
        {
            if (GM.battery > 50)
            {
                if (GM.line > 30)
                {
                    if (isSaid[0] && !isSaid[1] && !isSaid[2] && !isSaid[3])
                    {
                        GM.Answer[0] = 0;
                    }
                    if (!isSaid[0] && isSaid[1] && isSaid[2] && !isSaid[3])
                    {
                        GM.Answer[0] = 1;
                    }
                    else
                    {
                        GM.Answer[0] = 2;
                    }
                }
                if (GM.line <= 30)
                {
                    if (isSaid[0] && !isSaid[1] && !isSaid[2] && !isSaid[3])
                    {
                        GM.Answer[0] = 6;
                    }
                    if (!isSaid[0] && isSaid[1] && isSaid[2] && !isSaid[3])
                    {
                        GM.Answer[0] = 1;
                    }
                    else
                    {
                        GM.Answer[0] = 0;
                    }
                }
            }

            //GM.battery <= 50
            if (GM.battery <= 50)
            {
                if (GM.line > 30)
                {
                    if (!isSaid[0] && isSaid[1] && isSaid[2] && !isSaid[3])
                    {
                        GM.Answer[0] = 1;
                    }
                    else
                    {
                        GM.Answer[0] = 2;
                    }
                }
                if (GM.line <= 30)
                {
                    if (isSaid[0] && !isSaid[1] && !isSaid[2] && !isSaid[3])
                    {
                        GM.Answer[0] = 2;
                    }
                    if (!isSaid[0] && isSaid[1] && !isSaid[2] && isSaid[3])
                    {
                        GM.Answer[0] = 5;
                    }
                    if (isSaid[0] && !isSaid[1] && !isSaid[2] && isSaid[3])
                    {
                        GM.Answer[0] = 4;
                    }
                    else
                    {
                        GM.Answer[0] = 0;
                    }
                }
            }
        }

        //旧型
        if (!GM.isNew)
        {
            if (GM.battery > 20)
            {
                if (GM.line > 80)
                {
                    if (!isSaid[0] && !isSaid[1] && isSaid[2] && !isSaid[3])
                    {
                        GM.Answer[0] = 2;
                    }
                    else
                    {
                        GM.Answer[0] = 5;
                    }
                }
                if (GM.line <= 80)
                {
                    if (!isSaid[0] && isSaid[1] && isSaid[2] && !isSaid[3])
                    {
                        GM.Answer[0] = 3;
                    }
                    if (!isSaid[0] && isSaid[1] && !isSaid[2] && isSaid[3])
                    {
                        GM.Answer[0] = 6;
                    }
                    else
                    {
                        GM.Answer[0] = 1;
                    }
                }
            }
            if (GM.battery <= 20)
            {
                if (GM.line > 80)
                {
                    if (isSaid[0] && !isSaid[1] && !isSaid[2] && !isSaid[3])
                    {
                        GM.Answer[0] = 2;
                    }
                    if (!isSaid[0] && !isSaid[1] && !isSaid[2] && isSaid[3])
                    {
                        GM.Answer[0] = 5;
                    }
                    else
                    {
                        GM.Answer[0] = 4;
                    }
                }

                if (GM.line <= 80)
                {
                    if (isSaid[0] && !isSaid[1] && !isSaid[2] && !isSaid[3])
                    {
                        GM.Answer[0] = 2;
                    }
                    if (!isSaid[0] && isSaid[1] && !isSaid[2] && !isSaid[3])
                    {
                        GM.Answer[0] = 1;
                    }
                    if (!isSaid[0] && isSaid[1] && !isSaid[2] && isSaid[3])
                    {
                        GM.Answer[0] = 5;
                    }
                    if (isSaid[0] && !isSaid[1] && !isSaid[2] && isSaid[3])
                    {
                        GM.Answer[0] = 4;
                    }
                    else
                    {
                        GM.Answer[0] = 0;
                    }
                }
            }
        }
    }
}
