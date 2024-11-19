using UnityEngine;

public class puerta : MonoBehaviour
{

    public string nombreAnimacion;
    public Animator animator;
    public GameObject puertaObjeto;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.Play(nombreAnimacion);
            Destroy(gameObject);
            

        }
    }


}
