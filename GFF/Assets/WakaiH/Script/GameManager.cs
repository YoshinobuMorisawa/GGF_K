using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("変数")]
    [Header("0:頭 1:口 2:心臓 3:胃")]
    //正解
    public int[] Answer;
    //解答
    public int[] PlayerAnswer;
    [Header("新型ならtrue")]
    //新旧
    public bool isNew;
    public int battery;
    public int line;

    //時間

    // Start is called before the first frame update
    void Start()
    {
        init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void init()
    {
        for (int i = 0; i < Answer.Length; i++)
        {
            Answer[i] = 0;
            PlayerAnswer[i] = 0;
        }
        isNew = true;
        battery = 0;
        line = 0;
    }
}
