using UnityEditor;
using UnityEngine.UIElements;

namespace Unity.Notifications
{
    internal class ICSettingsProvider : SettingsProvider
    {
        private ICSettingsProvider(string path, SettingsScope scopes)
            : base(path, scopes)
        {
            Initialize();
        }

        [SettingsProvider]
        static SettingsProvider CreateMobileNotificationsSettingsProvider()
        {
            return new ICSettingsProvider("Project/Internet Computer Settings", SettingsScope.Project);
        }

        public override void OnActivate(string searchContext, VisualElement rootElement)
        {
            base.OnActivate(searchContext, rootElement);
        }

        public override void OnDeactivate()
        {
            base.OnDeactivate();
        }

        private void Initialize()
        {
            label = "Internet Computer Settings";
        }

        public override void OnGUI(string searchContext)
        {
        }
    }
}