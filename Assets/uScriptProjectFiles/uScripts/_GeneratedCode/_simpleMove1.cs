//uScript Generated Code - Build 1.0.3077
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class _simpleMove1 : uScriptLogic
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
   UnityEngine.GameObject local_4_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_4_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_8_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_8_UnityEngine_GameObject_previous = null;
   System.Single local_MoveSpeed_System_Single = (float) 0.1;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_ControlGameObjectMove logic_uScriptAct_ControlGameObjectMove_uScriptAct_ControlGameObjectMove_1 = new uScriptAct_ControlGameObjectMove( );
   UnityEngine.GameObject logic_uScriptAct_ControlGameObjectMove_Target_1 = default(UnityEngine.GameObject);
   uScriptAct_ControlGameObjectMove.Direction logic_uScriptAct_ControlGameObjectMove_moveDirection_1 = uScriptAct_ControlGameObjectMove.Direction.Right;
   System.Single logic_uScriptAct_ControlGameObjectMove_Speed_1 = (float) 0;
   System.Boolean logic_uScriptAct_ControlGameObjectMove_useLocal_1 = (bool) false;
   bool logic_uScriptAct_ControlGameObjectMove_Out_1 = true;
   //pointer to script instanced logic node
   uScriptAct_SetFloat logic_uScriptAct_SetFloat_uScriptAct_SetFloat_5 = new uScriptAct_SetFloat( );
   System.Single logic_uScriptAct_SetFloat_Value_5 = (float) 0.1;
   System.Single logic_uScriptAct_SetFloat_Target_5;
   bool logic_uScriptAct_SetFloat_Out_5 = true;
   //pointer to script instanced logic node
   uScriptAct_SetFloat logic_uScriptAct_SetFloat_uScriptAct_SetFloat_6 = new uScriptAct_SetFloat( );
   System.Single logic_uScriptAct_SetFloat_Value_6 = (float) 0.05;
   System.Single logic_uScriptAct_SetFloat_Target_6;
   bool logic_uScriptAct_SetFloat_Out_6 = true;
   //pointer to script instanced logic node
   uScriptAct_ControlGameObjectMove logic_uScriptAct_ControlGameObjectMove_uScriptAct_ControlGameObjectMove_7 = new uScriptAct_ControlGameObjectMove( );
   UnityEngine.GameObject logic_uScriptAct_ControlGameObjectMove_Target_7 = default(UnityEngine.GameObject);
   uScriptAct_ControlGameObjectMove.Direction logic_uScriptAct_ControlGameObjectMove_moveDirection_7 = uScriptAct_ControlGameObjectMove.Direction.Right;
   System.Single logic_uScriptAct_ControlGameObjectMove_Speed_7 = (float) 0.1;
   System.Boolean logic_uScriptAct_ControlGameObjectMove_useLocal_7 = (bool) false;
   bool logic_uScriptAct_ControlGameObjectMove_Out_7 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareGameObjects logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_9 = new uScriptCon_CompareGameObjects( );
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_A_9 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_B_9 = default(UnityEngine.GameObject);
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByTag_9 = (bool) false;
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByName_9 = (bool) false;
   System.Boolean logic_uScriptCon_CompareGameObjects_ReportNull_9 = (bool) true;
   bool logic_uScriptCon_CompareGameObjects_Same_9 = true;
   bool logic_uScriptCon_CompareGameObjects_Different_9 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareGameObjects logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_10 = new uScriptCon_CompareGameObjects( );
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_A_10 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_B_10 = default(UnityEngine.GameObject);
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByTag_10 = (bool) false;
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByName_10 = (bool) false;
   System.Boolean logic_uScriptCon_CompareGameObjects_ReportNull_10 = (bool) true;
   bool logic_uScriptCon_CompareGameObjects_Same_10 = true;
   bool logic_uScriptCon_CompareGameObjects_Different_10 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_0 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_3 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_3 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == logic_uScriptAct_ControlGameObjectMove_Target_7 || false == m_RegisteredForEvents )
      {
         logic_uScriptAct_ControlGameObjectMove_Target_7 = GameObject.Find( "/FakeSphere" ) as UnityEngine.GameObject;
      }
      if ( null == local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_4_UnityEngine_GameObject = GameObject.Find( "Sphere" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_8_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_8_UnityEngine_GameObject = GameObject.Find( "Sphere" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_8_UnityEngine_GameObject_previous != local_8_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_8_UnityEngine_GameObject_previous = local_8_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_8_UnityEngine_GameObject_previous != local_8_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_8_UnityEngine_GameObject_previous = local_8_UnityEngine_GameObject;
         
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
      if ( null == event_UnityEngine_GameObject_Instance_3 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_3 = GameObject.Find( "NewSlowZone" ) as UnityEngine.GameObject;
         if ( null != event_UnityEngine_GameObject_Instance_3 )
         {
            {
               uScript_Trigger component = event_UnityEngine_GameObject_Instance_3.GetComponent<uScript_Trigger>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_3.AddComponent<uScript_Trigger>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_3;
                  component.OnExitTrigger += Instance_OnExitTrigger_3;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_3;
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
      if ( null != event_UnityEngine_GameObject_Instance_3 )
      {
         {
            uScript_Trigger component = event_UnityEngine_GameObject_Instance_3.GetComponent<uScript_Trigger>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_3;
               component.OnExitTrigger -= Instance_OnExitTrigger_3;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_3;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_ControlGameObjectMove_uScriptAct_ControlGameObjectMove_1.SetParent(g);
      logic_uScriptAct_SetFloat_uScriptAct_SetFloat_5.SetParent(g);
      logic_uScriptAct_SetFloat_uScriptAct_SetFloat_6.SetParent(g);
      logic_uScriptAct_ControlGameObjectMove_uScriptAct_ControlGameObjectMove_7.SetParent(g);
      logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_9.SetParent(g);
      logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_10.SetParent(g);
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
      
   }
   
   public void OnDestroy()
   {
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
   
   void Instance_OnEnterTrigger_3(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_3 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_3( );
   }
   
   void Instance_OnExitTrigger_3(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_3 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_3( );
   }
   
   void Instance_WhileInsideTrigger_3(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_3 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_3( );
   }
   
   void Relay_OnUpdate_0()
   {
      if (true == CheckDebugBreak("84944943-5f97-4d0a-a668-f2ad58b72158", "Global_Update", Relay_OnUpdate_0)) return; 
      Relay_In_1();
      Relay_In_7();
   }
   
   void Relay_OnLateUpdate_0()
   {
      if (true == CheckDebugBreak("84944943-5f97-4d0a-a668-f2ad58b72158", "Global_Update", Relay_OnLateUpdate_0)) return; 
   }
   
   void Relay_OnFixedUpdate_0()
   {
      if (true == CheckDebugBreak("84944943-5f97-4d0a-a668-f2ad58b72158", "Global_Update", Relay_OnFixedUpdate_0)) return; 
   }
   
   void Relay_In_1()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("4dff5ad2-0219-4b70-8865-588257d26562", "Control_GameObject__Move_", Relay_In_1)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_8_UnityEngine_GameObject_previous != local_8_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_8_UnityEngine_GameObject_previous = local_8_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptAct_ControlGameObjectMove_Target_1 = local_8_UnityEngine_GameObject;
               
            }
            {
            }
            {
               logic_uScriptAct_ControlGameObjectMove_Speed_1 = local_MoveSpeed_System_Single;
               
            }
            {
            }
         }
         logic_uScriptAct_ControlGameObjectMove_uScriptAct_ControlGameObjectMove_1.In(logic_uScriptAct_ControlGameObjectMove_Target_1, logic_uScriptAct_ControlGameObjectMove_moveDirection_1, logic_uScriptAct_ControlGameObjectMove_Speed_1, logic_uScriptAct_ControlGameObjectMove_useLocal_1);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript _simpleMove1.uscript at Control GameObject (Move).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnEnterTrigger_3()
   {
      if (true == CheckDebugBreak("f644ce45-a1e4-4870-b1af-cd034db36cef", "Trigger_Event", Relay_OnEnterTrigger_3)) return; 
      local_4_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_3;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      Relay_In_9();
   }
   
   void Relay_OnExitTrigger_3()
   {
      if (true == CheckDebugBreak("f644ce45-a1e4-4870-b1af-cd034db36cef", "Trigger_Event", Relay_OnExitTrigger_3)) return; 
      local_4_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_3;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      Relay_In_10();
   }
   
   void Relay_WhileInsideTrigger_3()
   {
      if (true == CheckDebugBreak("f644ce45-a1e4-4870-b1af-cd034db36cef", "Trigger_Event", Relay_WhileInsideTrigger_3)) return; 
      local_4_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_3;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
   }
   
   void Relay_In_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("ff7ad12e-d9db-4a3e-a2d3-c2152d89a4bf", "Set_Float", Relay_In_5)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_SetFloat_uScriptAct_SetFloat_5.In(logic_uScriptAct_SetFloat_Value_5, out logic_uScriptAct_SetFloat_Target_5);
         local_MoveSpeed_System_Single = logic_uScriptAct_SetFloat_Target_5;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript _simpleMove1.uscript at Set Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("fa494381-cad2-4b9e-a676-b168eb009be6", "Set_Float", Relay_In_6)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_SetFloat_uScriptAct_SetFloat_6.In(logic_uScriptAct_SetFloat_Value_6, out logic_uScriptAct_SetFloat_Target_6);
         local_MoveSpeed_System_Single = logic_uScriptAct_SetFloat_Target_6;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript _simpleMove1.uscript at Set Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("6cef4d56-133a-4e9f-be34-d71281796219", "Control_GameObject__Move_", Relay_In_7)) return; 
         {
            {
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_ControlGameObjectMove_uScriptAct_ControlGameObjectMove_7.In(logic_uScriptAct_ControlGameObjectMove_Target_7, logic_uScriptAct_ControlGameObjectMove_moveDirection_7, logic_uScriptAct_ControlGameObjectMove_Speed_7, logic_uScriptAct_ControlGameObjectMove_useLocal_7);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript _simpleMove1.uscript at Control GameObject (Move).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_9()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("3e02f2e6-42f3-4a40-80ce-4898dba41e2f", "Compare_GameObjects", Relay_In_9)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptCon_CompareGameObjects_A_9 = local_4_UnityEngine_GameObject;
               
            }
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_8_UnityEngine_GameObject_previous != local_8_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_8_UnityEngine_GameObject_previous = local_8_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptCon_CompareGameObjects_B_9 = local_8_UnityEngine_GameObject;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_9.In(logic_uScriptCon_CompareGameObjects_A_9, logic_uScriptCon_CompareGameObjects_B_9, logic_uScriptCon_CompareGameObjects_CompareByTag_9, logic_uScriptCon_CompareGameObjects_CompareByName_9, logic_uScriptCon_CompareGameObjects_ReportNull_9);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_9.Same;
         
         if ( test_0 == true )
         {
            Relay_In_6();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript _simpleMove1.uscript at Compare GameObjects.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_10()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("ee1b7287-b663-4436-922d-05f2dd6c73eb", "Compare_GameObjects", Relay_In_10)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptCon_CompareGameObjects_A_10 = local_4_UnityEngine_GameObject;
               
            }
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_8_UnityEngine_GameObject_previous != local_8_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_8_UnityEngine_GameObject_previous = local_8_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptCon_CompareGameObjects_B_10 = local_8_UnityEngine_GameObject;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_10.In(logic_uScriptCon_CompareGameObjects_A_10, logic_uScriptCon_CompareGameObjects_B_10, logic_uScriptCon_CompareGameObjects_CompareByTag_10, logic_uScriptCon_CompareGameObjects_CompareByName_10, logic_uScriptCon_CompareGameObjects_ReportNull_10);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_10.Different;
         
         if ( test_0 == true )
         {
            Relay_In_5();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript _simpleMove1.uscript at Compare GameObjects.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "_simpleMove1.uscript:MoveSpeed", local_MoveSpeed_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "e87d952f-3c04-497e-8036-92fed6bb38ee", local_MoveSpeed_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "_simpleMove1.uscript:4", local_4_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "f0f9e6b1-a4ef-4c95-9dd8-2e31de1d17f5", local_4_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "_simpleMove1.uscript:8", local_8_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "cb0fbd80-b484-454d-9d89-3c919cb41413", local_8_UnityEngine_GameObject);
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
