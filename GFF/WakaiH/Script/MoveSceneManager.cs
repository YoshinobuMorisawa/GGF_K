using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Scenes
{
    TITLE,
    MAIN,
    RANKING,
    EXIT
}

public class MoveSceneManager : SingletonMonoBehaviour<MoveSceneManager>
{   
    //Singletonパターンのための処理
    public void Awake()
    {
        //Singletonパターンのための処理
        if (this != Instance)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        Application.targetFrameRate = 60;

        Director.Instance.VisibleCursor(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ChangeScene(Scenes.EXIT);
        }    
    }

    public static void ChangeScene(Scenes scenes)
    {
        switch (scenes)
        {
            case Scenes.TITLE:
                SceneManager.LoadScene("Title");
                break;
            
            case Scenes.MAIN:
                SceneManager.LoadScene("Main");
                break;
           
            case Scenes.RANKING:
                SceneManager.LoadScene("Ranking");
                break;

            case Scenes.EXIT:
                Director.Instance.QuitGame();
                break;
        }
    }
}
