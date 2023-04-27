using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitEffect : MonoBehaviour
{


    void Update()
    {
        
    }

        void OnCollisionEnter(Collision collision)
    {

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Bullet")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");
            collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
        }
    }
}
