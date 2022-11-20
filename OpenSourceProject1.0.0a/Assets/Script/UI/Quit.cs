using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void ExitGame()
    {
#if UNITY_EDITOR //unity editor에서 종료할 때
        UnityEditor.EditorApplication.isPlaying = false;
#else //앱에서 종료할 때 (PC에서 종료되는지는 아직 모름. 나중에 수정해야 할 수도 있음.)
        Application.Quit();
#endif
    }
}
