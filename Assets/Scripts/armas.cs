using UnityEngine;


public class armas : MonoBehaviour
{

    public BoxCollider arma;
    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        desactivarCollidersArmas();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            animator.Play("Golpe");
        }
        
    }

    public void ActivardColliderarma()
    {
       arma.enabled = true;
    }

    public void desactivarCollidersArmas()
    {
        arma.enabled = false;
    }
}
