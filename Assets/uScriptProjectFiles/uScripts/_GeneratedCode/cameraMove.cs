//uScript Generated Code - Build 1.0.3077
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class cameraMove : uScriptLogic
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
   System.Single local_11_System_Single = (float) 5;
   System.Single local_12_System_Single = (float) 0;
   System.Single local_14_System_Single = (float) 0;
   System.Single local_15_System_Single = (float) -4;
   UnityEngine.Vector3 local_17_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Transform local_2_UnityEngine_Transform = default(UnityEngine.Transform);
   UnityEngine.Vector3 local_3_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.GameObject local_5_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_5_UnityEngine_GameObject_previous = null;
   System.Single local_7_System_Single = (float) 0;
   System.Single local_8_System_Single = (float) 0;
   System.Single local_9_System_Single = (float) 0;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_GetPositionFromTransform logic_uScriptAct_GetPositionFromTransform_uScriptAct_GetPositionFromTransform_1 = new uScriptAct_GetPositionFromTransform( );
   UnityEngine.Transform logic_uScriptAct_GetPositionFromTransform_target_1 = default(UnityEngine.Transform);
   System.Boolean logic_uScriptAct_GetPositionFromTransform_getLocal_1 = (bool) false;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionFromTransform_position_1;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionFromTransform_forward_1;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionFromTransform_right_1;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionFromTransform_up_1;
   UnityEngine.Matrix4x4 logic_uScriptAct_GetPositionFromTransform_worldMatrix_1;
   bool logic_uScriptAct_GetPositionFromTransform_Out_1 = true;
   //pointer to script instanced logic node
   uScriptAct_MoveToLocation logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_4 = new uScriptAct_MoveToLocation( );
   UnityEngine.GameObject[] logic_uScriptAct_MoveToLocation_targetArray_4 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_MoveToLocation_location_4 = new Vector3( );
   System.Boolean logic_uScriptAct_MoveToLocation_asOffset_4 = (bool) false;
   System.Single logic_uScriptAct_MoveToLocation_totalTime_4 = (float) 0.5;
   bool logic_uScriptAct_MoveToLocation_Out_4 = true;
   bool logic_uScriptAct_MoveToLocation_Cancelled_4 = true;
   //pointer to script instanced logic node
   uScriptAct_GetComponentsVector3 logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_6 = new uScriptAct_GetComponentsVector3( );
   UnityEngine.Vector3 logic_uScriptAct_GetComponentsVector3_InputVector3_6 = new Vector3( );
   System.Single logic_uScriptAct_GetComponentsVector3_X_6;
   System.Single logic_uScriptAct_GetComponentsVector3_Y_6;
   System.Single logic_uScriptAct_GetComponentsVector3_Z_6;
   bool logic_uScriptAct_GetComponentsVector3_Out_6 = true;
   //pointer to script instanced logic node
   uScriptAct_SubtractFloat logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_10 = new uScriptAct_SubtractFloat( );
   System.Single logic_uScriptAct_SubtractFloat_A_10 = (float) 0;
   System.Single logic_uScriptAct_SubtractFloat_B_10 = (float) 0;
   System.Single logic_uScriptAct_SubtractFloat_FloatResult_10;
   System.Int32 logic_uScriptAct_SubtractFloat_IntResult_10;
   bool logic_uScriptAct_SubtractFloat_Out_10 = true;
   //pointer to script instanced logic node
   uScriptAct_SubtractFloat logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_13 = new uScriptAct_SubtractFloat( );
   System.Single logic_uScriptAct_SubtractFloat_A_13 = (float) 0;
   System.Single logic_uScriptAct_SubtractFloat_B_13 = (float) 0;
   System.Single logic_uScriptAct_SubtractFloat_FloatResult_13;
   System.Int32 logic_uScriptAct_SubtractFloat_IntResult_13;
   bool logic_uScriptAct_SubtractFloat_Out_13 = true;
   //pointer to script instanced logic node
   uScriptAct_SetComponentsVector3 logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_16 = new uScriptAct_SetComponentsVector3( );
   System.Single logic_uScriptAct_SetComponentsVector3_X_16 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Y_16 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Z_16 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_SetComponentsVector3_OutputVector3_16;
   bool logic_uScriptAct_SetComponentsVector3_Out_16 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_0 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == local_2_UnityEngine_Transform || false == m_RegisteredForEvents )
      {
         GameObject gameObject = GameObject.Find( "Player" );
         if ( null != gameObject )
         {
            local_2_UnityEngine_Transform = gameObject.GetComponent<UnityEngine.Transform>();
         }
      }
      if ( null == local_5_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_5_UnityEngine_GameObject = GameObject.Find( "Main Camera" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_5_UnityEngine_GameObject_previous != local_5_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_5_UnityEngine_GameObject_previous = local_5_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_5_UnityEngine_GameObject_previous != local_5_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_5_UnityEngine_GameObject_previous = local_5_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_0 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_0 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_0 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_0.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_0.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_0;
                  component.OnLateUpdate += Instance_OnLateUpdate_0;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_0;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_0 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_0.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_0;
               component.OnLateUpdate -= Instance_OnLateUpdate_0;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_0;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_GetPositionFromTransform_uScriptAct_GetPositionFromTransform_1.SetParent(g);
      logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_4.SetParent(g);
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_6.SetParent(g);
      logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_10.SetParent(g);
      logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_13.SetParent(g);
      logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_16.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_4.Finished += uScriptAct_MoveToLocation_Finished_4;
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
      
      logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_4.Update( );
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_4.Finished -= uScriptAct_MoveToLocation_Finished_4;
   }
   
   void Instance_OnUpdate_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_0( );
   }
   
   void Instance_OnLateUpdate_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_0( );
   }
   
   void Instance_OnFixedUpdate_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_0( );
   }
   
   void uScriptAct_MoveToLocation_Finished_4(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_4( );
   }
   
   void Relay_OnUpdate_0()
   {
      if (true == CheckDebugBreak("1b70d511-713b-4e2d-b1c3-7d11562936a4", "Global_Update", Relay_OnUpdate_0)) return; 
      Relay_In_1();
   }
   
   void Relay_OnLateUpdate_0()
   {
      if (true == CheckDebugBreak("1b70d511-713b-4e2d-b1c3-7d11562936a4", "Global_Update", Relay_OnLateUpdate_0)) return; 
   }
   
   void Relay_OnFixedUpdate_0()
   {
      if (true == CheckDebugBreak("1b70d511-713b-4e2d-b1c3-7d11562936a4", "Global_Update", Relay_OnFixedUpdate_0)) return; 
   }
   
   void Relay_In_1()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("2a878927-8cdf-4c13-a7b3-9c260a2e715f", "Get_Position_From_Transform", Relay_In_1)) return; 
         {
            {
               logic_uScriptAct_GetPositionFromTransform_target_1 = local_2_UnityEngine_Transform;
               
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
         logic_uScriptAct_GetPositionFromTransform_uScriptAct_GetPositionFromTransform_1.In(logic_uScriptAct_GetPositionFromTransform_target_1, logic_uScriptAct_GetPositionFromTransform_getLocal_1, out logic_uScriptAct_GetPositionFromTransform_position_1, out logic_uScriptAct_GetPositionFromTransform_forward_1, out logic_uScriptAct_GetPositionFromTransform_right_1, out logic_uScriptAct_GetPositionFromTransform_up_1, out logic_uScriptAct_GetPositionFromTransform_worldMatrix_1);
         local_3_UnityEngine_Vector3 = logic_uScriptAct_GetPositionFromTransform_position_1;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetPositionFromTransform_uScriptAct_GetPositionFromTransform_1.Out;
         
         if ( test_0 == true )
         {
            Relay_In_6();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript cameraMove.uscript at Get Position From Transform.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Finished_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("2f9b25f3-1860-4b07-bdec-d75f4e3d31f5", "Move_To_Location", Relay_Finished_4)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript cameraMove.uscript at Move To Location.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("2f9b25f3-1860-4b07-bdec-d75f4e3d31f5", "Move_To_Location", Relay_In_4)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_5_UnityEngine_GameObject_previous != local_5_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_5_UnityEngine_GameObject_previous = local_5_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_MoveToLocation_targetArray_4.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_MoveToLocation_targetArray_4, index + 1);
               }
               logic_uScriptAct_MoveToLocation_targetArray_4[ index++ ] = local_5_UnityEngine_GameObject;
               
            }
            {
               logic_uScriptAct_MoveToLocation_location_4 = local_17_UnityEngine_Vector3;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_4.In(logic_uScriptAct_MoveToLocation_targetArray_4, logic_uScriptAct_MoveToLocation_location_4, logic_uScriptAct_MoveToLocation_asOffset_4, logic_uScriptAct_MoveToLocation_totalTime_4);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript cameraMove.uscript at Move To Location.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Cancel_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("2f9b25f3-1860-4b07-bdec-d75f4e3d31f5", "Move_To_Location", Relay_Cancel_4)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_5_UnityEngine_GameObject_previous != local_5_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_5_UnityEngine_GameObject_previous = local_5_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_MoveToLocation_targetArray_4.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_MoveToLocation_targetArray_4, index + 1);
               }
               logic_uScriptAct_MoveToLocation_targetArray_4[ index++ ] = local_5_UnityEngine_GameObject;
               
            }
            {
               logic_uScriptAct_MoveToLocation_location_4 = local_17_UnityEngine_Vector3;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_4.Cancel(logic_uScriptAct_MoveToLocation_targetArray_4, logic_uScriptAct_MoveToLocation_location_4, logic_uScriptAct_MoveToLocation_asOffset_4, logic_uScriptAct_MoveToLocation_totalTime_4);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript cameraMove.uscript at Move To Location.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("5880f0d5-0573-4418-9443-faeb145d18a1", "Get_Components__Vector3_", Relay_In_6)) return; 
         {
            {
               logic_uScriptAct_GetComponentsVector3_InputVector3_6 = local_3_UnityEngine_Vector3;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_6.In(logic_uScriptAct_GetComponentsVector3_InputVector3_6, out logic_uScriptAct_GetComponentsVector3_X_6, out logic_uScriptAct_GetComponentsVector3_Y_6, out logic_uScriptAct_GetComponentsVector3_Z_6);
         local_7_System_Single = logic_uScriptAct_GetComponentsVector3_X_6;
         local_8_System_Single = logic_uScriptAct_GetComponentsVector3_Y_6;
         local_9_System_Single = logic_uScriptAct_GetComponentsVector3_Z_6;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_6.Out;
         
         if ( test_0 == true )
         {
            Relay_In_10();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript cameraMove.uscript at Get Components (Vector3).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_10()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("bb376e21-d530-4186-945b-398f5f66602f", "Subtract_Float", Relay_In_10)) return; 
         {
            {
               logic_uScriptAct_SubtractFloat_A_10 = local_9_System_Single;
               
            }
            {
               logic_uScriptAct_SubtractFloat_B_10 = local_11_System_Single;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_10.In(logic_uScriptAct_SubtractFloat_A_10, logic_uScriptAct_SubtractFloat_B_10, out logic_uScriptAct_SubtractFloat_FloatResult_10, out logic_uScriptAct_SubtractFloat_IntResult_10);
         local_12_System_Single = logic_uScriptAct_SubtractFloat_FloatResult_10;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_10.Out;
         
         if ( test_0 == true )
         {
            Relay_In_13();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript cameraMove.uscript at Subtract Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_13()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("2eb5cacc-d86f-437e-a286-1c8b5d883e95", "Subtract_Float", Relay_In_13)) return; 
         {
            {
               logic_uScriptAct_SubtractFloat_A_13 = local_8_System_Single;
               
            }
            {
               logic_uScriptAct_SubtractFloat_B_13 = local_15_System_Single;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_13.In(logic_uScriptAct_SubtractFloat_A_13, logic_uScriptAct_SubtractFloat_B_13, out logic_uScriptAct_SubtractFloat_FloatResult_13, out logic_uScriptAct_SubtractFloat_IntResult_13);
         local_14_System_Single = logic_uScriptAct_SubtractFloat_FloatResult_13;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_13.Out;
         
         if ( test_0 == true )
         {
            Relay_In_16();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript cameraMove.uscript at Subtract Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_16()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("9d682044-fea6-4a0c-bbb6-09f0c216a5c6", "Set_Components__Vector3_", Relay_In_16)) return; 
         {
            {
               logic_uScriptAct_SetComponentsVector3_X_16 = local_7_System_Single;
               
            }
            {
               logic_uScriptAct_SetComponentsVector3_Y_16 = local_14_System_Single;
               
            }
            {
               logic_uScriptAct_SetComponentsVector3_Z_16 = local_12_System_Single;
               
            }
            {
            }
         }
         logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_16.In(logic_uScriptAct_SetComponentsVector3_X_16, logic_uScriptAct_SetComponentsVector3_Y_16, logic_uScriptAct_SetComponentsVector3_Z_16, out logic_uScriptAct_SetComponentsVector3_OutputVector3_16);
         local_17_UnityEngine_Vector3 = logic_uScriptAct_SetComponentsVector3_OutputVector3_16;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_16.Out;
         
         if ( test_0 == true )
         {
            Relay_In_4();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript cameraMove.uscript at Set Components (Vector3).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "cameraMove.uscript:2", local_2_UnityEngine_Transform);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "345ff635-92b8-4fb7-b751-2a7c2f3b5d46", local_2_UnityEngine_Transform);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "cameraMove.uscript:3", local_3_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "14cc3db5-3ef0-421b-9f46-2c2beffeedc8", local_3_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "cameraMove.uscript:5", local_5_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "48fe33f1-3ebf-4eb2-bae8-f6bb80911b8e", local_5_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "cameraMove.uscript:7", local_7_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "449a909d-a65d-4b4f-bf3f-eaecec2209e3", local_7_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "cameraMove.uscript:8", local_8_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "a971c061-a8c6-4e14-803d-32402c91044b", local_8_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "cameraMove.uscript:9", local_9_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "c4d2071b-ed28-4e85-875c-08b4efc2a4a4", local_9_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "cameraMove.uscript:11", local_11_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "79f96c74-1fe9-4354-a260-442597b52c92", local_11_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "cameraMove.uscript:12", local_12_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "5a6e6263-f3cd-4186-9e8e-9da1a651dcc9", local_12_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "cameraMove.uscript:14", local_14_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "80053fd8-7346-4e20-a0a8-0dab5cb00000", local_14_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "cameraMove.uscript:15", local_15_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "f8c59da7-ad2e-40f7-991f-28fb35af128f", local_15_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "cameraMove.uscript:17", local_17_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "7cfc9617-dc55-4731-a581-e9d06852f7a8", local_17_UnityEngine_Vector3);
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
