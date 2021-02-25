using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GUI = UnityEngine.GUI;

/// <summary>
/// Scripts related to controlling the flow of the game
/// Not implemented anywhere now but will be implemented in future iterations
/// </summary>
public class GameController : MonoBehaviour
{
    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 30), "Start"))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
