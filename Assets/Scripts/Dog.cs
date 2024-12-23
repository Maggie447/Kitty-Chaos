using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody dogRb;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        dogRb = GetComponent<Rigidbody>();
        player = GameObject.Find("cat");
    }

    // Update is called once per frame
    void Update()
    {
        // Dog chases cat
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        dogRb.AddForce(lookDirection * speed);
    }
}
