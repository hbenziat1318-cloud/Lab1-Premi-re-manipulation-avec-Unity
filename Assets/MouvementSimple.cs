using UnityEngine;

public class MouvementSimple : MonoBehaviour
{
    public float vitesse = 5f;
    
    void Update()
    {
        // Flèche DROITE → va à droite
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(vitesse * Time.deltaTime, 0, 0);
        
        // Flèche GAUCHE → va à gauche  
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(-vitesse * Time.deltaTime, 0, 0);
        
        // Flèche HAUT → va en avant
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(0, 0, vitesse * Time.deltaTime);
        
        // Flèche BAS → va en arrière
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(0, 0, -vitesse * Time.deltaTime);
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Piece"))
        {
            Debug.Log("Collection réussi! " + other.gameObject.name);
            Destroy(other.gameObject);
        }
    }
}