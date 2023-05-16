using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    public Transform target;
    public bool isOnGround = true;
    public float initialHealth = 10.0f;
    private float currentHealth;
    public float healthBarLength;
    public PlayerMovement curHealth;


    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        healthBarLength = Screen.width / 2;
        currentHealth = initialHealth;

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        transform.position += transform.forward * speed * Time.deltaTime;
        
    }
  void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

    }

}

   
