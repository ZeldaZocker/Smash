using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_boundary : MonoBehaviour {

	void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.position = new Vector3(0, 9, -9);
            other.GetComponent<jump>().grounded = true;
            other.GetComponent<jump>().doubleJump = true;
            //Destroy(other.gameObject);
            Debug.Log("Im back and refreshed!");
        }

        if (other.gameObject.tag == "bullet")
        {
            Debug.Log("Bullet out!");
            Destroy(other.gameObject);
        }

    }
	
}
