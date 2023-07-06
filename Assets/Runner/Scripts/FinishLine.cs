using System;
using System.Collections;
using System.Collections.Generic;
using HyperCasual.Core;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HyperCasual.Runner
{
    /// <summary>
    /// Ends the game on collision, forcing a win state.
    /// </summary>
    [ExecuteInEditMode]
    [RequireComponent(typeof(Collider))]
    public class FinishLine : Spawnable
    {
        const string k_PlayerTag = "Player";
        private int score;

        private void Start()
        {
            
        }

        void OnTriggerEnter(Collider col)
        {
            if (col.CompareTag(k_PlayerTag))
            {
                PlayerPrefs.SetString("Score",GameObject.FindWithTag("Score").GetComponent<TextMeshProUGUI>().text);
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}