using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steve63 : MonoBehaviour
{
    Transform steve_transform;
    // Start is called before the first frame update
    void Start()
    {
        steve_transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        steve_transform.Translate(0.5f, 0, 0);
    }
}
