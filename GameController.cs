using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    
    void Rotate()
    {
        if(Input.touchCount > 0) // toque na tela
        {
            Touch t = Input.GetTouch(0); // para aplicar somente um touch por vez
            if(t.phase == TouchPhase.Moved) // daí entra nessa condição para funcionar a rotação
            {
                Vector2 rot = new Vector2(t.deltaPosition.y, t.deltaPosition.x * -1); // aqui está rotacionando todos os eixos
                transform.Rotate(rot * 5 * Time.deltaTime, Space.World);  
            }
        }
    }

    /*  OU

     void Rotate()
    {
     if(Input.touchCount > 0) // ou colocar == 2, e abaixo no 2 colocar 0.
     {
         Touch t = Input.GetTouch(2); 
         if(t.phase == TouchPhase.Moved)
         {
             float z = 5 * Time.deltaTime;
             transform.rotation = Quaternion.Euler(0, 0, z);
         }
     }
    }
     
    /*/

    void Update()
    {
        Rotate();
    }
}
