using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoneButton : MonoBehaviour
{
    [SerializeField]
    private GameObject scrollView;
    Slides slides;

    private void Start() {
        slides = scrollView.GetComponent<Slides>();
    }


    public void OnClicked(){
        int[] cnt = slides.TypeCount(); // A, B, C... Gをそれぞれいくつ入ってるか格納する。
    }
}
