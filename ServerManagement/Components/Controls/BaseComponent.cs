using Microsoft.AspNetCore.Components;

namespace ServerManagement.Components.Controls
{
    public class BaseComponent : ComponentBase
    {
        protected bool isFirstRender { get; set; } = true;

        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);

            isFirstRender = firstRender;
        }

    }
}
