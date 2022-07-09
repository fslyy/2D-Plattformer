using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;

public class UI : MonoBehaviour
{
    public Image heart1;
    public Image heart2;
    public Image heart3;
    public Image dashcd;
    public Image key_indicator;
    public Sprite heart_full;
    public Sprite heart_empty;
    public Sprite dash_up;
    public Sprite dash_cd;
    public Sprite key;
    public Sprite empty_slot;
    // Update is called once per frame

    void Update()
    {
        if (GameObject.Find("player").GetComponent<DeathCheck>().lives <= 2)
        {
            heart3.sprite = heart_empty;
        }
        if (GameObject.Find("player").GetComponent<DeathCheck>().lives <= 1)
        {
            heart2.sprite = heart_empty;
        }
        if (GameObject.Find("player").GetComponent<DeathCheck>().lives <= 0)
        {
            heart1.sprite = heart_empty;
        }
        if(GameObject.Find("player").GetComponent<DeathCheck>().lives == 3)
        {
            heart1.sprite = heart_full;
            heart2.sprite = heart_full;
            heart3.sprite = heart_full;
        }
        if (GameObject.Find("player").GetComponent<PlayerMovement>().dashcooldown == false)
        {
            dashcd.sprite = dash_up;
        }
        else
        {
            dashcd.sprite = dash_cd;
        }

        if (GameObject.Find("player").GetComponent<key_door_sys>().has_key == true)
        {
            key_indicator.sprite = key;
        }
        else
        {
            key_indicator.sprite = empty_slot;
        }
    }
}
