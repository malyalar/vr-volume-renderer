using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateLeft : MonoBehaviour {

   

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void RotateLeft()
    {
        transform.Rotate(0, 30, 0, Space.World);
       
    }

    public void RotateRight()
    {
        transform.Rotate(0, -30, 0, Space.World);
    }

    public void RotateUp()
    {
        transform.Rotate(30, 0, 0, Space.World);
    }

    public void RotateDown()
    {
        transform.Rotate(-30, 0, 0, Space.World);
    }

}
