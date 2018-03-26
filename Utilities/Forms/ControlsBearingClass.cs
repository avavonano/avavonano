using System.Reflection;
using System.Windows.Forms;

namespace Utilities.Forms
{
    public abstract class ControlsBearingClass
    {
        public void Update()
        {
            PropertyInfo[] properties = GetType().GetProperties();
            foreach (var property in properties)
            {
                var ctrl = property.GetValue(this) as Control;
                ctrl?.Update();
            }
        }
    }
}
