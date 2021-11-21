using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Move(Vector2Int direction)
    {
        transform.position += new Vector3(direction.x, 0, direction.y);
        GetComponent<Animator>().Play("moveforward");
    }

    public void Move2(Vector2Int direction)
    {
        transform.position += new Vector3(direction.x, 0, direction.y);
        GetComponent<Animator>().Play("moveright");
    }

    public void Move3(Vector2Int direction)
    {
        transform.position += new Vector3(direction.x, 0, direction.y);
        GetComponent<Animator>().Play("moveleft");
    }

    public void Move4(Vector2Int direction)
    {
        transform.position += new Vector3(direction.x, 0, direction.y);
        GetComponent<Animator>().Play("moveback");
    }

    public void Move5(Vector2Int direction)
    {
        //transform.position += new Vector3(direction.x, 0, direction.y);
        GetComponent<Animator>().Play("attackLeft");
    }
}
