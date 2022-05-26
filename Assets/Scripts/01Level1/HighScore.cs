using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;

public class HighScore : MonoBehaviour
{
    [SerializeField] GameObject _scoreObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void SetHighScore()
    {
        PlayFabClientAPI.UpdatePlayerStatistics(new UpdatePlayerStatisticsRequest() { Statistics = new List<StatisticUpdate> { new StatisticUpdate { StatisticName = "HighScore1", Value = 100 } } }, 
            Result =>{ Debug.Log(" Score gönderimi Basarili"); },Error =>{ Debug.Log(" Score gönderimi basarisiz");});
    }
}
