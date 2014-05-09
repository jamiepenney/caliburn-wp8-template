using System;
using System.Collections.Generic;
using Caliburn.Micro;
using Microsoft.Phone.Controls;
using $safeprojectname$.ViewModels;

namespace $safeprojectname$
{
    public class Bootstrapper : PhoneBootstrapper
    {
        PhoneContainer container;

        protected override void Configure()
        {
            if (RootFrame == null)
                return;

            container = new PhoneContainer();

            container.RegisterPhoneServices(RootFrame);

            // View Models
            container.PerRequest<MainViewModel>();

            // Services

            AddCustomConventions();
        }

        static void AddCustomConventions()
        {
            ConventionManager.AddElementConvention<LongListSelector>(LongListSelector.ItemsSourceProperty, "SelectedItem", "SelectionChanged");
        }

        protected override object GetInstance(Type service, string key)
        {
            return container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            container.BuildUp(instance);
        }
    }
}