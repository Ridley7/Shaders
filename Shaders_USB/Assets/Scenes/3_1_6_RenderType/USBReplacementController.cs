using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class USBReplacementController : MonoBehaviour
{
    //Replacemente shader
    public Shader m_replacementeShader;

    private void OnEnable()
    {
        if(m_replacementeShader != null)
        {
            //the camera will replace all the shader in the scene with the replacement shader
            // the "RenderType" configuration must match
            GetComponent<Camera>().SetReplacementShader(m_replacementeShader, "RenderType");
        }
    }

    private void OnDisable()
    {
        GetComponent<Camera>().ResetReplacementShader();
    }
}
