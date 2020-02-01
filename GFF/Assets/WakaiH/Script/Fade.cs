using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    Scenes nextScene = Scenes.TITLE;

    public void StartFadeOut(Scenes _nextScene)
    {
        nextScene = _nextScene;
        GetComponent<Animator>().SetTrigger("startFadeOut");
    }

    public void FadeOut()
    {
        GetComponent<Animator>().SetBool("IsFade", true);
    }

    void CompleteFadeOut()
    {
        MoveSceneManager.ChangeScene(nextScene);
    }

    void FadeFinish()
    {
        GetComponent<Animator>().SetBool("IsFade", false);
    }
}
