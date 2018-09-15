using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoyDetection : MonoBehaviour
{

    public BoxCollider Platfrom;

    private void Update()
    {

    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("im exiting collison");
        Platfrom.isTrigger = false;
    }
}
