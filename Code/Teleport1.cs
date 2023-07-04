using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = new Vector3(130, 50, -75);
    }
}
