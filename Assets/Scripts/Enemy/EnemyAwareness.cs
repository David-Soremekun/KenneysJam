using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAwareness : MonoBehaviour
{
    public bool awareOfPlayer { get; private set; }
    public Vector2 DirectionToPlayer { get; private set; }

    private Transform player;

    [SerializeField]
    private float DetectionDistance;
    private void Awake()
    {
        player = FindAnyObjectByType<PlayerMovement>().transform;
    }


    private void Update()
    {
        Vector2 enemyToPlayerVec = player.position - transform.position;
        DirectionToPlayer = enemyToPlayerVec.normalized;
        if (enemyToPlayerVec.magnitude<= DetectionDistance)
        {
            awareOfPlayer = true;
        }
        else
        {
            awareOfPlayer = false;
        }
    }
}
