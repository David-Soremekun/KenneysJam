using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class craftUi : MonoBehaviour
{
    public bool SetFordelete = false;
    public GameObject owner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SetFordelete)
        {
            Destroy(gameObject);
        }
    }
    public void setOwner(GameObject o)
    {
        owner = o;
    }
}
