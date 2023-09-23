using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;

    private Vector3 moveDir;

    void Start()
    {
        InputManager.Init(this);
        InputManager.GameMode();
    }

    void Update()
    {
        transform.position +=  speed * Time.deltaTime * moveDir;
    }

    public void SetMoveDirection(Vector3 newDirection)
    {
        moveDir = newDirection;
    }
}
