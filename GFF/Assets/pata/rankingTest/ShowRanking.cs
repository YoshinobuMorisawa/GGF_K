using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowRanking : MonoBehaviour
{
    public Text scoreBoardText;
    public Text playerCounter;

    private void Start()
    {
        QuickRanking.Instance.FetchPlayerCount(Set2);

        QuickRanking.Instance.FetchPlayerCount(SetPlayerCounter);
    }

    void SetPlayerCounter()
    {
        playerCounter.text = "Total Player Count: "+ QuickRanking.Instance.PlayerCount.ToString();
    }

    void Set2()
    {
        gameObject.GetComponent<Text>().text = QuickRanking.Instance.GetRankingByText();
    }

    private void Update() {
         QuickRanking.Instance.FetchPlayerCount(Set2);
    }

    //Button//
    public void BackToMainGame()
    {
        //SceneManager.LoadScene("SampleGame");
    }
}
