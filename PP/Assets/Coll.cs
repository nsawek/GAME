using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coll : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();
    }
}
