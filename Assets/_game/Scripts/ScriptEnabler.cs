using UnityEngine;

public class ScriptEnabler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Aiming>().enabled = true;
        GetComponent<Thrower>().enabled = true;
    }

    private void Update()
    {

        //if (GetComponent<Rigidbody>())
        //{

        //    GetComponent<Aiming>().enabled = false;
        //    GetComponent<Thrower>().enabled = false;
        //}
        if (Input.GetMouseButtonDown(1))
        {
            GetComponent<Aiming>().enabled = true;
            GetComponent<Thrower>().enabled = true;
        }

    }
}
