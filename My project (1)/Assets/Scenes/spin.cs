using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(0, 0.5f, 0);
    }
}
