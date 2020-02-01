using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StomachPattern : MonoBehaviour
{
    public enum StomachType
    {
        a, //33% 未満
        b, //33% 以上 66% 未満
        c, //66% 以上
    }

    StomachType stomachType = StomachType.a;

    public int Stomachans;
    public int battery = 100;
    public int line = 100;
    public bool isTrue;
    public int stomachPercent = 100;
    public int serialCode;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Awake()
    {
        if (serialCode > 50)
        {
            isTrue = true;
        }
        if (serialCode <= 50)
        {
            isTrue = false;
        }

        //新型
        if (serialCode > 50)
        {
            if (battery > 50)
            {
                if (line >30)
                {
                    if (stomachType == StomachType.c)
                    {
                        Stomachans = 'D';
                    }
                    if (stomachType == StomachType.b)
                    {
                        Stomachans = 'E';
                    }
                    if (stomachType == StomachType.a)
                    {
                        Stomachans = 'F';
                    }
                }
                if (line <= 30)
                {
                    if (stomachType == StomachType.c)
                    {
                        Stomachans = 'A';
                    }
                    if (stomachType == StomachType.b)
                    {
                        Stomachans = 'B';
                    }
                    if (stomachType == StomachType.a)
                    {
                        Stomachans = 'C';
                    }
                }
            }
            if (battery <= 50)
            {
                if (line > 30)
                {
                    if (stomachType == StomachType.c)
                    {
                        Stomachans = 'A';
                    }
                    if (stomachType == StomachType.b)
                    {
                        Stomachans = 'B';
                    }
                    if (stomachType == StomachType.a)
                    {
                        Stomachans = 'C';
                    }
                }
                if (line <= 30)
                {
                    if (stomachType == StomachType.c)
                    {
                        Stomachans = 'D';
                    }
                    if (stomachType == StomachType.b)
                    {
                        Stomachans = 'E';
                    }
                    if (stomachType == StomachType.a)
                    {
                        Stomachans = 'F';
                    }
                }
            }
        }
        //旧型
        if (serialCode <= 50)
        {
            if (battery > 20)
            {
                if (line > 80)
                {
                    if (stomachType == StomachType.c)
                    {
                        Stomachans = 'G';
                    }
                    if (stomachType == StomachType.b)
                    {
                        Stomachans = 'F';
                    }
                    if (stomachType == StomachType.a)
                    {
                        Stomachans = 'E';
                    }
                }
                if (line <= 80)
                {
                    if (stomachType == StomachType.c)
                    {
                        Stomachans = 'E';
                    }
                    if (stomachType == StomachType.b)
                    {
                        Stomachans = 'C';
                    }
                    if (stomachType == StomachType.a)
                    {
                        Stomachans = 'A';
                    }
                }
            }
            if (battery <= 20)
            {
                if (line > 80)
                {
                    if (stomachType == StomachType.c)
                    {
                        Stomachans = 'C';
                    }
                    if (stomachType == StomachType.b)
                    {
                        Stomachans = 'G';
                    }
                    if (stomachType == StomachType.a)
                    {
                        Stomachans = 'E';
                    }
                }
                if (line <= 80)
                {
                    if (stomachType == StomachType.c)
                    {
                        Stomachans = 'B';
                    }
                    if (stomachType == StomachType.b)
                    {
                        Stomachans = 'D';
                    }
                    if (stomachType == StomachType.a)
                    {
                        Stomachans = 'A';
                    }
                }
            }
        }
    }
}
