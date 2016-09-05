using UnityEngine;
using System.Collections;

public class Inimigo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        GameObject fimDoCaminho = GameObject.Find("FimDoCaminho");
        Vector3 posicaoDoFim = fimDoCaminho.transform.position;
        agent.SetDestination(posicaoDoFim);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
