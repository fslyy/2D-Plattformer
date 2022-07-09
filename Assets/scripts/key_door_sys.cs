using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_door_sys : MonoBehaviour
{

    public bool has_key = false;
    public bool door_open = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "key")
        {
            has_key = true;
        }
        if (collision.gameObject.tag == "door" && has_key == true)
        {
            door_open = true;
            has_key = false;
        }
    }
}
