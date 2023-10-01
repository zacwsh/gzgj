using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static event Action OnPlayerDeath;

    [SerializeField] float moveSpeed = 12f;
    Rigidbody rb;
    Transform target;
    Vector3 moveDirection;



    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("FirstPersonController").transform;
    }

    // Update is called once per frame
    private void Update()
    {
        if(target)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            moveDirection = direction;
        }
    }

    private void FixedUpdate()
    {
        if (target)
        {
            rb.velocity = new Vector3(moveDirection.x, 0, moveDirection.z) * moveSpeed;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("You're dead");
            OnPlayerDeath?.Invoke();
        }
    }

}
