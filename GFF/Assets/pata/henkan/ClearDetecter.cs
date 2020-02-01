using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainTypeExchanger : MonoBehaviour
{
    int[] Run(int[] cnt){
        int[] res = new int[7];
        for(int i=0; i<4; i++){
            res[cnt[i]]++;
        }
        return res;
    }

    public bool CompareAnswer(int[] a, int[] b){
        for(int i=0; i<a.GetLength(0); i++){
            if(a[i] != b[i]) return false;
        }
        return true;
    }   
}
