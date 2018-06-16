using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Odpowiada za prędkośc poruszania się kulki, liczy wektory odbicja od obektów z którymi wchodzi w kolizję. Jak zwięszymy s piłka zwiększy prędkość.
/// </summary>
public class MovePlayer : MonoBehaviour {
    public float s = 20;
    public string test = "Vert";
    void FixedUpdate()
    {
    float vite = Input.GetAxisRaw(test);
    GetComponent<Rigidbody2D>().velocity = new Vector2(0, vite) * s;
    }
}
