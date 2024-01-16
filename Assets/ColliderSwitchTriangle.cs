using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSwitchTriangle : MonoBehaviour
{
    // Start is called before the first frame update
    public PolygonCollider2D polygonCollider;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            polygonCollider.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4))
        {
            polygonCollider.enabled = false;
        }
    }
}
