using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;
    private Rigidbody2D enemyRB;
    private Vector2 playerPosition;
    private Vector2 lookDirection;
    private float angle;
    private GameObject playerGameObject;
    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
        playerGameObject = GameObject.FindGameObjectWithTag("Player");
    }

    
    void FixedUpdate()
    {
        playerPosition = playerGameObject.transform.position;
        enemyRB.transform.position = Vector3.MoveTowards(transform.position, playerPosition, movementSpeed * Time.fixedDeltaTime);
        lookDirection = playerPosition - enemyRB.position;
        angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        enemyRB.SetRotation(angle);
    }
}
