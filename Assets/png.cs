using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
//
using UnityEngine.Networking;

public class png_converter : MonoBehaviour
{
    Texture2D icon;
    public byte[] bytes;
    

    // Start is called before the first frame update
    void Start()
    {
    
        /* Create .png images of Prefabs in Scene and save the .png files in Assets/images folder */
    
    
        icon = AssetPreview.GetAssetPreview(GameObject.Find("SM_Env_Tree_Apricot_Grown_01")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/arbol1.png", bytes);
       
        icon = AssetPreview.GetAssetPreview(GameObject.Find("SM_Generic_Tree_Patch_01 (17)")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/arbol2.png", bytes);
        
        icon = AssetPreview.GetAssetPreview(GameObject.Find("SM_Env_Tree_Cherry_01 (27)")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/arbol3.png", bytes);
        
        icon = AssetPreview.GetAssetPreview(GameObject.Find("SM_Env_Tree_Large_01 (2)")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/arbol4.png", bytes);
        
        icon = AssetPreview.GetAssetPreview(GameObject.Find("SM_Env_Flowers_02 (67)")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/planta1.png", bytes);
       
        icon = AssetPreview.GetAssetPreview(GameObject.Find("SM_Prop_Plant_Wheat_Optimised_04")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/planta2.png", bytes);
        
        icon = AssetPreview.GetAssetPreview(GameObject.Find("SM_Generic_Grass_Patch_03 (124)")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/planta3.png", bytes);
        
        icon = AssetPreview.GetAssetPreview(GameObject.Find("SM_Prop_Plant_Ground_03_L2")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/planta4.png", bytes);
        
        icon = AssetPreview.GetAssetPreview(GameObject.Find("SM_Veh_Pickup_01 (5)")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/elemento1.png", bytes);
        
        icon = AssetPreview.GetAssetPreview(GameObject.Find("SM_Veh_TractorOld_01 (3)")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/elemento2.png", bytes);
        
        icon = AssetPreview.GetAssetPreview(GameObject.Find("SM_Prop_Tyre_01")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/elemento3.png", bytes);
        
        icon = AssetPreview.GetAssetPreview(GameObject.Find("SM_Prop_Truck_Rusted_01 (1)")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/elemento4.png", bytes);
        
        
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
