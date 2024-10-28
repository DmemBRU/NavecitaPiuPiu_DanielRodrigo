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
            Instantiate(enemigoPrefab, transform.position, Quaternion.identity);

            yield return new WaitForSeconds(2);
        }
    }
}
