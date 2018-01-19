//uScript Generated Code - Build 1.0.3077
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class _simpleBool1 : uScriptLogic
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
   UnityEngine.GameObject local_1_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_1_UnityEngine_GameObject_previous = null;
   System.String local_9_System_String = "Toggle color";
   System.Boolean local_IsRed_System_Boolean = (bool) false;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_2 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_2 = (float) 3;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_2 = (bool) false;
   bool logic_uScriptAct_Delay_Immediate_2 = true;
   bool logic_uScriptAct_Delay_AfterDelay_2 = true;
   bool logic_uScriptAct_Delay_Stopped_2 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_2 = false;
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_3 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_3 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_3 = true;
   bool logic_uScriptCon_CompareBool_False_3 = true;
   //pointer to script instanced logic node
   uScriptAct_AssignMaterialColor logic_uScriptAct_AssignMaterialColor_uScriptAct_AssignMaterialColor_5 = new uScriptAct_AssignMaterialColor( );
   UnityEngine.GameObject[] logic_uScriptAct_AssignMaterialColor_Target_5 = new UnityEngine.GameObject[] {};
   UnityEngine.Color logic_uScriptAct_AssignMaterialColor_MatColor_5 = new UnityEngine.Color( (float)0.4558824, (float)0.4558824, (float)0.4558824, (float)1 );
   System.Int32 logic_uScriptAct_AssignMaterialColor_MatChannel_5 = (int) 0;
   bool logic_uScriptAct_AssignMaterialColor_Out_5 = true;
   //pointer to script instanced logic node
   uScriptAct_AssignMaterialColor logic_uScriptAct_AssignMaterialColor_uScriptAct_AssignMaterialColor_6 = new uScriptAct_AssignMaterialColor( );
   UnityEngine.GameObject[] logic_uScriptAct_AssignMaterialColor_Target_6 = new UnityEngine.GameObject[] {};
   UnityEngine.Color logic_uScriptAct_AssignMaterialColor_MatColor_6 = new UnityEngine.Color( (float)1, (float)0, (float)0, (float)1 );
   System.Int32 logic_uScriptAct_AssignMaterialColor_MatChannel_6 = (int) 0;
   bool logic_uScriptAct_AssignMaterialColor_Out_6 = true;
   //pointer to script instanced logic node
   uScriptAct_ToggleBool logic_uScriptAct_ToggleBool_uScriptAct_ToggleBool_7 = new uScriptAct_ToggleBool( );
   System.Boolean logic_uScriptAct_ToggleBool_Target_7 = (bool) false;
   System.Boolean logic_uScriptAct_ToggleBool_Result_7;
   bool logic_uScriptAct_ToggleBool_Out_7 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_8 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_8 = "";
   System.Object[] logic_uScriptAct_Log_Target_8 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_8 = "";
   bool logic_uScriptAct_Log_Out_8 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_0 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == local_1_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_1_UnityEngine_GameObject = GameObject.Find( "BooleanTest" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_1_UnityEngine_GameObject_previous != local_1_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_1_UnityEngine_GameObject_previous = local_1_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_1_UnityEngine_GameObject_previous != local_1_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_1_UnityEngine_GameObject_previous = local_1_UnityEngine_GameObject;
         
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
               uScript_Global component = event_UnityEngine_GameObject_Instance_0.GetComponent<uScript_Global>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_0.AddComponent<uScript_Global>();
               }
               if ( null != component )
               {
                  component.uScriptStart += Instance_uScriptStart_0;
                  component.uScriptLateStart += Instance_uScriptLateStart_0;
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
            uScript_Global component = event_UnityEngine_GameObject_Instance_0.GetComponent<uScript_Global>();
            if ( null != component )
            {
               component.uScriptStart -= Instance_uScriptStart_0;
               component.uScriptLateStart -= Instance_uScriptLateStart_0;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_Delay_uScriptAct_Delay_2.SetParent(g);
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_3.SetParent(g);
      logic_uScriptAct_AssignMaterialColor_uScriptAct_AssignMaterialColor_5.SetParent(g);
      logic_uScriptAct_AssignMaterialColor_uScriptAct_AssignMaterialColor_6.SetParent(g);
      logic_uScriptAct_ToggleBool_uScriptAct_ToggleBool_7.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_8.SetParent(g);
   }
   public void Awake()
   {
      
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
      
      if (true == logic_uScriptAct_Delay_DrivenDelay_2)
      {
         Relay_DrivenDelay_2();
      }
   }
   
   public void OnDestroy()
   {
   }
   
   void Instance_uScriptStart_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_uScriptStart_0( );
   }
   
   void Instance_uScriptLateStart_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_uScriptLateStart_0( );
   }
   
   void Relay_uScriptStart_0()
   {
      if (true == CheckDebugBreak("bc4bbfb1-0974-45a9-b286-d9fa630e337a", "uScript_Events", Relay_uScriptStart_0)) return; 
      Relay_In_2();
   }
   
   void Relay_uScriptLateStart_0()
   {
      if (true == CheckDebugBreak("bc4bbfb1-0974-45a9-b286-d9fa630e337a", "uScript_Events", Relay_uScriptLateStart_0)) return; 
   }
   
   void Relay_In_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("eb0356ff-49ba-4016-96dc-d41514f994a9", "Delay", Relay_In_2)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_Delay_uScriptAct_Delay_2.In(logic_uScriptAct_Delay_Duration_2, logic_uScriptAct_Delay_SingleFrame_2);
         logic_uScriptAct_Delay_DrivenDelay_2 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_2.AfterDelay;
         
         if ( test_0 == true )
         {
            Relay_In_3();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript _simpleBool1.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Stop_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("eb0356ff-49ba-4016-96dc-d41514f994a9", "Delay", Relay_Stop_2)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_Delay_uScriptAct_Delay_2.Stop(logic_uScriptAct_Delay_Duration_2, logic_uScriptAct_Delay_SingleFrame_2);
         logic_uScriptAct_Delay_DrivenDelay_2 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_2.AfterDelay;
         
         if ( test_0 == true )
         {
            Relay_In_3();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript _simpleBool1.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_DrivenDelay_2( )
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_Delay_DrivenDelay_2 = logic_uScriptAct_Delay_uScriptAct_Delay_2.DrivenDelay();
         if ( true == logic_uScriptAct_Delay_DrivenDelay_2 )
         {
            if ( logic_uScriptAct_Delay_uScriptAct_Delay_2.AfterDelay == true )
            {
               Relay_In_3();
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript _simpleBool1.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   void Relay_In_3()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("7ad178e0-3b5e-4f58-a7e8-2949cfb40a72", "Compare_Bool", Relay_In_3)) return; 
         {
            {
               logic_uScriptCon_CompareBool_Bool_3 = local_IsRed_System_Boolean;
               
            }
         }
         logic_uScriptCon_CompareBool_uScriptCon_CompareBool_3.In(logic_uScriptCon_CompareBool_Bool_3);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_3.True;
         bool test_1 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_3.False;
         
         if ( test_0 == true )
         {
            Relay_In_5();
         }
         if ( test_1 == true )
         {
            Relay_In_6();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript _simpleBool1.uscript at Compare Bool.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d2d2bc94-980c-4f73-99c3-43aec94eea92", "Assign_Material_Color", Relay_In_5)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_1_UnityEngine_GameObject_previous != local_1_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_1_UnityEngine_GameObject_previous = local_1_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_AssignMaterialColor_Target_5.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_AssignMaterialColor_Target_5, index + 1);
               }
               logic_uScriptAct_AssignMaterialColor_Target_5[ index++ ] = local_1_UnityEngine_GameObject;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_AssignMaterialColor_uScriptAct_AssignMaterialColor_5.In(logic_uScriptAct_AssignMaterialColor_Target_5, logic_uScriptAct_AssignMaterialColor_MatColor_5, logic_uScriptAct_AssignMaterialColor_MatChannel_5);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_AssignMaterialColor_uScriptAct_AssignMaterialColor_5.Out;
         
         if ( test_0 == true )
         {
            Relay_Toggle_7();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript _simpleBool1.uscript at Assign Material Color.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("ba314c42-60d2-4635-89ef-4d4d7a2fe577", "Assign_Material_Color", Relay_In_6)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_1_UnityEngine_GameObject_previous != local_1_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_1_UnityEngine_GameObject_previous = local_1_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_AssignMaterialColor_Target_6.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_AssignMaterialColor_Target_6, index + 1);
               }
               logic_uScriptAct_AssignMaterialColor_Target_6[ index++ ] = local_1_UnityEngine_GameObject;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_AssignMaterialColor_uScriptAct_AssignMaterialColor_6.In(logic_uScriptAct_AssignMaterialColor_Target_6, logic_uScriptAct_AssignMaterialColor_MatColor_6, logic_uScriptAct_AssignMaterialColor_MatChannel_6);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_AssignMaterialColor_uScriptAct_AssignMaterialColor_6.Out;
         
         if ( test_0 == true )
         {
            Relay_Toggle_7();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript _simpleBool1.uscript at Assign Material Color.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Toggle_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1ecbe8bb-8aae-4e6c-9239-7b1d4b5e8664", "Toggle_Bool", Relay_Toggle_7)) return; 
         {
            {
               logic_uScriptAct_ToggleBool_Target_7 = local_IsRed_System_Boolean;
               
            }
            {
            }
         }
         logic_uScriptAct_ToggleBool_uScriptAct_ToggleBool_7.Toggle(logic_uScriptAct_ToggleBool_Target_7, out logic_uScriptAct_ToggleBool_Result_7);
         local_IsRed_System_Boolean = logic_uScriptAct_ToggleBool_Result_7;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_ToggleBool_uScriptAct_ToggleBool_7.Out;
         
         if ( test_0 == true )
         {
            Relay_In_8();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript _simpleBool1.uscript at Toggle Bool.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_8()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("af8d9864-1762-4262-8105-066361cf6915", "Log", Relay_In_8)) return; 
         {
            {
            }
            {
               int index = 0;
               if ( logic_uScriptAct_Log_Target_8.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Log_Target_8, index + 1);
               }
               logic_uScriptAct_Log_Target_8[ index++ ] = local_9_System_String;
               
            }
            {
            }
         }
         logic_uScriptAct_Log_uScriptAct_Log_8.In(logic_uScriptAct_Log_Prefix_8, logic_uScriptAct_Log_Target_8, logic_uScriptAct_Log_Postfix_8);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Log_uScriptAct_Log_8.Out;
         
         if ( test_0 == true )
         {
            Relay_In_2();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript _simpleBool1.uscript at Log.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "_simpleBool1.uscript:1", local_1_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "cc8d95e9-d385-476f-929e-b711d377f730", local_1_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "_simpleBool1.uscript:IsRed", local_IsRed_System_Boolean);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "bf6a6e7b-5164-4a07-b0e5-650c0fd4ab84", local_IsRed_System_Boolean);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "_simpleBool1.uscript:9", local_9_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "966db015-ad43-42b3-866e-581e6702c7e3", local_9_System_String);
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
