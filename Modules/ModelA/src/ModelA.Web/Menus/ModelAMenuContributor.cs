using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace ModelA.Web.Menus;

public class ModelAMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(ModelAMenus.Prefix, displayName: "ModelA", "~/ModelA", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
