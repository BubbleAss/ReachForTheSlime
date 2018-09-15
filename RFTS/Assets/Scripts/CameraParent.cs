using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraParent : MonoBehaviour
{

    public Transform cameraTrans;
    public Transform playerTrans;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        cameraTrans.position = new Vector3(cameraTrans.position.x, playerTrans.position.y + 6.34f, cameraTrans.position.z);
	}
}
