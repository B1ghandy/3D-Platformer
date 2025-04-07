using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;
    private void OnTriggerEnter(Collider other)
    {
       other.GetComponent<Transform>().position = new Vector3(130, 43, -74);
    }
}
