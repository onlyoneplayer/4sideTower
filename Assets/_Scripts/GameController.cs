using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject wall;
    public MovingWall component;
    public float speed = 3f;
    private float speedTreshold = 0.2f;

    private void Awake()
    {
        component = wall.GetComponent<MovingWall>();
        InvokeRepeating("IncreaseSpeed", 5f, 3f);
    }

    private void Update()
    {
        component.speed = speed;
    }

    private void IncreaseSpeed()
    {
        speed += speedTreshold;                            
    }
}
