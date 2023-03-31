using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float speed = 0.8f;
    [SerializeField] private Vector3 direction = new Vector3(1f, 0f, 0f);
    [SerializeField] private float healthPoints = 100;

    void Start()
    {
        Damage(50);
        Heal(25);
    }

    void Update()
    {
        Move();
    }

    void Heal(float quantity)
    {
        healthPoints += quantity;
        Debug.Log("The player has been healed. Actual health: " + healthPoints);
    }

    void Damage(float quantity)
    {
        healthPoints -= quantity;
        Debug.Log("The player has been damaged. Actual health: " + healthPoints);
    }

    void Move()
    {
        transform.position += direction * speed * Time.deltaTime;
        Debug.Log("The player has moved. Actual Position: " + transform.position);
    }
}
