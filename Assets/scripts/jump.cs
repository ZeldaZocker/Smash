using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

    public bool grounded;
    public bool doubleJump;
    public float jumpheight;
    public Rigidbody rb;

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
            rb.velocity = new Vector3(0, jumpheight, 0);
            //this.GetComponent<Rigidbody>().AddForce(Vector3.up * 20 * jumpheight);
            grounded = false;
        }
        else if (doubleJump)
        {
            rb.velocity = new Vector3(0, jumpheight, 0);
           // this.GetComponent<Rigidbody>().AddForce(Vector3.up * 20 * jumpheight);
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
