namespace Loupedeck.VisualStudioPlugin
{
    using System;

    class TabWindows : PluginDynamicAdjustment
    {
        public TabWindows() : base("Switch Tabs", "Changes Tabs in Visual Studio", "Tools", true)
        {
        }

        protected override void ApplyAdjustment(String actionParameter, Int32 ticks)
        {
            if(ticks < 0)
            {
                this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.F6, ModifierKey.Control | ModifierKey.Shift);
            }
            else if(ticks > 0)
            {
                this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.F6, ModifierKey.Control);
            }
        }
    }
}
