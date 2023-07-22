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
    public GameObject player;
    public GameObject spwan;
    public GameObject o;

    public int WoodHave;
    public int IronHave;
    public int GoldHave;
    public int MythrilHave;
    public float buttonRage = 1;


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
        spwan.GetComponent<craftUi>().setOwner(gameObject);
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
        o = Instantiate(spwan, new Vector3(collision.transform.position.x + buttonRage, collision.transform.position.y + buttonRage, collision.transform.position.z), collision.transform.rotation,gameObject.GetComponentInParent<Canvas>().GetComponent<RectTransform>().transform);
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        selected = false;
        o.GetComponent<craftUi>().SetFordelete = true;
    }
}
