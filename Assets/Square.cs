using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public GameObject target;

    void OnMouseDown()
    {
       target.SetActive(true);
    }
}
