using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

    public Transform MovePlat;
    /*bool left = true;
    bool right = false;*/
    public float platDirec = -3f;

    void Awake()
    {
        //MovePlat.transform.position = new Vector3(3.7f, MovePlat.position.y, 1f);
    }

    // Update is called once per frame
    void Update ()
    {
        Movement();
	}

    void Movement()
    {
        MovePlat.transform.position += new Vector3(platDirec * Time.deltaTime, 0, 0);
    if(MovePlat.position.x < -3.5 || MovePlat.position.x > 3.5)
        {
            platDirec *= -1;
        }
    }

    
}
