using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPItem : MonoBehaviour , IItem
{
    [SerializeField]
    public int HPUp;
    public void Use(GameObject user) {
        Debug.Log("Using HP item");
    }
}
