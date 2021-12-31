using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;

public class UI : MonoBehaviour
{
    public Image image1;
    public Image image2;
    public Image image3;
    public Sprite sprite_old;
    public Sprite sprite_new;
    // Update is called once per frame

    void Update()
    {
        if (GameObject.Find("player").GetComponent<DeathCheck>().lives <= 2)
        {
            image3.sprite = sprite_new;
        }
        if (GameObject.Find("player").GetComponent<DeathCheck>().lives <= 1)
        {
            image2.sprite = sprite_new;
        }
        if (GameObject.Find("player").GetComponent<DeathCheck>().lives <= 0)
        {
            image1.sprite = sprite_new;
        }
        if(GameObject.Find("player").GetComponent<DeathCheck>().lives == 0)
        {
            image1.sprite = sprite_old;
            image2.sprite = sprite_old;
            image3.sprite = sprite_old;
        }
    }
}
