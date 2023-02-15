using System;
using System.Collections.Generic;
using System.Text;
using Mainapp.Localization;
using Volo.Abp.Application.Services;

namespace Mainapp;

/* Inherit your application services from this class.
 */
public abstract class MainappAppService : ApplicationService
{
    protected MainappAppService()
    {
        LocalizationResource = typeof(MainappResource);
    }
}
