using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class COINS : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
            FindObjectOfType<POINTS>().Score += 1;
        if (other.gameObject.tag == "ONE")
            FindObjectOfType<POINTS>().Score -= 1;
        if (FindObjectOfType<POINTS>().Score < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}