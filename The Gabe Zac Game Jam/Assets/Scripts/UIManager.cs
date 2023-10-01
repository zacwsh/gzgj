using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject gameOverMenu;


    private void OnEnable()
    {
        Enemy.OnPlayerDeath += EnableGameOverMenu;
    }

    private void OnDisable()
    {
        Enemy.OnPlayerDeath -= EnableGameOverMenu;
    }
    public void EnableGameOverMenu()
    {
        gameOverMenu.SetActive(true);
    }

    public void Restartlevel()
    {
        SceneManager.LoadScene(SceneManager.GetSceneByName("Main Menu").buildIndex);
    }
}
