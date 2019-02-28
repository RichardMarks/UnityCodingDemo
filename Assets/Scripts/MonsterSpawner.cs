using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    private LayoutBounds layoutBounds;

    public GameObject monsterPrefab;

    public float secondsUntilNextSpawn = 3;
    public int maximumMonstersAtOnce = 20;

    private Transform monstersRoot;

    private void Awake()
    {
        layoutBounds = LayoutBounds.GetLayoutBounds();
        monstersRoot = GameObject.Find("Monsters").transform;
    }

    private void Start()
    {
        InvokeRepeating("SpawnMonster", 0, secondsUntilNextSpawn);
    }

    private void SpawnMonster()
    {
        if (FindObjectsOfType<Monster>().Length < maximumMonstersAtOnce)
        {
            Vector2 spawnPosition = Random.insideUnitCircle * (layoutBounds.Maximum - layoutBounds.Minimum);

            Instantiate(monsterPrefab, spawnPosition, Quaternion.identity, monstersRoot);
        }
    }
}
