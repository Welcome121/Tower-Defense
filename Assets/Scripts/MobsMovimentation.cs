using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobsMovimentation : MonoBehaviour
{
    [SerializeField]private GameObject destination;

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

        agent.SetDestination(destination.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
