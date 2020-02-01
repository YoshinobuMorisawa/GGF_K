using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    private GameObject adder;
    Slides slides;
    private void Start() {
        slides = adder.GetComponent<Slides>();
    }
    public void OnClicked(){
        slides.Add(gameObject);
    }

}
