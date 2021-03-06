﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//====定数宣言====//
public static class Constants
{

}

public class Director
{
    //=====シングルトン=====//
    //共有インスタンス
    private static Director director;

    //共有インスタンスの取得
    public static Director Instance
    {
        get
        {
            if (director == null)
            {
                director = new Director();
            }

            return director;
        }
    }
    //=======================//

    public void VisibleCursor(bool flag)
    {
        Cursor.visible = flag;

        if (flag)
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }


    //ゲームの終了
    public void QuitGame()
    {
        #if UNITY_EDITOR            //エディターからの起動時
            EditorApplication.isPlaying = false;

        #elif UNITY_STANDALONE      //アプリケーションからの起動時
            Application.Quit();
        #endif
    }
}

public class GameInstance
{
    //=======シングルトン=======//
    //共有インスタンス
    private static GameInstance gameInstance;    

    //コンストラクタ
    private GameInstance()
    {
        getPoints = 0;
    }

    //共有インスタンスの取得
    public static GameInstance Instance
    {
        get
        {
            if(gameInstance == null) 
            {
                gameInstance = new GameInstance();
            }

            return gameInstance;
        }
    }
    //===========================//

    //獲得したポイント
    public int getPoint;

    //ゲームインスタンスの初期化
    public void Init_GameInstance() 
    {
        getPoint = 0;
    }
}