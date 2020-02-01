using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public enum SE_TYPE { ACTION, DEAD, RUN, DAMAGE, IDLE, ENVIRONMENTAL }

    public AudioClip[] bgm;
    public AudioClip[] actionSE;
    public AudioClip[] deadSE;
    public AudioClip[] runSE;
    public AudioClip[] damageSE;
    public AudioClip[] idleSE;
    public AudioClip[] environmentalSE;

    [SerializeField]
    [Range(0, 1)]
    float bgmVolume = 1.0f;
    [SerializeField]
    [Range(0, 1)]
    float seVolume = 1.0f;

    AudioSource bgmAudioSource;
    AudioSource seAudioSource;

    void Awake()
    {
        //シーンを切り替えてもこのゲームオブジェクトを削除しないようにする
        DontDestroyOnLoad(gameObject);
        bgmAudioSource = gameObject.AddComponent<AudioSource>();
        seAudioSource = gameObject.AddComponent<AudioSource>();
    }

    //BGM再生。numに0未満を指定すると停止
    public void PlayBGM(int num)
    {
        if (num >= 0)
        {
            bgmAudioSource.clip = bgm[num];
            bgmAudioSource.loop = true;
            bgmAudioSource.volume = bgmVolume;
            bgmAudioSource.Play();
        }
        else
        {
            bgmAudioSource.Stop();
        }
    }

    //BGM停止
    public void StopBGM()
    {
        bgmAudioSource.Stop();
    }

    //SE再生
    public void PlaySE(SE_TYPE seType, int num)
    {
        switch (seType)
        {
            case SE_TYPE.ACTION:
                seAudioSource.PlayOneShot(actionSE[num], seVolume);
                break;

            case SE_TYPE.DEAD:
                seAudioSource.PlayOneShot(deadSE[num], seVolume);
                break;

            case SE_TYPE.RUN:
                seAudioSource.PlayOneShot(runSE[num], seVolume);
                break;

            case SE_TYPE.DAMAGE:
                seAudioSource.PlayOneShot(damageSE[num], seVolume);
                break;

            case SE_TYPE.IDLE:
                seAudioSource.PlayOneShot(idleSE[num], seVolume);
                break;

            case SE_TYPE.ENVIRONMENTAL:
                seAudioSource.PlayOneShot(environmentalSE[num], seVolume);
                break;
        }
    }

    //ランダムでSE再生
    public void RandomSE(SE_TYPE seType)
    {
        int num = 0;
        int randomRange = 0;

        switch (seType)
        {
            case SE_TYPE.ACTION:
                randomRange = actionSE.Length;
                num = Random.Range(0, randomRange);
                PlaySE(SE_TYPE.ACTION, num);
                break;

            case SE_TYPE.DEAD:
                randomRange = deadSE.Length;
                num = Random.Range(0, randomRange);
                PlaySE(SE_TYPE.DEAD, num);
                break;

            case SE_TYPE.DAMAGE:
                randomRange = damageSE.Length;
                num = Random.Range(0, randomRange);
                PlaySE(SE_TYPE.DAMAGE, num);
                break;

            case SE_TYPE.RUN:
                randomRange = runSE.Length;
                num = Random.Range(0, randomRange);
                PlaySE(SE_TYPE.RUN, num);
                break;

            case SE_TYPE.IDLE:
                randomRange = idleSE.Length;
                num = Random.Range(0, randomRange);
                PlaySE(SE_TYPE.IDLE, num);
                break;

            case SE_TYPE.ENVIRONMENTAL:
                randomRange = environmentalSE.Length;
                num = Random.Range(0, randomRange);
                PlaySE(SE_TYPE.ENVIRONMENTAL, num);
                break;
        }
    }
}
