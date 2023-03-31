using ClasesRegulares.Clase5;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    [SerializeField] private KeyCode shootKeyCode = KeyCode.Space;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    private void Update()
    {
        if (Input.GetKeyDown(shootKeyCode))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bulletScript = bullet.GetComponent<Bullet>();
        Debug.Log("Shoot");
    }
}