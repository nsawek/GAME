using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class COINS : MonoBehaviour
{
    /// <summary>
    /// funckja dodaje nam punkty gdy piłka przejdzie przez niewidzialne objekty przy paletkach, jak i odejmuje gdy jej nie dobijemy, dodatkowo wyświetla ekran śmierci gdy mamy mniej niż 0 punktów. 
    /// </summary>
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