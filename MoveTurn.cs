using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTurn : MonoBehaviour
{
    public float angle = 90.0f;
    public float maxCount = 50.0f;
    public float speed_x;
    public float speed_y;
    public float speed_z;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log(count = count + 1);
        
        if (count == maxCount)
        {
            
            this.transform.Rotate(0, 0, angle);
            count = 0;
        }
        this.transform.Translate(speed_x, speed_y, speed_z);
    }
}
