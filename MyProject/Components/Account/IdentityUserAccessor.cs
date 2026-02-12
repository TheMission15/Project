using Microsoft.AspNetCore.Identity;

namespace MyProject.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<Model.Account> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<Model.Account> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
