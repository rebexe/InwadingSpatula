using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
    public float speed = 0f;

	// Use this for initialization
	void Start () {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
    }
	
	// Update is called once per frame
	void Update () {
    
        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }

    }





}
