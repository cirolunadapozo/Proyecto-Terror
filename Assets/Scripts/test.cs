using UnityEngine;

public class test : MonoBehaviour
{
    public Vector3 valores;
    public GameObject otro;
    public int factor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey("d"))
        {
            gameObject.transform.Translate(valores);
            otro.transform.Translate(factor * valores);
        }
    }
}
