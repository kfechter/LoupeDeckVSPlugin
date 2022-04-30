namespace Loupedeck.VisualStudioPlugin
{
    using System;

    public class VisualStudioApplication : ClientApplication
    {
        public VisualStudioApplication()
        {

        }

        protected override String GetProcessName() => "devenv.exe";

        protected override String GetBundleName() => "";
    }
}