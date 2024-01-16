using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSwitchCircle : MonoBehaviour
{
    // Start is called before the first frame update
    public CircleCollider2D circleCollider;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            circleCollider.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha4))
        {
            circleCollider.enabled = false;
        }
    }
}
