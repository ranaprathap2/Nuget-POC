﻿#pragma checksum "D:\POC\CommonLibPOC\NugetPOC\Stackoverflow sample\Components\AvatarView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "732F46B8498F8E7E379C7AAFADAA0C34D5509B1B3680CF7A5133C321775928F2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Components
{
    partial class AvatarView : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_FrameworkElement_Width(global::Windows.UI.Xaml.FrameworkElement obj, global::System.Double value)
            {
                obj.Width = value;
            }
            public static void Set_Windows_UI_Xaml_FrameworkElement_Height(global::Windows.UI.Xaml.FrameworkElement obj, global::System.Double value)
            {
                obj.Height = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class AvatarView_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IAvatarView_Bindings
        {
            private global::Components.AvatarView dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Grid obj2;

            private AvatarView_obj1_BindingsTracking bindingsTracking;

            public AvatarView_obj1_Bindings()
            {
                this.bindingsTracking = new AvatarView_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // AvatarView.xaml line 12
                        this.obj2 = (global::Windows.UI.Xaml.Controls.Grid)target;
                        break;
                    default:
                        break;
                }
            }

            // IAvatarView_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Components.AvatarView)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Components.AvatarView obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Width(obj.Width, phase);
                        this.Update_Height(obj.Height, phase);
                    }
                }
            }
            private void Update_Width(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // AvatarView.xaml line 12
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Width(this.obj2, obj);
                }
            }
            private void Update_Height(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // AvatarView.xaml line 12
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Height(this.obj2, obj);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class AvatarView_obj1_BindingsTracking
            {
                private global::System.WeakReference<AvatarView_obj1_Bindings> weakRefToBindingObj; 

                public AvatarView_obj1_BindingsTracking(AvatarView_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<AvatarView_obj1_Bindings>(obj);
                }

                public AvatarView_obj1_Bindings TryGetBindingObject()
                {
                    AvatarView_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void DependencyPropertyChanged_Width(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    AvatarView_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Components.AvatarView obj = sender as global::Components.AvatarView;
                        if (obj != null)
                        {
                            bindings.Update_Width(obj.Width, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_Height(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    AvatarView_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Components.AvatarView obj = sender as global::Components.AvatarView;
                        if (obj != null)
                        {
                            bindings.Update_Height(obj.Height, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_Width = 0;
                private long tokenDPC_Height = 0;
                public void UpdateChildListeners_(global::Components.AvatarView obj)
                {
                    AvatarView_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.FrameworkElement.WidthProperty, tokenDPC_Width);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.FrameworkElement.HeightProperty, tokenDPC_Height);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_Width = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.FrameworkElement.WidthProperty, DependencyPropertyChanged_Width);
                            tokenDPC_Height = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.FrameworkElement.HeightProperty, DependencyPropertyChanged_Height);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // AvatarView.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    AvatarView_obj1_Bindings bindings = new AvatarView_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

