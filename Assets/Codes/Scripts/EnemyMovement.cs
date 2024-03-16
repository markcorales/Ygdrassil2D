using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//[RequireComponent(typeof(Enemy))]
public class EnemyMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;

    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 2f;

    private Transform target;
    private int pathIndex = 0;
    LevelManager levelManager;

    

    private void Start()
    {
        //enemy = GetComponent<Enemy>();
        target = LevelManager.main.path[0];
    }

    
    private void Update()
    {
        if (Vector2.Distance(target.position, transform.position) <= 0.1f){
            pathIndex++;

            if (pathIndex >= LevelManager.main.path.Length) {
                EndPath();
                return;
            } else
            {
                target = LevelManager.main.path[pathIndex];
            }
            
        }
        
    }
    private void FixedUpdate() {
        Vector2 direction = (target.position - transform.position).normalized;

        rb.velocity = direction * moveSpeed;
    }

    public void EndPath()
    {
        PlayerStats.Lives--;
        Destroy(gameObject);
    }
}
