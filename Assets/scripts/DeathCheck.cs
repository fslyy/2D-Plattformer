using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCheck : MonoBehaviour
{

    public Transform playertransform;

    private Quaternion rotation = Quaternion.Euler(0, 0, 0);
    private Vector3 position = new Vector3(1, 8, 0);
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "death")
        {
            playertransform.SetPositionAndRotation(position,rotation);
        }

    }

}
