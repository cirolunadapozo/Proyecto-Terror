using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class enemigo_sigue : MonoBehaviour
{

    public GameObject target;
    public float velocidad;
    public float distanciaVision;

   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target.transform.position) < distanciaVision)
        {
            var lookPos = target.transform.position - transform.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 2);
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);

        }

        if (velocidad < 3)
        {
            Invoke("ResetVelocidad", 2);
        }



        
        
    }

    private void ResetVelocidad()
    {
        velocidad = 3;
    }
}
