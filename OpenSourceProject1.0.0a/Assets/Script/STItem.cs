using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STItem : MonoBehaviour, IItem
{
    [SerializeField]
    public int STUp;
    public void Use(GameObject user) {
        Debug.Log("Useing ST Item");

    }
}
