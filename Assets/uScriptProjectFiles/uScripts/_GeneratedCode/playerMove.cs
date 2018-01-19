//uScript Generated Code - Build 1.0.3077
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class playerMove : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   delegate void ContinueExecution();
   ContinueExecution m_ContinueExecution;
   bool m_Breakpoint = false;
   const int MaxRelayCallCount = 1000;
   int relayCallCount = 0;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   UnityEngine.Vector3 local_11_UnityEngine_Vector3 = new Vector3( (float)-30.83373, (float)2.007605, (float)49.5 );
   System.Single local_12_System_Single = (float) -30.83305;
   System.Single local_13_System_Single = (float) 49.5;
   UnityEngine.Vector3 local_15_UnityEngine_Vector3 = new Vector3( (float)-30.83373, (float)0, (float)49.5 );
   UnityEngine.GameObject local_17_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_17_UnityEngine_GameObject_previous = null;
   System.Single local_21_System_Single = (float) 0.2;
   UnityEngine.GameObject local_30_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_30_UnityEngine_GameObject_previous = null;
   System.Boolean local_FireHeld_System_Boolean = (bool) false;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_3 = null;
   UnityEngine.GameObject owner_Connection_5 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_0 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_0 = UnityEngine.KeyCode.W;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_0 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_0 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_0 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_6 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_6 = UnityEngine.KeyCode.S;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_6 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_6 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_6 = true;
   //pointer to script instanced logic node
   uScriptAct_GetComponentsVector3 logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_9 = new uScriptAct_GetComponentsVector3( );
   UnityEngine.Vector3 logic_uScriptAct_GetComponentsVector3_InputVector3_9 = new Vector3( );
   System.Single logic_uScriptAct_GetComponentsVector3_X_9;
   System.Single logic_uScriptAct_GetComponentsVector3_Y_9;
   System.Single logic_uScriptAct_GetComponentsVector3_Z_9;
   bool logic_uScriptAct_GetComponentsVector3_Out_9 = true;
   //pointer to script instanced logic node
   uScriptAct_RaycastFromCursor logic_uScriptAct_RaycastFromCursor_uScriptAct_RaycastFromCursor_10 = new uScriptAct_RaycastFromCursor( );
   UnityEngine.Camera logic_uScriptAct_RaycastFromCursor_Camera_10 = default(UnityEngine.Camera);
   System.Single logic_uScriptAct_RaycastFromCursor_Distance_10 = (float) 1000;
   UnityEngine.LayerMask logic_uScriptAct_RaycastFromCursor_layerMask_10 = 1;
   System.Boolean logic_uScriptAct_RaycastFromCursor_include_10 = (bool) true;
   System.Boolean logic_uScriptAct_RaycastFromCursor_showRay_10 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_RaycastFromCursor_HitObject_10;
   System.Single logic_uScriptAct_RaycastFromCursor_HitDistance_10;
   UnityEngine.Vector3 logic_uScriptAct_RaycastFromCursor_HitLocation_10;
   UnityEngine.Vector3 logic_uScriptAct_RaycastFromCursor_HitNormal_10;
   bool logic_uScriptAct_RaycastFromCursor_NotObstructed_10 = true;
   bool logic_uScriptAct_RaycastFromCursor_Obstructed_10 = true;
   //pointer to script instanced logic node
   uScriptAct_SetComponentsVector3 logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_14 = new uScriptAct_SetComponentsVector3( );
   System.Single logic_uScriptAct_SetComponentsVector3_X_14 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Y_14 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Z_14 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_SetComponentsVector3_OutputVector3_14;
   bool logic_uScriptAct_SetComponentsVector3_Out_14 = true;
   //pointer to script instanced logic node
   uScriptAct_LookAt logic_uScriptAct_LookAt_uScriptAct_LookAt_16 = new uScriptAct_LookAt( );
   UnityEngine.GameObject[] logic_uScriptAct_LookAt_Target_16 = new UnityEngine.GameObject[] {};
   System.Object logic_uScriptAct_LookAt_Focus_16 = "";
   System.Single logic_uScriptAct_LookAt_time_16 = (float) 0;
   uScriptAct_LookAt.LockAxis logic_uScriptAct_LookAt_lockAxis_16 = uScriptAct_LookAt.LockAxis.Y;
   bool logic_uScriptAct_LookAt_Out_16 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_18 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_18 = UnityEngine.KeyCode.Space;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_18 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_18 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_18 = true;
   //pointer to script instanced logic node
   uScriptAct_SpawnPrefab logic_uScriptAct_SpawnPrefab_uScriptAct_SpawnPrefab_19 = new uScriptAct_SpawnPrefab( );
   System.String logic_uScriptAct_SpawnPrefab_PrefabName_19 = "Bullet";
   System.String logic_uScriptAct_SpawnPrefab_ResourcePath_19 = "";
   UnityEngine.GameObject logic_uScriptAct_SpawnPrefab_SpawnPoint_19 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_SpawnPrefab_SpawnedName_19 = "";
   UnityEngine.Vector3 logic_uScriptAct_SpawnPrefab_LocationOffset_19 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.GameObject logic_uScriptAct_SpawnPrefab_SpawnedGameObject_19;
   System.Int32 logic_uScriptAct_SpawnPrefab_SpawnedInstancedID_19;
   bool logic_uScriptAct_SpawnPrefab_Immediate_19 = true;
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_20 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_20 = (float) 0;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_20 = (bool) false;
   bool logic_uScriptAct_Delay_Immediate_20 = true;
   bool logic_uScriptAct_Delay_AfterDelay_20 = true;
   bool logic_uScriptAct_Delay_Stopped_20 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_20 = false;
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_22 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_22 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_22 = true;
   bool logic_uScriptCon_CompareBool_False_22 = true;
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_25 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_25;
   bool logic_uScriptAct_SetBool_Out_25 = true;
   bool logic_uScriptAct_SetBool_SetTrue_25 = true;
   bool logic_uScriptAct_SetBool_SetFalse_25 = true;
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_26 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_26;
   bool logic_uScriptAct_SetBool_Out_26 = true;
   bool logic_uScriptAct_SetBool_SetTrue_26 = true;
   bool logic_uScriptAct_SetBool_SetFalse_26 = true;
   //pointer to script instanced logic node
   uScriptAct_Toggle logic_uScriptAct_Toggle_uScriptAct_Toggle_29 = new uScriptAct_Toggle( );
   UnityEngine.GameObject[] logic_uScriptAct_Toggle_Target_29 = new UnityEngine.GameObject[] {};
   System.Boolean logic_uScriptAct_Toggle_IgnoreChildren_29 = (bool) false;
   bool logic_uScriptAct_Toggle_Out_29 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_1 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_8 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_28 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_x_2 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_y_2 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_z_2 = (float) 0.1;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_x_4 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_y_4 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_z_4 = (float) -0.1;
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == logic_uScriptAct_RaycastFromCursor_Camera_10 || false == m_RegisteredForEvents )
      {
         GameObject gameObject = GameObject.Find( "/Main Camera" );
         if ( null != gameObject )
         {
            logic_uScriptAct_RaycastFromCursor_Camera_10 = gameObject.GetComponent<UnityEngine.Camera>();
         }
      }
      if ( null == logic_uScriptAct_SpawnPrefab_SpawnPoint_19 || false == m_RegisteredForEvents )
      {
         logic_uScriptAct_SpawnPrefab_SpawnPoint_19 = GameObject.Find( "/Player/Weapon" ) as UnityEngine.GameObject;
      }
      if ( null == local_17_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_17_UnityEngine_GameObject = GameObject.Find( "Player" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_17_UnityEngine_GameObject_previous != local_17_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_17_UnityEngine_GameObject_previous = local_17_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_30_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_30_UnityEngine_GameObject = GameObject.Find( "MuzzleFlash" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_30_UnityEngine_GameObject_previous != local_30_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_30_UnityEngine_GameObject_previous = local_30_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == owner_Connection_3 || false == m_RegisteredForEvents )
      {
         owner_Connection_3 = parentGameObject;
      }
      if ( null == owner_Connection_5 || false == m_RegisteredForEvents )
      {
         owner_Connection_5 = parentGameObject;
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_17_UnityEngine_GameObject_previous != local_17_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_17_UnityEngine_GameObject_previous = local_17_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_30_UnityEngine_GameObject_previous != local_30_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_30_UnityEngine_GameObject_previous = local_30_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_1 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_1 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_1 )
         {
            {
               uScript_Input component = event_UnityEngine_GameObject_Instance_1.GetComponent<uScript_Input>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_1.AddComponent<uScript_Input>();
               }
               if ( null != component )
               {
                  component.KeyEvent += Instance_KeyEvent_1;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_8 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_8 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_8 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_8.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_8.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_8;
                  component.OnLateUpdate += Instance_OnLateUpdate_8;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_8;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_28 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_28 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_28 )
         {
            {
               uScript_Global component = event_UnityEngine_GameObject_Instance_28.GetComponent<uScript_Global>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_28.AddComponent<uScript_Global>();
               }
               if ( null != component )
               {
                  component.uScriptStart += Instance_uScriptStart_28;
                  component.uScriptLateStart += Instance_uScriptLateStart_28;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_1 )
      {
         {
            uScript_Input component = event_UnityEngine_GameObject_Instance_1.GetComponent<uScript_Input>();
            if ( null != component )
            {
               component.KeyEvent -= Instance_KeyEvent_1;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_8 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_8.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_8;
               component.OnLateUpdate -= Instance_OnLateUpdate_8;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_8;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_28 )
      {
         {
            uScript_Global component = event_UnityEngine_GameObject_Instance_28.GetComponent<uScript_Global>();
            if ( null != component )
            {
               component.uScriptStart -= Instance_uScriptStart_28;
               component.uScriptLateStart -= Instance_uScriptLateStart_28;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_0.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_6.SetParent(g);
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_9.SetParent(g);
      logic_uScriptAct_RaycastFromCursor_uScriptAct_RaycastFromCursor_10.SetParent(g);
      logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_14.SetParent(g);
      logic_uScriptAct_LookAt_uScriptAct_LookAt_16.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_18.SetParent(g);
      logic_uScriptAct_SpawnPrefab_uScriptAct_SpawnPrefab_19.SetParent(g);
      logic_uScriptAct_Delay_uScriptAct_Delay_20.SetParent(g);
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_22.SetParent(g);
      logic_uScriptAct_SetBool_uScriptAct_SetBool_25.SetParent(g);
      logic_uScriptAct_SetBool_uScriptAct_SetBool_26.SetParent(g);
      logic_uScriptAct_Toggle_uScriptAct_Toggle_29.SetParent(g);
      owner_Connection_3 = parentGameObject;
      owner_Connection_5 = parentGameObject;
   }
   public void Awake()
   {
      
      logic_uScriptAct_LookAt_uScriptAct_LookAt_16.Finished += uScriptAct_LookAt_Finished_16;
      logic_uScriptAct_SpawnPrefab_uScriptAct_SpawnPrefab_19.FinishedSpawning += uScriptAct_SpawnPrefab_FinishedSpawning_19;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_29.OnOut += uScriptAct_Toggle_OnOut_29;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_29.OffOut += uScriptAct_Toggle_OffOut_29;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_29.ToggleOut += uScriptAct_Toggle_ToggleOut_29;
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      m_RegisteredForEvents = true;
      
   }
   
   public void OnEnable()
   {
      RegisterForUnityHooks( );
      m_RegisteredForEvents = true;
   }
   
   public void OnDisable()
   {
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      //reset each Update, and increments each method call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      if ( null != m_ContinueExecution )
      {
         ContinueExecution continueEx = m_ContinueExecution;
         m_ContinueExecution = null;
         m_Breakpoint = false;
         continueEx( );
         return;
      }
      UpdateEditorValues( );
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
      logic_uScriptAct_LookAt_uScriptAct_LookAt_16.Update( );
      logic_uScriptAct_SpawnPrefab_uScriptAct_SpawnPrefab_19.Update( );
      if (true == logic_uScriptAct_Delay_DrivenDelay_20)
      {
         Relay_DrivenDelay_20();
      }
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_LookAt_uScriptAct_LookAt_16.Finished -= uScriptAct_LookAt_Finished_16;
      logic_uScriptAct_SpawnPrefab_uScriptAct_SpawnPrefab_19.FinishedSpawning -= uScriptAct_SpawnPrefab_FinishedSpawning_19;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_29.OnOut -= uScriptAct_Toggle_OnOut_29;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_29.OffOut -= uScriptAct_Toggle_OffOut_29;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_29.ToggleOut -= uScriptAct_Toggle_ToggleOut_29;
   }
   
   void Instance_KeyEvent_1(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_KeyEvent_1( );
   }
   
   void Instance_OnUpdate_8(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_8( );
   }
   
   void Instance_OnLateUpdate_8(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_8( );
   }
   
   void Instance_OnFixedUpdate_8(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_8( );
   }
   
   void Instance_uScriptStart_28(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_uScriptStart_28( );
   }
   
   void Instance_uScriptLateStart_28(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_uScriptLateStart_28( );
   }
   
   void uScriptAct_LookAt_Finished_16(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_16( );
   }
   
   void uScriptAct_SpawnPrefab_FinishedSpawning_19(object o, System.EventArgs e)
   {
      //fill globals
      //links to SpawnedGameObject = 0
      //links to SpawnedInstancedID = 0
      //relay event to nodes
      Relay_FinishedSpawning_19( );
   }
   
   void uScriptAct_Toggle_OnOut_29(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnOut_29( );
   }
   
   void uScriptAct_Toggle_OffOut_29(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OffOut_29( );
   }
   
   void uScriptAct_Toggle_ToggleOut_29(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_ToggleOut_29( );
   }
   
   void Relay_In_0()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("994733c1-aeb0-46bd-8fb8-1337c8d44e67", "Input_Events_Filter", Relay_In_0)) return; 
         {
            {
            }
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_0.In(logic_uScriptAct_OnInputEventFilter_KeyCode_0);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_0.KeyHeld;
         
         if ( test_0 == true )
         {
            Relay_Translate_2();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_KeyEvent_1()
   {
      if (true == CheckDebugBreak("280f1ce0-c700-47e2-b40f-9e2849b9ce0a", "Input_Events", Relay_KeyEvent_1)) return; 
      Relay_In_0();
      Relay_In_6();
      Relay_In_18();
   }
   
   void Relay_Translate_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("415b3f3f-feda-4953-afa5-19e9e51b7f7b", "UnityEngine_Transform", Relay_Translate_2)) return; 
         {
            {
            }
            {
            }
            {
            }
         }
         {
            UnityEngine.Transform component;
            component = owner_Connection_3.GetComponent<UnityEngine.Transform>();
            if ( null != component )
            {
               component.Translate(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_x_2, method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_y_2, method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_z_2);
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at UnityEngine.Transform.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Translate_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("30766d61-6588-4e09-989b-0517cf3b7fa5", "UnityEngine_Transform", Relay_Translate_4)) return; 
         {
            {
            }
            {
            }
            {
            }
         }
         {
            UnityEngine.Transform component;
            component = owner_Connection_5.GetComponent<UnityEngine.Transform>();
            if ( null != component )
            {
               component.Translate(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_x_4, method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_y_4, method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_z_4);
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at UnityEngine.Transform.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("eff80d7d-5165-45dc-9884-9c83838826f9", "Input_Events_Filter", Relay_In_6)) return; 
         {
            {
            }
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_6.In(logic_uScriptAct_OnInputEventFilter_KeyCode_6);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_6.KeyHeld;
         
         if ( test_0 == true )
         {
            Relay_Translate_4();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnUpdate_8()
   {
      if (true == CheckDebugBreak("23269e11-1881-41a5-bcdb-df40073be27e", "Global_Update", Relay_OnUpdate_8)) return; 
      Relay_In_10();
   }
   
   void Relay_OnLateUpdate_8()
   {
      if (true == CheckDebugBreak("23269e11-1881-41a5-bcdb-df40073be27e", "Global_Update", Relay_OnLateUpdate_8)) return; 
   }
   
   void Relay_OnFixedUpdate_8()
   {
      if (true == CheckDebugBreak("23269e11-1881-41a5-bcdb-df40073be27e", "Global_Update", Relay_OnFixedUpdate_8)) return; 
   }
   
   void Relay_In_9()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("23516958-1df9-4fbb-a545-047378c76000", "Get_Components__Vector3_", Relay_In_9)) return; 
         {
            {
               logic_uScriptAct_GetComponentsVector3_InputVector3_9 = local_11_UnityEngine_Vector3;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_9.In(logic_uScriptAct_GetComponentsVector3_InputVector3_9, out logic_uScriptAct_GetComponentsVector3_X_9, out logic_uScriptAct_GetComponentsVector3_Y_9, out logic_uScriptAct_GetComponentsVector3_Z_9);
         local_12_System_Single = logic_uScriptAct_GetComponentsVector3_X_9;
         local_13_System_Single = logic_uScriptAct_GetComponentsVector3_Z_9;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_9.Out;
         
         if ( test_0 == true )
         {
            Relay_In_14();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Get Components (Vector3).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_10()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d00a3ab0-c59b-4275-84c0-5948e845c21f", "Raycast_From_Mouse_Cursor", Relay_In_10)) return; 
         {
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_RaycastFromCursor_uScriptAct_RaycastFromCursor_10.In(logic_uScriptAct_RaycastFromCursor_Camera_10, logic_uScriptAct_RaycastFromCursor_Distance_10, logic_uScriptAct_RaycastFromCursor_layerMask_10, logic_uScriptAct_RaycastFromCursor_include_10, logic_uScriptAct_RaycastFromCursor_showRay_10, out logic_uScriptAct_RaycastFromCursor_HitObject_10, out logic_uScriptAct_RaycastFromCursor_HitDistance_10, out logic_uScriptAct_RaycastFromCursor_HitLocation_10, out logic_uScriptAct_RaycastFromCursor_HitNormal_10);
         local_11_UnityEngine_Vector3 = logic_uScriptAct_RaycastFromCursor_HitLocation_10;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_RaycastFromCursor_uScriptAct_RaycastFromCursor_10.Obstructed;
         
         if ( test_0 == true )
         {
            Relay_In_9();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Raycast From Mouse Cursor.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_14()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("66049b85-4801-4b93-b387-020f971a2736", "Set_Components__Vector3_", Relay_In_14)) return; 
         {
            {
               logic_uScriptAct_SetComponentsVector3_X_14 = local_12_System_Single;
               
            }
            {
            }
            {
               logic_uScriptAct_SetComponentsVector3_Z_14 = local_13_System_Single;
               
            }
            {
            }
         }
         logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_14.In(logic_uScriptAct_SetComponentsVector3_X_14, logic_uScriptAct_SetComponentsVector3_Y_14, logic_uScriptAct_SetComponentsVector3_Z_14, out logic_uScriptAct_SetComponentsVector3_OutputVector3_14);
         local_15_UnityEngine_Vector3 = logic_uScriptAct_SetComponentsVector3_OutputVector3_14;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_14.Out;
         
         if ( test_0 == true )
         {
            Relay_In_16();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Set Components (Vector3).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Finished_16()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("7ed8caf6-6459-4a1b-9b8f-f25c4768f551", "Look_At", Relay_Finished_16)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Look At.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_16()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("7ed8caf6-6459-4a1b-9b8f-f25c4768f551", "Look_At", Relay_In_16)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_17_UnityEngine_GameObject_previous != local_17_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_17_UnityEngine_GameObject_previous = local_17_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_LookAt_Target_16.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_LookAt_Target_16, index + 1);
               }
               logic_uScriptAct_LookAt_Target_16[ index++ ] = local_17_UnityEngine_GameObject;
               
            }
            {
               logic_uScriptAct_LookAt_Focus_16 = local_15_UnityEngine_Vector3;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_LookAt_uScriptAct_LookAt_16.In(logic_uScriptAct_LookAt_Target_16, logic_uScriptAct_LookAt_Focus_16, logic_uScriptAct_LookAt_time_16, logic_uScriptAct_LookAt_lockAxis_16);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Look At.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_18()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("fa038b4c-5ae4-418a-9438-6fbdca4cc948", "Input_Events_Filter", Relay_In_18)) return; 
         {
            {
            }
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_18.In(logic_uScriptAct_OnInputEventFilter_KeyCode_18);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_18.KeyDown;
         bool test_1 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_18.KeyUp;
         
         if ( test_0 == true )
         {
            Relay_True_26();
         }
         if ( test_1 == true )
         {
            Relay_False_25();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_FinishedSpawning_19()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1cf40a6c-0742-4a91-84dc-b28ad21fff4f", "Spawn_Prefab", Relay_FinishedSpawning_19)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Spawn Prefab.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_19()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1cf40a6c-0742-4a91-84dc-b28ad21fff4f", "Spawn_Prefab", Relay_In_19)) return; 
         {
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_SpawnPrefab_uScriptAct_SpawnPrefab_19.In(logic_uScriptAct_SpawnPrefab_PrefabName_19, logic_uScriptAct_SpawnPrefab_ResourcePath_19, logic_uScriptAct_SpawnPrefab_SpawnPoint_19, logic_uScriptAct_SpawnPrefab_SpawnedName_19, logic_uScriptAct_SpawnPrefab_LocationOffset_19, out logic_uScriptAct_SpawnPrefab_SpawnedGameObject_19, out logic_uScriptAct_SpawnPrefab_SpawnedInstancedID_19);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SpawnPrefab_uScriptAct_SpawnPrefab_19.Immediate;
         
         if ( test_0 == true )
         {
            Relay_In_20();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Spawn Prefab.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_20()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("7a7fcd5a-c506-4133-874c-557b3faf1036", "Delay", Relay_In_20)) return; 
         {
            {
               logic_uScriptAct_Delay_Duration_20 = local_21_System_Single;
               
            }
            {
            }
         }
         logic_uScriptAct_Delay_uScriptAct_Delay_20.In(logic_uScriptAct_Delay_Duration_20, logic_uScriptAct_Delay_SingleFrame_20);
         logic_uScriptAct_Delay_DrivenDelay_20 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_20.AfterDelay;
         
         if ( test_0 == true )
         {
            Relay_In_22();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Stop_20()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("7a7fcd5a-c506-4133-874c-557b3faf1036", "Delay", Relay_Stop_20)) return; 
         {
            {
               logic_uScriptAct_Delay_Duration_20 = local_21_System_Single;
               
            }
            {
            }
         }
         logic_uScriptAct_Delay_uScriptAct_Delay_20.Stop(logic_uScriptAct_Delay_Duration_20, logic_uScriptAct_Delay_SingleFrame_20);
         logic_uScriptAct_Delay_DrivenDelay_20 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_20.AfterDelay;
         
         if ( test_0 == true )
         {
            Relay_In_22();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_DrivenDelay_20( )
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         {
            {
               logic_uScriptAct_Delay_Duration_20 = local_21_System_Single;
               
            }
            {
            }
         }
         logic_uScriptAct_Delay_DrivenDelay_20 = logic_uScriptAct_Delay_uScriptAct_Delay_20.DrivenDelay();
         if ( true == logic_uScriptAct_Delay_DrivenDelay_20 )
         {
            if ( logic_uScriptAct_Delay_uScriptAct_Delay_20.AfterDelay == true )
            {
               Relay_In_22();
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   void Relay_In_22()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("e0091389-8316-473d-baf9-8cce2d944d7a", "Compare_Bool", Relay_In_22)) return; 
         {
            {
               logic_uScriptCon_CompareBool_Bool_22 = local_FireHeld_System_Boolean;
               
            }
         }
         logic_uScriptCon_CompareBool_uScriptCon_CompareBool_22.In(logic_uScriptCon_CompareBool_Bool_22);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_22.True;
         
         if ( test_0 == true )
         {
            Relay_In_19();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Compare Bool.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_True_25()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b49ff522-2088-4ed3-b219-057e29f32735", "Set_Bool", Relay_True_25)) return; 
         {
            {
            }
         }
         logic_uScriptAct_SetBool_uScriptAct_SetBool_25.True(out logic_uScriptAct_SetBool_Target_25);
         local_FireHeld_System_Boolean = logic_uScriptAct_SetBool_Target_25;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_25.SetFalse;
         
         if ( test_0 == true )
         {
            Relay_TurnOff_29();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Set Bool.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_False_25()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b49ff522-2088-4ed3-b219-057e29f32735", "Set_Bool", Relay_False_25)) return; 
         {
            {
            }
         }
         logic_uScriptAct_SetBool_uScriptAct_SetBool_25.False(out logic_uScriptAct_SetBool_Target_25);
         local_FireHeld_System_Boolean = logic_uScriptAct_SetBool_Target_25;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_25.SetFalse;
         
         if ( test_0 == true )
         {
            Relay_TurnOff_29();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Set Bool.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_True_26()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1fcd33f8-48f5-4588-8e68-efce9968a5bd", "Set_Bool", Relay_True_26)) return; 
         {
            {
            }
         }
         logic_uScriptAct_SetBool_uScriptAct_SetBool_26.True(out logic_uScriptAct_SetBool_Target_26);
         local_FireHeld_System_Boolean = logic_uScriptAct_SetBool_Target_26;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_26.Out;
         
         if ( test_0 == true )
         {
            Relay_In_22();
            Relay_TurnOn_29();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Set Bool.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_False_26()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1fcd33f8-48f5-4588-8e68-efce9968a5bd", "Set_Bool", Relay_False_26)) return; 
         {
            {
            }
         }
         logic_uScriptAct_SetBool_uScriptAct_SetBool_26.False(out logic_uScriptAct_SetBool_Target_26);
         local_FireHeld_System_Boolean = logic_uScriptAct_SetBool_Target_26;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_26.Out;
         
         if ( test_0 == true )
         {
            Relay_In_22();
            Relay_TurnOn_29();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Set Bool.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_uScriptStart_28()
   {
      if (true == CheckDebugBreak("269aebc3-9d43-430a-baa1-df28432a4cc0", "uScript_Events", Relay_uScriptStart_28)) return; 
      Relay_TurnOff_29();
   }
   
   void Relay_uScriptLateStart_28()
   {
      if (true == CheckDebugBreak("269aebc3-9d43-430a-baa1-df28432a4cc0", "uScript_Events", Relay_uScriptLateStart_28)) return; 
   }
   
   void Relay_OnOut_29()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("066345e6-872f-4ff3-ba56-677ec321b262", "Toggle", Relay_OnOut_29)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OffOut_29()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("066345e6-872f-4ff3-ba56-677ec321b262", "Toggle", Relay_OffOut_29)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_ToggleOut_29()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("066345e6-872f-4ff3-ba56-677ec321b262", "Toggle", Relay_ToggleOut_29)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOn_29()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("066345e6-872f-4ff3-ba56-677ec321b262", "Toggle", Relay_TurnOn_29)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_30_UnityEngine_GameObject_previous != local_30_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_30_UnityEngine_GameObject_previous = local_30_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_29.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_29, index + 1);
               }
               logic_uScriptAct_Toggle_Target_29[ index++ ] = local_30_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_29.TurnOn(logic_uScriptAct_Toggle_Target_29, logic_uScriptAct_Toggle_IgnoreChildren_29);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOff_29()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("066345e6-872f-4ff3-ba56-677ec321b262", "Toggle", Relay_TurnOff_29)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_30_UnityEngine_GameObject_previous != local_30_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_30_UnityEngine_GameObject_previous = local_30_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_29.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_29, index + 1);
               }
               logic_uScriptAct_Toggle_Target_29[ index++ ] = local_30_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_29.TurnOff(logic_uScriptAct_Toggle_Target_29, logic_uScriptAct_Toggle_IgnoreChildren_29);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Toggle_29()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("066345e6-872f-4ff3-ba56-677ec321b262", "Toggle", Relay_Toggle_29)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_30_UnityEngine_GameObject_previous != local_30_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_30_UnityEngine_GameObject_previous = local_30_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Toggle_Target_29.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_29, index + 1);
               }
               logic_uScriptAct_Toggle_Target_29[ index++ ] = local_30_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_29.Toggle(logic_uScriptAct_Toggle_Target_29, logic_uScriptAct_Toggle_IgnoreChildren_29);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript playerMove.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "playerMove.uscript:11", local_11_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "481abba7-d853-40ed-a713-f5ce99a3deeb", local_11_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "playerMove.uscript:12", local_12_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "9354d450-271d-48c7-9096-3c9ae2b9ba8a", local_12_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "playerMove.uscript:13", local_13_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "e525743f-aeed-4a2b-b19a-3953d2e0bb87", local_13_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "playerMove.uscript:15", local_15_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "531d3f83-9b79-415f-8e98-6273c77b6a4a", local_15_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "playerMove.uscript:17", local_17_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "898ea84c-9c43-472c-8e6b-fa33beba2e30", local_17_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "playerMove.uscript:21", local_21_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "11afca15-170b-4fc0-bb35-82140d942339", local_21_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "playerMove.uscript:FireHeld", local_FireHeld_System_Boolean);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "aab88a57-9783-4684-88ea-282a2c6687a4", local_FireHeld_System_Boolean);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "playerMove.uscript:30", local_30_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "e25d204f-e825-4b89-8f6a-7b61a6680465", local_30_UnityEngine_GameObject);
   }
   bool CheckDebugBreak(string guid, string name, ContinueExecution method)
   {
      if (true == m_Breakpoint) return true;
      
      if (true == uScript_MasterComponent.FindBreakpoint(guid))
      {
         if (uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint == guid)
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = "";
         }
         else
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = guid;
            UpdateEditorValues( );
            UnityEngine.Debug.Log("uScript BREAK Node:" + name + " ((Time: " + Time.time + "");
            UnityEngine.Debug.Break();
            #if (!UNITY_FLASH)
            m_ContinueExecution = new ContinueExecution(method);
            #endif
            m_Breakpoint = true;
            return true;
         }
      }
      return false;
   }
}
