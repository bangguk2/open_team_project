using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] ItemList;
    [SerializeField]
    private int GenCooltime = 10;
    [SerializeField]
    private float GenLength = 5;
    [SerializeField]
    private int MaxItemSpawn =10;
    [SerializeField]
    private int MinItemSpawn = 7;
    private int SpawnItemMany = 0;
    private float lastSpawnTime;
    [SerializeField]
    private Transform playerTransform;
    public void Spawn(int itemLength) {
        Vector3 spawnPosition= GetRandomPoint(playerTransform.position,GenLength );
        GameObject selectedItem=ItemList[Random.Range(0, itemLength-1)];
        GameObject item = Instantiate(selectedItem,spawnPosition, Quaternion.identity );
        Destroy(item, GenCooltime);
    }
    public Vector3 GetRandomPoint(Vector3 center, float distance) {
        Vector3 randomPos = Random.insideUnitSphere * distance + center;
        randomPos.z = 0;
        
        return randomPos;
    }
    void Start()
    {
        lastSpawnTime = 0;
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= lastSpawnTime + GenCooltime) {
            lastSpawnTime = Time.time;
            for (SpawnItemMany = Random.Range(MinItemSpawn, MaxItemSpawn); SpawnItemMany > 0; SpawnItemMany--) {
                Spawn(ItemList.Length);
            }
        }
    }
}
