using UnityEngine;

public class raio : MonoBehaviour
{
    Ray ray;
    RaycastHit hitData;
    Vector3 point;
    Color color;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (UnityEngine.Input.GetKey(KeyCode.Mouse0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            color = Color.blue;
            Lancar(ray, color, 1);
        }
    }

        private void Lancar(Ray ray, Color color, int tipo)
        {
        if (Physics.Raycast(ray, out hitData))
        {
            Debug.Log("Start!");
            string tag = hitData.collider.tag;
            GameObject hitObject = hitData.transform.gameObject;
            Debug.Log(tag);
            Debug.Log(hitData.collider.name);


            if (hitData.collider.CompareTag("target"))
            {
                Destroy(hitObject);
            }
        }
          
         }
            
    
}
