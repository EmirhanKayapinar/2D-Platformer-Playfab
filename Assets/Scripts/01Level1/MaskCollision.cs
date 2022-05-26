using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaskCollision : MonoBehaviour
{
    [SerializeField] GameObject _gameOverPanel;
    [SerializeField] Text _scoreTextFinal;
    [SerializeField] GameObject _score,_highScore;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _scoreTextFinal.text = $"Skorunuz : {_score.GetComponent<Score>()._scores.ToString()}";
            _gameOverPanel.SetActive(true);
            Time.timeScale = 0;
            _highScore.GetComponent<HighScore>().SetHighScore();
        }
    }
}
