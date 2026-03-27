using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pllayershoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform shootPos;
    void Start()
    {

    }

    public void Shoot(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            GameObject bulletPrefab = Instantiate(bullet, shootPos.position, shootPos.rotation);
            Destroy(bulletPrefab, 1);
        }

    }
}
