using UnityEngine;
using UnityEngine.SceneManagement;

public class vida : MonoBehaviour
{

    public int hpPlayer = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hpPlayer <= 0)
        {
            SceneManager.LoadScene("PP_Combate");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemigo"))
        {
            hpPlayer -= 1;
        }
    }
}
