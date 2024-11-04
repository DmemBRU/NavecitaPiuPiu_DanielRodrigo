using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dISPARO : MonoBehaviour
{
    [SerializeField] int velocidad;
    [SerializeField] int damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2 (1, 0)* velocidad* Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemigo"))
        {
           
            Destroy(this.gameObject);
            other.gameObject.GetComponent<enemigo>().RecibirDannio(damage);
            
        }
    }
}
