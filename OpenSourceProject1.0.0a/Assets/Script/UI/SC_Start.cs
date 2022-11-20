using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_Start : MonoBehaviour
{
    public void Change()
    {
        SceneManager.LoadScene("StartScene");
    }
}
