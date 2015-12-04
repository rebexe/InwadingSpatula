using UnityEngine;
using System.Collections;

public class InvaderMovement : MonoBehaviour {

    public float speed = 0.0001f;
    public float min;
    public float max;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x + (Time.deltaTime * speed), transform.position.y, transform.position.z);
        if (transform.position.x < min)
        {
            speed *= -1;
        }

        if (transform.position.x > max)
        {
            speed *= -1;
        }
    }


}
