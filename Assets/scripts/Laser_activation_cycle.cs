using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_activation_cycle : MonoBehaviour
{
    public float laser_cd;
    public float counter;
    private BoxCollider2D laser_col;
    private SpriteRenderer laser_spr;
    // Start is called before the first frame update
    void Start()
    {
        laser_col = GetComponent<BoxCollider2D>();
        laser_spr = GetComponent<SpriteRenderer>();
        counter = laser_cd;
    }

    // Update is called once per frame
    void Update()
    {
        counter -= 5 * Time.deltaTime;

        if (counter < 0)
        {
            laser_col.enabled = false;
            laser_spr.enabled = false;
        }
        else if (counter > 0)
        {
            laser_col.enabled = true;
            laser_spr.enabled = true;
        }
        if (counter <= -laser_cd)
        {
            counter = laser_cd;
        }
        
    }
}
