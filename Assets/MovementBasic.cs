using UnityEngine;
using System.Collections;

public class MovementBasic : MonoBehaviour {


    public GameObject bullet; 
    float speed = 6f;
    public float fireRate = 0;

    float timeToFire = 0;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (fireRate == 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Shoot();
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.Space) && Time.time > timeToFire)
            {
                timeToFire = Time.time + 1 / fireRate;
                Shoot();
            }
        }





        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
            print("Left arrow was pressed");
        }
        else if (Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            print("Right arrow was pressed");
        }


    }

    void Shoot()
    {
            Instantiate(bullet, transform.position, Quaternion.identity);
    }

}
