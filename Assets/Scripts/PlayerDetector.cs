using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    Enemy _parentEnemy;

    void Awake()
    {
        _parentEnemy = transform.parent.GetComponent<Enemy>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.GetComponent<Player>())
        {
            _parentEnemy.ToggleChase();
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.transform.gameObject.GetComponent<Player>())
        {
            _parentEnemy.ToggleChase();
        }
    }
}
