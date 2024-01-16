using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSwitchSquare : MonoBehaviour
{
    // Start is called before the first frame update
    public BoxCollider2D boxCollider;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            boxCollider.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4))
        {
            boxCollider.enabled = false;
        }

    }
}
