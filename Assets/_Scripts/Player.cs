using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bulletPrefab;
    public UIController uiController;

    private void Update()
    {
        LookAtMouse();
        Shoot();
    }

    public void Shoot()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }

    public void LookAtMouse()
    {
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            PlayerDeath();
        }
    }

    public void PlayerDeath()
    {
        Destroy(gameObject);
        Time.timeScale = 0;
        uiController.ShowFinalScreen();
    }

}
