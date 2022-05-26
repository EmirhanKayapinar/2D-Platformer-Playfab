using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int _scores;
    [SerializeField] Text _scoreText;
    public void Scoree()
    {
        _scoreText.text = _scores.ToString();

    }

    private void FixedUpdate()
    {
        Scoree();
    }
}
