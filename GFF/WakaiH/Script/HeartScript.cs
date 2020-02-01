using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{
    [Header("ゲームオブジェクト")]
    //private GameManager GM;

    [Header("イメージ")]
    private Animator img;

    [Header("変数")]
    private int imgpattern;
    private int Signal;
    private int Answer;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void init(GameManager GM)
    {
        //GM = GameObject.Find("GameManager").GetComponent<GameManager>();

        //色設定
        imgpattern = Random.Range(0, 2);
        switch (imgpattern)
        {
            case 0:
                img = GameObject.Find("imgHeartRed").GetComponent<Animator>();
                break;

            case 1:
                img = GameObject.Find("imgHeartBlue").GetComponent<Animator>();
                break;

            default:
                break;
        }

        //点滅パターン
        Signal = Random.Range(0, 4);
        switch (Signal)
        {
            case 0:
                img.SetTrigger("Signal0");
                break;

            case 1:
                img.SetTrigger("Signal1");
                break;

            case 2:
                img.SetTrigger("Signal2");
                break;

            case 3:
                img.SetTrigger("Signal3");
                break;

            default:
                break;
        }

        //正解を判断
        if (GM.isNew)
        {
            if (GM.battery >= 50)
            {
                if (GM.line >= 30)
                {
                    switch (imgpattern)
                    {
                        case 0:
                            if (Signal == 0)
                            {
                                //A
                                GM.Answer[2] = 0;
                            }
                            else
                            {
                                //G
                                GM.Answer[2] = 6;
                            }
                            break;

                        case 1:
                            if (Signal == 1)
                            {
                                //C
                                GM.Answer[2] = 2;
                            }
                            else
                            {
                                //B
                                GM.Answer[2] = 1;
                            }
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    switch (imgpattern)
                    {
                        case 0:
                            if (Signal == 2)
                            {
                                //C
                                GM.Answer[2] = 2;
                            }
                            else
                            {
                                //A
                                GM.Answer[2] = 0;
                            }
                            break;

                        case 1:
                            if (Signal == 3)
                            {
                                //G
                                GM.Answer[2] = 6;
                            }
                            else
                            {
                                //E
                                GM.Answer[2] = 4;
                            }
                            break;

                        default:
                            break;
                    }
                }        
            }
            else
            {
                if (GM.line >= 30)
                {
                    switch (imgpattern)
                    {
                        case 0:
                            if (Signal == 0)
                            {
                                //E
                                GM.Answer[2] = 4;
                            }
                            else
                            {
                                //A
                                GM.Answer[2] = 0;
                            }
                            break;

                        case 1:
                            if (Signal == 2)
                            {
                                //D
                                GM.Answer[2] = 3;
                            }
                            else
                            {
                                //B
                                GM.Answer[2] = 1;
                            }
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    switch (imgpattern)
                    {
                        case 0:
                            if (Signal == 0)
                            {
                                //F
                                GM.Answer[2] = 5;
                            }
                            else
                            {
                                //C
                                GM.Answer[2] = 2;
                            }
                            break;

                        case 1:
                            if (Signal == 2)
                            {
                                //E
                                GM.Answer[2] = 4;
                            }
                            else
                            {
                                //B
                                GM.Answer[2] = 1;
                            }
                            break;

                        default:
                            break;
                    }
                }
            }
        }
        else
        {
            if (GM.battery >= 20)
            {
                if (GM.line >= 80)
                {
                    switch (imgpattern)
                    {
                        case 0:
                            if (Signal == 2)
                            {
                                //F
                                GM.Answer[2] = 5;
                            }
                            else
                            {
                                //B
                                GM.Answer[2] = 1;
                            }
                            break;

                        case 1:
                            if (Signal == 3)
                            {
                                //A
                                GM.Answer[2] = 0;
                            }
                            else
                            {
                                //G
                                GM.Answer[2] = 6;
                            }
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    switch (imgpattern)
                    {
                        case 0:
                            if (Signal == 2)
                            {
                                //F
                                GM.Answer[2] = 5;
                            }
                            else
                            {
                                //B
                                GM.Answer[2] = 1;
                            }
                            break;

                        case 1:
                            if (Signal == 0)
                            {
                                //B
                                GM.Answer[2] = 1;
                            }
                            else
                            {
                                //E
                                GM.Answer[2] = 4;
                            }
                            break;

                        default:
                            break;
                    }
                }
            }
            else
            {
                if (GM.line >= 80)
                {
                    switch (imgpattern)
                    {
                        case 0:
                            if (Signal == 2)
                            {
                                //D
                                GM.Answer[2] = 3;
                            }
                            else
                            {
                                //A
                                GM.Answer[2] = 0;
                            }
                            break;

                        case 1:
                            if (Signal == 2)
                            {
                                //F
                                GM.Answer[2] = 5;
                            }
                            else
                            {
                                //G
                                GM.Answer[2] = 6;
                            }
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    switch (imgpattern)
                    {
                        case 0:
                            if (Signal == 3)
                            {
                                //E
                                GM.Answer[2] = 4;
                            }
                            else
                            {
                                //B
                                GM.Answer[2] = 1;
                            }
                            break;

                        case 1:
                            if (Signal == 1)
                            {
                                //G
                                GM.Answer[2] = 6;
                            }
                            else
                            {
                                //D
                                GM.Answer[2] = 3;
                            }
                            break;

                        default:
                            break;
                    }
                }
            }
        }
    }
}
