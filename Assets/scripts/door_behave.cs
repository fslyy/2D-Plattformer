using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_behave : MonoBehaviour
{
    private GameObject player;
    public Sprite door_open;
    public SpriteRenderer spriterenderer;
    private void Start()
    {
        player = GameObject.Find("player");
    }

    private void Update()
    {
        if (player.GetComponent<key_door_sys>().door_open)
        {
            Destroy(gameObject.GetComponent<BoxCollider2D>());
            spriterenderer.sprite = door_open;
        }
    }
}
