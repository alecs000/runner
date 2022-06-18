using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Increase : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       other.transform.localScale = new Vector3(other.transform.localScale.x*1.5f, other.transform.localScale.y, other.transform.localScale.z * 1.5f);
    }
}
