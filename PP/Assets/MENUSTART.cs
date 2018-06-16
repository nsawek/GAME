using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Wyświetla Start, włącza scene z grą, na bazie tego że jest to scena 1 a z grą 2 wieć GetActiveScene().buildIndex + 1 gdzie GetActiveScene to obecnie aktywna scena pierwsza w kolejności. 
/// </summary>
public class MENUSTART : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
