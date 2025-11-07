using UnityEngine;

public class CollectionPiece : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Piece"))
        {
            Debug.Log("Bravo! Collection réussi!");
            Destroy(other.gameObject);
        }
    }
}