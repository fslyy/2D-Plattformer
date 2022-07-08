using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_activation_cycle : MonoBehaviour
{
    public bool Laser_on = false;
    private BoxCollider2D laser_col;
    private SpriteRenderer laser_spr;
    // Start is called before the first frame update
    void Start()
    {
        laser_col = GetComponent<BoxCollider2D>();
        laser_spr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Laser_on == false)
        {
            laser_col.enabled = false;
            laser_spr.enabled = false;
            Invoke("Laser_back", 1.5f);
        }
        if (Laser_on == true)
        {
            laser_col.enabled = true;
            laser_spr.enabled = true;
            Invoke("Laser_off", 1.5f);
        }

    }
    private void Laser_off()
    {
        Laser_on = false;
    }
    private void Laser_back()
    {
        Laser_on = true;
    }
}
