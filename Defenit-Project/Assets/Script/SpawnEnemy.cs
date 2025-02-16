using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float respawnTime = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(EnemySpawn()); 
    }

    IEnumerator EnemySpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);

            // Tentukan posisi random dalam area tertentu
            float randomX = Random.Range(Camera.main.transform.position.x - 5f, Camera.main.transform.position.x + 5f);
            float randomY = Random.Range(Camera.main.transform.position.y - 3f, Camera.main.transform.position.y + 3f);
            Vector2 spawnPosition = new Vector2(randomX, randomY);



            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
