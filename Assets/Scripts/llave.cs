using UnityEngine;

public class llave : MonoBehaviour
{

    public GameObject Objetollave;
    public GameObject ColliderPuerta;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ColliderPuerta.gameObject.SetActive(true);
            Destroy(Objetollave);
        }
    }

}
