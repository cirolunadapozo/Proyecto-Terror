using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int hp;
    public int damage = 1;
    public GameObject enemigo;
    public Animator animator;

    public enemigo_sigue enemigoSigue;
    public int cambioVelocidad;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Invoke("enemigoMuere", 1.5f);
        }


        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "areaImpacto")
        {
            hp -= damage;
            animator.Play("enemigoGolpeado");
            enemigoSigue.velocidad = cambioVelocidad;
        }
    }

    private void enemigoMuere()
    {
        enemigo.SetActive(false) ;
    }

    
}
