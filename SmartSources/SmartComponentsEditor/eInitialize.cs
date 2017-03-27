﻿using Smart.Editors;
using Smart.Helpers;
using Smart.Managers;
using Smart.Setup;
using UnityEditor;

namespace Smart
{
    [InitializeOnLoad]
    public static class eInitialize
    {
        static eInitialize()
        {
            eSetup.InitializeDLLWithType<CoroutinesManager>("Components", "7eaaf8612fdab2b419c0194f0a0a1435", s =>
            {
                s.Reg<CoroutinesManager>("Managers/Coroutines", eHierarchyIcons.Priority.Higher);
                s.Reg<UpdatesManager>("Managers/Updates", eHierarchyIcons.Priority.Higher);
                s.Reg<CanvasManager>("Managers/Canvas", eHierarchyIcons.Priority.Higher);

                s.Reg<DelayHelper>("Helpers/Delay", eHierarchyIcons.Priority.Lower);
                s.Reg<EventsHelper>("Helpers/Events", eHierarchyIcons.Priority.Lower);
                s.Reg<CommandsHelper>("Helpers/Commands", eHierarchyIcons.Priority.Lower);
                s.Reg<DontDestroyHelper>("Helpers/DontDestroy", eHierarchyIcons.Priority.Lower);
                s.Reg<ToggleHelper>("Helpers/Toggle", eHierarchyIcons.Priority.Lower);
                s.Reg<MaterialHelper>("Helpers/Material", eHierarchyIcons.Priority.Lower);
                s.Reg<PopupHelper>("Helpers/Popup", eHierarchyIcons.Priority.Lower);
                s.Reg<InputFieldHelper>("Helpers/InputField", eHierarchyIcons.Priority.Lower);
                s.Reg<CollisionTriggerHelper>("Helpers/CollisionTrigger", eHierarchyIcons.Priority.Lower);
                s.Reg<TemplateHelper>("Helpers/Template", eHierarchyIcons.Priority.Lower);
                s.Reg<JointBreakHelper>("Helpers/JointBreak", eHierarchyIcons.Priority.Lower);
                s.Reg<LightLODHelper>("Helpers/LightLOD", eHierarchyIcons.Priority.Lower);                

                s.Reg<ColorLerpHelper>("Helpers/Helper", eHierarchyIcons.Priority.Lower);
                s.Reg<FloatLerpHelper>("Helpers/Helper", eHierarchyIcons.Priority.Lower);
                s.Reg<IntervalEventHelper>("Helpers/Helper", eHierarchyIcons.Priority.Lower);
                s.Reg<RotationHelper>("Helpers/Helper", eHierarchyIcons.Priority.Lower);
                s.Reg<RuntimeDebugHelper>("Helpers/Helper", eHierarchyIcons.Priority.Lower);
                s.Reg<ScrollingUVHelper>("Helpers/Helper", eHierarchyIcons.Priority.Lower);
                s.Reg<SelectOptionHelper>("Helpers/Helper", eHierarchyIcons.Priority.Lower);
                s.Reg<FollowCameraHelper>("Helpers/Helper", eHierarchyIcons.Priority.Lower);
                s.Reg<CountConditionHelper>("Helpers/Helper", eHierarchyIcons.Priority.Lower);
                s.Reg<MaterialHelper>("Helpers/Helper", eHierarchyIcons.Priority.Lower);
            }); 
        }
    }
}
