using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class craftUi : MonoBehaviour
{
    public bool SetFordelete = false;
    public GameObject owner;
    public GameObject player;
    public float range;
    // Update is called once per frame
    void Update()
    {
        if (SetFordelete)
        {
            Destroy(gameObject);
        }
        else
        {
            //gameObject.GetComponent<RectTransform>().position.Equals(new Vector3(player.transform.position.x + range,player.transform.position.y + range,player.transform.position.z));
            //gameObject.GetComponent<RectTransform>().position.Set(player.transform.position.x + range, player.transform.position.y + range, player.transform.position.z);

        }
        
    }
    public void setOwner(GameObject o, GameObject p, float r)
    {
        owner = o;
        player = p;
        range = r;
    }
    public void pressed()
    {
        Debug.Log("pressed");
    }
}
