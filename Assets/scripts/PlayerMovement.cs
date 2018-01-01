using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    private Transform myTransform;
    public float speed = 15f;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;


    /*  void Start()
      {
          myTransform = GetComponent<Transform>();
          this.transform.position = new Vector2(Random.Range(-7, 7), 0);
      }*/


    void Update()
    {
        //Smooth Camera für 3D Spiele
        //Camera.main.transform.position = this.transform.position - this.transform.forward * 10 + this.transform.up * 3;
        //Camera.main.transform.LookAt(this.transform.transform.position);
        //Camera.main.transform.parent = this.transform;


        if (Input.GetMouseButtonDown(0))
            {
                Fire();
            }
            

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }



    }

        void FixedUpdate() {


        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        
        transform.Translate(x, 0, 0);
        transform.Rotate(0, 0, 0);
    }

    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.right * 10;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2.0f);
    }

    


}