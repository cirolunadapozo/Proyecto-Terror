using UnityEngine;

public class pedidio : MonoBehaviour
{
    public GameObject pedidoUI;
    public GameObject pedidoTrigger;

    public GameObject triggerPedidoFernetCocaNormal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKey("e"))
        {
           
            pedidoUI.SetActive(true);
            pedidoTrigger.SetActive(false);
        }
    }

    public void cerrarPedido()
    {
        pedidoUI.SetActive(false);
        triggerPedidoFernetCocaNormal.SetActive(true);
    }
}
