using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Haystack : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= 5;
    }
    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= 5 ;
    }
}
