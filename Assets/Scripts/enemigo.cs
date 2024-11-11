using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Video;

public class enemigo : MonoBehaviour
{
    [SerializeField] int velocidad;
    [SerializeField] int vida;
    [SerializeField] Animator anim;
    [SerializeField] GameObject bala;
    [SerializeField] GameObject spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(disparo());
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();

        

    }

    private void Movimiento()
    {
        transform.Translate(new Vector2(-1, 0).normalized * velocidad * Time.deltaTime);

    }

    public void RecibirDannio( int dannioRecibido) 
    {
        vida -= dannioRecibido;
        anim.SetTrigger("blink");

        if (vida <= 0)
        {
            Destroy(this.gameObject);
        
        }
    
    }
    private IEnumerator disparo()
    {
        while (true)
        {
            Instantiate(bala, spawnpoint.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(3);
        }
    }
}
