using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private TextMeshProUGUI _scoreLabel;

  
    // Start is called before the first frame update
    void Start()
    {
        _scoreLabel = GameObject.FindWithTag("Score").GetComponent<TextMeshProUGUI>();
        if (PlayerPrefs.GetString("Score") != "")
        {
            _scoreLabel.text = PlayerPrefs.GetString("Score");
        }
        
    }

 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
             int score = int.Parse(_scoreLabel.text);
             score++;
            _scoreLabel.text = score.ToString();
        }
    }
}
