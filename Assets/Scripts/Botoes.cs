using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Botoes : MonoBehaviour {

    public void restartGame()
    {
        InstanciaPernilongo.pernilongosNatela = 0;
        Derrota.gameover = false;
        Vitoria.vitoria = false;
        SceneManager.LoadScene("ScenaJogo");
    }

    public void ExitGame()
    {
        InstanciaPernilongo.pernilongosNatela = 0;
        Derrota.gameover = false;
        Vitoria.vitoria = false;
        SceneManager.LoadScene("Inicial");
    }



}
