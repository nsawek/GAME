using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Funkcja testująca wyjsćie z gry, wyśiwetla w logach napis QUIT!
/// </summary>
public class Exit : MonoBehaviour
{

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
