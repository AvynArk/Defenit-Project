using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Transform objective; // Ubah dari public ke private
    public float speed;

    void Start()
    {
        // Cari game object bernama "Objective" di scene
        GameObject obj = GameObject.Find("Objective");

        if (obj != null)
        {
            objective = obj.transform;
        }
        else
        {
            Debug.LogError("Objective tidak ditemukan di scene!");
        }
    }

    void Update()
    {
        if (objective == null) return;

        transform.position = Vector2.MoveTowards(transform.position, objective.position, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == objective.gameObject) // Cek GameObject-nya langsung
        {
            Destroy(gameObject); // Hancurkan enemy
        }
    }
}
