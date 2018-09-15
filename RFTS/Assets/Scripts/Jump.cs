using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    //Attaches the rigidBody of jumpBoy to the code
    public Rigidbody jump;
    //the force with which pushes jumpBoy upwards. Can be modified in the menu under the jump script.
    public int jumpForce = 400;
    //If false, jumpBoy cant jump.
    bool jumpAllow = true;
	
	
	void Update ()
    {
        LeftMouse();
	}

    //Method made in order to make jumpBoy jump when LeftMouse is pressed. Called on in the Update method. Mainly made for organization.
    void LeftMouse ()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && jumpAllow == true)
        {
            jump.AddForce(0, jumpForce, 0);
            //after the left mouse button is clicked, jumpBoy cant jump unitl he enters another collision, this way jumpBoy cannot infinitely jump.
            jumpAllow = false;
        }
    }

    //PreMade unity method in order to sense when jumpBoy Collides, and if so, it will set jumpAllow to true thus allowing jumpBoy to jump again.
    private void OnCollisionEnter(Collision collision)
    {
        jumpAllow = true;
    }
}
