using UnityEngine;
using UnityEngine.VFX;

public class VFX : MonoBehaviour
{
    public VisualEffect visualEffect;
    public float size = 100;

    [SerializeField] private SphereCollider sphereCollider;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        visualEffect.SetFloat("AppliedSize", size / 100);
        visualEffect.SetInt("SpawnRate", (int) size * 20);
        sphereCollider.radius = size / 100;
        Debug.Log("settingfloat");
    }
}