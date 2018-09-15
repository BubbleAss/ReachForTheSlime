using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithMove : MonoBehaviour
{
    public GameObject player;
    

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionStay(Collision collision)
    {
        GameObject sticky = collision.collider.gameObject;
        player.transform.parent = sticky.transform;
    }
    private void OnCollisionExit(Collision collision)
    {
        player.transform.parent = null;
    }
}