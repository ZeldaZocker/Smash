using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_boundary : MonoBehaviour {
    
    public int deaths;


    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.position = new Vector3(0, 8.8f, -8.6f);
            other.GetComponent<jump>().grounded = true;
            other.GetComponent<jump>().doubleJump = true;
            deaths++;
            //Destroy(other.gameObject);
            Debug.Log("Im back and refreshed!");
        }

        if (other.gameObject.tag == "bullet")
        {
            Debug.Log("Bullet out!");
            Destroy(other.gameObject);
        }

    }

    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 100, 25), "Deaths: " + deaths.ToString());
    }

}
