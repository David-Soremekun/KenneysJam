using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crafting : MonoBehaviour
{
    public bool selected; //see if this is currently selected craft
    public bool canCraft;
    public bool crafted;
    public string item;

    public BoxCollider2D col;
    public GameObject spwan;

    public int WoodHave;
    public int IronHave;
    public int GoldHave;
    public int MythrilHave;


    private int WoodNeeded;
    private int IronNeeded;
    private int GoldNeeded;
    private int MythrilNeeded;

    // Start is called before the first frame update
    void Start()
    {
        canCraft = false;
        selected = false;
        item = "Iron_sward";
        WoodNeeded = 2;
        IronNeeded = 5;
        GoldNeeded = 0;
        MythrilNeeded = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if ((WoodHave >= WoodNeeded)&&(IronHave >= IronNeeded)&&(GoldHave >= GoldNeeded)&&(MythrilHave >= MythrilNeeded))
        {
            canCraft = true;
        }
        else
        {
            canCraft = false;
        }
    }

    //collition
    private void OnTriggerEnter2D(Collider2D collision)
    {
        selected = true;
        GameObject o = Instantiate(spwan, new Vector3(transform.position.x + 1, transform.position.y + 1, transform.position.z), transform.rotation);
        
    }
    private void OnTriggerExit(Collider other)
    {
        selected = false;
    }
}
