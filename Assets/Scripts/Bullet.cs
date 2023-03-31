using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializedField] private class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 direction;
    [SerializeField] private int damage;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = direction.normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
