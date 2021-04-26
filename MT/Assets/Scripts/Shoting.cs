using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoting : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePoint;
    public Transform gun;
    public float bulletSpeed = 50;

    private Vector3 lookDirection;
    private float lookAngle;
    private Vector3 mousePos;

    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lookDirection = (mousePos - transform.position).normalized;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        gun.eulerAngles = new Vector3(0, 0, lookAngle);
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletClone = Instantiate(bullet, firePoint.position, firePoint.rotation);
            bulletClone.GetComponent<Rigidbody2D>().AddForce(firePoint.right * bulletSpeed, ForceMode2D.Impulse);
        }
       
    }
}
