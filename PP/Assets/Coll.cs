using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Funckja dla wyjscia z gry w menu gry i ekranu śmierci. Używam tutaj funkcji zawartej w Unity.
/// </summary>
public class Coll : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();
    }
}
