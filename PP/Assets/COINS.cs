using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COINS : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
            FindObjectOfType<POINTS>().Score += 1;
        if (other.gameObject.tag == "ONE")
            FindObjectOfType<POINTS>().Score -= 1;
    }
}
