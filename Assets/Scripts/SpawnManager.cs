using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public Transform[] spawnpoint;
    public Wave[] waves;

    private int currentWave = 0;
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    public IEnumerator SpawnRoutine()
    {
        while (currentWave < waves.Length)
        {
            Debug.Log($"Wave: {currentWave + 1}");
            Wave wave = waves[currentWave];
            yield return new WaitForSeconds(wave.Delaystart);

            for (int i = 0; i < wave.totalSpawnEnemies; i++)
            {
                int enemyIndex = Random.Range(0, wave.numberOfRandomSpawn);
                Instantiate(EnemyPrefab, spawnpoint[enemyIndex].position, Quaternion.identity); // 2D ใช้ได้

                yield return new WaitForSeconds(wave.spawnInterval);

            }

            Debug.Log("Next Wave");
            currentWave++;
        }

        Debug.Log("Finished!!!");
    }
}
