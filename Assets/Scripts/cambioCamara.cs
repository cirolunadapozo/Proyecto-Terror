using UnityEngine;

public class cambioCamara : MonoBehaviour
{

    public GameObject[] listaCamara;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        listaCamara[0].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKey("e"))
        {
            listaCamara[0].gameObject.SetActive(false);
            listaCamara[1].gameObject.SetActive(true);
            
        }

        if (other.CompareTag("Player") && Input.GetKey("r"))
        {
            listaCamara[0].gameObject.SetActive(true);
            listaCamara[1].gameObject.SetActive(false);

        }

    }

    
}
