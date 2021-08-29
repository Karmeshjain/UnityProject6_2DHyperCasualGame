using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bgscript : MonoBehaviour
{
    // Start is called before the first frame update
    public float scroll_speed = 0.3f;
    private MeshRenderer mesh_renderer;

     void Awake()
    {
        mesh_renderer = GetComponent<MeshRenderer>();
        

    }

    void Start()
    {
        
    }

    void Scroll()
    {
        Vector2 offset = mesh_renderer.sharedMaterial.GetTextureOffset("_MainTex");
        offset.y += Time.deltaTime * scroll_speed;

        mesh_renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
    // Update is called once per frame
    void Update()
    {
        Scroll();
    }
}
