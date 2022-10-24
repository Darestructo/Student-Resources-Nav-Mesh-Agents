using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //ADDED

public class Enemy : MonoBehaviour
{
    NavMeshAgent _enemy;
    Transform _playerTransform;

    bool _bShouldChase = false;


    void Awake()
    {
        _enemy = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        HandlePlayerChase();
    }

    public void HandlePlayerChase()
    {
        if (_bShouldChase)
        {
            _playerTransform = FindObjectOfType<Player>().GetComponent<Transform>();
            _enemy.SetDestination(_playerTransform.position);
        }
    }

    public void ToggleChase()
    {
        _bShouldChase = !_bShouldChase;
        Debug.Log($"Chase bool now set to: {_bShouldChase}");
    }
}
