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
            Destroy(this.gameObject);// 1초 지나면 총알 사라지게 함
        }
    }
    void OnTriggerEnter2D(Collider2D Obj)
    {
        if (Obj.gameObject.tag.Equals("Object"))
        // 부딪힌 객체의 태그가 Object인지 확인(적 추가하면 enemy로 변경)
        {
            
            Destroy(this.gameObject);
            // 총알을 없앰
        }


    }
}