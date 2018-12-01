using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnPiPlayerController : MonoBehaviour {

    public float speed;
    public Text text;
    public AnPiPlayerController Player;

    private Rigidbody rb;
    private Vector3 moveInput;
    private Vector3 moveVelocity;
    private Camera mainCamera;

    public AnPiShooter gun;

    private AudioSource audioSource;

	// Use this for initialization
	void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCamera = FindObjectOfType<Camera>();
        audioSource = GetComponent<AudioSource>();
	}

    private void Update()
    {
        float moveHorizontal = Input.GetAxisRaw ("Horizontal");
        float moveVertical = Input.GetAxisRaw ("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //here are the mouse controls I took out to meet the assignments requirement. Works a lot better with this still on in my opinion

        /*Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayLength;

        if (groundPlane.Raycast(cameraRay, out rayLength))
        {
            Vector3 pointToLook = cameraRay.GetPoint(rayLength);
            transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
        }*/

        if (Input.GetKeyDown("space"))
        {
            audioSource.Play();
            gun.isFiring = true;
        }

        if (Input.GetKeyUp("space"))
        {
            audioSource.Stop();
            gun.isFiring = false;
        }

        moveVelocity = movement * speed;

        if (Input.GetKey("escape"))
            Application.Quit();
    }

    private void FixedUpdate()
    {
        rb.velocity = moveVelocity;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "EnemyShot")
        {
            text.text = "Y O U  L O S E";
        }
    }

}
