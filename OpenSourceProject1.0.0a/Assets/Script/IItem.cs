using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 아이템이 무조건 가져야 하는 인터페이스
public interface IItem
{
    //아이템 사용시 실행 함수
    public  void Use(GameObject user) ;


}
