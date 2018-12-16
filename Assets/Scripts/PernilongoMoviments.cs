using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PernilongoMoviments : MonoBehaviour
{

    public bool preso= false;
    [SerializeField] private float speed = 3f;
    [SerializeField] private List<Transform> pontosTransform;
    private Vector3 destino;
    public bool dentro;
//    private List<Vector2> pontosVector2;
    bool isMoving = true;
    public int i;

    public float tempo;

    void Start()
    {
      
        i = Random.Range(0, pontosTransform.Count);
        destino = new Vector3(pontosTransform[i].position.x, pontosTransform[i].position.y, 0);

    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("teiaAranha"))
        {

            preso = true;
        }
            

    }


    void Update()
    {
      
       if(preso==false)
        {
            if (isMoving)//verifica se pode se movimentar
                transform.position = Vector3.MoveTowards(transform.position, destino, Time.deltaTime * speed);


            // se locomove ate o ponto sorteado em I no metodo start, e se movimenta coma velocidade * o tempo
            if (transform.position == pontosTransform[i].position)//verifica se o lugar atual é o mesmo ponto que o do ponto sorteado
            {
                

                i = Random.Range(0, pontosTransform.Count);//sorteia um novo ponto para seguir
                destino = new Vector3(pontosTransform[i].position.x, pontosTransform[i].position.y, 0);
                isMoving = true;// habilita movimentação;
            }
        }
         
     }

    }




