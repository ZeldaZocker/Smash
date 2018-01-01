using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_boundary : MonoBehaviour {

	void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != "bullet")
        {
            Debug.Log("Im out!");
            other.transform.position = new Vector3(0, 9, -9);
            //Destroy(other.gameObject);
        }
    }
	
}
