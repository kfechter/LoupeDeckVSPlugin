namespace Loupedeck.VisualStudioPlugin
{
    using System;

    public class VisualStudioApplication : ClientApplication
    {
        public VisualStudioApplication()
        {

        }

        protected override String GetProcessName() => "Microsoft Visual Studio 2022";

        protected override String GetBundleName() => "";
    }
}