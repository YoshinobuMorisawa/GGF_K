using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrainPattern : MonoBehaviour
{
    public enum BrainType
    {
        A,
        B,
        C,
        D,
    }

    BrainType brainType = BrainType.A;

    public Text Brain;
    public int battery = 100;
    public int line = 100;
    public int brainAns;
    public int serialCode;
    public bool isTrue;


    // Start is called before the first frame update
    public void Start()
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
                if (line > 30)
                {
                    if (brainType == BrainType.A)
                    {
                        brainAns = 'A';
                    }
                    if (brainType == BrainType.B && brainType == BrainType.C)
                    {
                        brainAns = 'B';
                    }
                    else
                    {
                        brainAns = 'C';
                    }
                }
                if (line <= 30)
                {
                    if (brainType == BrainType.A)
                    {
                        brainAns = 'G';
                    }
                    if (brainType == BrainType.B && brainType == BrainType.C)
                    {
                        brainAns = 'B';
                    }
                    else
                    {
                        brainAns = 'A';
                    }
                }
            }

            //battery <= 50
            if (battery <= 50)
            {
                if (line > 30)
                {
                    if (brainType == BrainType.B && brainType == BrainType.C)
                    {
                        brainAns = 'B';
                    }
                    else
                    {
                        brainAns = 'C';
                    }
                }
                if (line <= 30)
                {
                    if (brainType == BrainType.A)
                    {
                        brainAns = 'C';
                    }
                    if (brainType == BrainType.B && brainType == BrainType.D)
                    {
                        brainAns = 'F';
                    }
                    if (brainType == BrainType.A && brainType == BrainType.D)
                    {
                        brainAns = 'E';
                    }
                    else
                    {
                        brainAns = 'A';
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
                    if (brainType == BrainType.C)
                    {
                        brainAns = 'C';
                    }
                    else
                    {
                        brainAns = 'F';
                    }
                }
                if (line <= 80)
                {
                    if (brainType == BrainType.B && brainType == BrainType.C)
                    {
                        brainAns = 'D';
                    }
                    if (brainType == BrainType.B || brainType == BrainType.D)
                    {
                        brainAns = 'G';
                    }
                    else
                    {
                        brainAns = 'B';
                    }
                }
            }
            if (battery <= 20)
            {
                if (line > 80)
                {
                    if (brainType == BrainType.A)
                    {
                        brainAns = 'C';
                    }
                    if (brainType == BrainType.D)
                    {
                        brainAns = 'F';
                    }
                    else
                    {
                        brainAns = 'E';
                    }
                }

                if (line <= 80)
                {
                    if (brainType == BrainType.A)
                    {
                        brainAns = 'C';
                    }
                    if (brainType == BrainType.D)
                    {
                        brainAns = 'B';
                    }
                    if (brainType == BrainType.B && brainType == BrainType.D)
                    {
                        brainAns = 'F';
                    }
                    if (brainType == BrainType.A && brainType == BrainType.D)
                    {
                        brainAns = 'E';
                    }
                    else
                    {
                        brainAns = 'A';
                    }
                }
            }
        }
    }
}
