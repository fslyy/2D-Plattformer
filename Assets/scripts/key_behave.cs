using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_behave : MonoBehaviour
{
    private GameObject player;
    private void Start()
    {
        player = GameObject.Find("player");
    }

    private void Update()
    {
        if (player.GetComponent<key_door_sys>().has_key)
        {
            Destroy(gameObject);
        }
    }
}
