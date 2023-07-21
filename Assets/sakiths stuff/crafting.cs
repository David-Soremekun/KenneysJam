using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crafting : MonoBehaviour
{
    public bool selected; //see if this is currently selected craft
    public string item;

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
            selected = true;
        }
    }
}
