using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSwitchHexagon : MonoBehaviour
{
    // Start is called before the first frame update
    public PolygonCollider2D polygonCollider;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            polygonCollider.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3))
        {
            polygonCollider.enabled = false;
        }
    }
}
