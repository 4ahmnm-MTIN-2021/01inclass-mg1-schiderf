using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    void Update()
    {
        transform.Translate(0, Time.deltaTime * 1, 0, Space.World);
    }
}
