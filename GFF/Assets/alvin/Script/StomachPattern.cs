using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StomachPattern : MonoBehaviour
{
    public enum StomachType
    {
        a, //33% 未満
        b, //33% 以上 66% 未満
        c, //66% 以上
    }

    StomachType stomachType = StomachType.a;

    public int stomachPercent;
    private Image myImage;

    // Start is called before the first frame update
    void Start()
    {
        myImage = GameObject.Find("imgStomachFront").GetComponentInChildren<Image>();
    }

    // Update is called once per frame
    public void Awake()
    {
       

    }

    public void init(GameManager GM)
    {
        stomachPercent = Random.Range(0, 101);
        myImage.fillAmount = (float)stomachPercent / 100f;
        if (stomachPercent >= 66)
        {
            stomachType = StomachType.c;
        }
        else if (stomachPercent >= 33 && stomachPercent < 66)
        {
            stomachType = StomachType.b;
        }
        else if (stomachPercent <= 33)
        {
            stomachType = StomachType.a;
        }


        //新型
        if (GM.isNew)
        {
            if (GM.battery > 50)
            {
                if (GM.line > 30)
                {
                    if (stomachType == StomachType.c)
                    {
                        GM.Answer[3] = 3;
                    }
                    if (stomachType == StomachType.b)
                    {
                        GM.Answer[3] = 4;
                    }
                    if (stomachType == StomachType.a)
                    {
                        GM.Answer[3] = 5;
                    }
                }
                if (GM.line <= 30)
                {
                    if (stomachType == StomachType.c)
                    {
                        GM.Answer[3] = 0;
                    }
                    if (stomachType == StomachType.b)
                    {
                        GM.Answer[3] = 1;
                    }
                    if (stomachType == StomachType.a)
                    {
                        GM.Answer[3] = 2;
                    }
                }
            }
            if (GM.battery <= 50)
            {
                if (GM.line > 30)
                {
                    if (stomachType == StomachType.c)
                    {
                        GM.Answer[3] = 0;
                    }
                    if (stomachType == StomachType.b)
                    {
                        GM.Answer[3] = 1;
                    }
                    if (stomachType == StomachType.a)
                    {
                        GM.Answer[3] = 2;
                    }
                }
                if (GM.line <= 30)
                {
                    if (stomachType == StomachType.c)
                    {
                        GM.Answer[3] = 3;
                    }
                    if (stomachType == StomachType.b)
                    {
                        GM.Answer[3] = 4;
                    }
                    if (stomachType == StomachType.a)
                    {
                        GM.Answer[3] = 5;
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
                    if (stomachType == StomachType.c)
                    {
                        GM.Answer[3] = 6;
                    }
                    if (stomachType == StomachType.b)
                    {
                        GM.Answer[3] = 5;
                    }
                    if (stomachType == StomachType.a)
                    {
                        GM.Answer[3] = 4;
                    }
                }
                if (GM.line <= 80)
                {
                    if (stomachType == StomachType.c)
                    {
                        GM.Answer[3] = 4;
                    }
                    if (stomachType == StomachType.b)
                    {
                        GM.Answer[3] = 2;
                    }
                    if (stomachType == StomachType.a)
                    {
                        GM.Answer[3] = 0;
                    }
                }
            }
            if (GM.battery <= 20)
            {
                if (GM.line > 80)
                {
                    if (stomachType == StomachType.c)
                    {
                        GM.Answer[3] = 2;
                    }
                    if (stomachType == StomachType.b)
                    {
                        GM.Answer[3] = 6;
                    }
                    if (stomachType == StomachType.a)
                    {
                        GM.Answer[3] = 4;
                    }
                }
                if (GM.line <= 80)
                {
                    if (stomachType == StomachType.c)
                    {
                        GM.Answer[3] = 1;
                    }
                    if (stomachType == StomachType.b)
                    {
                        GM.Answer[3] = 3;
                    }
                    if (stomachType == StomachType.a)
                    {
                        GM.Answer[3] = 0;
                    }
                }
            }
        }
    }
}
