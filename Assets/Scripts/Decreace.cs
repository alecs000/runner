using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decreace : MonoBehaviour
{
    [SerializeField] float speedDecrease;
    private void Update()
    {
        transform.localScale = new Vector3(Mathf.Lerp(transform.localScale.x, 0, Time.deltaTime * speedDecrease), Mathf.Lerp(transform.localScale.z, 0, Time.deltaTime * speedDecrease), transform.localScale.z);
    }
}
