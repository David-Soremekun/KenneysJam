using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private float enemySpeed;
    
    [SerializeField]
    private float rotSpeed;

    private Vector2 targetDir;

    private Rigidbody2D rb;
    private EnemyAwareness eDetection;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        eDetection = GetComponent<EnemyAwareness>();
    }
    private void SetVelocity()
    {
        if (targetDir == Vector2.zero)
        {
            rb.velocity = Vector2.zero;
        }
        else
        {
            rb.velocity = transform.up * rotSpeed;
        }
    }
    private void RotateTowards()
    {
        if(targetDir == Vector2.zero)
        {
            return;
        }
        Quaternion targetRot = Quaternion.LookRotation(transform.forward, targetDir);
        Quaternion rotation = Quaternion.RotateTowards(transform.rotation, targetRot, rotSpeed * Time.deltaTime);
    
        rb.SetRotation(rotation);

    }
    private void UpdateTargetDirection()
    {   
        if (eDetection.awareOfPlayer)
        {
            targetDir = eDetection.DirectionToPlayer;
        }
        else
        {
            targetDir = Vector2.zero;
        }
    }
    private void FixedUpdate()
    {
        UpdateTargetDirection();
        RotateTowards();
        SetVelocity();
    }

}
