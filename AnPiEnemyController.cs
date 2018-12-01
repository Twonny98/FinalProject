using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnPiEnemyController : MonoBehaviour {

    private Rigidbody rb;
    public float enemySpeed;

    public AnPiPlayerController thePlayer;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<AnPiPlayerController>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(thePlayer.transform.position);
    }

    private void FixedUpdate()
    {
        rb.velocity = (transform.forward * enemySpeed);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }
}
