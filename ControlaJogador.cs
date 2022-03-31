using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaJogador : MonoBehaviour
{

    public float Velocidade = 10;

    // Update is called once per frame
    void Update()
    {
        //pega as informacoes do teclado
        float eixoX = Input.GetAxis("Horizontal");
        float eixoZ = Input.GetAxis("Vertical");

        //usa Vector3 para armazenar a poscao +1|-1 enviada pelo teclado em cada eixo
        Vector3 direcao = new Vector3(eixoX,0,eixoZ);
        
        //recebe as direcoes do teclado e muda em transform no jogo para movimentacao do personagem
        transform.Translate(direcao * Velocidade * Time.deltaTime);
        if(direcao!=Vector3.zero)
        {
            GetComponent<Animator>().SetBool("Movendo",true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Movendo",false);
        }
    }
}
