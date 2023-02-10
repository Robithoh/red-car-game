using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    CarScript carScript;

    // Start is called before the first frame update
    void Start()
    {
        carScript = GameObject.FindObjectOfType<CarScript>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Car"){
            // kill the player
            carScript.Die();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
