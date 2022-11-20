using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void ExitGame()
    {
#if UNITY_EDITOR //unity editor���� ������ ��
        UnityEditor.EditorApplication.isPlaying = false;
#else //�ۿ��� ������ �� (PC���� ����Ǵ����� ���� ��. ���߿� �����ؾ� �� ���� ����.)
        Application.Quit();
#endif
    }
}
