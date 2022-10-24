using UnityEngine;
using UnityEngine.AI;//ADDED

public class RTSController : MonoBehaviour
{
    NavMeshAgent _player;

    void Awake()
    {
        _player = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray clickPosition = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(clickPosition, out var hitInfo))
            {
                _player.SetDestination(hitInfo.point);
            }
        }
    }
}
