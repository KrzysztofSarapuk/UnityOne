using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementController : MonoBehaviour
{
    public void Move(Vector2Int direction)
    {
        //transform.position += new Vector3(direction.x, 0, direction.y );
        GetComponent<Animator>().Play("moveforward");
    }
    public void Move(TileController target)
    {
        Debug.Log("Poruszam");
        transform.position = target.transform.position;
    }


    //public void Move(Vector2Int direction)
    //{
    //    transform.position += new Vector3(direction.x, 0, direction.y);
    //    GetComponent<Animator>().Play("moveforward");
    //}

    //public void Move2(Vector2Int direction)
    //{
    //    transform.position += new Vector3(direction.x, 0, direction.y);
    //    GetComponent<Animator>().Play("moveright");
    //}

    //public void Move3(Vector2Int direction)
    //{
    //    transform.position += new Vector3(direction.x, 0, direction.y);
    //    GetComponent<Animator>().Play("moveleft");
    //}

    //public void Move4(Vector2Int direction)
    //{
    //    transform.position += new Vector3(direction.x, 0, direction.y);
    //    GetComponent<Animator>().Play("moveback");
    //}

    //public void Move5(Vector2Int direction)
    //{
    //    //transform.position += new Vector3(direction.x, 0, direction.y);
    //    GetComponent<Animator>().Play("attackLeft");
    //}
}
