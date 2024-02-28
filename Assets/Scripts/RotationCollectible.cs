using UnityEngine;

public class RotationCollectible : MonoBehaviour
{
    public float velocidadRotacion = 50f;

    void Update()
    {
        transform.Rotate(Vector3.up * velocidadRotacion * Time.deltaTime);
    }
}
