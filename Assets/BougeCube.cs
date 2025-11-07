using UnityEngine;

public class BougeCube : MonoBehaviour
{
    public float vitesse = 5f;
    
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * vitesse * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * vitesse * Time.deltaTime;
        
        transform.Translate(x, 0, z);
    }
}