using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    private Vector3 CannonPosition;
    private Vector3 MousePosition;
    private Vector3 Direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CannonRotate();
    }
    public void CannonRotate()
    {
        CannonPosition = transform.position;
        MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Direction = MousePosition - CannonPosition;
        transform.right = Direction;
    }
}
