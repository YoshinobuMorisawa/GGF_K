using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CardManager : MonoBehaviour
{   
    [System.Serializable]
    public class Tuple{
        public string str1;
        public int valueMin;
        public int valueMax;
        public string str2;
    }
    
    [SerializeField]
    public List<Tuple> tuples = new List<Tuple>();
    Text ownText;

    private void Start() {
        ownText = gameObject.GetComponent<Text>();
        string text = "";
        text += "シリアルコード : ";
        text += (Random.Range(0, (int)(1e8-1)).ToString("00000000"));
        text += "\n";
        
        foreach(Tuple x in tuples){
            text += x.str1 + " ";
            text += Random.Range(x.valueMin, x.valueMax);
            text += " " + x.str2;
            text += "\n";
        }
        ownText.text = text;
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
