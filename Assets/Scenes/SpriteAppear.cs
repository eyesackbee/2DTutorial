using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAppear : MonoBehaviour
{
    public GameObject target;
    public void ShowImage()

    {
        target.SetActive(true);
    }
}
