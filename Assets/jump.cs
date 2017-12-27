using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

    public bool grounded;
    public bool doubleJump;
    public float jumpheight;


    void Start()
    {
        grounded = true;
        doubleJump = true;
    }

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpheight != 0)
            {
                Jump();
            }
            if (jumpheight == 0)
            {
                jumpheight = 2;
                Jump();
            }
        }
    }



    void Jump()
    {
        if (grounded)
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * 20 * jumpheight);
            grounded = false;
        }
        else if (doubleJump)
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * 20 * jumpheight);
            doubleJump = false;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ground")
        {
            grounded = true;
            doubleJump = true;
        }
    }


}
