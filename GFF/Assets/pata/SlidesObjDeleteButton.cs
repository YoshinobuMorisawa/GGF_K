using UnityEngine;

public class SlidesObjDeleteButton : MonoBehaviour {
    [SerializeField]
    private GameObject scrollView;
    Slides slides;

    private void Start() {
        slides = scrollView.GetComponent<Slides>();
    }
    public void onClicked(){
        slides.Delete();
    }
}