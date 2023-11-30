using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class sub_menus : MonoBehaviour
{
    Button bttn_1_1, bttn_1_2, bttn_1_3, bttn_1_4;
    Button bttn_2_1, bttn_2_2, bttn_2_3, bttn_2_4;
    Button bttn_3_1, bttn_3_2, bttn_3_3, bttn_3_4;

    GameObject go;
    bool status;


    // Start is called before the first frame update
    void Start()
    {
        status = false;

        bttn_1_1 = GameObject.Find("Arbol1").GetComponent<Button>();
        bttn_1_2 = GameObject.Find("Arbol2").GetComponent<Button>();
        bttn_1_3 = GameObject.Find("Arbol3").GetComponent<Button>();
        bttn_1_4 = GameObject.Find("Arbol4").GetComponent<Button>();

        bttn_2_1 = GameObject.Find("Arbusto1").GetComponent<Button>();
        bttn_2_2 = GameObject.Find("Arbusto2").GetComponent<Button>();
        bttn_2_3 = GameObject.Find("Arbusto3").GetComponent<Button>();
        bttn_2_4 = GameObject.Find("Arbusto4").GetComponent<Button>();

        bttn_3_1 = GameObject.Find("Elemento1").GetComponent<Button>();
        bttn_3_2 = GameObject.Find("Elemento2").GetComponent<Button>();
        bttn_3_3 = GameObject.Find("Elemento3").GetComponent<Button>();
        bttn_3_4 = GameObject.Find("Elemento4").GetComponent<Button>();

        bttn_1_1.onClick.AddListener(() => select_go(GameObject.Find("SM_Env_Tree_Apricot_Grown_01")));
        bttn_1_2.onClick.AddListener(() => select_go(GameObject.Find("SM_Generic_Tree_Patch_01 (17)")));
        bttn_1_3.onClick.AddListener(() => select_go(GameObject.Find("SM_Env_Tree_Cherry_01 (27)")));
        bttn_1_4.onClick.AddListener(() => select_go(GameObject.Find("SM_Env_Tree_Large_01 (2)")));

        bttn_2_1.onClick.AddListener(() => select_go(GameObject.Find("SM_Env_Flowers_02 (67)")));
        bttn_2_2.onClick.AddListener(() => select_go(GameObject.Find("SM_Prop_Plant_Wheat_Optimised_04")));
        bttn_2_3.onClick.AddListener(() => select_go(GameObject.Find("SM_Generic_Grass_Patch_03 (124)")));
        bttn_2_4.onClick.AddListener(() => select_go(GameObject.Find("SM_Prop_Plant_Ground_03_L2")));
      
        bttn_3_1.onClick.AddListener(() => select_go(GameObject.Find("SM_Veh_Pickup_01 (5)")));
        bttn_3_2.onClick.AddListener(() => select_go(GameObject.Find("SM_Veh_TractorOld_01 (3)")));
        bttn_3_3.onClick.AddListener(() => select_go(GameObject.Find("SM_Prop_Tyre_01")));
        bttn_3_4.onClick.AddListener(() => select_go(GameObject.Find("SM_Prop_Truck_Rusted_01 (1)")));

    } // end of Start() 


    // Update is called once per frame
    // Update is called once per frame
    void Update()
    {
        if (status)
        {
            Camera cmr = GameObject.Find("Camera").GetComponent<Camera>();
            Vector3 mouse_pstn = cmr.ViewportToWorldPoint(new Vector3(Input.mousePosition.x / Screen.width, 0f, 6f));
            Vector3 objt_pstn = new Vector3(mouse_pstn.x, 0f, mouse_pstn.z);
            Instantiate(go, GameObject.Find("Camera").transform.position + new Vector3(0f, 0f, -15f), Quaternion.identity);
            status = false; // Establecer status en false después de instanciar el objeto
        }
    }

                  



    GameObject select_go(GameObject game_object)
    {
        status = true;
        go = game_object;
        return go;

    }


}