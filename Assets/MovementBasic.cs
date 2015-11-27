using UnityEngine;
using System.Collections;

public class MovementBasic : MonoBehaviour {


    public GameObject bullet; 
    float speed = 6f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
            print("Left arrow was pressed");
        }
        else if (Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            print("Right arrow was pressed");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);


        }

    }
}
