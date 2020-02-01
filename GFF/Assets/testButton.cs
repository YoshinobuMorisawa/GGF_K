using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testButton : MonoBehaviour
{
    public void onClicked(){
        QuickRanking.Instance.SaveRanking("hoge", Random.Range(0, 1000));
    }
}
