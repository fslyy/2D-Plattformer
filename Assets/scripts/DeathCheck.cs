using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCheck : MonoBehaviour
{

    public Transform playertransform;
    public bool death = false;
    public int lives = 3;
    public bool dmg_cd = false;

    private Quaternion rotation = Quaternion.Euler(0, 0, 0);
    private Vector3 position = new Vector3(-8, -1, 0);
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "damage" && dmg_cd == false)
        {
            lives -= 1;
            dmg_cd = true;
            Invoke("SetCdBack", 2);
        }
        if (collision.gameObject.tag == "death")
        {

            death = true;
        }
    }
    private void Update()
    {
        if (death == true || lives <= 0)
        {
            playertransform.SetPositionAndRotation(position, rotation);
            death = false;
            lives = 3;
            dmg_cd = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "damage" && dmg_cd == false)
        {
            lives -= 1;
            dmg_cd = true;
            Invoke("SetCdBack", 2);
        }
    }
    private void SetCdBack()
    {
        dmg_cd = false;
    }
}

