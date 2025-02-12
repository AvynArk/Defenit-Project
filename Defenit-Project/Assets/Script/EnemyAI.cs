using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public GameObject objective;
    public float speed;

    private float distance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, objective.transform.position);
        Vector2 direction = objective.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, objective.transform.position, speed * Time.deltaTime);
    }
}
