using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScroller : MonoBehaviour
{
    public Transform player;
    
    public Vector3 offset;
    [SerializeField] public float dampValue;
    Vector3 velocity=Vector3.zero;

    // Happens last within the update
    private void FixedUpdate()
    {
        Vector3 movePosition = player.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, movePosition, ref velocity, dampValue);
        transform.position = new Vector3(transform.position.x, transform.position.y, -10f);
    }
}
