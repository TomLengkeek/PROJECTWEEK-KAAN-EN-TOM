﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    UiText text;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("scoredisplay").GetComponent<UiText>();
    }

    // Update is called once per frame  
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) //als de speler in de hitbox van de mol komt --> verwijder 
    {
        Destroy(gameObject);
        text.score++;
    }
}
