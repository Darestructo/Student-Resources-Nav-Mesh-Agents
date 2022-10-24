using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //ADDED

public class Enemy : MonoBehaviour
{
    [SerializeField] Material _idleMaterial;
    [SerializeField] Material _chaseMaterial;

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

    public void ToggleChase()
    {
        _bShouldChase = !_bShouldChase;
        UpdateEnemyMaterial();
        Debug.Log($"Chase bool now set to: {_bShouldChase}");
    }

    void HandlePlayerChase()
    {
        if (_bShouldChase)
        {
            _playerTransform = FindObjectOfType<Player>().GetComponent<Transform>();
            _enemy.SetDestination(_playerTransform.position);
        }
    }

    void UpdateEnemyMaterial()
    {
        if (_bShouldChase)
        {
            GetComponent<Renderer>().material = _chaseMaterial;
        }
        else
        GetComponent<Renderer>().material = _idleMaterial;
    }
}
