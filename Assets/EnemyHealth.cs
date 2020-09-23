using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    float maxHp=100, hp;

    void Start()
    {
        hp = maxHp;
    }

    public void TakeDamage(float damage)
    {
        hp -= damage;
        if (hp<=0)
        {
            Destroy(gameObject);
        }
    }
}
