using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int velocidad;
    [SerializeField] private GameObject Disparo;
    [SerializeField] private GameObject SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        LimitesMovimientos();
        Atacar();
    }

    private void Movimiento()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector2(h, v).normalized * velocidad * Time.deltaTime);
    }
    private void LimitesMovimientos()
    {
       float yClamped = Mathf.Clamp(transform.position.y, -3.94f, 3.94f);
       float xClamped = Mathf.Clamp(transform.position.x, -7.41f, 7.41f);
        transform.position = new Vector2(xClamped, yClamped);
    }
    private void Atacar()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(Disparo, SpawnPoint.transform.position, quaternion.identity);
        
        };
    }
}
