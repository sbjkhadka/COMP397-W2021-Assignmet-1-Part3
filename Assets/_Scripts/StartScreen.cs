using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This scripts is used for moving between scenes
/// </summary>
public class StartScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void ShowOptions()
    {
        SceneManager.LoadScene("OptionsScreen");
    }

    public void GoToStartScreen()
    {
        SceneManager.LoadScene("Start");
    }

    public void GoToLevel2() {
        SceneManager.LoadScene("Level2");
    }
}
