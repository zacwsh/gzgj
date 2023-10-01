using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class UIManager : MonoBehaviour
{

    public TextMeshProUGUI waveText;
    private int waveNumber;
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


    public void QuitGame()
    {
        Application.Quit();
    }


    public void UpdateWave(int waveToAdd)
    {
        waveNumber += waveToAdd;
        waveText.text = "Wave: " + waveToAdd;
    }

    public void StartGame()
    {
        waveNumber = 1;
        UpdateWave(0);
    }
}
