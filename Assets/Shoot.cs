using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
    public int speed = 4;
    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {

    rb = gameObject.GetComponent<Rigidbody2D>();
        // rigidbody2D.velocity.y = speed;
        rb.MovePosition(rb.position * speed);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    

}
