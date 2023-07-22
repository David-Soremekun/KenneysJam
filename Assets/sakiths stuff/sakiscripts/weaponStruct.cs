using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class weaponStruct : ScriptableObject
{
    public string weapon_name;
    public Sprite weapon_sprite;
    public bool owned = false;
    public float damage_min = 0;
    public float damage_max = 0;
    public float ranage = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (weapon_name == null)
        {
            weapon_name = "Unknown_weapon";
            Debug.Log("weapon name missing");
        }
        if (weapon_sprite == null)
        {
            Debug.Log("sprite missing for weapon: " + weapon_name);
        }
    }
    //public void set(string n, Sprite s, float min, float max, float r, bool o = false)
    //{
    //    weapon_name = n;
    //    weapon_sprite = s;
    //    damage_min = min;
    //    damage_max = max;
    //    ranage = r;
    //    owned = o;
    //}  

    public float getDamage()
    {
        return Random.Range(damage_min, damage_max);
    }
}
