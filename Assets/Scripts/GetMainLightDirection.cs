using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class GetMainLightDirection : MonoBehaviour
{
   [SerializeField] private Material skyboxMaterial;

    private void Update()
    {
        skyboxMaterial.SetVector("_MainLightDirection", transform.forward);
        skyboxMaterial.SetVector("_MainLightUp", transform.up);
        skyboxMaterial.SetVector("_MainLightRight", transform.right);
    }
}
