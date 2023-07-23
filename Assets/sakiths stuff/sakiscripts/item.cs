using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public Sprite sprite;
    public float speed = 1;
    public float timecheck = 1;
    private float t = 0;
    private bool up = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if ( t > timecheck)
        {
            if (up)
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.up * speed;
            }
            else
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.down * speed;
            }
            up = !up;
            t = 0;
        }
       
    }
}
