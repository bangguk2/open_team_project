using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
float time = 0.0f;
    void Update()
    {
        time += Time.deltaTime;
        if(time >= 1)
        {
            Destroy(this.gameObject);// 1�� ������ �Ѿ� ������� ��
        }
    }
    void OnTriggerEnter2D(Collider2D Obj)
    {
        if (Obj.gameObject.tag.Equals("Object"))
        // �ε��� ��ü�� �±װ� Object���� Ȯ��(�� �߰��ϸ� enemy�� ����)
        {
            
            Destroy(this.gameObject);
            // �Ѿ��� ����
        }


    }
}