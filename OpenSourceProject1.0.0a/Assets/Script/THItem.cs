using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THItem : MonoBehaviour
{
    [SerializeField]
    public int THUp;
    public void Use(GameObject user){
        Debug.Log("Using TH item");
    }
}
