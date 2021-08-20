using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
    private void Start()
    {
        float screenHeightInUnits = Camera.main.orthographicSize * 2;
        float screenWidthInUnits = screenHeightInUnits * Screen.width / Screen.height;

        Debug.Log(screenHeightInUnits);
        Debug.Log(screenWidthInUnits);
    }
    void Update()
    {
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z); 
    }
}
