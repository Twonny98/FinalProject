using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnPiEnemyHealth : MonoBehaviour {

    public int health;
    private int currentHealth;
    public Text text;

	// Use this for initialization
	void Start ()
    {
        currentHealth = health;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (currentHealth <= 0)
        {
            text.text = "E N E M Y  D E F E A T E D";
            Destroy(gameObject);
        }
	}

    public void HurtEnemy(int damage)
    {
        currentHealth -= damage;
    }
}
