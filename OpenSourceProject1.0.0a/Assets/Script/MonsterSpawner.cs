using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject User;
    public GameObject tem;
    public GameObject monsterPrefeb;
    private float x, y;
    private float SetX, SetY;
    [SerializeField]
    private float radius;

    public DayTime dayTime;


    private float lastGenTime = 0;
    private float timeNow = 0;
    public float genTime = 1f;
    public float genMany = 1;
    private void Start()
    {
        lastGenTime = 0;
    }
    void Update()
    {
        timeNow += Time.deltaTime;
        if (timeNow >= genTime + lastGenTime)
        {
            lastGenTime = timeNow;

            if (dayTime.timeNow >= dayTime.timeDaySet / 2) 
            {
                float userX = User.transform.position.x;
                float userY = User.transform.position.y;

              
                for (int i = 0; i < genMany; i++)
                { 
                    SetX = Random.Range(-radius, radius);
                    SetY = Mathf.Sqrt(Mathf.Pow(radius, 2) - Mathf.Pow(SetX, 2)) * (Random.Range(0, 2) == 1 ? -1 : 1);
                    x = SetX + userX;
                    y = SetY + userY;
                    Vector3 pos = new Vector3(x, y, -1);

                    tem = Instantiate(monsterPrefeb, pos, Quaternion.identity);
                    EnemyAI enemyai=tem.GetComponent<EnemyAI>();
                    enemyai.target = User.transform;
                    tem.transform.parent = gameObject.transform;
                    
                }
            }
        }
    }

}
