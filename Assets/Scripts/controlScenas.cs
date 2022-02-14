using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlScenas : MonoBehaviour
{
    // Start is called before the first frame update
    public void CambiarScena(string scena){
        if(scena == "WelcomeSpace"){
            SceneManager.LoadScene("WelcomeSpace");
        }else if( scena == "VistaGeneral"){
            SceneManager.LoadScene("VistaGeneral");
        }else if( scena == "VistaDeSala"){
            SceneManager.LoadScene("VistaDeSala");
        }else if( scena == "VistaDeChico"){
            SceneManager.LoadScene("VistaDeChico");
        }
    }

}
