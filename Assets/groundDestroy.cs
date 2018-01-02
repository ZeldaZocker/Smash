using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundDestroy : MonoBehaviour {

public void OnCollisionEnter(Collision other)
    {
       if (other.gameObject.tag == "ground")
        {
            Debug.Log("Bullet ground!");
            Destroy(this.gameObject);
        }
    }
}
