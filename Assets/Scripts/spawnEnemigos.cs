using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemigos : MonoBehaviour
{
    [SerializeField] GameObject enemigoPrefab;
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine (spawnearNaves());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator spawnearNaves()
    {
        while (true)
        {
            Instantiate(enemigoPrefab, new Vector3(transform.position.x, Random.Range(-4.567998f, 4.567998f),0), Quaternion.identity);

            yield return new WaitForSeconds(2);
        }
    }
}
