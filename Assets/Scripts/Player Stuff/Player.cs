using UnityEngine;

public class Player : MonoBehaviour
{
    bool IsMoveableTile(Vector3 dir) 
    {
        return Physics.Raycast(transform.position + (dir * 1.1f), Vector3.down, 1.0f) && !Physics.Raycast(transform.position, transform.forward, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveTo = new(0,0,0);
        if (Input.GetKeyDown(KeyCode.W)) {moveTo = Vector3.forward;}
        if (Input.GetKeyDown(KeyCode.A)) {moveTo = Vector3.left;}
        if (Input.GetKeyDown(KeyCode.S)) {moveTo = Vector3.back;}
        if (Input.GetKeyDown(KeyCode.D)) {moveTo = Vector3.right;}


        if (moveTo.magnitude != 0) 
        {
            transform.rotation = Quaternion.LookRotation(moveTo);
            transform.position = IsMoveableTile(moveTo) ? transform.position + moveTo : transform.position;
        }
    }

    void Fire()
    {

    }
}
