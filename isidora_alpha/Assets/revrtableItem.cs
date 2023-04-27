using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revrtableItem : MonoBehaviour
{

    List<Vector3> positions;
    List<Quaternion> rotations;

    void Start() {
        positions = new List<Vector3>();
        rotations = new List<Quaternion> ();
    }


    // Update is called once per frame
    void Update()
    {
        
        
        if(Input.GetButton("Fire2")){
            startRewind();
        }
        else{
            positions.Add(gameObject.GetComponent<Rigidbody>().position);
            rotations.Add(gameObject.GetComponent<Rigidbody>().rotation);
        }
    }



    void startRewind(){
        // for(int i=0;i<10;i++){
        //     Debug.Log(positions[positions.Count - i-1]);
        // }
        gameObject.GetComponent<Rigidbody>().position = positions[positions.Count - 1];
        positions.RemoveAt(positions.Count-1);
        gameObject.GetComponent<Rigidbody>().rotation = rotations[rotations.Count - 1];
        rotations.RemoveAt(rotations.Count-1);
    }
}
