﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Zachowanie paletek, ich prędkość i reakcja na kolziję z piłką. 
/// </summary>
public class PINK : MonoBehaviour
{
    public float s = 25;
    public int ponits=0;
    private int points;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * s;
    }

    float Hitpink(Vector2 pinkLoc, Vector2 pinkPos,float racketHeight)
    {
        return (pinkLoc.y - pinkPos.y) / racketHeight;
    }
    void OnCollisionEnter2D2(Collision2D box) {
        if (box.gameObject.name == "Player" || box.gameObject.name == "PlayerLEFT") {
            points++;
        }
        System.Console.WriteLine(ponits);
    }


    void OnCollisionEnter2D(Collision2D box)
    {
        if (box.gameObject.name == "Player")
        {
            float y = Hitpink(transform.position,box.transform.position,box.collider.bounds.size.y);
            Vector2 pink2 = new Vector2(-1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = pink2 * s;
        }
        if (box.gameObject.name == "PlayerLEFT")
        {
            float y = Hitpink(transform.position, box.transform.position, box.collider.bounds.size.y);
            Vector2 pink2 = new Vector2(1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = pink2 * s;
        }

    }
}
